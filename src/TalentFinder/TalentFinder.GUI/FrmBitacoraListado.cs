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
	public partial class FrmBitacoraListado : Form
	{
		public FrmBitacoraListado()
		{
			InitializeComponent();
		}
		private void InitFormControls()
		{
			this.Tag = new Frase() { Tag = "bitacora_listado" };
			GbBuscador.Tag = new Frase() { Tag = "criterios_busqueda" };
			BtnBuscar.Tag = new Frase() { Tag = "buscar" };
			BtnCancelar.Tag = new Frase() { Tag = "cancelar" };
			LblTipoEvento.Tag = new Frase() { Tag = "tipo_evento" };
			LblFechaDesde.Tag = new Frase() { Tag = "fecha_desde" };
			LblFechaHasta.Tag = new Frase() { Tag = "fecha_hasta" };
			DgvListado.Columns["RazonSocial"].Tag = new Frase() { Tag = "razon_social" };
			DgvListado.Columns["Direccion"].Tag = new Frase() { Tag = "direccion" };
			DgvListado.Columns["Telefono"].Tag = new Frase() { Tag = "telefono" };
			DgvListado.Columns["Email"].Tag = new Frase() { Tag = "email" };
			DgvListado.Columns["CUIT"].Tag = new Frase() { Tag = "cuit" };
		}
		private void SetDatePickers()
		{
			DtpFechaDesde.CustomFormat = "dd/MM/yyyy";
			DtpFechaHasta.CustomFormat = "dd/MM/yyyy";
		}
		private void SetGrilla()
		{
			DgvListado.Columns.Add("FechaCreacion", "Fecha Evento");
			DgvListado.Columns["FechaCreacion"].Width = 100;
			DgvListado.Columns["FechaCreacion"].DataPropertyName = "FechaCreacion";

			DgvListado.Columns.Add("Usuario", "Usuario");
			DgvListado.Columns["Usuario"].Width = 150;
			DgvListado.Columns["Usuario"].DataPropertyName = "Usuario";

			DgvListado.Columns.Add("TipoEvento", "Tipo Evento");
			DgvListado.Columns["TipoEvento"].Width = 50;
			DgvListado.Columns["TipoEvento"].DataPropertyName = "TipoEvento";

			DgvListado.Columns.Add("Descripcion", "Descripción");
			DgvListado.Columns["Descripcion"].Width = 200;
			DgvListado.Columns["Descripcion"].DataPropertyName = "Descripcion";

			DgvListado.AllowUserToAddRows = false;
			DgvListado.RowHeadersVisible = false;
			DgvListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			DgvListado.MultiSelect = false;
			DgvListado.AutoGenerateColumns = false;
			DgvListado.EditMode = DataGridViewEditMode.EditProgrammatically;
			DgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			DgvListado.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			DgvListado.RowTemplate.Height = 30;
		}
		private void CargarGrilla()
		{
			TipoEvento tipoEvento = (TipoEvento)CmbTipoEvento.SelectedItem;
			DgvListado.DataSource = null;
			DgvListado.DataSource = SistemaManager.BitacoraManager.GetAll(tipoEvento, DtpFechaDesde.Value, DtpFechaHasta.Value);
			DgvListado.ClearSelection();
		}
		private void BtnBuscar_Click(object sender, EventArgs e)
		{
			CargarGrilla();
		}
		private void FrmBitacoraListado_Load(object sender, EventArgs e)
		{
			InitFormControls();
			SetGrilla();
			//CargarGrilla();
			SetDatePickers();
		}

	}
}
