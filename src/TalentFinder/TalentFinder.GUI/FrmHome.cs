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

		private void IniciarControlesFormulario()
		{
			this.Tag = new Frase() { Tag = "inicio" };
			gbGestionPostulante.Tag = new Frase() { Tag = "gestion_postulante" };
			gbGestionPerfilProfesional.Tag = new Frase() { Tag = "gestion_perfil_profesional" };
			gbGestionEmpresa.Tag = new Frase() { Tag = "gestion_empresa" };
			gbAdministracionSistema.Tag = new Frase() { Tag = "administracion_sistema" };
			gbArchivo.Tag = new Frase() { Tag = "archivo" };

			BtnGestionAvisosLaborales.Tag = new Frase() { Tag = "avisos_laborales" };

			BtnGestionPostulaciones.Tag = new Frase() { Tag = "postularse_aviso" };

			BtnVerListadoEmpresas.Tag = new Frase() { Tag = "ver_listado_empresas" };
			BtnGestionPerfiles.Tag = new Frase() { Tag = "gestion_perfiles" };
			BtnGestionUsuarios.Tag = new Frase() { Tag = "gestion_usuarios" };
			BtnGestionBackup.Tag = new Frase() { Tag = "gestion_backup" };

			BtnCerrarSesion.Tag = new Frase() { Tag = "cerrar_sesion" };
			BtnSalir.Tag = new Frase() { Tag = "salir" };
		}

		private void AplicarPermiso()
		{
			List<PermisoComponent> perfilesPermisos = SistemaManager.SessionManager.UsuarioLogueado.PermisoComponent;

			BtnGestionAvisosLaborales.Visible = SistemaManager.PerfilPermisoManager.TienePermiso(Permisos.PUBLICAR_AVISO_LABORAL, perfilesPermisos);

			BtnGestionPostulaciones.Visible = SistemaManager.PerfilPermisoManager.TienePermiso(Permisos.POSTULARSE_A_AVISO_LABORAL, perfilesPermisos);

			BtnVerListadoEmpresas.Visible = SistemaManager.PerfilPermisoManager.TienePermiso(Permisos.LEER_USUARIO, perfilesPermisos);
			BtnGestionPerfiles.Visible = SistemaManager.PerfilPermisoManager.TienePermiso(Permisos.LEER_PERFIL, perfilesPermisos);
			BtnGestionUsuarios.Visible = SistemaManager.PerfilPermisoManager.TienePermiso(Permisos.LEER_USUARIO, perfilesPermisos);
			BtnGestionBackup.Visible = SistemaManager.PerfilPermisoManager.TienePermiso(Permisos.REALIZAR_BACKUP, perfilesPermisos) || SistemaManager.PerfilPermisoManager.TienePermiso(Permisos.REALIZAR_RESTORE, perfilesPermisos);
			BtnVerBitacora.Visible = SistemaManager.PerfilPermisoManager.TienePermiso(Permisos.VER_BITACORA, perfilesPermisos);
			BtnGestionIdiomas.Visible = SistemaManager.PerfilPermisoManager.TienePermiso(Permisos.GESTION_IDIOMAS, perfilesPermisos);


		}

		private void SetearVentana()
		{
			//this.ControlBox = false;
			//this.Text = String.Empty;
			this.FormBorderStyle = FormBorderStyle.None;
		}

		private void MostrarUsuarioLogueado()
		{
			LblUsuarioLogueado.Text += string.Format(" {0}", SistemaManager.SessionManager.UsuarioLogueado.UserName);
		}

		private void BtnGestionAvisosLaborales_Click(object sender, EventArgs e)
		{
			FrmGestionAvisoLaboral frm = new FrmGestionAvisoLaboral();
			frm.MdiParent = this.MdiParent;
			frm.Show();

		}

		private void BtnGestionPostulaciones_Click(object sender, EventArgs e)
		{
			FrmGestionPostulaciones frm = new FrmGestionPostulaciones();
			frm.MdiParent = this.MdiParent;
			frm.Show();
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
			SetearVentana();
			MostrarUsuarioLogueado();
			AplicarPermiso();

			// iniciar controles de formulario
			IniciarControlesFormulario();

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
