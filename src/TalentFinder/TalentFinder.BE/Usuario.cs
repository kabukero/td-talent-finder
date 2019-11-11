using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class Usuario : EntidadBase
	{
		public string UserName { get; set; }
		public string UserPassword { get; set; }
		public override string ToString()
		{
			return UserName;
		}
		public List<PermisoComponent> PermisoComponent { get; set; }
		public Int64 DVH { get; set; }
		public UsuarioTipo UsuarioTipo { get; set; }
	}
}
