/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC19
 * Fecha: 27/10/2026
 * Hora: 07:38 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraPracSharp
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void BtnSumarClick(object sender, EventArgs e)
		{
			double num1, num2, suma;
			num1=Convert.ToDouble(txtNum1.Text);
			num2=Convert.ToDouble(txtNum2.Text);
			suma=num1+num2;
			lblResultado.Text=txtNum1.Text+" + "+txtNum2.Text+" = "+Convert.ToString(suma);			
		}
		
		void BtnRestarClick(object sender, EventArgs e)
		{
			double num1, num2, resta;
			num1=Convert.ToDouble(txtNum1.Text);
			num2=Convert.ToDouble(txtNum2.Text);
			resta=num1-num2;
			lblResultado.Text=txtNum1.Text+" - "+txtNum2.Text+" = "+Convert.ToString(resta);
		}
		
		void BtnMultiplicarClick(object sender, EventArgs e)
		{
			double num1, num2, multiplicacion;
			num1=Convert.ToDouble(txtNum1.Text);
			num2=Convert.ToDouble(txtNum2.Text);
			multiplicacion=num1*num2;
			lblResultado.Text=txtNum1.Text+" * "+txtNum2.Text+" = "+Convert.ToString(multiplicacion);
		}
		
		void BtnDividirClick(object sender, EventArgs e)
		{
			double num1, num2, divicion;
			num1=Convert.ToDouble(txtNum1.Text);
			num2=Convert.ToDouble(txtNum2.Text);
			divicion=num1/num2;
			lblResultado.Text=txtNum1.Text+" / "+txtNum2.Text+" = "+Convert.ToString(divicion);
		}
	}
}
