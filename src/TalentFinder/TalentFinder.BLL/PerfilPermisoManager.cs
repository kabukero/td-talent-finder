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
	/// Entidad de negocio para gestionar los perfiles y permisos del sistema
	/// </summary>
	public class PerfilPermisoManager
	{
		/// <summary>
		/// Atributo que contiene el mapper de familias y patentes para gestionar la persistencia
		/// </summary>
		private PerfilPermisoMapper perfilPermisoMapper;
		public PerfilPermisoManager()
		{
			perfilPermisoMapper = new PerfilPermisoMapper();
		}

		/// <summary>
		/// Método para obtener las familias y patentes disponibles en el sistema
		/// </summary>
		/// <returns></returns>
		public List<PermisoComponent> GetAllPerfilesPermisos()
		{
			List<PermisoComponent> permisoComponents = perfilPermisoMapper.GetAllPerfilesPermisos();

			foreach(PermisoComponent p1 in permisoComponents)
			{
				foreach(PermisoComponent p2 in permisoComponents)
				{
					if(p2.PermisoPadreId == p1.Id)
					{
						try
						{
							p1.Agregar(p2);
						}
						catch(Exception ex)
						{
							string error = ex.Message;
						}
					}
				}
			}
			List<PermisoComponent> permisoComponentsAux = permisoComponents.Where(x => x.PermisoPadreId == (int)Permisos.ROOT).ToList();
			return permisoComponentsAux;
		}

		/// <summary>
		/// Método para obtener las familias y patentes por usuario disponibles en el sistema 
		/// </summary>
		/// <param name="usuario">Un usuario</param>
		/// <returns>Lista de familias y patentes</returns>
		public List<PermisoComponent> GetAllPerfilesPermisosPorUsuario(Usuario usuario)
		{
			List<PermisoComponent> permisoComponents = perfilPermisoMapper.GetAllPerfilesPermisosPorUsuario(usuario);
			return permisoComponents;
		}

		/// <summary>
		/// Método para guardar las familias y patentes asociadas a un usuario
		/// </summary>
		/// <param name="perfilesPermisos"></param>
		/// <param name="usuario"></param>
		/// <returns>Resultado de la ejecución</returns>
		public int GuardarUsuarioPerfilesPermisos(List<PermisoComponent> perfilesPermisos, Usuario usuario)
		{
			return perfilPermisoMapper.GuardarUsuarioPerfilesPermisos(perfilesPermisos, usuario);
		}

		/// <summary>
		/// Método para obtener las familias y patentes por usuario disponibles en el sistema 
		/// </summary>
		/// <param name="usuario">Un usuario</param>
		/// <returns>Lista de familias y patentes</returns>
		public List<PermisoComponent> GetUsuarioPerfilesPermisosPorUsuario(Usuario usuario)
		{
			return perfilPermisoMapper.GetAllPerfilesPermisos();
		}

		/// <summary>
		/// Método para verificar si una lista de permisos los contiene lista de familias y patentes
		/// </summary>
		/// <param name="permisos">Lista de permisos</param>
		/// <param name="perfilesPermisos">Lista de familias y patentes</param>
		/// <returns>Resultado de la verificación</returns>
		public bool TienePermiso(Permisos permisos, List<PermisoComponent> perfilesPermisos)
		{
			bool r = false;
			foreach(PermisoComponent p in perfilesPermisos)
			{
				if(p.Id == (int)permisos)
				{
					r = true;
					break;
				}
			}
			//PermisoComponent pc = familiasPermisos.FirstOrDefault(x => x.Id == (int)permisos);
			//return pc == null;
			return r;
		}

		/// <summary>
		/// Método para agregar una familia al sistema
		/// </summary>
		/// <param name="perfil">Una familia</param>
		/// <returns>Resultado de la ejecución</returns>
		public int AgregarPerfil(Perfil perfil)
		{
			return perfilPermisoMapper.AgregarPerfil(perfil);
		}

		/// <summary>
		/// Mëtodo para obtener las patenes del sistema
		/// </summary>
		/// <returns>Lista de patentes</returns>
		public List<Permiso> GetAllPermisos()
		{
			return perfilPermisoMapper.GetAllPermisos();
		}

		/// <summary>
		/// Método para obtener las familias del sistema
		/// </summary>
		/// <returns></returns>
		public List<Perfil> GetAllPerfiles()
		{
			return perfilPermisoMapper.GetAllPerfiles();
		}

		/// <summary>
		/// Método para agregar una relación familia - patente
		/// </summary>
		/// <param name="permisoPermiso">Una familia patente</param>
		/// <returns>Resultado de la ejecución</returns>
		public int AgregarPermisoPermiso(PermisoPermiso permisoPermiso)
		{
			return perfilPermisoMapper.AgregarPermisoPermiso(permisoPermiso);
		}

		/// <summary>
		/// Método para editar una relación familia - patente
		/// </summary>
		/// <param name="permisoPermiso">Una familia patente</param>
		/// <returns>Resultado de la ejecución</returns>
		public int EditarPerfil(Perfil perfil)
		{
			return perfilPermisoMapper.EditarPerfil(perfil);
		}

		/// <summary>
		/// Método para eliminar una relación familia - patente
		/// </summary>
		/// <param name="permisoPermiso">Una familia patente</param>
		/// <returns>Resultado de la ejecución</returns>
		public int EliminarPerfil(Perfil perfil)
		{
			return perfilPermisoMapper.EliminarPerfil(perfil);
		}

		/// <summary>
		/// Método para obtener una patente por id
		/// </summary>
		/// <param name="permisoPermiso">Un id de una patente</param>
		/// <returns>Una patente encontrada</returns>
		public Permiso GetPermiso(int Id)
		{
			return new Permiso() { Id = Id };
		}

		/// <summary>
		/// Método para quitar una relación familia - patente a una familia
		/// </summary>
		/// <param name="permisoPermiso">Una lista de familias patentes</param>
		/// <returns>Resultado de la ejecución</returns>
		public int QuitarPermisoPermisos(List<PermisoPermiso> permisoPermisos)
		{
			return perfilPermisoMapper.QuitarPermisoPermiso(permisoPermisos);
		}
	}
}
