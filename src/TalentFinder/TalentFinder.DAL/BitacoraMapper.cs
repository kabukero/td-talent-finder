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
		public List<Bitacora> GetAll(TipoEvento TipoEvento, DateTime? FechaDesde, DateTime? FechaHasta)
		{
			List<Bitacora> lista = new List<Bitacora>();
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			if(TipoEvento != null)
				parametros.Add(da.CrearParametro("@TipoEventoId", TipoEvento.Id));
			if(FechaDesde != null)
				parametros.Add(da.CrearParametro("@FechaDesde", FechaDesde.Value.ToString("yyyy/MM/dd")));
			if(FechaHasta != null)
				parametros.Add(da.CrearParametro("@FechaHasta", FechaHasta.Value.ToString("yyyy/MM/dd")));
			DataTable tabla = da.Leer("BitacoraListar", parametros);
			da.Cerrar();

			foreach(DataRow fila in tabla.Rows)
			{
				Bitacora bitacora = new Bitacora();
				bitacora.Id = int.Parse(fila["Id"].ToString());
				bitacora.FechaCreacion = DateTime.Parse(fila["FechaCreacion"].ToString());
				Usuario usuario = new Usuario();
				usuario.Id = int.Parse(fila["UsuarioId"].ToString());
				usuario.UserName = fila["UserName"].ToString();
				bitacora.Usuario = usuario;
				TipoEvento tipoEvento = new TipoEvento();
				tipoEvento.Id = int.Parse(fila["TipoEventoId"].ToString());
				tipoEvento.Nombre = fila["TipoEvento"].ToString();
				bitacora.TipoEvento = tipoEvento;
				lista.Add(bitacora);
			}
			return lista;
		}
	}
}
