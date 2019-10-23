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
		private IList<Frase> frases;
		public IList<Frase> Frases
		{
			get
			{
				return frases;
			}
		}
		public IList<IdiomaFrase> GetAllIdiomaFrases(Idioma idioma)
		{
			IList<IdiomaFrase> lista = new List<IdiomaFrase>();
			foreach(Frase f in frases)
			{
				IdiomaFrase idiomaFrase = new IdiomaFrase();
				idiomaFrase.IdiomaId = idioma.Id;
				idiomaFrase.Tag = f.Tag;
				lista.Add(idiomaFrase);
			}
			return lista;
		}
		private void SetIdiomas(IList<Idioma> Idiomas)
		{
			this.Idiomas = Idiomas;
		}
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
		public IList<Idioma> GetAllIdiomas()
		{
			SetIdiomas();
			return Idiomas;
		}
		public void AgregarIdioma(Idioma idioma)
		{
			IdiomaMapper.AgregarIdioma(idioma);
		}
		public void EditarIdioma(Idioma idioma)
		{
			IdiomaMapper.EditarIdioma(idioma);
		}
		public void EliminarIdioma(Idioma idioma)
		{
			IdiomaMapper.EliminarIdioma(idioma);
		}
		public Idioma NewIdioma(int id = 0, string nombre = null)
		{
			return new Idioma()
			{
				Id = id,
				Nombre = nombre
			};
		}
		public void SetIdiomas()
		{
			frases = IdiomaMapper.GetAllFrases();
			Idiomas = IdiomaMapper.GetAllIdiomas();

			foreach(Idioma idioma in Idiomas)
				if(idioma.Traducciones == null || idioma.Traducciones.Count == 0)
					idioma.Traducciones = GetAllIdiomaFrases(idioma);
		}
		public void GuardarTraducciones(IList<IdiomaFrase> idiomaFrases)
		{
			IdiomaMapper.GuardarTraducciones(idiomaFrases);
		}
		public IdiomaManager()
		{
			IdiomaMapper = new IdiomaMapper();
			SetIdiomas();
		}
	}
}
