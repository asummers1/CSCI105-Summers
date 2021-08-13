using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuSystem_summersa
{
    public partial class BMICalculator : Form
    {

        /*
         * Alexander Summers
         * Calculates BMI based on the BMI formula
         */
        public BMICalculator()
        {
            InitializeComponent();
        }
        double BMI = 1;
        private void BMIClick(object sender, EventArgs e)
        {
           
            Button btn = (Button)sender;
            if (btn.Tag == "Calculate")
            {
                double bmiheight = (Convert.ToDouble(txtHeightFeet.Text) * 12) + Convert.ToDouble(txtHeightInches.Text);  //Converts all BMI height inputs to inches
                BMI = (Convert.ToDouble(txtWeight.Text) * 703) / (bmiheight * bmiheight);  //Calculates BMI
                lblBMISolution.Text = Convert.ToString(Math.Round(BMI,2));  //Puts BMI in a label
            }
            if (btn.Tag == "Reset")
            {
                txtHeightFeet.Text = txtHeightInches.Text = txtWeight.Text = ""; //Resets all textboxes to empty values
            }
        }
        private bool ValidInput(TextBox txtbox)  //Checks for valid input
        {
            {
                if (!int.TryParse(txtbox.Text, out int result) || Convert.ToInt32(txtbox.Text) < 0)
                {
                    return false;

                }
                
                else
                {
                    return true;
                }
            }
        }

       

        private void txtChecker(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
           
            if (ValidInput(txtHeightFeet) && ValidInput(txtHeightInches) && ValidInput(txtWeight))
            {
                btnCompute.Enabled = true;
            }
            else
            {
                btnCompute.Enabled = false;
            }
        }

        
    }
}
