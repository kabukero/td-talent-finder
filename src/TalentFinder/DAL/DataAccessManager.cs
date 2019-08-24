using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
	internal class DataAccessManager
	{
		private SqlConnection conn;
		private SqlTransaction tx;

		public void Abrir()
		{
			conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString);
			conn.Open();
		}

		public void Cerrar()
		{
			if(conn != null && conn.State == ConnectionState.Open)
			{
				conn.Close();
				conn = null;
				GC.Collect();
			}
		}

		public void IniciarTx()
		{
			if(tx == null && conn != null)
			{
				tx = conn.BeginTransaction();
			}
		}

		public void ConfirmarTx()
		{
			tx.Commit();
			tx = null;
		}

		public void CancelarTx()
		{
			tx.Rollback();
			tx = null;
		}

		public SqlParameter CrearParametro(string nombre, string valor)
		{
			SqlParameter parametro = new SqlParameter(nombre, valor);
			parametro.SqlDbType = SqlDbType.VarChar;
			return parametro;
		}

		public SqlParameter CrearParametro(string nombre, int valor)
		{
			SqlParameter parametro = new SqlParameter(nombre, valor);
			parametro.SqlDbType = SqlDbType.Int;
			return parametro;
		}

		public SqlParameter CrearParametro(string nombre, decimal valor)
		{
			SqlParameter parametro = new SqlParameter(nombre, valor);
			parametro.SqlDbType = SqlDbType.Decimal;
			return parametro;
		}

		public SqlParameter CrearParametro(string nombre, DateTime valor)
		{
			SqlParameter parametro = new SqlParameter(nombre, valor);
			parametro.SqlDbType = SqlDbType.DateTime;
			return parametro;
		}

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

		public int LeerEscalar(string nombre, List<SqlParameter> parametros)
		{
			int r;

			try
			{
				using(SqlCommand cmd = CrearComando(nombre, parametros))
				{
					r = int.Parse(cmd.ExecuteScalar().ToString());
				}
			}
			catch(Exception ex)
			{
				r = -1;
			}

			return r;
		}

		public int Escribir(string nombre, List<SqlParameter> parametros)
		{
			int f = 0;
			try
			{
				using(SqlCommand cmd = CrearComando(nombre, parametros))
				{
					f = cmd.ExecuteNonQuery();
					cmd.Parameters.Clear();
				}
			}
			catch(Exception ex)
			{
				f = -1;
			}
			return f;
		}
	}
}
