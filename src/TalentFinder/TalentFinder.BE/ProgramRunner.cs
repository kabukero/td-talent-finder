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
	/// <summary>
	/// Entidad de negocio que representa el runner de los programas
	/// que los usuarios crean en las evaluaciones que realizan
	/// </summary>
	public class ProgramRunner
	{
		/// <summary>
		/// Atributo que contiene el usuario autor de un programa
		/// </summary>
		private Usuario usuario;

		/// <summary>
		/// Property que contiene el compilador para generar el assembly
		/// </summary>
		public Compilador Compilador { get; }

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

		/// <summary>
		/// Constructor de la clase para inicializar el compilador y el usuario
		/// </summary>
		/// <param name="usuario">Usuario auto del programa</param>
		public ProgramRunner(Usuario usuario)
		{
			this.usuario = usuario;
			Compilador = new Compilador(usuario);
		}
	}
}
