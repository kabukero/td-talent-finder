using System;
using System.Windows.Forms;
using TalentFinder.BE;
using TalentFinder.BLL;
using TalentFinder.GUI.Helpers;

namespace TalentFinder.GUI
{
	public partial class FrmLogin : Form
	{
		private UsuarioManager usuarioManager = new UsuarioManager();
		private BitacoraManager bitacoraManager = new BitacoraManager();
		private PerfilPermisoManager perfilPermisoManager = new PerfilPermisoManager();
		private IdiomaManager IdiomaManager = new IdiomaManager();
		private IdiomaHelper IdiomaHelper = new IdiomaHelper();

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
			gbSeleccionarIdioma.Tag = new Frase() { Tag = "selecione_idioma" };
			LblTitulo.Tag = new Frase() { Tag = "ingrese_credenciales" };
			LblUsuario.Tag = new Frase() { Tag = "usuario" };
			LblPassword.Tag = new Frase() { Tag = "clave" };
			BtnIngresar.Tag = new Frase() { Tag = "ingresar" };
			BtnCancelar.Tag = new Frase() { Tag = "salir" };
		}

		private void BtnCancelar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void BtnIngresar_Click(object sender, EventArgs e)
		{
			Usuario usuario = usuarioManager.CrearUsuarioLogin(TxtUsuario.Text, TxtPassword.Text);
			if(usuarioManager.ValidarLogin(usuario))
			{
				bitacoraManager.RegistrarEntrada(usuario, perfilPermisoManager.GetPermiso((int)Permisos.LOGIN_SISTEMA), "Ingresó al sistema");
				GoToPanelDeControl();
			}
			else
			{
				if(usuarioManager.SuperoMaximoIntentosLogin(usuario))
					Application.Exit();
				else
				{
					LimpiarForm();
					MessageBox.Show("Las credenciales son incorrectas. Vuelva a intentar", "Ingreso sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void BtnIdiomaSpain_Click(object sender, EventArgs e)
		{
			IdiomaHelper.CambiarIdiomaControlesFormulario(this, SistemaManager.IdiomaManager.GetIdioma(Idiomas.ESPAÑOL));
		}

		private void BtnIdiomaEnglish_Click(object sender, EventArgs e)
		{
			IdiomaHelper.CambiarIdiomaControlesFormulario(this, SistemaManager.IdiomaManager.GetIdioma(Idiomas.INGLES));
		}

		private void BtnIdiomaFrance_Click(object sender, EventArgs e)
		{
			IdiomaHelper.CambiarIdiomaControlesFormulario(this, SistemaManager.IdiomaManager.GetIdioma(Idiomas.FRANCES));
		}

		private void FrmLogin_Load(object sender, EventArgs e)
		{
			// iniciar controles de formulario
			InitFormControls();

			// suscribir a evento
			IdiomaHelper.CambiarIdioma += IdiomaHelper.CambiarTextoControlFormSegunIdioma;

			// disparar evento
			IdiomaHelper.CambiarIdiomaControlesFormulario(this, SistemaManager.IdiomaManager.GetIdioma(Idiomas.ESPAÑOL));
		}
	}
}
