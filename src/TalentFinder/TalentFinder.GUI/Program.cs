using System;
using System.Windows.Forms;
using TalentFinder.Seguridad;

namespace TalentFinder.GUI
{
	static class Program
	{
		public static SessionManager usuarioSesion;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmLogin());
		}
	}
}
