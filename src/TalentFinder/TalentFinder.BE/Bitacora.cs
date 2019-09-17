﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class Bitacora : EntidadBase
	{
		public DateTime FechaCreacion { get; set; }
		public Usuario Usuario { get; set; }
		public Permiso Permiso { get; set; }
		public string Descripcion { get; set; }
	}
}
