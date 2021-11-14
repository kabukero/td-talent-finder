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
			this.TxtEmail = new System.Windows.Forms.TextBox();
			this.LblEmail = new System.Windows.Forms.Label();
			this.BtnEliminar = new System.Windows.Forms.Button();
			this.BtnEditar = new System.Windows.Forms.Button();
			this.BtnAgregar = new System.Windows.Forms.Button();
			this.TxtDireccion = new System.Windows.Forms.TextBox();
			this.LblDireccion = new System.Windows.Forms.Label();
			this.TxtCUIT = new System.Windows.Forms.TextBox();
			this.LblCuit = new System.Windows.Forms.Label();
			this.TxtTelefono = new System.Windows.Forms.TextBox();
			this.LblTelefono = new System.Windows.Forms.Label();
			this.TxtRazonSocial = new System.Windows.Forms.TextBox();
			this.LblRazonSocial = new System.Windows.Forms.Label();
			this.DgvEmpresas = new System.Windows.Forms.DataGridView();
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
			this.gbEmpresa.Controls.Add(this.LblDireccion);
			this.gbEmpresa.Controls.Add(this.TxtCUIT);
			this.gbEmpresa.Controls.Add(this.LblCuit);
			this.gbEmpresa.Controls.Add(this.TxtTelefono);
			this.gbEmpresa.Controls.Add(this.LblTelefono);
			this.gbEmpresa.Controls.Add(this.TxtRazonSocial);
			this.gbEmpresa.Controls.Add(this.LblRazonSocial);
			this.gbEmpresa.Location = new System.Drawing.Point(3, 17);
			this.gbEmpresa.Name = "gbEmpresa";
			this.gbEmpresa.Size = new System.Drawing.Size(1128, 175);
			this.gbEmpresa.TabIndex = 0;
			this.gbEmpresa.TabStop = false;
			this.gbEmpresa.Text = "Empresa";
			// 
			// TxtEmail
			// 
			this.TxtEmail.Enabled = false;
			this.TxtEmail.Location = new System.Drawing.Point(459, 79);
			this.TxtEmail.Name = "TxtEmail";
			this.TxtEmail.Size = new System.Drawing.Size(301, 29);
			this.TxtEmail.TabIndex = 3;
			// 
			// LblEmail
			// 
			this.LblEmail.AutoSize = true;
			this.LblEmail.Location = new System.Drawing.Point(396, 82);
			this.LblEmail.Name = "LblEmail";
			this.LblEmail.Size = new System.Drawing.Size(57, 24);
			this.LblEmail.TabIndex = 9;
			this.LblEmail.Text = "Email";
			// 
			// BtnEliminar
			// 
			this.BtnEliminar.Location = new System.Drawing.Point(643, 121);
			this.BtnEliminar.Name = "BtnEliminar";
			this.BtnEliminar.Size = new System.Drawing.Size(140, 34);
			this.BtnEliminar.TabIndex = 7;
			this.BtnEliminar.Text = "Eliminar";
			this.BtnEliminar.UseVisualStyleBackColor = true;
			this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
			// 
			// BtnEditar
			// 
			this.BtnEditar.Location = new System.Drawing.Point(483, 121);
			this.BtnEditar.Name = "BtnEditar";
			this.BtnEditar.Size = new System.Drawing.Size(140, 34);
			this.BtnEditar.TabIndex = 6;
			this.BtnEditar.Text = "Editar";
			this.BtnEditar.UseVisualStyleBackColor = true;
			this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
			// 
			// BtnAgregar
			// 
			this.BtnAgregar.Location = new System.Drawing.Point(319, 121);
			this.BtnAgregar.Name = "BtnAgregar";
			this.BtnAgregar.Size = new System.Drawing.Size(140, 34);
			this.BtnAgregar.TabIndex = 5;
			this.BtnAgregar.Text = "Agregar";
			this.BtnAgregar.UseVisualStyleBackColor = true;
			this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
			// 
			// TxtDireccion
			// 
			this.TxtDireccion.Enabled = false;
			this.TxtDireccion.Location = new System.Drawing.Point(643, 30);
			this.TxtDireccion.Name = "TxtDireccion";
			this.TxtDireccion.Size = new System.Drawing.Size(448, 29);
			this.TxtDireccion.TabIndex = 1;
			// 
			// LblDireccion
			// 
			this.LblDireccion.AutoSize = true;
			this.LblDireccion.Location = new System.Drawing.Point(547, 33);
			this.LblDireccion.Name = "LblDireccion";
			this.LblDireccion.Size = new System.Drawing.Size(90, 24);
			this.LblDireccion.TabIndex = 2;
			this.LblDireccion.Text = "Dirección";
			// 
			// TxtCUIT
			// 
			this.TxtCUIT.Enabled = false;
			this.TxtCUIT.Location = new System.Drawing.Point(849, 79);
			this.TxtCUIT.Name = "TxtCUIT";
			this.TxtCUIT.Size = new System.Drawing.Size(242, 29);
			this.TxtCUIT.TabIndex = 4;
			// 
			// LblCuit
			// 
			this.LblCuit.AutoSize = true;
			this.LblCuit.Location = new System.Drawing.Point(787, 82);
			this.LblCuit.Name = "LblCuit";
			this.LblCuit.Size = new System.Drawing.Size(52, 24);
			this.LblCuit.TabIndex = 4;
			this.LblCuit.Text = "CUIT";
			// 
			// TxtTelefono
			// 
			this.TxtTelefono.Enabled = false;
			this.TxtTelefono.Location = new System.Drawing.Point(136, 79);
			this.TxtTelefono.Name = "TxtTelefono";
			this.TxtTelefono.Size = new System.Drawing.Size(242, 29);
			this.TxtTelefono.TabIndex = 2;
			// 
			// LblTelefono
			// 
			this.LblTelefono.AutoSize = true;
			this.LblTelefono.Location = new System.Drawing.Point(38, 82);
			this.LblTelefono.Name = "LblTelefono";
			this.LblTelefono.Size = new System.Drawing.Size(85, 24);
			this.LblTelefono.TabIndex = 2;
			this.LblTelefono.Text = "Teléfono";
			// 
			// TxtRazonSocial
			// 
			this.TxtRazonSocial.Enabled = false;
			this.TxtRazonSocial.Location = new System.Drawing.Point(136, 30);
			this.TxtRazonSocial.Name = "TxtRazonSocial";
			this.TxtRazonSocial.Size = new System.Drawing.Size(387, 29);
			this.TxtRazonSocial.TabIndex = 0;
			// 
			// LblRazonSocial
			// 
			this.LblRazonSocial.AutoSize = true;
			this.LblRazonSocial.Location = new System.Drawing.Point(10, 33);
			this.LblRazonSocial.Name = "LblRazonSocial";
			this.LblRazonSocial.Size = new System.Drawing.Size(120, 24);
			this.LblRazonSocial.TabIndex = 0;
			this.LblRazonSocial.Text = "Razón Social";
			// 
			// DgvEmpresas
			// 
			this.DgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvEmpresas.Location = new System.Drawing.Point(3, 198);
			this.DgvEmpresas.Name = "DgvEmpresas";
			this.DgvEmpresas.Size = new System.Drawing.Size(1128, 503);
			this.DgvEmpresas.TabIndex = 1;
			this.DgvEmpresas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpresas_CellClick);
			// 
			// FrmGestionEmpresa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1143, 713);
			this.Controls.Add(this.DgvEmpresas);
			this.Controls.Add(this.gbEmpresa);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FrmGestionEmpresa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gestion Empresa";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGestionEmpresa_FormClosing);
			this.Load += new System.EventHandler(this.FrmGestionEmpresa_Load);
			this.Shown += new System.EventHandler(this.FrmGestionEmpresa_Shown);
			this.gbEmpresa.ResumeLayout(false);
			this.gbEmpresa.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgvEmpresas)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbEmpresa;
		private System.Windows.Forms.TextBox TxtDireccion;
		private System.Windows.Forms.Label LblDireccion;
		private System.Windows.Forms.TextBox TxtCUIT;
		private System.Windows.Forms.Label LblCuit;
		private System.Windows.Forms.TextBox TxtTelefono;
		private System.Windows.Forms.Label LblTelefono;
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