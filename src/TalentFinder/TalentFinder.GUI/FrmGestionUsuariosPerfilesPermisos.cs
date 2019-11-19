using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalentFinder.BE;
using TalentFinder.BLL;
using TalentFinder.GUI.Helpers;

namespace TalentFinder.GUI
{
	public partial class FrmGestionUsuariosPerfilesPermisos : Form, IIdiomaObserver
	{
		public FrmGestionUsuariosPerfilesPermisos()
		{
			InitializeComponent();
		}
		private void InitFormControls()
		{
			this.Tag = new Frase() { Tag = "gestion_perfiles_permisos_usuarios" };
			LblTitulo.Tag = new Frase() { Tag = "seleccione_dir_destino_bkp" };
			LblUsuarios.Tag = new Frase() { Tag = "usuarios" };
			LblPerfilesPermisos.Tag = new Frase() { Tag = "perfiles_permisos" };
			BtnGuardar.Tag = new Frase() { Tag = "guardar" };
		}
		private void CargarLstUsuarios()
		{
			try
			{
				LstUsuarios.DataSource = null;
				LstUsuarios.DataSource = SistemaManager.UsuarioManager.GetUsuarios();
				LstUsuarios.ClearSelected();
			}
			catch(Exception ex)
			{
				LstUsuarios.DataSource = null;
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = new TipoEvento() { Id = (int)TiposEventos.ERROR };
				bitacora.Descripcion = string.Format("FrmGestionUsuariosPerfilesPermisos-CargarLstUsuarios: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void CargarTreeView()
		{
			try
			{
				TvwPerfilesPermisos.Nodes.Clear();
				TvwPerfilesPermisos.CheckBoxes = true;
				List<PermisoComponent> perfilesPermisos = SistemaManager.PerfilPermisoManager.GetAllPerfilesPermisos();
				CargarNodos(perfilesPermisos, null);
				TvwPerfilesPermisos.ExpandAll();
			}
			catch(Exception ex)
			{
				TvwPerfilesPermisos.Nodes.Clear();
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = new TipoEvento() { Id = (int)TiposEventos.ERROR };
				bitacora.Descripcion = string.Format("FrmGestionUsuariosPerfilesPermisos-CargarTreeView: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void CargarNodos(IList<PermisoComponent> perfilesPermisos, TreeNode Padre)
		{
			foreach(PermisoComponent p in perfilesPermisos)
			{
				TreeNode nodo = CrearNodo(p);

				if(Padre == null)
					TvwPerfilesPermisos.Nodes.Add(nodo);
				else
					Padre.Nodes.Add(nodo);

				if(p is Perfil)
				{
					IList<PermisoComponent> nodosHijos = p.Permisos;
					if(nodosHijos.Count > 0)
						CargarNodos(nodosHijos, nodo);
				}
			}
		}
		private TreeNode CrearNodo(PermisoComponent p)
		{
			TreeNode nodo = new TreeNode(p.Nombre);
			nodo.Tag = p;
			return nodo;
		}
		private void CargarUsuarioSeleccionado()
		{
			try
			{
				Usuario usuario = (Usuario)LstUsuarios.SelectedItem;
				if(usuario == null)
					return;
				TxtUsuario.Text = usuario.UserName;

				TxtNombre.Clear();
				TxtApellido.Clear();
				TxtEmail.Clear();
				CmbEmpresa.SelectedIndex = -1;

				if(usuario.Persona != null)
				{
					TxtNombre.Text = usuario.Persona.Nombre;
					TxtApellido.Text = usuario.Persona.Apellido;
					TxtEmail.Text = usuario.Persona.Email;
					for(int i = 0; i < CmbEmpresa.Items.Count; i++)
					{
						Empresa e = (Empresa)CmbEmpresa.Items[i];
						if(e.Id == usuario.Persona.Empresa.Id)
						{
							CmbEmpresa.SelectedIndex = i;
							break;
						}
					}
				}
				RecorrerNodos(TvwPerfilesPermisos.Nodes, usuario.PermisoComponent);
			}
			catch(Exception ex)
			{
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = new TipoEvento() { Id = (int)TiposEventos.ERROR };
				bitacora.Descripcion = string.Format("FrmGestionUsuariosPerfilesPermisos-CargarUsuarioSeleccionado: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void CargarPerfilesPermisosUsuarioSeleccionado()
		{
			try
			{

				if(LstUsuarios.Items.Count == 0 || LstUsuarios.SelectedItem == null)
					return;
				Usuario usuario = (Usuario)LstUsuarios.SelectedItem;
				List<PermisoComponent> perfilesPermisos = SistemaManager.PerfilPermisoManager.GetAllPerfilesPermisosPorUsuario(usuario);
				RecorrerNodos(TvwPerfilesPermisos.Nodes, perfilesPermisos);
			}
			catch(Exception ex)
			{
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = new TipoEvento() { Id = (int)TiposEventos.ERROR };
				bitacora.Descripcion = string.Format("FrmGestionUsuariosPerfilesPermisos-CargarPerfilesPermisosUsuarioSeleccionado: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void RecorrerNodos(TreeNodeCollection nodes, List<PermisoComponent> perfilesPermisos)
		{
			UncheckedAllNodes(nodes);
			foreach(TreeNode nodo in nodes)
			{
				PermisoComponent p = (PermisoComponent)nodo.Tag;
				PermisoComponent item = perfilesPermisos.FirstOrDefault(x => x.Id == p.Id);
				if(item != null)
					nodo.Checked = true;
				RecorrerNodos(nodo.Nodes, perfilesPermisos);
			}
		}
		private void UncheckedAllNodes(TreeNodeCollection nodes)
		{
			foreach(TreeNode node in nodes)
			{
				node.Checked = false;
				UncheckedAllNodes(node.Nodes);
			}
		}
		private void FindCheckedNodes(List<TreeNode> checked_nodes, TreeNodeCollection nodes)
		{
			foreach(TreeNode node in nodes)
			{
				// Add this node.
				if(node.Checked)
					checked_nodes.Add(node);

				// Check the node's descendants.
				FindCheckedNodes(checked_nodes, node.Nodes);
			}
		}
		private bool ValidarUsuario()
		{
			if(string.IsNullOrEmpty(TxtUsuario.Text))
			{
				MessageBox.Show("Ingrese el nombre usuario", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if(string.IsNullOrEmpty(TxtPassword.Text))
			{
				MessageBox.Show("Ingrese la passwor", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if(CmbEmpresa.SelectedIndex == -1)
			{
				MessageBox.Show("Selecione la empresa", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if(string.IsNullOrEmpty(TxtNombre.Text))
			{
				MessageBox.Show("Ingrese el nombre de la persona", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if(string.IsNullOrEmpty(TxtApellido.Text))
			{
				MessageBox.Show("Ingrese el apellido de la persona", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if(string.IsNullOrEmpty(TxtEmail.Text))
			{
				MessageBox.Show("Ingrese el e-mail", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}
		private void CargarEmpresas()
		{
			try
			{
				CmbEmpresa.DataSource = SistemaManager.EmpresaManager.GetAllEmpresas();
			}
			catch(Exception ex)
			{
				CmbEmpresa.DataSource = null;
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = new TipoEvento() { Id = (int)TiposEventos.ERROR };
				bitacora.Descripcion = string.Format("FrmGestionUsuariosPerfilesPermisos-CargarPerfilesPermisosUsuarioSeleccionado: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void Update(Idioma idioma)
		{
			GUIHelper.CambiarTextoControlFormSegunIdioma(this, idioma);
		}
		private void ClearForm()
		{
			CargarLstUsuarios();
			UncheckedAllNodes(TvwPerfilesPermisos.Nodes);
			TvwPerfilesPermisos.SelectedNode = null;
			TxtUsuario.Clear();
			TxtPassword.Clear();
			TxtNombre.Clear();
			TxtApellido.Clear();
			TxtEmail.Clear();
			CmbEmpresa.SelectedIndex = -1;
		}
		private void LstUsuarios_Click(object sender, EventArgs e)
		{
			//CargarPerfilesPermisosUsuarioSeleccionado();
			CargarUsuarioSeleccionado();
		}
		private void BtnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				if(LstUsuarios.Items.Count == 0 || LstUsuarios.SelectedItem == null)
					return;

				Usuario usuario = (Usuario)LstUsuarios.SelectedItem;
				List<TreeNode> treeNodes = new List<TreeNode>();
				List<PermisoComponent> perfilesPermisos = new List<PermisoComponent>();
				FindCheckedNodes(treeNodes, TvwPerfilesPermisos.Nodes);

				foreach(TreeNode nodo in treeNodes)
				{
					perfilesPermisos.Add((PermisoComponent)nodo.Tag);
				}

				try
				{
					SistemaManager.PerfilPermisoManager.GuardarUsuarioPerfilesPermisos(perfilesPermisos, usuario);
					CargarTreeView();
					ClearForm();
					MessageBox.Show("Los permisos se guardaron correctamente", "Usuarios Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch(Exception ex)
				{
					MessageBox.Show("Ha ocurrido un error. Vuelva a intentar mas tarde", "Usuarios Permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch(Exception ex)
			{
				CmbEmpresa.DataSource = null;
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = new TipoEvento() { Id = (int)TiposEventos.ERROR };
				bitacora.Descripcion = string.Format("FrmGestionUsuariosPerfilesPermisos-BtnGuardar_Click: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void BtnAgregarUsuario_Click(object sender, EventArgs e)
		{
			try
			{
				if(!ValidarUsuario())
					return;

				List<TreeNode> treeNodes = new List<TreeNode>();
				List<PermisoComponent> perfilesPermisos = new List<PermisoComponent>();
				FindCheckedNodes(treeNodes, TvwPerfilesPermisos.Nodes);

				foreach(TreeNode nodo in treeNodes)
				{
					perfilesPermisos.Add((PermisoComponent)nodo.Tag);
				}

				Usuario usuario = new Usuario();

				if(!usuario.IsInRole((int)Permisos.PERFIL_POSTULANTE, perfilesPermisos)
					&& !usuario.IsInRole((int)Permisos.PERFIL_RECLUTADOR, perfilesPermisos))
				{
					MessageBox.Show("Debe seleccionar el perfil del usuario (Postulante o Reclutador)", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				usuario.UserName = TxtUsuario.Text;
				usuario.UserPassword = TxtPassword.Text;
				usuario.PermisoComponent = perfilesPermisos;
				Persona persona = new Persona();
				persona.Nombre = TxtNombre.Text;
				persona.Apellido = TxtApellido.Text;
				persona.Email = TxtEmail.Text;
				persona.Empresa = (Empresa)CmbEmpresa.SelectedItem;
				usuario.Persona = persona;
				SistemaManager.UsuarioManager.Agregar(usuario);
				SistemaManager.PerfilPermisoManager.GuardarUsuarioPerfilesPermisos(usuario.PermisoComponent, usuario);
				MessageBox.Show("El usuario se agregó correctamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearForm();
			}
			catch(Exception ex)
			{
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = new TipoEvento() { Id = (int)TiposEventos.ERROR };
				bitacora.Descripcion = string.Format("FrmGestionUsuariosPerfilesPermisos-BtnAgregarUsuario_Click: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void BtnEditarUsuario_Click(object sender, EventArgs e)
		{
			try
			{
				Usuario usuario = (Usuario)LstUsuarios.SelectedItem;
				if(usuario == null)
				{
					MessageBox.Show("Seleccione el usuario", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				if(string.IsNullOrEmpty(TxtUsuario.Text))
				{
					MessageBox.Show("Ingrese el nombre usuario", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				usuario.UserName = TxtUsuario.Text;
				usuario.Persona.Empresa = (Empresa)CmbEmpresa.SelectedItem;
				SistemaManager.UsuarioManager.Editar(usuario, TxtPassword.Text);
				MessageBox.Show("El usuario se editó correctamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearForm();
			}
			catch(Exception ex)
			{
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = new TipoEvento() { Id = (int)TiposEventos.ERROR };
				bitacora.Descripcion = string.Format("FrmGestionUsuariosPerfilesPermisos-BtnEditarUsuario_Click: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void BtnEliminarUsuario_Click(object sender, EventArgs e)
		{
			try
			{
				Usuario usuario = (Usuario)LstUsuarios.SelectedItem;
				if(usuario == null)
				{
					MessageBox.Show("Seleccione el usuario", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				SistemaManager.UsuarioManager.Eliminar(usuario);
				MessageBox.Show("El usuario se eliminó correctamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearForm();
			}
			catch(Exception ex)
			{
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = new TipoEvento() { Id = (int)TiposEventos.ERROR };
				bitacora.Descripcion = string.Format("FrmGestionUsuariosPerfilesPermisos-BtnEliminarUsuario_Click: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void BtnCancelar_Click(object sender, EventArgs e)
		{
			ClearForm();
		}
		private void FrmUsuarioPerfilPermiso_Load(object sender, EventArgs e)
		{
			try
			{
				CargarLstUsuarios();
				CargarTreeView();
				CargarEmpresas();
				ClearForm();

				// iniciar controles de formulario
				InitFormControls();

				// suscribir observer
				IdiomaSubject.AddObserver(this);

				// actualizar idioma
				Update(SistemaManager.SessionManager.IdiomaSession.IdiomaSelected);
			}
			catch(Exception ex)
			{
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = new TipoEvento() { Id = (int)TiposEventos.ERROR };
				bitacora.Descripcion = string.Format("FrmGestionUsuariosPerfilesPermisos-FrmUsuarioPerfilPermiso_Load: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void FrmGestionUsuariosPerfilesPermisos_FormClosing(object sender, FormClosingEventArgs e)
		{
			IdiomaSubject.RemoveObserver(this);
		}
		private void FrmGestionUsuariosPerfilesPermisos_Shown(object sender, EventArgs e)
		{
			ClearForm();
		}
	}
}
