using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio que representa la relación entre
	/// una traduccion y una frase de un idioma
	/// </summary>
	public class IdiomaFrase
	{
		/// <summary>
		/// Property que contiene el identificador de un idioma
		/// </summary>
		public int IdiomaId { get; set; }
		/// <summary>
		/// Property que contiene la etiqueta de una frase de un idioma
		/// </summary>
		public string Tag { get; set; }
		/// <summary>
		/// Property que contiene la traducción de una frase de un idioma
		/// </summary>
		public string Traduccion { get; set; }
	}
}
