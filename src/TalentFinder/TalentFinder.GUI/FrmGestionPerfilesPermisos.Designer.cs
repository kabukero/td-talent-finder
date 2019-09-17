namespace TalentFinder.GUI
{
	partial class FrmGestionPerfilesPermisos
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
			this.LblFamilias = new System.Windows.Forms.Label();
			this.LblDescripcion = new System.Windows.Forms.Label();
			this.TxtDescripcion = new System.Windows.Forms.TextBox();
			this.BtnCrear = new System.Windows.Forms.Button();
			this.BtnCancelar = new System.Windows.Forms.Button();
			this.LstPerfiles = new System.Windows.Forms.ListBox();
			this.LstPermisos = new System.Windows.Forms.ListBox();
			this.BtnAgregarPerfil = new System.Windows.Forms.Button();
			this.BtnAgregarPermiso = new System.Windows.Forms.Button();
			this.LblPerfiles = new System.Windows.Forms.Label();
			this.LblPermisos = new System.Windows.Forms.Label();
			this.LblPerfil = new System.Windows.Forms.Label();
			this.BtnEditar = new System.Windows.Forms.Button();
			this.BtnEliminar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TvwPerfilesPermisos
			// 
			this.TvwPerfilesPermisos.AllowDrop = true;
			this.TvwPerfilesPermisos.Location = new System.Drawing.Point(10, 36);
			this.TvwPerfilesPermisos.Name = "TvwPerfilesPermisos";
			this.TvwPerfilesPermisos.Size = new System.Drawing.Size(491, 586);
			this.TvwPerfilesPermisos.TabIndex = 0;
			this.TvwPerfilesPermisos.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TvwPerfilesPermisos_ItemDrag);
			this.TvwPerfilesPermisos.Click += new System.EventHandler(this.TvwPerfilesPermisos_Click);
			this.TvwPerfilesPermisos.DragDrop += new System.Windows.Forms.DragEventHandler(this.TvwPerfilesPermisos_DragDrop);
			this.TvwPerfilesPermisos.DragEnter += new System.Windows.Forms.DragEventHandler(this.TvwPerfilesPermisos_DragEnter);
			// 
			// LblFamilias
			// 
			this.LblFamilias.AutoSize = true;
			this.LblFamilias.Location = new System.Drawing.Point(154, 9);
			this.LblFamilias.Name = "LblFamilias";
			this.LblFamilias.Size = new System.Drawing.Size(165, 24);
			this.LblFamilias.TabIndex = 7;
			this.LblFamilias.Text = "Perfiles - Permisos";
			// 
			// LblDescripcion
			// 
			this.LblDescripcion.AutoSize = true;
			this.LblDescripcion.Location = new System.Drawing.Point(616, 38);
			this.LblDescripcion.Name = "LblDescripcion";
			this.LblDescripcion.Size = new System.Drawing.Size(110, 24);
			this.LblDescripcion.TabIndex = 8;
			this.LblDescripcion.Text = "Descripción";
			// 
			// TxtDescripcion
			// 
			this.TxtDescripcion.Location = new System.Drawing.Point(734, 36);
			this.TxtDescripcion.Name = "TxtDescripcion";
			this.TxtDescripcion.Size = new System.Drawing.Size(273, 29);
			this.TxtDescripcion.TabIndex = 9;
			// 
			// BtnCrear
			// 
			this.BtnCrear.Location = new System.Drawing.Point(599, 74);
			this.BtnCrear.Name = "BtnCrear";
			this.BtnCrear.Size = new System.Drawing.Size(113, 40);
			this.BtnCrear.TabIndex = 12;
			this.BtnCrear.Text = "Crear";
			this.BtnCrear.UseVisualStyleBackColor = true;
			this.BtnCrear.Click += new System.EventHandler(this.BtnGuardar_Click);
			// 
			// BtnCancelar
			// 
			this.BtnCancelar.Location = new System.Drawing.Point(970, 74);
			this.BtnCancelar.Name = "BtnCancelar";
			this.BtnCancelar.Size = new System.Drawing.Size(113, 40);
			this.BtnCancelar.TabIndex = 13;
			this.BtnCancelar.Text = "Cancelar";
			this.BtnCancelar.UseVisualStyleBackColor = true;
			this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
			// 
			// LstPerfiles
			// 
			this.LstPerfiles.FormattingEnabled = true;
			this.LstPerfiles.ItemHeight = 24;
			this.LstPerfiles.Location = new System.Drawing.Point(507, 157);
			this.LstPerfiles.Name = "LstPerfiles";
			this.LstPerfiles.Size = new System.Drawing.Size(318, 412);
			this.LstPerfiles.TabIndex = 14;
			// 
			// LstPermisos
			// 
			this.LstPermisos.FormattingEnabled = true;
			this.LstPermisos.ItemHeight = 24;
			this.LstPermisos.Location = new System.Drawing.Point(831, 157);
			this.LstPermisos.Name = "LstPermisos";
			this.LstPermisos.Size = new System.Drawing.Size(313, 412);
			this.LstPermisos.TabIndex = 15;
			// 
			// BtnAgregarPerfil
			// 
			this.BtnAgregarPerfil.Location = new System.Drawing.Point(552, 582);
			this.BtnAgregarPerfil.Name = "BtnAgregarPerfil";
			this.BtnAgregarPerfil.Size = new System.Drawing.Size(222, 40);
			this.BtnAgregarPerfil.TabIndex = 16;
			this.BtnAgregarPerfil.Text = "Agregar Perfil a Perfil";
			this.BtnAgregarPerfil.UseVisualStyleBackColor = true;
			this.BtnAgregarPerfil.Click += new System.EventHandler(this.BtnAgregarPerfil_Click);
			// 
			// BtnAgregarPermiso
			// 
			this.BtnAgregarPermiso.Location = new System.Drawing.Point(869, 582);
			this.BtnAgregarPermiso.Name = "BtnAgregarPermiso";
			this.BtnAgregarPermiso.Size = new System.Drawing.Size(235, 40);
			this.BtnAgregarPermiso.TabIndex = 17;
			this.BtnAgregarPermiso.Text = "Agregar Permiso a Perfil";
			this.BtnAgregarPermiso.UseVisualStyleBackColor = true;
			this.BtnAgregarPermiso.Click += new System.EventHandler(this.BtnAgregarPermiso_Click);
			// 
			// LblPerfiles
			// 
			this.LblPerfiles.AutoSize = true;
			this.LblPerfiles.Location = new System.Drawing.Point(624, 126);
			this.LblPerfiles.Name = "LblPerfiles";
			this.LblPerfiles.Size = new System.Drawing.Size(71, 24);
			this.LblPerfiles.TabIndex = 18;
			this.LblPerfiles.Text = "Perfiles";
			// 
			// LblPermisos
			// 
			this.LblPermisos.AutoSize = true;
			this.LblPermisos.Location = new System.Drawing.Point(934, 126);
			this.LblPermisos.Name = "LblPermisos";
			this.LblPermisos.Size = new System.Drawing.Size(88, 24);
			this.LblPermisos.TabIndex = 19;
			this.LblPermisos.Text = "Permisos";
			// 
			// LblPerfil
			// 
			this.LblPerfil.AutoSize = true;
			this.LblPerfil.Location = new System.Drawing.Point(808, 9);
			this.LblPerfil.Name = "LblPerfil";
			this.LblPerfil.Size = new System.Drawing.Size(51, 24);
			this.LblPerfil.TabIndex = 20;
			this.LblPerfil.Text = "Perfil";
			// 
			// BtnEditar
			// 
			this.BtnEditar.Location = new System.Drawing.Point(724, 74);
			this.BtnEditar.Name = "BtnEditar";
			this.BtnEditar.Size = new System.Drawing.Size(113, 40);
			this.BtnEditar.TabIndex = 21;
			this.BtnEditar.Text = "Editar";
			this.BtnEditar.UseVisualStyleBackColor = true;
			this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
			// 
			// BtnEliminar
			// 
			this.BtnEliminar.Location = new System.Drawing.Point(848, 74);
			this.BtnEliminar.Name = "BtnEliminar";
			this.BtnEliminar.Size = new System.Drawing.Size(113, 40);
			this.BtnEliminar.TabIndex = 22;
			this.BtnEliminar.Text = "Eliminar";
			this.BtnEliminar.UseVisualStyleBackColor = true;
			this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
			// 
			// FrmGestionPerfilesPermisos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1156, 634);
			this.Controls.Add(this.BtnEliminar);
			this.Controls.Add(this.BtnEditar);
			this.Controls.Add(this.LblPerfil);
			this.Controls.Add(this.LblPermisos);
			this.Controls.Add(this.LblPerfiles);
			this.Controls.Add(this.BtnAgregarPermiso);
			this.Controls.Add(this.BtnAgregarPerfil);
			this.Controls.Add(this.LstPermisos);
			this.Controls.Add(this.LstPerfiles);
			this.Controls.Add(this.BtnCancelar);
			this.Controls.Add(this.BtnCrear);
			this.Controls.Add(this.TxtDescripcion);
			this.Controls.Add(this.LblDescripcion);
			this.Controls.Add(this.LblFamilias);
			this.Controls.Add(this.TvwPerfilesPermisos);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FrmGestionPerfilesPermisos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Gestión Perfiles Permisos";
			this.Load += new System.EventHandler(this.FrmGestionPerfilesPermisos_Load);
			this.Shown += new System.EventHandler(this.FrmGestionPerfilesPermisos_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView TvwPerfilesPermisos;
		private System.Windows.Forms.Label LblFamilias;
		private System.Windows.Forms.Label LblDescripcion;
		private System.Windows.Forms.TextBox TxtDescripcion;
		private System.Windows.Forms.Button BtnCrear;
		private System.Windows.Forms.Button BtnCancelar;
		private System.Windows.Forms.ListBox LstPerfiles;
		private System.Windows.Forms.ListBox LstPermisos;
		private System.Windows.Forms.Button BtnAgregarPerfil;
		private System.Windows.Forms.Button BtnAgregarPermiso;
		private System.Windows.Forms.Label LblPerfiles;
		private System.Windows.Forms.Label LblPermisos;
		private System.Windows.Forms.Label LblPerfil;
		private System.Windows.Forms.Button BtnEditar;
		private System.Windows.Forms.Button BtnEliminar;
	}
}