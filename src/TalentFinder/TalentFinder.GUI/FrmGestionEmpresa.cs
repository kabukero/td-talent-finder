using System;
using System.Windows.Forms;
using TalentFinder.BE;
using TalentFinder.BLL;
using TalentFinder.GUI.Helpers;

namespace TalentFinder.GUI
{
	public partial class FrmGestionEmpresa : Form
	{
		private EmpresaManager empresaManager = new EmpresaManager();
		private FrmPanelControl frmParent;
		public FrmGestionEmpresa()
		{
			InitializeComponent();
		}

		private void InitFormControls()
		{
			this.Tag = new Frase() { Tag = "gestion_empresa" };
			gbEmpresa.Tag = new Frase() { Tag = "empresa" };
			BtnAgregar.Tag = new Frase() { Tag = "agregar" };
			BtnEditar.Tag = new Frase() { Tag = "editar" };
			BtnEliminar.Tag = new Frase() { Tag = "eliminar" };
			LblRazonSocial.Tag = new Frase() { Tag = "razon_social" };
			LblDireccion.Tag = new Frase() { Tag = "direccion" };
			LblTelefono.Tag = new Frase() { Tag = "telefono" };
			LblEmail.Tag = new Frase() { Tag = "email" };
			LblCuit.Tag = new Frase() { Tag = "cuit" };
			DgvEmpresas.Columns["RazonSocial"].Tag = new Frase() { Tag = "razon_social" };
			DgvEmpresas.Columns["Direccion"].Tag = new Frase() { Tag = "direccion" };
			DgvEmpresas.Columns["Telefono"].Tag = new Frase() { Tag = "telefono" };
			DgvEmpresas.Columns["Email"].Tag = new Frase() { Tag = "email" };
			DgvEmpresas.Columns["CUIT"].Tag = new Frase() { Tag = "cuit" };
		}

