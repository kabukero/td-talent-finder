using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TalentFinder.BE;

namespace TalentFinder.DAL
{
	public class UsuarioMapper
	{
		public int ExisteUsuario(Usuario usuario)
		{
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@UserName", usuario.UserName));
			int f = da.LeerEscalar("LoginUsuario", parametros);
			da.Cerrar();
			return f;
		}

		public Usuario GetUsuario(string userName)
		{
			Usuario usuario = null;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@UserName", userName));
			DataTable tabla = da.Leer("GetUsuario", parametros);
			if(tabla.Rows.Count > 0)
			{
				DataRow registro = tabla.Rows[0];
				usuario = new Usuario();
				usuario.Id = int.Parse(registro["Id"].ToString());
				usuario.UserName = registro["UserName"].ToString();
				usuario.UserPassword = registro["UserPassword"].ToString();
			}
			da.Cerrar();
			return usuario;
		}
	}
}
