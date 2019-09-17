using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class AvisoLaboral : EntidadBase
	{
		public DateTime FechaVigencia { get; set; }
		public DateTime FechaVencimiento { get; set; }
		public DateTime FechaCreacion { get; set; }
	}
}
