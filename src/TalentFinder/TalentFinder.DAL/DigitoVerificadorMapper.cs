using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TalentFinder.BE;

namespace TalentFinder.DAL
{
	/// <summary>
	/// Entidad de negocio que permite gestionar los digitos verificadores del sistema
	/// </summary>
	public class DigitoVerificadorMapper
	{
		/// <summary>
		/// Método para verificar si existe entrada en la tabla de sistema
		/// </summary>
		/// <param name="tablasSistema">Una tabla de sistema</param>
		/// <returns></returns>
		public int ExisteDVV(TablasSistema tablasSistema)
		{
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@TablaSistemaId", (int)tablasSistema));
			int f = da.LeerEscalar("ExisteDVV", parametros);
			da.Cerrar();
			return f;
		}

		/// <summary>
		/// Método para crear un digito verificador vertical
		/// </summary>
		/// <param name="digitoVerificadorVertical">Un digito verificador</param>
		/// <returns>Resultado de la ejecución</returns>

		public int CrearDVV(DigitoVerificadorVertical digitoVerificadorVertical)
		{
			int f = 0;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			try
			{
				List<SqlParameter> parametros = new List<SqlParameter>();
				parametros.Add(da.CrearParametro("@TablaSistemaId", digitoVerificadorVertical.TablaSistema.Id));
				parametros.Add(da.CrearParametro("@FechaCreacion", digitoVerificadorVertical.FechaCreacion));
				parametros.Add(da.CrearParametro("@DVV", digitoVerificadorVertical.DVV));
				f = da.Escribir("AgregarDDV", parametros);
			}
			catch(Exception ex)
			{
				f = -1;
			}
			da.Cerrar();
			return f;
		}

		/// <summary>
		/// Método para editar un digito verificador vertical
		/// </summary>
		/// <param name="digitoVerificadorVertical">Un digito verificador</param>
		/// <returns>Resultado de la ejecución</returns>
		public int EditarDVV(DigitoVerificadorVertical digitoVerificadorVertical)
		{
			int f = 0;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			try
			{
				List<SqlParameter> parametros = new List<SqlParameter>();
				parametros.Add(da.CrearParametro("@TablaSistemaId", digitoVerificadorVertical.TablaSistema.Id));
				parametros.Add(da.CrearParametro("@FechaActualizacion", digitoVerificadorVertical.FechaActualizacion));
				parametros.Add(da.CrearParametro("@DVV", digitoVerificadorVertical.DVV));
				f = da.Escribir("EditarDDV", parametros);
			}
			catch(Exception ex)
			{
				f = -1;
			}
			da.Cerrar();
			return f;
		}

		/// <summary>
		/// Método para obtener un digito verificador vertical
		/// </summary>
		/// <param name="tablasSistema">Una tabla de sistema</param>
		/// <returns>Un digito verificador vertical</returns>
		public DigitoVerificadorVertical GetDVV(TablasSistema tablasSistema)
		{
			DataAccessManager da = new DataAccessManager();
			DigitoVerificadorVertical digitoVerificadorVertical = null;
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@TablaSistemaId", (int)tablasSistema));
			DataTable tabla = da.Leer("GetDVV", parametros);

			foreach(DataRow fila in tabla.Rows)
			{
				digitoVerificadorVertical = new DigitoVerificadorVertical();
				digitoVerificadorVertical.Id = int.Parse(fila["Id"].ToString());
				digitoVerificadorVertical.TablaSistema = new TablaSistema() { Id = int.Parse(fila["TablaSistemaId"].ToString()) };
				digitoVerificadorVertical.FechaCreacion = DateTime.Parse(fila["FechaCreacion"].ToString());
				if(fila["FechaActualizacion"] != DBNull.Value)
					digitoVerificadorVertical.FechaActualizacion = DateTime.Parse(fila["FechaActualizacion"].ToString());
				digitoVerificadorVertical.DVV = int.Parse(fila["DVV"].ToString());
			}
			da.Cerrar();
			return digitoVerificadorVertical;
		}
	}
}
