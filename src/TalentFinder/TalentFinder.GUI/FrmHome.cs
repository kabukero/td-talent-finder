using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TalentFinder.BE;
using TalentFinder.BLL;
using TalentFinder.GUI.Helpers;

namespace TalentFinder.GUI
{
	public partial class FrmHome : Form, IIdiomaObserver
	{
		public FrmHome()
		{
			InitializeComponent();
		}
		private void InitFormControls()
		{
			this.Tag = new Frase() { Tag = "inicio" };
			gbGestionPostulante.Tag = new Frase() { Tag = "gestion_postulante" };
			gbGestionPerfilProfesional.Tag = new Frase() { Tag = "gestion_perfil_profesional" };
			gbGestionEmpresa.Tag = new Frase() { Tag = "gestion_empresa" };
			gbAdministracionSistema.Tag = new Frase() { Tag = "administracion_sistema" };
			gbArchivo.Tag = new Frase() { Tag = "archivo" };
			BtnCerrarSesion.Tag = new Frase() { Tag = "cerrar_sesion" };
			BtnSalir.Tag = new Frase() { Tag = "salir" };
			BtnPublicarAviso.Tag = new Frase() { Tag = "publicar_aviso" };
			BtnPostularseAviso.Tag = new Frase() { Tag = "postularse_aviso" };
			BtnVerListadoEmpresas.Tag = new Frase() { Tag = "ver_listado_empresas" };
			BtnGestionPerfiles.Tag = new Frase() { Tag = "gestion_perfiles" };
			BtnGestionUsuarios.Tag = new Frase() { Tag = "gestion_usuarios" };
			BtnGestionBackup.Tag = new Frase() { Tag = "gestion_backup" };
		}
		private void AplicarPermiso()
		{
			List<PermisoComponent> perfilesPermisos = SistemaManager.SessionManager.UsuarioLogueado.PermisoComponent;
			BtnVerListadoEmpresas.Visible = SistemaManager.PerfilPermisoManager.TienePermiso(Permisos.LEER_USUARIO, perfilesPermisos);
			BtnGestionPerfiles.Visible = SistemaManager.PerfilPermisoManager.TienePermiso(Permisos.LEER_PERFIL, perfilesPermisos);
			BtnGestionUsuarios.Visible = SistemaManager.PerfilPermisoManager.TienePermiso(Permisos.LEER_USUARIO, perfilesPermisos);
			BtnGestionBackup.Visible = SistemaManager.PerfilPermisoManager.TienePermiso(Permisos.REALIZAR_BACKUP, perfilesPermisos) || SistemaManager.PerfilPermisoManager.TienePermiso(Permisos.REALIZAR_RESTORE, perfilesPermisos);
			BtnPostularseAviso.Visible = SistemaManager.PerfilPermisoManager.TienePermiso(Permisos.POSTULARSE_A_AVISO_LABORAL, perfilesPermisos);
			BtnPublicarAviso.Visible = SistemaManager.PerfilPermisoManager.TienePermiso(Permisos.PUBLICAR_AVISO_LABORAL, perfilesPermisos);
		}
		private void SetWindow()
		{
			//this.ControlBox = false;
			//this.Text = String.Empty;
			this.FormBorderStyle = FormBorderStyle.None;
		}
		private void ShowUsuarioLoguead()
		{
			LblUsuarioLogueado.Text += string.Format(" {0}", SistemaManager.SessionManager.UsuarioLogueado.UserName);
		}
		private void BtnVerListadoEmpresas_Click(object sender, EventArgs e)
		{
			FrmGestionEmpresa frm = new FrmGestionEmpresa();
			frm.MdiParent = this.MdiParent;
			frm.Show();
		}
		private void BtnGestionPerfiles_Click(object sender, EventArgs e)
		{
			FrmGestionPerfilesPermisos frm = new FrmGestionPerfilesPermisos();
			frm.MdiParent = this.MdiParent;
			frm.WindowState = FormWindowState.Maximized;
			frm.Show();
		}
		private void BtnGestiónUsuarios_Click(object sender, EventArgs e)
		{
			FrmGestionUsuariosPerfilesPermisos frm = new FrmGestionUsuariosPerfilesPermisos();
			frm.MdiParent = this.MdiParent;
			frm.WindowState = FormWindowState.Maximized;
			frm.Show();
		}
		private void BtnGestionBackup_Click(object sender, EventArgs e)
		{
			FrmGestionBackup frm = new FrmGestionBackup();
			frm.MdiParent = this.MdiParent;
			frm.Show();
		}
		private void BtnVerBitacora_Click(object sender, EventArgs e)
		{
			FrmBitacoraListado frm = new FrmBitacoraListado();
			frm.MdiParent = this.MdiParent;
			frm.Show();
		}
		private void BtnGestionIdiomas_Click(object sender, EventArgs e)
		{
			FrmGestionIdioma frm = new FrmGestionIdioma();
			frm.MdiParent = this.MdiParent;
			frm.Show();
		}
		private void BtnSalir_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void BtnCerrarSesion_Click(object sender, EventArgs e)
		{
			SistemaManager.BitacoraManager.RegistrarEntrada(SistemaManager.SessionManager.UsuarioLogueado, new TipoEvento() { Id = (int)TiposEventos.INFORMACION }, "Salió del sistema");
			this.MdiParent.Close();
			this.Close();
			FrmLogin frm = new FrmLogin();
			frm.Show();
		}
		public void Update(Idioma idioma)
		{
			GUIHelper.CambiarTextoControlFormSegunIdioma(this, idioma);
		}
		private void FrmHome_Load(object sender, EventArgs e)
		{
			SetWindow();
			ShowUsuarioLoguead();
			AplicarPermiso();

			// iniciar controles de formulario
			InitFormControls();

			// suscribir a evento
			IdiomaSubject.AddObserver(this);

			// actualizar idioma
			Update(SistemaManager.SessionManager.IdiomaSession.IdiomaSelected);
		}
		private void FrmHome_FormClosing(object sender, FormClosingEventArgs e)
		{
			IdiomaSubject.RemoveObserver(this);
		}
	}
}
