using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;
using TalentFinder.DAL;

namespace TalentFinder.BLL
{
	/// <summary>
	/// Entidad de negocio para gestionar los idiomas del sistema
	/// </summary>
	public class IdiomaManager
	{
		/// <summary>
		/// Atributo que contiene el mapper del idioma para gestionar la persistencia
		/// </summary>
		private IdiomaMapper IdiomaMapper;

		/// <summary>
		/// Atributo que contiene la lista de idiomas del sistema
		/// </summary>
		private IList<Idioma> Idiomas;

		/// <summary>
		/// Atributo que contiene la lista de frases del sistema
		/// </summary
		private IList<Frase> frases;

		public IList<Frase> Frases
		{
			get
			{
				return frases;
			}
		}

		/// <summary>
		/// Método para obtener la lista de idiomas frases del sistema
		/// </summary>
		/// <param name="idioma">Entidad idioma</param>
		/// <returns>Lista de idiomas frases</returns>
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

		/// <summary>
		/// Setter de la lista de idiomas
		/// </summary>
		/// <param name="Idiomas"></param>
		private void SetIdiomas(IList<Idioma> Idiomas)
		{
			this.Idiomas = Idiomas;
		}

		/// <summary>
		/// Método para obtener un idioma por su id
		/// </summary>
		/// <param name="IdiomaId">Id del idioma</param>
		/// <returns>Entidad idioma encontrada</returns>
		public Idioma GetIdioma(Idiomas IdiomaId)
		{
			return Idiomas.Where(x => x.Id == (int)IdiomaId).FirstOrDefault();
		}

		/// <summary>
		/// Método para obtener la traducción según un idimoa y frase
		/// </summary>
		/// <param name="idioma">Un idioma</param>
		/// <param name="frase">Una frase</param>
		/// <returns>Entidad IdiomaFrase encontrada</returns>
		public IdiomaFrase GetTraduccion(Idioma idioma, Frase frase)
		{
			IdiomaFrase idiomaFrase = null;
			Idioma idiomaElegido = Idiomas.Where(x => x.Id == idioma.Id).FirstOrDefault();
			if(idiomaElegido != null)
				idiomaFrase = idiomaElegido.Traducciones.Where(x => x.Tag == frase.Tag).FirstOrDefault();
			return idiomaFrase;
		}

		/// <summary>
		/// Método para obtener los idiomas del sistema
		/// </summary>
		/// <returns></returns>
		public IList<Idioma> GetAllIdiomas()
		{
			SetIdiomas();
			return Idiomas;
		}

		/// <summary>
		/// Método para agregar un idioma en el sistema
		/// </summary>
		/// <param name="idioma"></param>
		public void AgregarIdioma(Idioma idioma)
		{
			IdiomaMapper.AgregarIdioma(idioma);
		}

		/// <summary>
		/// Método para editar un idioma en el sistema
		/// </summary>
		/// <param name="idioma">Un idioma</param>
		public void EditarIdioma(Idioma idioma)
		{
			IdiomaMapper.EditarIdioma(idioma);
		}

		/// <summary>
		/// Método para eliminar un idioma en el sistema
		/// </summary>
		/// <param name="idioma">Un idioma</param>
		public void EliminarIdioma(Idioma idioma)
		{
			IdiomaMapper.EliminarIdioma(idioma);
		}

		/// <summary>
		/// Método para crear un nuevo item vacío idioma
		/// </summary>
		/// <param name="id">Id del idioma</param>
		/// <param name="nombre">Nombre del idioma</param>
		/// <returns></returns>
		public Idioma NewIdioma(int id = 0, string nombre = null)
		{
			return new Idioma()
			{
				Id = id,
				Nombre = nombre
			};
		}

		/// <summary>
		/// Método setter de la lista de idiomas
		/// </summary>
		public void SetIdiomas()
		{
			frases = IdiomaMapper.GetAllFrases();
			Idiomas = IdiomaMapper.GetAllIdiomas();

			foreach(Idioma idioma in Idiomas)
				if(idioma.Traducciones == null || idioma.Traducciones.Count == 0)
					idioma.Traducciones = GetAllIdiomaFrases(idioma);
		}

		/// <summary>
		/// Método para guardar las traducciones de un idioma
		/// </summary>
		/// <param name="idiomaFrases">Lista de traducciones</param>
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
