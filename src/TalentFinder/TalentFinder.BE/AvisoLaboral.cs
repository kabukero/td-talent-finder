
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	/// <summary>
	/// Entidad de negocio para contener la información
	/// de un aviso laboral
	/// </summary>
	public class AvisoLaboral : EntidadBase
	{
		/// <summary>
		/// Property que contiene el título de un aviso laboral
		/// </summary>
		public string Titulo { get; set; }
		/// <summary>
		/// Property que contiene la descripcion de un aviso laboral
		/// </summary>
		public string Descripcion { get; set; }
		/// <summary>
		/// Property que contiene la fecha de vigencia de un aviso laboral
		/// </summary>
		public DateTime FechaVigencia { get; set; }
		/// <summary>
		/// Property que contiene la fecha de vencimiento de un aviso laboral
		/// </summary>
		public DateTime FechaVencimiento { get; set; }
		/// <summary>
		/// Property que contiene la fecha de creación de un aviso laboral
		/// </summary>
		public DateTime FechaCreacion { get; set; }
		/// <summary>
		/// Property que contiene el lugar de trabajo de un aviso laboral
		/// </summary>
		public string LugarTrabajo { get; set; }
		/// <summary>
		/// Property que contiene el reclutador de un aviso laboral
		/// </summary>
		public Reclutador Reclutador { get; set; }
		/// <summary>
		/// Property que contiene la empresa de un aviso laboral
		/// </summary>
		public Empresa Empresa { get; set; }
		/// <summary>
		/// Property para mostrar en formato español la fecha de vigencia de un aviso laboral
		/// </summary>
		public string FechaVigenciaDisplay
		{
			get
			{
				return FechaVigencia.ToString("dd/MM/yyyy");
			}
		}
		/// <summary>
		/// Método para mostrat en formato string el estado interno de un aviso laboral
		/// </summary>
		public override string ToString()
		{
			return string.Format("{0} ({1})", Descripcion, LugarTrabajo);
		}
	}
}
