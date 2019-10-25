using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalentFinder.BLL;
using TalentFinder.BE;

namespace TalentFinder.GUI
{
	public partial class FrmExamenRealizarProgama : Form
	{
		private ProgramRunner ProgramRunner = new ProgramRunner();
		public FrmExamenRealizarProgama()
		{
			InitializeComponent();
		}

		private void BtnEjecutarCodigo_Click(object sender, EventArgs e)
		{
			Parser Parser = new Parser();
			MessageBox.Show(Parser.GetCodigoPrograma("", TxtCodigoPrograma.Text));

			//ResultadoEjecucion ResultadoEjecucion = ProgramRunner.EjecutarPrograma(TxtCodigoPrograma.Text);
			//if(ResultadoEjecucion.ResultadoEjecucionEstado == ResultadoEjecucionEstado.ERROR)
			//	MessageBox.Show("El programa no compila. Corrija los errores", "Creación Programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//else
			//	MessageBox.Show("El programa ejecuta correctamente", "Creación Programa", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
