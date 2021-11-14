using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using TalentFinder.Service.Domain;

namespace TalentFinder.Service.DAL
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
		private Persona GetPersona(Usuario usuario)
		{
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			DataTable tabla;
			DataRow fila = null;
			Persona persona = null;
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@UsuarioId", usuario.Id));

			if(usuario.IsInRole((int)Permisos.PERFIL_POSTULANTE, usuario.PermisoComponent))
			{
				tabla = da.Leer("GetProfesional", parametros);
				if(tabla.Rows.Count > 0)
				{
					fila = tabla.Rows[0];
					persona = new Profesional();
				}
			}
			else if(usuario.IsInRole((int)Permisos.PERFIL_RECLUTADOR, usuario.PermisoComponent))
			{
				tabla = da.Leer("GetReclutador", parametros);
				if(tabla.Rows.Count > 0)
				{
					fila = tabla.Rows[0];
					persona = new Profesional();
				}
			}
			if(fila != null)
			{
				persona.Id = int.Parse(fila["Id"].ToString());
				persona.Nombre = fila["Nombre"].ToString();
				persona.Apellido = fila["Apellido"].ToString();
				persona.Email = fila["Email"].ToString();
				Empresa empresa = new Empresa();
				empresa.Id = int.Parse(fila["EmpresaId"].ToString());
				empresa.RazonSocial = fila["RazonSocial"].ToString();
				persona.Empresa = empresa;
			}
			da.Cerrar();
			return persona;
		}

		public Usuario GetUsuario(string userName)
		{
			Usuario usuario = null;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@UserName", userName));
			DataTable tabla = da.Leer("GetUsuariobByUserName", parametros);
			if(tabla.Rows.Count > 0)
			{
				DataRow registro = tabla.Rows[0];
				usuario = new Usuario();
				usuario.Id = int.Parse(registro["Id"].ToString());
				usuario.UserName = registro["UserName"].ToString();
				usuario.UserPassword = registro["UserPassword"].ToString();
				PerfilPermisoMapper perfilPermisoMapper = new PerfilPermisoMapper();
				usuario.PermisoComponent = perfilPermisoMapper.GetAllPerfilesPermisosPorUsuario(usuario);
				usuario.Persona = GetPersona(usuario);
			}
			da.Cerrar();
			return usuario;
		}

		public Usuario GetUsuario(Usuario user)
		{
			Usuario usuario = null;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@Id", user.Id));
			DataTable tabla = da.Leer("GetUsuario", parametros);
			if(tabla.Rows.Count > 0)
			{
				DataRow registro = tabla.Rows[0];
				usuario = new Usuario();
				usuario.Id = int.Parse(registro["Id"].ToString());
				usuario.UserName = registro["UserName"].ToString();
				PerfilPermisoMapper perfilPermisoMapper = new PerfilPermisoMapper();
				usuario.PermisoComponent = perfilPermisoMapper.GetAllPerfilesPermisosPorUsuario(usuario);
				usuario.Persona = GetPersona(usuario);
			}
			da.Cerrar();
			return usuario;
		}

		public Usuario GetUsuarioAdministrador()
		{
			return GetUsuario(new Usuario() { Id = int.Parse(ConfigurationManager.AppSettings["UsuarioAdministradorId"].ToString()) });
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
			PerfilPermisoMapper perfilPermisoMapper = new PerfilPermisoMapper();
			List<Usuario> lista = new List<Usuario>();
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			DataTable tabla = da.Leer("GetUsuarios", null);
			da.Cerrar();

			List<SqlParameter> parametros = new List<SqlParameter>();
			foreach(DataRow fila in tabla.Rows)
			{
				Usuario usuario = new Usuario();
				usuario.Id = int.Parse(fila["Id"].ToString());
				usuario.UserName = fila["UserName"].ToString();
				usuario.UserPassword = fila["UserPassword"].ToString();
				usuario.PermisoComponent = perfilPermisoMapper.GetAllPerfilesPermisosPorUsuario(usuario);
				usuario.Persona = GetPersona(usuario);
				lista.Add(usuario);
			}
			return lista;
		}

		public int Agregar(Usuario usuario)
		{
			int NewId;
			DataAccessManager da = new DataAccessManager();
			try
			{
				da.Abrir();
				da.IniciarTx();

				List<SqlParameter> parametros = new List<SqlParameter>();
				parametros.Add(da.CrearParametro("@UserName", usuario.UserName));
				parametros.Add(da.CrearParametro("@UserPassword", usuario.UserPassword));
				NewId = (int)da.LeerEscalar("AgregarUsuario", parametros);
				usuario.Id = NewId;

				parametros.Clear();
				parametros.Add(da.CrearParametro("@Nombre", usuario.Persona.Nombre));
				parametros.Add(da.CrearParametro("@Apellido", usuario.Persona.Apellido));
				parametros.Add(da.CrearParametro("@Email", usuario.Persona.Email));
				parametros.Add(da.CrearParametro("@UsuarioId", usuario.Id));
				parametros.Add(da.CrearParametro("@EmpresaId", usuario.Persona.Empresa.Id));

				if(usuario.IsInRole((int)Permisos.PERFIL_POSTULANTE, usuario.PermisoComponent))
					da.Escribir("AgregarProfesional", parametros);
				else if(usuario.IsInRole((int)Permisos.PERFIL_RECLUTADOR, usuario.PermisoComponent))
					da.Escribir("AgregarReclutador", parametros);

				da.ConfirmarTx();
			}
			catch(Exception ex)
			{
				da.CancelarTx();
				throw;
			}
			da.Cerrar();
			return NewId;
		}

		public int Editar(Usuario usuario)
		{
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@Id", usuario.Id));
			parametros.Add(da.CrearParametro("@UserName", usuario.UserName));
			parametros.Add(da.CrearParametro("@UserPassword", usuario.UserPassword));
			int f = da.Escribir("EditarUsuario", parametros);
			da.Cerrar();
			return f;
		}

		public int Eliminar(Usuario usuario)
		{
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@Id", usuario.Id));
			int f = da.Escribir("EliminarUsuario", parametros);
			da.Cerrar();
			return f;
		}
	}
}
