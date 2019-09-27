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
		private BitacoraMapper bitacoraMapper = new BitacoraMapper();
		public int RegistrarEntrada(Usuario usuario, TipoEvento TipoEvento, string descripcion = null)
		{
			Bitacora bitacora = GetBitacora(usuario, TipoEvento, descripcion);
			return bitacoraMapper.RegistrarEntrada(bitacora);
		}
		private Bitacora GetBitacora(Usuario usuario, TipoEvento TipoEvento, string descripcion = null)
		{
			Bitacora bitacora = new Bitacora();
			bitacora.TipoEvento = TipoEvento;
			bitacora.Usuario = usuario;
			bitacora.FechaCreacion = DateTime.Now;
			bitacora.Descripcion = descripcion;
			return bitacora;
		}
	}
}
