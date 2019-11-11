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
			this.LblUsuarios = new System.Windows.Forms.Label();
			this.LblPerfilesPermisos = new System.Windows.Forms.Label();
			this.GbUsuario = new System.Windows.Forms.GroupBox();
			this.BtnCancelar = new System.Windows.Forms.Button();
			this.CmbUsuarioTipo = new System.Windows.Forms.ComboBox();
			this.LblTipo = new System.Windows.Forms.Label();
			this.BtnEliminarUsuario = new System.Windows.Forms.Button();
			this.BtnEditarUsuario = new System.Windows.Forms.Button();
			this.BtnAgregarUsuario = new System.Windows.Forms.Button();
			this.TxtPassword = new System.Windows.Forms.TextBox();
			this.LblPassword = new System.Windows.Forms.Label();
			this.TxtUsuario = new System.Windows.Forms.TextBox();
			this.LblUsuario = new System.Windows.Forms.Label();
			this.BtnCancelar2 = new System.Windows.Forms.Button();
			this.GbUsuario.SuspendLayout();
			this.SuspendLayout();
			// 
			// TvwPerfilesPermisos
			// 
			this.TvwPerfilesPermisos.Location = new System.Drawing.Point(423, 213);
			this.TvwPerfilesPermisos.Name = "TvwPerfilesPermisos";
			this.TvwPerfilesPermisos.Size = new System.Drawing.Size(732, 388);
			this.TvwPerfilesPermisos.TabIndex = 0;
			// 
			// LblTitulo
			// 
			this.LblTitulo.AutoSize = true;
			this.LblTitulo.Location = new System.Drawing.Point(373, 160);
			this.LblTitulo.Name = "LblTitulo";
			this.LblTitulo.Size = new System.Drawing.Size(365, 24);
			this.LblTitulo.TabIndex = 1;
			this.LblTitulo.Text = "Gestión de perfiles y permisos de usuarios";
			// 
			// LstUsuarios
			// 
			this.LstUsuarios.FormattingEnabled = true;
			this.LstUsuarios.ItemHeight = 24;
			this.LstUsuarios.Location = new System.Drawing.Point(13, 213);
			this.LstUsuarios.Name = "LstUsuarios";
			this.LstUsuarios.Size = new System.Drawing.Size(395, 388);
			this.LstUsuarios.TabIndex = 2;
			this.LstUsuarios.Click += new System.EventHandler(this.LstUsuarios_Click);
			// 
			// BtnGuardar
			// 
			this.BtnGuardar.Location = new System.Drawing.Point(444, 607);
			this.BtnGuardar.Name = "BtnGuardar";
			this.BtnGuardar.Size = new System.Drawing.Size(94, 33);
			this.BtnGuardar.TabIndex = 3;
			this.BtnGuardar.Text = "Guardar";
			this.BtnGuardar.UseVisualStyleBackColor = true;
			this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
			// 
			// LblUsuarios
			// 
			this.LblUsuarios.AutoSize = true;
			this.LblUsuarios.Location = new System.Drawing.Point(163, 187);
			this.LblUsuarios.Name = "LblUsuarios";
			this.LblUsuarios.Size = new System.Drawing.Size(83, 24);
			this.LblUsuarios.TabIndex = 5;
			this.LblUsuarios.Text = "Usuarios";
			// 
			// LblPerfilesPermisos
			// 
			this.LblPerfilesPermisos.AutoSize = true;
			this.LblPerfilesPermisos.Location = new System.Drawing.Point(709, 187);
			this.LblPerfilesPermisos.Name = "LblPerfilesPermisos";
			this.LblPerfilesPermisos.Size = new System.Drawing.Size(165, 24);
			this.LblPerfilesPermisos.TabIndex = 6;
			this.LblPerfilesPermisos.Text = "Perfiles - Permisos";
			// 
			// GbUsuario
			// 
			this.GbUsuario.Controls.Add(this.BtnCancelar);
			this.GbUsuario.Controls.Add(this.CmbUsuarioTipo);
			this.GbUsuario.Controls.Add(this.LblTipo);
			this.GbUsuario.Controls.Add(this.BtnEliminarUsuario);
			this.GbUsuario.Controls.Add(this.BtnEditarUsuario);
			this.GbUsuario.Controls.Add(this.BtnAgregarUsuario);
			this.GbUsuario.Controls.Add(this.TxtPassword);
			this.GbUsuario.Controls.Add(this.LblPassword);
			this.GbUsuario.Controls.Add(this.TxtUsuario);
			this.GbUsuario.Controls.Add(this.LblUsuario);
			this.GbUsuario.Location = new System.Drawing.Point(12, 12);
			this.GbUsuario.Name = "GbUsuario";
			this.GbUsuario.Size = new System.Drawing.Size(1143, 145);
			this.GbUsuario.TabIndex = 7;
			this.GbUsuario.TabStop = false;
			this.GbUsuario.Text = "Gestión Usuarios";
			// 
			// BtnCancelar
			// 
			this.BtnCancelar.Location = new System.Drawing.Point(685, 87);
			this.BtnCancelar.Name = "BtnCancelar";
			this.BtnCancelar.Size = new System.Drawing.Size(94, 33);
			this.BtnCancelar.TabIndex = 13;
			this.BtnCancelar.Text = "Cancelar";
			this.BtnCancelar.UseVisualStyleBackColor = true;
			this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
			// 
			// CmbUsuarioTipo
			// 
			this.CmbUsuarioTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CmbUsuarioTipo.FormattingEnabled = true;
			this.CmbUsuarioTipo.Location = new System.Drawing.Point(766, 36);
			this.CmbUsuarioTipo.Name = "CmbUsuarioTipo";
			this.CmbUsuarioTipo.Size = new System.Drawing.Size(370, 32);
			this.CmbUsuarioTipo.TabIndex = 12;
			// 
			// LblTipo
			// 
			this.LblTipo.AutoSize = true;
			this.LblTipo.Location = new System.Drawing.Point(700, 39);
			this.LblTipo.Name = "LblTipo";
			this.LblTipo.Size = new System.Drawing.Size(48, 24);
			this.LblTipo.TabIndex = 11;
			this.LblTipo.Text = "Tipo";
			// 
			// BtnEliminarUsuario
			// 
			this.BtnEliminarUsuario.Location = new System.Drawing.Point(567, 87);
			this.BtnEliminarUsuario.Name = "BtnEliminarUsuario";
			this.BtnEliminarUsuario.Size = new System.Drawing.Size(94, 33);
			this.BtnEliminarUsuario.TabIndex = 10;
			this.BtnEliminarUsuario.Text = "Eliminar";
			this.BtnEliminarUsuario.UseVisualStyleBackColor = true;
			this.BtnEliminarUsuario.Click += new System.EventHandler(this.BtnEliminarUsuario_Click);
			// 
			// BtnEditarUsuario
			// 
			this.BtnEditarUsuario.Location = new System.Drawing.Point(457, 87);
			this.BtnEditarUsuario.Name = "BtnEditarUsuario";
			this.BtnEditarUsuario.Size = new System.Drawing.Size(94, 33);
			this.BtnEditarUsuario.TabIndex = 9;
			this.BtnEditarUsuario.Text = "Editar";
			this.BtnEditarUsuario.UseVisualStyleBackColor = true;
			this.BtnEditarUsuario.Click += new System.EventHandler(this.BtnEditarUsuario_Click);
			// 
			// BtnAgregarUsuario
			// 
			this.BtnAgregarUsuario.Location = new System.Drawing.Point(348, 87);
			this.BtnAgregarUsuario.Name = "BtnAgregarUsuario";
			this.BtnAgregarUsuario.Size = new System.Drawing.Size(94, 33);
			this.BtnAgregarUsuario.TabIndex = 8;
			this.BtnAgregarUsuario.Text = "Agregar";
			this.BtnAgregarUsuario.UseVisualStyleBackColor = true;
			this.BtnAgregarUsuario.Click += new System.EventHandler(this.BtnAgregarUsuario_Click);
			// 
			// TxtPassword
			// 
			this.TxtPassword.Location = new System.Drawing.Point(432, 37);
			this.TxtPassword.Name = "TxtPassword";
			this.TxtPassword.PasswordChar = '*';
			this.TxtPassword.Size = new System.Drawing.Size(262, 29);
			this.TxtPassword.TabIndex = 3;
			// 
			// LblPassword
			// 
			this.LblPassword.AutoSize = true;
			this.LblPassword.Location = new System.Drawing.Point(329, 40);
			this.LblPassword.Name = "LblPassword";
			this.LblPassword.Size = new System.Drawing.Size(92, 24);
			this.LblPassword.TabIndex = 2;
			this.LblPassword.Text = "Password";
			// 
			// TxtUsuario
			// 
			this.TxtUsuario.Location = new System.Drawing.Point(87, 38);
			this.TxtUsuario.Name = "TxtUsuario";
			this.TxtUsuario.Size = new System.Drawing.Size(225, 29);
			this.TxtUsuario.TabIndex = 0;
			// 
			// LblUsuario
			// 
			this.LblUsuario.AutoSize = true;
			this.LblUsuario.Location = new System.Drawing.Point(7, 41);
			this.LblUsuario.Name = "LblUsuario";
			this.LblUsuario.Size = new System.Drawing.Size(74, 24);
			this.LblUsuario.TabIndex = 0;
			this.LblUsuario.Text = "Usuario";
			// 
			// BtnCancelar2
			// 
			this.BtnCancelar2.Location = new System.Drawing.Point(554, 607);
			this.BtnCancelar2.Name = "BtnCancelar2";
			this.BtnCancelar2.Size = new System.Drawing.Size(94, 33);
			this.BtnCancelar2.TabIndex = 14;
			this.BtnCancelar2.Text = "Cancelar";
			this.BtnCancelar2.UseVisualStyleBackColor = true;
			this.BtnCancelar2.Click += new System.EventHandler(this.BtnCancelar_Click);
			// 
			// FrmGestionUsuariosPerfilesPermisos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1167, 646);
			this.Controls.Add(this.BtnCancelar2);
			this.Controls.Add(this.GbUsuario);
			this.Controls.Add(this.LblPerfilesPermisos);
			this.Controls.Add(this.LblUsuarios);
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
			this.Shown += new System.EventHandler(this.FrmGestionUsuariosPerfilesPermisos_Shown);
			this.GbUsuario.ResumeLayout(false);
			this.GbUsuario.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView TvwPerfilesPermisos;
		private System.Windows.Forms.Label LblTitulo;
		private System.Windows.Forms.ListBox LstUsuarios;
		private System.Windows.Forms.Button BtnGuardar;
		private System.Windows.Forms.Label LblUsuarios;
		private System.Windows.Forms.Label LblPerfilesPermisos;
		private System.Windows.Forms.GroupBox GbUsuario;
		private System.Windows.Forms.TextBox TxtPassword;
		private System.Windows.Forms.Label LblPassword;
		private System.Windows.Forms.TextBox TxtUsuario;
		private System.Windows.Forms.Label LblUsuario;
		private System.Windows.Forms.Label LblTipo;
		private System.Windows.Forms.Button BtnEliminarUsuario;
		private System.Windows.Forms.Button BtnEditarUsuario;
		private System.Windows.Forms.Button BtnAgregarUsuario;
		private System.Windows.Forms.ComboBox CmbUsuarioTipo;
		private System.Windows.Forms.Button BtnCancelar;
		private System.Windows.Forms.Button BtnCancelar2;
	}
}