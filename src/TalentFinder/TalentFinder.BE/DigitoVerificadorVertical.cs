using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class DigitoVerificadorVertical : EntidadBase
	{
		public TablaSistema TablaSistema { get; set; }
		public DateTime FechaCreacion { get; set; }
		public DateTime FechaActualizacion { get; set; }
		public Int64 DVV { get; set; }
	}
}
