using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio que representa una persona física
	/// dentro del sistema
	/// </summary>
	public class Persona : EntidadBase
	{
		/// <summary>
		/// Property que contiene el nombre de una persona
		/// </summary>
		public string Nombre { get; set; }
		/// <summary>
		/// Property que contiene el apellido de una persona
		/// </summary>
		public string Apellido { get; set; }
		/// <summary>
		/// Property que contiene el e-mail de una persona
		/// </summary>
		public string Email { get; set; }
		/// <summary>
		/// Property que contiene el usuario asociado a una persona
		/// </summary>
		public Usuario Usuario { get; set; }
		/// <summary>
		/// Property que contiene la empresa asociada a una persona
		/// </summary>
		public Empresa Empresa { get; set; }
	}
}
