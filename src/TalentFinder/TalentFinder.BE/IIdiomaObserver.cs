using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Interfaz que implementaran los observers
	/// </summary>
	public interface IIdiomaObserver
	{
		void Update(Idioma idioma);
	}
}
