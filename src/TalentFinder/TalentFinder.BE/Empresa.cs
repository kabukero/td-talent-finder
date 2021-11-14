using System;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio para representa la empresa que realiza búsquedas laborales
	/// </summary>
	public class Empresa : EntidadBase
	{
		/// <summary>
		/// Property para contener la razon social de la empresa
		/// </summary>
		public string RazonSocial { get; set; }
		/// <summary>
		/// Property para contener la direccion de la empresa
		/// </summary>
		public string Direccion { get; set; }
		/// <summary>
		/// Property para contener el teléfono de la empresa
		/// </summary>
		public string Telefono { get; set; }
		/// <summary>
		/// Property para contener e-mail de la empresa
		/// </summary>
		public string Email { get; set; }
		/// <summary>
		/// Property para contener el CUIT de la empresa
		/// </summary>
		public string CUIT { get; set; }
		/// <summary>
		/// Property para contener la fecha de creación de la empresa
		/// </summary>
		public DateTime FechaCreacion { get; set; }
		/// <summary>
		/// Property para mostrar en formato español la fecha de creación de la empresa
		/// </summary>
		public String FechaCreacionFormateada
		{
			get
			{
				return FechaCreacion.ToString("yyyy/MM/dd HH:mm:ss");
			}
		}
		public DateTime FechaActualizacion { get; set; }
		/// <summary>
		/// Property para contener la fecha actualización de la empresa
		/// </summary>
		public String FechaActualizacionFormateada
		{
			get
			{
				return FechaActualizacion.ToString("yyyy/MM/dd HH:mm:ss");
			}
		}
		/// <summary>
		/// Property para contener la fecha de creación histórico de la empresa
		/// </summary>
		public DateTime FechaCreacionHistorico { get; set; }
		/// <summary>
		/// Property para mostrar en formato español la fecha de creación de la empresa
		/// </summary>
		public String FechaCreacionHistoricoFormateada
		{
			get
			{
				return FechaCreacionHistorico.ToString("yyyy/MM/dd HH:mm:ss");
			}
		}
		/// <summary>
		/// Property para contener dígito verificador horizontal de la empresa
		/// </summary>
		public Int64 DVH { get; set; }
		/// <summary>
		/// Property para mostrar el estado interno de la empresa
		/// </summary>
		public override string ToString()
		{
			return RazonSocial;
		}
	}
}
