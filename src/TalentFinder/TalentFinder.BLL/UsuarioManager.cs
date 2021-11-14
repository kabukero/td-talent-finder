using System.Collections.Generic;
using System.Linq;
using TalentFinder.BE;
using TalentFinder.DAL;
using TalentFinder.Seguridad;

namespace TalentFinder.BLL
{
	public class UsuarioManager
	{
		private const int USUARIO_ADMINISTRADOR_ID = 5;
		private const int CantidadMaximaIntentos = 3;
		public int CantidadIntentosLogin { get; set; }

		private UsuarioMapper usuarioMapper = new UsuarioMapper();

		public UsuarioManager()
		{
			CantidadIntentosLogin = 0;
		}

		public List<Usuario> GetUsuarios()
		{
			List<Usuario> lista = usuarioMapper.GetUsuarios().Where(x => x.Id != USUARIO_ADMINISTRADOR_ID).ToList();
			return lista;
		}

		public Usuario GetUsuario(Usuario usuario)
		{
			return  usuarioMapper.GetUsuario(usuario);
		}

		public Usuario GetUsuarioAdministrador()
		{
			return usuarioMapper.GetUsuarioAdministrador();
		}

		public List<Usuario> GetUsuariosToDropDownList()
		{
			List<Usuario> lista = usuarioMapper.GetUsuarios();
			lista.Insert(0, new Usuario() { Id = 0, UserName = "Seleccione" });
			return lista;
		}

		public bool ValidarUsuario(Usuario usuario)
		{
			CantidadIntentosLogin++;
			PerfilPermisoManager perfilPermisoManager = new PerfilPermisoManager();

			// validar si el usuario esta registrado
			Usuario UsuarioEncontrado = usuarioMapper.GetUsuario(usuario.UserName);
			if(UsuarioEncontrado == null)
				return false;

			// validar password
			if(!EncryptorManager.VerifyPasswordHash(usuario.UserPassword, UsuarioEncontrado.UserPassword))
				return false;

			// set id usuario
			usuario.Id = UsuarioEncontrado.Id;

			// cargar permisos usuario
			usuario.PermisoComponent = perfilPermisoManager.GetAllPerfilesPermisosPorUsuario(usuario);

			// crear sesion usuario logueado
			SessionManager usuarioSesion = SessionManager.GetUsuarioSesion();
			usuarioSesion.UsuarioLogueado = usuario;

			// set perfil usuario logueado
			if(SistemaManager.PerfilPermisoManager.TienePermiso(Permisos.PERFIL_POSTULANTE, usuarioSesion.UsuarioLogueado.PermisoComponent))
				usuarioSesion.Profesional = SistemaManager.ProfesionalManager.GetProfesional(usuarioSesion.UsuarioLogueado);
			else if(SistemaManager.PerfilPermisoManager.TienePermiso(Permisos.PERFIL_RECLUTADOR, usuarioSesion.UsuarioLogueado.PermisoComponent))
				usuarioSesion.Reclutador = SistemaManager.ReclutadorManager.GetReclutador(usuarioSesion.UsuarioLogueado);

			return true;
		}

		public Usuario CrearUsuarioLogin(string usuario, string password)
		{
			return new Usuario() { UserName = usuario, UserPassword = password };
		}

		public bool ValidarLogin(Usuario usuario)
		{
			if(string.IsNullOrEmpty(usuario.UserName) || usuario.UserName.Length > 50)
				return false;

			if(string.IsNullOrEmpty(usuario.UserPassword) || usuario.UserPassword.Length > 50)
				return false;

			if(!ValidarUsuario(usuario))
				return false;

			return true;
		}

		public bool SuperoMaximoIntentosLogin(Usuario usuario)
		{
			bool r = CantidadIntentosLogin == CantidadMaximaIntentos;
			if(r)
				DeshabilitarUsuario(usuario);
			return r;
		}

		public int DeshabilitarUsuario(Usuario usuario)
		{
			int f = usuarioMapper.ExisteUsuario(usuario);
			if(f > 0)
				f = usuarioMapper.DeshabilitarUsuario(usuario);
			return f;
		}

		public int Agregar(Usuario usuario)
		{
			usuario.UserPassword = EncryptorManager.GetPasswordHash(usuario.UserPassword);
			return usuarioMapper.Agregar(usuario);
		}

		public void Editar(Usuario usuario, string userPassword)
		{
			if(!string.IsNullOrEmpty(userPassword))
				usuario.UserPassword = EncryptorManager.GetPasswordHash(userPassword);
			usuarioMapper.Editar(usuario);
		}

		public void Eliminar(Usuario usuario)
		{
			usuarioMapper.Eliminar(usuario);
		}
	}
}
