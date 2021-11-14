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
		public FrmGestionBackup()
		{
			InitializeComponent();
		}

		private void InitFormControls()
		{
			this.Tag = new Frase() { Tag = "gestion_backup" };
			LblTitulo.Tag = new Frase() { Tag = "seleccione_dir_destino_bkp" };
			BtnRealizarBackup.Tag = new Frase() { Tag = "realizar_backup" };
			BtnRealizarRestore.Tag = new Frase() { Tag = "realizar_restore" };
		}

		private void CargarBackups()
		{
			try
			{
				DgvBackups.DataSource = null;
				DgvBackups.DataSource = SistemaManager.BackupManager.GetAllBackups();
				DgvBackups.ClearSelection();
			}
			catch(Exception ex)
			{
				DgvBackups.DataSource = null;
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = SistemaManager.BitacoraManager.GetBitacoraTipoEvento((int)TiposEventos.ERROR);
				bitacora.Descripcion = string.Format("FrmGestionBackup.CargarBackups(): {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SetGrilla()
		{
			DgvBackups.Columns.Add("FechaCreacion", "Fecha Creacion");
			DgvBackups.Columns["FechaCreacion"].Width = 150;
			DgvBackups.Columns["FechaCreacion"].DataPropertyName = "FechaCreacion";

			DgvBackups.Columns.Add("NombreArchivo", "Nombre Archivo");
			DgvBackups.Columns["NombreArchivo"].Width = 250;
			DgvBackups.Columns["NombreArchivo"].DataPropertyName = "NombreArchivo";

			DgvBackups.AllowUserToAddRows = false;
			DgvBackups.RowHeadersVisible = false;
			DgvBackups.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			DgvBackups.MultiSelect = false;
			DgvBackups.AutoGenerateColumns = false;
			DgvBackups.EditMode = DataGridViewEditMode.EditProgrammatically;
			DgvBackups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			DgvBackups.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			DgvBackups.RowTemplate.Height = 30;
		}

		public void Update(Idioma idioma)
		{
			GUIHelper.CambiarTextoControlFormSegunIdioma(this, idioma);
		}

		private void BtnRealizarRestore_Click(object sender, EventArgs e)
		{
			try
			{
				Backup backup = (Backup)DgvBackups.CurrentRow.DataBoundItem;

				if(backup == null)
				{
					MessageBox.Show("Debe seleccionar un archivo para realizar el restore de la base de datos", "Gestión Restore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				SistemaManager.BackupManager.RelizarRestore(backup);
				SistemaManager.BitacoraManager.RegistrarEntrada(SistemaManager.SessionManager.UsuarioLogueado, new TipoEvento() { Id = (int)TiposEventos.INFORMACION }, string.Format("Se realizó un restore de la DB en el siguiente directorio: {0} ", backup.NombreArchivo));
				MessageBox.Show("El restore de la DB se realizó correctamente", "Gestión Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch(Exception ex)
			{
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = SistemaManager.ListaTipoEvento.FirstOrDefault(x => x.Id == (int)TiposEventos.ERROR);
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
				backup.NombreArchivo = SistemaManager.BackupManager.GetNombreArchivoBackup();
				SistemaManager.BackupManager.RelizarBackup(backup);
				SistemaManager.BitacoraManager.RegistrarEntrada(SistemaManager.SessionManager.UsuarioLogueado, new TipoEvento() { Id = (int)TiposEventos.INFORMACION }, string.Format("Se realizó un backup de la DB en el siguiente directorio: {0} ", backup.NombreArchivo));
				MessageBox.Show("El backup de la DB se realizó correctamente", "Gestión Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch(Exception ex)
			{
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = SistemaManager.ListaTipoEvento.FirstOrDefault(x => x.Id == (int)TiposEventos.ERROR);
				bitacora.Descripcion = string.Format("FrmGestionBackup -BtnRealizarBackup_Click: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				CargarBackups();
			}
		}

		private void FrmGestionBackup_Load(object sender, EventArgs e)
		{
			try
			{
				SetGrilla();
				CargarBackups();

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
				bitacora.TipoEvento = SistemaManager.ListaTipoEvento.FirstOrDefault(x => x.Id == (int)TiposEventos.ERROR);
				bitacora.Descripcion = string.Format("FrmGestionBackup_Load: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void FrmGestionBackup_FormClosing(object sender, FormClosingEventArgs e)
		{
			IdiomaSubject.RemoveObserver(this);
		}

		private void FrmGestionBackup_Shown(object sender, EventArgs e)
		{
			DgvBackups.ClearSelection();
		}
	}
}
