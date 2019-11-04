using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public interface IEjercicio
	{
		string Nombre { get; set; }
		int MiMetodo(int valor);
		int MiMetodo(string valor);
		int MiMetodo(int[] valor);
	}
}
