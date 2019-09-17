namespace TalentFinder.GUI
{
	partial class FrmGestionEmpresa
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
			this.gbEmpresa = new System.Windows.Forms.GroupBox();
			this.BtnEliminar = new System.Windows.Forms.Button();
			this.BtnEditar = new System.Windows.Forms.Button();
			this.BtnAgregar = new System.Windows.Forms.Button();
			this.TxtDireccion = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtCUIT = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtTelefono = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtRazonSocial = new System.Windows.Forms.TextBox();
			this.LblRazonSocial = new System.Windows.Forms.Label();
			this.DgvEmpresas = new System.Windows.Forms.DataGridView();
			this.TxtEmail = new System.Windows.Forms.TextBox();
			this.LblEmail = new System.Windows.Forms.Label();
			this.gbEmpresa.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgvEmpresas)).BeginInit();
			this.SuspendLayout();
			// 
			// gbEmpresa
			// 
			this.gbEmpresa.Controls.Add(this.TxtEmail);
			this.gbEmpresa.Controls.Add(this.LblEmail);
			this.gbEmpresa.Controls.Add(this.BtnEliminar);
			this.gbEmpresa.Controls.Add(this.BtnEditar);
			this.gbEmpresa.Controls.Add(this.BtnAgregar);
			this.gbEmpresa.Controls.Add(this.TxtDireccion);
			this.gbEmpresa.Controls.Add(this.label3);
			this.gbEmpresa.Controls.Add(this.TxtCUIT);
			this.gbEmpresa.Controls.Add(this.label2);
			this.gbEmpresa.Controls.Add(this.TxtTelefono);
			this.gbEmpresa.Controls.Add(this.label1);
			this.gbEmpresa.Controls.Add(this.TxtRazonSocial);
			this.gbEmpresa.Controls.Add(this.LblRazonSocial);
			this.gbEmpresa.Location = new System.Drawing.Point(3, 13);
			this.gbEmpresa.Name = "gbEmpresa";
			this.gbEmpresa.Size = new System.Drawing.Size(1128, 175);
			this.gbEmpresa.TabIndex = 0;
			this.gbEmpresa.TabStop = false;
			this.gbEmpresa.Text = "Empresa";
			// 
			// BtnEliminar
			// 
			this.BtnEliminar.Location = new System.Drawing.Point(560, 121);
			this.BtnEliminar.Name = "BtnEliminar";
			this.BtnEliminar.Size = new System.Drawing.Size(140, 48);
			this.BtnEliminar.TabIndex = 8;
			this.BtnEliminar.Text = "Eliminar";
			this.BtnEliminar.UseVisualStyleBackColor = true;
			this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
			// 
			// BtnEditar
			// 
			this.BtnEditar.Location = new System.Drawing.Point(400, 121);
			this.BtnEditar.Name = "BtnEditar";
			this.BtnEditar.Size = new System.Drawing.Size(140, 48);
			this.BtnEditar.TabIndex = 7;
			this.BtnEditar.Text = "Editar";
			this.BtnEditar.UseVisualStyleBackColor = true;
			this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
			// 
			// BtnAgregar
			// 
			this.BtnAgregar.Location = new System.Drawing.Point(236, 121);
			this.BtnAgregar.Name = "BtnAgregar";
			this.BtnAgregar.Size = new System.Drawing.Size(140, 48);
			this.BtnAgregar.TabIndex = 6;
			this.BtnAgregar.Text = "Agregar";
			this.BtnAgregar.UseVisualStyleBackColor = true;
			this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
			// 
			// TxtDireccion
			// 
			this.TxtDireccion.Location = new System.Drawing.Point(518, 24);
			this.TxtDireccion.Name = "TxtDireccion";
			this.TxtDireccion.Size = new System.Drawing.Size(242, 29);
			this.TxtDireccion.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(418, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "Dirección";
			// 
			// TxtCUIT
			// 
			this.TxtCUIT.Location = new System.Drawing.Point(518, 72);
			this.TxtCUIT.Name = "TxtCUIT";
			this.TxtCUIT.Size = new System.Drawing.Size(242, 29);
			this.TxtCUIT.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(456, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "CUIT";
			// 
			// TxtTelefono
			// 
			this.TxtTelefono.Location = new System.Drawing.Point(136, 72);
			this.TxtTelefono.Name = "TxtTelefono";
			this.TxtTelefono.Size = new System.Drawing.Size(242, 29);
			this.TxtTelefono.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Teléfono";
			// 
			// TxtRazonSocial
			// 
			this.TxtRazonSocial.Location = new System.Drawing.Point(136, 24);
			this.TxtRazonSocial.Name = "TxtRazonSocial";
			this.TxtRazonSocial.Size = new System.Drawing.Size(242, 29);
			this.TxtRazonSocial.TabIndex = 1;
			// 
			// LblRazonSocial
			// 
			this.LblRazonSocial.AutoSize = true;
			this.LblRazonSocial.Location = new System.Drawing.Point(10, 29);
			this.LblRazonSocial.Name = "LblRazonSocial";
			this.LblRazonSocial.Size = new System.Drawing.Size(120, 24);
			this.LblRazonSocial.TabIndex = 0;
			this.LblRazonSocial.Text = "Razón Social";
			// 
			// DgvEmpresas
			// 
			this.DgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvEmpresas.Location = new System.Drawing.Point(3, 195);
			this.DgvEmpresas.Name = "DgvEmpresas";
			this.DgvEmpresas.Size = new System.Drawing.Size(1128, 292);
			this.DgvEmpresas.TabIndex = 1;
			this.DgvEmpresas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpresas_CellClick);
			// 
			// TxtEmail
			// 
			this.TxtEmail.Location = new System.Drawing.Point(848, 74);
			this.TxtEmail.Name = "TxtEmail";
			this.TxtEmail.Size = new System.Drawing.Size(242, 29);
			this.TxtEmail.TabIndex = 10;
			// 
			// LblEmail
			// 
			this.LblEmail.AutoSize = true;
			this.LblEmail.Location = new System.Drawing.Point(786, 77);
			this.LblEmail.Name = "LblEmail";
			this.LblEmail.Size = new System.Drawing.Size(57, 24);
			this.LblEmail.TabIndex = 9;
			this.LblEmail.Text = "Email";
			// 
			// FrmGestionEmpresa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1143, 499);
			this.Controls.Add(this.DgvEmpresas);
			this.Controls.Add(this.gbEmpresa);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FrmGestionEmpresa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gestion Empresa";
			this.Load += new System.EventHandler(this.FrmGestionEmpresa_Load);
			this.gbEmpresa.ResumeLayout(false);
			this.gbEmpresa.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgvEmpresas)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbEmpresa;
		private System.Windows.Forms.TextBox TxtDireccion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxtCUIT;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtTelefono;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtRazonSocial;
		private System.Windows.Forms.Label LblRazonSocial;
		private System.Windows.Forms.DataGridView DgvEmpresas;
		private System.Windows.Forms.Button BtnEditar;
		private System.Windows.Forms.Button BtnAgregar;
		private System.Windows.Forms.Button BtnEliminar;
		private System.Windows.Forms.TextBox TxtEmail;
		private System.Windows.Forms.Label LblEmail;
	}
}