using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;
using TalentFinder.DAL;

namespace TalentFinder.BLL
{
	/// <summary>
	/// Entidad de negocio para gestionar los avisos laborales
	/// </summary>
	public class AvisoLaboralManager
	{
		/// <summary>
		/// Método para obtener los avisos laborales filtrador
		/// </summary>
		private AvisoLaboralMapper AvisoLaboralMapper = new AvisoLaboralMapper();
		/// <summary>
		/// Método para obtener los avisos laborales filtrado por criterio de búsqueda
		/// </summary>
		/// <param name="palabraClave">Palabra clave a filtrar</param>
		/// <param name="lugarTrabajo">Lugar de trabajo para filtrar</param>
		/// <param name="tecnologias">Tecnologías a filtrar</param>
		/// <returns>Lista de avisos laborales</returns>
		public List<AvisoLaboral> GetAvisos(string palabraClave, string lugarTrabajo, string tecnologias)
		{
			return AvisoLaboralMapper.GetAvisos(palabraClave, lugarTrabajo, tecnologias);
		}
	}
}
