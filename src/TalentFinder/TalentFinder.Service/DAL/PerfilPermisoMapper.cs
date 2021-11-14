using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.Service.Domain;

namespace TalentFinder.Service.DAL
{
	public class PerfilPermisoMapper
	{
		private const int RootId = 1;
		public List<PermisoComponent> GetAllPerfilesPermisos()
		{
			List<PermisoComponent> permisoComponents = new List<PermisoComponent>();
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			PermisoComponent permisoComponent;
			DataTable tabla = da.Leer("GetAllPerfilesPermisos", null);
			foreach(DataRow fila in tabla.Rows)
			{
				if(int.Parse(fila["TipoPermisoId"].ToString()) == (int)TiposPermiso.PERFIL) // perfil
					permisoComponent = new Perfil();
				else // permiso
					permisoComponent = new Permiso();
				permisoComponent.Id = int.Parse(fila["Id"].ToString());
				permisoComponent.Nombre = fila["Nombre"].ToString();

				//if(int.Parse(fila["PermisoPadreId"].ToString()) == RootId)
				//	permisoComponent.PermisoPadreId = -1;
				//else
				//	permisoComponent.PermisoPadreId = int.Parse(fila["PermisoPadreId"].ToString());
				permisoComponent.PermisoPadreId = int.Parse(fila["PermisoPadreId"].ToString());
				permisoComponents.Add(permisoComponent);
			}
			da.Cerrar();
			return permisoComponents;
		}
		public List<PermisoComponent> GetAllPerfilesPermisosPorUsuario(Usuario usuario)
		{
			List<PermisoComponent> permisoComponents = new List<PermisoComponent>();
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@UsuarioId", usuario.Id));
			DataTable tabla = da.Leer("GetUsuarioPerfilesPermisos", parametros);
			foreach(DataRow fila in tabla.Rows)
			{
				PermisoComponent permisoComponent = new	Perfil();
				permisoComponent.Id = int.Parse(fila["Id"].ToString());
				permisoComponent.Nombre = fila["Nombre"].ToString();
				permisoComponents.Add(permisoComponent);
			}
			da.Cerrar();
			return permisoComponents;
		}
		public int GuardarUsuarioPerfilesPermisos(List<PermisoComponent> perfilesPermisos, Usuario usuario)
		{
			int f = 0;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			da.IniciarTx();
			try
			{
				List<SqlParameter> parametros = new List<SqlParameter>();
				parametros.Add(da.CrearParametro("@UsuarioId", usuario.Id));
				f = da.Escribir("EliminarUsuarioPerfilesPermisos", parametros);

				foreach(PermisoComponent p in perfilesPermisos)
				{
					parametros.Clear();
					parametros.Add(da.CrearParametro("@UsuarioId", usuario.Id));
					parametros.Add(da.CrearParametro("@PermisoId", p.Id));
					f += da.Escribir("GuardarUsuarioPerfilesPermisos", parametros);
				}
				da.ConfirmarTx();
			}
			catch(Exception ex)
			{
				f = -1;
				da.CancelarTx();
			}
			da.Cerrar();
			return f;
		}
		public List<Permiso> GetAllPermisos()
		{
			List<Permiso> permisos = new List<Permiso>();
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			DataTable tabla = da.Leer("GetAllPermisos", null);
			foreach(DataRow fila in tabla.Rows)
			{
				Permiso permiso = new Permiso();
				permiso.Id = int.Parse(fila["Id"].ToString());
				permiso.Nombre = fila["Nombre"].ToString();
				permisos.Add(permiso);
			}
			da.Cerrar();
			return permisos;
		}
		public List<Perfil> GetAllPerfiles()
		{
			List<Perfil> perfiles = new List<Perfil>();
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			DataTable tabla = da.Leer("GetAllPerfiles", null);
			foreach(DataRow fila in tabla.Rows)
			{
				Perfil perfil = new Perfil();
				perfil.Id = int.Parse(fila["Id"].ToString());
				perfil.Nombre = fila["Nombre"].ToString();
				perfiles.Add(perfil);
			}
			da.Cerrar();
			return perfiles;
		}
		public int AgregarPermisoPermiso(PermisoPermiso permisoPermiso)
		{
			int f = 0;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			try
			{
				List<SqlParameter> parametros = new List<SqlParameter>();
				parametros.Add(da.CrearParametro("@PermisoId", permisoPermiso.PermisoId));
				parametros.Add(da.CrearParametro("@PermisoPadreId", permisoPermiso.PermisoPadreId));
				f = da.Escribir("AgregarPermisoToPerfil", parametros);
			}
			catch(Exception ex)
			{
				f = -1;
			}
			da.Cerrar();
			return f;
		}
		public int AgregarPerfil(Perfil perfil)
		{
			int f = 0;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			try
			{
				List<SqlParameter> parametros = new List<SqlParameter>();
				parametros.Add(da.CrearParametro("@Nombre", perfil.Nombre));
				parametros.Add(da.CrearParametro("@PermisoPadreId", perfil.PermisoPadreId));
				f = da.Escribir("CrearPerfil", parametros);
			}
			catch(Exception ex)
			{
				f = -1;
			}
			da.Cerrar();
			return f;
		}
		public int EditarPerfil(Perfil perfil)
		{
			int f = 0;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			try
			{
				List<SqlParameter> parametros = new List<SqlParameter>();
				parametros.Add(da.CrearParametro("@Id", perfil.Id));
				parametros.Add(da.CrearParametro("@Nombre", perfil.Nombre));
				f = da.Escribir("EditarPerfil", parametros);
			}
			catch(Exception ex)
			{
				f = -1;
			}
			finally
			{
				da.Cerrar();
			}
			return f;
		}
		public int EliminarPerfil(Perfil perfil)
		{
			int f = 0;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			try
			{
				List<SqlParameter> parametros = new List<SqlParameter>();
				parametros.Add(da.CrearParametro("@Id", perfil.Id));
				f = da.Escribir("EliminarPerfil", parametros);
			}
			catch(Exception ex)
			{
				f = -1;
			}
			da.Cerrar();
			return f;
		}
		public int QuitarPermisoPermiso(List<PermisoPermiso> permisoPermisos)
		{
			int f = 0;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			da.IniciarTx();
			try
			{
				foreach(PermisoPermiso permisoPermiso in permisoPermisos)
				{
					List<SqlParameter> parametros = new List<SqlParameter>();
					parametros.Add(da.CrearParametro("@PermisoId", permisoPermiso.PermisoId));
					parametros.Add(da.CrearParametro("@PermisoPadreId", permisoPermiso.PermisoPadreId));
					f = da.Escribir("QuitarPermisoPermiso", parametros);
				}
				da.ConfirmarTx();
			}
			catch(Exception ex)
			{
				da.CancelarTx();
				f = -1;
			}
			finally
			{
				da.Cerrar();
			}
			return f;
		}
	}
}
