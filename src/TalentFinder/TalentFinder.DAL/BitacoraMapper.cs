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
	public class BitacoraMapper
	{
		public int RegistrarEntrada(Bitacora bitacora)
		{
			int f = 0;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			try
			{
				List<SqlParameter> parametros = new List<SqlParameter>();
				parametros.Add(da.CrearParametro("@FechaCreacion", bitacora.FechaCreacion));
				parametros.Add(da.CrearParametro("@UsuarioId", bitacora.Usuario.Id));
				parametros.Add(da.CrearParametro("@TipoEventoId", bitacora.TipoEvento.Id));
				parametros.Add(da.CrearParametro("@Descripcion", bitacora.Descripcion));
				f = da.Escribir("RegistrarEntrada", parametros);
			}
			catch(Exception ex)
			{
				f = -1;
			}
			da.Cerrar();
			return f;
		}
		public List<Bitacora> GetBitacoraEventos(Usuario usuario, TipoEvento TipoEvento, DateTime? FechaDesde, DateTime? FechaHasta)
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
				lista.Add(bitacora);
			}
			return lista;
		}

		public List<TipoEvento> GetBitacoraTipoEventos()
		{
			List<TipoEvento> lista = new List<TipoEvento>();
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
			return lista;
		}
	}
}
