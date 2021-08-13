using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinQuadEquation
{
    public partial class WinQuadEquation : Form
    {
        /*
         * Alexander Summers
         * Calculates the two x-values in the quadratic equation given the three neccessary inputs
         * 11-1-2019
         */
        public WinQuadEquation()
        {
            InitializeComponent();
        }

        private void WinQuadEquation_Load(object sender, EventArgs e) //Runs when the form is loaded
        {
            lblX1.Text = "X\u2081";
            lblX2.Text = "X\u2082";
        }



        private void BtnSolve_Click(object sender, EventArgs e)
        {
             
                double discriminate = Math.Pow(Convert.ToDouble(txtTermA.Text), 2) - 4 * Convert.ToDouble(txtTermA.Text) * Convert.ToDouble(txtTermC.Text);
            double xSol1, xSol2;
            
            {
                if (discriminate >= 0)
                {
                    xSol1 = (-Convert.ToDouble(txtTermB.Text) + Math.Sqrt(discriminate)) / (2 * Convert.ToDouble(txtTermA.Text));
                    xSol2 = (-Convert.ToDouble(txtTermB.Text) - Math.Sqrt(discriminate)) / (2 * Convert.ToDouble(txtTermA.Text));
                    txtSolutionX1.Text = xSol1.ToString("N15");
                    txtSolutionX1.Text = xSol2.ToString("N15");
                }
                else //Imaginary Numbers
                {
                    double beforeSign = -(Convert.ToDouble(txtTermB.Text) / (2 * Convert.ToDouble(txtTermA.Text)));
                    double afterSign = Math.Sqrt(Math.Abs(discriminate)) / (2 * Convert.ToDouble(txtTermA.Text));
                    txtSolutionX1.Text = beforeSign.ToString() + " + " + afterSign.ToString() + " \uD835\uDC56";
                    txtSolutionX2.Text = beforeSign.ToString() + " - " + afterSign.ToString() + " \uD835\uDC56";
                }
                //double numA = Convert.ToDouble(txtTermA.Text);
                //double numB = Convert.ToDouble(txtTermB.Text);
                //double numC = Convert.ToDouble(txtTermC.Text);
            }
        }
        void isValidInput(TextBox txt)
        {
            if (!double.TryParse(txt.Text, out double result) && txt.Text != "")  //If number is invalid
            {
                txt.BackColor = Color.Red;  //A red background connotates an error to users
                MessageBox.Show("Error! This text box doesn't consist of a number", "Error");
                txt.Clear();
                txt.Focus();
                return;
            }
            if (txtTermA.Text != "" && txtTermB.Text != "" && txtTermC.Text != "") //if both of these have text, enable the two buttons.
            {
                btnSolve.Enabled = true;  
                btnReset.Enabled = true;
            }
            else  //...otherwise, don't.
            {
                btnSolve.Enabled = false;
            }
            txt.BackColor = Color.White;  //resets the background color back to its original.
            return;
        }
        //These run when their respective terms are validating
        private void TxtTermA_Validating(object sender, CancelEventArgs e)  
        {
            isValidInput(txtTermA);
        }
        
        private void TxtTermB_TextChanged(object sender, EventArgs e)
        {
            isValidInput(txtTermB);
        }

        private void TxtTermC_TextChanged(object sender, EventArgs e)
        {
            isValidInput(txtTermC);
        }

        private void btnReset_Click(object sender, EventArgs e) //clears both of the textboxes
        {
            txtSolutionX1.Text = "";
            txtSolutionX2.Text = "";

        }
    }
}
