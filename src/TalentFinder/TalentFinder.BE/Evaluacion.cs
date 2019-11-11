using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class Evaluacion : EntidadBase
	{
		public string Descripcion { get; set; }
		public string CodigoFuenteTest { get; set; }
		public string Ejercicio { get; set; }
	}
}
