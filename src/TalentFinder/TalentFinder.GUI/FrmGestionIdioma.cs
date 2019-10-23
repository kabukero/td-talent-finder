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
	public partial class FrmGestionIdioma : Form
	{
		private IList<Label> labels;
		private IList<TextBox> textboxes;
		private const string PrefijoNameTextBox = "Txt";
		private const string PrefijoNameLabel = "Lbl";
		private const int widthLabel = 500, widthTextbox = 800;
		private const int margenXLabel = 10, margenY = 0, offsetY = 40;
		private const int margenXTextbox = margenXLabel + widthLabel + 10;
		private const int posicionInicialY = 340;
		public FrmGestionIdioma()
		{
			InitializeComponent();
		}
		private void CargarIdiomas()
		{
			LstIdiomas.DataSource = null;
			LstIdiomas.DataSource = SistemaManager.IdiomaManager.GetAllIdiomas();
			LstIdiomas.ClearSelected();
		}
		public void PanelControlCargarMenuIdiomas()
		{
			FrmPanelControl frm = (FrmPanelControl)this.MdiParent;
			frm.CargarMenuIdiomas();
		}
		private void EliminarControles()
		{
			if(labels == null || textboxes == null)
				return;

			foreach(Label l in labels)
			{
				this.Controls.Remove(l);
			}

			foreach(TextBox t in textboxes)
			{
				this.Controls.Remove(t);
			}
		}
		private void CargarControles(IList<IdiomaFrase> idiomasFrases)
		{
			IList<Label> labels = CrearLabels(idiomasFrases);
			IList<TextBox> textboxes = CrearTextBoxes(idiomasFrases);
			foreach(Label l in labels)
				this.Controls.Add(l);
			foreach(TextBox t in textboxes)
				this.Controls.Add(t);
		}
		private IList<Label> CrearLabels(IList<IdiomaFrase> idiomasFrases)
		{
			labels = new List<Label>();
			int posicionYLabel = posicionInicialY;

			foreach(IdiomaFrase idiomaFrase in idiomasFrases)
			{
				Label lbl = new Label();
				lbl.Name = PrefijoNameLabel + idiomaFrase.Tag;
				lbl.Text = idiomaFrase.Tag;
				lbl.Width = widthLabel;
				lbl.Location = new System.Drawing.Point(margenXLabel, posicionYLabel);
				labels.Add(lbl);
				posicionYLabel += offsetY;
			}
			return labels;
		}
		private bool ValidarNombreIdioma()
		{
			if(string.IsNullOrEmpty(TxtIdioma.Text))
			{
				MessageBox.Show("Ingrese el nombre del idioma", "Idioma", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}
		private IList<TextBox> CrearTextBoxes(IList<IdiomaFrase> idiomasFrases)
		{
			int posicionYTextbox = posicionInicialY;
			textboxes = new List<TextBox>();

			foreach(IdiomaFrase idiomaFrase in idiomasFrases)
			{
				TextBox txt = new TextBox();
				txt.Name = PrefijoNameTextBox + idiomaFrase.Tag;
				txt.Text = idiomaFrase.Traduccion;
				txt.Width = widthTextbox;
				txt.Tag = idiomaFrase;
				txt.Location = new System.Drawing.Point(margenXTextbox, posicionYTextbox);
				textboxes.Add(txt);
				posicionYTextbox += offsetY;
			}
			return textboxes;
		}
		private void LimpiarForm()
		{
			TxtIdioma.Clear();
			LstIdiomas.ClearSelected();
			BtnGuardarTraducciones.Enabled = false;
			EliminarControles();
		}
		private bool ValidarIdiomaSeleccion()
		{
			Idioma idioma = (Idioma)LstIdiomas.SelectedItem;
			if(idioma == null)
			{
				MessageBox.Show("Seleccione un idioma", "Idioma", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}
		private bool ValidarTraducciones()
		{
			bool r = true;
			foreach(TextBox t in textboxes)
			{
				if(string.IsNullOrEmpty(t.Text))
				{
					MessageBox.Show("Ingrese todas las traducciones", "Idioma", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					r = false;
					break;
				}
			}
			return r;
		}
		private void BtnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				if(!ValidarNombreIdioma())
					return;
				SistemaManager.IdiomaManager.AgregarIdioma(SistemaManager.IdiomaManager.NewIdioma(nombre: TxtIdioma.Text));
				CargarIdiomas();
				MessageBox.Show("El idioma se agregó correctamente", "Idioma - Traducciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch
			{
				MessageBox.Show("Ocurrió un error. Vuelva intentar más tarde", "Idioma - Traducciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			LimpiarForm();
		}
		private void BtnEditar_Click(object sender, EventArgs e)
		{
			try
			{
				if(!ValidarNombreIdioma())
					return;
				if(!ValidarIdiomaSeleccion())
					return;
				Idioma idiomaSeleccionado = (Idioma)LstIdiomas.SelectedItem;
				idiomaSeleccionado.Nombre = TxtIdioma.Text;
				SistemaManager.IdiomaManager.EditarIdioma(idiomaSeleccionado);
				CargarIdiomas();
				PanelControlCargarMenuIdiomas();
				MessageBox.Show("El idioma se editó correctamente", "Idioma - Traducciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch
			{
				MessageBox.Show("Ocurrió un error. Vuelva intentar más tarde", "Idioma - Traducciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			LimpiarForm();
		}
		private void BtnEliminar_Click(object sender, EventArgs e)
		{
			try
			{
				if(!ValidarIdiomaSeleccion())
					return;
				SistemaManager.IdiomaManager.EliminarIdioma((Idioma)LstIdiomas.SelectedItem);
				CargarIdiomas();
				PanelControlCargarMenuIdiomas();
				MessageBox.Show("El idioma se eliminó correctamente", "Idioma - Traducciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch
			{
				MessageBox.Show("Ocurrió un error. Vuelva intentar más tarde", "Idioma - Traducciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			LimpiarForm();
		}
		private void BtnGuardarTraducciones_Click(object sender, EventArgs e)
		{
			try
			{
				if(!ValidarIdiomaSeleccion())
					return;
				if(!ValidarTraducciones())
					return;
				IList<IdiomaFrase> idiomaFrases = new List<IdiomaFrase>();
				foreach(TextBox t in textboxes)
				{
					IdiomaFrase i = (IdiomaFrase)t.Tag;
					i.Traduccion = t.Text;
					idiomaFrases.Add(i);
				}
				SistemaManager.IdiomaManager.GuardarTraducciones(idiomaFrases);
				PanelControlCargarMenuIdiomas();
				MessageBox.Show("Las traducciones se guardaron correctamente", "Idioma - Traducciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch
			{
				MessageBox.Show("Ocurrió un error. Vuelva intentar más tarde", "Idioma - Traducciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			LimpiarForm();
		}
		private void BtnCancelar_Click(object sender, EventArgs e)
		{
			LimpiarForm();
		}
		private void LstIdiomas_MouseClick(object sender, MouseEventArgs e)
		{
			Idioma idioma = (Idioma)LstIdiomas.SelectedItem;
			if(idioma == null)
				return;
			EliminarControles();
			CargarControles(idioma.Traducciones);
			LblCantidadTags.Text = idioma.Traducciones.Count.ToString();
			BtnGuardarTraducciones.Enabled = true;
		}
		private void FrmGestionIdioma_Load(object sender, EventArgs e)
		{
			CargarIdiomas();
		}
	}
}
