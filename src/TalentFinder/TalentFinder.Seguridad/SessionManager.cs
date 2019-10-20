using TalentFinder.BE;

namespace TalentFinder.Seguridad
{
	public class SessionManager
	{
		private static SessionManager instanciaSesion;
		public Usuario UsuarioLogueado { get; set; }
		public Idioma IdiomaSession { get; set; }
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
