using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;

namespace TalentFinder.BLL
{
	public class ProgramRunner
	{
		private string CrearPrograma(string codigoMetodo)
		{
			string codigoPrograma = @"using System;public static class Program{public static void Main(){Console.WriteLine(""Hello World"");} " + codigoMetodo + " }";
			string nombreArchivoPrograma = string.Format("{0}/{1}_{2}.cs", ConfigurationManager.AppSettings["PathPrograms"].ToString(), "examen_programa", DateTime.Now.ToString("ddMMyyyyHHmmss"));
			FileStream archivo = new FileStream(nombreArchivoPrograma, FileMode.Create);
			StreamWriter escritor = new StreamWriter(archivo);
			escritor.WriteLine(codigoPrograma);
			escritor.Close();
			archivo.Close();
			return nombreArchivoPrograma;
		}

		public ResultadoEjecucion EjecutarPrograma(string codigoMetodo)
		{
			string nombreArchivoPrograma = CrearPrograma(codigoMetodo);

			//Create process
			System.Diagnostics.Process proceso = new System.Diagnostics.Process();

			//strCommand is path and file name of command to run
			proceso.StartInfo.FileName = ConfigurationManager.AppSettings["CommandCSharpCompiler"].ToString();

			//strCommandParameters are parameters to pass to program
			proceso.StartInfo.Arguments = nombreArchivoPrograma;

			proceso.StartInfo.UseShellExecute = false;

			//Set output of program to be written to process output stream
			proceso.StartInfo.RedirectStandardOutput = true;

			//Optional
			proceso.StartInfo.WorkingDirectory = ConfigurationManager.AppSettings["PathPrograms"].ToString();

			// not show black console window
			proceso.StartInfo.CreateNoWindow = true;

			//Start the process
			proceso.Start();

			//Get program output
			string strOutput = proceso.StandardOutput.ReadToEnd();

			//Wait for process to finish
			proceso.WaitForExit();

			ResultadoEjecucion ResultadoEjecucion = new ResultadoEjecucion();
			ResultadoEjecucion.Descripcion = strOutput;

			if(ResultadoEjecucion.Descripcion.Contains("error"))
				ResultadoEjecucion.ResultadoEjecucionEstado = ResultadoEjecucionEstado.ERROR;
			else
				ResultadoEjecucion.ResultadoEjecucionEstado = ResultadoEjecucionEstado.EXECUTED;

			return ResultadoEjecucion;
		}
	}
}
