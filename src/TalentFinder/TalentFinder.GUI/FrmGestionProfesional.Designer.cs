namespace TalentFinder.GUI
{
	partial class FrmGestionProfesional
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
			this.GbDatosPersonales = new System.Windows.Forms.GroupBox();
			this.LblNombreProfesional = new System.Windows.Forms.Label();
			this.TxtNombre = new System.Windows.Forms.TextBox();
			this.TxtApellido = new System.Windows.Forms.TextBox();
			this.LblApellidoProfesional = new System.Windows.Forms.Label();
			this.TxtEmail = new System.Windows.Forms.TextBox();
			this.LblEmail = new System.Windows.Forms.Label();
			this.LblEmpresa = new System.Windows.Forms.Label();
			this.CmbEmpresa = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.LstTecnologias = new System.Windows.Forms.ListBox();
			this.CmbTecnologias = new System.Windows.Forms.ComboBox();
			this.BtnAgregarTecnologia = new System.Windows.Forms.Button();
			this.BtnQuitarTecnologia = new System.Windows.Forms.Button();
			this.GbExperienciaLaboral = new System.Windows.Forms.GroupBox();
			this.LblDescripcionExperiencia = new System.Windows.Forms.Label();
			this.TxtDescripcionExperiencia = new System.Windows.Forms.TextBox();
			this.LblAniosExperiencia = new System.Windows.Forms.Label();
			this.TxtAniosExperiencia = new System.Windows.Forms.TextBox();
			this.TxtEmpresaExperiencia = new System.Windows.Forms.TextBox();
			this.LblEmpresaExperiencia = new System.Windows.Forms.Label();
			this.LstExperiencia = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.BtnExperiencia = new System.Windows.Forms.Button();
			this.BtnGuardarDatosPersonales = new System.Windows.Forms.Button();
			this.GbIdiomas = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.LblDescipcion = new System.Windows.Forms.Label();
			this.TxtDescripcionIdioma = new System.Windows.Forms.TextBox();
			this.LstIdiomas = new System.Windows.Forms.ListBox();
			this.BtnQuitarIdioma = new System.Windows.Forms.Button();
			this.GbConocimiento = new System.Windows.Forms.GroupBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.LstConocimientos = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.GbDatosPersonales.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.GbExperienciaLaboral.SuspendLayout();
			this.GbIdiomas.SuspendLayout();
			this.GbConocimiento.SuspendLayout();
			this.SuspendLayout();
			// 
			// GbDatosPersonales
			// 
			this.GbDatosPersonales.Controls.Add(this.BtnGuardarDatosPersonales);
			this.GbDatosPersonales.Controls.Add(this.CmbEmpresa);
			this.GbDatosPersonales.Controls.Add(this.LblEmpresa);
			this.GbDatosPersonales.Controls.Add(this.TxtEmail);
			this.GbDatosPersonales.Controls.Add(this.LblEmail);
			this.GbDatosPersonales.Controls.Add(this.TxtApellido);
			this.GbDatosPersonales.Controls.Add(this.LblApellidoProfesional);
			this.GbDatosPersonales.Controls.Add(this.TxtNombre);
			this.GbDatosPersonales.Controls.Add(this.LblNombreProfesional);
			this.GbDatosPersonales.Location = new System.Drawing.Point(13, 13);
			this.GbDatosPersonales.Name = "GbDatosPersonales";
			this.GbDatosPersonales.Size = new System.Drawing.Size(1170, 84);
			this.GbDatosPersonales.TabIndex = 0;
			this.GbDatosPersonales.TabStop = false;
			this.GbDatosPersonales.Text = "Datos Personales";
			// 
			// LblNombreProfesional
			// 
			this.LblNombreProfesional.AutoSize = true;
			this.LblNombreProfesional.Location = new System.Drawing.Point(8, 41);
			this.LblNombreProfesional.Name = "LblNombreProfesional";
			this.LblNombreProfesional.Size = new System.Drawing.Size(79, 24);
			this.LblNombreProfesional.TabIndex = 0;
			this.LblNombreProfesional.Text = "Nombre";
			// 
			// TxtNombre
			// 
			this.TxtNombre.Location = new System.Drawing.Point(111, 38);
			this.TxtNombre.Name = "TxtNombre";
			this.TxtNombre.Size = new System.Drawing.Size(169, 29);
			this.TxtNombre.TabIndex = 1;
			// 
			// TxtApellido
			// 
			this.TxtApellido.Location = new System.Drawing.Point(375, 36);
			this.TxtApellido.Name = "TxtApellido";
			this.TxtApellido.Size = new System.Drawing.Size(152, 29);
			this.TxtApellido.TabIndex = 3;
			// 
			// LblApellidoProfesional
			// 
			this.LblApellidoProfesional.AutoSize = true;
			this.LblApellidoProfesional.Location = new System.Drawing.Point(290, 39);
			this.LblApellidoProfesional.Name = "LblApellidoProfesional";
			this.LblApellidoProfesional.Size = new System.Drawing.Size(79, 24);
			this.LblApellidoProfesional.TabIndex = 2;
			this.LblApellidoProfesional.Text = "Apellido";
			// 
			// TxtEmail
			// 
			this.TxtEmail.Location = new System.Drawing.Point(609, 35);
			this.TxtEmail.Name = "TxtEmail";
			this.TxtEmail.Size = new System.Drawing.Size(180, 29);
			this.TxtEmail.TabIndex = 5;
			// 
			// LblEmail
			// 
			this.LblEmail.AutoSize = true;
			this.LblEmail.Location = new System.Drawing.Point(538, 38);
			this.LblEmail.Name = "LblEmail";
			this.LblEmail.Size = new System.Drawing.Size(63, 24);
			this.LblEmail.TabIndex = 4;
			this.LblEmail.Text = "E-mail";
			// 
			// LblEmpresa
			// 
			this.LblEmpresa.AutoSize = true;
			this.LblEmpresa.Location = new System.Drawing.Point(806, 38);
			this.LblEmpresa.Name = "LblEmpresa";
			this.LblEmpresa.Size = new System.Drawing.Size(86, 24);
			this.LblEmpresa.TabIndex = 6;
			this.LblEmpresa.Text = "Empresa";
			// 
			// CmbEmpresa
			// 
			this.CmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CmbEmpresa.FormattingEnabled = true;
			this.CmbEmpresa.Location = new System.Drawing.Point(894, 33);
			this.CmbEmpresa.Name = "CmbEmpresa";
			this.CmbEmpresa.Size = new System.Drawing.Size(148, 32);
			this.CmbEmpresa.TabIndex = 7;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.BtnQuitarTecnologia);
			this.groupBox2.Controls.Add(this.BtnAgregarTecnologia);
			this.groupBox2.Controls.Add(this.CmbTecnologias);
			this.groupBox2.Controls.Add(this.LstTecnologias);
			this.groupBox2.Location = new System.Drawing.Point(689, 103);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(494, 323);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tecnologías";
			// 
			// LstTecnologias
			// 
			this.LstTecnologias.FormattingEnabled = true;
			this.LstTecnologias.ItemHeight = 24;
			this.LstTecnologias.Location = new System.Drawing.Point(6, 70);
			this.LstTecnologias.Name = "LstTecnologias";
			this.LstTecnologias.Size = new System.Drawing.Size(467, 196);
			this.LstTecnologias.TabIndex = 0;
			// 
			// CmbTecnologias
			// 
			this.CmbTecnologias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CmbTecnologias.FormattingEnabled = true;
			this.CmbTecnologias.Location = new System.Drawing.Point(7, 29);
			this.CmbTecnologias.Name = "CmbTecnologias";
			this.CmbTecnologias.Size = new System.Drawing.Size(337, 32);
			this.CmbTecnologias.TabIndex = 1;
			// 
			// BtnAgregarTecnologia
			// 
			this.BtnAgregarTecnologia.Location = new System.Drawing.Point(380, 28);
			this.BtnAgregarTecnologia.Name = "BtnAgregarTecnologia";
			this.BtnAgregarTecnologia.Size = new System.Drawing.Size(93, 32);
			this.BtnAgregarTecnologia.TabIndex = 2;
			this.BtnAgregarTecnologia.Text = "Agregar";
			this.BtnAgregarTecnologia.UseVisualStyleBackColor = true;
			// 
			// BtnQuitarTecnologia
			// 
			this.BtnQuitarTecnologia.Location = new System.Drawing.Point(6, 279);
			this.BtnQuitarTecnologia.Name = "BtnQuitarTecnologia";
			this.BtnQuitarTecnologia.Size = new System.Drawing.Size(109, 32);
			this.BtnQuitarTecnologia.TabIndex = 3;
			this.BtnQuitarTecnologia.Text = "Quitar";
			this.BtnQuitarTecnologia.UseVisualStyleBackColor = true;
			// 
			// GbExperienciaLaboral
			// 
			this.GbExperienciaLaboral.Controls.Add(this.BtnExperiencia);
			this.GbExperienciaLaboral.Controls.Add(this.button1);
			this.GbExperienciaLaboral.Controls.Add(this.LstExperiencia);
			this.GbExperienciaLaboral.Controls.Add(this.TxtEmpresaExperiencia);
			this.GbExperienciaLaboral.Controls.Add(this.LblEmpresaExperiencia);
			this.GbExperienciaLaboral.Controls.Add(this.TxtAniosExperiencia);
			this.GbExperienciaLaboral.Controls.Add(this.LblAniosExperiencia);
			this.GbExperienciaLaboral.Controls.Add(this.TxtDescripcionExperiencia);
			this.GbExperienciaLaboral.Controls.Add(this.LblDescripcionExperiencia);
			this.GbExperienciaLaboral.Location = new System.Drawing.Point(13, 103);
			this.GbExperienciaLaboral.Name = "GbExperienciaLaboral";
			this.GbExperienciaLaboral.Size = new System.Drawing.Size(670, 323);
			this.GbExperienciaLaboral.TabIndex = 2;
			this.GbExperienciaLaboral.TabStop = false;
			this.GbExperienciaLaboral.Text = "Experiencia Laboral";
			// 
			// LblDescripcionExperiencia
			// 
			this.LblDescripcionExperiencia.AutoSize = true;
			this.LblDescripcionExperiencia.Location = new System.Drawing.Point(6, 25);
			this.LblDescripcionExperiencia.Name = "LblDescripcionExperiencia";
			this.LblDescripcionExperiencia.Size = new System.Drawing.Size(110, 24);
			this.LblDescripcionExperiencia.TabIndex = 0;
			this.LblDescripcionExperiencia.Text = "Descripción";
			// 
			// TxtDescripcionExperiencia
			// 
			this.TxtDescripcionExperiencia.Location = new System.Drawing.Point(10, 50);
			this.TxtDescripcionExperiencia.Multiline = true;
			this.TxtDescripcionExperiencia.Name = "TxtDescripcionExperiencia";
			this.TxtDescripcionExperiencia.Size = new System.Drawing.Size(393, 64);
			this.TxtDescripcionExperiencia.TabIndex = 1;
			// 
			// LblAniosExperiencia
			// 
			this.LblAniosExperiencia.AutoSize = true;
			this.LblAniosExperiencia.Location = new System.Drawing.Point(433, 25);
			this.LblAniosExperiencia.Name = "LblAniosExperiencia";
			this.LblAniosExperiencia.Size = new System.Drawing.Size(160, 24);
			this.LblAniosExperiencia.TabIndex = 2;
			this.LblAniosExperiencia.Text = "Años Experiencia";
			// 
			// TxtAniosExperiencia
			// 
			this.TxtAniosExperiencia.Location = new System.Drawing.Point(471, 54);
			this.TxtAniosExperiencia.Name = "TxtAniosExperiencia";
			this.TxtAniosExperiencia.Size = new System.Drawing.Size(100, 29);
			this.TxtAniosExperiencia.TabIndex = 3;
			// 
			// TxtEmpresaExperiencia
			// 
			this.TxtEmpresaExperiencia.Location = new System.Drawing.Point(123, 127);
			this.TxtEmpresaExperiencia.Name = "TxtEmpresaExperiencia";
			this.TxtEmpresaExperiencia.Size = new System.Drawing.Size(280, 29);
			this.TxtEmpresaExperiencia.TabIndex = 5;
			// 
			// LblEmpresaExperiencia
			// 
			this.LblEmpresaExperiencia.AutoSize = true;
			this.LblEmpresaExperiencia.Location = new System.Drawing.Point(11, 130);
			this.LblEmpresaExperiencia.Name = "LblEmpresaExperiencia";
			this.LblEmpresaExperiencia.Size = new System.Drawing.Size(86, 24);
			this.LblEmpresaExperiencia.TabIndex = 4;
			this.LblEmpresaExperiencia.Text = "Empresa";
			// 
			// LstExperiencia
			// 
			this.LstExperiencia.FormattingEnabled = true;
			this.LstExperiencia.ItemHeight = 24;
			this.LstExperiencia.Location = new System.Drawing.Point(6, 164);
			this.LstExperiencia.Name = "LstExperiencia";
			this.LstExperiencia.Size = new System.Drawing.Size(650, 100);
			this.LstExperiencia.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(478, 117);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 32);
			this.button1.TabIndex = 7;
			this.button1.Text = "Agregar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// BtnExperiencia
			// 
			this.BtnExperiencia.Location = new System.Drawing.Point(7, 270);
			this.BtnExperiencia.Name = "BtnExperiencia";
			this.BtnExperiencia.Size = new System.Drawing.Size(109, 32);
			this.BtnExperiencia.TabIndex = 8;
			this.BtnExperiencia.Text = "Quitar";
			this.BtnExperiencia.UseVisualStyleBackColor = true;
			// 
			// BtnGuardarDatosPersonales
			// 
			this.BtnGuardarDatosPersonales.Location = new System.Drawing.Point(1056, 30);
			this.BtnGuardarDatosPersonales.Name = "BtnGuardarDatosPersonales";
			this.BtnGuardarDatosPersonales.Size = new System.Drawing.Size(100, 40);
			this.BtnGuardarDatosPersonales.TabIndex = 8;
			this.BtnGuardarDatosPersonales.Text = "Guardar";
			this.BtnGuardarDatosPersonales.UseVisualStyleBackColor = true;
			// 
			// GbIdiomas
			// 
			this.GbIdiomas.Controls.Add(this.BtnQuitarIdioma);
			this.GbIdiomas.Controls.Add(this.LstIdiomas);
			this.GbIdiomas.Controls.Add(this.TxtDescripcionIdioma);
			this.GbIdiomas.Controls.Add(this.LblDescipcion);
			this.GbIdiomas.Controls.Add(this.textBox1);
			this.GbIdiomas.Controls.Add(this.label1);
			this.GbIdiomas.Location = new System.Drawing.Point(13, 433);
			this.GbIdiomas.Name = "GbIdiomas";
			this.GbIdiomas.Size = new System.Drawing.Size(593, 293);
			this.GbIdiomas.TabIndex = 3;
			this.GbIdiomas.TabStop = false;
			this.GbIdiomas.Text = "Idiomas";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Idioma";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(80, 28);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(507, 29);
			this.textBox1.TabIndex = 1;
			// 
			// LblDescipcion
			// 
			this.LblDescipcion.AutoSize = true;
			this.LblDescipcion.Location = new System.Drawing.Point(7, 69);
			this.LblDescipcion.Name = "LblDescipcion";
			this.LblDescipcion.Size = new System.Drawing.Size(110, 24);
			this.LblDescipcion.TabIndex = 2;
			this.LblDescipcion.Text = "Descripcion";
			// 
			// TxtDescripcionIdioma
			// 
			this.TxtDescripcionIdioma.Location = new System.Drawing.Point(10, 96);
			this.TxtDescripcionIdioma.Multiline = true;
			this.TxtDescripcionIdioma.Name = "TxtDescripcionIdioma";
			this.TxtDescripcionIdioma.Size = new System.Drawing.Size(577, 51);
			this.TxtDescripcionIdioma.TabIndex = 3;
			// 
			// LstIdiomas
			// 
			this.LstIdiomas.FormattingEnabled = true;
			this.LstIdiomas.ItemHeight = 24;
			this.LstIdiomas.Location = new System.Drawing.Point(11, 164);
			this.LstIdiomas.Name = "LstIdiomas";
			this.LstIdiomas.Size = new System.Drawing.Size(576, 76);
			this.LstIdiomas.TabIndex = 4;
			// 
			// BtnQuitarIdioma
			// 
			this.BtnQuitarIdioma.Location = new System.Drawing.Point(11, 246);
			this.BtnQuitarIdioma.Name = "BtnQuitarIdioma";
			this.BtnQuitarIdioma.Size = new System.Drawing.Size(109, 32);
			this.BtnQuitarIdioma.TabIndex = 9;
			this.BtnQuitarIdioma.Text = "Quitar";
			this.BtnQuitarIdioma.UseVisualStyleBackColor = true;
			// 
			// GbConocimiento
			// 
			this.GbConocimiento.Controls.Add(this.button3);
			this.GbConocimiento.Controls.Add(this.button2);
			this.GbConocimiento.Controls.Add(this.LstConocimientos);
			this.GbConocimiento.Controls.Add(this.textBox2);
			this.GbConocimiento.Controls.Add(this.label2);
			this.GbConocimiento.Location = new System.Drawing.Point(612, 433);
			this.GbConocimiento.Name = "GbConocimiento";
			this.GbConocimiento.Size = new System.Drawing.Size(571, 293);
			this.GbConocimiento.TabIndex = 4;
			this.GbConocimiento.TabStop = false;
			this.GbConocimiento.Text = "Conocimientos / Habilidades";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(10, 51);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(547, 68);
			this.textBox2.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "Descripcion";
			// 
			// LstConocimientos
			// 
			this.LstConocimientos.FormattingEnabled = true;
			this.LstConocimientos.ItemHeight = 24;
			this.LstConocimientos.Location = new System.Drawing.Point(10, 164);
			this.LstConocimientos.Name = "LstConocimientos";
			this.LstConocimientos.Size = new System.Drawing.Size(546, 76);
			this.LstConocimientos.TabIndex = 10;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(10, 125);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(93, 32);
			this.button2.TabIndex = 11;
			this.button2.Text = "Agregar";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(11, 250);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(109, 32);
			this.button3.TabIndex = 12;
			this.button3.Text = "Quitar";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// FrmGestionProfesional
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1195, 749);
			this.Controls.Add(this.GbConocimiento);
			this.Controls.Add(this.GbIdiomas);
			this.Controls.Add(this.GbExperienciaLaboral);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.GbDatosPersonales);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FrmGestionProfesional";
			this.Text = "Gestión Profesional";
			this.GbDatosPersonales.ResumeLayout(false);
			this.GbDatosPersonales.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.GbExperienciaLaboral.ResumeLayout(false);
			this.GbExperienciaLaboral.PerformLayout();
			this.GbIdiomas.ResumeLayout(false);
			this.GbIdiomas.PerformLayout();
			this.GbConocimiento.ResumeLayout(false);
			this.GbConocimiento.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox GbDatosPersonales;
		private System.Windows.Forms.TextBox TxtNombre;
		private System.Windows.Forms.Label LblNombreProfesional;
		private System.Windows.Forms.TextBox TxtEmail;
		private System.Windows.Forms.Label LblEmail;
		private System.Windows.Forms.TextBox TxtApellido;
		private System.Windows.Forms.Label LblApellidoProfesional;
		private System.Windows.Forms.Label LblEmpresa;
		private System.Windows.Forms.ComboBox CmbEmpresa;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button BtnQuitarTecnologia;
		private System.Windows.Forms.Button BtnAgregarTecnologia;
		private System.Windows.Forms.ComboBox CmbTecnologias;
		private System.Windows.Forms.ListBox LstTecnologias;
		private System.Windows.Forms.GroupBox GbExperienciaLaboral;
		private System.Windows.Forms.TextBox TxtDescripcionExperiencia;
		private System.Windows.Forms.Label LblDescripcionExperiencia;
		private System.Windows.Forms.TextBox TxtAniosExperiencia;
		private System.Windows.Forms.Label LblAniosExperiencia;
		private System.Windows.Forms.TextBox TxtEmpresaExperiencia;
		private System.Windows.Forms.Label LblEmpresaExperiencia;
		private System.Windows.Forms.Button BtnExperiencia;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox LstExperiencia;
		private System.Windows.Forms.Button BtnGuardarDatosPersonales;
		private System.Windows.Forms.GroupBox GbIdiomas;
		private System.Windows.Forms.TextBox TxtDescripcionIdioma;
		private System.Windows.Forms.Label LblDescipcion;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnQuitarIdioma;
		private System.Windows.Forms.ListBox LstIdiomas;
		private System.Windows.Forms.GroupBox GbConocimiento;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ListBox LstConocimientos;
		private System.Windows.Forms.Button button3;
	}
}