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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.statusStripForm = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelIdioma = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripDropDownButtonIdioma = new System.Windows.Forms.ToolStripDropDownButton();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.statusStripForm.SuspendLayout();
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
			this.TxtUsuario.Location = new System.Drawing.Point(149, 269);
			this.TxtUsuario.MaxLength = 50;
			this.TxtUsuario.Name = "TxtUsuario";
			this.TxtUsuario.Size = new System.Drawing.Size(323, 29);
			this.TxtUsuario.TabIndex = 0;
			// 
			// TxtPassword
			// 
			this.TxtPassword.Location = new System.Drawing.Point(149, 325);
			this.TxtPassword.MaxLength = 50;
			this.TxtPassword.Name = "TxtPassword";
			this.TxtPassword.PasswordChar = '*';
			this.TxtPassword.Size = new System.Drawing.Size(323, 29);
			this.TxtPassword.TabIndex = 1;
			// 
			// BtnIngresar
			// 
			this.BtnIngresar.Location = new System.Drawing.Point(170, 369);
			this.BtnIngresar.Name = "BtnIngresar";
			this.BtnIngresar.Size = new System.Drawing.Size(118, 43);
			this.BtnIngresar.TabIndex = 2;
			this.BtnIngresar.Text = "Ingresar";
			this.BtnIngresar.UseVisualStyleBackColor = true;
			this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
			// 
			// BtnCancelar
			// 
			this.BtnCancelar.Location = new System.Drawing.Point(294, 369);
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
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(197, 15);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(198, 181);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// statusStripForm
			// 
			this.statusStripForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelIdioma,
            this.toolStripDropDownButtonIdioma});
			this.statusStripForm.Location = new System.Drawing.Point(0, 426);
			this.statusStripForm.Name = "statusStripForm";
			this.statusStripForm.Size = new System.Drawing.Size(571, 22);
			this.statusStripForm.TabIndex = 12;
			this.statusStripForm.Text = "statusStripPanelControl";
			// 
			// toolStripStatusLabelIdioma
			// 
			this.toolStripStatusLabelIdioma.Name = "toolStripStatusLabelIdioma";
			this.toolStripStatusLabelIdioma.Size = new System.Drawing.Size(44, 17);
			this.toolStripStatusLabelIdioma.Text = "Idioma";
			// 
			// toolStripDropDownButtonIdioma
			// 
			this.toolStripDropDownButtonIdioma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButtonIdioma.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonIdioma.Image")));
			this.toolStripDropDownButtonIdioma.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButtonIdioma.Name = "toolStripDropDownButtonIdioma";
			this.toolStripDropDownButtonIdioma.Size = new System.Drawing.Size(29, 20);
			this.toolStripDropDownButtonIdioma.Text = "Seleccione Idioma";
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(571, 448);
			this.Controls.Add(this.statusStripForm);
			this.Controls.Add(this.pictureBox1);
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
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
			this.Load += new System.EventHandler(this.FrmLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.statusStripForm.ResumeLayout(false);
			this.statusStripForm.PerformLayout();
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
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.StatusStrip statusStripForm;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelIdioma;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonIdioma;
	}
}