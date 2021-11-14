using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio que representa una postulación a un aviso laboral
	/// de un profesional
	/// </summary>
	public class Postulacion : EntidadBase
	{
		/// <summary>
		/// Property que contiene la fecha de creación de una postulación
		/// </summary>
		public DateTime FechaCreacion { get; set; }
		/// <summary>
		/// Property que contiene el aviso laboral asociado a una postulación
		/// </summary>
		public AvisoLaboral AvisoLaboral { get; set; }
		/// <summary>
		/// Property que contiene el estado de una postulación
		/// </summary>
		public PostulacionEstado PostulacionEstado { get; set; }
		/// <summary>
		/// Property que contiene profesional asociado a una postulación
		/// </summary>
		public Profesional Profesional { get; set; }
		/// <summary>
		/// Property que contiene la fecha de creación en formato español de una postulación
		/// </summary>
		public string FechaCreacionDisplay
		{
			get
			{
				return FechaCreacion.ToString("dd/MM/yyyy");
			}
		}
	}
}
