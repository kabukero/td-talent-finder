using System;

namespace TalentFinder.BE
{
	public class Empresa : EntidadBase
	{
		public string RazonSocial { get; set; }
		public string Direccion { get; set; }
		public string Telefono { get; set; }
		public string Email { get; set; }
		public string CUIT { get; set; }
		public DateTime FechaCreacion { get; set; }

		public String FechaCreacionFormateada
		{
			get
			{
				return FechaCreacion.ToString("yyyy/MM/dd HH:mm:ss");
			}
		}
		public DateTime FechaActualizacion { get; set; }

		public String FechaActualizacionFormateada
		{
			get
			{
				return FechaActualizacion.ToString("yyyy/MM/dd HH:mm:ss");
			}
		}

		public Int64 DVH { get; set; }
	}
}
