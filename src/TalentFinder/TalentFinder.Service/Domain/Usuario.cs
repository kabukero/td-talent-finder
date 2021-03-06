using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;

namespace TalentFinder.Service.Domain
{
	public class Usuario : EntidadBase
	{
		public string UserName { get; set; }
		public string UserPassword { get; set; }
		public override string ToString()
		{
			return UserName;
		}

		[JsonIgnore]
		public List<PermisoComponent> PermisoComponent { get; set; }
		public Persona Persona { get; set; }
		public bool IsInRole(int Id, IList<PermisoComponent> lista)
		{
			var c = GetComponent(Id, lista);
			return c != null;
		}
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
