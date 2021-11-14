using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio que representa la evaluación asignada
	/// a una postulación
	/// </summary>
	public class PostulacionEvaluacion : EntidadBase
	{
		/// <summary>
		/// Property que contiene la fecha de creación de la postulación evaluación
		/// </summary>
		public DateTime FechaCreacion { get; set; }
		/// <summary>
		/// Property que contine la respuesta de la evaluación
		/// </summary>
		public string Respuesta { get; set; }
		/// <summary>
		/// Property que describe si el postulante aprobo o no la evaluación
		/// </summary>
		public bool Aprobo { get; set; }
		/// <summary>
		/// Property que contiene el tiempo máximo para resolver la evaluación
		/// </summary>
		public string TiempoResolucionEvaluacion { get; set; }
		/// <summary>
		/// Property que contiene la evaluación
		/// </summary>
		public Evaluacion Evaluacion { get; set; }
	}
}
