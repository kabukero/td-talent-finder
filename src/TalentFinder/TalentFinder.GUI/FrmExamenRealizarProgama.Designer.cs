namespace TalentFinder.GUI
{
	partial class FrmExamenRealizarProgama
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
			this.TxtCodigoPrograma = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnEjecutarCodigo = new System.Windows.Forms.Button();
			this.LblEnunciado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TxtCodigoPrograma
			// 
			this.TxtCodigoPrograma.Location = new System.Drawing.Point(12, 111);
			this.TxtCodigoPrograma.Multiline = true;
			this.TxtCodigoPrograma.Name = "TxtCodigoPrograma";
			this.TxtCodigoPrograma.Size = new System.Drawing.Size(1053, 425);
			this.TxtCodigoPrograma.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(354, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Escriba el codigo del siguiente programa";
			// 
			// BtnEjecutarCodigo
			// 
			this.BtnEjecutarCodigo.Location = new System.Drawing.Point(417, 550);
			this.BtnEjecutarCodigo.Name = "BtnEjecutarCodigo";
			this.BtnEjecutarCodigo.Size = new System.Drawing.Size(228, 45);
			this.BtnEjecutarCodigo.TabIndex = 2;
			this.BtnEjecutarCodigo.Text = "Ejecutar Programa";
			this.BtnEjecutarCodigo.UseVisualStyleBackColor = true;
			this.BtnEjecutarCodigo.Click += new System.EventHandler(this.BtnEjecutarCodigo_Click);
			// 
			// LblEnunciado
			// 
			this.LblEnunciado.AutoSize = true;
			this.LblEnunciado.Location = new System.Drawing.Point(15, 53);
			this.LblEnunciado.MaximumSize = new System.Drawing.Size(850, 0);
			this.LblEnunciado.Name = "LblEnunciado";
			this.LblEnunciado.Size = new System.Drawing.Size(818, 48);
			this.LblEnunciado.TabIndex = 3;
			this.LblEnunciado.Text = "Crear una funcion que reciba 2 enteros como parametro y devuelva la suma de ellos" +
    ". El método debe llamarse: MiMetodo";
			// 
			// FrmExamenRealizarProgama
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1077, 614);
			this.Controls.Add(this.LblEnunciado);
			this.Controls.Add(this.BtnEjecutarCodigo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxtCodigoPrograma);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "FrmExamenRealizarProgama";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Examen - Realizar Programa";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxtCodigoPrograma;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnEjecutarCodigo;
		private System.Windows.Forms.Label LblEnunciado;
	}
}