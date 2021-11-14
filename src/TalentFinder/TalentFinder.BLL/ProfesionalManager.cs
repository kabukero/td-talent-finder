using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.BE;
using TalentFinder.DAL;

namespace TalentFinder.BLL
{
	public class ProfesionalManager
	{
		private ProfesionalMapper ProfesionalMapper = new ProfesionalMapper();
		public Profesional GetProfesional(Usuario usuario)
		{
			return ProfesionalMapper.GetProfesional(usuario);
		}
		public IList<Postulacion> GetPostulaciones(Profesional Profesional)
		{
			return ProfesionalMapper.GetPostulaciones(Profesional);
		}
		public PostulacionEvaluacion GetPostulacionEvaluacion(Postulacion Postulacion)
		{
			return ProfesionalMapper.GetPostulacionEvaluacion(Postulacion);
		}
		public int YaSePostulo(AvisoLaboral avisoLaboral)
		{
			return ProfesionalMapper.YaSePostulo(avisoLaboral);
		}
		public void CambiarEstadoPostulacion(Postulacion postulacion, PostulacionEvaluacion postulacionEvalucion)
		{
			ProfesionalMapper.CambiarEstadoPostulacion(postulacion, postulacionEvalucion);
		}
		public void Postularse(Postulacion postulacion)
		{
			ProfesionalMapper.Postularse(postulacion);
		}
	}
}