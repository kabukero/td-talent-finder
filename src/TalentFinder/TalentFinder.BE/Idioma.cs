using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.Service;

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
		public IList<IdiomaFrase> traducciones;
		public IList<IdiomaFrase> Traducciones
		{
			get
			{
				return CloneHelper.CloneObject<IList<IdiomaFrase>>(traducciones);
			}
		}
		public void Add(IdiomaFrase IdiomaFrase)
		{
			traducciones.Add(IdiomaFrase);
		}
		public Idioma()
		{
			traducciones = new List<IdiomaFrase>();
		}
	}
}
