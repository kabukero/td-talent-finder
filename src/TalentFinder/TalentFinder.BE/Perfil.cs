using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class Perfil : PermisoComponent
	{
		public List<PermisoComponent> Permisos { get; set; }

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
