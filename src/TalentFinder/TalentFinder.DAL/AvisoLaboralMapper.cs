using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;

namespace TalentFinder.DAL
{
	public class AvisoLaboralMapper
	{
		public List<AvisoLaboral> GetAvisos(string palabraClave, string lugarTrabajo, string tecnologias)
		{
			List<AvisoLaboral> lista = new List<AvisoLaboral>();
			DataAccessManager da = new DataAccessManager();
			da.Abrir();

			string queryFiltros = "";

			if(!string.IsNullOrEmpty(palabraClave))
				queryFiltros = " AND a.Descripcion LIKE '%" + palabraClave + "%'";

			if(!string.IsNullOrEmpty(lugarTrabajo))
				queryFiltros = " AND a.lugarTrabajo LIKE '%" + lugarTrabajo + "%'";

			if(!string.IsNullOrEmpty(tecnologias))
				queryFiltros = " AND (SELECT COUNT(*) FROM AvisoLaboralTecnologia t WHERE t.AvisoLaboralId=a.Id AND t.TecnologiaId IN (" + tecnologias + ")) > 0";

			string query = "SELECT a.Id,a.Titulo,a.Descripcion,a.FechaVigencia,a.FechaVencimiento,a.FechaCreacion,a.LugarTrabajo,a.ReclutadorId" +
			" FROM AvisoLaboral a" +
			" WHERE 1=1" + queryFiltros +
			" ORDER BY a.FechaVigencia DESC";
			DataTable tabla = da.LeerCmdText(query);
			da.Cerrar();

			foreach(DataRow fila in tabla.Rows)
			{
				AvisoLaboral aviso = new AvisoLaboral();
				aviso.Id = int.Parse(fila["Id"].ToString());
				aviso.Titulo = fila["Titulo"].ToString();
				aviso.Descripcion = fila["Descripcion"].ToString();
				aviso.FechaVigencia = DateTime.Parse(fila["FechaVigencia"].ToString());
				aviso.FechaVencimiento = DateTime.Parse(fila["FechaVencimiento"].ToString());
				aviso.FechaCreacion = DateTime.Parse(fila["FechaCreacion"].ToString());
				aviso.LugarTrabajo = fila["LugarTrabajo"].ToString();
				lista.Add(aviso);
			}
			return lista;
		}
	}
}
