using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class Ejercicio : IEjercicio
	{
		public string Nombre { get; set; }

		//XXX_BEGIN_EJERCICIO1_XXX
		public int MiMetodo(int valor)
		{
			throw new NotImplementedException();
		}
		//XXX_END_EJERCICIO1_XXX

		//XXX_BEGIN_EJERCICIO2_XXX
		public int MiMetodo(string valor)
		{
			throw new NotImplementedException();
		}
		//XXX_END_EJERCICIO2_XXX

		//XXX_BEGIN_EJERCICIO3_XXX
		public int MiMetodo(int[] valor)
		{
			throw new NotImplementedException();
		}
		//XXX_END_EJERCICIO3_XXX
	}
}
