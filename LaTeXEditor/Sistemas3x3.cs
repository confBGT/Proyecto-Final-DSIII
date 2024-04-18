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
    public partial class Sistemas3x3 : Form
    {
        public Sistemas3x3()
        {
            InitializeComponent();
        }

        public bool IsFormValid()
        {
            if ((txtIndependentTerm1.Text == "") || (txtIndependentTerm2.Text == "") || (txtIndependentTerm3.Text == "") || (txtXcoefficient1.Text == "") || (txtXcoefficient2.Text == "") || (txtXcoefficient3.Text == "") || (txtYcoefficient1.Text == "") || (txtYcoefficient2.Text == "") || (txtYcoefficient3.Text == "") || (txtZcoefficient1.Text == "") || (txtZcoefficient2.Text == "") || (txtZcoefficient3.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        Dictionary<string, double> Solver()
        {
            

            double mainDeterminant = (Convert.ToDouble(txtXcoefficient1.Text) * Convert.ToDouble(txtYcoefficient2.Text) * Convert.ToDouble(txtZcoefficient1.Text)) + (Convert.ToDouble(txtXcoefficient2.Text) * Convert.ToDouble(txtYcoefficient3.Text) * Convert.ToDouble(txtZcoefficient1.Text)) + (Convert.ToDouble(txtXcoefficient3.Text) * Convert.ToDouble(txtYcoefficient1.Text) * Convert.ToDouble(txtZcoefficient2.Text)) - (Convert.ToDouble(txtXcoefficient3.Text) * Convert.ToDouble(txtYcoefficient2.Text) * Convert.ToDouble(txtZcoefficient1.Text)) - (Convert.ToDouble(txtXcoefficient1.Text) * Convert.ToDouble(txtYcoefficient3.Text) * Convert.ToDouble(txtZcoefficient2.Text)) - (Convert.ToDouble(txtXcoefficient2.Text) * Convert.ToDouble(txtYcoefficient1.Text) * Convert.ToDouble(txtZcoefficient3.Text));
            double xDeterminant = (Convert.ToDouble(txtIndependentTerm1.Text) * Convert.ToDouble(txtYcoefficient2.Text) * Convert.ToDouble(txtZcoefficient3.Text)) + (Convert.ToDouble(txtXcoefficient2.Text) * Convert.ToDouble(txtYcoefficient3.Text) * Convert.ToDouble(txtIndependentTerm3.Text)) + (Convert.ToDouble(txtXcoefficient3.Text) * Convert.ToDouble(txtYcoefficient1.Text) * Convert.ToDouble(txtIndependentTerm2.Text)) -(Convert.ToDouble(txtXcoefficient3.Text) * Convert.ToDouble(txtYcoefficient2.Text) * Convert.ToDouble(txtIndependentTerm1.Text)) - (Convert.ToDouble(txtIndependentTerm1.Text) * Convert.ToDouble(txtYcoefficient3.Text) * Convert.ToDouble(txtZcoefficient2.Text)) - (Convert.ToDouble(txtXcoefficient2.Text) * Convert.ToDouble(txtIndependentTerm2.Text) * Convert.ToDouble(txtZcoefficient3.Text));
            double yDeterminant = (Convert.ToDouble(txtXcoefficient1.Text) * Convert.ToDouble(txtIndependentTerm2.Text) * Convert.ToDouble(txtZcoefficient3.Text)) + (Convert.ToDouble(txtIndependentTerm1.Text) * Convert.ToDouble(txtYcoefficient3.Text) * Convert.ToDouble(txtZcoefficient1.Text)) + (Convert.ToDouble(txtXcoefficient3.Text) * Convert.ToDouble(txtYcoefficient1.Text) * Convert.ToDouble(txtIndependentTerm3.Text)) -(Convert.ToDouble(txtXcoefficient3.Text) * Convert.ToDouble(txtIndependentTerm2.Text) * Convert.ToDouble(txtZcoefficient1.Text)) - (Convert.ToDouble(txtXcoefficient1.Text) * Convert.ToDouble(txtYcoefficient3.Text) * Convert.ToDouble(txtIndependentTerm3.Text)) - (Convert.ToDouble(txtIndependentTerm1.Text) * Convert.ToDouble(txtYcoefficient1.Text) * Convert.ToDouble(txtZcoefficient3.Text));
            double zDeterminant = (Convert.ToDouble(txtXcoefficient1.Text) * Convert.ToDouble(txtYcoefficient2.Text) * Convert.ToDouble(txtIndependentTerm3.Text)) + (Convert.ToDouble(txtXcoefficient2.Text) * Convert.ToDouble(txtIndependentTerm2.Text) * Convert.ToDouble(txtZcoefficient1.Text)) + (Convert.ToDouble(txtIndependentTerm1.Text) * Convert.ToDouble(txtYcoefficient1.Text) * Convert.ToDouble(txtZcoefficient2.Text)) -(Convert.ToDouble(txtIndependentTerm1.Text) * Convert.ToDouble(txtYcoefficient2.Text) * Convert.ToDouble(txtZcoefficient1.Text)) - (Convert.ToDouble(txtXcoefficient1.Text) * Convert.ToDouble(txtIndependentTerm2.Text) * Convert.ToDouble(txtZcoefficient2.Text)) - (Convert.ToDouble(txtXcoefficient2.Text) * Convert.ToDouble(txtYcoefficient1.Text) * Convert.ToDouble(txtIndependentTerm3.Text));

            if (mainDeterminant != 0)
            {
                Double xSolution = xDeterminant / mainDeterminant;
                Double ySolution = yDeterminant / mainDeterminant;
                Double zSolution = zDeterminant / mainDeterminant;
                return new Dictionary<string, double> { { "X", xSolution }, { "Y", ySolution }, { "Z", zSolution } };
            }
            else
            {
                Double xSolution = double.NaN;
                Double ySolution = double.NaN;
                Double zSolution = double.NaN;
                return new Dictionary<string, double> { { "X", xSolution }, { "Y", ySolution }, { "Z", zSolution } };
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (IsFormValid() == false)
            {
                MessageBox.Show("Introduzca un numero en todas las casillas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Dictionary<string, double> solutions = Solver();
                if (solutions.ContainsValue(double.NaN))
                {
                    txtSolutions.Text = "Sistema indeterminado, no existen soluciones reales.";
                }
                else
                {
                    string solutionText = "";
                    foreach (var solution in solutions)
                    {
                        solutionText += $"{solution.Key} = {solution.Value}, ";
                    }
                    txtSolutions.Text = solutionText.TrimEnd(',', ' ');
                }


            }
        }
    }
}
