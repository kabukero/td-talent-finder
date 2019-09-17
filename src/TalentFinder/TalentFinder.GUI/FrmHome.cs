using System;
using System.Windows.Forms;
using TalentFinder.Seguridad;

namespace TalentFinder.GUI
{
	public partial class FrmHome : Form
	{
		private SessionManager usuarioSesion;
		public FrmHome()
		{
			InitializeComponent();
			usuarioSesion = SessionManager.GetUsuarioSesion();
		}

		private void FrmHome_Load(object sender, EventArgs e)
		{
			ShowUsuarioLoguead();
		}
		private void ShowUsuarioLoguead()
		{
			LblUsuarioLogueado.Text += string.Format(" {0}", usuarioSesion.UsuarioLogueado.UserName);
		}
	}
}
