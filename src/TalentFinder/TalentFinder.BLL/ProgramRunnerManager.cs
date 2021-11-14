using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;

namespace TalentFinder.BLL
{
	public class ProgramRunnerManager
	{
		private ProgramRunner ProgramRunner;
		private Compilador Compilador;

		public ProgramRunnerManager(ProgramRunner programRunner, Compilador compilador)
		{
			ProgramRunner = programRunner;
			Compilador = compilador;
		}

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
