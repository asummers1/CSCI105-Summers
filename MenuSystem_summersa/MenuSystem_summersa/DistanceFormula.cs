using System;
using System.Windows.Forms;

namespace MenuSystem_summersa
{
    /*
     * Alexander Summers
     * Calculates the distance between two points using the distance formula
     * 11-1-2019
     */
    public partial class DistanceFormula : Form
    {
        public DistanceFormula()
        {
            InitializeComponent();
        }


        private bool ValidInput(TextBox txtbox)  //Checks for valid input
        {

            {
                if (!int.TryParse(txtbox.Text, out int result))
                {

                    return false;
                }
                else 
                {
                    return true;
                }
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double x1, x2, y1, y2;
            x1 = Convert.ToDouble(txtX1.Text); 
            x2 = Convert.ToDouble(txtX2.Text); 
            y1 = Convert.ToDouble(txtY1.Text); 
            y2 = Convert.ToDouble(txtY2.Text);
            string solution = Convert.ToString(ComputeDistance(x1, y1, x2, y2));  
            lblSolution.Text = solution;

        }

       

        

        private void txtChanged(object sender, EventArgs e)  //Checks for valid input upon the change of any textbox contents
        {
            TextBox txt = (TextBox)sender;
            ValidInput(txt);
            if (ValidInput(txtX1) && ValidInput(txtX2) && ValidInput(txtY1) && ValidInput(txtY2))
            {
                btnCompute.Enabled = true;
            }
            else
            {
                btnCompute.Enabled = false;
            }
        }

        /// <summary>
        /// This is where the distance formula is used to calculate the solution.
        /// </summary>
        /// <param name="x1">First x-value</param>
        /// <param name="y1">First y-value</param>
        /// <param name="x2">Second x-value</param>
        /// <param name="y2">Second y-value</param>
        /// <returns></returns>
        double ComputeDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)), 2);
        }
        
    }
}
