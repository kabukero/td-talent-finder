using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.Service.Domain
{
	/// <summary>
	/// Enumeración que contiene todos los identificadores de las patentes
	/// disponibles en el sistema
	/// </summary>
	public enum Permisos
	{
		ROOT = 1,
		PUBLICAR_AVISO_LABORAL = 4,
		POSTULARSE_A_AVISO_LABORAL = 7,
		LEER_USUARIO = 12,
		CREAR_USUARIO = 13,
		EDITAR_USUARIO = 14,
		ELIMINAR_USUARIO = 15,
		LEER_PERFIL = 16,
		CREAR_PERFIL = 17,
		EDITAR_PERFIL = 18,
		ELIMINAR_PERFIL = 19,
		LEER_EMPRESA = 22,
		CREAR_EMPRESA = 23,
		EDITAR_EMPRESA = 24,
		ELIMINAR_EMPRESA = 25,
		REALIZAR_BACKUP = 26,
		REALIZAR_RESTORE = 27,
		VER_BITACORA = 28,
		GESTION_IDIOMAS = 29,
		PERFIL_POSTULANTE = 5,
		PERFIL_RECLUTADOR = 2
	}
}
