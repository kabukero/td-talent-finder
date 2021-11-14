using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.Service.Domain
{
	public class Persona : EntidadBase
	{
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public string Email { get; set; }
		public Usuario Usuario { get; set; }
		public Empresa Empresa { get; set; }
	}
}
