using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio que representa el codigo fuente escrito por el usuario
	/// </summary>
	public class MetodoDetalle
	{
		/// <summary>
		/// Property que contiene el nombre del ejercicio a evaluar
		/// </summary>
		public string EjercicioNombre { get; set; }
		/// <summary>
		/// Property que contiene el codigo fuente de las pruebas unitarias del ejercicio
		/// </summary>
		public string CodigoFuenteTest { get; set; }
		/// <summary>
		/// Propety que contiene el codigo fuente escrito por el usuario durante la resolución de
		/// la evaluación
		/// </summary>
		public string CodigoFuenteMetodo { get; set; }
	}
}