		private void SetGrilla()
		{
			DgvEmpresas.Columns.Add("RazonSocial", "Razón Social");
			DgvEmpresas.Columns["RazonSocial"].Width = 150;
			DgvEmpresas.Columns["RazonSocial"].DataPropertyName = "RazonSocial";

			DgvEmpresas.Columns.Add("Direccion", "Dirección");
			DgvEmpresas.Columns["Direccion"].Width = 150;
			DgvEmpresas.Columns["Direccion"].DataPropertyName = "Direccion";

			DgvEmpresas.Columns.Add("Telefono", "Teléfono");
			DgvEmpresas.Columns["Telefono"].Width = 100;
			DgvEmpresas.Columns["Telefono"].DataPropertyName = "Telefono";

			DgvEmpresas.Columns.Add("Email", "E-mail");
			DgvEmpresas.Columns["Email"].Width = 150;
			DgvEmpresas.Columns["Email"].DataPropertyName = "Email";

			DgvEmpresas.Columns.Add("CUIT", "CUIT");
			DgvEmpresas.Columns["CUIT"].Width = 100;
			DgvEmpresas.Columns["CUIT"].DataPropertyName = "CUIT";

			DgvEmpresas.AllowUserToAddRows = false;
			DgvEmpresas.RowHeadersVisible = false;
			DgvEmpresas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			DgvEmpresas.MultiSelect = false;
			DgvEmpresas.AutoGenerateColumns = false;
			DgvEmpresas.EditMode = DataGridViewEditMode.EditProgrammatically;
			DgvEmpresas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			DgvEmpresas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			DgvEmpresas.RowTemplate.Height = 30;
		}
		private void CargarEmpresas()
		{
			DgvEmpresas.DataSource = null;
			DgvEmpresas.DataSource = empresaManager.GetAllEmpresas();
			DgvEmpresas.ClearSelection();
		}
		private void FillForm(Empresa empresa)
		{
			TxtRazonSocial.Text = empresa.RazonSocial;
			TxtDireccion.Text = empresa.Direccion;
			TxtTelefono.Text = empresa.Telefono;
			TxtEmail.Text = empresa.Email;
			TxtCUIT.Text = empresa.CUIT;
		}
		private void ClearForm()
		{
			TxtRazonSocial.Clear();
			TxtDireccion.Clear();
			TxtTelefono.Clear();
			TxtEmail.Clear();
			TxtCUIT.Clear();
		}
		private bool ValidarCampos()
		{
			if(string.IsNullOrEmpty(TxtRazonSocial.Text))
			{
				MessageBox.Show("Ingrese la razón social", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if(string.IsNullOrEmpty(TxtDireccion.Text))
			{
				MessageBox.Show("Ingrese la dirección", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if(string.IsNullOrEmpty(TxtTelefono.Text))
			{
				MessageBox.Show("Ingrese el teléfono", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if(string.IsNullOrEmpty(TxtEmail.Text))
			{
				MessageBox.Show("Ingrese el Email", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if(string.IsNullOrEmpty(TxtCUIT.Text))
			{
				MessageBox.Show("Ingrese el CUIT", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}
		private void AplicarPermiso()
		{
			if(frmParent.PerfilPermisoManager.TienePermiso(Permisos.CREAR_EMPRESA, frmParent.SessionManager.UsuarioLogueado.PermisoComponent) ||
				frmParent.PerfilPermisoManager.TienePermiso(Permisos.EDITAR_EMPRESA, frmParent.SessionManager.UsuarioLogueado.PermisoComponent))
			{
				TxtRazonSocial.Enabled = true;
				TxtDireccion.Enabled = true;
				TxtTelefono.Enabled = true;
				TxtEmail.Enabled = true;
				TxtCUIT.Enabled = true;
			}
			BtnAgregar.Visible = frmParent.PerfilPermisoManager.TienePermiso(Permisos.CREAR_EMPRESA, frmParent.SessionManager.UsuarioLogueado.PermisoComponent);
			BtnEditar.Visible = frmParent.PerfilPermisoManager.TienePermiso(Permisos.EDITAR_EMPRESA, frmParent.SessionManager.UsuarioLogueado.PermisoComponent);
			BtnEliminar.Visible = frmParent.PerfilPermisoManager.TienePermiso(Permisos.ELIMINAR_EMPRESA, frmParent.SessionManager.UsuarioLogueado.PermisoComponent);
		}
		private void DgvEmpresas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Empresa empresa = (Empresa)DgvEmpresas.CurrentRow.DataBoundItem;

			if(empresa == null)
				return;

			FillForm(empresa);
		}
		private void BtnAgregar_Click(object sender, EventArgs e)
		{
			if(!ValidarCampos())
				return;

			Empresa empresa = new Empresa();
			empresa.RazonSocial = TxtRazonSocial.Text;
			empresa.Direccion = TxtDireccion.Text;
			empresa.Telefono = TxtTelefono.Text;
			empresa.Email = TxtEmail.Text;
			empresa.CUIT = TxtCUIT.Text;
			if(empresaManager.Crear(empresa) == -1)
				MessageBox.Show("Vuelva a intentar más tarde por favor", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
				MessageBox.Show("La empresa se creó correctamente", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);

			CargarEmpresas();
			ClearForm();
		}
		private void BtnEditar_Click(object sender, EventArgs e)
		{
			Empresa empresa = (Empresa)DgvEmpresas.CurrentRow.DataBoundItem;

			if(empresa == null)
				return;

			if(!ValidarCampos())
				return;

			empresa.RazonSocial = TxtRazonSocial.Text;
			empresa.Direccion = TxtDireccion.Text;
			empresa.Telefono = TxtTelefono.Text;
			empresa.Email = TxtEmail.Text;
			empresa.CUIT = TxtCUIT.Text;

			if(empresaManager.Editar(empresa) == -1)
				MessageBox.Show("Vuelva a intentar más tarde por favor", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
				MessageBox.Show("La empresa se editó correctamente", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);

			CargarEmpresas();
			ClearForm();
		}
		private void BtnEliminar_Click(object sender, EventArgs e)
		{
			Empresa empresa = (Empresa)DgvEmpresas.CurrentRow.DataBoundItem;

			if(empresa == null)
				return;

			if(empresaManager.Eliminar(empresa) == -1)
				MessageBox.Show("Vuelva a intentar más tarde por favor", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
				MessageBox.Show("La empresa se eliminó correctamente", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);

			CargarEmpresas();
			ClearForm();
		}
		private void FrmGestionEmpresa_Load(object sender, EventArgs e)
		{
			frmParent = (FrmPanelControl)this.MdiParent;
			SetGrilla();
			CargarEmpresas();
			AplicarPermiso();

			// iniciar controles de formulario
			InitFormControls();

			// suscribir a evento
			IdiomaSubject.CambiarIdioma += IdiomaSubject.CambiarTextoControlFormSegunIdioma;
			IdiomaSubject.Attach(this);

			// disparar evento
			IdiomaSubject.CambiarIdiomaControlesFormulario(this, SistemaManager.Idioma);
		}
		private void FrmGestionEmpresa_Shown(object sender, EventArgs e)
		{
			DgvEmpresas.ClearSelection();
		}

		private void FrmGestionEmpresa_FormClosing(object sender, FormClosingEventArgs e)
		{
			IdiomaSubject.Detach(this);
		}
	}
}
