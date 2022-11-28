using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterGenerator
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        /*
         * Alexander Summers
         * Splash screen for my program
         * 12-7-2019
         */
        private void btnStart_Click(object sender, EventArgs e)
        {
            
            CharacterGenerator form = new CharacterGenerator();
            
            form.Show();
            

        }

        
    }
}
