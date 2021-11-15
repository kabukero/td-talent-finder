using TalentFinder.BE;
using Idioma = TalentFinder.Service.Domain.Idioma;
using Usuario = TalentFinder.Service.Domain.Usuario;

namespace TalentFinder.Service.Seguridad
{
	/// <summary>
	/// Clase para gestionar la sesión del usuario en el sistema
	/// </summary>
	public class SessionManager
	{
		/// <summary>
		/// Property instancia de la clase SessionManager
		/// </summary>
		private static SessionManager instanciaSesion;

		/// <summary>
		/// Property que contiene el objeto usuario logueado en el sistema
		/// </summary>
		public Usuario UsuarioLogueado { get; set; }

		/// <summary>
		/// Property que contiene el idioma de la sesión del usuario en el sistema
		/// </summary>
		public Idioma IdiomaSession { get; set; }

		/// <summary>
		/// Property que contiene el profesional asociado al usuario
		/// </summary>
		public Profesional Profesional { get; set; }

		/// <summary>
		/// /// Property que contiene el reclutador asociado al usuario
		/// </summary>
		public Reclutador Reclutador { get; set; }

		
		/// <summary>
		/// Constructor privado para implementar el patron de diseño singleton
		/// </summary>
		private SessionManager()
		{
			UsuarioLogueado = null;
		}

		/// <summary>
		/// Método para obtener el objeto Session Manager
		/// </summary>
		/// <returns>Objeto Session Manager</returns>
		public static SessionManager GetUsuarioSesion()
		{
			if(instanciaSesion == null)
				instanciaSesion = new SessionManager();
			return instanciaSesion;
		}

		/// <summary>
		/// Método para verificar si el usuario esta logueado en el sistema
		/// </summary>
		/// <returns></returns>
		public bool EstaElUsuarioLogueado()
		{
			return UsuarioLogueado != null;
		}
	}
}
