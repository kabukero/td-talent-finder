﻿using TalentFinder.Service.Domain;

namespace TalentFinder.Service.Seguridad
{
	public class SessionManager
	{
		private static SessionManager instanciaSesion;
		public Usuario UsuarioLogueado { get; set; }
		public Idioma IdiomaSession { get; set; }
		public Profesional Profesional { get; set; }
		//public Reclutador Reclutador { get; set; }
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