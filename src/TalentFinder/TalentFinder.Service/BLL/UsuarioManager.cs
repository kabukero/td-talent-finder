using System.Collections.Generic;
using System.Linq;
using TalentFinder.Service.DAL;
using TalentFinder.Service.Seguridad;
using TalentFinder.Service.Domain;

namespace TalentFinder.Service.BLL
{
	/// <summary>
	/// Clase para gestionar los usuarios del sistema
	/// </summary>
	public class UsuarioManager
	{
		private const int USUARIO_ADMINISTRADOR_ID = 5;
		private const int CantidadMaximaIntentos = 3;

		/// <summary>
		/// Property que contiene la cantidad intentos de login de un usuario
		/// </summary>
		public int CantidadIntentosLogin { get; set; }

		/// <summary>
		/// Atributo que contiene el mapper del usuario para gestionar la gestión de la persistencia en el sistema
		/// </summary>
		private UsuarioMapper usuarioMapper = new UsuarioMapper();

		public UsuarioManager()
		{
			CantidadIntentosLogin = 0;
		}

		/// <summary>
		/// Método para obtener los usuarios del sistema
		/// </summary>
		/// <returns></returns>
		public List<Usuario> GetUsuarios()
		{
			List<Usuario> lista = usuarioMapper.GetUsuarios().Where(x => x.Id != USUARIO_ADMINISTRADOR_ID).ToList();
			return lista;
		}

		/// <summary>
		/// Método para obtener un usuario por id
		/// </summary>
		/// <param name="usuario">Un usuario</param>
		/// <returns>El usuario buscado</returns>
		public Usuario GetUsuario(Usuario usuario)
		{
			return  usuarioMapper.GetUsuario(usuario);
		}

		/// <summary>
		/// Método para obtener el usuario administrador del sistema
		/// </summary>
		/// <returns>El usuario encontrado</returns>
		public Usuario GetUsuarioAdministrador()
		{
			return usuarioMapper.GetUsuarioAdministrador();
		}

		/// <summary>
		/// Método para obtener la lista de usuarios
		/// </summary>
		/// <returns>Lista de usuarios</returns>
		public List<Usuario> GetUsuariosToDropDownList()
		{
			List<Usuario> lista = usuarioMapper.GetUsuarios();
			lista.Insert(0, new Usuario() { Id = 0, UserName = "Seleccione" });
			return lista;
		}

		/// <summary>
		/// Método para validar un usuario
		/// </summary>
		/// <param name="usuario">Un usuario</param>
		/// <returns>Resultado de la validación</returns>
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
			//if(SistemaManager.PerfilPermisoManager.TienePermiso(Permisos.PERFIL_POSTULANTE, usuarioSesion.UsuarioLogueado.PermisoComponent))
			//	usuarioSesion.Profesional = SistemaManager.ProfesionalManager.GetProfesional(usuarioSesion.UsuarioLogueado);
			//else if(SistemaManager.PerfilPermisoManager.TienePermiso(Permisos.PERFIL_RECLUTADOR, usuarioSesion.UsuarioLogueado.PermisoComponent))
			//	usuarioSesion.Reclutador = SistemaManager.ReclutadorManager.GetReclutador(usuarioSesion.UsuarioLogueado);

			return true;
		}

		/// <summary>
		/// Método para crear un usuario login
		/// </summary>
		/// <param name="usuario">Un nombre de usuario</param>
		/// <param name="password">Una clave</param>
		/// <returns>Un objeto usuario</returns>
		public Usuario CrearUsuarioLogin(string usuario, string password)
		{
			return new Usuario() { UserName = usuario, UserPassword = password };
		}

		/// <summary>
		/// Método para validar el login de un usuario
		/// </summary>
		/// <param name="usuario"></param>
		/// <returns></returns>
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

		/// <summary>
		/// Método para validar si un usuario superó el número máximos de intentos de login
		/// </summary>
		/// <param name="usuario">Un usuario</param>
		/// <returns>Resultado de la validación</returns>
		public bool SuperoMaximoIntentosLogin(Usuario usuario)
		{
			bool r = CantidadIntentosLogin == CantidadMaximaIntentos;
			if(r)
				DeshabilitarUsuario(usuario);
			return r;
		}

		/// <summary>
		/// Método para deshabilitar un usuario
		/// </summary>
		/// <param name="usuario"Un usuario></param>
		/// <returns>Resultado de la ejecución</returns>
		public int DeshabilitarUsuario(Usuario usuario)
		{
			int f = usuarioMapper.ExisteUsuario(usuario);
			if(f > 0)
				f = usuarioMapper.DeshabilitarUsuario(usuario);
			return f;
		}

		/// <summary>
		/// Método para crear un usuario en el sistemam
		/// </summary>
		/// <param name="usuario">Un usuario</param>
		/// <returns>Resultado de la ejecución</returns>
		public int Agregar(Usuario usuario)
		{
			usuario.UserPassword = EncryptorManager.GetPasswordHash(usuario.UserPassword);
			return usuarioMapper.Agregar(usuario);
		}

		/// <summary>
		/// Método para editar un usuario en el sistemam
		/// </summary>
		/// <param name="usuario">Un usuario</param>
		/// <returns>Resultado de la ejecución</returns>
		public void Editar(Usuario usuario, string userPassword)
		{
			if(!string.IsNullOrEmpty(userPassword))
				usuario.UserPassword = EncryptorManager.GetPasswordHash(userPassword);
			usuarioMapper.Editar(usuario);
		}

		/// <summary>
		/// Método para eliminar un usuario en el sistemam
		/// </summary>
		/// <param name="usuario">Un usuario</param>
		/// <returns>Resultado de la ejecución</returns>
		public void Eliminar(Usuario usuario)
		{
			usuarioMapper.Eliminar(usuario);
		}
	}
}
