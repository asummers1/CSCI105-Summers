using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterGenerator
{
    /*
     * Alexander Summers
     * This program is a character generator. It takes information given to it and gives back character data, including stats.
     * 12-7-2019
     */
    public partial class CharacterGenerator : Form
    {
        CharacterData firstcharacter = new CharacterData();
        
      
        
        
        public CharacterGenerator()
        {
            InitializeComponent();
        }
       

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to save your character?", "Save Confirmation", MessageBoxButtons.YesNo); //Save confirmation
            if (result == DialogResult.Yes)
            {

                File.WriteAllText("CharacterData.csv", "");  //Clears out the characterData file. We don't want old data and new save info to be in the same file; we want it to be overwritten
                using (StreamWriter streamWriter = new StreamWriter("CharacterData.csv")) //This 'using' statement correctly deals with the streamWriter IDisposable object
                { //The following lines write data from text fields and comboboxes into the file, courtesy of the streamWriter.
                    streamWriter.WriteLine(txtName.Text);
                    streamWriter.WriteLine(cbxGender.SelectedIndex);
                    streamWriter.WriteLine(cbxRace.SelectedIndex);
                    streamWriter.WriteLine(cbxJob.SelectedIndex);
                }
            }
            else
            {
                return;  //If the user chooses something other than "yes," nothing occurs
            }
        }

        private void CharacterGenerator_Load(object sender, EventArgs e)
        {
            if (!File.Exists("CharacterData.csv")) //Error handling if the file doesn't exist
            {
                File.Create("CharacterData.csv");
            }
            using (StreamReader strmReader = new StreamReader("CharacterData.csv"))
            {
                try
                { //These lines read from the csv file, and set the info to the appropriate textboxes/comboboxes as well as the object properties
                    firstcharacter.CharacterName = txtName.Text = strmReader.ReadLine();
                    firstcharacter.CharacterGender = cbxGender.SelectedIndex = Convert.ToInt16(strmReader.ReadLine());
                    firstcharacter.CharacterRace = cbxRace.SelectedIndex = Convert.ToInt16(strmReader.ReadLine());
                    firstcharacter.CharacterJob = cbxJob.SelectedIndex = Convert.ToInt16(strmReader.ReadLine());

                }
                catch (InvalidOperationException) //If a line is blank or otherwise not parsed correctly, this part of the program ends and the remainder of the properties are set with their default values
                {
                    return;
                }
            }
            StatSet();
            PortraitAssigner();


        }
        void StatSet()
        {
            switch (cbxJob.SelectedIndex) //Checks the player's character occupation choice (point totals are out of 50).
            {
                case 0:
                    pointAssigner("Warrior", 10, 5, 10, 3, 2, 1, 6, 7, 4, 2);

                    break;
                case 1: 
                    pointAssigner("Scientist", 1, 5, 3, 10, 7, 4, 6, 10, 4, 10);
                    break;
                case 2: //Priest choice
                    pointAssigner("Priest", 1, 5, 3, 7, 10, 10, 5, 7, 2, 1);
                    break;
            }
        }
        void pointAssigner(string charactertype, byte Strength, byte Dexterity, byte Constitution, byte Intelligence, byte Wisdom, byte Charisma,
            byte Endurance, byte Perception, byte Agility, byte Luck)
        {
            if (cbxGender.SelectedIndex == 0)  //Gives a strength boost if character is a man
            {
                lblStrength.Text = Convert.ToString(Strength + 2);
                lblAgility.Text = Convert.ToString(Agility);
            }
            else  //Gives an agility boost if the character is a woman
            {
                lblStrength.Text = Convert.ToString(Strength);
                lblAgility.Text = Convert.ToString(Agility + 2);
            }
            lblDexterity.Text = Convert.ToString(Dexterity);
            lblConstitution.Text = Convert.ToString(Constitution);
            lblIntelligence.Text = Convert.ToString(Intelligence);
            lblWisdom.Text = Convert.ToString(Wisdom);
            lblCharisma.Text = Convert.ToString(Charisma);
            lblEndurance.Text = Convert.ToString(Endurance);
            lblPerception.Text = Convert.ToString(Perception);
            lblLuck.Text = Convert.ToString(Luck);
            

          
            /* This code should be commented out in release
            List<byte> allpointtotals = new List<byte>();
            allpointtotals.AddRange(new byte[] {Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma,
            Endurance, Perception, Agility, Luck});
            
            OverflowException overflow = new OverflowException($"The point totals of all of the stats in {charactertype} needs to equal 50.");
            byte total = 0, elementcounter = 0;
            
            foreach (byte num in allpointtotals) //This loop checks if each of the point values adds up to 50. The player should never see this as he/she never modifies them themselves; it's more useful for me as a developer...
            {                                    //...I'm keeping this in the end product in the case I want to add more jobs in the future. I don't want to have to re-add this; un-commenting it is preferable
               
                if (total > 50)
                {
                    throw overflow; //If total exceeds the total max allocation, this is thrown
                }
                bool test = elementcounter == allpointtotals.Count && total != 50;

                total += num;
                elementcounter++;
                
            }
            if (elementcounter == allpointtotals.Count && total < 50) 
            {
                throw overflow;
            }
            */


        }

        private void cbxJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatSet(); //The StatSet method is run, which sets the character attributes according to the job chosen
        }
        void PortraitAssigner()
        {

            if (cbxGender.SelectedIndex == 0 && cbxRace.SelectedIndex == 0) //Human male
            {
                pctCharacterPortrait.Image = Properties.Resources.HumanMan;
            }
            else if (cbxGender.SelectedIndex == 1 && cbxRace.SelectedIndex == 0) //Human woman
            {
                pctCharacterPortrait.Image = Properties.Resources.HumanWoman;
            }
            else if (cbxGender.SelectedIndex == 0 && cbxRace.SelectedIndex == 1)
            {
                pctCharacterPortrait.Image = Properties.Resources.ReptileMan;
            }
            else if (cbxGender.SelectedIndex == 1 && cbxRace.SelectedIndex == 1)
            {
                pctCharacterPortrait.Image = Properties.Resources.ReptileWoman;
            }

            
        }

        private void cbxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            PortraitAssigner();
        }

        private void cbxRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            PortraitAssigner();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to reset your character?", "Reset Confirmation", MessageBoxButtons.YesNo); //Save confirmation
            if (result == DialogResult.Yes)
            {
                txtName.Text = "";
                cbxGender.SelectedIndex = 0;
                cbxRace.SelectedIndex = 0;
                cbxJob.SelectedIndex = 0;


                File.WriteAllText("CharacterData.csv", "");  //Clears out the characterData file. We don't want old data and new save info to be in the same file; we want it to be overwritten


                using (StreamWriter streamWriter = new StreamWriter("CharacterData.csv")) //This 'using' statement correctly deals with the streamWriter IDisposable object
                { //The following lines write data from text fields and comboboxes into the file, courtesy of the streamWriter.
                    streamWriter.WriteLine(txtName.Text);
                    streamWriter.WriteLine(cbxGender.SelectedIndex);
                    streamWriter.WriteLine(cbxRace.SelectedIndex);
                    streamWriter.WriteLine(cbxJob.SelectedIndex);
                }
            }
            else
            {
                return;  //If the user chooses something other than "yes," nothing occurs
            }
        }
    }
}