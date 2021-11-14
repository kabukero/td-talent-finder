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
using TalentFinder.GUI.Helpers;

namespace TalentFinder.GUI
{
	public partial class FrmBitacoraListado : Form, IIdiomaObserver
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
			LblUsuario.Tag = new Frase() { Tag = "usuario" };
			LblTipoEvento.Tag = new Frase() { Tag = "tipo_evento" };
			LblFechaDesde.Tag = new Frase() { Tag = "fecha_desde" };
			LblFechaHasta.Tag = new Frase() { Tag = "fecha_hasta" };
			DgvListado.Columns["FechaCreacion"].Tag = new Frase() { Tag = "razon_social" };
			DgvListado.Columns["Usuario"].Tag = new Frase() { Tag = "direccion" };
			DgvListado.Columns["TipoEvento"].Tag = new Frase() { Tag = "telefono" };
			DgvListado.Columns["Descripcion"].Tag = new Frase() { Tag = "descripcion" };
		}
		private void SetDatePickers()
		{
			DtpFechaDesde.Format = DateTimePickerFormat.Custom;
			DtpFechaDesde.CustomFormat = "dd/MM/yyyy";
			DtpFechaDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
			DtpFechaHasta.Format = DateTimePickerFormat.Custom;
			DtpFechaHasta.CustomFormat = "dd/MM/yyyy";
			DtpFechaHasta.Value = new DateTime(DateTime.Now.Year, 12, 31);
		}
		private void SetGrilla()
		{
			DgvListado.Columns.Add("FechaCreacion", "Fecha Evento");
			DgvListado.Columns["FechaCreacion"].Width = 30;
			DgvListado.Columns["FechaCreacion"].DataPropertyName = "FechaCreacionFormmated";

			DgvListado.Columns.Add("Usuario", "Usuario");
			DgvListado.Columns["Usuario"].Width = 100;
			DgvListado.Columns["Usuario"].DataPropertyName = "Usuario";

			DgvListado.Columns.Add("TipoEvento", "Tipo Evento");
			DgvListado.Columns["TipoEvento"].Width = 30;
			DgvListado.Columns["TipoEvento"].DataPropertyName = "TipoEvento";

			DgvListado.Columns.Add("Descripcion", "Descripción");
			DgvListado.Columns["Descripcion"].Width = 300;
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
			Usuario usuario = (Usuario)CmbUsuario.SelectedItem;
			TipoEvento tipoEvento = (TipoEvento)CmbTipoEvento.SelectedItem;
			DgvListado.DataSource = null;
			DgvListado.DataSource = SistemaManager.BitacoraManager.GetBitacoraEventos(usuario, tipoEvento, DtpFechaDesde.Value, DtpFechaHasta.Value);
			DgvListado.ClearSelection();
		}
		private void CargarUsuarios()
		{
			CmbUsuario.DataSource = null;
			CmbUsuario.DataSource = SistemaManager.UsuarioManager.GetUsuariosToDropDownList();
		}
		private void CargarTipoEventos()
		{
			CmbTipoEvento.DataSource = null;
			CmbTipoEvento.DataSource = SistemaManager.BitacoraManager.GetBitacoraTipoEventos();
		}
		private void BtnBuscar_Click(object sender, EventArgs e)
		{
			try
			{
				CargarGrilla();
			}
			catch(Exception ex)
			{
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = SistemaManager.ListaTipoEvento.FirstOrDefault(x => x.Id == (int)TiposEventos.ERROR);
				bitacora.Descripcion = ex.Message;
				bitacora.Descripcion = string.Format("FrmBitacora-BtnBuscar_Click: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void BtnCancelar_Click(object sender, EventArgs e)
		{
			CmbUsuario.SelectedIndex = 0;
			CmbTipoEvento.SelectedIndex = 0;
			DtpFechaDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
			DtpFechaHasta.Value = new DateTime(DateTime.Now.Year, 12, 31);
		}
		public void Update(Idioma idioma)
		{
			GUIHelper.CambiarTextoControlFormSegunIdioma(this, idioma);
		}
		private void FrmBitacoraListado_Load(object sender, EventArgs e)
		{
			try
			{
				SetGrilla();
				CargarUsuarios();
				CargarTipoEventos();
				InitFormControls();
				//CargarGrilla();
				SetDatePickers();

				// suscribir a evento
				IdiomaSubject.AddObserver(this);

				// disparar evento
				Update(SistemaManager.SessionManager.IdiomaSession);
			}
			catch(Exception ex)
			{
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = SistemaManager.ListaTipoEvento.FirstOrDefault(x => x.Id == (int)TiposEventos.ERROR);
				bitacora.Descripcion = string.Format("FrmBitacoraListado_Load: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void FrmBitacoraListado_FormClosing(object sender, FormClosingEventArgs e)
		{
			IdiomaSubject.RemoveObserver(this);
		}
	}
}
