using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class ResultadoEjecucion
	{
		public string NombreArchivoPrograma { get; set; }

		public string NombreProgramaEjecutable
		{
			get
			{
				return ObtenerNombreProgramaEjecutable();
			}
		}

		public string Descripcion { get; set; }

		public ResultadoEjecucionEstado ResultadoEjecucionEstado { get; set; }

		private string ObtenerNombreProgramaEjecutable()
		{
			return NombreArchivoPrograma.Substring(0, NombreArchivoPrograma.Length - 3) + ".exe";
		}

	}
}
