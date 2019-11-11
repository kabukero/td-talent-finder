using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;
using TalentFinder.DAL;

namespace TalentFinder.BLL
{
	public class ReclutadorManager
	{
		private ReclutadorMapper ReclutadorMapper = new ReclutadorMapper();
		public Reclutador GetReclutador(Usuario usuario)
		{
			return ReclutadorMapper.GetReclutador(usuario);
		}
	}
}