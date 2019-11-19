using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
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
