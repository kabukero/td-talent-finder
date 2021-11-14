using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{
			MathUtil m = new MathUtil();
			int f = m.MiMetodo(4);
			Console.Write(string.Format("4! = {0}", f));
			Console.ReadKey();
		}
	}

	public class MathUtil
	{
		public int MiMetodo(int n)
		{
			int f = 1;

			if(n == 0 || n == 1)
				return f;

			for(int i = 1; i <= n; i++)
			{
				f *= i;
			}
			return f;
		}
	}
}
