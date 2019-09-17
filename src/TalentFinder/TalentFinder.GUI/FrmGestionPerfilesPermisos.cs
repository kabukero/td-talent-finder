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

namespace TalentFinder.GUI
{
	public partial class FrmGestionPerfilesPermisos : Form
	{
		private UsuarioManager usuarioManager = new UsuarioManager();
		private PerfilPermisoManager perfilPermisoManager = new PerfilPermisoManager();
		private TipoPermisoManager TipoPermisoManager = new TipoPermisoManager();

		public FrmGestionPerfilesPermisos()
		{
			InitializeComponent();
		}

		private void CargarLstPermisos()
		{
			LstPermisos.DataSource = null;
			LstPermisos.DataSource = perfilPermisoManager.GetAllPermisos();
			LstPermisos.ClearSelected();
		}
		private void CargarLstPerfiles()
		{
			LstPerfiles.DataSource = null;
			LstPerfiles.DataSource = perfilPermisoManager.GetAllPerfiles();
			LstPerfiles.ClearSelected();
		}
		private void CargarTreeView()
		{
			TvwPerfilesPermisos.Nodes.Clear();
			CargarNodos(perfilPermisoManager.GetAllPerfilesPermisos(), null);
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

		private void TvwPerfilesPermisos_ItemDrag(object sender, ItemDragEventArgs e)
		{
			DoDragDrop(e.Item, DragDropEffects.Move);
		}

		private void TvwPerfilesPermisos_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Move;
		}

		private void TvwPerfilesPermisos_DragDrop(object sender, DragEventArgs e)
		{
			if(ModifierKeys == Keys.Control)
			{
				MessageBox.Show("with CTRL");
				return;
			}
			// Retrieve the client coordinates of the drop location.
			// Obtener las coordenadas del nodo destino seleccionado
			Point targetPoint = TvwPerfilesPermisos.PointToClient(new Point(e.X, e.Y));

			// Retrieve the node at the drop location.
			// Obtener el nodo destino seleccionado segun las coordenadas destino
			TreeNode targetNode = TvwPerfilesPermisos.GetNodeAt(targetPoint);

			// Retrieve the node that was dragged.
			// Obtener el nodo origen seleccionado
			TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

			// Verificar que haya un nodo seleccionado
			if(draggedNode == null)
			{
				return;
			}

			// Did the user drop on a valid target node?
			// Validar Nodo destino
			if(targetNode == null)
			{
				// The user dropped the node on the treeview control instead
				// of another node so lets place the node at the bottom of the tree.
				// El usuario dropped el nodo sobre el treeview en vez
				// seleccionar un nodo destino
				draggedNode.Remove();
				TvwPerfilesPermisos.Nodes.Add(draggedNode);
				draggedNode.Expand();
			}
			else
			{
				TreeNode parentNode = targetNode;

				// Confirm that the node at the drop location is not 
				// the dragged node and that target node isn't null
				// (for example if you drag outside the control)
				// Validar que el nodo origen y destino no sean iguales
				// Validar que haya seleccionado un nodo destino
				if(!draggedNode.Equals(targetNode) && targetNode != null)
				{
					bool canDrop = true;

					// Crawl our way up from the node we dropped on to find out if
					// if the target node is our parent. 
					// Validar que el nodo destino no sea padre del nodo origen
					while(canDrop && (parentNode != null))
					{
						canDrop = !Object.ReferenceEquals(draggedNode, parentNode);
						parentNode = parentNode.Parent;
					}

					// Is this a valid drop location?
					if(canDrop)
					{
						// Yes. Move the node, expand it, and select it.
						draggedNode.Remove();
						targetNode.Nodes.Add(draggedNode);
						targetNode.Expand();
					}
				}
			}

			// Optional: Select the dropped node and navigate (however you do it)
			TvwPerfilesPermisos.SelectedNode = draggedNode;
			// NavigateToContent(draggedNode.Tag);
		}

		private void FrmGestionPerfilesPermisos_Load(object sender, EventArgs e)
		{
			CargarTreeView();
			CargarLstPermisos();
			CargarLstPerfiles();
		}

		private void TvwPerfilesPermisos_Click(object sender, EventArgs e)
		{
			//TreeNode nodo = TvwPerfilesPermisos.SelectedNode;
			//if(nodo != null)
			//	reut
		}

		private void FrmGestionPerfilesPermisos_Shown(object sender, EventArgs e)
		{
			TvwPerfilesPermisos.SelectedNode = null;
		}

