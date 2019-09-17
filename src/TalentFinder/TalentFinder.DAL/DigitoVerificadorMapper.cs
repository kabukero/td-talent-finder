using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
	}
}
