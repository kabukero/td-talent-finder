﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;
using TalentFinder.DAL;

namespace TalentFinder.BLL
{
	/// <summary>
	/// Clase para gestionar las tecnologías del sistema
	/// </summary>
	public class TecnologiaManager
	{
		private TecnologiaMapper TecnologiaMapper = new TecnologiaMapper();
		public List<Tecnologia> GetAllTecnologias()
		{
			return TecnologiaMapper.GetAllTecnologias();
		}
	}
}
