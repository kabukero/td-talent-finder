using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalentFinder.BE;
using TalentFinder.BLL;

namespace TalentFinder.GUI
{
	public partial class FrmGestionPostulaciones : Form
	{
		public FrmGestionPostulaciones()
		{
			InitializeComponent();
		}
		private void SetGrilla()
		{
			DgvAvisos.Columns.Add("FechaVigenciaDisplay", "Fecha");
			DgvAvisos.Columns["FechaVigenciaDisplay"].Width = 150;
			DgvAvisos.Columns["FechaVigenciaDisplay"].DataPropertyName = "FechaVigenciaDisplay";

			DgvAvisos.Columns.Add("Descripcion", "Descripción");
			DgvAvisos.Columns["Descripcion"].Width = 800;
			DgvAvisos.Columns["Descripcion"].DataPropertyName = "Descripcion";

			DgvAvisos.Columns.Add("LugarTrabajo", "Lugar");
			DgvAvisos.Columns["LugarTrabajo"].Width = 150;
			DgvAvisos.Columns["LugarTrabajo"].DataPropertyName = "LugarTrabajo";

			DgvAvisos.AllowUserToAddRows = false;
			DgvAvisos.RowHeadersVisible = false;
			DgvAvisos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			DgvAvisos.MultiSelect = false;
			DgvAvisos.AutoGenerateColumns = false;
			DgvAvisos.EditMode = DataGridViewEditMode.EditProgrammatically;
			//DgvAvisos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			DgvAvisos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			DgvAvisos.RowTemplate.Height = 30;
		}
		private void SetGrillaPostulaciones()
		{
			DgvPostulaciones.Columns.Add("FechaCreacionDisplay", "Fecha");
			DgvPostulaciones.Columns["FechaCreacionDisplay"].Width = 150;
			DgvPostulaciones.Columns["FechaCreacionDisplay"].DataPropertyName = "FechaCreacionDisplay";

			DgvPostulaciones.Columns.Add("Descripcion", "Descripción");
			DgvPostulaciones.Columns["Descripcion"].Width = 800;
			DgvPostulaciones.Columns["Descripcion"].DataPropertyName = "AvisoLaboral";

			DgvPostulaciones.Columns.Add("Estado", "Estado");
			DgvPostulaciones.Columns["Estado"].Width = 150;
			DgvPostulaciones.Columns["Estado"].DataPropertyName = "PostulacionEstado";

			DgvPostulaciones.AllowUserToAddRows = false;
			DgvPostulaciones.RowHeadersVisible = false;
			DgvPostulaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			DgvPostulaciones.MultiSelect = false;
			DgvPostulaciones.AutoGenerateColumns = false;
			DgvPostulaciones.EditMode = DataGridViewEditMode.EditProgrammatically;
			//DgvPostulaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			DgvPostulaciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			DgvPostulaciones.RowTemplate.Height = 30;
		}
		private void CargarTecnologias()
		{
			try
			{
				ChkListTecnologias.DataSource = SistemaManager.TecnologiaManager.GetAllTecnologias();
			}
			catch(Exception ex)
			{
				ChkListTecnologias.DataSource = null;
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = new TipoEvento() { Id = (int)TiposEventos.ERROR };
				bitacora.Descripcion = string.Format("FrmGestionPostulaciones-CargarTecnologias: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private string GetTecnologiasId()
		{
			string separador = "", ids = "";
			foreach(int indexChecked in ChkListTecnologias.CheckedIndices)
			{
				if(ChkListTecnologias.GetItemCheckState(indexChecked) == CheckState.Checked)
				{
					Tecnologia t = (Tecnologia)ChkListTecnologias.Items[indexChecked];
					ids += separador + t.Id;
					separador = ",";
				}
			}
			return ids;
		}
		private void CargarAvisos()
		{
			try
			{
				DgvAvisos.DataSource = null;
				DgvAvisos.DataSource = SistemaManager.AvisoLaboralManager.GetAvisos(TxtPalabraClave.Text, TxtLugarTrabajo.Text, GetTecnologiasId());
				DgvAvisos.ClearSelection();
			}
			catch(Exception ex)
			{
				ChkListTecnologias.DataSource = null;
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = new TipoEvento() { Id = (int)TiposEventos.ERROR };
				bitacora.Descripcion = string.Format("FrmGestionPostulaciones-CargarAvisos: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void CargarPostulaciones()
		{
			try
			{
				DgvPostulaciones.DataSource = null;
				DgvPostulaciones.DataSource = SistemaManager.ProfesionalManager.GetPostulaciones(SistemaManager.SessionManager.Profesional);
			}
			catch(Exception ex)
			{
				DgvPostulaciones.DataSource = null;
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = new TipoEvento() { Id = (int)TiposEventos.ERROR };
				bitacora.Descripcion = string.Format("FrmGestionPostulaciones-CargarAvisos: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void BtnBuscarAvisos_Click(object sender, EventArgs e)
		{
			CargarAvisos();
		}
		private void BtnCancelar_Click(object sender, EventArgs e)
		{
			TxtPalabraClave.Clear();
			TxtPalabraClave.Clear();
			foreach(int indexChecked in ChkListTecnologias.CheckedIndices)
			{
				ChkListTecnologias.SetItemChecked(indexChecked, false);
			}
			DgvAvisos.DataSource = null;
		}
		private void BtnRealizarEvaluacion_Click(object sender, EventArgs e)
		{
			Postulacion Postulacion = (Postulacion)DgvPostulaciones.CurrentRow.DataBoundItem;
			if(Postulacion == null)
				return;
			FrmExamenEjercicioProgamacion frm = new FrmExamenEjercicioProgamacion(Postulacion, this);
			frm.MdiParent = this.MdiParent;
			frm.Show();
		}
		private void BtnAplicarAviso_Click(object sender, EventArgs e)
		{
			try
			{
				AvisoLaboral avisoLaboral = (AvisoLaboral)DgvAvisos.CurrentRow.DataBoundItem;
				if(avisoLaboral == null)
					return;
				PostulacionEstado postulacionEstado = new PostulacionEstado();
				postulacionEstado.Id = (int)PostulacionEstados.INICIADA;
				Postulacion postulacion = new Postulacion();
				postulacion.FechaCreacion = DateTime.Now;
				postulacion.Profesional = SistemaManager.SessionManager.Profesional;
				postulacion.AvisoLaboral = avisoLaboral;
				postulacion.PostulacionEstado = postulacionEstado;
				SistemaManager.ProfesionalManager.Postularse(postulacion);
			}
			catch(Exception ex)
			{
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = new TipoEvento() { Id = (int)TiposEventos.ERROR };
				bitacora.Descripcion = string.Format("FrmGestionPostulaciones-BtnAplicarAviso_Click: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void DgvPostulaciones_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Postulacion p = (Postulacion)DgvPostulaciones.CurrentRow.DataBoundItem;
			if(p == null)
				return;
			BtnRealizarEvaluacion.Enabled = p.PostulacionEstado.Id == (int)PostulacionEstados.EN_EVALUACION;
		}
		private void DgvAvisos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				AvisoLaboral a = (AvisoLaboral)DgvAvisos.CurrentRow.DataBoundItem;
				if(a == null)
					return;
				BtnAplicarAviso.Enabled = SistemaManager.ProfesionalManager.YaSePostulo(a) == 0;
			}
			catch(Exception ex)
			{
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = new TipoEvento() { Id = (int)TiposEventos.ERROR };
				bitacora.Descripcion = string.Format("FrmGestionPostulaciones-DgvAvisos_CellClick: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void DgvPostulaciones_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			DgvPostulaciones.ClearSelection();
		}
		private void DgvAvisos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			DgvAvisos.ClearSelection();
		}
		private void FrmGestionPostulaciones_Load(object sender, EventArgs e)
		{
			try
			{
				SetGrilla();
				SetGrillaPostulaciones();
				CargarTecnologias();
				CargarPostulaciones();
			}
			catch(Exception ex)
			{
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = new TipoEvento() { Id = (int)TiposEventos.ERROR };
				bitacora.Descripcion = string.Format("FrmGestionPostulaciones-FrmGestionPostulaciones_Load: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
