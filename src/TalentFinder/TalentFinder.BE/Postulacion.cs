﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class Postulacion : EntidadBase
	{
		public DateTime FechaCreacion { get; set; }
		public AvisoLaboral AvisoLaboral { get; set; }
		public PostulacionEstado PostulacionEstado { get; set; }
	}
}
