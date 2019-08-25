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
	public partial class FrmLogin : Form
	{
		private UsuarioManager usuarioManager = new UsuarioManager();
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
				GoToPanelDeControl();
			}
			else
			{
				if(usuarioManager.SuperoMaximoIntentosLogin())
				{
					// TODO: deshabilitar usuario
					Application.Exit();
				}
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
			frm.Show();
			this.Hide();
		}
	}
}
