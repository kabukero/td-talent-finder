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
	public static class IdiomaSubject
	{
		public delegate void CambiarIdiomaEventHandler(Control parent, Idioma idioma);
		public static event CambiarIdiomaEventHandler CambiarIdioma;
		public static List<Control> Controls;

		static IdiomaSubject()
		{
			Controls = new List<Control>();
		}

		public static void Attach(Control control)
		{
			Controls.Add(control);
		}

		public static void Detach(Control control)
		{
			Controls.Remove(control);
		}

		public static void Notify(Idioma idioma)
		{
			foreach(Control control in Controls)
			{
				CambiarIdiomaControlesFormulario(control, idioma);
			}
		}

		public static void CambiarIdiomaControlesFormulario(Control control, Idioma idioma)
		{
			if(CambiarIdioma != null)
			{
				CambiarIdioma(control, idioma);
				SistemaManager.Idioma = idioma;
			}
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
