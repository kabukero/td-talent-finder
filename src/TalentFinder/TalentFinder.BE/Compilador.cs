using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class Compilador
	{
		private Parser Parser = new Parser();
		private string UserId;
		private string carpetaUser;
		private string carpetaUserProgram;
		private string CrearPrograma(MetodoDetalle MetodoDetalle)
		{
			if(!Directory.Exists(carpetaUser))
				Directory.CreateDirectory(carpetaUser);

			if(!Directory.Exists(carpetaUserProgram))
				Directory.CreateDirectory(carpetaUserProgram);

			string codigoPrograma = Parser.GetCodigoFuente(MetodoDetalle);
			string nombreArchivoPrograma = Path.Combine(carpetaUserProgram, string.Format("{0}_{1}.cs", "examen_programa", DateTime.Now.ToString("ddMMyyyy")));
			FileStream archivo = new FileStream(nombreArchivoPrograma, FileMode.Create);
			StreamWriter escritor = new StreamWriter(archivo);
			escritor.WriteLine(codigoPrograma);
			escritor.Close();
			archivo.Close();
			return nombreArchivoPrograma;
		}
		public ResultadoEjecucion CompilarPrograma(MetodoDetalle metodoDetalle)
		{
			ResultadoEjecucion ResultadoEjecucion = new ResultadoEjecucion();
			ResultadoEjecucion.NombreArchivoPrograma = CrearPrograma(metodoDetalle);
			ResultadoEjecucion.NombreProgramaEjecutable = ResultadoEjecucion.NombreArchivoPrograma.Substring(0, ResultadoEjecucion.NombreArchivoPrograma.Length - 3) + ".exe";

			//Create process
			Process proceso = new System.Diagnostics.Process();

			//strCommand is path and file name of command to run
			//proceso.StartInfo.FileName = ConfigurationManager.AppSettings["CommandCSharpCompiler"].ToString();
			proceso.StartInfo.FileName = "csc.exe";

			//strCommandParameters are parameters to pass to program
			proceso.StartInfo.Arguments = string.Format("/out:{0} {1}", ResultadoEjecucion.NombreProgramaEjecutable, ResultadoEjecucion.NombreArchivoPrograma);

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
				ResultadoEjecucion.ResultadoEjecucionEstado = ResultadoEjecucionEstado.ERROR_COMPILE;
			else
				ResultadoEjecucion.ResultadoEjecucionEstado = ResultadoEjecucionEstado.COMPILED;
			return ResultadoEjecucion;
		}
		public Compilador(Usuario usuario)
		{
			UserId = usuario.Id.ToString();
			carpetaUser = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, UserId);
			carpetaUserProgram = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, UserId, DateTime.Now.ToString("ddMMyyyy"));
		}
	}
}
