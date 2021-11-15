using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;
using Newtonsoft.Json;
using System.Configuration;

namespace TalentFinder.DAL
{
	/// <summary>
	/// Entidad de negocio para gestionar la bitacora del sistema
	/// </summary>
	public class BitacoraMapper
	{
		private string JsonFileName = "bitacora.js";
		private string JsonFilePath;

		/// <summary>
		/// Método para registrar una entreda en el base de datos del sistema
		/// </summary>
		/// <param name="bitacora">Una bitacora</param>
		public void RegistrarEntradaSql(Bitacora bitacora)
		{
			DataAccessManager da = new DataAccessManager();
			try
			{
				da.Abrir();
				List<SqlParameter> parametros = new List<SqlParameter>();
				parametros.Add(da.CrearParametro("@FechaCreacion", bitacora.FechaCreacion));
				parametros.Add(da.CrearParametro("@UsuarioId", bitacora.Usuario.Id));
				parametros.Add(da.CrearParametro("@TipoEventoId", bitacora.TipoEvento.Id));
				parametros.Add(da.CrearParametro("@Descripcion", bitacora.Descripcion));
				da.Escribir("RegistrarEntrada", parametros);
			}
			catch(Exception ex)
			{
				throw new DALException(ex.Message, ex);
			}
			finally
			{
				da.Cerrar();
			}
		}

		/// <summary>
		/// Método para serializar una entrada en el sistema
		/// </summary>
		/// <param name="bitacora">Una bitacora</param>
		public void RegistrarEntradaJson(Bitacora bitacora)
		{
			try
			{
				FileStream archivo = new FileStream(Path.Combine(JsonFilePath, JsonFileName), FileMode.Append);
				StreamWriter escritor = new StreamWriter(archivo);
				string linea = JsonConvert.SerializeObject(bitacora);
				escritor.WriteLine(linea);
				escritor.Close();
				archivo.Close();
			}
			catch(Exception ex)
			{
				throw new DALException(ex.Message, ex);
			}
		}

		/// <summary>
		/// Método que obtiene los eventos del sistama registrados en la bitácora
		/// por criterio de búsqueda
		/// </summary>
		/// <param name="usuario">El autor del evento generado en el sistema</param>
		/// <param name="TipoEvento">El tipo de evento generado en el sistema</param>
		/// <param name="FechaDesde">La fecha desde</param>
		/// <param name="FechaHasta">La fecha hasta</param>
		/// <returns>Lista de eventos generados en el sistema</returns>
		public List<Bitacora> GetBitacoraEventos(Usuario usuario, TipoEvento TipoEvento, DateTime? FechaDesde, DateTime? FechaHasta)
		{
			List<Bitacora> lista = new List<Bitacora>();
			try
			{
				List<Bitacora> lista1 = GetBitacoraEventosFromSql(usuario, TipoEvento, FechaDesde, FechaHasta);
				lista.AddRange(lista1);
				List<Bitacora> lista2 = GetBitacoraEventosFromJson(usuario, TipoEvento, FechaDesde, FechaHasta);
				if(lista2 != null)
					lista.AddRange(lista2);
			}
			catch(Exception ex)
			{
				lista = null;
				throw new DALException(ex.Message, ex);
			}
			return lista.OrderByDescending(x => x.FechaCreacion).ToList();
		}

		/// <summary>
		/// Método que obtiene los eventos de la base de datos del sistama registrados en la bitácora
		/// por criterio de búsqueda
		/// </summary>
		/// <param name="usuario">El autor del evento generado en el sistema</param>
		/// <param name="TipoEvento">El tipo de evento generado en el sistema</param>
		/// <param name="FechaDesde">La fecha desde</param>
		/// <param name="FechaHasta">La fecha hasta</param>
		/// <returns>Lista de eventos generados en el sistema</returns>
		public List<Bitacora> GetBitacoraEventosFromSql(Usuario usuario, TipoEvento TipoEvento, DateTime? FechaDesde, DateTime? FechaHasta)
		{
			List<Bitacora> lista = new List<Bitacora>();
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			if(usuario.Id != 0)
				parametros.Add(da.CrearParametro("@UsuarioId", usuario.Id));
			if(TipoEvento.Id != 0)
				parametros.Add(da.CrearParametro("@TipoEventoId", TipoEvento.Id));
			if(FechaDesde != null)
				parametros.Add(da.CrearParametro("@FechaDesde", FechaDesde.Value.ToString("yyyy/MM/dd")));
			if(FechaHasta != null)
				parametros.Add(da.CrearParametro("@FechaHasta", FechaHasta.Value.ToString("yyyy/MM/dd")));
			DataTable tabla = da.Leer("GetBitacoraEventos", parametros);
			da.Cerrar();

			foreach(DataRow fila in tabla.Rows)
			{
				Bitacora bitacora = new Bitacora();
				bitacora.Id = int.Parse(fila["Id"].ToString());
				bitacora.FechaCreacion = DateTime.Parse(fila["FechaCreacion"].ToString());
				Usuario user = new Usuario();
				user.Id = int.Parse(fila["UsuarioId"].ToString());
				user.UserName = fila["UserName"].ToString();
				bitacora.Usuario = user;
				TipoEvento tipoEvento = new TipoEvento();
				tipoEvento.Id = int.Parse(fila["TipoEventoId"].ToString());
				tipoEvento.Nombre = fila["TipoEvento"].ToString();
				bitacora.TipoEvento = tipoEvento;
				bitacora.Descripcion = fila["Descripcion"].ToString();
				lista.Add(bitacora);
			}

			return lista;
		}

