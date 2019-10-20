using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class Bitacora : EntidadBase
	{
		public DateTime FechaCreacion { get; set; }
		public string FechaCreacionFormmated
		{
			get
			{
				return FechaCreacion.ToString("dd/MM/yyyy HH:MM");
			}
		}
		public Usuario Usuario { get; set; }
		public TipoEvento TipoEvento { get; set; }
		public string Descripcion { get; set; }
	}
}
