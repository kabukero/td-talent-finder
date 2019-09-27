using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TalentFinder.BE;

namespace TalentFinder.DAL
{
	public class DigitoVerificadorMapper
	{
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
