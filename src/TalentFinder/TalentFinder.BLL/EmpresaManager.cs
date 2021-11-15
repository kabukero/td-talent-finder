using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;
using TalentFinder.DAL;

namespace TalentFinder.BLL
{
	/// <summary>
	/// Entidad de negocio para gestionar las empresas del sistema
	/// </summary>
	public class EmpresaManager
	{
		/// <summary>
		/// Atributo que contiene el mapper de la empresa para gestionar la persistencia
		/// </summary>
		private EmpresaMapper empresaMapper = new EmpresaMapper();

		/// <summary>
		/// Método para crear una empresa
		/// </summary>
		/// <param name="empresa">Entidad empresa</param>
		/// <returns>Resultado de la ejecución</returns>
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

		/// <summary>
		/// Método para editar una empresa
		/// </summary>
		/// <param name="empresa">Entidad empresa</param>
		/// <returns>Resultado de la ejecución</returns>
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

		/// <summary>
		/// Método para eliminar una empresa
		/// </summary>
		/// <param name="empresa">Entidad empresa</param>
		/// <returns>Resultado de la ejecución</returns>
		public int Eliminar(Empresa empresa)
		{
			int f = empresaMapper.Eliminar(empresa);
			if(f == 1)
				f = SistemaManager.DigitoVerificadorManager.GuardarDigitoVerificador(TablasSistema.TABLA_EMPRESA);
			return f;
		}

		/// <summary>
		/// Método para obtener las empresas del sistema
		/// </summary>
		/// <param name="empresa">Entidad empresa</param>
		/// <returns>Lista de empresas</returns>
		public List<Empresa> GetAllEmpresas()
		{
			return empresaMapper.GetAllEmpresas();
		}

		/// <summary>
		/// Método para obtener una empresa del sistema por id
		/// </summary>
		/// <param name="Id">Identificador de la empresa</param>
		/// <returns>Entidad empresa encontrada</returns>
		public Empresa GetEmpresa(int Id)
		{
			return empresaMapper.GetEmpresa(Id);
		}
	}
}
