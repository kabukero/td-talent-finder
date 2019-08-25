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
			this.LblUsuario = new System.Windows.Forms.Label();
			this.LblPassword = new System.Windows.Forms.Label();
			this.TxtUsuario = new System.Windows.Forms.TextBox();
			this.TxtPassword = new System.Windows.Forms.TextBox();
			this.BtnIngresar = new System.Windows.Forms.Button();
			this.BtnCancelar = new System.Windows.Forms.Button();
			this.LblTitulo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// LblUsuario
			// 
			this.LblUsuario.AutoSize = true;
			this.LblUsuario.Location = new System.Drawing.Point(44, 80);
			this.LblUsuario.Name = "LblUsuario";
			this.LblUsuario.Size = new System.Drawing.Size(79, 24);
			this.LblUsuario.TabIndex = 0;
			this.LblUsuario.Text = "Usuario:";
			// 
			// LblPassword
			// 
			this.LblPassword.AutoSize = true;
			this.LblPassword.Location = new System.Drawing.Point(12, 149);
			this.LblPassword.Name = "LblPassword";
			this.LblPassword.Size = new System.Drawing.Size(111, 24);
			this.LblPassword.TabIndex = 1;
			this.LblPassword.Text = "Contraseña:";
			// 
			// TxtUsuario
			// 
			this.TxtUsuario.Location = new System.Drawing.Point(127, 78);
			this.TxtUsuario.MaxLength = 50;
			this.TxtUsuario.Name = "TxtUsuario";
			this.TxtUsuario.Size = new System.Drawing.Size(323, 29);
			this.TxtUsuario.TabIndex = 0;
			// 
			// TxtPassword
			// 
			this.TxtPassword.Location = new System.Drawing.Point(127, 147);
			this.TxtPassword.MaxLength = 50;
			this.TxtPassword.Name = "TxtPassword";
			this.TxtPassword.PasswordChar = '*';
			this.TxtPassword.Size = new System.Drawing.Size(323, 29);
			this.TxtPassword.TabIndex = 1;
			// 
			// BtnIngresar
			// 
			this.BtnIngresar.Location = new System.Drawing.Point(131, 226);
			this.BtnIngresar.Name = "BtnIngresar";
			this.BtnIngresar.Size = new System.Drawing.Size(118, 62);
			this.BtnIngresar.TabIndex = 2;
			this.BtnIngresar.Text = "Ingresar";
			this.BtnIngresar.UseVisualStyleBackColor = true;
			this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
			// 
			// BtnCancelar
			// 
			this.BtnCancelar.Location = new System.Drawing.Point(274, 226);
			this.BtnCancelar.Name = "BtnCancelar";
			this.BtnCancelar.Size = new System.Drawing.Size(118, 62);
			this.BtnCancelar.TabIndex = 3;
			this.BtnCancelar.Text = "Cancelar";
			this.BtnCancelar.UseVisualStyleBackColor = true;
			this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
			// 
			// LblTitulo
			// 
			this.LblTitulo.AutoSize = true;
			this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTitulo.Location = new System.Drawing.Point(127, 25);
			this.LblTitulo.Name = "LblTitulo";
			this.LblTitulo.Size = new System.Drawing.Size(251, 25);
			this.LblTitulo.TabIndex = 5;
			this.LblTitulo.Text = "Ingrese sus credenciales";
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 330);
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
	}
}