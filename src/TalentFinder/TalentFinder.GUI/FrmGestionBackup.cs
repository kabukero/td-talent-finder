using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
	public partial class FrmGestionBackup : Form
	{
		BackupManager backupManager = new BackupManager();
		private string PathBackupFile;
		private string PathRestoreFile;
		public FrmGestionBackup()
		{
			InitializeComponent();
		}
		private void InitFormControls()
		{
			this.Tag = new Frase() { Tag = "gestion_backup" };
			LblTitulo.Tag = new Frase() { Tag = "seleccione_dir_destino_bkp" };
			BtnSeleccionarCarpeta.Tag = new Frase() { Tag = "seleccione_carpeta" };
			BtnSeleccionarArchivo.Tag = new Frase() { Tag = "seleccione_archivo" };
			BtnRealizarBackup.Tag = new Frase() { Tag = "realizar_backup" };
			BtnRealizarRestore.Tag = new Frase() { Tag = "realizar_restore" };
		}
		private void BtnRealizarRestore_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(PathRestoreFile))
			{
				MessageBox.Show("Debe seleccionar un archivo para realizar el restore de la base de datos", "Gestión Restore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Backup backup = new Backup();
			backup.PathBackupFile = PathRestoreFile;
			int f = backupManager.RelizarRestore(backup);

			if(f == 1)
			{
				SistemaManager.BitacoraManager.RegistrarEntrada(SistemaManager.SessionManager.UsuarioLogueado, new TipoEvento() { Id = (int)TiposEventos.INFORMACION }, string.Format("Se realizó un restore de la DB en el siguiente directorio: {0} ", backup.PathBackupFile));
				MessageBox.Show("El restore de la DB se realizó correctamente", "Gestión Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				SistemaManager.BitacoraManager.RegistrarEntrada(SistemaManager.SessionManager.UsuarioLogueado, new TipoEvento() { Id = (int)TiposEventos.ERROR }, string.Format("Ocurrió un error al intentar realizar un restore de la DB en el siguiente directorio: {0} ", backup.PathBackupFile));
				MessageBox.Show("Vuelva a intentar más tarde", "Gestión Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			PathRestoreFile = string.Empty;
			//LblCarpetaDestinoBackup.Text = "Carpeta destino backup: ";
		}
		private void BtnRealizarBackup_Click(object sender, EventArgs e)
		{
			Backup backup = new Backup();
			if(string.IsNullOrEmpty(PathBackupFile))
				backup.PathBackupFile = ConfigurationManager.AppSettings["PathBackupFile"].ToString();
			else
				backup.PathBackupFile = PathBackupFile;

			int f = backupManager.RelizarBackup(backup);

			if(f == 1)
			{
				SistemaManager.BitacoraManager.RegistrarEntrada(SistemaManager.SessionManager.UsuarioLogueado, new TipoEvento() { Id = (int)TiposEventos.INFORMACION }, string.Format("Se realizó un backup de la DB en el siguiente directorio: {0} ", backup.PathBackupFile));
				MessageBox.Show("El backup de la DB se realizó correctamente", "Gestión Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				SistemaManager.BitacoraManager.RegistrarEntrada(SistemaManager.SessionManager.UsuarioLogueado, new TipoEvento() { Id = (int)TiposEventos.ERROR }, string.Format("Ocurrió un error al intentar realizar un backup de la DB en el siguiente directorio: {0} ", backup.PathBackupFile));
				MessageBox.Show("Vuelva a intentar más tarde", "Gestión Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			PathBackupFile = string.Empty;
			//LblCarpetaDestinoBackup.Text = "Carpeta destino backup: ";
		}
		private void BtnSeleccionarCarpeta_Click(object sender, EventArgs e)
		{
			//FolderBrowserDialog folderDlg = new FolderBrowserDialog();
			//folderDlg.ShowNewFolderButton = true;
			//DialogResult result = folderDlg.ShowDialog();

			OpenFileDialog fileDlg = new OpenFileDialog();
			fileDlg.DefaultExt = "bak";
			//fileDlg.Filter = "bak files (*.bak)|*.txt|All files (*.*)|*.*";
			fileDlg.CheckFileExists = true;
			fileDlg.CheckPathExists = true;
			DialogResult result = fileDlg.ShowDialog();
			if(result == DialogResult.OK)
			{
				PathRestoreFile = fileDlg.FileName;
				//PathBackupFile = folderDlg.SelectedPath;
				//LblCarpetaDestinoBackup.Text = "Carpeta destino backup: " + PathBackupFile;
			}
		}
		private void FrmGestionBackup_Load(object sender, EventArgs e)
		{
			// iniciar controles de formulario
			InitFormControls();

			// suscribir a evento
			IdiomaSubject.CambiarIdioma += IdiomaSubject.CambiarTextoControlFormSegunIdioma;
			IdiomaSubject.Attach(this);

			// disparar evento
			IdiomaSubject.CambiarIdiomaControlesFormulario(this, SistemaManager.Idioma);
		}
		private void FrmGestionBackup_FormClosing(object sender, FormClosingEventArgs e)
		{
			IdiomaSubject.Detach(this);
		}
		private void BtnSeleccionarFile_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderDlg = new FolderBrowserDialog();
			folderDlg.ShowNewFolderButton = true;
			DialogResult result = folderDlg.ShowDialog();
			if(result == DialogResult.OK)
			{
				PathBackupFile = folderDlg.SelectedPath;
				//LblCarpetaDestinoBackup.Text = "Carpeta destino backup: " + PathBackupFile;
			}
		}
	}
}
