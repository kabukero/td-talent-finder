namespace TalentFinder.GUI
{
	partial class FrmHome
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.LblUsuarioLogueado = new System.Windows.Forms.Label();
			this.BtnCerrarSesion = new System.Windows.Forms.Button();
			this.gbArchivo = new System.Windows.Forms.GroupBox();
			this.BtnSalir = new System.Windows.Forms.Button();
			this.gbGestionPostulante = new System.Windows.Forms.GroupBox();
			this.BtnPublicarAviso = new System.Windows.Forms.Button();
			this.gbGestionPerfilProfesional = new System.Windows.Forms.GroupBox();
			this.BtnPostularseAviso = new System.Windows.Forms.Button();
			this.gbAdministracionSistema = new System.Windows.Forms.GroupBox();
			this.BtnVerBitacora = new System.Windows.Forms.Button();
			this.BtnGestionBackup = new System.Windows.Forms.Button();
			this.BtnGestionUsuarios = new System.Windows.Forms.Button();
			this.BtnGestionPerfiles = new System.Windows.Forms.Button();
			this.gbGestionEmpresa = new System.Windows.Forms.GroupBox();
			this.BtnVerListadoEmpresas = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.gbArchivo.SuspendLayout();
			this.gbGestionPostulante.SuspendLayout();
			this.gbGestionPerfilProfesional.SuspendLayout();
			this.gbAdministracionSistema.SuspendLayout();
			this.gbGestionEmpresa.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(4, 1);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(80, 80);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// LblUsuarioLogueado
			// 
			this.LblUsuarioLogueado.AutoSize = true;
			this.LblUsuarioLogueado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblUsuarioLogueado.Location = new System.Drawing.Point(92, 6);
			this.LblUsuarioLogueado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LblUsuarioLogueado.Name = "LblUsuarioLogueado";
			this.LblUsuarioLogueado.Size = new System.Drawing.Size(79, 24);
			this.LblUsuarioLogueado.TabIndex = 3;
			this.LblUsuarioLogueado.Text = "Usuario:";
			// 
			// BtnCerrarSesion
			// 
			this.BtnCerrarSesion.Location = new System.Drawing.Point(9, 16);
			this.BtnCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
			this.BtnCerrarSesion.Name = "BtnCerrarSesion";
			this.BtnCerrarSesion.Size = new System.Drawing.Size(107, 29);
			this.BtnCerrarSesion.TabIndex = 4;
			this.BtnCerrarSesion.Text = "Cerrar Sesión";
			this.BtnCerrarSesion.UseVisualStyleBackColor = true;
			this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
			// 
			// gbArchivo
			// 
			this.gbArchivo.Controls.Add(this.BtnSalir);
			this.gbArchivo.Controls.Add(this.BtnCerrarSesion);
			this.gbArchivo.Location = new System.Drawing.Point(823, 6);
			this.gbArchivo.Margin = new System.Windows.Forms.Padding(2);
			this.gbArchivo.Name = "gbArchivo";
			this.gbArchivo.Padding = new System.Windows.Forms.Padding(2);
			this.gbArchivo.Size = new System.Drawing.Size(237, 52);
			this.gbArchivo.TabIndex = 5;
			this.gbArchivo.TabStop = false;
			this.gbArchivo.Text = "Archivo";
			// 
			// BtnSalir
			// 
			this.BtnSalir.Location = new System.Drawing.Point(121, 16);
			this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
			this.BtnSalir.Name = "BtnSalir";
			this.BtnSalir.Size = new System.Drawing.Size(107, 29);
			this.BtnSalir.TabIndex = 5;
			this.BtnSalir.Text = "Salir";
			this.BtnSalir.UseVisualStyleBackColor = true;
			this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
			// 
			// gbGestionPostulante
			// 
			this.gbGestionPostulante.Controls.Add(this.BtnPublicarAviso);
			this.gbGestionPostulante.Location = new System.Drawing.Point(4, 160);
			this.gbGestionPostulante.Margin = new System.Windows.Forms.Padding(2);
			this.gbGestionPostulante.Name = "gbGestionPostulante";
			this.gbGestionPostulante.Padding = new System.Windows.Forms.Padding(2);
			this.gbGestionPostulante.Size = new System.Drawing.Size(197, 176);
			this.gbGestionPostulante.TabIndex = 6;
			this.gbGestionPostulante.TabStop = false;
			this.gbGestionPostulante.Text = "Gestión Postulante";
			// 
			// BtnPublicarAviso
			// 
			this.BtnPublicarAviso.Location = new System.Drawing.Point(43, 43);
			this.BtnPublicarAviso.Margin = new System.Windows.Forms.Padding(2);
			this.BtnPublicarAviso.Name = "BtnPublicarAviso";
			this.BtnPublicarAviso.Size = new System.Drawing.Size(105, 29);
			this.BtnPublicarAviso.TabIndex = 4;
			this.BtnPublicarAviso.Text = "Publicar Aviso";
			this.BtnPublicarAviso.UseVisualStyleBackColor = true;
			// 
			// gbGestionPerfilProfesional
			// 
			this.gbGestionPerfilProfesional.Controls.Add(this.BtnPostularseAviso);
			this.gbGestionPerfilProfesional.Location = new System.Drawing.Point(210, 160);
			this.gbGestionPerfilProfesional.Margin = new System.Windows.Forms.Padding(2);
			this.gbGestionPerfilProfesional.Name = "gbGestionPerfilProfesional";
			this.gbGestionPerfilProfesional.Padding = new System.Windows.Forms.Padding(2);
			this.gbGestionPerfilProfesional.Size = new System.Drawing.Size(197, 176);
			this.gbGestionPerfilProfesional.TabIndex = 7;
			this.gbGestionPerfilProfesional.TabStop = false;
			this.gbGestionPerfilProfesional.Text = "Gestión Perfil Profesional";
			// 
			// BtnPostularseAviso
			// 
			this.BtnPostularseAviso.Location = new System.Drawing.Point(18, 43);
			this.BtnPostularseAviso.Margin = new System.Windows.Forms.Padding(2);
			this.BtnPostularseAviso.Name = "BtnPostularseAviso";
			this.BtnPostularseAviso.Size = new System.Drawing.Size(145, 29);
			this.BtnPostularseAviso.TabIndex = 4;
			this.BtnPostularseAviso.Text = "Postularse a aviso";
			this.BtnPostularseAviso.UseVisualStyleBackColor = true;
			// 
			// gbAdministracionSistema
			// 
			this.gbAdministracionSistema.Controls.Add(this.BtnVerBitacora);
			this.gbAdministracionSistema.Controls.Add(this.BtnGestionBackup);
			this.gbAdministracionSistema.Controls.Add(this.BtnGestionUsuarios);
			this.gbAdministracionSistema.Controls.Add(this.BtnGestionPerfiles);
			this.gbAdministracionSistema.Location = new System.Drawing.Point(638, 160);
			this.gbAdministracionSistema.Margin = new System.Windows.Forms.Padding(2);
			this.gbAdministracionSistema.Name = "gbAdministracionSistema";
			this.gbAdministracionSistema.Padding = new System.Windows.Forms.Padding(2);
			this.gbAdministracionSistema.Size = new System.Drawing.Size(213, 215);
			this.gbAdministracionSistema.TabIndex = 8;
			this.gbAdministracionSistema.TabStop = false;
			this.gbAdministracionSistema.Text = "Administración Sistema";
			// 
			// BtnVerBitacora
			// 
			this.BtnVerBitacora.Location = new System.Drawing.Point(18, 174);
			this.BtnVerBitacora.Margin = new System.Windows.Forms.Padding(2);
			this.BtnVerBitacora.Name = "BtnVerBitacora";
			this.BtnVerBitacora.Size = new System.Drawing.Size(179, 29);
			this.BtnVerBitacora.TabIndex = 7;
			this.BtnVerBitacora.Text = "Ver Bitácora";
			this.BtnVerBitacora.UseVisualStyleBackColor = true;
			this.BtnVerBitacora.Click += new System.EventHandler(this.BtnVerBitacora_Click);
			// 
			// BtnGestionBackup
			// 
			this.BtnGestionBackup.Location = new System.Drawing.Point(18, 132);
			this.BtnGestionBackup.Margin = new System.Windows.Forms.Padding(2);
			this.BtnGestionBackup.Name = "BtnGestionBackup";
			this.BtnGestionBackup.Size = new System.Drawing.Size(179, 29);
			this.BtnGestionBackup.TabIndex = 6;
			this.BtnGestionBackup.Text = "Gestión Backup  Restore";
			this.BtnGestionBackup.UseVisualStyleBackColor = true;
			this.BtnGestionBackup.Click += new System.EventHandler(this.BtnGestionBackup_Click);
			// 
			// BtnGestionUsuarios
			// 
			this.BtnGestionUsuarios.Location = new System.Drawing.Point(18, 89);
			this.BtnGestionUsuarios.Margin = new System.Windows.Forms.Padding(2);
			this.BtnGestionUsuarios.Name = "BtnGestionUsuarios";
			this.BtnGestionUsuarios.Size = new System.Drawing.Size(179, 29);
			this.BtnGestionUsuarios.TabIndex = 5;
			this.BtnGestionUsuarios.Text = "Gestión Usuarios Perfiles";
			this.BtnGestionUsuarios.UseVisualStyleBackColor = true;
			this.BtnGestionUsuarios.Click += new System.EventHandler(this.BtnGestiónUsuarios_Click);
			// 
			// BtnGestionPerfiles
			// 
			this.BtnGestionPerfiles.Location = new System.Drawing.Point(18, 43);
			this.BtnGestionPerfiles.Margin = new System.Windows.Forms.Padding(2);
			this.BtnGestionPerfiles.Name = "BtnGestionPerfiles";
			this.BtnGestionPerfiles.Size = new System.Drawing.Size(179, 29);
			this.BtnGestionPerfiles.TabIndex = 4;
			this.BtnGestionPerfiles.Text = "Gestión Perfiles Permisos";
			this.BtnGestionPerfiles.UseVisualStyleBackColor = true;
			this.BtnGestionPerfiles.Click += new System.EventHandler(this.BtnGestionPerfiles_Click);
			// 
			// gbGestionEmpresa
			// 
			this.gbGestionEmpresa.Controls.Add(this.BtnVerListadoEmpresas);
			this.gbGestionEmpresa.Location = new System.Drawing.Point(422, 160);
			this.gbGestionEmpresa.Margin = new System.Windows.Forms.Padding(2);
			this.gbGestionEmpresa.Name = "gbGestionEmpresa";
			this.gbGestionEmpresa.Padding = new System.Windows.Forms.Padding(2);
			this.gbGestionEmpresa.Size = new System.Drawing.Size(197, 176);
			this.gbGestionEmpresa.TabIndex = 8;
			this.gbGestionEmpresa.TabStop = false;
			this.gbGestionEmpresa.Text = "Gestión Empresa";
			// 
			// BtnVerListadoEmpresas
			// 
			this.BtnVerListadoEmpresas.Location = new System.Drawing.Point(18, 43);
			this.BtnVerListadoEmpresas.Margin = new System.Windows.Forms.Padding(2);
			this.BtnVerListadoEmpresas.Name = "BtnVerListadoEmpresas";
			this.BtnVerListadoEmpresas.Size = new System.Drawing.Size(145, 29);
			this.BtnVerListadoEmpresas.TabIndex = 4;
			this.BtnVerListadoEmpresas.Text = "Ver listado empresas";
			this.BtnVerListadoEmpresas.UseVisualStyleBackColor = true;
			this.BtnVerListadoEmpresas.Click += new System.EventHandler(this.BtnVerListadoEmpresas_Click);
			// 
			// FrmHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1071, 536);
			this.Controls.Add(this.gbGestionEmpresa);
			this.Controls.Add(this.gbAdministracionSistema);
			this.Controls.Add(this.gbGestionPerfilProfesional);
			this.Controls.Add(this.gbGestionPostulante);
			this.Controls.Add(this.gbArchivo);
			this.Controls.Add(this.LblUsuarioLogueado);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmHome";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Inicio";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHome_FormClosing);
			this.Load += new System.EventHandler(this.FrmHome_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.gbArchivo.ResumeLayout(false);
			this.gbGestionPostulante.ResumeLayout(false);
			this.gbGestionPerfilProfesional.ResumeLayout(false);
			this.gbAdministracionSistema.ResumeLayout(false);
			this.gbGestionEmpresa.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label LblUsuarioLogueado;
		private System.Windows.Forms.Button BtnCerrarSesion;
		private System.Windows.Forms.GroupBox gbArchivo;
		private System.Windows.Forms.Button BtnSalir;
		private System.Windows.Forms.GroupBox gbGestionPostulante;
		private System.Windows.Forms.Button BtnPublicarAviso;
		private System.Windows.Forms.GroupBox gbGestionPerfilProfesional;
		private System.Windows.Forms.Button BtnPostularseAviso;
		private System.Windows.Forms.GroupBox gbAdministracionSistema;
		private System.Windows.Forms.Button BtnGestionPerfiles;
		private System.Windows.Forms.Button BtnGestionBackup;
		private System.Windows.Forms.Button BtnGestionUsuarios;
		private System.Windows.Forms.GroupBox gbGestionEmpresa;
		private System.Windows.Forms.Button BtnVerListadoEmpresas;
		private System.Windows.Forms.Button BtnVerBitacora;
	}
}