﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.Service.Domain
{
	public interface IIdiomaObserver
	{
		void Update(Idioma idioma);
	}
}
