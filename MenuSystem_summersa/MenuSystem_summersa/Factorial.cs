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
    public partial class Factorial : Form
    {
        /*
         * Alexander Summers
         * Calculates the inputted number times all of the whole numbers under it down to zero
         * 11-1-2019
         */
        public Factorial()
        {
            InitializeComponent();
           
        }

        private void FactorialClick(object sender, EventArgs e) //event handler for all buttons
        {
            Button btn = (Button)sender;
            if (btn.Tag == "Compute")  //Checks whether the clicked button is labeled "Compute"
            {
                int solution = 1;
                for (int i = Convert.ToInt32(txtFactorial.Text); i > 0; i--)  //Multiplies each number that is equal to one and less than or equal to the contents of the textbox
                {
                    solution *= i;
                }
                lblSolution.Text = Convert.ToString(solution);
            }
            else if (btn.Tag == "Reset") //checks whether the clicked button is tagged "Reset"
            {
                txtFactorial.Text = "";
            }
            
        }

       
        private void ValidInput(TextBox txtbox)  //Checks for valid input. This doesn't return a boolean as the others because there is only one textbox to check. Otherwise, the program has to hold the information from multiple textboxes.
        {
            
            {
                if (!int.TryParse(txtbox.Text, out int result))  //checks if the textbox text is an integer. Button enables if that is the case.
                {
                    MessageBox.Show("Please enter in a whole number into the textbox.");
                    btnCompute.Enabled = false; 
                }
                else
                {
                    btnCompute.Enabled = true;  //Only activates if textbox contains valid integer
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e) //clears the textbox
        {
            txtFactorial.Text = "";
        }

        private void TxtAccurateInput(object sender, EventArgs e)
        {
            ValidInput(txtFactorial); //runs the input validator. 
        }
    }
}
