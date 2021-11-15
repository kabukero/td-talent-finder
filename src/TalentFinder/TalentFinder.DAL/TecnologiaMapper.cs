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
	/// Clase para gestionar las tecnologías del sistema
	/// </summary>
	public class TecnologiaMapper
	{
		/// <summary>
		/// Método para obtener las tecnologías del sistema
		/// </summary>
		/// <returns>Lista de tecnologías</returns>
		public List<Tecnologia> GetAllTecnologias()
		{
			List<Tecnologia> lista = new List<Tecnologia>();
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			DataTable tabla = da.Leer("GetAllTecnologias", null);
			da.Cerrar();

			foreach(DataRow fila in tabla.Rows)
			{
				Tecnologia tecnologia = new Tecnologia();
				tecnologia.Id = int.Parse(fila["Id"].ToString());
				tecnologia.Nombre = fila["Nombre"].ToString();
				lista.Add(tecnologia);
			}
			return lista;
		}
	}
}
