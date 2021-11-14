using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.Service.Domain
{
	public class Perfil : PermisoComponent
	{
		public override IList<PermisoComponent> Permisos { get; set; }
		public Perfil()
		{
			Permisos = new List<PermisoComponent>();
		}
		public override void Agregar(PermisoComponent permiso)
		{
			Permisos.Add(permiso);
		}
		public override void Quitar(PermisoComponent permiso)
		{
			Permisos.Remove(permiso);
		}
	}
}