		/// <summary>
		/// Método que obtiene los eventos serializados en formato json del sistama registrados en la bitácora
		/// por criterio de búsqueda
		/// </summary>
		/// <param name="usuario">El autor del evento generado en el sistema</param>
		/// <param name="TipoEvento">El tipo de evento generado en el sistema</param>
		/// <param name="FechaDesde">La fecha desde</param>
		/// <param name="FechaHasta">La fecha hasta</param>
		/// <returns>Lista de eventos generados en el sistema</returns>
		public List<Bitacora> GetBitacoraEventosFromJson(Usuario usuario, TipoEvento TipoEvento, DateTime? FechaDesde, DateTime? FechaHasta)
		{
			List<Bitacora> lista = new List<Bitacora>();

			if(!File.Exists(Path.Combine(JsonFilePath, JsonFileName)))
				return null;

			FileStream archivo = new FileStream(Path.Combine(JsonFilePath, JsonFileName), FileMode.Open);
			StreamReader lector = new StreamReader(archivo);
			string linea;

			while((linea = lector.ReadLine()) != null)
			{
				Bitacora bitacora = JsonConvert.DeserializeObject<Bitacora>(linea);
				lista.Add(bitacora);
			}
			lector.Close();
			archivo.Close();

			if(usuario != null && usuario.Id != 0)
				lista = lista.Where(x => x.Usuario.Id == usuario.Id).ToList();

			if(TipoEvento != null && TipoEvento.Id != 0)
				lista = lista.Where(x => x.TipoEvento.Id == TipoEvento.Id).ToList();

			if(FechaDesde.HasValue)
				lista = lista.Where(x => x.FechaCreacion >= FechaDesde.Value).ToList();

			if(FechaHasta.HasValue)
				lista = lista.Where(x => x.FechaCreacion <= FechaHasta.Value).ToList();

			return lista;
		}

		/// <summary>
		/// Método para obtener los tipos eventos del sistema
		/// </summary>
		/// <returns>Lista de tipo de eventos</returns>
		public List<TipoEvento> GetBitacoraTipoEventos()
		{
			List<TipoEvento> lista = new List<TipoEvento>();
			try
			{
				DataAccessManager da = new DataAccessManager();
				da.Abrir();
				DataTable tabla = da.Leer("GetBitacoraTipoEventos", null);
				da.Cerrar();
				foreach(DataRow fila in tabla.Rows)
				{
					TipoEvento tipoEvento = new TipoEvento();
					tipoEvento.Id = int.Parse(fila["Id"].ToString());
					tipoEvento.Nombre = fila["Nombre"].ToString();
					lista.Add(tipoEvento);
				}
			}
			catch(Exception ex)
			{
				lista = null;
				throw new DALException(ex.Message, ex);
			}
			return lista;
		}

		/// <summary>
		/// Método para obtener el tipo de evento de la bitácora por id
		/// </summary>
		/// <param name="id">Un id</param>
		/// <returns>Un tipo de evento</returns>
		public TipoEvento GetBitacoraTipoEvento(int id)
		{
			TipoEvento tipoEvento = null;
			try
			{
				DataAccessManager da = new DataAccessManager();
				da.Abrir();
				List<SqlParameter> parametros = new List<SqlParameter>();
				parametros.Add(da.CrearParametro("@Id", id));
				DataTable tabla = da.Leer("GetBitacoraTipoEvento", parametros);
				da.Cerrar();
				foreach(DataRow fila in tabla.Rows)
				{
					tipoEvento = new TipoEvento();
					tipoEvento.Id = int.Parse(fila["Id"].ToString());
					tipoEvento.Nombre = fila["Nombre"].ToString();
				}
			}
			catch(Exception ex)
			{
				throw new DALException(ex.Message, ex);
			}
			return tipoEvento;
		}

		/// <summary>
		/// Método para crear la carpeta donde se guardarn los json de la bitacora
		/// </summary>
		/// <param name="path">Path del archivo json</param>
		private void CrearCarpetaBitacora(string path)
		{
			if(!Directory.Exists(path))
				Directory.CreateDirectory(path);
		}

		public BitacoraMapper()
		{
			JsonFilePath = Environment.ExpandEnvironmentVariables(ConfigurationManager.AppSettings["BitacoraPath"].ToString());
			CrearCarpetaBitacora(JsonFilePath);
		}
	}
}
