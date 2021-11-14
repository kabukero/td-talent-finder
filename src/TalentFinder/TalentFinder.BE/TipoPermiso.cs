using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio que representa un tipo de permiso (familia o patente)
	/// </summary>
	public class TipoPermiso : EntidadBase
	{
		/// <summary>
		/// Property que contiene el nombre de una familia o patente
		/// </summary>
		public string Nombre { get; set; }

		public override string ToString()
		{
			return Nombre;
		}
	}
}
