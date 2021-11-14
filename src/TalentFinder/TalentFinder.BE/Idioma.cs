using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class Idioma : IdiomaSubject
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		private Idioma idiomaSelected;
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
		public void AgregarTraduccion(IdiomaFrase IdiomaFrase)
		{
			traducciones.Add(IdiomaFrase);
		}
		public Idioma()
		{
			traducciones = new List<IdiomaFrase>();
		}
		public override string ToString()
		{
			return Nombre;
		}
	}
}
