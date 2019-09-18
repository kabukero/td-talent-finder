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
			this.label1 = new System.Windows.Forms.Label();
			this.BtnRealizarBackup = new System.Windows.Forms.Button();
			this.BtnSeleccionarCarpeta = new System.Windows.Forms.Button();
			this.LblCarpetaDestinoBackup = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(190, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(372, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Seleccione el directorio destino del backup";
			// 
			// BtnRealizarBackup
			// 
			this.BtnRealizarBackup.Location = new System.Drawing.Point(409, 177);
			this.BtnRealizarBackup.Name = "BtnRealizarBackup";
			this.BtnRealizarBackup.Size = new System.Drawing.Size(251, 65);
			this.BtnRealizarBackup.TabIndex = 1;
			this.BtnRealizarBackup.Text = "Realizar Backup";
			this.BtnRealizarBackup.UseVisualStyleBackColor = true;
			this.BtnRealizarBackup.Click += new System.EventHandler(this.BtnRealizarBackup_Click);
			// 
			// BtnSeleccionarCarpeta
			// 
			this.BtnSeleccionarCarpeta.Location = new System.Drawing.Point(110, 177);
			this.BtnSeleccionarCarpeta.Name = "BtnSeleccionarCarpeta";
			this.BtnSeleccionarCarpeta.Size = new System.Drawing.Size(251, 65);
			this.BtnSeleccionarCarpeta.TabIndex = 2;
			this.BtnSeleccionarCarpeta.Text = "Seleccionar carpeta";
			this.BtnSeleccionarCarpeta.UseVisualStyleBackColor = true;
			this.BtnSeleccionarCarpeta.Click += new System.EventHandler(this.BtnSeleccionarCarpeta_Click);
			// 
			// LblCarpetaDestinoBackup
			// 
			this.LblCarpetaDestinoBackup.AutoSize = true;
			this.LblCarpetaDestinoBackup.Location = new System.Drawing.Point(194, 318);
			this.LblCarpetaDestinoBackup.Name = "LblCarpetaDestinoBackup";
			this.LblCarpetaDestinoBackup.Size = new System.Drawing.Size(213, 24);
			this.LblCarpetaDestinoBackup.TabIndex = 3;
			this.LblCarpetaDestinoBackup.Text = "Carpeta destino backup:";
			// 
			// FrmGestionBackup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(767, 449);
			this.Controls.Add(this.LblCarpetaDestinoBackup);
			this.Controls.Add(this.BtnSeleccionarCarpeta);
			this.Controls.Add(this.BtnRealizarBackup);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "FrmGestionBackup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gestión Backup";
			this.Load += new System.EventHandler(this.FrmGestionBackup_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnRealizarBackup;
		private System.Windows.Forms.Button BtnSeleccionarCarpeta;
		private System.Windows.Forms.Label LblCarpetaDestinoBackup;
	}
}