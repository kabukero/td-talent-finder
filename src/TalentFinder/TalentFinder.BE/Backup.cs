using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio para contener la información
	/// de un backup
	/// </summary>
	public class Backup
	{
		/// <summary>
		/// Property que contiene la fecha de creación de un backup
		/// </summary>
		public DateTime FechaCreacion { get; set;  }
		/// <summary>
		/// Property que contiene el nombre del archivo de un backup
		/// </summary>
		public string NombreArchivo { get; set; }
	}
}
