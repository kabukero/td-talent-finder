using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Enumeración que contiene los identificadores de los estados del resultado de la ejecución de un programa
	/// </summary>
	public enum ResultadoEjecucionEstado
	{
		ERROR_COMPILE = 1,
		COMPILED,
		ERROR_EXECUTE,
		EXECUTED
	}
}
