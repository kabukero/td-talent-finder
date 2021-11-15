using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;

namespace TalentFinder.DAL
{
	/// <summary>
	/// Clase para gestionar los tipos de permisos en el sistema
	/// </summary>
	public class TipoPermisoMapper
	{
		/// <summary>
		/// Método para obtener los tipos de permisos del sistema
		/// </summary>
		/// <returns>Los tipos de permisos del sistema</returns>
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
