using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;
using TalentFinder.DAL;

namespace TalentFinder.BLL
{
	public class AvisoLaboralManager
	{
		private AvisoLaboralMapper AvisoLaboralMapper = new AvisoLaboralMapper();
		public List<AvisoLaboral> GetAvisos(string palabraClave, string lugarTrabajo, string tecnologias)
		{
			return AvisoLaboralMapper.GetAvisos(palabraClave, lugarTrabajo, tecnologias);
		}
	}
}
