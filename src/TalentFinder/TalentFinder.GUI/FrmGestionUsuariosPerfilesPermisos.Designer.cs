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
			this.TxtEmail = new System.Windows.Forms.TextBox();
			this.LblEmail = new System.Windows.Forms.Label();
			this.TxtApellido = new System.Windows.Forms.TextBox();
			this.LblApellido = new System.Windows.Forms.Label();
			this.TxtNombre = new System.Windows.Forms.TextBox();
			this.LblNombre = new System.Windows.Forms.Label();
			this.BtnCancelar = new System.Windows.Forms.Button();
			this.CmbEmpresa = new System.Windows.Forms.ComboBox();
			this.LblEmpresa = new System.Windows.Forms.Label();
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
			this.TvwPerfilesPermisos.Location = new System.Drawing.Point(423, 255);
			this.TvwPerfilesPermisos.Name = "TvwPerfilesPermisos";
			this.TvwPerfilesPermisos.Size = new System.Drawing.Size(732, 365);
			this.TvwPerfilesPermisos.TabIndex = 0;
			// 
			// LblTitulo
			// 
			this.LblTitulo.AutoSize = true;
			this.LblTitulo.Location = new System.Drawing.Point(382, 199);
			this.LblTitulo.Name = "LblTitulo";
			this.LblTitulo.Size = new System.Drawing.Size(365, 24);
			this.LblTitulo.TabIndex = 1;
			this.LblTitulo.Text = "Gestión de perfiles y permisos de usuarios";
			// 
			// LstUsuarios
			// 
			this.LstUsuarios.FormattingEnabled = true;
			this.LstUsuarios.ItemHeight = 24;
			this.LstUsuarios.Location = new System.Drawing.Point(13, 256);
			this.LstUsuarios.Name = "LstUsuarios";
			this.LstUsuarios.Size = new System.Drawing.Size(395, 364);
			this.LstUsuarios.TabIndex = 2;
			this.LstUsuarios.Click += new System.EventHandler(this.LstUsuarios_Click);
			// 
			// BtnGuardar
			// 
			this.BtnGuardar.Location = new System.Drawing.Point(494, 625);
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
			this.LblUsuarios.Location = new System.Drawing.Point(172, 223);
			this.LblUsuarios.Name = "LblUsuarios";
			this.LblUsuarios.Size = new System.Drawing.Size(83, 24);
			this.LblUsuarios.TabIndex = 5;
			this.LblUsuarios.Text = "Usuarios";
			// 
			// LblPerfilesPermisos
			// 
			this.LblPerfilesPermisos.AutoSize = true;
			this.LblPerfilesPermisos.Location = new System.Drawing.Point(718, 224);
			this.LblPerfilesPermisos.Name = "LblPerfilesPermisos";
			this.LblPerfilesPermisos.Size = new System.Drawing.Size(165, 24);
			this.LblPerfilesPermisos.TabIndex = 6;
			this.LblPerfilesPermisos.Text = "Perfiles - Permisos";
			// 
			// GbUsuario
			// 
			this.GbUsuario.Controls.Add(this.TxtEmail);
			this.GbUsuario.Controls.Add(this.LblEmail);
			this.GbUsuario.Controls.Add(this.TxtApellido);
			this.GbUsuario.Controls.Add(this.LblApellido);
			this.GbUsuario.Controls.Add(this.TxtNombre);
			this.GbUsuario.Controls.Add(this.LblNombre);
			this.GbUsuario.Controls.Add(this.BtnCancelar);
			this.GbUsuario.Controls.Add(this.CmbEmpresa);
			this.GbUsuario.Controls.Add(this.LblEmpresa);
			this.GbUsuario.Controls.Add(this.BtnEliminarUsuario);
			this.GbUsuario.Controls.Add(this.BtnEditarUsuario);
			this.GbUsuario.Controls.Add(this.BtnAgregarUsuario);
			this.GbUsuario.Controls.Add(this.TxtPassword);
			this.GbUsuario.Controls.Add(this.LblPassword);
			this.GbUsuario.Controls.Add(this.TxtUsuario);
			this.GbUsuario.Controls.Add(this.LblUsuario);
			this.GbUsuario.Location = new System.Drawing.Point(12, 12);
			this.GbUsuario.Name = "GbUsuario";
			this.GbUsuario.Size = new System.Drawing.Size(1143, 184);
			this.GbUsuario.TabIndex = 7;
			this.GbUsuario.TabStop = false;
			this.GbUsuario.Text = "Gestión Usuarios";
			// 
			// TxtEmail
			// 
			this.TxtEmail.Location = new System.Drawing.Point(848, 97);
			this.TxtEmail.Name = "TxtEmail";
			this.TxtEmail.Size = new System.Drawing.Size(269, 29);
			this.TxtEmail.TabIndex = 19;
			// 
			// LblEmail
			// 
			this.LblEmail.AutoSize = true;
			this.LblEmail.Location = new System.Drawing.Point(754, 103);
			this.LblEmail.Name = "LblEmail";
			this.LblEmail.Size = new System.Drawing.Size(63, 24);
			this.LblEmail.TabIndex = 18;
			this.LblEmail.Text = "E-mail";
			// 
			// TxtApellido
			// 
			this.TxtApellido.Location = new System.Drawing.Point(432, 98);
			this.TxtApellido.Name = "TxtApellido";
			this.TxtApellido.Size = new System.Drawing.Size(262, 29);
			this.TxtApellido.TabIndex = 17;
			// 
			// LblApellido
			// 
			this.LblApellido.AutoSize = true;
			this.LblApellido.Location = new System.Drawing.Point(329, 101);
			this.LblApellido.Name = "LblApellido";
			this.LblApellido.Size = new System.Drawing.Size(79, 24);
			this.LblApellido.TabIndex = 16;
			this.LblApellido.Text = "Apellido";
			// 
			// TxtNombre
			// 
			this.TxtNombre.Location = new System.Drawing.Point(87, 99);
			this.TxtNombre.Name = "TxtNombre";
			this.TxtNombre.Size = new System.Drawing.Size(225, 29);
			this.TxtNombre.TabIndex = 14;
			// 
			// LblNombre
			// 
			this.LblNombre.AutoSize = true;
			this.LblNombre.Location = new System.Drawing.Point(7, 102);
			this.LblNombre.Name = "LblNombre";
			this.LblNombre.Size = new System.Drawing.Size(79, 24);
			this.LblNombre.TabIndex = 15;
			this.LblNombre.Text = "Nombre";
			// 
			// BtnCancelar
			// 
			this.BtnCancelar.Location = new System.Drawing.Point(710, 139);
			this.BtnCancelar.Name = "BtnCancelar";
			this.BtnCancelar.Size = new System.Drawing.Size(94, 33);
			this.BtnCancelar.TabIndex = 13;
			this.BtnCancelar.Text = "Cancelar";
			this.BtnCancelar.UseVisualStyleBackColor = true;
			this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
			// 
			// CmbEmpresa
			// 
			this.CmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CmbEmpresa.FormattingEnabled = true;
			this.CmbEmpresa.Location = new System.Drawing.Point(848, 37);
			this.CmbEmpresa.Name = "CmbEmpresa";
			this.CmbEmpresa.Size = new System.Drawing.Size(269, 32);
			this.CmbEmpresa.TabIndex = 12;
			// 
			// LblEmpresa
			// 
			this.LblEmpresa.AutoSize = true;
			this.LblEmpresa.Location = new System.Drawing.Point(731, 40);
			this.LblEmpresa.Name = "LblEmpresa";
			this.LblEmpresa.Size = new System.Drawing.Size(86, 24);
			this.LblEmpresa.TabIndex = 11;
			this.LblEmpresa.Text = "Empresa";
			// 
			// BtnEliminarUsuario
			// 
			this.BtnEliminarUsuario.Location = new System.Drawing.Point(592, 139);
			this.BtnEliminarUsuario.Name = "BtnEliminarUsuario";
			this.BtnEliminarUsuario.Size = new System.Drawing.Size(94, 33);
			this.BtnEliminarUsuario.TabIndex = 10;
			this.BtnEliminarUsuario.Text = "Eliminar";
			this.BtnEliminarUsuario.UseVisualStyleBackColor = true;
			this.BtnEliminarUsuario.Click += new System.EventHandler(this.BtnEliminarUsuario_Click);
			// 
			// BtnEditarUsuario
			// 
			this.BtnEditarUsuario.Location = new System.Drawing.Point(482, 139);
			this.BtnEditarUsuario.Name = "BtnEditarUsuario";
			this.BtnEditarUsuario.Size = new System.Drawing.Size(94, 33);
			this.BtnEditarUsuario.TabIndex = 9;
			this.BtnEditarUsuario.Text = "Editar";
			this.BtnEditarUsuario.UseVisualStyleBackColor = true;
			this.BtnEditarUsuario.Click += new System.EventHandler(this.BtnEditarUsuario_Click);
			// 
			// BtnAgregarUsuario
			// 
			this.BtnAgregarUsuario.Location = new System.Drawing.Point(373, 139);
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
			this.BtnCancelar2.Location = new System.Drawing.Point(604, 625);
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
			this.ClientSize = new System.Drawing.Size(1167, 664);
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
		private System.Windows.Forms.Label LblEmpresa;
		private System.Windows.Forms.Button BtnEliminarUsuario;
		private System.Windows.Forms.Button BtnEditarUsuario;
		private System.Windows.Forms.Button BtnAgregarUsuario;
		private System.Windows.Forms.ComboBox CmbEmpresa;
		private System.Windows.Forms.Button BtnCancelar;
		private System.Windows.Forms.Button BtnCancelar2;
		private System.Windows.Forms.TextBox TxtEmail;
		private System.Windows.Forms.Label LblEmail;
		private System.Windows.Forms.TextBox TxtApellido;
		private System.Windows.Forms.Label LblApellido;
		private System.Windows.Forms.TextBox TxtNombre;
		private System.Windows.Forms.Label LblNombre;
	}
}