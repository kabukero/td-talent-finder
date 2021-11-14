namespace TalentFinder.GUI
{
	partial class FrmGestionBackup
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
			this.LblTitulo = new System.Windows.Forms.Label();
			this.BtnRealizarBackup = new System.Windows.Forms.Button();
			this.BtnRealizarRestore = new System.Windows.Forms.Button();
			this.DgvBackups = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.DgvBackups)).BeginInit();
			this.SuspendLayout();
			// 
			// LblTitulo
			// 
			this.LblTitulo.AutoSize = true;
			this.LblTitulo.Location = new System.Drawing.Point(422, 37);
			this.LblTitulo.Name = "LblTitulo";
			this.LblTitulo.Size = new System.Drawing.Size(294, 24);
			this.LblTitulo.TabIndex = 0;
			this.LblTitulo.Text = "Seleccione la operación a realizar";
			// 
			// BtnRealizarBackup
			// 
			this.BtnRealizarBackup.Location = new System.Drawing.Point(317, 98);
			this.BtnRealizarBackup.Name = "BtnRealizarBackup";
			this.BtnRealizarBackup.Size = new System.Drawing.Size(251, 65);
			this.BtnRealizarBackup.TabIndex = 1;
			this.BtnRealizarBackup.Text = "Realizar Backup";
			this.BtnRealizarBackup.UseVisualStyleBackColor = true;
			this.BtnRealizarBackup.Click += new System.EventHandler(this.BtnRealizarBackup_Click);
			// 
			// BtnRealizarRestore
			// 
			this.BtnRealizarRestore.Location = new System.Drawing.Point(601, 98);
			this.BtnRealizarRestore.Name = "BtnRealizarRestore";
			this.BtnRealizarRestore.Size = new System.Drawing.Size(251, 65);
			this.BtnRealizarRestore.TabIndex = 4;
			this.BtnRealizarRestore.Text = "Realizar Restore";
			this.BtnRealizarRestore.UseVisualStyleBackColor = true;
			this.BtnRealizarRestore.Click += new System.EventHandler(this.BtnRealizarRestore_Click);
			// 
			// DgvBackups
			// 
			this.DgvBackups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvBackups.Location = new System.Drawing.Point(31, 186);
			this.DgvBackups.Name = "DgvBackups";
			this.DgvBackups.Size = new System.Drawing.Size(1120, 462);
			this.DgvBackups.TabIndex = 5;
			// 
			// FrmGestionBackup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1185, 668);
			this.Controls.Add(this.DgvBackups);
			this.Controls.Add(this.BtnRealizarRestore);
			this.Controls.Add(this.BtnRealizarBackup);
			this.Controls.Add(this.LblTitulo);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FrmGestionBackup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gestión Backup / Restore";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGestionBackup_FormClosing);
			this.Load += new System.EventHandler(this.FrmGestionBackup_Load);
			this.Shown += new System.EventHandler(this.FrmGestionBackup_Shown);
			((System.ComponentModel.ISupportInitialize)(this.DgvBackups)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblTitulo;
		private System.Windows.Forms.Button BtnRealizarBackup;
		private System.Windows.Forms.Button BtnRealizarRestore;
		private System.Windows.Forms.DataGridView DgvBackups;
	}
}