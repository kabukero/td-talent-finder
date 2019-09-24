using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;

namespace TalentFinder.DAL
{
	public class IdiomaMapper
	{
		public IList<Idioma> GetAllIdiomas()
		{
			IList<Idioma> lista = new List<Idioma>();
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			DataTable tabla = da.Leer("GetAllIdiomas", null);

			foreach(DataRow fila in tabla.Rows)
			{
				Idioma idioma = new Idioma();
				idioma.Id = int.Parse(fila["Id"].ToString());
				idioma.Nombre = fila["Nombre"].ToString();
				List<SqlParameter> parameters = new List<SqlParameter>();
				parameters.Add(da.CrearParametro("@IdiomaId", idioma.Id));
				DataTable traducciones = da.Leer("GetAllTraducciones", parameters);
				foreach(DataRow traduccion in traducciones.Rows)
				{
					IdiomaFrase IdiomaFrase = new IdiomaFrase();
					IdiomaFrase.IdiomaId = int.Parse(traduccion["IdiomaId"].ToString());
					IdiomaFrase.Tag = traduccion["Tag"].ToString();
					IdiomaFrase.Traduccion = traduccion["Traduccion"].ToString();
					idioma.Add(IdiomaFrase);
				}
				lista.Add(idioma);
			}
			da.Cerrar();
			return lista;
		}
	}
}
