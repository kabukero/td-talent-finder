using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;

namespace TalentFinder.DAL
{
	public class TipoPermisoMapper
	{
		public List<TipoPermiso> GetAllTiposPermiso()
		{
			List<TipoPermiso> lista = new List<TipoPermiso>();
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			DataTable tabla = da.Leer("GetAllTiposPermiso", null);
			da.Cerrar();

			foreach(DataRow fila in tabla.Rows)
			{
				TipoPermiso tipoPermiso = new TipoPermiso();
				tipoPermiso.Id = int.Parse(fila["Id"].ToString());
				tipoPermiso.Nombre = fila["Nombre"].ToString();
				lista.Add(tipoPermiso);
			}
			return lista;
		}
	}
}
