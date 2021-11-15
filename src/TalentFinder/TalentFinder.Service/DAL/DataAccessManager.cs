using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TalentFinder.Service.DAL
{
	/// <summary>
	/// Clase para gestionar la conexión a la base de datos
	/// </summary>
	internal class DataAccessManager
	{
		/// <summary>
		/// Atributo que contiene la conexión a la base de datos
		/// </summary>
		private SqlConnection conn;

		/// <summary>
		/// Atributo que contiene una transacción sql de la base de datos
		/// </summary>
		private SqlTransaction tx;

		/// <summary>
		/// Método para abrir la conexión
		/// </summary>
		/// <param name="esDbMaster">Si es la db master</param>
		public void Abrir(bool esDbMaster = false)
		{
			if(esDbMaster)
				conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDb"].ConnectionString);
			else
				conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString);
			//conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringAdminDB"].ConnectionString);
			conn.Open();
		}

		/// <summary>
		/// Método para cerrar la conexión a la base de datos
		/// </summary>
		public void Cerrar()
		{
			if(conn != null && conn.State == ConnectionState.Open)
			{
				conn.Close();
				conn = null;
				GC.Collect();
			}
		}

		/// <summary>
		/// Método para iniciar una transacción
		/// </summary>
		public void IniciarTx()
		{
			if(tx == null && conn != null)
			{
				tx = conn.BeginTransaction();
			}
		}

		/// <summary>
		/// Método para confirmar una trasacción
		/// </summary>
		public void ConfirmarTx()
		{
			tx.Commit();
			tx = null;
		}

		/// <summary>
		/// Método para cancelar una transacción
		/// </summary>
		public void CancelarTx()
		{
			tx.Rollback();
			tx = null;
		}

		/// <summary>
		/// Método para crear un parámetro
		/// </summary>
		/// <param name="nombre">Nombre del parámetro</param>
		/// <param name="valor">Valor del parámetro</param>
		/// <returns></returns>
		public SqlParameter CrearParametro(string nombre, string valor)
		{
			SqlParameter parametro = new SqlParameter(nombre, valor);
			parametro.SqlDbType = SqlDbType.VarChar;
			return parametro;
		}

		/// <summary>
		/// Método para crear un parámetro
		/// </summary>
		/// <param name="nombre">Nombre del parámetro</param>
		/// <param name="valor">Valor del parámetro</param>
		/// <returns></returns>
		public SqlParameter CrearParametro(string nombre, int valor)
		{
			SqlParameter parametro = new SqlParameter(nombre, valor);
			parametro.SqlDbType = SqlDbType.Int;
			return parametro;
		}

		/// <summary>
		/// Método para crear un parámetro
		/// </summary>
		/// <param name="nombre">Nombre del parámetro</param>
		/// <param name="valor">Valor del parámetro</param>
		/// <returns></returns>
		public SqlParameter CrearParametro(string nombre, decimal valor)
		{
			SqlParameter parametro = new SqlParameter(nombre, valor);
			parametro.SqlDbType = SqlDbType.Decimal;
			return parametro;
		}

		/// <summary>
		/// Método para crear un parámetro
		/// </summary>
		/// <param name="nombre">Nombre del parámetro</param>
		/// <param name="valor">Valor del parámetro</param>
		/// <returns></returns>
		public SqlParameter CrearParametro(string nombre, DateTime valor)
		{
			SqlParameter parametro = new SqlParameter(nombre, valor);
			parametro.SqlDbType = SqlDbType.DateTime;
			return parametro;
		}

		/// <summary>
		/// Método para crear un objeto commmand
		/// </summary>
		/// <param name="nombre">Nombre del comando</param>
		/// <param name="parametros">Lista de parámetros</param>
		/// <returns>Un objeto command</returns>
		public SqlCommand CrearComando(string nombre, List<SqlParameter> parametros)
		{
			SqlCommand cmd = new SqlCommand(nombre, conn);
			cmd.CommandType = CommandType.StoredProcedure;

			if(parametros != null && parametros.Count > 0)
				cmd.Parameters.AddRange(parametros.ToArray());

			if(tx != null)
				cmd.Transaction = tx;

			return cmd;
		}

		/// <summary>
		/// Método para leer un set de datos
		/// </summary>
		/// <param name="nombre">Nombre del comando</param>
		/// <param name="parametros">Lista de parámetros</param>
		/// <returns>Un objeto data table</returns>
		public DataTable Leer(string nombre, List<SqlParameter> parametros)
		{
			DataTable tabla = new DataTable();
			using(SqlDataAdapter adaptador = new SqlDataAdapter())
			{
				adaptador.SelectCommand = CrearComando(nombre, parametros);
				adaptador.Fill(tabla);
			}
			return tabla;
		}

		/// <summary>
		/// Método para leer un set de datos
		/// </summary>
		/// <param name="nombre">Nombre del comando</param>
		/// <returns>Un objeto data table</returns>
		public DataTable LeerCmdText(string nombre)
		{
			DataTable tabla = new DataTable();
			using(SqlDataAdapter adaptador = new SqlDataAdapter())
			{
				using(SqlCommand cmd = new SqlCommand(nombre, conn))
				{
					cmd.CommandType = CommandType.Text;
					adaptador.SelectCommand = cmd;
					adaptador.Fill(tabla);
				}
			}
			return tabla;
		}

		/// <summary>
		/// Método para leer un valor de una tabla
		/// </summary>
		/// <param name="nombre">Nombre del comando</param>
		/// <param name="parametros">Lista de parámetros</param>
		/// <returns>Valor obtenido</returns>
		public int LeerEscalar(string nombre, List<SqlParameter> parametros)
		{
			int r;
			using(SqlCommand cmd = CrearComando(nombre, parametros))
			{
				r = int.Parse(cmd.ExecuteScalar().ToString());
			}
			return r;
		}

		/// <summary>
		/// Método para escribir en la db
		/// </summary>
		/// <param name="nombre">Nombre del comando</param>
		/// <param name="parametros">Lista de parámetros</param>
		/// <returns>Resultado de la ejecución</returns>
		public int Escribir(string nombre, List<SqlParameter> parametros)
		{
			int f = 0;
			using(SqlCommand cmd = CrearComando(nombre, parametros))
			{
				f = cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
			}
			return f;
		}

		/// <summary>
		/// Método para escribir en la db
		/// </summary>
		/// <param name="nombre">Nombre del comando</param>
		/// <param name="parametros">Lista de parámetros</param>
		/// <returns>Resultado de la ejecución</returns>

		public int EscribirCmdText(string nombre, List<SqlParameter> parametros)
		{
			int f = 1;
			using(SqlCommand cmd = new SqlCommand(nombre, conn))
			{
				cmd.CommandType = CommandType.Text;

				if(tx != null)
					cmd.Transaction = tx;

				if(parametros != null && parametros.Count > 0)
					cmd.Parameters.AddRange(parametros.ToArray());

				cmd.ExecuteNonQuery();
			}
			return f;
		}
	}
}
