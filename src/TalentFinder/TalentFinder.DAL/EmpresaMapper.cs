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
	public class EmpresaMapper
	{
		public int Crear(Empresa empresa)
		{
			int f = 0;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			try
			{
				List<SqlParameter> parametros = new List<SqlParameter>();
				parametros.Add(da.CrearParametro("@RazonSocial", empresa.RazonSocial));
				parametros.Add(da.CrearParametro("@Direccion", empresa.Direccion));
				parametros.Add(da.CrearParametro("@Telefono", empresa.Telefono));
				parametros.Add(da.CrearParametro("@Email", empresa.Email));
				parametros.Add(da.CrearParametro("@CUIT", empresa.CUIT));
				parametros.Add(da.CrearParametro("@FechaCreacion", empresa.FechaCreacion));
				parametros.Add(da.CrearParametro("@DVH", empresa.DVH));
				f = da.Escribir("CrearEmpresa", parametros);
			}
			catch(Exception ex)
			{
				f = -1;
			}
			da.Cerrar();
			return f;
		}

		public int Editar(Empresa empresa)
		{
			int f = 0;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			try
			{
				List<SqlParameter> parametros = new List<SqlParameter>();
				parametros.Add(da.CrearParametro("@Id", empresa.Id));
				parametros.Add(da.CrearParametro("@RazonSocial", empresa.RazonSocial));
				parametros.Add(da.CrearParametro("@Direccion", empresa.Direccion));
				parametros.Add(da.CrearParametro("@Telefono", empresa.Telefono));
				parametros.Add(da.CrearParametro("@Email", empresa.Email));
				parametros.Add(da.CrearParametro("@CUIT", empresa.CUIT));
				parametros.Add(da.CrearParametro("@FechaActualizacion", empresa.FechaActualizacion));
				parametros.Add(da.CrearParametro("@DVH", empresa.DVH));
				f = da.Escribir("EditarEmpresa", parametros);
			}
			catch(Exception ex)
			{
				f = -1;
			}
			da.Cerrar();
			return f;
		}

		public int Eliminar(Empresa empresa)
		{
			int f = 0;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			try
			{
				List<SqlParameter> parametros = new List<SqlParameter>();
				parametros.Add(da.CrearParametro("@Id", empresa.Id));
				f = da.Escribir("EliminarEmpresa", parametros);
			}
			catch(Exception ex)
			{
				f = -1;
			}
			da.Cerrar();
			return f;
		}

		public List<Empresa> GetAllEmpresas()
		{
			List<Empresa> lista = new List<Empresa>();
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			DataTable tabla = da.Leer("GetAllEmpresas", null);
			da.Cerrar();

			foreach(DataRow fila in tabla.Rows)
			{
				Empresa empresa = new Empresa();
				empresa.Id = int.Parse(fila["Id"].ToString());
				empresa.RazonSocial = fila["RazonSocial"].ToString();
				empresa.Direccion = fila["Direccion"].ToString();
				empresa.Telefono = fila["Telefono"].ToString();
				empresa.Email = fila["Email"].ToString();
				empresa.CUIT = fila["CUIT"].ToString();
				empresa.FechaCreacion = DateTime.Parse(fila["FechaCreacion"].ToString());
				if(fila["FechaActualizacion"] != DBNull.Value)
					empresa.FechaActualizacion = DateTime.Parse(fila["FechaActualizacion"].ToString());
				empresa.DVH = Int64.Parse(fila["DVH"].ToString());
				lista.Add(empresa);
			}
			return lista;
		}
	}
}
