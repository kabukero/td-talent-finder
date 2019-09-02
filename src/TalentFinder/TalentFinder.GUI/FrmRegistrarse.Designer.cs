namespace TalentFinder.GUI
{
	partial class FrmRegistrarse
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
			this.TxtPassword = new System.Windows.Forms.TextBox();
			this.TxtUsuario = new System.Windows.Forms.TextBox();
			this.LblPassword = new System.Windows.Forms.Label();
			this.LblUsuario = new System.Windows.Forms.Label();
			this.LblTitulo = new System.Windows.Forms.Label();
			this.BtnCancelar = new System.Windows.Forms.Button();
			this.BtnRegistrarse = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TxtPassword
			// 
			this.TxtPassword.Location = new System.Drawing.Point(223, 158);
			this.TxtPassword.MaxLength = 50;
			this.TxtPassword.Name = "TxtPassword";
			this.TxtPassword.PasswordChar = '*';
			this.TxtPassword.Size = new System.Drawing.Size(323, 29);
			this.TxtPassword.TabIndex = 4;
			// 
			// TxtUsuario
			// 
			this.TxtUsuario.Location = new System.Drawing.Point(223, 89);
			this.TxtUsuario.MaxLength = 50;
			this.TxtUsuario.Name = "TxtUsuario";
			this.TxtUsuario.Size = new System.Drawing.Size(323, 29);
			this.TxtUsuario.TabIndex = 2;
			// 
			// LblPassword
			// 
			this.LblPassword.AutoSize = true;
			this.LblPassword.Location = new System.Drawing.Point(108, 160);
			this.LblPassword.Name = "LblPassword";
			this.LblPassword.Size = new System.Drawing.Size(111, 24);
			this.LblPassword.TabIndex = 5;
			this.LblPassword.Text = "Contraseña:";
			// 
			// LblUsuario
			// 
			this.LblUsuario.AutoSize = true;
			this.LblUsuario.Location = new System.Drawing.Point(140, 91);
			this.LblUsuario.Name = "LblUsuario";
			this.LblUsuario.Size = new System.Drawing.Size(79, 24);
			this.LblUsuario.TabIndex = 3;
			this.LblUsuario.Text = "Usuario:";
			// 
			// LblTitulo
			// 
			this.LblTitulo.AutoSize = true;
			this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTitulo.Location = new System.Drawing.Point(174, 22);
			this.LblTitulo.Name = "LblTitulo";
			this.LblTitulo.Size = new System.Drawing.Size(349, 25);
			this.LblTitulo.TabIndex = 6;
			this.LblTitulo.Text = "Complete los campos de formulario";
			// 
			// BtnCancelar
			// 
			this.BtnCancelar.Location = new System.Drawing.Point(372, 226);
			this.BtnCancelar.Name = "BtnCancelar";
			this.BtnCancelar.Size = new System.Drawing.Size(118, 62);
			this.BtnCancelar.TabIndex = 8;
			this.BtnCancelar.Text = "Cancelar";
			this.BtnCancelar.UseVisualStyleBackColor = true;
			this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
			// 
			// BtnRegistrarse
			// 
			this.BtnRegistrarse.Location = new System.Drawing.Point(231, 226);
			this.BtnRegistrarse.Name = "BtnRegistrarse";
			this.BtnRegistrarse.Size = new System.Drawing.Size(118, 62);
			this.BtnRegistrarse.TabIndex = 7;
			this.BtnRegistrarse.Text = "Registrarse";
			this.BtnRegistrarse.UseVisualStyleBackColor = true;
			// 
			// FrmRegistrarse
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(719, 323);
			this.Controls.Add(this.BtnCancelar);
			this.Controls.Add(this.BtnRegistrarse);
			this.Controls.Add(this.LblTitulo);
			this.Controls.Add(this.TxtPassword);
			this.Controls.Add(this.TxtUsuario);
			this.Controls.Add(this.LblPassword);
			this.Controls.Add(this.LblUsuario);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "FrmRegistrarse";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registrarse";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxtPassword;
		private System.Windows.Forms.TextBox TxtUsuario;
		private System.Windows.Forms.Label LblPassword;
		private System.Windows.Forms.Label LblUsuario;
		private System.Windows.Forms.Label LblTitulo;
		private System.Windows.Forms.Button BtnCancelar;
		private System.Windows.Forms.Button BtnRegistrarse;
	}
}