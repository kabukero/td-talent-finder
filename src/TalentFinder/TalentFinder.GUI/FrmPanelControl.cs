using System;
using System.Windows.Forms;
using TalentFinder.Seguridad;

namespace TalentFinder.GUI
{
	public partial class FrmPanelControl : Form
	{
		public FrmPanelControl()
		{
			InitializeComponent();
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void FrmPanelControl_Load(object sender, EventArgs e)
		{
			LblUsuarioLogueado.Text = Program.usuarioSesion.UsuarioLogueado.UserName;
		}
	}
}
