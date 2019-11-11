namespace TalentFinder.GUI
{
	partial class FrmGestionPostulaciones
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
			this.gbBuscador = new System.Windows.Forms.GroupBox();
			this.BtnCancelar = new System.Windows.Forms.Button();
			this.ChkListTecnologias = new System.Windows.Forms.CheckedListBox();
			this.BtnRealizarEvaluacion = new System.Windows.Forms.Button();
			this.BtnAplicarAviso = new System.Windows.Forms.Button();
			this.BtnBuscarAvisos = new System.Windows.Forms.Button();
			this.TxtLugarTrabajo = new System.Windows.Forms.TextBox();
			this.LblLugarTrabajo = new System.Windows.Forms.Label();
			this.LblTecnologia = new System.Windows.Forms.Label();
			this.TxtPalabraClave = new System.Windows.Forms.TextBox();
			this.LblPalabraClave = new System.Windows.Forms.Label();
			this.DgvAvisos = new System.Windows.Forms.DataGridView();
			this.DgvPostulaciones = new System.Windows.Forms.DataGridView();
			this.LblPostulacion = new System.Windows.Forms.Label();
			this.gbBuscador.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgvAvisos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvPostulaciones)).BeginInit();
			this.SuspendLayout();
			// 
			// gbBuscador
			// 
			this.gbBuscador.Controls.Add(this.BtnCancelar);
			this.gbBuscador.Controls.Add(this.ChkListTecnologias);
			this.gbBuscador.Controls.Add(this.BtnRealizarEvaluacion);
			this.gbBuscador.Controls.Add(this.BtnAplicarAviso);
			this.gbBuscador.Controls.Add(this.BtnBuscarAvisos);
			this.gbBuscador.Controls.Add(this.TxtLugarTrabajo);
			this.gbBuscador.Controls.Add(this.LblLugarTrabajo);
			this.gbBuscador.Controls.Add(this.LblTecnologia);
			this.gbBuscador.Controls.Add(this.TxtPalabraClave);
			this.gbBuscador.Controls.Add(this.LblPalabraClave);
			this.gbBuscador.Location = new System.Drawing.Point(12, 1);
			this.gbBuscador.Name = "gbBuscador";
			this.gbBuscador.Size = new System.Drawing.Size(1128, 215);
			this.gbBuscador.TabIndex = 2;
			this.gbBuscador.TabStop = false;
			this.gbBuscador.Text = "Buscador Avisos";
			// 
			// BtnCancelar
			// 
			this.BtnCancelar.Location = new System.Drawing.Point(817, 175);
			this.BtnCancelar.Name = "BtnCancelar";
			this.BtnCancelar.Size = new System.Drawing.Size(165, 34);
			this.BtnCancelar.TabIndex = 10;
			this.BtnCancelar.Text = "Cancelar";
			this.BtnCancelar.UseVisualStyleBackColor = true;
			this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
			// 
			// ChkListTecnologias
			// 
			this.ChkListTecnologias.FormattingEnabled = true;
			this.ChkListTecnologias.Location = new System.Drawing.Point(652, 18);
			this.ChkListTecnologias.Name = "ChkListTecnologias";
			this.ChkListTecnologias.Size = new System.Drawing.Size(469, 148);
			this.ChkListTecnologias.TabIndex = 9;
			// 
			// BtnRealizarEvaluacion
			// 
			this.BtnRealizarEvaluacion.Location = new System.Drawing.Point(569, 175);
			this.BtnRealizarEvaluacion.Name = "BtnRealizarEvaluacion";
			this.BtnRealizarEvaluacion.Size = new System.Drawing.Size(242, 34);
			this.BtnRealizarEvaluacion.TabIndex = 7;
			this.BtnRealizarEvaluacion.Text = "Realizar Evaluación";
			this.BtnRealizarEvaluacion.UseVisualStyleBackColor = true;
			this.BtnRealizarEvaluacion.Click += new System.EventHandler(this.BtnRealizarEvaluacion_Click);
			// 
			// BtnAplicarAviso
			// 
			this.BtnAplicarAviso.Location = new System.Drawing.Point(341, 175);
			this.BtnAplicarAviso.Name = "BtnAplicarAviso";
			this.BtnAplicarAviso.Size = new System.Drawing.Size(222, 34);
			this.BtnAplicarAviso.TabIndex = 6;
			this.BtnAplicarAviso.Text = "Aplicar a Aviso";
			this.BtnAplicarAviso.UseVisualStyleBackColor = true;
			// 
			// BtnBuscarAvisos
			// 
			this.BtnBuscarAvisos.Location = new System.Drawing.Point(110, 175);
			this.BtnBuscarAvisos.Name = "BtnBuscarAvisos";
			this.BtnBuscarAvisos.Size = new System.Drawing.Size(206, 34);
			this.BtnBuscarAvisos.TabIndex = 5;
			this.BtnBuscarAvisos.Text = "Buscar Avisos";
			this.BtnBuscarAvisos.UseVisualStyleBackColor = true;
			this.BtnBuscarAvisos.Click += new System.EventHandler(this.BtnBuscarAvisos_Click);
			// 
			// TxtLugarTrabajo
			// 
			this.TxtLugarTrabajo.Location = new System.Drawing.Point(136, 81);
			this.TxtLugarTrabajo.Name = "TxtLugarTrabajo";
			this.TxtLugarTrabajo.Size = new System.Drawing.Size(387, 29);
			this.TxtLugarTrabajo.TabIndex = 1;
			// 
			// LblLugarTrabajo
			// 
			this.LblLugarTrabajo.AutoSize = true;
			this.LblLugarTrabajo.Location = new System.Drawing.Point(3, 84);
			this.LblLugarTrabajo.Name = "LblLugarTrabajo";
			this.LblLugarTrabajo.Size = new System.Drawing.Size(127, 24);
			this.LblLugarTrabajo.TabIndex = 2;
			this.LblLugarTrabajo.Text = "Lugar Trabajo";
			// 
			// LblTecnologia
			// 
			this.LblTecnologia.AutoSize = true;
			this.LblTecnologia.Location = new System.Drawing.Point(533, 29);
			this.LblTecnologia.Name = "LblTecnologia";
			this.LblTecnologia.Size = new System.Drawing.Size(114, 24);
			this.LblTecnologia.TabIndex = 2;
			this.LblTecnologia.Text = "Tecnologías";
			// 
			// TxtPalabraClave
			// 
			this.TxtPalabraClave.Location = new System.Drawing.Point(136, 30);
			this.TxtPalabraClave.Name = "TxtPalabraClave";
			this.TxtPalabraClave.Size = new System.Drawing.Size(387, 29);
			this.TxtPalabraClave.TabIndex = 0;
			// 
			// LblPalabraClave
			// 
			this.LblPalabraClave.AutoSize = true;
			this.LblPalabraClave.Location = new System.Drawing.Point(10, 33);
			this.LblPalabraClave.Name = "LblPalabraClave";
			this.LblPalabraClave.Size = new System.Drawing.Size(125, 24);
			this.LblPalabraClave.TabIndex = 0;
			this.LblPalabraClave.Text = "Palabra Clave";
			// 
			// DgvAvisos
			// 
			this.DgvAvisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvAvisos.Location = new System.Drawing.Point(12, 222);
			this.DgvAvisos.Name = "DgvAvisos";
			this.DgvAvisos.Size = new System.Drawing.Size(1128, 232);
			this.DgvAvisos.TabIndex = 3;
			// 
			// DgvPostulaciones
			// 
			this.DgvPostulaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvPostulaciones.Location = new System.Drawing.Point(13, 489);
			this.DgvPostulaciones.Name = "DgvPostulaciones";
			this.DgvPostulaciones.Size = new System.Drawing.Size(1128, 248);
			this.DgvPostulaciones.TabIndex = 4;
			// 
			// LblPostulacion
			// 
			this.LblPostulacion.AutoSize = true;
			this.LblPostulacion.Location = new System.Drawing.Point(15, 460);
			this.LblPostulacion.Name = "LblPostulacion";
			this.LblPostulacion.Size = new System.Drawing.Size(127, 24);
			this.LblPostulacion.TabIndex = 5;
			this.LblPostulacion.Text = "Postulaciones";
			// 
			// FrmGestionPostulaciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1153, 749);
			this.Controls.Add(this.LblPostulacion);
			this.Controls.Add(this.DgvPostulaciones);
			this.Controls.Add(this.gbBuscador);
			this.Controls.Add(this.DgvAvisos);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FrmGestionPostulaciones";
			this.Text = "FrmGestionPostulaciones";
			this.Load += new System.EventHandler(this.FrmGestionPostulaciones_Load);
			this.gbBuscador.ResumeLayout(false);
			this.gbBuscador.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgvAvisos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvPostulaciones)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbBuscador;
		private System.Windows.Forms.Button BtnRealizarEvaluacion;
		private System.Windows.Forms.Button BtnAplicarAviso;
		private System.Windows.Forms.Button BtnBuscarAvisos;
		private System.Windows.Forms.TextBox TxtLugarTrabajo;
		private System.Windows.Forms.Label LblLugarTrabajo;
		private System.Windows.Forms.Label LblTecnologia;
		private System.Windows.Forms.TextBox TxtPalabraClave;
		private System.Windows.Forms.Label LblPalabraClave;
		private System.Windows.Forms.DataGridView DgvAvisos;
		private System.Windows.Forms.CheckedListBox ChkListTecnologias;
		private System.Windows.Forms.Button BtnCancelar;
		private System.Windows.Forms.DataGridView DgvPostulaciones;
		private System.Windows.Forms.Label LblPostulacion;
	}
}