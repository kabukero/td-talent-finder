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
	/// Clase para gestionar los reclutadores del sistema
	/// </summary>
	public class ReclutadorManager
	{
		/// <summary>
		/// Atributo que contiene el mapper del reclutador para gestionar la persistencia de los reclutadores en el sistema
		/// </summary>
		private ReclutadorMapper ReclutadorMapper = new ReclutadorMapper();

		/// <summary>
		/// Método para obtener un reclutador asociado a un usuario
		/// </summary>
		/// <param name="usuario">Un usuario</param>
		/// <returns>El reclutador encontrado</returns>
		public Reclutador GetReclutador(Usuario usuario)
		{
			return ReclutadorMapper.GetReclutador(usuario);
		}
	}
}