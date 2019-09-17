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
	public class DigitoVerificadorManager
	{
		private DigitoVerificadorMapper digitoVerificadorMapper;
		public EmpresaManager EmpresaManager { get; set; }
		public UsuarioManager UsuarioManager { get; set; }

		public DigitoVerificadorManager()
		{
			digitoVerificadorMapper = new DigitoVerificadorMapper();
		}

		public int GuardarDigitoVerificador(TablasSistema tablasSistema)
		{
			int f = 0;
			DigitoVerificadorVertical digitoVerificadorVertical = new DigitoVerificadorVertical();

			switch(tablasSistema)
			{
				case TablasSistema.TABLA_EMPRESA:
					digitoVerificadorVertical.DVV = CalcularDVVEmpresa(EmpresaManager.GetAllEmpresas());
					//digitoVerificadorVertical.DVV = -1;
					break;
				//case TablasSistema.TABLA_USUARIO:
				//	digitoVerificadorVertical.DVV = CalcularDVVEmpresa(usuarioManager.GetAllUsuarios());
				//	break;
			}
			digitoVerificadorVertical.TablaSistema = new TablaSistema() { Id = (int)tablasSistema };

			if(digitoVerificadorMapper.ExisteDVV(tablasSistema) == 0)
			{
				digitoVerificadorVertical.FechaCreacion = DateTime.Now;
				f = digitoVerificadorMapper.CrearDVV(digitoVerificadorVertical);
			}
			else
			{
				digitoVerificadorVertical.FechaActualizacion = DateTime.Now;
				f = digitoVerificadorMapper.EditarDVV(digitoVerificadorVertical);
			}
			return f;
		}

		public Int64 CalcularDVH(Empresa empresa)
		{
			Int64 digitoVerificadorHorizontal = 0, digitoVerificadorCampo;
			int numeroCampo = 0;
			foreach(PropertyInfo p in empresa.GetType().GetProperties().Where(p => !p.GetGetMethod().GetParameters().Any() && p.Name != "DVH"))
			{
				digitoVerificadorCampo = 0;
				string valorCampo = p.GetValue(empresa, null).ToString();
				byte[] asciiBytes = Encoding.ASCII.GetBytes(valorCampo);

				for(int i = 0; i < asciiBytes.Length; i++)
				{
					digitoVerificadorCampo += asciiBytes[i] * (i + 1);
				}

				digitoVerificadorHorizontal += (numeroCampo + 1) * digitoVerificadorCampo;
				numeroCampo++;
			}
			return digitoVerificadorHorizontal;
		}

		public Int64 CalcularDVVEmpresa(List<Empresa> empresas)
		{
			Int64 dvv = 0;
			foreach(Empresa e in empresas)
				dvv += e.DVH;
			return dvv;
		}

		public Int64 CalcularDVVEmpresa(List<Usuario> usuarios)
		{
			Int64 dvv = 0;
			foreach(Usuario e in usuarios)
				dvv += e.DVH;
			return dvv;
		}
	}
}
