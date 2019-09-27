using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;
using TalentFinder.DAL;

namespace TalentFinder.BLL
{
	public class TipoPermisoManager
	{
		private TipoPermisoMapper TipoPermisoMapper = new TipoPermisoMapper();
		public List<TipoPermiso> GetAllTiposPermiso()
		{
			List<TipoPermiso> lista = TipoPermisoMapper.GetAllTiposPermiso();
			lista.Insert(0, new TipoPermiso() { Id = 0, Nombre = "" });
			return lista;
		}
	}
}
