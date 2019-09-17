using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;
using TalentFinder.DAL;

namespace TalentFinder.BLL
{
	public class BitacoraManager
	{
		private BitacoraMapper bitacoraMapper;

		public BitacoraManager()
		{
			bitacoraMapper = new BitacoraMapper();
		}

		public int RegistrarEntrada(Usuario usuario, Permiso permiso, string descripcion = null)
		{
			Bitacora bitacora = GetBitacora(usuario, permiso, descripcion);
			return bitacoraMapper.RegistrarEntrada(bitacora);
		}

		private Bitacora GetBitacora(Usuario usuario, Permiso permiso, string descripcion = null)
		{
			Bitacora bitacora = new Bitacora();
			bitacora.Permiso = permiso;
			bitacora.Usuario = usuario;
			bitacora.FechaCreacion = DateTime.Now;
			bitacora.Descripcion = descripcion;
			return bitacora;
		}
	}
}
