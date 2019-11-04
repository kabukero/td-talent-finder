using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class TestEjercicio1 : ITestEjercicio
	{
		private IList<TestItem> TestItems;
		private Func<int, int, bool> TestDelegadoFunc;
		private IEjercicio Ejercicio;
		private void SetTestFunc()
		{
			TestDelegadoFunc = (n, m) => Ejercicio.MiMetodo(n) == m;
		}
		private void CargarValoresTests()
		{
			TestItems = new List<TestItem>();
			TestItems.Add(new TestItem() { NumeroTest = 1, NumeroEjercicio = 1, ParametroEntrada = 0, ValorResultadoEsperado = 1 });
			TestItems.Add(new TestItem() { NumeroTest = 2, NumeroEjercicio = 1, ParametroEntrada = 1, ValorResultadoEsperado = 1 });
			TestItems.Add(new TestItem() { NumeroTest = 3, NumeroEjercicio = 1, ParametroEntrada = 4, ValorResultadoEsperado = 24 });
		}
		public TestResultado MiMetodoTest()
		{
			// ejecutar casos de test
			foreach(TestItem testItem in TestItems)
			{
				testItem.Error = TestDelegadoFunc(testItem.ParametroEntrada, testItem.ValorResultadoEsperado);
				testItem.Descripcion = testItem.Error ? "SUCCESS" : "ERROR";
			}
			// retornar objeto resultado del test
			TestResultado ResultadoTest = new TestResultado();
			ResultadoTest.TestItems = TestItems;
			ResultadoTest.Estado = ResultadoTest.TestItems.Any(x => x.Error);
			ResultadoTest.Descripcion = ResultadoTest.Estado ? "ERROR" : "OK";
			return ResultadoTest;
		}
		public TestEjercicio1(IEjercicio Ejercicio)
		{
			this.Ejercicio = Ejercicio;
			SetTestFunc();
			CargarValoresTests();
		}
	}
}
