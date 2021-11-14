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
		public void RegistrarEntrada(Usuario usuario, TipoEvento TipoEvento, string descripcion = null)
		{
			Bitacora bitacora = GetBitacora(usuario, TipoEvento, descripcion);
			bitacoraMapper.RegistrarEntradaSql(bitacora);
		}
		public void RegistrarEntradaJson(Bitacora bitacora)
		{
			bitacoraMapper.RegistrarEntradaJson(bitacora);
		}
		public List<Bitacora> GetBitacoraEventos(Usuario usuario, TipoEvento TipoEvento, DateTime? FechaDesde, DateTime? FechaHasta)
		{
			return bitacoraMapper.GetBitacoraEventos(usuario, TipoEvento, FechaDesde, FechaHasta);
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
		public List<TipoEvento> GetBitacoraTipoEventos()
		{
			List<TipoEvento> lista = bitacoraMapper.GetBitacoraTipoEventos();
			lista.Insert(0, new TipoEvento() { Id = 0, Nombre = "Seleccione" });
			return lista;
		}

		public TipoEvento GetBitacoraTipoEvento(int id)
		{
			return  bitacoraMapper.GetBitacoraTipoEvento(id);
		}
	}
}
