using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TalentFinder.BE;
using TalentFinder.BLL;
using TalentFinder.GUI.Helpers;
using TalentFinder.Seguridad;

namespace TalentFinder.GUI
{
	public partial class FrmHome : Form
	{
		private BitacoraManager bitacoraManager = new BitacoraManager();
		private FrmPanelControl frmParent;

		public FrmHome()
		{
			InitializeComponent();
		}

		private void InitFormControls()
		{
			this.Tag = new Frase() { Tag = "inicio" };
			gbSeleccionarIdioma.Tag = new Frase() { Tag = "selecione_idioma" };
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
			List<PermisoComponent> perfilesPermisos = frmParent.SessionManager.UsuarioLogueado.PermisoComponent;
			BtnVerListadoEmpresas.Visible = frmParent.PerfilPermisoManager.TienePermiso(Permisos.LEER_USUARIO, perfilesPermisos);
			BtnGestionPerfiles.Visible = frmParent.PerfilPermisoManager.TienePermiso(Permisos.LEER_PERFIL, perfilesPermisos);
			BtnGestionUsuarios.Visible = frmParent.PerfilPermisoManager.TienePermiso(Permisos.LEER_USUARIO, perfilesPermisos);
			BtnGestionBackup.Visible = frmParent.PerfilPermisoManager.TienePermiso(Permisos.REALIZAR_BACKUP, perfilesPermisos);
			BtnPostularseAviso.Visible = frmParent.PerfilPermisoManager.TienePermiso(Permisos.POSTULARSE_A_AVISO_LABORAL, perfilesPermisos);
			BtnPublicarAviso.Visible = frmParent.PerfilPermisoManager.TienePermiso(Permisos.PUBLICAR_AVISO_LABORAL, perfilesPermisos);
		}

		private void SetWindow()
		{
			//this.ControlBox = false;
			//this.Text = String.Empty;
			this.FormBorderStyle = FormBorderStyle.None;
		}
		private void ShowUsuarioLoguead()
		{
			LblUsuarioLogueado.Text += string.Format(" {0}", frmParent.SessionManager.UsuarioLogueado.UserName);
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

		private void BtnSalir_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void BtnCerrarSesion_Click(object sender, EventArgs e)
		{
			bitacoraManager.RegistrarEntrada(frmParent.SessionManager.UsuarioLogueado, new TipoEvento() { Id = (int)TiposEventos.INFORMACION }, "Salió del sistema");
			this.MdiParent.Close();
			this.Close();
			FrmLogin frm = new FrmLogin();
			frm.Show();
		}

		private void BtnIdiomaSpain_Click(object sender, EventArgs e)
		{
			//IdiomaHelper.CambiarIdiomaControlesFormulario(this, SistemaManager.IdiomaManager.GetIdioma(Idiomas.ESPAÑOL));
			IdiomaSubject.Notify(SistemaManager.IdiomaManager.GetIdioma(Idiomas.ESPAÑOL));
		}

		private void BtnIdiomaEnglish_Click(object sender, EventArgs e)
		{
			//IdiomaHelper.CambiarIdiomaControlesFormulario(this, SistemaManager.IdiomaManager.GetIdioma(Idiomas.INGLES));
			IdiomaSubject.Notify(SistemaManager.IdiomaManager.GetIdioma(Idiomas.INGLES));
		}

		private void BtnIdiomaFrance_Click(object sender, EventArgs e)
		{
			//IdiomaHelper.CambiarIdiomaControlesFormulario(this, SistemaManager.IdiomaManager.GetIdioma(Idiomas.FRANCES));
			IdiomaSubject.Notify(SistemaManager.IdiomaManager.GetIdioma(Idiomas.FRANCES));
		}

		private void FrmHome_Load(object sender, EventArgs e)
		{
			frmParent = (FrmPanelControl)this.MdiParent;
			SetWindow();
			ShowUsuarioLoguead();
			AplicarPermiso();

			// iniciar controles de formulario
			InitFormControls();

			// suscribir a evento
			IdiomaSubject.Attach(this);
			IdiomaSubject.CambiarIdioma += IdiomaSubject.CambiarTextoControlFormSegunIdioma;

			// disparar evento
			IdiomaSubject.CambiarIdiomaControlesFormulario(this, SistemaManager.Idioma);
		}
	}
}
