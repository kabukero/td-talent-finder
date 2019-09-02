using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalentFinder.GUI
{
	public partial class FrmRegistrarse : Form
	{
		public FrmRegistrarse()
		{
			InitializeComponent();
		}

		private void BtnCancelar_Click(object sender, EventArgs e)
		{
			FrmLogin frm = new FrmLogin();
			frm.Show();
			this.Hide();
		}
	}
}
