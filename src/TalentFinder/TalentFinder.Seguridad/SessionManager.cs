using TalentFinder.BE;

namespace TalentFinder.Seguridad
{
	public class SessionManager
	{
		private static SessionManager instanciaSesion;

		private Usuario usuarioLogueado;
		public Usuario UsuarioLogueado
		{
			get
			{
				return usuarioLogueado;
			}
			set
			{
				usuarioLogueado = value;
			}
		}

		private SessionManager()
		{
			UsuarioLogueado = null;
		}

		public static SessionManager GetUsuarioSesion()
		{
			if(instanciaSesion == null)
				instanciaSesion = new SessionManager();
			return instanciaSesion;
		}

		public bool EstaElUsuarioLogueado()
		{
			return UsuarioLogueado != null;
		}
	}
}
