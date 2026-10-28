/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC19
 * Fecha: 27/10/2026
 * Hora: 07:38 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CalculadoraPracSharp
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.btnSumar = new System.Windows.Forms.Button();
			this.btnRestar = new System.Windows.Forms.Button();
			this.btnMultiplicar = new System.Windows.Forms.Button();
			this.btnDividir = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(103, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Calculadora";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(50, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Numero 1:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(50, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Numero 2:";
			// 
			// txtNum1
			// 
			this.txtNum1.Location = new System.Drawing.Point(157, 72);
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.Size = new System.Drawing.Size(100, 26);
			this.txtNum1.TabIndex = 3;
			// 
			// txtNum2
			// 
			this.txtNum2.Location = new System.Drawing.Point(157, 125);
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.Size = new System.Drawing.Size(100, 26);
			this.txtNum2.TabIndex = 4;
			// 
			// btnSumar
			// 
			this.btnSumar.Location = new System.Drawing.Point(13, 209);
			this.btnSumar.Name = "btnSumar";
			this.btnSumar.Size = new System.Drawing.Size(76, 39);
			this.btnSumar.TabIndex = 6;
			this.btnSumar.Text = "Sumar";
			this.btnSumar.UseVisualStyleBackColor = true;
			this.btnSumar.Click += new System.EventHandler(this.BtnSumarClick);
			// 
			// btnRestar
			// 
			this.btnRestar.Location = new System.Drawing.Point(103, 209);
			this.btnRestar.Name = "btnRestar";
			this.btnRestar.Size = new System.Drawing.Size(73, 39);
			this.btnRestar.TabIndex = 7;
			this.btnRestar.Text = "Restar";
			this.btnRestar.UseVisualStyleBackColor = true;
			this.btnRestar.Click += new System.EventHandler(this.BtnRestarClick);
			// 
			// btnMultiplicar
			// 
			this.btnMultiplicar.Location = new System.Drawing.Point(202, 209);
			this.btnMultiplicar.Name = "btnMultiplicar";
			this.btnMultiplicar.Size = new System.Drawing.Size(105, 39);
			this.btnMultiplicar.TabIndex = 8;
			this.btnMultiplicar.Text = "Multiplicar";
			this.btnMultiplicar.UseVisualStyleBackColor = true;
			this.btnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicarClick);
			// 
			// btnDividir
			// 
			this.btnDividir.Location = new System.Drawing.Point(325, 209);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(77, 39);
			this.btnDividir.TabIndex = 9;
			this.btnDividir.Text = "Dividir";
			this.btnDividir.UseVisualStyleBackColor = true;
			this.btnDividir.Click += new System.EventHandler(this.BtnDividirClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(50, 264);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "Resultado:";
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(157, 264);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(100, 23);
			this.lblResultado.TabIndex = 11;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(435, 331);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnDividir);
			this.Controls.Add(this.btnMultiplicar);
			this.Controls.Add(this.btnRestar);
			this.Controls.Add(this.btnSumar);
			this.Controls.Add(this.txtNum2);
			this.Controls.Add(this.txtNum1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "CalculadoraPracSharp";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnDividir;
		private System.Windows.Forms.Button btnMultiplicar;
		private System.Windows.Forms.Button btnRestar;
		private System.Windows.Forms.Button btnSumar;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.TextBox txtNum1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
