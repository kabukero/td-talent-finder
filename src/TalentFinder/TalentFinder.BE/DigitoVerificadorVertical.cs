using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio para representa el digito verificador vertical
	/// para la validación de la integridad de datos
	/// </summary>
	public class DigitoVerificadorVertical : EntidadBase
	{
		/// <summary>
		/// Property que contiene la tabla de sistema a calcular el DVV
		/// </summary>
		public TablaSistema TablaSistema { get; set; }
		/// <summary>
		/// Property que contiene la fecha de creación del DVV
		/// </summary>
		public DateTime FechaCreacion { get; set; }
		/// <summary>
		/// Property que contiene la fecha de actualización del DVV
		/// </summary>
		public DateTime FechaActualizacion { get; set; }
		/// <summary>
		/// Property que contiene el DVV
		/// </summary>
		public Int64 DVV { get; set; }
	}
}
