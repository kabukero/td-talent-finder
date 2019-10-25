using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class Parser
	{
		public string GetCodigoPrograma(string CodigoFuente, string codigoMetodo)
		{
			int startIndex = CodigoFuente.IndexOf("//XXX_BEGIN_XXX");
			int EndIndex = CodigoFuente.IndexOf("//XXX_END_XXXX");
			string output = CodigoFuente.Substring(0, startIndex) + "\r\n" + codigoMetodo + "\r\n" + CodigoFuente.Substring(EndIndex, CodigoFuente.Length - 1);
			return output;
		}
	}
}
