using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio que representa el componente familia pantente
	/// </summary>
	public abstract class PermisoComponent : EntidadBase
	{
		/// <summary>
		/// Property que contiene el identificador del padre de la familia/patente
		/// </summary>
		public int PermisoPadreId { get; set; }
		/// <summary>
		/// Property que contiene el nombre de una familia / patente
		/// </summary>
		public string Nombre { get; set; }
		/// <summary>
		/// Property que contiene el nombre de una familia / patente
		/// </summary>
		public abstract IList<PermisoComponent> Permisos { get; set; }
		/// <summary>
		/// Método abstracto para agregar una familia / patente
		/// </summary>
		public abstract void Agregar(PermisoComponent permiso);
		/// <summary>
		/// Método abstracto para quitar una familia / patente
		/// </summary>
		public abstract void Quitar(PermisoComponent permiso);
		/// <summary>
		/// Método para mostrar el estado interno de una familia / patente
		/// </summary>
		public override string ToString()
		{
			return Nombre;
		}
	}
}
