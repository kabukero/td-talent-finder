using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.Service.Domain
{
	public class Permiso : PermisoComponent
	{
		public override IList<PermisoComponent> Permisos { get; set; }
		public override void Agregar(PermisoComponent permiso)
		{
			//throw new NotImplementedException();
		}
		public override void Quitar(PermisoComponent permiso)
		{
			//throw new NotImplementedException();
		}
	}
}
