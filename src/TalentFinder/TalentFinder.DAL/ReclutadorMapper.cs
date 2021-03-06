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
	/// <summary>
	/// Clase para gestionar los reclutadores del sistema
	/// </summary>
	public class ReclutadorMapper
	{
		/// <summary>
		/// Método para obtener un reclutador asociado a un usuario
		/// </summary>
		/// <param name="usuario">Un usuario</param>
		/// <returns>El reclutador encontrado</returns>
		public Reclutador GetReclutador(Usuario usuario)
		{
			Reclutador reclutador = null;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@UsuarioId", usuario.Id));
			DataTable tabla = da.Leer("GetReclutador", parametros);
			if(tabla.Rows.Count > 0)
			{
				DataRow registro = tabla.Rows[0];
				reclutador = new Reclutador();
				reclutador.Id = int.Parse(registro["Id"].ToString());
				reclutador.Nombre = registro["Nombre"].ToString();
				reclutador.Apellido = registro["Apellido"].ToString();
			}
			da.Cerrar();
			return reclutador;
		}
	}
}
