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
    public partial class Sistemas2x2 : Form
    {
        public Sistemas2x2()
        {
            InitializeComponent();
        }

        public bool IsFormValid()
        {
            if ((txtIndependentTerm1.Text == "") || (txtIndependentTerm2.Text == "") || (txtXcoefficient1.Text == "") || (txtXcoefficient2.Text == "") || (txtYcoefficient1.Text == "") || (txtYcoefficient2.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        (Double, Double) Solver()
        {
            Double mainDeterminant = (Convert.ToDouble(txtXcoefficient1.Text)) * (Convert.ToDouble(txtYcoefficient2.Text)) - (Convert.ToDouble(txtYcoefficient1.Text)) * (Convert.ToDouble(txtXcoefficient2.Text));
            Double xDeterminant = (Convert.ToDouble(txtIndependentTerm1.Text)) * (Convert.ToDouble(txtYcoefficient2.Text)) - (Convert.ToDouble(txtYcoefficient1.Text)) * (Convert.ToDouble(txtIndependentTerm2.Text));
            Double yDeterminant = (Convert.ToDouble(txtXcoefficient1.Text)) * (Convert.ToDouble(txtIndependentTerm2.Text)) - (Convert.ToDouble(txtIndependentTerm1.Text)) * (Convert.ToDouble(txtXcoefficient2.Text));
            if (mainDeterminant != 0)
            {
                Double xSolution = xDeterminant / mainDeterminant;
                Double ySolution = yDeterminant / mainDeterminant;
                return (xSolution, ySolution);
            }
            else
            {
                Double xSolution = double.NaN;
                Double ySolution = double.NaN;
                return (xSolution, ySolution);
            }
        }
       

        private void btnSolve_Click(object sender, EventArgs e)
        {
            if(IsFormValid() == false)
            {
                MessageBox.Show("Introduzca un numero en todas las casillas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                (double x, double y) = Solver();
                if (x == double.NaN || y == double.NaN)
                {
                    txtSolutions.Text = ("Sistema indeterminado, no existen soluciones reales.");
                }
                else
                {
                    txtSolutions.Text = ($"X = {x}, Y = {y}");
                }

            }
        }
    }
}
