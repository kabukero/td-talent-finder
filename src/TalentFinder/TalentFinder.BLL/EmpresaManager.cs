using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;
using TalentFinder.DAL;

namespace TalentFinder.BLL
{
	public class EmpresaManager
	{
		private DigitoVerificadorManager digitoVerificadorManager;
		private EmpresaMapper empresaMapper;

		public EmpresaManager()
		{
			digitoVerificadorManager = new DigitoVerificadorManager();
			digitoVerificadorManager.EmpresaManager = this;
			empresaMapper = new EmpresaMapper();
		}

		public int Crear(Empresa empresa)
		{
			empresa.FechaCreacion = DateTime.Now;
			empresa.DVH = digitoVerificadorManager.CalcularDVH(empresa);
			int f = empresaMapper.Crear(empresa);
			if(f == 1)
				f = digitoVerificadorManager.GuardarDigitoVerificador(TablasSistema.TABLA_EMPRESA);
			return f;
		}
		public int Editar(Empresa empresa)
		{
			empresa.DVH = digitoVerificadorManager.CalcularDVH(empresa);
			int f = empresaMapper.Editar(empresa);

			if(f == 1)
				f = digitoVerificadorManager.GuardarDigitoVerificador(TablasSistema.TABLA_EMPRESA);
			return f;
		}
		public int Eliminar(Empresa empresa)
		{
			int f = empresaMapper.Eliminar(empresa);
			if(f == 1)
				f = digitoVerificadorManager.GuardarDigitoVerificador(TablasSistema.TABLA_EMPRESA);
			return f;
		}
		public List<Empresa> GetAllEmpresas()
		{
			return empresaMapper.GetAllEmpresas();
		}
	}
}
