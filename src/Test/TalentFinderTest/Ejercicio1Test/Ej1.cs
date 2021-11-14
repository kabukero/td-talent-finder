using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Test
{
	public class Ej1
	{
		static Random random;

		static Ej1()
		{
			random = new Random();
		}

		static void Main(string[] args)
		{ 
			TestMiMetodo();
		}

		static void TestMiMetodo()
		{
			for(int i = 0; i < 5; i++)
			{
				int numero = random.Next(0, 12);

				int resultadoObtenido = MiMetodo(numero);

				int resultadoEsperado = ImplementacionDeseadaMiMetodo(numero);

				Console.Write(string.Format("Resultado obtenido: {0} Resultado esperado: {1}", resultadoObtenido, resultadoEsperado));

				if(resultadoObtenido == resultadoEsperado)
					Console.WriteLine(" SUCCESS");
				else
					Console.WriteLine(" ERROR");
			}
		}

		static int ImplementacionDeseadaMiMetodo(int numero)
		{
			int factorial = 1;
			for(int i = 1; i <= numero; i++)
				factorial = factorial * i;
			return factorial;
		}

		//static XXX_MI_METODO_XXX

		static int MiMetodo(int numero)
		{
			int factorial = 1;
			for(int i = 1; i <= numero; i++)
				factorial = factorial * i; return factorial;
		}

		public class ResultadoTest
		{

		}
	}
}
