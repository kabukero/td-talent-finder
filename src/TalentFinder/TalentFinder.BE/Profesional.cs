using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class Profesional : EntidadBase
	{
		public List<AvisoLaboral> AvisosLaborales { get; set; }
	}
}
