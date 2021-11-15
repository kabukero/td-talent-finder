using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;

namespace TalentFinder.DAL
{
	/// <summary>
	/// Entidad de negocio para gestionar los profesionales del sistema
	/// </summary>
	public class ProfesionalMapper
	{
		/// <summary>
		/// Método para obtener el profesional asociado a un usuario
		/// </summary>
		/// <param name="usuario">Un usuario</param>
		/// <returns>Un profesional encontrado</returns>
		public Profesional GetProfesional(Usuario usuario)
		{
			Profesional profesional = null;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@UsuarioId", usuario.Id));
			DataTable tabla = da.Leer("GetProfesional", parametros);
			if(tabla.Rows.Count > 0)
			{
				DataRow registro = tabla.Rows[0];
				profesional = new Profesional();
				profesional.Id = int.Parse(registro["Id"].ToString());
				profesional.Nombre = registro["Nombre"].ToString();
				profesional.Apellido = registro["Apellido"].ToString();
				profesional.Email = registro["Email"].ToString();
			}
			da.Cerrar();
			return profesional;
		}

		/// <summary>
		/// Método para obtener las postulaciones de un profesional
		/// </summary>
		/// <param name="Profesional">Un profesional</param>
		/// <returns>Lista de postulaciones de un profesional</returns>
		public IList<Postulacion> GetPostulaciones(Profesional Profesional)
		{
			IList<Postulacion> postulacions = new List<Postulacion>();
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@ProfesionalId", Profesional.Id));
			DataTable tabla = da.Leer("GetPostulaciones", parametros);
			da.Cerrar();

			foreach(DataRow fila in tabla.Rows)
			{
				AvisoLaboral avisoLaboral = new AvisoLaboral();
				Postulacion postulacion = new Postulacion();
				PostulacionEstado PostulacionEstado = new PostulacionEstado();
				postulacion.Id = int.Parse(fila["Id"].ToString());
				postulacion.FechaCreacion = DateTime.Parse(fila["FechaCreacion"].ToString());
				avisoLaboral.Id = int.Parse(fila["AvisoLaboralId"].ToString());
				avisoLaboral.Descripcion = fila["Descripcion"].ToString();
				avisoLaboral.LugarTrabajo = fila["LugarTrabajo"].ToString();
				avisoLaboral.FechaVencimiento = DateTime.Parse(fila["FechaVencimiento"].ToString());
				avisoLaboral.FechaVigencia = DateTime.Parse(fila["FechaVigencia"].ToString());
				PostulacionEstado.Id = int.Parse(fila["PostulacionEstadoId"].ToString());
				PostulacionEstado.Nombre = fila["Nombre"].ToString();
				postulacion.AvisoLaboral = avisoLaboral;
				postulacion.PostulacionEstado = PostulacionEstado;
				postulacions.Add(postulacion);
			}
			return postulacions;
		}

		/// <summary>
		/// Método para obtener las evaluaciones de las postulaciones
		/// </summary>
		/// <param name="Postulacion">Una postulación</param>
		/// <returns>Una postulación evaluación</returns>
		public PostulacionEvaluacion GetPostulacionEvaluacion(Postulacion Postulacion)
		{
			PostulacionEvaluacion postulacion = null;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@PostulacionId", Postulacion.Id));
			DataTable tabla = da.Leer("GetPostulacionEvaluacion", parametros);
			if(tabla.Rows.Count > 0)
			{

				DataRow registro = tabla.Rows[0];
				Evaluacion evaluacion = new Evaluacion();
				postulacion = new PostulacionEvaluacion();
				postulacion.Id = int.Parse(registro["Id"].ToString());
				postulacion.FechaCreacion = DateTime.Parse(registro["FechaCreacion"].ToString());
				postulacion.Aprobo = bool.Parse(registro["Aprobo"].ToString());
				evaluacion.Id = int.Parse(registro["EvaluacionId"].ToString());
				evaluacion.Descripcion = registro["Descripcion"].ToString();
				evaluacion.Ejercicio = registro["Ejercicio"].ToString();
				evaluacion.CodigoFuenteTest = registro["CodigoFuenteTest"].ToString();
				evaluacion.Tiempo = registro["Tiempo"].ToString();
				postulacion.Evaluacion = evaluacion;
			}
			da.Cerrar();
			return postulacion;
		}

		/// <summary>
		/// Método para verificar si un profesional se postulo a un aviso laboral
		/// </summary>
		/// <param name="avisoLaboral">Un aviso laboral</param>
		/// <returns>Resultado de la validación</returns>
		public int YaSePostulo(AvisoLaboral avisoLaboral)
		{
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@AvisoLaboralId", avisoLaboral.Id));
			int f = da.LeerEscalar("ExistePostulacion", parametros);
			da.Cerrar();
			return f;
		}

		/// <summary>
		/// Método el estado a una postulación
		/// </summary>
		/// <param name="postulacion">Una postulación</param>
		/// <param name="postulacionEvalucion">Una postulación evaluación</param>
		public void CambiarEstadoPostulacion(Postulacion postulacion, PostulacionEvaluacion postulacionEvalucion)
		{
			DataAccessManager da = new DataAccessManager();
			try
			{
				da.Abrir();
				da.IniciarTx();
				List<SqlParameter> parametros = new List<SqlParameter>();
				parametros.Add(da.CrearParametro("@Id", postulacion.Id));
				parametros.Add(da.CrearParametro("@PostulacionEstadoId", postulacion.PostulacionEstado.Id));
				da.Escribir("CambiarEstadoPostulacion", parametros);
				parametros.Clear();
				parametros.Add(da.CrearParametro("@Id", postulacionEvalucion.Id));
				parametros.Add(da.CrearParametro("@Respuesta", postulacionEvalucion.Respuesta));
				parametros.Add(da.CrearParametro("@TiempoResolucionEvaluacion", postulacionEvalucion.TiempoResolucionEvaluacion));
				parametros.Add(da.CrearParametro("@Aprobo", postulacionEvalucion.Aprobo ? 1 : 0));
				da.Escribir("CambiarResultadoEvaluacion", parametros);
				da.ConfirmarTx();
			}
			catch(Exception ex)
			{
				da.CancelarTx();
				throw;
			}
			da.Cerrar();
		}

		/// <summary>
		/// Método para postularse a un aviso laboral
		/// </summary>
		/// <param name="postulacion">Una postulación</param>
		public void Postularse(Postulacion postulacion)
		{
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@FechaCreacion", postulacion.FechaCreacion));
			parametros.Add(da.CrearParametro("@ProfesionalId", postulacion.Profesional.Id));
			parametros.Add(da.CrearParametro("@AvisoLaboralId", postulacion.AvisoLaboral.Id));
			parametros.Add(da.CrearParametro("@PostulacionEstadoId", postulacion.PostulacionEstado.Id));
			da.Escribir("Postularse", parametros);
			da.Cerrar();
		}
	}
}
