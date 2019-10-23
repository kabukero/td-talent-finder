using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BLL
{
	public class ProgramRunner
	{
		private string CrearPrograma(string codigoMetodo)
		{
			string codigoPrograma = @"using System;public static class Program{public static void Main(){Console.WriteLine(""Hello World"");} " + codigoMetodo + " }";
			string nombrePrograma = string.Format("{0}/{1}_{2}.cs", ConfigurationManager.AppSettings["PathPrograms"].ToString(), "examen_programa", DateTime.Now.ToString("ddMMyyyyHHmmss"));
			FileStream archivo = new FileStream(nombrePrograma, FileMode.Create);
			StreamWriter escritor = new StreamWriter(archivo);
			escritor.WriteLine(codigoPrograma);
			escritor.Close();
			archivo.Close();
			return nombrePrograma;
		}

		public string EjecutarPrograma(string codigoPrograma)
		{
			string nombreArchivoPrograma = CrearPrograma(codigoPrograma);

			//Create process
			System.Diagnostics.Process pProcess = new System.Diagnostics.Process();

			//strCommand is path and file name of command to run
			pProcess.StartInfo.FileName = ConfigurationManager.AppSettings["CommandCSharpCompiler"].ToString();

			//strCommandParameters are parameters to pass to program
			pProcess.StartInfo.Arguments = nombreArchivoPrograma;

			pProcess.StartInfo.UseShellExecute = false;

			//Set output of program to be written to process output stream
			pProcess.StartInfo.RedirectStandardOutput = true;

			//Optional
			pProcess.StartInfo.WorkingDirectory = ConfigurationManager.AppSettings["PathPrograms"].ToString();

			// not show black console window
			pProcess.StartInfo.CreateNoWindow = true;

			//Start the process
			pProcess.Start();

			//Get program output
			string strOutput = pProcess.StandardOutput.ReadToEnd();

			//Wait for process to finish
			pProcess.WaitForExit();

			return strOutput;
		}
	}
}
