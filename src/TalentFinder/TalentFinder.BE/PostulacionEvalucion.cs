using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class PostulacionEvalucion : EntidadBase
	{
		public DateTime FechaCreacion { get; set; }
		public string Respuesta { get; set; }
		public bool Aprobo { get; set; }
		public string TiempoResolucionEvaluacion { get; set; }
		public Evaluacion Evaluacion { get; set; }
	}
}
