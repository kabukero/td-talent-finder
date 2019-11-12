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
	public class ProfesionalMapper
	{
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

		public PostulacionEvalucion GetPostulacionEvaluacion(Postulacion Postulacion)
		{
			PostulacionEvalucion postulacion = null;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@PostulacionId", Postulacion.Id));
			DataTable tabla = da.Leer("GetPostulacionEvaluacion", parametros);
			if(tabla.Rows.Count > 0)
			{

				DataRow registro = tabla.Rows[0];
				Evaluacion evaluacion = new Evaluacion();
				postulacion = new PostulacionEvalucion();
				postulacion.Id = int.Parse(registro["Id"].ToString());
				postulacion.FechaCreacion = DateTime.Parse(registro["FechaCreacion"].ToString());
				postulacion.Aprobo = bool.Parse(registro["Aprobo"].ToString());
				evaluacion.Id = int.Parse(registro["EvaluacionId"].ToString());
				evaluacion.Descripcion = registro["Descripcion"].ToString();
				evaluacion.Ejercicio = registro["Ejercicio"].ToString();
				evaluacion.Tiempo = registro["Tiempo"].ToString();
				postulacion.Evaluacion = evaluacion;
			}
			da.Cerrar();
			return postulacion;
		}
	}
}
