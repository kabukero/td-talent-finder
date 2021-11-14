using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio que representa una tecnología dentro del sistema
	/// </summary>
	public class Tecnologia : EntidadBase
	{
		/// <summary>
		/// Property que contiene el nombre de una tecnología
		/// </summary>
		public string Nombre { get; set; }
		public override string ToString()
		{
			return Nombre;
		}
	}
}
