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
	/// Clase para gestionar los tipos de permisos en el sistema
	/// </summary>
	public class TipoPermisoManager
	{
		private TipoPermisoMapper TipoPermisoMapper = new TipoPermisoMapper();

		/// <summary>
		/// Método para obtener los tipos de permisos del sistema
		/// </summary>
		/// <returns>Los tipos de permisos del sistema</returns>
		public List<TipoPermiso> GetAllTiposPermiso()
		{
			List<TipoPermiso> lista = TipoPermisoMapper.GetAllTiposPermiso();
			lista.Insert(0, new TipoPermiso() { Id = 0, Nombre = "" });
			return lista;
		}
	}
}
