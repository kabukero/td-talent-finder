using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class AvisoLaboral : EntidadBase
	{
		public string Titulo { get; set; }
		public string Descripcion { get; set; }
		public DateTime FechaVigencia { get; set; }
		public DateTime FechaVencimiento { get; set; }
		public DateTime FechaCreacion { get; set; }
		public string LugarTrabajo { get; set; }
		public Reclutador Reclutador { get; set; }
		public Empresa Empresa { get; set; }
		public string FechaVigenciaDisplay
		{
			get
			{
				return FechaVigencia.ToString("dd/MM/yyyy");
			}
		}
		public override string ToString()
		{
			return string.Format("{0} ({1})", Descripcion, LugarTrabajo);
		}
	}
}
