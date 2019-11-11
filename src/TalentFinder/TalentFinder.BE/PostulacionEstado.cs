using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class PostulacionEstado : EntidadBase
	{
		public string Nombre { get; set; }
		public override string ToString()
		{
			return Nombre;
		}
	}
}
