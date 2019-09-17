using System;
using System.Collections.Generic;
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

		public int DeshabilitarUsuario(Usuario usuario)
		{
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@UserName", usuario.UserName));
			int f = da.Escribir("DeshabilitarUsuario", parametros);
			da.Cerrar();
			return f;
		}

		public List<Usuario> GetUsuarios()
		{
			List<Usuario> lista = new List<Usuario>();
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			DataTable tabla = da.Leer("GetUsuarios", null);
			da.Cerrar();

			foreach(DataRow fila in tabla.Rows)
			{
				Usuario usuario = new Usuario();
				usuario.Id = int.Parse(fila["Id"].ToString());
				usuario.UserName = fila["UserName"].ToString();
				lista.Add(usuario);
			}
			return lista;
		}
	}
}
