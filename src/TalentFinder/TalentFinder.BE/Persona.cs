using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class Persona : EntidadBase
	{
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public Usuario Usuario { get; set; }
	}
}
