using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.Service.Domain
{
	/// <summary>
	/// Entidad de negocio que representa un perfil dentro dentro del sistema
	/// </summary>
	public class Perfil : PermisoComponent
	{
		/// <summary>
		/// Lista que contiene que las familias patentes disponibles en el sistema
		/// </summary>
		public override IList<PermisoComponent> Permisos { get; set; }
		/// <summary>
		/// Constructor para inicializar la lista de permisos
		/// </summary>
		public Perfil()
		{
			Permisos = new List<PermisoComponent>();
		}
		/// <summary>
		/// Método para agregar una familia / patente a las lista de permisos
		/// </summary>
		/// <param name="permiso">una familia / patente</param>
		public override void Agregar(PermisoComponent permiso)
		{
			Permisos.Add(permiso);
		}
		/// <summary>
		/// Método para quitar una familia / patente a las lista de permisos
		/// </summary>
		/// <param name="permiso">una familia / patente</param>
		public override void Quitar(PermisoComponent permiso)
		{
			Permisos.Remove(permiso);
		}
	}
}
