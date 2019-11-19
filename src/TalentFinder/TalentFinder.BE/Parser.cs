using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class Parser
	{
		private EjercicioCodigoFuenteFactory EjercicioCodigoFuenteFactory = new EjercicioCodigoFuenteFactory();
		public string GetCodigoFuente(MetodoDetalle MetodoDetalle)
		{
			//string codigoFuentePrograma = EjercicioCodigoFuenteFactory.GetCodigoFuente(MetodoDetalle.EjercicioNombre);
			string codigoFuentePrograma = MetodoDetalle.CodigoFuenteTest;
			codigoFuentePrograma = codigoFuentePrograma.Replace("XXX_MI_METODO_XXX", MetodoDetalle.CodigoFuenteMetodo);
			return codigoFuentePrograma;
		}
	}
}
