using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio que representa el resultado de la ejecución de un programa
	/// </summary>
	public class ResultadoEjecucion
	{
		/// <summary>
		/// Property que contiene el nombre del archivo del programa generado por el sistema
		/// </summary>
		public string NombreArchivoPrograma { get; set; }

		public string NombreProgramaEjecutable
		{
			get
			{
				return ObtenerNombreProgramaEjecutable();
			}
		}

		/// <summary>
		/// Property que contiene la descripción del resultado de la ejecución de un programa
		/// </summary>
		public string Descripcion { get; set; }

		/// <summary>
		/// Property que contiene el estado de la ejecución de un programa
		/// </summary>
		public ResultadoEjecucionEstado ResultadoEjecucionEstado { get; set; }

		/// <summary>
		/// Método para obtener el nombre del programa ejecutable
		/// </summary>
		/// <returns>Nombre del programa ejecutable</returns>
		private string ObtenerNombreProgramaEjecutable()
		{
			return NombreArchivoPrograma.Substring(0, NombreArchivoPrograma.Length - 3) + ".exe";
		}

	}
}
