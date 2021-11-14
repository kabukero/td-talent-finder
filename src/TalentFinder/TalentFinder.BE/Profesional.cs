using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio que representa un profesional dentro del sistema
	/// </summary>
	public class Profesional : Persona
	{
		/// <summary>
		/// Lista que contiene las postulaciones del profesional
		/// </summary>
		public List<Postulacion> Postulaciones { get; set; }
	}
}
