using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;
using TalentFinder.DAL;

namespace TalentFinder.BLL
{
	/// <summary>
	/// Entidad de negocio que permite gestionar los digitos verificadores del sistema
	/// </summary>
	public class DigitoVerificadorManager
	{
		/// <summary>
		/// Atributo que contiene el mapper del digito verificador para persistir en el sistema
		/// </summary>
		DigitoVerificadorMapper DigitoVerificadorMapper = new DigitoVerificadorMapper();

		/// <summary>
		/// Método que permite guardar un digito verificador en el sistema
		/// </summary>
		/// <param name="tablasSistema"></param>
		/// <returns>Resultado de la ejecución</returns>
		public int GuardarDigitoVerificador(TablasSistema tablasSistema)
		{
			int f = 0;
			DigitoVerificadorVertical digitoVerificadorVertical = new DigitoVerificadorVertical();

			switch(tablasSistema)
			{
				case TablasSistema.TABLA_EMPRESA:
					digitoVerificadorVertical.DVV = CalcularDVV(SistemaManager.EmpresaManager.GetAllEmpresas());
					//digitoVerificadorVertical.DVV = -1;
					break;
				//case TablasSistema.TABLA_USUARIO:
				//	digitoVerificadorVertical.DVV = CalcularDVVEmpresa(usuarioManager.GetAllUsuarios());
				//	break;
			}
			digitoVerificadorVertical.TablaSistema = new TablaSistema() { Id = (int)tablasSistema };

			if(DigitoVerificadorMapper.ExisteDVV(tablasSistema) == 0)
			{
				digitoVerificadorVertical.FechaCreacion = DateTime.Now;
				f = DigitoVerificadorMapper.CrearDVV(digitoVerificadorVertical);
			}
			else
			{
				digitoVerificadorVertical.FechaActualizacion = DateTime.Now;
				f = DigitoVerificadorMapper.EditarDVV(digitoVerificadorVertical);
			}
			return f;
		}

		/// <summary>
		/// Método para calcular el digito verificador horizontal
		/// </summary>
		/// <param name="empresa">Entidad empresa</param>
		/// <returns>Valor del digito verificador</returns>
		public Int64 CalcularDVH(Empresa empresa)
		{
			Int64 digitoVerificadorHorizontal = 0, digitoVerificadorCampo;
			int numeroCampo = 0;

			// obtener las properties del objeto
			IEnumerable<PropertyInfo> properties = empresa.GetType().GetProperties().Where(p => !p.GetGetMethod().GetParameters().Any() && p.Name != "DVH" && p.Name != "FechaCreacion" && p.Name != "FechaActualizacion");

			foreach(PropertyInfo p in properties)
			{
				digitoVerificadorCampo = 0;

				string valorCampo = p.GetValue(empresa, null).ToString();

				if(!string.IsNullOrEmpty(valorCampo))
				{
					// obtener los valores ASCII de valor de la property
					byte[] asciiBytes = Encoding.ASCII.GetBytes(valorCampo);

					for(int i = 0; i < asciiBytes.Length; i++)
					{
						digitoVerificadorCampo += asciiBytes[i] * (i + 1);
					}

					digitoVerificadorHorizontal += (numeroCampo + 1) * digitoVerificadorCampo;
				}
				numeroCampo++;
			}
			return digitoVerificadorHorizontal;
		}

		/// <summary>
		/// Método para calcular el digito verificador vertical
		/// </summary>
		/// <param name="empresas">Entidad empresa</param>
		/// <returns>Valor del digito verificador</returns>
		public Int64 CalcularDVV(List<Empresa> empresas)
		{
			Int64 dvv = 0;
			foreach(Empresa e in empresas)
				dvv += e.DVH;
			return dvv;
		}

		/// <summary>
		/// Método para verificar la integridad de datos del sistema
		/// </summary>
		/// <returns>Resultado de la verificación</returns>
		public bool VerificarIntegridadDatosSistema()
		{
			List<Empresa> empresas = SistemaManager.EmpresaManager.GetAllEmpresas();

			if(empresas == null || empresas.Count == 0)
				return true;

			foreach(Empresa empresa in empresas)
			{
				Int64 DVH = CalcularDVH(empresa);
				if(empresa.DVH != DVH)
					return false;
			}

			DigitoVerificadorVertical dvv = DigitoVerificadorMapper.GetDVV(TablasSistema.TABLA_EMPRESA);

			Int64 DVV = CalcularDVV(empresas);
			if(dvv.DVV != DVV)
				return false;

			return true;
		}

		/// <summary>
		/// Método para verificar la integridad de datos de la entidad empresa
		/// </summary>
		/// <param name="empresa">Entidad empresa</param>
		/// <returns>Resultado de la verificación</returns>
		public bool VerificarIntegridadDatosEmpresa(Empresa empresa)
		{
			Empresa empresaActual = SistemaManager.EmpresaManager.GetEmpresa(empresa.Id);

			if(empresaActual == null)
				return true;

			Int64 DVH = CalcularDVH(empresaActual);
			if(empresaActual.DVH != DVH)
				return false;

			return true;
		}
	}
}
