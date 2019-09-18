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

namespace TalentFinder.GUI
{
	public partial class FrmGestionBackup : Form
	{
		private string PathBackupFile;
		public FrmGestionBackup()
		{
			InitializeComponent();
		}

		private void BtnRealizarBackup_Click(object sender, EventArgs e)
		{
			//if(string.IsNullOrEmpty(PathBackupFile))
			//{
			//	MessageBox.Show("Selecione la carpeta destino del backup", "Gestión Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//	return;
			//}
			BackupManager backupManager = new BackupManager();
			Backup backup = new Backup();
			if(string.IsNullOrEmpty(PathBackupFile))
				backup.PathBackupFile = ConfigurationManager.AppSettings["PathBackupFile"].ToString();
			else
				backup.PathBackupFile = PathBackupFile;

			int f = backupManager.RelizarBackup(backup);

			if(f == 1)
			{
				MessageBox.Show("El backup se realizó correctamente", "Gestión Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Vuelva a intentar más tarde", "Gestión Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			PathBackupFile = string.Empty;
			LblCarpetaDestinoBackup.Text = "Carpeta destino backup: ";
		}

		private void BtnSeleccionarCarpeta_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderDlg = new FolderBrowserDialog();
			folderDlg.ShowNewFolderButton = true;
			DialogResult result = folderDlg.ShowDialog();
			if(result == DialogResult.OK)
			{
				PathBackupFile = folderDlg.SelectedPath;
				LblCarpetaDestinoBackup.Text = "Carpeta destino backup: " + PathBackupFile;
			}
		}

		private void FrmGestionBackup_Load(object sender, EventArgs e)
		{
			LblCarpetaDestinoBackup.Text = "Carpeta destino backup: " + ConfigurationManager.AppSettings["PathBackupFile"].ToString();
		}
	}
}
