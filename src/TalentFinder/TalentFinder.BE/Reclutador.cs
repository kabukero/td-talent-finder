using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio que representa un reclutador dentro del sistema
	/// </summary>
	public class Reclutador : Persona
	{
		/// <summary>
		/// Lista que contiene las postulaciones que gestiona un reclutador
		/// </summary>
		public List<Postulacion> Postulaciones { get; set; }
	}
}
