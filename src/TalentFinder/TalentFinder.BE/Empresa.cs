using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class Empresa : EntidadBase
	{
		public string RazonSocial { get; set; }
		public string Direccion { get; set; }
		public string Telefono { get; set; }
		public string Email { get; set; }
		public string CUIT { get; set; }
		public DateTime FechaCreacion { get; set; }
		public DateTime FechaActualizacion { get; set; }
		public Int64 DVH { get; set; }
	}
}
