namespace TalentFinder.GUI
{
	partial class FrmPanelControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPanelControl));
			this.statusStripPanelControl = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelIdioma = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripDropDownButtonIdioma = new System.Windows.Forms.ToolStripDropDownButton();
			this.statusStripPanelControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStripPanelControl
			// 
			this.statusStripPanelControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelIdioma,
            this.toolStripDropDownButtonIdioma});
			this.statusStripPanelControl.Location = new System.Drawing.Point(0, 548);
			this.statusStripPanelControl.Name = "statusStripPanelControl";
			this.statusStripPanelControl.Size = new System.Drawing.Size(1074, 22);
			this.statusStripPanelControl.TabIndex = 1;
			this.statusStripPanelControl.Text = "statusStripForm";
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
			// FrmPanelControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1074, 570);
			this.Controls.Add(this.statusStripPanelControl);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IsMdiContainer = true;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FrmPanelControl";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Panel Control";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPanelControl_FormClosing);
			this.Load += new System.EventHandler(this.FrmPanelControl_Load);
			this.statusStripPanelControl.ResumeLayout(false);
			this.statusStripPanelControl.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStripPanelControl;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelIdioma;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonIdioma;
	}
}