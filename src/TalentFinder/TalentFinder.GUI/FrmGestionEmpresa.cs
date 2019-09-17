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
	public partial class FrmGestionEmpresa : Form
	{
		private EmpresaManager empresaManager = new EmpresaManager();

		public FrmGestionEmpresa()
		{
			InitializeComponent();
		}

		private void FrmGestionEmpresa_Load(object sender, EventArgs e)
		{
			CargarEmpresas();
		}

		private void CargarEmpresas()
		{
			DgvEmpresas.DataSource = null;
			DgvEmpresas.DataSource = empresaManager.GetAllEmpresas();
		}

		private void DgvEmpresas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Empresa empresa = (Empresa)DgvEmpresas.CurrentRow.DataBoundItem;

			if(empresa == null)
				return;

			FillForm(empresa);
		}

		private void FillForm(Empresa empresa)
		{
			TxtRazonSocial.Text = empresa.RazonSocial;
			TxtDireccion.Text = empresa.Direccion;
			TxtTelefono.Text = empresa.Telefono;
			TxtCUIT.Text = empresa.CUIT;
		}

		private void ClearForm()
		{
			TxtRazonSocial.Clear();
			TxtDireccion.Clear();
			TxtTelefono.Clear();
			TxtCUIT.Clear();
		}

		private void BtnAgregar_Click(object sender, EventArgs e)
		{
			if(!ValidarCampos())
				return;

			Empresa empresa = new Empresa();
			empresa.RazonSocial = TxtRazonSocial.Text;
			empresa.Direccion = TxtDireccion.Text;
			empresa.Telefono = TxtTelefono.Text;
			empresa.CUIT = TxtCUIT.Text;
			empresa.Email = TxtEmail.Text;
			empresaManager.Crear(empresa);
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
			empresa.CUIT = TxtCUIT.Text;
			empresa.Email = TxtEmail.Text;
			empresaManager.Editar(empresa);
			CargarEmpresas();
			ClearForm();
		}

		private void BtnEliminar_Click(object sender, EventArgs e)
		{
			Empresa empresa = (Empresa)DgvEmpresas.CurrentRow.DataBoundItem;

			if(empresa == null)
				return;

			empresaManager.Eliminar(empresa);
			CargarEmpresas();
			ClearForm();
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
			if(string.IsNullOrEmpty(TxtCUIT.Text))
			{
				MessageBox.Show("Ingrese el CUIT", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if(string.IsNullOrEmpty(TxtEmail.Text))
			{
				MessageBox.Show("Ingrese el Email", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}
	}
}
