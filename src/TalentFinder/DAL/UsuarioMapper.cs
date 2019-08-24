using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
	public class UsuarioMapper
	{
		public bool Login(Usuario usuario)
		{
			bool r = true;

			DataAccessManager da = new DataAccessManager();
			da.Abrir();

			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@UserName", usuario.UserName));
			parametros.Add(da.CrearParametro("@UserPassword", usuario.Password));
			int f = da.LeerEscalar("LoginUsuario", parametros);

			if(f == 0)
				r = false;

			da.Cerrar();

			return r;
		}
	}
}
