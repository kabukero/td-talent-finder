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
			LstUsuarios.DataSource = null;
			LstUsuarios.DataSource = SistemaManager.UsuarioManager.GetUsuarios();
			LstUsuarios.ClearSelected();
		}
		private void CargarTreeView()
		{
			TvwPerfilesPermisos.Nodes.Clear();
			TvwPerfilesPermisos.CheckBoxes = true;
			List<PermisoComponent> perfilesPermisos = SistemaManager.PerfilPermisoManager.GetAllPerfilesPermisos();
			CargarNodos(perfilesPermisos, null);
			TvwPerfilesPermisos.ExpandAll();
		}
		private void CargarNodos(List<PermisoComponent> perfilesPermisos, TreeNode Padre)
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
					List<PermisoComponent> nodosHijos = ((Perfil)p).Permisos;
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
			Usuario usuario = (Usuario)LstUsuarios.SelectedItem;
			if(usuario == null)
				return;
			TxtUsuario.Text = usuario.UserName;
			for(int i = 0; i < CmbUsuarioTipo.Items.Count; i++)
			{
				UsuarioTipo t = (UsuarioTipo)CmbUsuarioTipo.Items[i];
				if(t.Id == usuario.UsuarioTipo.Id)
				{
					CmbUsuarioTipo.SelectedIndex = i;
					break;
				}
			}
		}
		private void CargarPerfilesPermisosUsuarioSeleccionado()
		{
			if(LstUsuarios.Items.Count == 0 || LstUsuarios.SelectedItem == null)
				return;
			Usuario usuario = (Usuario)LstUsuarios.SelectedItem;
			List<PermisoComponent> perfilesPermisos = SistemaManager.PerfilPermisoManager.GetAllPerfilesPermisosPorUsuario(usuario);
			RecorrerNodos(TvwPerfilesPermisos.Nodes, perfilesPermisos);
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
			if(CmbUsuarioTipo.SelectedIndex == -1)
			{
				MessageBox.Show("Selecione el tipo de usuario", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}
		private void CargarUsuariosTipos()
		{
			CmbUsuarioTipo.DataSource = SistemaManager.UsuarioManager.GetUsuarioTipos();
		}
		public void Update(Idioma idioma)
		{
			GUIHelper.CambiarTextoControlFormSegunIdioma(this, idioma);
		}
		private void ClearForm()
		{
			LstUsuarios.ClearSelected();
			UncheckedAllNodes(TvwPerfilesPermisos.Nodes);
			TvwPerfilesPermisos.SelectedNode = null;
			TxtUsuario.Clear();
			TxtPassword.Clear();
			CmbUsuarioTipo.SelectedIndex = -1;
		}
		private void LstUsuarios_Click(object sender, EventArgs e)
		{
			CargarPerfilesPermisosUsuarioSeleccionado();
			CargarUsuarioSeleccionado();
		}
		private void BtnGuardar_Click(object sender, EventArgs e)
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

			int f = SistemaManager.PerfilPermisoManager.GuardarUsuarioPerfilesPermisos(perfilesPermisos, usuario);
			if(f == -1)
			{
				MessageBox.Show("Ha ocurrido un error. Vuelva a intentar mas tarde", "Usuarios Permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				CargarTreeView();
				ClearForm();
				MessageBox.Show("Los permisos se guardaron correctamente", "Usuarios Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private void BtnAgregarUsuario_Click(object sender, EventArgs e)
		{
			try
			{
				if(!ValidarUsuario())
					return;
				Usuario usuario = new Usuario();
				usuario.UserName = TxtUsuario.Text;
				usuario.UserPassword = TxtPassword.Text;
				usuario.UsuarioTipo = (UsuarioTipo)CmbUsuarioTipo.SelectedItem;
				SistemaManager.UsuarioManager.Agregar(usuario);
				MessageBox.Show("El usuario se agregó correctamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearForm();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Ha ocurrido un error interno. Vuelva a intentar más tarde", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				usuario.UsuarioTipo = (UsuarioTipo)CmbUsuarioTipo.SelectedItem;
				SistemaManager.UsuarioManager.Editar(usuario, TxtPassword.Text);
				MessageBox.Show("El usuario se editó correctamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearForm();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Ha ocurrido un error interno. Vuelva a intentar más tarde", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				MessageBox.Show("Ha ocurrido un error interno. Vuelva a intentar más tarde", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void BtnCancelar_Click(object sender, EventArgs e)
		{
			ClearForm();
		}
		private void FrmUsuarioPerfilPermiso_Load(object sender, EventArgs e)
		{
			CargarLstUsuarios();
			CargarTreeView();
			CargarUsuariosTipos();
			ClearForm();

			// iniciar controles de formulario
			InitFormControls();

			// suscribir observer
			IdiomaSubject.AddObserver(this);

			// actualizar idioma
			Update(SistemaManager.SessionManager.IdiomaSession.IdiomaSelected);
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
