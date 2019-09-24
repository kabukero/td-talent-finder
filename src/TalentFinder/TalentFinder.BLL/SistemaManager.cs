using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;

namespace TalentFinder.BLL
{
	public static class SistemaManager
	{
		public static Idioma Idioma;
		public static IdiomaManager IdiomaManager;

		static SistemaManager()
		{
			IdiomaManager = new IdiomaManager();
			Idioma = IdiomaManager.GetIdioma(Idiomas.ESPAÑOL); // idioma por defecto
		}
	}
}
