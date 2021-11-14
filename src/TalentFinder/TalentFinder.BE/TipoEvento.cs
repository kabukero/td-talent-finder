using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio que representa un tipo de evento que ocurre en el sistema
	/// </summary>
	public class TipoEvento : EntidadBase
	{
		/// <summary>
		/// Property que contiene el nombre del tipo de evento
		/// </summary>
		public string Nombre { get; set; }
		public override string ToString()
		{
			return Nombre;
		}
	}
}
