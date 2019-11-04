namespace TalentFinder.GUI
{
	partial class FrmExamenEjercicioProgamacion
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
			this.components = new System.ComponentModel.Container();
			this.TxtCodigoPrograma = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnEjecutarCodigo = new System.Windows.Forms.Button();
			this.LblEnunciado = new System.Windows.Forms.Label();
			this.TxtCurrentElapsedTime = new System.Windows.Forms.TextBox();
			this.TimerClock = new System.Windows.Forms.Timer(this.components);
			this.LblTiempoRestante = new System.Windows.Forms.Label();
			this.BtnFinalizarExamen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TxtCodigoPrograma
			// 
			this.TxtCodigoPrograma.Location = new System.Drawing.Point(12, 122);
			this.TxtCodigoPrograma.Multiline = true;
			this.TxtCodigoPrograma.Name = "TxtCodigoPrograma";
			this.TxtCodigoPrograma.Size = new System.Drawing.Size(1053, 415);
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
			this.BtnEjecutarCodigo.Location = new System.Drawing.Point(321, 550);
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
			this.LblEnunciado.Location = new System.Drawing.Point(15, 46);
			this.LblEnunciado.MaximumSize = new System.Drawing.Size(500, 0);
			this.LblEnunciado.Name = "LblEnunciado";
			this.LblEnunciado.Size = new System.Drawing.Size(467, 72);
			this.LblEnunciado.TabIndex = 3;
			this.LblEnunciado.Text = "Desarrollar un método que reciba un número entero y retorne el factorial de dicho" +
    " número. El método debe llamarse: MiMetodo";
			// 
			// TxtCurrentElapsedTime
			// 
			this.TxtCurrentElapsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtCurrentElapsedTime.Location = new System.Drawing.Point(886, 33);
			this.TxtCurrentElapsedTime.Name = "TxtCurrentElapsedTime";
			this.TxtCurrentElapsedTime.Size = new System.Drawing.Size(179, 80);
			this.TxtCurrentElapsedTime.TabIndex = 4;
			// 
			// TimerClock
			// 
			this.TimerClock.Tick += new System.EventHandler(this.TimerClock_Tick);
			// 
			// LblTiempoRestante
			// 
			this.LblTiempoRestante.AutoSize = true;
			this.LblTiempoRestante.Location = new System.Drawing.Point(882, 6);
			this.LblTiempoRestante.Name = "LblTiempoRestante";
			this.LblTiempoRestante.Size = new System.Drawing.Size(153, 24);
			this.LblTiempoRestante.TabIndex = 5;
			this.LblTiempoRestante.Text = "Tiempo Restante";
			// 
			// BtnFinalizarExamen
			// 
			this.BtnFinalizarExamen.Location = new System.Drawing.Point(576, 550);
			this.BtnFinalizarExamen.Name = "BtnFinalizarExamen";
			this.BtnFinalizarExamen.Size = new System.Drawing.Size(228, 45);
			this.BtnFinalizarExamen.TabIndex = 6;
			this.BtnFinalizarExamen.Text = "Finalizar Examen";
			this.BtnFinalizarExamen.UseVisualStyleBackColor = true;
			this.BtnFinalizarExamen.Click += new System.EventHandler(this.BtnFinalizarExamen_Click);
			// 
			// FrmExamenEjercicioProgamacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1077, 614);
			this.Controls.Add(this.BtnFinalizarExamen);
			this.Controls.Add(this.LblTiempoRestante);
			this.Controls.Add(this.TxtCurrentElapsedTime);
			this.Controls.Add(this.LblEnunciado);
			this.Controls.Add(this.BtnEjecutarCodigo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxtCodigoPrograma);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FrmExamenEjercicioProgamacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Examen - Realizar Programa";
			this.Load += new System.EventHandler(this.FrmExamenEjercicioProgamacion_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxtCodigoPrograma;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnEjecutarCodigo;
		private System.Windows.Forms.Label LblEnunciado;
		private System.Windows.Forms.TextBox TxtCurrentElapsedTime;
		private System.Windows.Forms.Timer TimerClock;
		private System.Windows.Forms.Label LblTiempoRestante;
		private System.Windows.Forms.Button BtnFinalizarExamen;
	}
}