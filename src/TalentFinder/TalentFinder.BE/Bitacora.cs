using Newtonsoft.Json;
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

		[JsonIgnore]
		public string FechaCreacionFormmated
		{
			get
			{
				return FechaCreacion.ToString("dd/MM/yyyy HH:mm");
			}
		}
		public Usuario Usuario { get; set; }
		public TipoEvento TipoEvento { get; set; }
		public string Descripcion { get; set; }
	}
}
