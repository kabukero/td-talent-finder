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
		private EmpresaMapper empresaMapper = new EmpresaMapper();
		public int Crear(Empresa empresa)
		{
			empresa.FechaCreacion = DateTime.Now;
			empresa.FechaActualizacion = DateTime.Now;
			int f = empresaMapper.Crear(empresa);
			if(f != -1)
			{
				empresa.Id = f;
				empresa.DVH = SistemaManager.DigitoVerificadorManager.CalcularDVH(empresa);
				f = empresaMapper.EditarDVHEmpresa(empresa);
				if(f != -1)
				{
					f = SistemaManager.DigitoVerificadorManager.GuardarDigitoVerificador(TablasSistema.TABLA_EMPRESA);
					if(f != -1)
					{
						empresa.FechaCreacionHistorico = DateTime.Now;
						f = empresaMapper.CrearHistorico(empresa);
					}
				}
			}
			return f;
		}
		public int Editar(Empresa empresa)
		{
			Empresa empresaActual = GetEmpresa(empresa.Id);

			// control de cambios
			if(empresaActual.FechaActualizacion > empresa.FechaActualizacion)
				return -1;

			empresa.FechaActualizacion = DateTime.Now;
			empresa.DVH = SistemaManager.DigitoVerificadorManager.CalcularDVH(empresa);
			int f = empresaMapper.Editar(empresa);

			if(f == 1)
			{
				f = SistemaManager.DigitoVerificadorManager.GuardarDigitoVerificador(TablasSistema.TABLA_EMPRESA);
				if(f != -1)
				{
					empresa.FechaCreacionHistorico = DateTime.Now;
					f = empresaMapper.CrearHistorico(empresa);
				}
			}
			return f;
		}
		public int Eliminar(Empresa empresa)
		{
			int f = empresaMapper.Eliminar(empresa);
			if(f == 1)
				f = SistemaManager.DigitoVerificadorManager.GuardarDigitoVerificador(TablasSistema.TABLA_EMPRESA);
			return f;
		}
		public List<Empresa> GetAllEmpresas()
		{
			return empresaMapper.GetAllEmpresas();
		}
		public Empresa GetEmpresa(int Id)
		{
			return empresaMapper.GetEmpresa(Id);
		}
	}
}
