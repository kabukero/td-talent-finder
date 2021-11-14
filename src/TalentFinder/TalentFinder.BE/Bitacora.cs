using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio para contener la información
	/// de un Bitacora
	/// </summary>
	public class Bitacora : EntidadBase
	{
		/// <summary>
		/// Property que contiene la fecha de creación de una bitacora
		/// </summary>
		public DateTime FechaCreacion { get; set; }

		[JsonIgnore]
		public string FechaCreacionFormmated
		{
			get
			{
				return FechaCreacion.ToString("dd/MM/yyyy HH:mm");
			}
		}
		/// <summary>
		/// Property que contiene el Usuario de una bitacora
		/// </summary>
		public Usuario Usuario { get; set; }
		/// <summary>
		/// Property que contiene el tipo de evento de una bitacora
		/// </summary>
		public TipoEvento TipoEvento { get; set; }
		/// <summary>
		/// Property que contiene la descripción de una bitacora
		/// </summary>
		public string Descripcion { get; set; }
	}
}
