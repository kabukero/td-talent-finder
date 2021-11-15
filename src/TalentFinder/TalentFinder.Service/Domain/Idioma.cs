using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.Service;

namespace TalentFinder.Service.Domain
{
	/// <summary>
	/// Entidad de negocio que representa un idioma del sistema
	/// </summary>
	public class Idioma : IdiomaSubject
	{
		/// <summary>
		/// Property que contiene el identificador de un idioma
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Property que contiene el nombre de un idioma
		/// </summary>
		public string Nombre { get; set; }
		private Idioma idiomaSelected;
		/// <summary>
		/// Property que contiene el idioma seleccionado por el usuario
		/// </summary>
		public Idioma IdiomaSelected
		{
			get
			{
				return idiomaSelected;
			}
			set
			{
				idiomaSelected = value;
				Notify(idiomaSelected);
			}
		}
		private IList<IdiomaFrase> traducciones;
		/// <summary>
		/// Property que contiene las traducciones de un idioma
		/// </summary>
		public IList<IdiomaFrase> Traducciones
		{
			get
			{
				return traducciones;
			}
			set
			{
				traducciones = value;
			}
		}
		/// <summary>
		/// Método para agregar una traduccion de un idioma
		/// </summary>
		/// <param name="IdiomaFrase"></param>
		public void AgregarTraduccion(IdiomaFrase IdiomaFrase)
		{
			traducciones.Add(IdiomaFrase);
		}
		/// <summary>
		/// Constructo de la clase para inicializar la lista traducciones
		/// </summary>
		public Idioma()
		{
			traducciones = new List<IdiomaFrase>();
		}
		/// <summary>
		/// Property que contiene el nombre de un idioma
		/// </summary>
		public override string ToString()
		{
			return Nombre;
		}
	}
}
