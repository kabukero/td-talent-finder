
namespace TalentFinder.GUI
{
	partial class FrmGestionAvisoLaboral
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gbAvisoLaboral = new System.Windows.Forms.GroupBox();
			this.TxtRazonSocial = new System.Windows.Forms.TextBox();
			this.LblTitulo = new System.Windows.Forms.Label();
			this.LblDescripcion = new System.Windows.Forms.Label();
			this.TxtDescripcion = new System.Windows.Forms.TextBox();
			this.ChkListTecnologias = new System.Windows.Forms.CheckedListBox();
			this.LblTecnologias = new System.Windows.Forms.Label();
			this.BtnEliminar = new System.Windows.Forms.Button();
			this.BtnEditar = new System.Windows.Forms.Button();
			this.BtnAgregar = new System.Windows.Forms.Button();
			this.DgvAvisosLaborales = new System.Windows.Forms.DataGridView();
			this.gbAvisoLaboral.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgvAvisosLaborales)).BeginInit();
			this.SuspendLayout();
			// 
			// gbAvisoLaboral
			// 
			this.gbAvisoLaboral.Controls.Add(this.BtnEliminar);
			this.gbAvisoLaboral.Controls.Add(this.BtnEditar);
			this.gbAvisoLaboral.Controls.Add(this.BtnAgregar);
			this.gbAvisoLaboral.Controls.Add(this.LblTecnologias);
			this.gbAvisoLaboral.Controls.Add(this.ChkListTecnologias);
			this.gbAvisoLaboral.Controls.Add(this.TxtDescripcion);
			this.gbAvisoLaboral.Controls.Add(this.LblDescripcion);
			this.gbAvisoLaboral.Controls.Add(this.TxtRazonSocial);
			this.gbAvisoLaboral.Controls.Add(this.LblTitulo);
			this.gbAvisoLaboral.Location = new System.Drawing.Point(15, 15);
			this.gbAvisoLaboral.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.gbAvisoLaboral.Name = "gbAvisoLaboral";
			this.gbAvisoLaboral.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.gbAvisoLaboral.Size = new System.Drawing.Size(1222, 382);
			this.gbAvisoLaboral.TabIndex = 0;
			this.gbAvisoLaboral.TabStop = false;
			this.gbAvisoLaboral.Text = "Aviso Laboral";
			// 
			// TxtRazonSocial
			// 
			this.TxtRazonSocial.Location = new System.Drawing.Point(12, 65);
			this.TxtRazonSocial.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.TxtRazonSocial.Name = "TxtRazonSocial";
			this.TxtRazonSocial.Size = new System.Drawing.Size(620, 29);
			this.TxtRazonSocial.TabIndex = 0;
			// 
			// LblTitulo
			// 
			this.LblTitulo.AutoSize = true;
			this.LblTitulo.Location = new System.Drawing.Point(12, 35);
			this.LblTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.LblTitulo.Name = "LblTitulo";
			this.LblTitulo.Size = new System.Drawing.Size(56, 24);
			this.LblTitulo.TabIndex = 2;
			this.LblTitulo.Text = "Título";
			// 
			// LblDescripcion
			// 
			this.LblDescripcion.AutoSize = true;
			this.LblDescripcion.Location = new System.Drawing.Point(637, 35);
			this.LblDescripcion.Name = "LblDescripcion";
			this.LblDescripcion.Size = new System.Drawing.Size(110, 24);
			this.LblDescripcion.TabIndex = 3;
			this.LblDescripcion.Text = "Descripción";
			// 
			// TxtDescripcion
			// 
			this.TxtDescripcion.Location = new System.Drawing.Point(641, 62);
			this.TxtDescripcion.Multiline = true;
			this.TxtDescripcion.Name = "TxtDescripcion";
			this.TxtDescripcion.Size = new System.Drawing.Size(572, 276);
			this.TxtDescripcion.TabIndex = 4;
			// 
			// ChkListTecnologias
			// 
			this.ChkListTecnologias.FormattingEnabled = true;
			this.ChkListTecnologias.Location = new System.Drawing.Point(12, 142);
			this.ChkListTecnologias.Name = "ChkListTecnologias";
			this.ChkListTecnologias.Size = new System.Drawing.Size(620, 196);
			this.ChkListTecnologias.TabIndex = 10;
			// 
			// LblTecnologias
			// 
			this.LblTecnologias.AutoSize = true;
			this.LblTecnologias.Location = new System.Drawing.Point(15, 108);
			this.LblTecnologias.Name = "LblTecnologias";
			this.LblTecnologias.Size = new System.Drawing.Size(114, 24);
			this.LblTecnologias.TabIndex = 11;
			this.LblTecnologias.Text = "Tecnologías";
			// 
			// BtnEliminar
			// 
			this.BtnEliminar.Location = new System.Drawing.Point(719, 342);
			this.BtnEliminar.Name = "BtnEliminar";
			this.BtnEliminar.Size = new System.Drawing.Size(140, 34);
			this.BtnEliminar.TabIndex = 14;
			this.BtnEliminar.Text = "Eliminar";
			this.BtnEliminar.UseVisualStyleBackColor = true;
			// 
			// BtnEditar
			// 
			this.BtnEditar.Location = new System.Drawing.Point(559, 342);
			this.BtnEditar.Name = "BtnEditar";
			this.BtnEditar.Size = new System.Drawing.Size(140, 34);
			this.BtnEditar.TabIndex = 13;
			this.BtnEditar.Text = "Editar";
			this.BtnEditar.UseVisualStyleBackColor = true;
			// 
			// BtnAgregar
			// 
			this.BtnAgregar.Location = new System.Drawing.Point(395, 342);
			this.BtnAgregar.Name = "BtnAgregar";
			this.BtnAgregar.Size = new System.Drawing.Size(140, 34);
			this.BtnAgregar.TabIndex = 12;
			this.BtnAgregar.Text = "Agregar";
			this.BtnAgregar.UseVisualStyleBackColor = true;
			// 
			// DgvAvisosLaborales
			// 
			this.DgvAvisosLaborales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvAvisosLaborales.Location = new System.Drawing.Point(15, 407);
			this.DgvAvisosLaborales.Name = "DgvAvisosLaborales";
			this.DgvAvisosLaborales.Size = new System.Drawing.Size(1222, 399);
			this.DgvAvisosLaborales.TabIndex = 1;
			// 
			// FrmGestionAvisoLaboral
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1252, 818);
			this.Controls.Add(this.DgvAvisosLaborales);
			this.Controls.Add(this.gbAvisoLaboral);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "FrmGestionAvisoLaboral";
			this.Text = "Gestión Avisos Laborales";
			this.Load += new System.EventHandler(this.FrmGestionAvisoLaboral_Load);
			this.gbAvisoLaboral.ResumeLayout(false);
			this.gbAvisoLaboral.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgvAvisosLaborales)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbAvisoLaboral;
		private System.Windows.Forms.TextBox TxtRazonSocial;
		private System.Windows.Forms.Label LblTitulo;
		private System.Windows.Forms.TextBox TxtDescripcion;
		private System.Windows.Forms.Label LblDescripcion;
		private System.Windows.Forms.Label LblTecnologias;
		private System.Windows.Forms.CheckedListBox ChkListTecnologias;
		private System.Windows.Forms.Button BtnEliminar;
		private System.Windows.Forms.Button BtnEditar;
		private System.Windows.Forms.Button BtnAgregar;
		private System.Windows.Forms.DataGridView DgvAvisosLaborales;
	}
}