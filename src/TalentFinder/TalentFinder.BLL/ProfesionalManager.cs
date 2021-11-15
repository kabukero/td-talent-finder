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
	/// Entidad de negocio para gestionar los profesionales del sistema
	/// </summary>
	public class ProfesionalManager
	{
		/// <summary>
		/// Atributo mappter del profesional para gestionar la persistencia en el sistema
		/// </summary>
		private ProfesionalMapper ProfesionalMapper = new ProfesionalMapper();

		/// <summary>
		/// Método para obtener el profesional asociado a un usuario
		/// </summary>
		/// <param name="usuario">Un usuario</param>
		/// <returns>Un profesional encontrado</returns>
		public Profesional GetProfesional(Usuario usuario)
		{
			return ProfesionalMapper.GetProfesional(usuario);
		}

		/// <summary>
		/// Método para obtener las postulaciones de un profesional
		/// </summary>
		/// <param name="Profesional">Un profesional</param>
		/// <returns>Lista de postulaciones de un profesional</returns>
		public IList<Postulacion> GetPostulaciones(Profesional Profesional)
		{
			return ProfesionalMapper.GetPostulaciones(Profesional);
		}

		/// <summary>
		/// Método para obtener las evaluaciones de las postulaciones
		/// </summary>
		/// <param name="Postulacion">Una postulación</param>
		/// <returns>Una postulación evaluación</returns>
		public PostulacionEvaluacion GetPostulacionEvaluacion(Postulacion Postulacion)
		{
			return ProfesionalMapper.GetPostulacionEvaluacion(Postulacion);
		}

		/// <summary>
		/// Método para verificar si un profesional se postulo a un aviso laboral
		/// </summary>
		/// <param name="avisoLaboral">Un aviso laboral</param>
		/// <returns>Resultado de la validación</returns>
		public int YaSePostulo(AvisoLaboral avisoLaboral)
		{
			return ProfesionalMapper.YaSePostulo(avisoLaboral);
		}

		/// <summary>
		/// Método el estado a una postulación
		/// </summary>
		/// <param name="postulacion">Una postulación</param>
		/// <param name="postulacionEvalucion">Una postulación evaluación</param>
		public void CambiarEstadoPostulacion(Postulacion postulacion, PostulacionEvaluacion postulacionEvalucion)
		{
			ProfesionalMapper.CambiarEstadoPostulacion(postulacion, postulacionEvalucion);
		}

		/// <summary>
		/// Método para postularse a un aviso laboral
		/// </summary>
		/// <param name="postulacion">Una postulación</param>
		public void Postularse(Postulacion postulacion)
		{
			ProfesionalMapper.Postularse(postulacion);
		}
	}
}