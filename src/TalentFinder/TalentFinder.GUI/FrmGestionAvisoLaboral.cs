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
	public partial class FrmGestionAvisoLaboral : Form
	{
		public FrmGestionAvisoLaboral()
		{
			InitializeComponent();
		}

		private void SetGrilla()
		{
			DgvAvisosLaborales.Columns.Add("FechaVigenciaDisplay", "Fecha");
			DgvAvisosLaborales.Columns["FechaVigenciaDisplay"].Width = 150;
			DgvAvisosLaborales.Columns["FechaVigenciaDisplay"].DataPropertyName = "FechaVigenciaDisplay";

			DgvAvisosLaborales.Columns.Add("Titulo", "Título");
			DgvAvisosLaborales.Columns["Titulo"].Width = 200;
			DgvAvisosLaborales.Columns["Titulo"].DataPropertyName = "Titulo";

			DgvAvisosLaborales.Columns.Add("Descripcion", "Descripción");
			DgvAvisosLaborales.Columns["Descripcion"].Width = 800;
			DgvAvisosLaborales.Columns["Descripcion"].DataPropertyName = "Descripcion";

			DgvAvisosLaborales.Columns.Add("LugarTrabajo", "Lugar");
			DgvAvisosLaborales.Columns["LugarTrabajo"].Width = 150;
			DgvAvisosLaborales.Columns["LugarTrabajo"].DataPropertyName = "LugarTrabajo";

			DgvAvisosLaborales.AllowUserToAddRows = false;
			DgvAvisosLaborales.RowHeadersVisible = false;
			DgvAvisosLaborales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			DgvAvisosLaborales.MultiSelect = false;
			DgvAvisosLaborales.AutoGenerateColumns = false;
			DgvAvisosLaborales.EditMode = DataGridViewEditMode.EditProgrammatically;
			//DgvAvisosLaborales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			DgvAvisosLaborales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			DgvAvisosLaborales.RowTemplate.Height = 30;
		}

		private void CargarTecnologias()
		{
			try
			{
				ChkListTecnologias.DataSource = SistemaManager.TecnologiaManager.GetAllTecnologias();
			}
			catch(Exception ex)
			{
				ChkListTecnologias.DataSource = null;
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = SistemaManager.ListaTipoEvento.FirstOrDefault(x => x.Id == (int)TiposEventos.ERROR);
				bitacora.Descripcion = string.Format("FrmGestionAvisoLaboral-CargarTecnologias: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void CargarAvisosLaborales()
		{
			try
			{
				DgvAvisosLaborales.DataSource = null;
				DgvAvisosLaborales.DataSource = SistemaManager.AvisoLaboralManager.GetAvisos(string.Empty, string.Empty, string.Empty);
				DgvAvisosLaborales.ClearSelection();
			}
			catch(Exception ex)
			{
				ChkListTecnologias.DataSource = null;
				Bitacora bitacora = new Bitacora();
				bitacora.FechaCreacion = DateTime.Now;
				bitacora.Usuario = SistemaManager.SessionManager.UsuarioLogueado;
				bitacora.TipoEvento = SistemaManager.ListaTipoEvento.FirstOrDefault(x => x.Id == (int)TiposEventos.ERROR);
				bitacora.Descripcion = string.Format("FrmGestionPostulaciones-CargarAvisos: {0} {1} {2} {3}", ex.Source, ex.Message, ex.InnerException, ex.StackTrace);
				SistemaManager.BitacoraManager.RegistrarEntradaJson(bitacora);
				MessageBox.Show("Ocurrió un error interno. Vuelva a intentar más tarde", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private string GetTecnologiasId()
		{
			string separador = "", ids = "";
			foreach(int indexChecked in ChkListTecnologias.CheckedIndices)
			{
				if(ChkListTecnologias.GetItemCheckState(indexChecked) == CheckState.Checked)
				{
					Tecnologia t = (Tecnologia)ChkListTecnologias.Items[indexChecked];
					ids += separador + t.Id;
					separador = ",";
				}
			}
			return ids;
		}

		private void FrmGestionAvisoLaboral_Load(object sender, EventArgs e)
		{
			SetGrilla();
			CargarTecnologias();
			CargarAvisosLaborales();
		}
	}
}
