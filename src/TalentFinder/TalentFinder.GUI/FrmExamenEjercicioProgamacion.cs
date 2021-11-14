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
		private TimeSpan TiempoTranscurrido;
		private Postulacion Postulacion;
		private PostulacionEvaluacion postulacionEvalucion;
		private FrmGestionPostulaciones frmGestionPostulaciones;

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
			TiempoTranscurrido = TiempoTranscurrido.Add(TimeSpan.FromSeconds(-1));
			TxtCurrentElapsedTime.Text = TiempoTranscurrido.ToString().Substring(3);

			if(TiempoTranscurrido == new TimeSpan(0, 0, 0))
			{
				FinalizoElTiempo();
			}
		}

		private void BtnEjecutarCodigo_Click(object sender, EventArgs e)
		{
			try
			{
				MetodoDetalle.CodigoFuenteMetodo = TxtCodigoPrograma.Text;
				ResultadoEjecucion ResultadoEjecucion = ProgramRunner.EjecutarPrograma(MetodoDetalle);
				MessageBox.Show(ResultadoEjecucion.Descripcion);
			}
			catch(Exception ex)
			{
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = SistemaManager.ListaTipoEvento.FirstOrDefault(x => x.Id == (int)TiposEventos.ERROR);
				bitacora.Descripcion = string.Format("FrmExamenEjercicioProgamacion-BtnEjecutarCodigo_Click: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnFinalizarExamen_Click(object sender, EventArgs e)
		{
			try
			{
				MetodoDetalle.CodigoFuenteMetodo = TxtCodigoPrograma.Text;
				ResultadoEjecucion ResultadoEjecucion = ProgramRunner.EjecutarPrograma(MetodoDetalle);
				postulacionEvalucion.Aprobo = ResultadoEjecucion.ResultadoEjecucionEstado == ResultadoEjecucionEstado.EXECUTED;
				postulacionEvalucion.Respuesta = TxtCodigoPrograma.Text;
				postulacionEvalucion.TiempoResolucionEvaluacion = HoraInicio.Subtract(TiempoTranscurrido).ToString().Substring(3);
				Postulacion.PostulacionEstado.Id = (int)PostulacionEstados.EVALUADO;
				SistemaManager.ProfesionalManager.CambiarEstadoPostulacion(Postulacion, postulacionEvalucion);
				frmGestionPostulaciones.CargarPostulaciones();
				MessageBox.Show(ResultadoEjecucion.Descripcion);
				TimerClock.Stop();
				this.Hide();
			}
			catch(Exception ex)
			{
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = SistemaManager.ListaTipoEvento.FirstOrDefault(x => x.Id == (int)TiposEventos.ERROR);
				bitacora.Descripcion = string.Format("FrmExamenEjercicioProgamacion-BtnFinalizarExamen_Click: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public FrmExamenEjercicioProgamacion(Postulacion Postulacion, FrmGestionPostulaciones frmGestionPostulaciones)
		{
			this.frmGestionPostulaciones = frmGestionPostulaciones;
			this.Postulacion = Postulacion;
			InitializeComponent();
		}

		private string getCodigoMetodoInicial()
		{
			return "public ... MiMetodo( ... )" + Environment.NewLine + "{" + Environment.NewLine + "}";
		}

		private void inicializarExamen()
		{
			TxtCodigoPrograma.Text = getCodigoMetodoInicial();
			LblEnunciado.Focus();
			TimerClock.Enabled = true;
			TimerClock.Interval = 1000;
			postulacionEvalucion = SistemaManager.ProfesionalManager.GetPostulacionEvaluacion(Postulacion);
			MetodoDetalle = new MetodoDetalle();
			MetodoDetalle.EjercicioNombre = postulacionEvalucion.Evaluacion.Ejercicio;
			MetodoDetalle.CodigoFuenteTest = postulacionEvalucion.Evaluacion.CodigoFuenteTest;
			LblEnunciado.Text = postulacionEvalucion.Evaluacion.Descripcion;
			HoraInicio = TimeSpan.Parse(postulacionEvalucion.Evaluacion.Tiempo);
			TiempoTranscurrido = TimeSpan.Parse(postulacionEvalucion.Evaluacion.Tiempo);
			TxtCurrentElapsedTime.Text = TiempoTranscurrido.ToString().Substring(3);
			ProgramRunner = new ProgramRunner(SistemaManager.SessionManager.UsuarioLogueado);
		}

		private void FrmExamenEjercicioProgamacion_Load(object sender, EventArgs e)
		{
			try
			{
				inicializarExamen();
			}
			catch(Exception ex)
			{
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = SistemaManager.ListaTipoEvento.FirstOrDefault(x => x.Id == (int)TiposEventos.ERROR);
				bitacora.Descripcion = string.Format("FrmExamenEjercicioProgamacion_Load: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void FrmExamenEjercicioProgamacion_FormClosing(object sender, FormClosingEventArgs e)
		{
			TimerClock.Stop();
		}
	}
}
