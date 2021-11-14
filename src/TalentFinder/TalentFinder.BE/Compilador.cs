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
		public Usuario Usuario { get; }
		public Parser Parser { get; }
		public string CarpetaTalenFinder { get; }
		public string CarpetaUsuario { get; }
		public string CarpetaUsuarioEvaluaciones { get; }

		private string CrearPrograma(MetodoDetalle MetodoDetalle)
		{
			if(!Directory.Exists(CarpetaTalenFinder))
				Directory.CreateDirectory(CarpetaTalenFinder);

			if(!Directory.Exists(CarpetaUsuario))
				Directory.CreateDirectory(CarpetaUsuario);

			if(!Directory.Exists(CarpetaUsuarioEvaluaciones))
				Directory.CreateDirectory(CarpetaUsuarioEvaluaciones);

			string codigoPrograma = Parser.GetCodigoFuente(MetodoDetalle);
			string nombreArchivoPrograma = Path.Combine(CarpetaUsuarioEvaluaciones, string.Format("{0}_{1}.cs", "programa_fuente", DateTime.Now.ToString("yyyyMMddhhmmssmmm")));
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

			//Create process
			Process proceso = new Process();

			//strCommand is path and file name of command to run
			proceso.StartInfo.FileName = ConfigurationManager.AppSettings["CommandCSharpCompiler"].ToString();
			//string cmd = string.Format("c:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\csc.exe /out:{0} {1}", ResultadoEjecucion.NombreProgramaEjecutable, ResultadoEjecucion.NombreArchivoPrograma);
			//string cmd = string.Format("csc.exe /out:{0} {1}", ResultadoEjecucion.NombreProgramaEjecutable, ResultadoEjecucion.NombreArchivoPrograma);
			//string cmd = "csc.exe /out:d:\\Academico\\uai\\materias\\trabajo-diploma\\trabajo-diploma-proyecto\\src\\TalentFinder\\TalentFinder.GUI\\bin\\Debug\\1\\21112019\\examen_programa_21112019.exe d:\\Academico\\uai\\materias\\trabajo-diploma\\trabajo-diploma-proyecto\\src\\TalentFinder\\TalentFinder.GUI\\bin\\Debug\\1\\21112019\\examen_programa_21112019.cs";
			//string cmd = @"csc.exe /out:examen_programa_21112019.exe examen_programa_21112019.cs";
			//proceso.StartInfo.FileName = cmd;
			//proceso.StartInfo.FileName = "csc.exe";

			//strCommandParameters are parameters to pass to program
			string cmdArguments = string.Format("/out:{0} {1}", ResultadoEjecucion.NombreProgramaEjecutable, ResultadoEjecucion.NombreArchivoPrograma);
			proceso.StartInfo.Arguments = cmdArguments;

			proceso.StartInfo.UseShellExecute = false;

			//Set output of program to be written to process output stream
			proceso.StartInfo.RedirectStandardOutput = true;

			//Optional
			//proceso.StartInfo.WorkingDirectory = ConfigurationManager.AppSettings["PathPrograms"].ToString();
			proceso.StartInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;

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
			Usuario = usuario;
			Parser = new Parser();
			CarpetaTalenFinder = Environment.ExpandEnvironmentVariables(ConfigurationManager.AppSettings["CarpetaTalentFinder"].ToString());
			CarpetaUsuario = Path.Combine(CarpetaTalenFinder, "usuarios", Usuario.Id.ToString());
			CarpetaUsuarioEvaluaciones = Path.Combine(CarpetaUsuario, "evaluaciones", DateTime.Now.ToString("ddMMyyyy"));
		}
	}
}
