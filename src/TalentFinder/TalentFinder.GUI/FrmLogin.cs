using System;
using System.Windows.Forms;
using TalentFinder.BE;
using TalentFinder.BLL;
using TalentFinder.GUI.Helpers;

namespace TalentFinder.GUI
{
	public partial class FrmLogin : Form, IIdiomaObserver
	{
		public FrmLogin()
		{
			InitializeComponent();
		}
		private void LimpiarForm()
		{
			TxtPassword.Clear();
			TxtPassword.Focus();
		}
		private void GoToPanelDeControl()
		{
			FrmPanelControl frm = new FrmPanelControl();
			frm.IsMdiContainer = true;
			frm.Show();
			this.Hide();
		}
		private void InitFormControls()
		{
			this.Tag = new Frase() { Tag = "ingreso_sistema" };
			LblTitulo.Tag = new Frase() { Tag = "ingrese_credenciales" };
			LblUsuario.Tag = new Frase() { Tag = "usuario" };
			LblPassword.Tag = new Frase() { Tag = "clave" };
			BtnIngresar.Tag = new Frase() { Tag = "ingresar" };
			BtnCancelar.Tag = new Frase() { Tag = "salir" };
		}
		public void Update(Idioma idioma)
		{
			GUIHelper.CambiarTextoControlFormSegunIdioma(this, idioma);
		}
		private void LanzarProcesoVerificacionIntegridadDatos()
		{
			if(!SistemaManager.DigitoVerificadorManager.VerificarIntegridadDatosSistema())
			{
				BtnIngresar.Visible = false;
				MessageBox.Show("Comuniquese con el administrador del sistema", "Ingreso sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void BtnCancelar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void BtnIngresar_Click(object sender, EventArgs e)
		{
			Usuario usuario = SistemaManager.UsuarioManager.CrearUsuarioLogin(TxtUsuario.Text, TxtPassword.Text);
			if(SistemaManager.UsuarioManager.ValidarLogin(usuario))
			{
				SistemaManager.BitacoraManager.RegistrarEntrada(usuario, new TipoEvento() { Id = (int)TiposEventos.INFORMACION }, "Ingresó al sistema");
				GoToPanelDeControl();
			}
			else
			{
				if(SistemaManager.UsuarioManager.SuperoMaximoIntentosLogin(usuario))
					Application.Exit();
				else
				{
					LimpiarForm();
					MessageBox.Show("Las credenciales son incorrectas. Vuelva a intentar", "Ingreso sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}
		private void FrmLogin_Load(object sender, EventArgs e)
		{
			// iniciar controles de formulario
			InitFormControls();

			// suscribir a evento
			IdiomaSubject.AddObserver(this);

			// disparar evento
			Update(SistemaManager.SessionManager.IdiomaSession.IdiomaSelected);

			// cargar opciones del menu idiomas
			GUIHelper.CargarMenuIdiomas(toolStripDropDownButtonIdioma, SistemaManager.IdiomaManager.GetAllIdiomas());

			// Lanzar proceso de verificacion integridad de los datos del sistema
			LanzarProcesoVerificacionIntegridadDatos();
		}
		private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			IdiomaSubject.RemoveObserver(this);
		}
	}
}
