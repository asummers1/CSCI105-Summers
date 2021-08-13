using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Alexander Summers
 * Calculates battle damage based on user-inputted doubles.
 * 10-3-2019
 * */
namespace Battle_Damage
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            double AttackPower = Convert.ToDouble(txtAttackPower.Text);   //lines 27-30 convert all of the textbox info to doubles
            double WeaponDamage = Convert.ToDouble(txtWeaponDamage.Text);
            double WeaponSpeed = Convert.ToDouble(txtWeaponSpeed.Text);
            double DamageMult = Convert.ToDouble(txtDamMult.Text);

          
            if (WeaponDamage < 10 || WeaponDamage > 500)  //these if-statements check if the values are in the accepted ranges
            {

                MessageBox.Show("Please make sure that your weapon damage is between 10 and 500.", "Error");
                
            }
            if (AttackPower < 1 || AttackPower > 10)
            {
                MessageBox.Show("Please make sure that your attack power is between 1 and 10.", "Error");
               
            }
            if (WeaponSpeed < 1.0 || WeaponSpeed > 5.0)
            {
                MessageBox.Show("Please make sure your weapon speed is between 1.0 and 5.0.", "Error");
                
            }
            if (DamageMult < 1.0 || DamageMult > 4.0)
            {

                MessageBox.Show("Please make sure your damage multiplier is between 1 and 4.", "Error");

            }
            else
            {
  
                
                double numDamage = (Convert.ToDouble(txtWeaponDamage.Text) + Convert.ToDouble(txtAttackPower.Text) / 3.5 * Convert.ToDouble(txtWeaponSpeed.Text)) * Convert.ToDouble(txtDamMult.Text);  //this else statement converts input to...
                numDamage = Math.Round(numDamage, 2); //...a string, which is then set as the text of a label.
                string Damage = Convert.ToString(numDamage);
                lblBatDamDisp.Text = (Damage);
            }
        }
        private bool ValidInput(TextBox txtbox)  
        {
            
            {
               
                if (!double.TryParse(txtbox.Text, out double result)) //Checks each textbox for valid input
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        void txtChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            
            if (ValidInput(txtAttackPower) && ValidInput(txtDamMult) && ValidInput(txtWeaponDamage) && ValidInput(txtWeaponSpeed))  //Checks whether all of the inputs are valid. Button only enables if this is the case
            {
                btnCompute.Enabled = true;
            }
            else
            {
                btnCompute.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)  //checks if the reset button is clicked
       {
            txtAttackPower.Text = txtDamMult.Text = txtWeaponDamage.Text = txtWeaponSpeed.Text = ""; //resets all text fields when the button is clicked
        }

        
    }
}


