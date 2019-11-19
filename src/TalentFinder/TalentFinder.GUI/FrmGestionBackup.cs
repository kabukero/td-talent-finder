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
	public partial class FrmGestionBackup : Form, IIdiomaObserver
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
		public void Update(Idioma idioma)
		{
			GUIHelper.CambiarTextoControlFormSegunIdioma(this, idioma);
		}
		private void BtnRealizarRestore_Click(object sender, EventArgs e)
		{
			try
			{
				if(string.IsNullOrEmpty(PathRestoreFile))
				{
					MessageBox.Show("Debe seleccionar un archivo para realizar el restore de la base de datos", "Gestión Restore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				Backup backup = new Backup();
				backup.PathBackupFile = PathRestoreFile;
				backupManager.RelizarRestore(backup);
				SistemaManager.BitacoraManager.RegistrarEntrada(SistemaManager.SessionManager.UsuarioLogueado, new TipoEvento() { Id = (int)TiposEventos.INFORMACION }, string.Format("Se realizó un restore de la DB en el siguiente directorio: {0} ", backup.PathBackupFile));
				MessageBox.Show("El restore de la DB se realizó correctamente", "Gestión Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
				PathRestoreFile = string.Empty;
				//LblCarpetaDestinoBackup.Text = "Carpeta destino backup: ";
			}
			catch(Exception ex)
			{
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = new TipoEvento() { Id = (int)TiposEventos.ERROR };
				bitacora.Descripcion = string.Format("FrmGestionBackup_Load: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void BtnRealizarBackup_Click(object sender, EventArgs e)
		{
			try
			{
				Backup backup = new Backup();
				if(string.IsNullOrEmpty(PathBackupFile))
					backup.PathBackupFile = ConfigurationManager.AppSettings["PathBackupFile"].ToString();
				else
					backup.PathBackupFile = PathBackupFile;
				backupManager.RelizarBackup(backup);
				SistemaManager.BitacoraManager.RegistrarEntrada(SistemaManager.SessionManager.UsuarioLogueado, new TipoEvento() { Id = (int)TiposEventos.INFORMACION }, string.Format("Se realizó un backup de la DB en el siguiente directorio: {0} ", backup.PathBackupFile));
				MessageBox.Show("El backup de la DB se realizó correctamente", "Gestión Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
				PathBackupFile = string.Empty;
				//LblCarpetaDestinoBackup.Text = "Carpeta destino backup: ";
			}
			catch(Exception ex)
			{
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = new TipoEvento() { Id = (int)TiposEventos.ERROR };
				bitacora.Descripcion = string.Format("FrmGestionBackup -BtnRealizarBackup_Click: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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
		private void FrmGestionBackup_Load(object sender, EventArgs e)
		{
			try
			{
				// iniciar controles de formulario
				InitFormControls();

				// suscribir observer
				IdiomaSubject.AddObserver(this);

				// actualizar idioma
				Update(SistemaManager.SessionManager.IdiomaSession.IdiomaSelected);
			}
			catch(Exception ex)
			{
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = new TipoEvento() { Id = (int)TiposEventos.ERROR };
				bitacora.Descripcion = string.Format("FrmGestionBackup_Load: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void FrmGestionBackup_FormClosing(object sender, FormClosingEventArgs e)
		{
			IdiomaSubject.RemoveObserver(this);
		}
	}
}
