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
	public partial class FrmGestionPerfilesPermisos : Form
	{
		public FrmGestionPerfilesPermisos()
		{
			InitializeComponent();
		}
		private void CargarLstPermisos()
		{
			LstPermisos.DataSource = null;
			LstPermisos.DataSource = SistemaManager.PerfilPermisoManager.GetAllPermisos();
			LstPermisos.ClearSelected();
		}
		private void CargarLstPerfiles()
		{
			LstPerfiles.DataSource = null;
			LstPerfiles.DataSource = SistemaManager.PerfilPermisoManager.GetAllPerfiles();
			LstPerfiles.ClearSelected();
		}
		private void CargarTreeView()
		{
			SetTreeView();
			TvwPerfilesPermisos.Nodes.Clear();
			CargarNodos(SistemaManager.PerfilPermisoManager.GetAllPerfilesPermisos(), null);
			TvwPerfilesPermisos.ExpandAll();
		}
		private void SetTreeView()
		{
			TvwPerfilesPermisos.HideSelection = false;
			TvwPerfilesPermisos.DrawMode = TreeViewDrawMode.OwnerDrawText;

			TvwPerfilesPermisos.DrawNode += (o, e) =>
			{
				if(e.Node == e.Node.TreeView.SelectedNode)
				{
					Font font = e.Node.NodeFont ?? e.Node.TreeView.Font;
					Rectangle r = e.Bounds;
					r.Offset(0, 1);
					Brush brush = e.Node.TreeView.Focused ? SystemBrushes.Highlight : Brushes.Gray;
					e.Graphics.FillRectangle(brush, e.Bounds);
					TextRenderer.DrawText(e.Graphics, e.Node.Text, font, r, SystemColors.HighlightText, TextFormatFlags.GlyphOverhangPadding);
				}
				else
					e.DrawDefault = true;
			};

			TvwPerfilesPermisos.MouseDown += (o, e) =>
			{
				TreeNode node = TvwPerfilesPermisos.GetNodeAt(e.Location);
				if(node != null && node.Bounds.Contains(e.Location)) TvwPerfilesPermisos.SelectedNode = node;
			};
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
		private TreeNode FindNodeFromNodeToRoot(TreeNode node, PermisoComponent permisoComponentToAdd)
		{
			if(node == null)
				return null;

			PermisoComponent permisoComponent = (PermisoComponent)node.Tag;
			if(permisoComponent.Id == permisoComponentToAdd.Id)
				return node;
			else if(node.Parent == null)
				return null;
			else
				return FindNodeFromNodeToRoot(node.Parent, permisoComponentToAdd);
		}
		private void FindNodeFromNodeToChild(TreeNode selectedNode, PermisoComponent permisoComponentToAdd, ref TreeNode targetNode)
		{
			foreach(TreeNode node in selectedNode.Nodes)
			{
				PermisoComponent permisoComponent = (PermisoComponent)node.Tag;
				if(permisoComponent.Id == permisoComponentToAdd.Id)
				{
					targetNode = node;
					return;
				}
				FindNodeFromNodeToChild(node, permisoComponentToAdd, ref targetNode);
			}
		}
		public void AddChildren(List<TreeNode> Nodes, TreeNode Node)
		{
			foreach(TreeNode thisNode in Node.Nodes)
			{
				Nodes.Add(thisNode);
				AddChildren(Nodes, thisNode);
			}
		}
		private void ClearForm()
		{
			BtnCrear.Enabled = true;
			BtnEditar.Enabled = true;
			BtnQuitar.Enabled = true;
			BtnEliminar.Enabled = true;
			TxtDescripcion.Enabled = true;
			TvwPerfilesPermisos.SelectedNode = null;
			LstPerfiles.ClearSelected();
			LstPermisos.ClearSelected();
			TxtDescripcion.Clear();
		}
		private void EnableDisableFieldsForm(bool enable)
		{
			TxtDescripcion.Enabled = enable;
			BtnCrear.Enabled = enable;
			BtnEditar.Enabled = enable;
			BtnEliminar.Enabled = enable;
		}
		private void FillForm()
		{
			TreeNode selectedNode = TvwPerfilesPermisos.SelectedNode;
			if(selectedNode == null)
			{
				TxtDescripcion.Clear();
				return;
			}
			PermisoComponent permisoComponent = (PermisoComponent)selectedNode.Tag;
			if(permisoComponent is Perfil)
				EnableDisableFieldsForm(true);
			else
				EnableDisableFieldsForm(false);
			TxtDescripcion.Text = permisoComponent.Nombre;
		}
		private void InitFormControls()
		{
			this.Tag = new Frase() { Tag = "gestion_perfiles_permisos" };
			LblPerfilesPermisos.Tag = new Frase() { Tag = "perfiles_permisos" };
			LblPerfiles.Tag = new Frase() { Tag = "perfiles" };
			LblPermisos.Tag = new Frase() { Tag = "permisos" };
			gbPerfil.Tag = new Frase() { Tag = "perfil" };
			LblDescripcion.Tag = new Frase() { Tag = "descripcion" };
			BtnCrear.Tag = new Frase() { Tag = "crear" };
			BtnEditar.Tag = new Frase() { Tag = "editar" };
			BtnQuitar.Tag = new Frase() { Tag = "quitar" };
			BtnEliminar.Tag = new Frase() { Tag = "eliminar" };
			BtnCancelar.Tag = new Frase() { Tag = "cancelar" };
			LblDescripcion.Tag = new Frase() { Tag = "descripcion" };
			BtnAgregarPerfil.Tag = new Frase() { Tag = "agregar_perfil_a_perfil" };
			BtnAgregarPermiso.Tag = new Frase() { Tag = "agregar_permiso_a_perfil" };
		}
		private void FrmGestionPerfilesPermisos_Load(object sender, EventArgs e)
		{
			CargarTreeView();
			CargarLstPermisos();
			CargarLstPerfiles();

			// iniciar controles de formulario
			InitFormControls();

			// suscribir a evento
			IdiomaSubject.CambiarIdioma += IdiomaSubject.CambiarTextoControlFormSegunIdioma;
			IdiomaSubject.Attach(this);

			// disparar evento
			IdiomaSubject.CambiarIdiomaControlesFormulario(this, SistemaManager.Idioma);
		}
		private void FrmGestionPerfilesPermisos_Shown(object sender, EventArgs e)
		{
			TvwPerfilesPermisos.SelectedNode = null;
			ClearForm();
		}
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

			PermisoComponent permisoComponent = (PermisoComponent)selectedNode.Tag;
			if(!(permisoComponent is Perfil))
			{
				MessageBox.Show("No puede agregar un permiso a un permiso. Seleccione un perfil", "Agregar Perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			TreeNode targetNode = null;
			FindNodeFromNodeToChild(selectedNode, permiso, ref targetNode);
			if(targetNode != null)
			{
				TreeNode targetNodeParent = targetNode.Parent;
				if(targetNodeParent != null)
				{
					PermisoComponent PermisoComponentParent = (PermisoComponent)targetNodeParent.Tag;
					if(permisoComponent.Id == PermisoComponentParent.Id)
					{
						MessageBox.Show("El permiso ya esta cargado. Seleccione otro permiso", "Agregar Permiso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
				}
			}

			PermisoPermiso permisoPermiso = new PermisoPermiso();
			permisoPermiso.PermisoId = permiso.Id;
			permisoPermiso.PermisoPadreId = permisoComponent.Id;

			int f = SistemaManager.PerfilPermisoManager.AgregarPermisoPermiso(permisoPermiso);

			if(f == -1)
				MessageBox.Show("Ocurrió un error. Vuelva a intentar más tarde", "Gestión Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error);
			CargarTreeView();
			ClearForm();
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
				MessageBox.Show("No puede agregar un perfil a un permiso. Seleccione un perfil", "Agregar Perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if(perfil.Id == permisoComponent.Id)
			{
				MessageBox.Show("No puede agregar el mismo perfil. Seleccione otro perfil", "Agregar Perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if(FindNodeFromNodeToRoot(selectedNode, perfil) != null)
			{
				MessageBox.Show("El perfil ya es padre. Seleccione otro perfil", "Agregar Perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			TreeNode targetNode = null;
			FindNodeFromNodeToChild(selectedNode, perfil, ref targetNode);
			if(targetNode != null)
			{
				TreeNode targetNodeParent = targetNode.Parent;
				if(targetNodeParent != null)
				{
					PermisoComponent PermisoComponentParent = (PermisoComponent)targetNodeParent.Tag;
					if(permisoComponent.Id == PermisoComponentParent.Id)
					{
						MessageBox.Show("El perfil ya esta cargado. Seleccione otro perfil", "Agregar Perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
				}
			}

			PermisoPermiso permisoPermiso = new PermisoPermiso();
			permisoPermiso.PermisoId = perfil.Id;
			permisoPermiso.PermisoPadreId = permisoComponent.Id;

			int f = SistemaManager.PerfilPermisoManager.AgregarPermisoPermiso(permisoPermiso);

			if(f == -1)
				MessageBox.Show("Ocurrió un error. Vuelva a intentar más tarde", "Gestión Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error);
			CargarTreeView();
			ClearForm();
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
			perfil.PermisoPadreId = (int)Permisos.ROOT; // nodo raiz

			TreeNode selectedNode = TvwPerfilesPermisos.SelectedNode;

			if(selectedNode != null)
			{
				PermisoComponent permisoComponent = (PermisoComponent)selectedNode.Tag;
				if(!(permisoComponent is Perfil))
				{
					MessageBox.Show("No puede agregar un perfil a un permiso. Seleccione un perfil", "Agregar Perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				perfil.PermisoPadreId = permisoComponent.Id;
			}

			int f = SistemaManager.PerfilPermisoManager.AgregarPerfil(perfil);

			if(f == -1)
				MessageBox.Show("Ocurrió un error. Vuelva a intentar más tarde", "Gestión Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error);
			CargarTreeView();
			CargarLstPerfiles();
			ClearForm();
		}
		private void BtnEditar_Click(object sender, EventArgs e)
		{
			TreeNode selectedNode = TvwPerfilesPermisos.SelectedNode;
			if(selectedNode == null)
			{
				MessageBox.Show("Seleccione un perfil", "Editar Perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			PermisoComponent permisoComponent = (PermisoComponent)selectedNode.Tag;
			if(!(permisoComponent is Perfil))
			{
				MessageBox.Show("Seleccione un perfil", "Editar Perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;

			}

			Perfil perfil = (Perfil)selectedNode.Tag;
			perfil.Nombre = TxtDescripcion.Text;
			int f = SistemaManager.PerfilPermisoManager.EditarPerfil(perfil);
			if(f == -1)
				MessageBox.Show("Ocurrió un error. Vuelva a intentar más tarde", "Gestión Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error);
			CargarTreeView();
			CargarLstPerfiles();
			ClearForm();
		}
		private void BtnQuitar_Click(object sender, EventArgs e)
		{
			TreeNode selectedNode = TvwPerfilesPermisos.SelectedNode;
			if(selectedNode == null)
			{
				MessageBox.Show("Seleccione un perfil o permiso", "Quitar Perfil / Permiso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			List<TreeNode> Nodes = new List<TreeNode>();
			Nodes.Add(selectedNode);
			AddChildren(Nodes, selectedNode);
			List<PermisoPermiso> permisoPermisos = new List<PermisoPermiso>();

			foreach(TreeNode node in Nodes)
			{
				PermisoComponent permisoComponent = (PermisoComponent)node.Tag;
				PermisoPermiso permisoPermiso = new PermisoPermiso();
				permisoPermiso.PermisoId = permisoComponent.Id;
				permisoPermiso.PermisoPadreId = permisoComponent.PermisoPadreId;
				permisoPermisos.Add(permisoPermiso);
			}

			int f = SistemaManager.PerfilPermisoManager.QuitarPermisoPermisos(permisoPermisos);
			if(f == -1)
				MessageBox.Show("Ocurrió un error. Vuelva a intentar más tarde", "Gestión Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error);
			CargarTreeView();
			CargarLstPerfiles();
			ClearForm();
		}
		private void BtnEliminar_Click(object sender, EventArgs e)
		{
			TreeNode selectedNode = TvwPerfilesPermisos.SelectedNode;
			if(selectedNode == null)
			{
				MessageBox.Show("Seleccione un perfil", "Eliminar Perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if(selectedNode.Nodes != null && selectedNode.Nodes.Count > 0)
			{
				MessageBox.Show("No puede eliminar el perfil ya que tiene otros perfiles y permisos asociados", "Eliminar Perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			PermisoComponent permisoComponent = (PermisoComponent)selectedNode.Tag;
			if(!(permisoComponent is Perfil))
			{
				MessageBox.Show("Seleccione un perfil", "Editar Perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Perfil perfil = (Perfil)selectedNode.Tag;
			int f = SistemaManager.PerfilPermisoManager.EliminarPerfil(perfil);
			if(f == -1)
				MessageBox.Show("Ocurrió un error. Vuelva a intentar más tarde", "Gestión Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error);
			CargarTreeView();
			CargarLstPerfiles();
			ClearForm();
		}
		private void BtnCancelar_Click(object sender, EventArgs e)
		{
			ClearForm();
		}
		private void TvwPerfilesPermisos_AfterSelect(object sender, TreeViewEventArgs e)
		{
			FillForm();
		}
		private void FrmGestionPerfilesPermisos_FormClosing(object sender, FormClosingEventArgs e)
		{
			IdiomaSubject.Detach(this);
		}
	}
}
