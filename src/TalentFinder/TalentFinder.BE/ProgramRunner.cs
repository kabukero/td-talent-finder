using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;

namespace TalentFinder.BE
{
	public class ProgramRunner
	{
		private Usuario usuario;
		private Compilador Compilador;
		public ResultadoEjecucion EjecutarPrograma(MetodoDetalle metodoDetalle)
		{
			ResultadoEjecucion ResultadoEjecucion = Compilador.CompilarPrograma(metodoDetalle);

			if(ResultadoEjecucion.ResultadoEjecucionEstado == ResultadoEjecucionEstado.ERROR_COMPILE)
				return ResultadoEjecucion;

			//Create process
			Process proceso = new System.Diagnostics.Process();

			//strCommand is path and file name of command to run
			proceso.StartInfo.FileName = ResultadoEjecucion.NombreProgramaEjecutable;

			//strCommandParameters are parameters to pass to program
			//proceso.StartInfo.Arguments = string.Format("-out:{0} {1}", nombreProgramaEjecutable, nombreArchivoPrograma);

			proceso.StartInfo.UseShellExecute = false;

			//Set output of program to be written to process output stream
			proceso.StartInfo.RedirectStandardOutput = true;

			//Optional
			//proceso.StartInfo.WorkingDirectory = ConfigurationManager.AppSettings["PathPrograms"].ToString();

			// not show black console window
			proceso.StartInfo.CreateNoWindow = true;

			//Start the process
			proceso.Start();

			//Get program output
			string strOutput = proceso.StandardOutput.ReadToEnd();

			//Wait for process to finish
			proceso.WaitForExit();

			ResultadoEjecucion.Descripcion = strOutput;

			if(ResultadoEjecucion.Descripcion.Contains("error"))
				ResultadoEjecucion.ResultadoEjecucionEstado = ResultadoEjecucionEstado.ERROR_EXECUTE;
			else
				ResultadoEjecucion.ResultadoEjecucionEstado = ResultadoEjecucionEstado.EXECUTED;

			return ResultadoEjecucion;
		}
		public ProgramRunner(Usuario usuario)
		{
			this.usuario = usuario;
			Compilador = new Compilador(usuario);
		}
	}
}
