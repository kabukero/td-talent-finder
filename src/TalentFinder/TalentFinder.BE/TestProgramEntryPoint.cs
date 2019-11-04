using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class TestProgramEntryPoint
	{
		public static void Main(string[] args)
		{
			if(args == null)
				Console.WriteLine("Error");

			IEjercicio Ejercicio = new Ejercicio();
			Ejercicio.Nombre = args[0];
			ITestEjercicio EjercicioTest = TestEjercicioFactory.GetEjercicio(Ejercicio);
			TestResultado resultado = EjercicioTest.MiMetodoTest();
			Console.Clear();
			Console.WriteLine("***BEGIN_SALIDA****");
			Console.WriteLine(resultado.Descripcion);
			foreach(TestItem item in resultado.TestItems)
				Console.WriteLine(item.Descripcion);
			Console.WriteLine("***END_SALIDA****");
		}
	}
}
