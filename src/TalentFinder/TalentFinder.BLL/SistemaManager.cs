using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;
using TalentFinder.Seguridad;

namespace TalentFinder.BLL
{
	/// <summary>
	/// Clase contenedor de las clases managers de la capa de negocio
	/// </summary>
	public class SistemaManager
	{
		public static UsuarioManager UsuarioManager = new UsuarioManager();
		public static SessionManager SessionManager;
		public static BitacoraManager BitacoraManager = new BitacoraManager();
		public static BackupManager BackupManager = new BackupManager();
		public static PerfilPermisoManager PerfilPermisoManager = new PerfilPermisoManager();
		public static TipoPermisoManager TipoPermisoManager = new TipoPermisoManager();
		public static DigitoVerificadorManager DigitoVerificadorManager = new DigitoVerificadorManager();
		public static EmpresaManager EmpresaManager = new EmpresaManager();
		public static IdiomaManager IdiomaManager = new IdiomaManager();
		public static TecnologiaManager TecnologiaManager = new TecnologiaManager();
		public static AvisoLaboralManager AvisoLaboralManager = new AvisoLaboralManager();
		public static ProfesionalManager ProfesionalManager = new ProfesionalManager();
		public static ReclutadorManager ReclutadorManager = new ReclutadorManager();
		public static List<TipoEvento> ListaTipoEvento = new List<TipoEvento>();

		static SistemaManager()
		{
			SessionManager = SessionManager.GetUsuarioSesion();
			Idioma idiomaDefault = IdiomaManager.GetIdioma(Idiomas.ESPAÑOL); // idioma por defecto
			SessionManager.IdiomaSession = idiomaDefault;
			SessionManager.IdiomaSession.IdiomaSelected = idiomaDefault;
			ListaTipoEvento = BitacoraManager.GetBitacoraTipoEventos();
		}
	}
}
