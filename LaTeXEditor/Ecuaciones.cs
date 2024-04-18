using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexEditor
{
	public partial class Ecuaciones : Form
	{
		public Ecuaciones()
		{
			InitializeComponent();
		}

		private void rbQuad_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "1") //este if permite que se seleccione por primera vez el radiobutton sin pedir confirmacion de reestablecer todo. todas las veces siguientes se pedira confirmacion. ver linea 39.
			{
				DialogResult dialogResult = MessageBox.Show("Esta acción reestablecerá todo en esta ventana. ¿Seguro que desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dialogResult == DialogResult.Yes)
				{
					Clear();
				}
				else
				{
					rbCube.Checked = true;
					return;
				}
			}
			txtBoxInputXCube.Enabled = false;
			label4.Visible = true;
			txtBoxOutputX2.Visible = true;
			textBox1.Text = "1"; //hace cumplir lo estipulado en la linea 23
		}

		private void rbCube_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "1")
			{
				DialogResult dialogResult = MessageBox.Show("Esta acción reestablecerá todo en esta ventana. ¿Seguro que desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dialogResult == DialogResult.Yes)
				{
					Clear();
				}
				else
				{
					rbQuad.Checked = true;
					return;
				}
			}
			txtBoxInputXCube.Enabled = true;
			label4.Visible = false;
			txtBoxOutputX2.Visible = false;
			textBox1.Text = "1";
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			//anadir todo al git y al programa general
			//ver si las lineas de comentarios se cumplen todas
			if (rbQuad.Checked || rbCube.Checked) //este if prohibe que se calcule algo si ningun tipo de ecuacion fue seleccionado
			{
				if (rbQuad.Checked)
				{
					if (txtBoxInputXSquare.Text != "0" && txtBoxInputXSquare.Text != "" && txtBoxInputX.Text != "" && txtBoxInputConstant.Text != "") //este if obliga al usuario a insertar todos los parametros y tambien que el del termino mas grande no sea igual a 0
					{
						if (Double.TryParse(txtBoxInputXSquare.Text, out Double a) && Double.TryParse(txtBoxInputX.Text, out Double b) && Double.TryParse(txtBoxInputConstant.Text, out Double c)) //este if con tryparse obliga al usuario a insertar numeros y no otra cosa como letras, ademas ya convierte los string a double para realizar los calculos
						{
							txtBoxOutputType.Text = "Cuadrática";
							txtBoxOutputX1.Text = Convert.ToString(Math.Round((-1 * b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a), 6));
							txtBoxOutputX2.Text = Convert.ToString(Math.Round((-1 * b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a), 6));
						}
						else
						{
							MessageBox.Show("Por favor inserte parámetros válidos.");
						}
					}
					else
					{
						MessageBox.Show("Es obligatorio definir todos los parámetros. El parámetro de x al cuadrado no puede ser 0 para las ecuaciones cuadráticas.");
					}
				}
				if (rbCube.Checked)
				{
					if (txtBoxInputXCube.Text != "0" && txtBoxInputXCube.Text != "" && txtBoxInputXSquare.Text != "" && txtBoxInputX.Text != "" && txtBoxInputConstant.Text != "")
					{
						if(Double.TryParse(txtBoxInputXCube.Text, out Double a) && Double.TryParse(txtBoxInputXSquare.Text, out Double b) && Double.TryParse(txtBoxInputX.Text, out Double c) && Double.TryParse(txtBoxInputConstant.Text, out Double d))
						{
							txtBoxOutputType.Text = "Cúbica";
							double z = (((-1 * Math.Pow(b, 3)) / (27 * Math.Pow(a, 3))) + ((b * c) / (6 * Math.Pow(a, 2))) - (d / (2 * a)));
							double z2 = Math.Pow((((-1 * Math.Pow(b, 3)) / (27 * Math.Pow(a, 3))) + ((b * c) / (6 * Math.Pow(a, 2))) - (d / (2 * a))), 2);
							double y = Math.Pow((c / (3 * a)) - (Math.Pow(b, 2) / (9 * Math.Pow(a, 2))), 3);
							double w = Math.Sqrt(z2 + y);
							double v = cubeRoot(z + w);
							double u = cubeRoot(z - w);
							double t = b / (3 * a);
							txtBoxOutputX1.Text = Convert.ToString(Math.Round(v + u - t, 6));
						}
						else
						{
							MessageBox.Show("Por favor inserte parámetros válidos.");
						}
					}
					else
					{
						MessageBox.Show("Es obligatorio definir todos los parámetros. El parámetro de x al cubo no puede ser 0 para las ecuaciones cúbicas.");
					}
				}
			}
			else
			{
				MessageBox.Show("Por favor escoja un tipo de ecuación antes de comenzar.");
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		public void Clear()
		{
			txtBoxInputXCube.Text = "";
			txtBoxInputXSquare.Text = "";
			txtBoxInputX.Text = "";
			txtBoxInputConstant.Text = "";
			txtBoxOutputType.Text = "";
			txtBoxOutputX1.Text = "";
			txtBoxOutputX2.Text = "";
		}

		public double cubeRoot(double operand)
		{
			if (operand == 0)
			{
				return 0;
			}
			else
			{
				return (Math.Abs(operand) / operand) * Math.Pow(Math.Abs(operand), 1.0 / 3.0);
			}
		}

		private void btnAviso_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Para las ecuaciones cúbicas solo es posible calcular una solución debido a que las otras dos requerirían cálculos con números imaginarios. Además, hay casos que no serán calculables en absoluto debido a las mismas razones. Para las ecuaciones cuadráticas, si una valor da NaN significa que esta sería una solución compleja.");
		}
	}
}

