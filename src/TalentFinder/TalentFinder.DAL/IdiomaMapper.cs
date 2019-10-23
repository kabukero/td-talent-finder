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
				if(traducciones != null && traducciones.Rows.Count > 0)
				{
					foreach(DataRow traduccion in traducciones.Rows)
					{
						IdiomaFrase IdiomaFrase = new IdiomaFrase();
						IdiomaFrase.IdiomaId = int.Parse(traduccion["IdiomaId"].ToString());
						IdiomaFrase.Tag = traduccion["Tag"].ToString();
						IdiomaFrase.Traduccion = traduccion["Traduccion"].ToString();
						idioma.AgregarTraduccion(IdiomaFrase);
					}
				}
				lista.Add(idioma);
			}
			da.Cerrar();
			return lista;
		}
		public void AgregarIdioma(Idioma idioma)
		{
			int f = 0;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			try
			{
				List<SqlParameter> parametros = new List<SqlParameter>();
				parametros.Add(da.CrearParametro("@Nombre", idioma.Nombre));
				f = da.Escribir("AgregarIdioma", parametros);
			}
			catch(Exception ex)
			{
				f = -1;
			}
			da.Cerrar();
		}
		public void EditarIdioma(Idioma idioma)
		{
			int f = 0;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			try
			{
				List<SqlParameter> parametros = new List<SqlParameter>();
				parametros.Add(da.CrearParametro("@Id", idioma.Id));
				parametros.Add(da.CrearParametro("@Nombre", idioma.Nombre));
				f = da.Escribir("EditarIdioma", parametros);
			}
			catch(Exception ex)
			{
				f = -1;
			}
			da.Cerrar();
		}
		public void EliminarIdioma(Idioma idioma)
		{
			DataAccessManager da = new DataAccessManager();
			try
			{
				da.Abrir();
				da.IniciarTx();
				List<SqlParameter> parametros = new List<SqlParameter>();
				parametros.Add(da.CrearParametro("@IdiomaId", idioma.Id));
				da.Escribir("EliminarIdiomaTraducciones", parametros);

				parametros.Clear();
				parametros.Add(da.CrearParametro("@Id", idioma.Id));
				da.Escribir("EliminarIdioma", parametros);

				da.ConfirmarTx();
			}
			catch(Exception ex)
			{
				da.CancelarTx();
				throw;
			}
			da.Cerrar();
		}
		public void GuardarTraducciones(IList<IdiomaFrase> idiomaFrases)
		{
			DataAccessManager da = new DataAccessManager();
			try
			{
				da.Abrir();
				da.IniciarTx();

				List<SqlParameter> parametros = new List<SqlParameter>();
				parametros.Add(da.CrearParametro("@IdiomaId", idiomaFrases[0].IdiomaId));
				da.Escribir("EliminarIdiomaTraducciones", parametros);

				foreach(IdiomaFrase idiomaFrase in idiomaFrases)
				{
					parametros.Clear();
					parametros.Add(da.CrearParametro("@IdiomaId", idiomaFrase.IdiomaId));
					parametros.Add(da.CrearParametro("@Tag", idiomaFrase.Tag));
					parametros.Add(da.CrearParametro("@Traduccion", idiomaFrase.Traduccion));
					da.Escribir("GuardarIdiomaTraducciones", parametros);
				}

				da.ConfirmarTx();
			}
			catch
			{
				da.CancelarTx();
				throw;
			}
		}
		public IList<Frase> GetAllFrases()
		{
			IList<Frase> lista = new List<Frase>();
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			DataTable tabla = da.Leer("GetAllFrases", null);
			foreach(DataRow fila in tabla.Rows)
			{
				Frase frase = new Frase();
				frase.Tag = fila["Tag"].ToString();
				lista.Add(frase);
			}
			da.Cerrar();
			return lista;
		}
	}
}
