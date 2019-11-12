using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalentFinder.BLL;
using TalentFinder.BE;

namespace TalentFinder.GUI
{
	public partial class FrmExamenEjercicioProgamacion : Form
	{
		private MetodoDetalle MetodoDetalle;
		private ProgramRunner ProgramRunner;
		private TimeSpan HoraInicio;
		private Postulacion Postulacion;
		private FrmGestionPostulaciones frmGestionPostulaciones;
		public FrmExamenEjercicioProgamacion(Postulacion Postulacion, FrmGestionPostulaciones frmGestionPostulaciones)
		{
			this.frmGestionPostulaciones = frmGestionPostulaciones;
			this.Postulacion = Postulacion;
			InitializeComponent();
		}
		private void FinalizoElTiempo()
		{
			TimerClock.Stop();
			TxtCodigoPrograma.Enabled = false;
			BtnEjecutarCodigo.Enabled = false;
			BtnFinalizarExamen.Enabled = false;
			MessageBox.Show("Termino El examen");
		}
		private void TimerClock_Tick(object sender, EventArgs e)
		{
			HoraInicio = HoraInicio.Add(TimeSpan.FromSeconds(-1));
			TxtCurrentElapsedTime.Text = HoraInicio.ToString().Substring(3);

			if(HoraInicio == new TimeSpan(0, 0, 0))
			{
				FinalizoElTiempo();
			}
		}
		private void BtnEjecutarCodigo_Click(object sender, EventArgs e)
		{
			MetodoDetalle.CodigoFuenteMetodo = TxtCodigoPrograma.Text;
			ResultadoEjecucion ResultadoEjecucion = ProgramRunner.EjecutarPrograma(MetodoDetalle);
			MessageBox.Show(ResultadoEjecucion.Descripcion);
		}
		private void BtnFinalizarExamen_Click(object sender, EventArgs e)
		{
			MetodoDetalle.CodigoFuenteMetodo = TxtCodigoPrograma.Text;
			ResultadoEjecucion ResultadoEjecucion = ProgramRunner.EjecutarPrograma(MetodoDetalle);
			MessageBox.Show(ResultadoEjecucion.Descripcion);
			if(ResultadoEjecucion.ResultadoEjecucionEstado == ResultadoEjecucionEstado.EXECUTED)
			{
				frmGestionPostulaciones.CargarPostulaciones();
			}
			this.Hide();
		}
		private void FrmExamenEjercicioProgamacion_Load(object sender, EventArgs e)
		{
			TimerClock.Enabled = true;
			TimerClock.Interval = 1000;
			MetodoDetalle = new MetodoDetalle();
			PostulacionEvalucion postulacionEvalucion = SistemaManager.ProfesionalManager.GetPostulacionEvaluacion(Postulacion);
			MetodoDetalle.EjercicioNombre = postulacionEvalucion.Evaluacion.Ejercicio;
			HoraInicio = TimeSpan.Parse(postulacionEvalucion.Evaluacion.Tiempo);
			TxtCurrentElapsedTime.Text = HoraInicio.ToString().Substring(3);
			LblEnunciado.Text = postulacionEvalucion.Evaluacion.Descripcion;
			ProgramRunner = new ProgramRunner(SistemaManager.SessionManager.UsuarioLogueado);
		}
	}
}
