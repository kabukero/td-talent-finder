﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class Usuario : EntidadBase
	{
		public string UserName { get; set; }
		public string UserPassword { get; set; }
	}
}
