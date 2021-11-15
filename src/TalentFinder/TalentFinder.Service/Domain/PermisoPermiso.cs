using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.Service.Domain
{
	/// <summary>
	/// Entidad de negocio que relaciona la estructura arbol de una familia / patente
	/// </summary>
	public class PermisoPermiso
	{
		/// <summary>
		/// Property que contiene el identificador de una familia / patente 
		/// </summary>
		public int PermisoId { get; set; }
		/// <summary>
		/// Property que contiene el identificador de una familia / patente padre
		/// </summary>
		public int PermisoPadreId { get; set; }
	}
}
