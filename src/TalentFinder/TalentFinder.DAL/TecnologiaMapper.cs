using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;

namespace TalentFinder.DAL
{
	public class TecnologiaMapper
	{
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
