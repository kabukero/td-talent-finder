using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public abstract class EjercicioBase
	{
		public abstract int MiMetodo(int numero);
		public abstract IList<ResultadoTest> MiMetodoTest();
	}
}
