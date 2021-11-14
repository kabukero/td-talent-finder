using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio que representa la clase de base de las demás entidades
	/// </summary>
	public class EntidadBase
	{
		/// <summary>
		/// Property que contiene el identificador de una entidad de negocio
		/// </summary>
		public int Id { get; set; }
	}
}
