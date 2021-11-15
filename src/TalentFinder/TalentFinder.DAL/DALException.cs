using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.DAL
{
	/// <summary>
	/// Excepción de la capa DAL
	/// </summary>
	public class DALException : Exception
	{
		public DALException()
		{

		}
		public DALException(string mensaje) : base(mensaje)
		{

		}
		public DALException(string mensaje, Exception ex) : base(mensaje, ex)
		{

		}
	}
}
