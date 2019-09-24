using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;
using TalentFinder.DAL;

namespace TalentFinder.BLL
{
	public class IdiomaManager
	{
		private IdiomaMapper IdiomaMapper;
		private IList<Idioma> Idiomas;

		public Idioma GetIdioma(Idiomas IdiomaId)
		{
			return Idiomas.Where(x => x.Id == (int)IdiomaId).FirstOrDefault();
		}

		public IdiomaFrase GetTraduccion(Idioma idioma, Frase frase)
		{
			IdiomaFrase idiomaFrase = null;
			Idioma idiomaElegido = Idiomas.Where(x => x.Id == idioma.Id).FirstOrDefault();
			if(idiomaElegido != null)
				idiomaFrase = idiomaElegido.Traducciones.Where(x => x.Tag == frase.Tag).FirstOrDefault();
			return idiomaFrase;
		}

		public IdiomaManager()
		{
			IdiomaMapper = new IdiomaMapper();
			Idiomas = IdiomaMapper.GetAllIdiomas();
		}

		public IList<Idioma> GetAllIdiomas()
		{
			return IdiomaMapper.GetAllIdiomas();
		}
	}
}
