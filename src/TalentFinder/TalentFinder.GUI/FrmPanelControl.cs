using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TalentFinder.BE;
using TalentFinder.BLL;
using TalentFinder.Seguridad;

namespace TalentFinder.GUI
{
	public partial class FrmPanelControl : Form
	{
		private SessionManager usuarioSesion;
		private PerfilPermisoManager perfilPermisoManager = new PerfilPermisoManager();

		public FrmPanelControl()
		{
			InitializeComponent();
			usuarioSesion = SessionManager.GetUsuarioSesion();
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void FrmPanelControl_Load(object sender, EventArgs e)
		{
			SetMenu();
			ShowFrmHome();
		}

		private void SetMenu()
		{
			List<PermisoComponent> familiasPermisos = usuarioSesion.UsuarioLogueado.PermisoComponent;
			administraciónToolStripMenuItem.Visible = perfilPermisoManager.TienePermiso(Permisos.LEER_USUARIO, familiasPermisos);
			gestiónPostulanteToolStripMenuItem.Visible = perfilPermisoManager.TienePermiso(Permisos.PUBLICAR_AVISO_LABORAL, familiasPermisos);
			gestiónPerfilProfesionalToolStripMenuItem.Visible = perfilPermisoManager.TienePermiso(Permisos.POSTULARSE_A_AVISO_LABORAL, familiasPermisos);
		}

		private void ShowFrmHome()
		{
			FrmHome frm = new FrmHome();
			frm.MdiParent = this;
			frm.WindowState = FormWindowState.Maximized;
			frm.Show();
		}

		private void gestiónPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmGestionPerfilesPermisos frm = new FrmGestionPerfilesPermisos();
			frm.MdiParent = this;
			frm.WindowState = FormWindowState.Maximized;
			frm.Show();
		}

		private void gestiónUsuariosPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmGestionUsuariosPerfilesPermisos frm = new FrmGestionUsuariosPerfilesPermisos();
			frm.MdiParent = this;
			frm.WindowState = FormWindowState.Maximized;
			frm.Show();
		}

		private void verListadoEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmGestionEmpresa frm = new FrmGestionEmpresa();
			frm.MdiParent = this;
			frm.Show();
		}
	}
}
