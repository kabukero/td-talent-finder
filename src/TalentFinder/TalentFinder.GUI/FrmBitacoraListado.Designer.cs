namespace TalentFinder.GUI
{
	partial class FrmBitacoraListado
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
			this.GbBuscador = new System.Windows.Forms.GroupBox();
			this.CmbUsuario = new System.Windows.Forms.ComboBox();
			this.LblUsuario = new System.Windows.Forms.Label();
			this.BtnCancelar = new System.Windows.Forms.Button();
			this.BtnBuscar = new System.Windows.Forms.Button();
			this.DtpFechaHasta = new System.Windows.Forms.DateTimePicker();
			this.LblFechaHasta = new System.Windows.Forms.Label();
			this.DtpFechaDesde = new System.Windows.Forms.DateTimePicker();
			this.LblFechaDesde = new System.Windows.Forms.Label();
			this.CmbTipoEvento = new System.Windows.Forms.ComboBox();
			this.LblTipoEvento = new System.Windows.Forms.Label();
			this.DgvListado = new System.Windows.Forms.DataGridView();
			this.GbBuscador.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
			this.SuspendLayout();
			// 
			// GbBuscador
			// 
			this.GbBuscador.Controls.Add(this.CmbUsuario);
			this.GbBuscador.Controls.Add(this.LblUsuario);
			this.GbBuscador.Controls.Add(this.BtnCancelar);
			this.GbBuscador.Controls.Add(this.BtnBuscar);
			this.GbBuscador.Controls.Add(this.DtpFechaHasta);
			this.GbBuscador.Controls.Add(this.LblFechaHasta);
			this.GbBuscador.Controls.Add(this.DtpFechaDesde);
			this.GbBuscador.Controls.Add(this.LblFechaDesde);
			this.GbBuscador.Controls.Add(this.CmbTipoEvento);
			this.GbBuscador.Controls.Add(this.LblTipoEvento);
			this.GbBuscador.Location = new System.Drawing.Point(13, 5);
			this.GbBuscador.Name = "GbBuscador";
			this.GbBuscador.Size = new System.Drawing.Size(1177, 113);
			this.GbBuscador.TabIndex = 0;
			this.GbBuscador.TabStop = false;
			this.GbBuscador.Text = "Bitácora Eventos - Buscador";
			// 
			// CmbUsuario
			// 
			this.CmbUsuario.FormattingEnabled = true;
			this.CmbUsuario.Location = new System.Drawing.Point(105, 29);
			this.CmbUsuario.Name = "CmbUsuario";
			this.CmbUsuario.Size = new System.Drawing.Size(174, 32);
			this.CmbUsuario.TabIndex = 9;
			// 
			// LblUsuario
			// 
			this.LblUsuario.AutoSize = true;
			this.LblUsuario.Location = new System.Drawing.Point(13, 34);
			this.LblUsuario.Name = "LblUsuario";
			this.LblUsuario.Size = new System.Drawing.Size(74, 24);
			this.LblUsuario.TabIndex = 8;
			this.LblUsuario.Text = "Usuario";
			// 
			// BtnCancelar
			// 
			this.BtnCancelar.Location = new System.Drawing.Point(592, 69);
			this.BtnCancelar.Name = "BtnCancelar";
			this.BtnCancelar.Size = new System.Drawing.Size(108, 39);
			this.BtnCancelar.TabIndex = 7;
			this.BtnCancelar.Text = "Cancelar";
			this.BtnCancelar.UseVisualStyleBackColor = true;
			this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
			// 
			// BtnBuscar
			// 
			this.BtnBuscar.Location = new System.Drawing.Point(474, 69);
			this.BtnBuscar.Name = "BtnBuscar";
			this.BtnBuscar.Size = new System.Drawing.Size(108, 39);
			this.BtnBuscar.TabIndex = 6;
			this.BtnBuscar.Text = "Buscar";
			this.BtnBuscar.UseVisualStyleBackColor = true;
			this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
			// 
			// DtpFechaHasta
			// 
			this.DtpFechaHasta.Location = new System.Drawing.Point(971, 31);
			this.DtpFechaHasta.Name = "DtpFechaHasta";
			this.DtpFechaHasta.Size = new System.Drawing.Size(200, 29);
			this.DtpFechaHasta.TabIndex = 5;
			// 
			// LblFechaHasta
			// 
			this.LblFechaHasta.AutoSize = true;
			this.LblFechaHasta.Location = new System.Drawing.Point(896, 36);
			this.LblFechaHasta.Name = "LblFechaHasta";
			this.LblFechaHasta.Size = new System.Drawing.Size(57, 24);
			this.LblFechaHasta.TabIndex = 4;
			this.LblFechaHasta.Text = "Hasta";
			// 
			// DtpFechaDesde
			// 
			this.DtpFechaDesde.Location = new System.Drawing.Point(680, 32);
			this.DtpFechaDesde.Name = "DtpFechaDesde";
			this.DtpFechaDesde.Size = new System.Drawing.Size(200, 29);
			this.DtpFechaDesde.TabIndex = 3;
			// 
			// LblFechaDesde
			// 
			this.LblFechaDesde.AutoSize = true;
			this.LblFechaDesde.Location = new System.Drawing.Point(601, 35);
			this.LblFechaDesde.Name = "LblFechaDesde";
			this.LblFechaDesde.Size = new System.Drawing.Size(65, 24);
			this.LblFechaDesde.TabIndex = 2;
			this.LblFechaDesde.Text = "Desde";
			// 
			// CmbTipoEvento
			// 
			this.CmbTipoEvento.FormattingEnabled = true;
			this.CmbTipoEvento.Location = new System.Drawing.Point(416, 29);
			this.CmbTipoEvento.Name = "CmbTipoEvento";
			this.CmbTipoEvento.Size = new System.Drawing.Size(174, 32);
			this.CmbTipoEvento.TabIndex = 1;
			// 
			// LblTipoEvento
			// 
			this.LblTipoEvento.AutoSize = true;
			this.LblTipoEvento.Location = new System.Drawing.Point(296, 33);
			this.LblTipoEvento.Name = "LblTipoEvento";
			this.LblTipoEvento.Size = new System.Drawing.Size(112, 24);
			this.LblTipoEvento.TabIndex = 0;
			this.LblTipoEvento.Text = "Tipo Evento";
			// 
			// DgvListado
			// 
			this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvListado.Location = new System.Drawing.Point(13, 124);
			this.DgvListado.Name = "DgvListado";
			this.DgvListado.Size = new System.Drawing.Size(1177, 416);
			this.DgvListado.TabIndex = 1;
			// 
			// FrmBitacoraListado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1202, 543);
			this.Controls.Add(this.DgvListado);
			this.Controls.Add(this.GbBuscador);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FrmBitacoraListado";
			this.Text = "Bitacora Eventos";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBitacoraListado_FormClosing);
			this.Load += new System.EventHandler(this.FrmBitacoraListado_Load);
			this.GbBuscador.ResumeLayout(false);
			this.GbBuscador.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox GbBuscador;
		private System.Windows.Forms.Label LblTipoEvento;
		private System.Windows.Forms.ComboBox CmbTipoEvento;
		private System.Windows.Forms.DateTimePicker DtpFechaHasta;
		private System.Windows.Forms.Label LblFechaHasta;
		private System.Windows.Forms.DateTimePicker DtpFechaDesde;
		private System.Windows.Forms.Label LblFechaDesde;
		private System.Windows.Forms.Button BtnCancelar;
		private System.Windows.Forms.Button BtnBuscar;
		private System.Windows.Forms.DataGridView DgvListado;
		private System.Windows.Forms.ComboBox CmbUsuario;
		private System.Windows.Forms.Label LblUsuario;
	}
}