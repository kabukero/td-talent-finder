using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
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
		LOGIN_SISTEMA = 21,
		LEER_EMPRESA = 23,
		CREAR_EMPRESA = 24,
		EDITAR_EMPRESA = 25,
		ELIMINAR_EMPRESA = 26,
		REALIZAR_BACKUP = 27,
		REALIZAR_RESTORE = 29
	}
}
