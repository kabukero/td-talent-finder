using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TalentFinder.BE;
using TalentFinder.BLL;
using TalentFinder.GUI.Helpers;
using TalentFinder.Seguridad;

namespace TalentFinder.GUI
{
	public partial class FrmPanelControl : Form
	{
		private SessionManager sessionManager;
		private PerfilPermisoManager perfilPermisoManager = new PerfilPermisoManager();

		public PerfilPermisoManager PerfilPermisoManager
		{
			get
			{
				return perfilPermisoManager;
			}
		}

		public SessionManager SessionManager
		{
			get
			{
				return sessionManager;
			}
		}

		public FrmPanelControl()
		{
			InitializeComponent();
			sessionManager = SessionManager.GetUsuarioSesion();
		}

		private void SetMenu()
		{
			List<PermisoComponent> familiasPermisos = sessionManager.UsuarioLogueado.PermisoComponent;
			//administraciónToolStripMenuItem.Visible = perfilPermisoManager.TienePermiso(Permisos.LEER_USUARIO, familiasPermisos);
			//gestiónPostulanteToolStripMenuItem.Visible = perfilPermisoManager.TienePermiso(Permisos.PUBLICAR_AVISO_LABORAL, familiasPermisos);
			//gestiónPerfilProfesionalToolStripMenuItem.Visible = perfilPermisoManager.TienePermiso(Permisos.POSTULARSE_A_AVISO_LABORAL, familiasPermisos);
			//gestiónEmpresaToolStripMenuItem.Visible = perfilPermisoManager.TienePermiso(Permisos.LEER_EMPRESA, familiasPermisos);
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
			SetMenu();

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
