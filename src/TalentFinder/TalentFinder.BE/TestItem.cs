using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class TestItem
	{
		public int NumeroTest { get; set; }
		public int NumeroEjercicio { get; set; }
		public int ParametroEntrada { get; set; }
		public int ValorResultadoEsperado { get; set; }
		public string Descripcion { get; set; }
		public bool Error { get; set; }
	}
}
