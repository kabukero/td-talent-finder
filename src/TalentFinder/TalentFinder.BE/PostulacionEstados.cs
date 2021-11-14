using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Enumeración que contiene los identificadores de los estados de las postulaciones
	/// </summary>
	public enum PostulacionEstados
	{
		INICIADA = 1,
		PRESELECCIONADO,
		NO_SELECCIONADO,
		EN_EVALUACION,
		EVALUADO,
		EN_ENTREVISTA,
		ENTREVISTADO,
		CONTRATADO,
		NO_CONTRATADO
	}
}
