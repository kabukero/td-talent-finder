using System;
using System.Windows.Forms;
using TalentFinder.BE;
using TalentFinder.BLL;
using TalentFinder.GUI.Helpers;

namespace TalentFinder.GUI
{
	public partial class FrmPanelControl : Form
	{
		public FrmPanelControl()
		{
			InitializeComponent();
		}
		private void ShowFrmHome()
		{
			FrmHome frm = new FrmHome();
			frm.MdiParent = this;
			frm.Show();
			frm.WindowState = FormWindowState.Maximized;
		}
		private void InitFormControls()
		{
			this.Tag = new Frase() { Tag = "panel_de_control" };
		}
		private void FrmPanelControl_Load(object sender, EventArgs e)
		{
			// iniciar controles de formulario
			InitFormControls();

			// suscribir a evento
			IdiomaSubject.CambiarIdioma += IdiomaSubject.CambiarTextoControlFormSegunIdioma;
			IdiomaSubject.Attach(this);

			// disparar evento
			IdiomaSubject.CambiarIdiomaControlesFormulario(this, SistemaManager.Idioma);

			ShowFrmHome();
		}
		private void FrmPanelControl_FormClosing(object sender, FormClosingEventArgs e)
		{
			IdiomaSubject.Detach(this);
		}
	}
}
