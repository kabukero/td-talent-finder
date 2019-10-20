using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalentFinder.BE;
using TalentFinder.BLL;

namespace TalentFinder.GUI.Helpers
{
	public class GUIHelper
	{
		public static void CargarMenuIdiomas(ToolStripDropDownButton ToolStripDropDownButton, IList<Idioma> idiomas)
		{
			List<ToolStripItem> lista = new List<ToolStripItem>();
			foreach(Idioma idioma in idiomas)
			{
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
				toolStripMenuItem.Name = idioma.Nombre + "ToolStripMenuItem";
				toolStripMenuItem.Size = new System.Drawing.Size(180, 22);
				toolStripMenuItem.Text = idioma.Nombre;
				toolStripMenuItem.Tag = idioma;
				toolStripMenuItem.Click += new EventHandler(ToolStripDropDownButton_Click);
				lista.Add(toolStripMenuItem);
			}
			ToolStripDropDownButton.DropDownItems.Clear();
			ToolStripDropDownButton.DropDownItems.AddRange(lista.ToArray());
		}

		public static void ToolStripDropDownButton_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
			Idioma idioma = (Idioma)toolStripMenuItem.Tag;
			SistemaManager.SessionManager.IdiomaSession.IdiomaSelected = idioma;
		}

		public static void CambiarTextoControlFormSegunIdioma(Control parentControl, Idioma idioma)
		{
			if(!string.IsNullOrEmpty(parentControl.Text) && parentControl.Tag != null)
				CambiarTextoControlForm(parentControl, idioma);

			foreach(Control control in parentControl.Controls)
			{
				if(control.GetType() == typeof(Label) || control.GetType() == typeof(Button) || control.GetType() == typeof(GroupBox) && !string.IsNullOrEmpty(control.Text) && control.Tag != null)
					CambiarTextoControlForm(control, idioma);

				if(control.GetType() == typeof(GroupBox))
					CambiarTextoControlFormSegunIdioma(control, idioma);
			}
		}

		public static void CambiarTextoControlForm(Control control, Idioma idioma)
		{
			Frase frase = (Frase)control.Tag;
			if(frase != null && !string.IsNullOrEmpty(frase.Tag))
			{
				IdiomaFrase IdiomaFrase = SistemaManager.IdiomaManager.GetTraduccion(idioma, frase);
				if(IdiomaFrase != null && !string.IsNullOrEmpty(IdiomaFrase.Traduccion))
					control.Text = IdiomaFrase.Traduccion;
			}
		}
	}
}
