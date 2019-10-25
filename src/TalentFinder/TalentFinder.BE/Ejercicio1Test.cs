using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class Ejercicio1Test
	{
		public IDictionary<int, int> ValoresTests = new Dictionary<int, int>();
		private Func<int, int, bool> TestFunc;
		private Ejercicio1 Ejercicio1;
		private void SetTestFunc()
		{
			TestFunc = (n, m) => Ejercicio1.MiMetodo(n) == m;
		}
		private void CargarValoresTests()
		{
			ValoresTests.Add(0, 1);
			ValoresTests.Add(1, 1);
			ValoresTests.Add(4, 24);
		}
		public IList<ResultadoTest> MiMetodoTest()
		{
			IList<ResultadoTest> resultadoTests = new List<ResultadoTest>();
			foreach(KeyValuePair<int, int> test in ValoresTests)
			{
				ResultadoTest ResultadoTest = new ResultadoTest();
				ResultadoTest.Estado = TestFunc(test.Key, test.Value);
				resultadoTests.Add(ResultadoTest);
			}
			return resultadoTests;
		}
		public Ejercicio1Test()
		{
			this.Ejercicio1 = new Ejercicio1();
			SetTestFunc();
		}
	}
}
