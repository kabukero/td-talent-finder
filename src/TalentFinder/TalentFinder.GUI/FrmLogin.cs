using System;
using System.Windows.Forms;
using TalentFinder.BE;
using TalentFinder.BLL;

namespace TalentFinder.GUI
{
	public partial class FrmLogin : Form
	{
		private UsuarioManager usuarioManager = new UsuarioManager();
		private BitacoraManager bitacoraManager = new BitacoraManager();
		private PerfilPermisoManager perfilPermisoManager = new PerfilPermisoManager();
		public FrmLogin()
		{
			InitializeComponent();
		}

		private void BtnCancelar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void BtnIngresar_Click(object sender, EventArgs e)
		{
			Usuario usuario = usuarioManager.CrearUsuarioLogin(TxtUsuario.Text, TxtPassword.Text);
			if(usuarioManager.ValidarLogin(usuario))
			{
				bitacoraManager.RegistrarEntrada(usuario, perfilPermisoManager.GetPermiso((int)Permisos.LOGIN_SISTEMA), "Ingresó al sistema");
				GoToPanelDeControl();
			}
			else
			{
				if(usuarioManager.SuperoMaximoIntentosLogin(usuario))
					Application.Exit();
				else
				{
					LimpiarForm();
					MessageBox.Show("Las credenciales son incorrectas. Vuelva a intentar", "Ingreso sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void LimpiarForm()
		{
			TxtPassword.Clear();
			TxtPassword.Focus();
		}

		private void GoToPanelDeControl()
		{
			FrmPanelControl frm = new FrmPanelControl();
			frm.IsMdiContainer = true;
			frm.Show();
			this.Hide();
		}

		private void FrmLogin_Load(object sender, EventArgs e)
		{

		}
	}
}
