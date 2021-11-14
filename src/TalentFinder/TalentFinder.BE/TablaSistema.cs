using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio que representa las tablas del sistema a las cuales
	/// se les verifica la integridad de los datos
	/// </summary>
	public class TablaSistema : EntidadBase
	{
		/// <summary>
		/// Property que contiene la descripción de la tabla de sistema
		/// </summary>
		public string Descripcion { get; set; }
	}
}
