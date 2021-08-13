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
    /*
     * Alexander Summers
     * This application provides an assortment of calculatorsm including a
     * BMI calculator and a factorial calculator.
     * I have used these six control types: Labels, TextBoxes, GroupBoxes, FlowLayout Panels, PictureBoxes, and Buttons.
     * 10/28/2019
     */
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void OptionClick(object sender, EventArgs e) //This checks if a person clicked a particular button by checking the tag.
        { //On all of these, it checks the tag, makes the form object, and then shows it.
            Button clickedbutton = (Button)sender;
            if (clickedbutton.Tag == "BMI Calculator")
            {
                BMICalculator bmiform = new BMICalculator();  
                bmiform.Show();

            }
            if (clickedbutton.Tag == "Quadratic")
            {
                
                WinQuadEquation.WinQuadEquation WinQuad = new WinQuadEquation.WinQuadEquation();
                WinQuad.Show();
            }
            if (clickedbutton.Tag == "Distance Formula")
            {
                DistanceFormula distform = new DistanceFormula();
                distform.Show();
            }
            if (clickedbutton.Tag == "Factorials")
            {
                Factorial fact = new Factorial();
                fact.Show();
                    }
            if (clickedbutton.Tag == "Battle Damage")
            {
                Battle_Damage.Form1 battledamage = new Battle_Damage.Form1();
                battledamage.Show();
            }
        }
    }
}
