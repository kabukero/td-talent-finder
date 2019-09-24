namespace TalentFinder.GUI
{
	partial class FrmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
			this.LblUsuario = new System.Windows.Forms.Label();
			this.LblPassword = new System.Windows.Forms.Label();
			this.TxtUsuario = new System.Windows.Forms.TextBox();
			this.TxtPassword = new System.Windows.Forms.TextBox();
			this.BtnIngresar = new System.Windows.Forms.Button();
			this.BtnCancelar = new System.Windows.Forms.Button();
			this.LblTitulo = new System.Windows.Forms.Label();
			this.BtnIdiomaSpain = new System.Windows.Forms.Button();
			this.BtnIdiomaFrance = new System.Windows.Forms.Button();
			this.BtnIdiomaEnglish = new System.Windows.Forms.Button();
			this.gbSeleccionarIdioma = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.gbSeleccionarIdioma.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// LblUsuario
			// 
			this.LblUsuario.AutoSize = true;
			this.LblUsuario.Location = new System.Drawing.Point(56, 271);
			this.LblUsuario.Name = "LblUsuario";
			this.LblUsuario.Size = new System.Drawing.Size(74, 24);
			this.LblUsuario.TabIndex = 0;
			this.LblUsuario.Text = "Usuario";
			// 
			// LblPassword
			// 
			this.LblPassword.AutoSize = true;
			this.LblPassword.Location = new System.Drawing.Point(24, 327);
			this.LblPassword.Name = "LblPassword";
			this.LblPassword.Size = new System.Drawing.Size(106, 24);
			this.LblPassword.TabIndex = 1;
			this.LblPassword.Text = "Contraseña";
			// 
			// TxtUsuario
			// 
			this.TxtUsuario.Location = new System.Drawing.Point(162, 269);
			this.TxtUsuario.MaxLength = 50;
			this.TxtUsuario.Name = "TxtUsuario";
			this.TxtUsuario.Size = new System.Drawing.Size(323, 29);
			this.TxtUsuario.TabIndex = 0;
			// 
			// TxtPassword
			// 
			this.TxtPassword.Location = new System.Drawing.Point(162, 325);
			this.TxtPassword.MaxLength = 50;
			this.TxtPassword.Name = "TxtPassword";
			this.TxtPassword.PasswordChar = '*';
			this.TxtPassword.Size = new System.Drawing.Size(323, 29);
			this.TxtPassword.TabIndex = 1;
			// 
			// BtnIngresar
			// 
			this.BtnIngresar.Location = new System.Drawing.Point(170, 380);
			this.BtnIngresar.Name = "BtnIngresar";
			this.BtnIngresar.Size = new System.Drawing.Size(118, 43);
			this.BtnIngresar.TabIndex = 2;
			this.BtnIngresar.Text = "Ingresar";
			this.BtnIngresar.UseVisualStyleBackColor = true;
			this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
			// 
			// BtnCancelar
			// 
			this.BtnCancelar.Location = new System.Drawing.Point(294, 380);
			this.BtnCancelar.Name = "BtnCancelar";
			this.BtnCancelar.Size = new System.Drawing.Size(118, 43);
			this.BtnCancelar.TabIndex = 3;
			this.BtnCancelar.Text = "Salir";
			this.BtnCancelar.UseVisualStyleBackColor = true;
			this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
			// 
			// LblTitulo
			// 
			this.LblTitulo.AutoSize = true;
			this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTitulo.Location = new System.Drawing.Point(161, 225);
			this.LblTitulo.Name = "LblTitulo";
			this.LblTitulo.Size = new System.Drawing.Size(251, 25);
			this.LblTitulo.TabIndex = 5;
			this.LblTitulo.Text = "Ingrese sus credenciales";
			// 
			// BtnIdiomaSpain
			// 
			this.BtnIdiomaSpain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnIdiomaSpain.BackgroundImage")));
			this.BtnIdiomaSpain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnIdiomaSpain.FlatAppearance.BorderSize = 0;
			this.BtnIdiomaSpain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnIdiomaSpain.Location = new System.Drawing.Point(68, 28);
			this.BtnIdiomaSpain.Name = "BtnIdiomaSpain";
			this.BtnIdiomaSpain.Size = new System.Drawing.Size(50, 50);
			this.BtnIdiomaSpain.TabIndex = 7;
			this.BtnIdiomaSpain.UseVisualStyleBackColor = true;
			this.BtnIdiomaSpain.Click += new System.EventHandler(this.BtnIdiomaSpain_Click);
			// 
			// BtnIdiomaFrance
			// 
			this.BtnIdiomaFrance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnIdiomaFrance.BackgroundImage")));
			this.BtnIdiomaFrance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnIdiomaFrance.FlatAppearance.BorderSize = 0;
			this.BtnIdiomaFrance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnIdiomaFrance.Location = new System.Drawing.Point(393, 28);
			this.BtnIdiomaFrance.Name = "BtnIdiomaFrance";
			this.BtnIdiomaFrance.Size = new System.Drawing.Size(50, 50);
			this.BtnIdiomaFrance.TabIndex = 8;
			this.BtnIdiomaFrance.UseVisualStyleBackColor = true;
			this.BtnIdiomaFrance.Click += new System.EventHandler(this.BtnIdiomaFrance_Click);
			// 
			// BtnIdiomaEnglish
			// 
			this.BtnIdiomaEnglish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnIdiomaEnglish.BackgroundImage")));
			this.BtnIdiomaEnglish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnIdiomaEnglish.FlatAppearance.BorderSize = 0;
			this.BtnIdiomaEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnIdiomaEnglish.Location = new System.Drawing.Point(236, 28);
			this.BtnIdiomaEnglish.Name = "BtnIdiomaEnglish";
			this.BtnIdiomaEnglish.Size = new System.Drawing.Size(50, 50);
			this.BtnIdiomaEnglish.TabIndex = 9;
			this.BtnIdiomaEnglish.UseVisualStyleBackColor = true;
			this.BtnIdiomaEnglish.Click += new System.EventHandler(this.BtnIdiomaEnglish_Click);
			// 
			// gbSeleccionarIdioma
			// 
			this.gbSeleccionarIdioma.Controls.Add(this.BtnIdiomaSpain);
			this.gbSeleccionarIdioma.Controls.Add(this.BtnIdiomaEnglish);
			this.gbSeleccionarIdioma.Controls.Add(this.BtnIdiomaFrance);
			this.gbSeleccionarIdioma.Location = new System.Drawing.Point(28, 122);
			this.gbSeleccionarIdioma.Name = "gbSeleccionarIdioma";
			this.gbSeleccionarIdioma.Size = new System.Drawing.Size(511, 85);
			this.gbSeleccionarIdioma.TabIndex = 10;
			this.gbSeleccionarIdioma.TabStop = false;
			this.gbSeleccionarIdioma.Text = "Seleccione Idioma / Choose Language / Choisir la langue";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(238, 13);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(571, 448);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.gbSeleccionarIdioma);
			this.Controls.Add(this.LblTitulo);
			this.Controls.Add(this.BtnCancelar);
			this.Controls.Add(this.BtnIngresar);
			this.Controls.Add(this.TxtPassword);
			this.Controls.Add(this.TxtUsuario);
			this.Controls.Add(this.LblPassword);
			this.Controls.Add(this.LblUsuario);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FrmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Talent Finder - Ingreso al sistema";
			this.Load += new System.EventHandler(this.FrmLogin_Load);
			this.gbSeleccionarIdioma.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblUsuario;
		private System.Windows.Forms.Label LblPassword;
		private System.Windows.Forms.TextBox TxtUsuario;
		private System.Windows.Forms.TextBox TxtPassword;
		private System.Windows.Forms.Button BtnIngresar;
		private System.Windows.Forms.Button BtnCancelar;
		private System.Windows.Forms.Label LblTitulo;
		private System.Windows.Forms.Button BtnIdiomaSpain;
		private System.Windows.Forms.Button BtnIdiomaFrance;
		private System.Windows.Forms.Button BtnIdiomaEnglish;
		private System.Windows.Forms.GroupBox gbSeleccionarIdioma;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}