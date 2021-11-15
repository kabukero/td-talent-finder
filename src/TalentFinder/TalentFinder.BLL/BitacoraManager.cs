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
	/// Entidad de negocio para gestionar la bitacora del sistema
	/// </summary>
	public class BitacoraManager
	{
		/// <summary>
		/// Atributo que contiene el mapper la bitacora para persistir los datos
		/// </summary>
		private BitacoraMapper bitacoraMapper = new BitacoraMapper();

		/// <summary>
		/// Método que permite escribir una entrada en la bitacora del sistema
		/// </summary>
		/// <param name="usuario">El usuario autor de la entrada</param>
		/// <param name="TipoEvento">El tipo de evento generado en el sistema</param>
		/// <param name="descripcion">La descripción de la nueva entrada</param>
		public void RegistrarEntrada(Usuario usuario, TipoEvento TipoEvento, string descripcion = null)
		{
			Bitacora bitacora = GetBitacora(usuario, TipoEvento, descripcion);
			bitacoraMapper.RegistrarEntradaSql(bitacora);
		}

		/// <summary>
		/// Método que permite escribir una entrada en formato json en la bitacora del sistema
		/// </summary>
		/// <param name="bitacora">Una bitacora a escribir</param>
		public void RegistrarEntradaJson(Bitacora bitacora)
		{
			bitacoraMapper.RegistrarEntradaJson(bitacora);
		}

		/// <summary>
		/// Método que obtiene los eventos del sistama registrados en la bitácora
		/// por criterio de búsqueda
		/// </summary>
		/// <param name="usuario">El autor del evento generado en el sistema</param>
		/// <param name="TipoEvento">El tipo de evento generado en el sistema</param>
		/// <param name="FechaDesde">La fecha desde</param>
		/// <param name="FechaHasta">La fecha hasta</param>
		/// <returns>Lista de eventos generados en el sistema</returns>
		public List<Bitacora> GetBitacoraEventos(Usuario usuario, TipoEvento TipoEvento, DateTime? FechaDesde, DateTime? FechaHasta)
		{
			return bitacoraMapper.GetBitacoraEventos(usuario, TipoEvento, FechaDesde, FechaHasta);
		}

		/// <summary>
		/// Método para crar un objeto bitácora
		/// </summary>
		/// <param name="usuario">El autor de la entrada de la bitácora</param>
		/// <param name="TipoEvento">El tipo de evento generado en el sistema</param>
		/// <param name="descripcion">La descripción de la entrada de la bitácora</param>
		/// <returns>Una bitacora</returns>
		private Bitacora GetBitacora(Usuario usuario, TipoEvento TipoEvento, string descripcion = null)
		{
			Bitacora bitacora = new Bitacora();
			bitacora.TipoEvento = TipoEvento;
			bitacora.Usuario = usuario;
			bitacora.FechaCreacion = DateTime.Now;
			bitacora.Descripcion = descripcion;
			return bitacora;
		}

		/// <summary>
		/// Método para obtener los tipos eventos que se pueden generar en el sistema
		/// </summary>
		/// <returns>Lista de eventos del sistema</returns>
		public List<TipoEvento> GetBitacoraTipoEventos()
		{
			List<TipoEvento> lista = bitacoraMapper.GetBitacoraTipoEventos();
			lista.Insert(0, new TipoEvento() { Id = 0, Nombre = "Seleccione" });
			return lista;
		}

		/// <summary>
		/// Método para obtener un tipo de evento a partir del identificador
		/// </summary>
		/// <param name="id">El identificador de un tipo de evento</param>
		/// <returns>El tipo de evento encontrado</returns>
		public TipoEvento GetBitacoraTipoEvento(int id)
		{
			return  bitacoraMapper.GetBitacoraTipoEvento(id);
		}
	}
}
