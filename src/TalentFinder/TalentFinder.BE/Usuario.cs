using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio que representa un usuario dentro del sistema
	/// </summary>
	public class Usuario : EntidadBase
	{
		/// <summary>
		/// Property que contiene el nombre de usuario
		/// </summary>
		public string UserName { get; set; }
		/// <summary>
		/// Property que contiene la clave del usuario
		/// </summary>
		public string UserPassword { get; set; }
		public override string ToString()
		{
			return UserName;
		}

		/// <summary>
		/// Property que contiene una lista con las familias y patentes de un usuario
		/// </summary>
		[JsonIgnore]
		public List<PermisoComponent> PermisoComponent { get; set; }
		/// <summary>
		/// Property que contiene la persona física asociada a un usuario
		/// </summary>
		public Persona Persona { get; set; }

		/// <summary>
		/// Método que determina el usuario tiene un rol
		/// </summary>
		/// <param name="Id">Identificador de una familia o patente</param>
		/// <param name="lista">Lista que contiene las familias y patentes del usuario</param>
		/// <returns>Valor que representa si la lista contiene o no al rol</returns>
		public bool IsInRole(int Id, IList<PermisoComponent> lista)
		{
			var c = GetComponent(Id, lista);
			return c != null;
		}
		/// <summary>
		/// Método para obtener una familia / patente a partir de un id
		/// </summary>
		/// <param name="Id">Identificador de una familia o patente</param>
		/// <param name="lista">Lista que contiene las familias y patentes del usuario</param>
		/// <returns>Una familia o patente</returns>
		public PermisoComponent GetComponent(int Id, IList<PermisoComponent> lista)
		{
			PermisoComponent component = lista != null ? lista.Where(i => i.Id.Equals(Id)).FirstOrDefault() : null;

			if(component == null && lista != null)
			{
				foreach(var c in lista)
				{
					var l = GetComponent(Id, c.Permisos);
					if(l != null && l.Id == Id)
						return l;
					else if(l != null)
						return GetComponent(Id, l.Permisos);
				}
			}
			return component;
		}
	}
}
