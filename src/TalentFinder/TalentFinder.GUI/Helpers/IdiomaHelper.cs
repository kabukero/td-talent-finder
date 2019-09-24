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
	public class IdiomaHelper
	{
		public delegate void CambiarIdiomaEventHandler(Control parent, Idioma idioma);
		public event CambiarIdiomaEventHandler CambiarIdioma;

		public void CambiarIdiomaControlesFormulario(Control control, Idioma idioma)
		{
			if(this.CambiarIdioma != null)
				this.CambiarIdioma(control, idioma);
		}

		public void CambiarTextoControlFormSegunIdioma(Control parentControl, Idioma idioma)
		{
			if(!string.IsNullOrEmpty(parentControl.Text) && parentControl.Tag != null)
				CambiarTextoControlForm(parentControl, idioma);

			foreach(Control control in parentControl.Controls)
			{
				if(control.GetType() == typeof(Label) || control.GetType() == typeof(Button) || control.GetType() == typeof(GroupBox) && !string.IsNullOrEmpty(control.Text) && control.Tag != null)
					CambiarTextoControlForm(control, idioma);
					//MessageBox.Show(control.Name);

				if(control.GetType() == typeof(GroupBox))
					CambiarTextoControlFormSegunIdioma(control, idioma);
			}
		}

		private void CambiarTextoControlForm(Control control, Idioma idioma)
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
