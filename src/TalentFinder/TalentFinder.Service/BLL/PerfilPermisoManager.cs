using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.Service.Domain;
using TalentFinder.Service.DAL;

namespace TalentFinder.Service.BLL
{
	public class PerfilPermisoManager
	{
		private PerfilPermisoMapper perfilPermisoMapper;
		public PerfilPermisoManager()
		{
			perfilPermisoMapper = new PerfilPermisoMapper();
		}
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
		public List<PermisoComponent> GetAllPerfilesPermisosPorUsuario(Usuario usuario)
		{
			List<PermisoComponent> permisoComponents = perfilPermisoMapper.GetAllPerfilesPermisosPorUsuario(usuario);
			return permisoComponents;
		}
		public int GuardarUsuarioPerfilesPermisos(List<PermisoComponent> perfilesPermisos, Usuario usuario)
		{
			return perfilPermisoMapper.GuardarUsuarioPerfilesPermisos(perfilesPermisos, usuario);
		}
		public List<PermisoComponent> GetUsuarioPerfilesPermisosPorUsuario(Usuario usuario)
		{
			return perfilPermisoMapper.GetAllPerfilesPermisos();
		}
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
		public int AgregarPerfil(Perfil perfil)
		{
			return perfilPermisoMapper.AgregarPerfil(perfil);
		}
		public List<Permiso> GetAllPermisos()
		{
			return perfilPermisoMapper.GetAllPermisos();
		}
		public List<Perfil> GetAllPerfiles()
		{
			return perfilPermisoMapper.GetAllPerfiles();
		}
		public int AgregarPermisoPermiso(PermisoPermiso permisoPermiso)
		{
			return perfilPermisoMapper.AgregarPermisoPermiso(permisoPermiso);
		}
		public int EditarPerfil(Perfil perfil)
		{
			return perfilPermisoMapper.EditarPerfil(perfil);
		}
		public int EliminarPerfil(Perfil perfil)
		{
			return perfilPermisoMapper.EliminarPerfil(perfil);
		}
		public Permiso GetPermiso(int Id)
		{
			return new Permiso() { Id = Id };
		}
		public int QuitarPermisoPermisos(List<PermisoPermiso> permisoPermisos)
		{
			return perfilPermisoMapper.QuitarPermisoPermiso(permisoPermisos);
		}
	}
}
