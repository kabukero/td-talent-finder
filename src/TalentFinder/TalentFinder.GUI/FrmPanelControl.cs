using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TalentFinder.BE;
using TalentFinder.BLL;
using TalentFinder.GUI.Helpers;

namespace TalentFinder.GUI
{
	public partial class FrmPanelControl : Form, IIdiomaObserver
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
		public void CargarMenuIdiomas()
		{
			GUIHelper.CargarMenuIdiomas(toolStripDropDownButtonIdioma, SistemaManager.IdiomaManager.GetAllIdiomas());
		}

		public void Update(Idioma idioma)
		{
			GUIHelper.CambiarTextoControlFormSegunIdioma(this, idioma);
		}

		private void FrmPanelControl_Load(object sender, EventArgs e)
		{
			// iniciar controles de formulario
			InitFormControls();

			// suscribir observer
			IdiomaSubject.AddObserver(this);

			// actualizar idioma
			Update(SistemaManager.SessionManager.IdiomaSession.IdiomaSelected);

			// cargar opciones del menu idiomas
			CargarMenuIdiomas();

			ShowFrmHome();
		}

		private void FrmPanelControl_FormClosing(object sender, FormClosingEventArgs e)
		{
			IdiomaSubject.RemoveObserver(this);
		}
	}
}
