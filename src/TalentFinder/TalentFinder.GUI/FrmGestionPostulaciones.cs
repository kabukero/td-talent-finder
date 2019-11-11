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
			DgvAvisos.Columns.Add("FechaVigencia", "Fecha");
			DgvAvisos.Columns["FechaVigencia"].Width = 150;
			DgvAvisos.Columns["FechaVigencia"].DataPropertyName = "FechaVigencia";

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
			DgvPostulaciones.Columns.Add("FechaCreacion", "Fecha");
			DgvPostulaciones.Columns["FechaCreacion"].Width = 150;
			DgvPostulaciones.Columns["FechaCreacion"].DataPropertyName = "FechaCreacion";

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
			ChkListTecnologias.DataSource = SistemaManager.TecnologiaManager.GetAllTecnologias();
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

			DgvAvisos.DataSource = null;
			DgvAvisos.DataSource = SistemaManager.AvisoLaboralManager.GetAvisos(TxtPalabraClave.Text, TxtLugarTrabajo.Text, GetTecnologiasId());
		}
		public void CargarPostulaciones()
		{
			DgvPostulaciones.DataSource = null;
			DgvPostulaciones.DataSource = SistemaManager.ProfesionalManager.GetPostulaciones(SistemaManager.SessionManager.Profesional);
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
		private void FrmGestionPostulaciones_Load(object sender, EventArgs e)
		{
			SetGrilla();
			SetGrillaPostulaciones();
			CargarTecnologias();
			CargarPostulaciones();
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
	}
}
