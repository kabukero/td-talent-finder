using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.Service.Domain
{
	public abstract class PermisoComponent : EntidadBase
	{
		public int PermisoPadreId { get; set; }
		public string Nombre { get; set; }
		public abstract IList<PermisoComponent> Permisos { get; set; }
		public abstract void Agregar(PermisoComponent permiso);
		public abstract void Quitar(PermisoComponent permiso);
		public override string ToString()
		{
			return Nombre;
		}
	}
}
