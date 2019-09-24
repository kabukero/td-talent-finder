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
	public partial class FrmGestionUsuariosPerfilesPermisos : Form
	{
		private UsuarioManager usuarioManager = new UsuarioManager();
		private PerfilPermisoManager perfilPermisoManager = new PerfilPermisoManager();

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
			BtnSalir.Tag = new Frase() { Tag = "salir" };
		}

		private void FrmUsuarioPerfilPermiso_Load(object sender, EventArgs e)
		{
			CargarLstUsuarios();
			CargarTreeView();

			// iniciar controles de formulario
			InitFormControls();

			// suscribir a evento
			IdiomaSubject.CambiarIdioma += IdiomaSubject.CambiarTextoControlFormSegunIdioma;
			IdiomaSubject.Attach(this);

			// disparar evento
			IdiomaSubject.CambiarIdiomaControlesFormulario(this, SistemaManager.Idioma);
		}

		private void CargarLstUsuarios()
		{
			LstUsuarios.DataSource = null;
			LstUsuarios.DataSource = usuarioManager.GetUsuarios();
			LstUsuarios.ClearSelected();
		}

		private void CargarTreeView()
		{
			TvwPerfilesPermisos.Nodes.Clear();
			TvwPerfilesPermisos.CheckBoxes = true;
			List<PermisoComponent> perfilesPermisos = perfilPermisoManager.GetAllPerfilesPermisos();
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

		private void LstUsuarios_Click(object sender, EventArgs e)
		{
			CargarPerfilesPermisosUsuarioSeleccionado();
		}

		private void CargarPerfilesPermisosUsuarioSeleccionado()
		{
			if(LstUsuarios.Items.Count == 0 || LstUsuarios.SelectedItem == null)
				return;
			Usuario usuario = (Usuario)LstUsuarios.SelectedItem;
			List<PermisoComponent> perfilesPermisos = perfilPermisoManager.GetAllPerfilesPermisosPorUsuario(usuario);
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

		private void BtnGuardar_Click(object sender, EventArgs e)
		{
			if(LstUsuarios.Items.Count == 0 || LstUsuarios.SelectedItem == null)
				return;

			Usuario usuario = (Usuario)LstUsuarios.SelectedItem;
			List<TreeNode> treeNodes = new List<TreeNode>();
			treeNodes.Clear();
			List<PermisoComponent> perfilesPermisos = new List<PermisoComponent>();
			FindCheckedNodes(treeNodes, TvwPerfilesPermisos.Nodes);

			foreach(TreeNode nodo in treeNodes)
			{
				perfilesPermisos.Add((PermisoComponent)nodo.Tag);
			}

			int f = perfilPermisoManager.GuardarUsuarioPerfilesPermisos(perfilesPermisos, usuario);
			if(f == -1)
			{
				MessageBox.Show("Ha ocurrido un error. Vuelva a intentar mas tarde", "Usuarios Pemrisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				MessageBox.Show("Los permisos se guardaron correctamente", "Usuarios Pemrisos", MessageBoxButtons.OK, MessageBoxIcon.Information);
				CargarTreeView();
			}
		}

		private void BtnSalir_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void FrmGestionUsuariosPerfilesPermisos_FormClosing(object sender, FormClosingEventArgs e)
		{
			IdiomaSubject.Detach(this);
		}
	}
}
