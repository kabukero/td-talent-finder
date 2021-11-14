using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio que representa el Parser
	/// para poder crear el codigo fuente escrito por el usuario
	/// </summary>
	public class Parser
	{
		/// <summary>
		/// Método para obtener el codigo fuente del programa escrito por el usuario
		/// </summary>
		/// <param name="MetodoDetalle">Código fuente escrito por el usuario</param>
		/// <returns>Código fuente del programa</returns>
		public string GetCodigoFuente(MetodoDetalle MetodoDetalle)
		{
			//string codigoFuentePrograma = EjercicioCodigoFuenteFactory.GetCodigoFuente(MetodoDetalle.EjercicioNombre);
			string codigoFuentePrograma = MetodoDetalle.CodigoFuenteTest;
			codigoFuentePrograma = codigoFuentePrograma.Replace("XXX_MI_METODO_XXX", MetodoDetalle.CodigoFuenteMetodo);
			return codigoFuentePrograma;
		}
	}
}
