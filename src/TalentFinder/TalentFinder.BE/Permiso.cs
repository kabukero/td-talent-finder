using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio que representa una patente dentro del sistema
	/// </summary>
	public class Permiso : PermisoComponent
	{
		/// <summary>
		/// Lista de patentes
		/// </summary>
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
