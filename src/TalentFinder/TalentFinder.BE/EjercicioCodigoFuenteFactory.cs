using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class EjercicioCodigoFuenteFactory
	{
		public string GetCodigoFuente(string nombreEjercicio)
		{
			string codigoFuentePrograma = "";
			switch(nombreEjercicio)
			{
				case "Ejercicio1":
					codigoFuentePrograma = @"
					using System;
					using System.Collections.Generic;
					using System.Linq;
					using System.Text;

					public static class Program
					{
						static Random random;
						static Program()
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
								int[] v = GetRandomArray();
								int resultadoObtenido = MiMetodo(v);
								int resultadoEsperado = ImplementacionDeseadaMiMetodo(v);
								Console.Write(string.Format(""Resultado obtenido: {0} Resultado esperado: {1}"", resultadoObtenido, resultadoEsperado));
								if(resultadoObtenido == resultadoEsperado)
										Console.WriteLine("" SUCCESS"");
									else
										Console.WriteLine("" ERROR"");
							}
						}
						static int[] GetRandomArray()
						{
							int len = random.Next(1, 100);
							int[] v = new int[len];
							for(int i = 0; i < len; i++)
								v[i] = random.Next(-1000, 1000);
							return v;
						}
						static int ImplementacionDeseadaMiMetodo(int[] numeros)
						{
							int suma = 0;
							for(int i = 0; i < numeros.Length; i++)
								suma += numeros[i];
							return suma;
						}
						static XXX_MI_METODO_XXX
					}";
					break;
				case "Ejercicio2":
					codigoFuentePrograma = @"
					using System;
					using System.Collections.Generic;
					using System.Linq;
					using System.Text;

					public static class Program
					{
						static Random random;
						static Program()
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
								int numero;
								if(i < 2)
									numero = i;
								else
									numero = random.Next(0, 12);
								int resultadoObtenido = MiMetodo(numero);
								int resultadoEsperado = ImplementacionDeseadaMiMetodo(numero);
								Console.Write(string.Format(""Resultado obtenido: {0} Resultado esperado: {1}"", resultadoObtenido, resultadoEsperado));
								if(resultadoObtenido == resultadoEsperado)
										Console.WriteLine("" SUCCESS"");
									else
										Console.WriteLine("" ERROR"");
							}
						}
						static int ImplementacionDeseadaMiMetodo(int numero)
						{
							int factorial = 1;
							for(int i = 1; i <= numero; i++)
								factorial = factorial * i;
							return factorial;
						}
						static XXX_MI_METODO_XXX
					}";
					break;
				case "Ejercicio3":
					codigoFuentePrograma = @"
					using System;
					using System.Collections.Generic;
					using System.Linq;
					using System.Text;

					public static class Program
					{
						static Random random;
						static Program()
						{
							random = new Random();
						}
						static void Main(string[] args)
						{
							TestMiMetodo();
						}
						static string GetRandomString()
						{
							string str = """";
							int len = random.Next(1, 10);
							for(int k = 0; k < len; k++)
							{
								for(int i = 0; i < random.Next(1, 20); i++)
								{
									str += ((char)('a' + random.Next(0, 26))).ToString();
								}
								for(int j = 0; j < random.Next(1, 20); j++)
								{
									str += "" "";
								}
						}
							return str;
						}
					static void TestMiMetodo()
					{
						for(int i = 0; i < 5; i++)
						{
							string valor = GetRandomString();
							int resultadoObtenido = MiMetodo(valor);
							int resultadoEsperado = ImplementacionDeseadaMiMetodo(valor);
							Console.Write(string.Format(""Resultado obtenido: {0} Resultado esperado: {1}"", resultadoObtenido, resultadoEsperado));
							if(resultadoObtenido == resultadoEsperado)
								Console.WriteLine("" SUCCESS"");
							else
								Console.WriteLine("" ERROR"");
						}
					}
					static int ImplementacionDeseadaMiMetodo(string oracion)
					{
						int cantidadPalabras = 0;
						string[] arrayOracion = oracion.Split(' ');
						for(int i = 0; i < arrayOracion.Length; i++)
						{
							if(!string.IsNullOrEmpty(arrayOracion[i]))
								cantidadPalabras++;
						}
						return cantidadPalabras;
					}
					static XXX_MI_METODO_XXX
					}";
					break;

			}
			return codigoFuentePrograma;
		}
	}
}
