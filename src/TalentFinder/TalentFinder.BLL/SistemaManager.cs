using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;
using TalentFinder.Seguridad;

namespace TalentFinder.BLL
{
	public class SistemaManager
	{
		public static UsuarioManager UsuarioManager = new UsuarioManager();
		public static SessionManager SessionManager;
		public static BitacoraManager BitacoraManager = new BitacoraManager();
		public static PerfilPermisoManager PerfilPermisoManager = new PerfilPermisoManager();
		public static TipoPermisoManager TipoPermisoManager = new TipoPermisoManager();
		public static DigitoVerificadorManager DigitoVerificadorManager = new DigitoVerificadorManager();
		public static EmpresaManager EmpresaManager = new EmpresaManager();
		public static IdiomaManager IdiomaManager = new IdiomaManager();

		static SistemaManager()
		{
			SessionManager = SessionManager.GetUsuarioSesion();
			Idioma idiomaDefault = IdiomaManager.GetIdioma(Idiomas.ESPAÑOL); // idioma por defecto
			SessionManager.IdiomaSession = idiomaDefault;
			SessionManager.IdiomaSession.IdiomaSelected = idiomaDefault;
		}
	}
}
