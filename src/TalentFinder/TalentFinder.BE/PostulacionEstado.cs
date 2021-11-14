using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio que representa el estado de una postulación
	/// </summary>
	public class PostulacionEstado : EntidadBase
	{
		/// <summary>
		/// Property que contiene el nombre del estado de una postulación
		/// </summary>
		public string Nombre { get; set; }
		public override string ToString()
		{
			return Nombre;
		}
	}
}
