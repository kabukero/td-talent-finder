namespace TalentFinder.GUI
{
	partial class FrmGestionUsuariosPerfilesPermisos
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
			this.TvwPerfilesPermisos = new System.Windows.Forms.TreeView();
			this.LblTitulo = new System.Windows.Forms.Label();
			this.LstUsuarios = new System.Windows.Forms.ListBox();
			this.BtnGuardar = new System.Windows.Forms.Button();
			this.BtnSalir = new System.Windows.Forms.Button();
			this.LblUsuarios = new System.Windows.Forms.Label();
			this.LblPerfilesPermisos = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TvwPerfilesPermisos
			// 
			this.TvwPerfilesPermisos.Location = new System.Drawing.Point(320, 82);
			this.TvwPerfilesPermisos.Name = "TvwPerfilesPermisos";
			this.TvwPerfilesPermisos.Size = new System.Drawing.Size(653, 388);
			this.TvwPerfilesPermisos.TabIndex = 0;
			// 
			// LblTitulo
			// 
			this.LblTitulo.AutoSize = true;
			this.LblTitulo.Location = new System.Drawing.Point(17, 8);
			this.LblTitulo.Name = "LblTitulo";
			this.LblTitulo.Size = new System.Drawing.Size(365, 24);
			this.LblTitulo.TabIndex = 1;
			this.LblTitulo.Text = "Gestión de perfiles y permisos de usuarios";
			// 
			// LstUsuarios
			// 
			this.LstUsuarios.FormattingEnabled = true;
			this.LstUsuarios.ItemHeight = 24;
			this.LstUsuarios.Location = new System.Drawing.Point(16, 82);
			this.LstUsuarios.Name = "LstUsuarios";
			this.LstUsuarios.Size = new System.Drawing.Size(298, 388);
			this.LstUsuarios.TabIndex = 2;
			this.LstUsuarios.Click += new System.EventHandler(this.LstUsuarios_Click);
			// 
			// BtnGuardar
			// 
			this.BtnGuardar.Location = new System.Drawing.Point(389, 485);
			this.BtnGuardar.Name = "BtnGuardar";
			this.BtnGuardar.Size = new System.Drawing.Size(94, 48);
			this.BtnGuardar.TabIndex = 3;
			this.BtnGuardar.Text = "Guardar";
			this.BtnGuardar.UseVisualStyleBackColor = true;
			this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
			// 
			// BtnSalir
			// 
			this.BtnSalir.Location = new System.Drawing.Point(489, 485);
			this.BtnSalir.Name = "BtnSalir";
			this.BtnSalir.Size = new System.Drawing.Size(94, 48);
			this.BtnSalir.TabIndex = 4;
			this.BtnSalir.Text = "Salir";
			this.BtnSalir.UseVisualStyleBackColor = true;
			this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
			// 
			// LblUsuarios
			// 
			this.LblUsuarios.AutoSize = true;
			this.LblUsuarios.Location = new System.Drawing.Point(19, 49);
			this.LblUsuarios.Name = "LblUsuarios";
			this.LblUsuarios.Size = new System.Drawing.Size(83, 24);
			this.LblUsuarios.TabIndex = 5;
			this.LblUsuarios.Text = "Usuarios";
			// 
			// LblPerfilesPermisos
			// 
			this.LblPerfilesPermisos.AutoSize = true;
			this.LblPerfilesPermisos.Location = new System.Drawing.Point(323, 49);
			this.LblPerfilesPermisos.Name = "LblPerfilesPermisos";
			this.LblPerfilesPermisos.Size = new System.Drawing.Size(165, 24);
			this.LblPerfilesPermisos.TabIndex = 6;
			this.LblPerfilesPermisos.Text = "Perfiles - Permisos";
			// 
			// FrmGestionUsuariosPerfilesPermisos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(982, 549);
			this.Controls.Add(this.LblPerfilesPermisos);
			this.Controls.Add(this.LblUsuarios);
			this.Controls.Add(this.BtnSalir);
			this.Controls.Add(this.BtnGuardar);
			this.Controls.Add(this.LstUsuarios);
			this.Controls.Add(this.LblTitulo);
			this.Controls.Add(this.TvwPerfilesPermisos);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FrmGestionUsuariosPerfilesPermisos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gestión Perfiles Permisos Usuarios";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGestionUsuariosPerfilesPermisos_FormClosing);
			this.Load += new System.EventHandler(this.FrmUsuarioPerfilPermiso_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView TvwPerfilesPermisos;
		private System.Windows.Forms.Label LblTitulo;
		private System.Windows.Forms.ListBox LstUsuarios;
		private System.Windows.Forms.Button BtnGuardar;
		private System.Windows.Forms.Button BtnSalir;
		private System.Windows.Forms.Label LblUsuarios;
		private System.Windows.Forms.Label LblPerfilesPermisos;
	}
}