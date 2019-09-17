using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class Reclutador : Persona
	{
		public List<Postulacion> Postulaciones { get; set; }
	}
}