		private void BtnGuardar_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(TxtDescripcion.Text))
			{
				MessageBox.Show("Ingrese el nombre del perfil", "Agregar Perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Perfil perfil = new Perfil();
			perfil.Nombre = TxtDescripcion.Text;
			perfil.PermisoPadreId = 1; // nodo raiz

			TreeNode selectedNode = TvwPerfilesPermisos.SelectedNode;

			if(selectedNode != null)
			{
				PermisoComponent permisoComponent = (PermisoComponent)selectedNode.Tag;
				perfil.PermisoPadreId = permisoComponent.Id;
			}

			int f = perfilPermisoManager.AgregarPerfil(perfil);

			if(f == -1)
				MessageBox.Show("Ocurrió un error. Vuelva a intentar más tarde", "Gestión Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
				CargarTreeView();
		}

		private void BtnCancelar_Click(object sender, EventArgs e)
		{
			//TreeNode node = GetRootParentNode();
			//if(node == null)
			//{
			//	//while(node.Parent != null)
			//	//{
			//	//	node = node.Parent;
			//	//}
			//	//MessageBox.Show(node.Text);
			//	MessageBox.Show("nodo raiz");
			//}
			//else
			//	MessageBox.Show(GetRootParentNode(node).Text);

			TvwPerfilesPermisos.SelectedNode = null;
			LstPerfiles.ClearSelected();
			LstPermisos.ClearSelected();
			TxtDescripcion.Clear();
		}

		private TreeNode GetRootParentNode()
		{
			TreeNode node = TvwPerfilesPermisos.SelectedNode;

			if(node != null)
			{
				if(node.Parent == null)
					return null;
				else
					return GetRootParentNode(node);
			}
			return null;
		}

		private TreeNode GetRootParentNode(TreeNode node)
		{
			if(node.Parent == null)
				return node;
			return GetRootParentNode(node.Parent);
		}

		//private bool IsNodeParent()
		//{
		//	TreeNode node = TvwPerfilesPermisos.SelectedNode;

		//	if(node != null)
		//	{
		//		if(node.Parent == null)
		//			return false;
		//		else
		//			return IsNodeParent(node);
		//	}
		//	return false;
		//}

		//private bool IsNodeParent(TreeNode node)
		//{
		//	if(node.Parent == null)
		//		return false;
		//	else if(node)
		//	return GetRootParentNode(node.Parent);
		//}

		private void BtnAgregarPermiso_Click(object sender, EventArgs e)
		{
			TreeNode selectedNode = TvwPerfilesPermisos.SelectedNode;

			if(selectedNode == null)
			{
				MessageBox.Show("Seleccione un perfil", "Agregar Permiso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Permiso permiso = (Permiso)LstPermisos.SelectedItem;

			if(permiso == null)
			{
				MessageBox.Show("Seleccione un permiso", "Agregar Permiso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			PermisoPermiso permisoPermiso = new PermisoPermiso();
			permisoPermiso.PermisoId = permiso.Id;
			PermisoComponent permisoComponent = (PermisoComponent)selectedNode.Tag;
			permisoPermiso.PermisoPadreId = permisoComponent.Id;

			int f = perfilPermisoManager.AgregarPermisoPermiso(permisoPermiso);

			if(f == -1)
				MessageBox.Show("Ocurrió un error. Vuelva a intentar más tarde", "Gestión Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
				CargarTreeView();

		}

		private void BtnAgregarPerfil_Click(object sender, EventArgs e)
		{
			TreeNode selectedNode = TvwPerfilesPermisos.SelectedNode;

			if(selectedNode == null)
			{
				MessageBox.Show("Seleccione un perfil", "Agregar Perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			PermisoComponent permisoComponent = (PermisoComponent)selectedNode.Tag;
			if(!(permisoComponent is Perfil))
			{
				MessageBox.Show("Seleccione un perfil", "Agregar Perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Perfil perfil = (Perfil)LstPerfiles.SelectedItem;

			if(perfil == null)
			{
				MessageBox.Show("Seleccione un perfil", "Agregar Perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if(perfil.Id == permisoComponent.Id)
			{
				MessageBox.Show("Seleccione otro perfil", "Agregar Perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if(perfil.Id == permisoComponent.Id)
			{
				MessageBox.Show("Seleccione otro perfil", "Agregar Perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			PermisoPermiso permisoPermiso = new PermisoPermiso();
			permisoPermiso.PermisoId = perfil.Id;
			permisoPermiso.PermisoPadreId = permisoComponent.Id;

			int f = perfilPermisoManager.AgregarPermisoPermiso(permisoPermiso);

			if(f == -1)
				MessageBox.Show("Ocurrió un error. Vuelva a intentar más tarde", "Gestión Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
				CargarTreeView();

		}

		private void BtnEditar_Click(object sender, EventArgs e)
		{
			TreeNode node = TvwPerfilesPermisos.SelectedNode;
			if(node == null)
			{
				MessageBox.Show("Seleccione un perfil", "Editar Perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Perfil perfil = (Perfil)node.Tag;
			perfil.Nombre = TxtDescripcion.Text;
			int f = perfilPermisoManager.EditarPerfil(perfil);
			if(f == -1)
				MessageBox.Show("Ocurrió un error. Vuelva a intentar más tarde", "Gestión Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
				CargarTreeView();
		}

		private void BtnEliminar_Click(object sender, EventArgs e)
		{
			TreeNode node = TvwPerfilesPermisos.SelectedNode;
			if(node == null)
			{
				MessageBox.Show("Seleccione un perfil", "Editar Perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Perfil perfil = (Perfil)node.Tag;
			int f = perfilPermisoManager.EliminarPerfil(perfil);
			if(f == -1)
				MessageBox.Show("Ocurrió un error. Vuelva a intentar más tarde", "Gestión Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
				CargarTreeView();
		}
	}
}
