namespace TalentFinder.GUI
{
	partial class FrmGestionIdioma
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
			this.GbGestionIdiomas = new System.Windows.Forms.GroupBox();
			this.LstIdiomas = new System.Windows.Forms.ListBox();
			this.BtnCancelar = new System.Windows.Forms.Button();
			this.BtnEliminar = new System.Windows.Forms.Button();
			this.BtnEditar = new System.Windows.Forms.Button();
			this.BtnGuardar = new System.Windows.Forms.Button();
			this.TxtIdioma = new System.Windows.Forms.TextBox();
			this.LblIdioma = new System.Windows.Forms.Label();
			this.LblTraducciones = new System.Windows.Forms.Label();
			this.BtnGuardarTraducciones = new System.Windows.Forms.Button();
			this.LblCantidadTags = new System.Windows.Forms.Label();
			this.GbGestionIdiomas.SuspendLayout();
			this.SuspendLayout();
			// 
			// GbGestionIdiomas
			// 
			this.GbGestionIdiomas.Controls.Add(this.LstIdiomas);
			this.GbGestionIdiomas.Controls.Add(this.BtnCancelar);
			this.GbGestionIdiomas.Controls.Add(this.BtnEliminar);
			this.GbGestionIdiomas.Controls.Add(this.BtnEditar);
			this.GbGestionIdiomas.Controls.Add(this.BtnGuardar);
			this.GbGestionIdiomas.Controls.Add(this.TxtIdioma);
			this.GbGestionIdiomas.Controls.Add(this.LblIdioma);
			this.GbGestionIdiomas.Location = new System.Drawing.Point(13, 13);
			this.GbGestionIdiomas.Name = "GbGestionIdiomas";
			this.GbGestionIdiomas.Size = new System.Drawing.Size(809, 260);
			this.GbGestionIdiomas.TabIndex = 0;
			this.GbGestionIdiomas.TabStop = false;
			this.GbGestionIdiomas.Text = "Gestión Idiomas";
			// 
			// LstIdiomas
			// 
			this.LstIdiomas.FormattingEnabled = true;
			this.LstIdiomas.ItemHeight = 24;
			this.LstIdiomas.Location = new System.Drawing.Point(16, 76);
			this.LstIdiomas.Name = "LstIdiomas";
			this.LstIdiomas.Size = new System.Drawing.Size(781, 172);
			this.LstIdiomas.TabIndex = 6;
			this.LstIdiomas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LstIdiomas_MouseClick);
			// 
			// BtnCancelar
			// 
			this.BtnCancelar.Location = new System.Drawing.Point(697, 32);
			this.BtnCancelar.Name = "BtnCancelar";
			this.BtnCancelar.Size = new System.Drawing.Size(100, 36);
			this.BtnCancelar.TabIndex = 5;
			this.BtnCancelar.Text = "Cancelar";
			this.BtnCancelar.UseVisualStyleBackColor = true;
			this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
			// 
			// BtnEliminar
			// 
			this.BtnEliminar.Location = new System.Drawing.Point(589, 32);
			this.BtnEliminar.Name = "BtnEliminar";
			this.BtnEliminar.Size = new System.Drawing.Size(100, 36);
			this.BtnEliminar.TabIndex = 4;
			this.BtnEliminar.Text = "Eliminar";
			this.BtnEliminar.UseVisualStyleBackColor = true;
			this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
			// 
			// BtnEditar
			// 
			this.BtnEditar.Location = new System.Drawing.Point(483, 32);
			this.BtnEditar.Name = "BtnEditar";
			this.BtnEditar.Size = new System.Drawing.Size(100, 36);
			this.BtnEditar.TabIndex = 3;
			this.BtnEditar.Text = "Editar";
			this.BtnEditar.UseVisualStyleBackColor = true;
			this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
			// 
			// BtnGuardar
			// 
			this.BtnGuardar.Location = new System.Drawing.Point(377, 32);
			this.BtnGuardar.Name = "BtnGuardar";
			this.BtnGuardar.Size = new System.Drawing.Size(100, 36);
			this.BtnGuardar.TabIndex = 2;
			this.BtnGuardar.Text = "Agregar";
			this.BtnGuardar.UseVisualStyleBackColor = true;
			this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
			// 
			// TxtIdioma
			// 
			this.TxtIdioma.Location = new System.Drawing.Point(98, 36);
			this.TxtIdioma.Name = "TxtIdioma";
			this.TxtIdioma.Size = new System.Drawing.Size(260, 29);
			this.TxtIdioma.TabIndex = 1;
			// 
			// LblIdioma
			// 
			this.LblIdioma.AutoSize = true;
			this.LblIdioma.Location = new System.Drawing.Point(13, 39);
			this.LblIdioma.Name = "LblIdioma";
			this.LblIdioma.Size = new System.Drawing.Size(66, 24);
			this.LblIdioma.TabIndex = 0;
			this.LblIdioma.Text = "Idioma";
			// 
			// LblTraducciones
			// 
			this.LblTraducciones.AutoSize = true;
			this.LblTraducciones.Location = new System.Drawing.Point(13, 289);
			this.LblTraducciones.Name = "LblTraducciones";
			this.LblTraducciones.Size = new System.Drawing.Size(195, 24);
			this.LblTraducciones.TabIndex = 1;
			this.LblTraducciones.Text = "Gestión Traducciones";
			// 
			// BtnGuardarTraducciones
			// 
			this.BtnGuardarTraducciones.Location = new System.Drawing.Point(321, 283);
			this.BtnGuardarTraducciones.Name = "BtnGuardarTraducciones";
			this.BtnGuardarTraducciones.Size = new System.Drawing.Size(241, 36);
			this.BtnGuardarTraducciones.TabIndex = 3;
			this.BtnGuardarTraducciones.Text = "Guardar Traducciones";
			this.BtnGuardarTraducciones.UseVisualStyleBackColor = true;
			this.BtnGuardarTraducciones.Click += new System.EventHandler(this.BtnGuardarTraducciones_Click);
			// 
			// LblCantidadTags
			// 
			this.LblCantidadTags.AutoSize = true;
			this.LblCantidadTags.Location = new System.Drawing.Point(227, 289);
			this.LblCantidadTags.Name = "LblCantidadTags";
			this.LblCantidadTags.Size = new System.Drawing.Size(62, 24);
			this.LblCantidadTags.TabIndex = 4;
			this.LblCantidadTags.Text = "#Tags";
			// 
			// FrmGestionIdioma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(969, 749);
			this.Controls.Add(this.LblCantidadTags);
			this.Controls.Add(this.BtnGuardarTraducciones);
			this.Controls.Add(this.LblTraducciones);
			this.Controls.Add(this.GbGestionIdiomas);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FrmGestionIdioma";
			this.Text = "Gestión Idiomas";
			this.Load += new System.EventHandler(this.FrmGestionIdioma_Load);
			this.GbGestionIdiomas.ResumeLayout(false);
			this.GbGestionIdiomas.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox GbGestionIdiomas;
		private System.Windows.Forms.Label LblIdioma;
		private System.Windows.Forms.TextBox TxtIdioma;
		private System.Windows.Forms.Button BtnCancelar;
		private System.Windows.Forms.Button BtnEliminar;
		private System.Windows.Forms.Button BtnEditar;
		private System.Windows.Forms.Button BtnGuardar;
		private System.Windows.Forms.ListBox LstIdiomas;
		private System.Windows.Forms.Label LblTraducciones;
		private System.Windows.Forms.Button BtnGuardarTraducciones;
		private System.Windows.Forms.Label LblCantidadTags;
	}
}