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

namespace TalentFinder.DAL
{
	public class BitacoraMapper
	{
		private string JsonFileName = "bitacora.js";
		private string JsonFilePath;
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
		public void RegistrarEntradaJson(Bitacora bitacora)
		{
			try
			{
				FileStream archivo = new FileStream(JsonFilePath, FileMode.Append);
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
			return lista;
		}
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
		public List<Bitacora> GetBitacoraEventosFromJson(Usuario usuario, TipoEvento TipoEvento, DateTime? FechaDesde, DateTime? FechaHasta)
		{
			List<Bitacora> lista = new List<Bitacora>();

			if(!File.Exists(JsonFilePath))
				return null;

			FileStream archivo = new FileStream(JsonFilePath, FileMode.Open);
			StreamReader lector = new StreamReader(archivo);
			string linea;

			while((linea = lector.ReadLine()) != null)
			{
				Bitacora bitacora = JsonConvert.DeserializeObject<Bitacora>(linea);
				lista.Add(bitacora);
			}
			lector.Close();
			archivo.Close();

			lista = lista.Where(x => (usuario == null || x.Usuario.Id == usuario.Id) &&
								(TipoEvento == null || x.TipoEvento.Id == TipoEvento.Id) &&
								(!FechaDesde.HasValue || x.FechaCreacion >= FechaDesde.Value) &&
								(!FechaHasta.HasValue || x.FechaCreacion <= FechaHasta.Value))
								.ToList();
			return lista;
		}
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
		public BitacoraMapper()
		{
			JsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, JsonFileName);
		}
	}
}
