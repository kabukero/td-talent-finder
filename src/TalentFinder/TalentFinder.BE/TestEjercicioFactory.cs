using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class TestEjercicioFactory
	{
		public static ITestEjercicio GetEjercicio(IEjercicio Ejercicio)
		{
			ITestEjercicio EjercicioTest = null;
			switch(Ejercicio.Nombre)
			{
				case "Ejercicio1":
					EjercicioTest = new TestEjercicio1(Ejercicio);
					break;
				case "Ejercicio2":
					EjercicioTest = new TestEjercicio1(Ejercicio);
					break;
				case "Ejercicio3":
					EjercicioTest = new TestEjercicio1(Ejercicio);
					break;
				case "Ejercicio4":
					EjercicioTest = new TestEjercicio1(Ejercicio);
					break;
				case "Ejercicio5":
					EjercicioTest = new TestEjercicio1(Ejercicio);
					break;
				default:
					break;
			}
			return EjercicioTest;
		}
	}
}
