using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;

namespace TalentFinder.BLL
{
	/// <summary>
	/// Entidad de negocio que representa el runner de los programas
	/// que los usuarios crean en las evaluaciones que realizan
	/// </summary>
	public class ProgramRunnerManager
	{
		/// <summary>
		/// Atributo que contiene el program runner de un programa
		/// </summary>
		private ProgramRunner ProgramRunner;

		/// <summary>
		/// Atributo que contiene el compilador de un programa
		/// </summary>
		private Compilador Compilador;


		/// <summary>
		/// Constructor de la clase para iniciar el program runner y en compilador
		/// </summary>
		/// <param name="programRunner">Un program runner</param>
		/// <param name="compilador">Un compilador</param>
		public ProgramRunnerManager(ProgramRunner programRunner, Compilador compilador)
		{
			ProgramRunner = programRunner;
			Compilador = compilador;
		}

		/// <summary>
		/// Método que ejecuta el assembly generado por el compilador
		/// </summary>
		/// <param name="metodoDetalle">Código fuente del programa escrito por el usuario</param>
		/// <returns>Resultado de la ejecución</returns>
		public ResultadoEjecucion EjecutarPrograma(MetodoDetalle metodoDetalle)
		{
			ResultadoEjecucion ResultadoEjecucion = null;
			try
			{
				ResultadoEjecucion = Compilador.CompilarPrograma(metodoDetalle);

				if(ResultadoEjecucion.ResultadoEjecucionEstado == ResultadoEjecucionEstado.ERROR_COMPILE)
					return ResultadoEjecucion;

				// Crear proceso
				Process proceso = Process.Start(ObtenerProcesoConfiguracion(ResultadoEjecucion.NombreProgramaEjecutable));

				// Obtener salida del programa
				string strOutput = proceso.StandardOutput.ReadToEnd();
				string strError = proceso.StandardError.ReadToEnd();

				// Esperar que el proceso finalice
				proceso.WaitForExit();

				ResultadoEjecucion.Descripcion = strOutput;

				ResultadoEjecucion.ResultadoEjecucionEstado = ResultadoEjecucion.Descripcion.Contains("error") ? ResultadoEjecucionEstado.ERROR_EXECUTE : ResultadoEjecucionEstado.EXECUTED;
			}
			catch(Exception ex)
			{
				throw new Exception("error ejecucion: " + ex.Message);
			}

			return ResultadoEjecucion;
		}

		/// <summary>
		/// Mëtodo para obtener el objeto process para poder ejecutar un programa en segundo plano
		/// </summary>
		/// <param name="RutaNombreProgramaEjecutable"></param>
		/// <returns>Un process info</returns>
		private ProcessStartInfo ObtenerProcesoConfiguracion(string RutaNombreProgramaEjecutable)
		{
			ProcessStartInfo configuracion = new ProcessStartInfo();
			//configuracion.WorkingDirectory = @"c:\Windows\Microsoft.NET\Framework\v4.0.30319\";
			//configuracion.FileName = @"c:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe";
			//configuracion.Arguments = RutaNombreProgramaEjecutable;
			configuracion.FileName = RutaNombreProgramaEjecutable;
			configuracion.CreateNoWindow = true;
			configuracion.RedirectStandardOutput = true;
			configuracion.RedirectStandardError = true;
			configuracion.UseShellExecute = false;
			return configuracion;
		}

	}
}
