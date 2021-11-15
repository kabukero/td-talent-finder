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
	/// Entidad de negocio para gestionar las empresas del sistema
	/// </summary>
	public class EmpresaMapper
	{
		/// <summary>
		/// Método para crear una empresa
		/// </summary>
		/// <param name="empresa">Entidad empresa</param>
		/// <returns>Resultado de la ejecución</returns>
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
				parametros.Add(da.CrearParametro("@FechaCreacion", empresa.FechaCreacionFormateada));
				parametros.Add(da.CrearParametro("@FechaActualizacion", empresa.FechaCreacionFormateada));
				f = da.LeerEscalar("CrearEmpresa", parametros);
			}
			catch(Exception ex)
			{
				f = -1;
			}
			da.Cerrar();
			return f;
		}

		/// <summary>
		/// Método para editar una empresa
		/// </summary>
		/// <param name="empresa">Entidad empresa</param>
		/// <returns>Resultado de la ejecución</returns>
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
				parametros.Add(da.CrearParametro("@FechaActualizacion", empresa.FechaActualizacionFormateada));
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

		/// <summary>
		/// Método para editar el DVH de una empresa
		/// </summary>
		/// <param name="empresa">Entidad empresa</param>
		/// <returns>Resultado de la ejecución</returns>
		public int EditarDVHEmpresa(Empresa empresa)
		{
			int f = 0;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			try
			{
				List<SqlParameter> parametros = new List<SqlParameter>();
				parametros.Add(da.CrearParametro("@EmpresaId", empresa.Id));
				parametros.Add(da.CrearParametro("@DVH", empresa.DVH));
				f = da.Escribir("EditarDVHEmpresa", parametros);
			}
			catch(Exception ex)
			{
				f = -1;
			}
			da.Cerrar();
			return f;
		}

		/// <summary>
		/// Método para eliminar una empresa
		/// </summary>
		/// <param name="empresa">Entidad empresa</param>
		/// <returns>Resultado de la ejecución</returns>
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

		/// <summary>
		/// Método para obtener las empresas del sistema
		/// </summary>
		/// <param name="empresa">Entidad empresa</param>
		/// <returns>Lista de empresas</returns>
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

				if(fila["DVH"] != DBNull.Value)
					empresa.DVH = Int64.Parse(fila["DVH"].ToString());
				lista.Add(empresa);
			}
			return lista;
		}

		/// <summary>
		/// Método para obtener una empresa del sistema por id
		/// </summary>
		/// <param name="Id">Identificador de la empresa</param>
		/// <returns>Entidad empresa encontrada</returns>
		public Empresa GetEmpresa(int Id)
		{
			Empresa empresa = null;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@EmpresaId", Id));
			DataTable tabla = da.Leer("GetEmpresa", parametros);
			da.Cerrar();

			foreach(DataRow fila in tabla.Rows)
			{
				empresa = new Empresa();
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
			}
			return empresa;
		}

		/// <summary>
		/// Método para crear un histórico de una empresa
		/// </summary>
		/// <param name="empresa">Una empresa</param>
		/// <returns>Resultado de la ejecución</returns>
		public int CrearHistorico(Empresa empresa)
		{
			int f = 0;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			try
			{
				List<SqlParameter> parametros = new List<SqlParameter>();
				parametros.Add(da.CrearParametro("@EmpresaId", empresa.Id));
				parametros.Add(da.CrearParametro("@RazonSocial", empresa.RazonSocial));
				parametros.Add(da.CrearParametro("@Direccion", empresa.Direccion));
				parametros.Add(da.CrearParametro("@Telefono", empresa.Telefono));
				parametros.Add(da.CrearParametro("@Email", empresa.Email));
				parametros.Add(da.CrearParametro("@CUIT", empresa.CUIT));
				parametros.Add(da.CrearParametro("@FechaCreacion", empresa.FechaCreacionFormateada));
				parametros.Add(da.CrearParametro("@FechaActualizacion", empresa.FechaCreacionFormateada));
				parametros.Add(da.CrearParametro("@FechaCreacionHistorico", empresa.FechaCreacionHistoricoFormateada));
				parametros.Add(da.CrearParametro("@DVH", empresa.DVH));
				f = da.Escribir("CrearEmpresaHistorico", parametros);
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
