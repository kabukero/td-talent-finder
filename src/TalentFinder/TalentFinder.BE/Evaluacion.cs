using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio que representa la evalución que va realizar
	/// un profesional que se postula a un aviso laboral
	/// </summary>
	public class Evaluacion : EntidadBase
	{
		/// <summary>
		/// Property que contiene la descripción de una evalución
		/// </summary>
		public string Descripcion { get; set; }
		/// <summary>
		/// Property que contiene el codigo fuente de las pruebas unitarias de una evalución
		/// </summary>
		public string CodigoFuenteTest { get; set; }
		/// <summary>
		/// Property que contiene el enunciado del ejercicio de una evalución
		/// </summary>
		public string Ejercicio { get; set; }
		/// <summary>
		/// Property que contiene la duracion en foramto HH:SS de una evalución
		/// </summary>
		public string Tiempo { get; set; }
	}
}
