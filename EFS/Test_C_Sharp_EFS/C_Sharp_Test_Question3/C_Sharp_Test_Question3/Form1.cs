using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Test_Question3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Changement de texte des radio boutons et checkbox
            rbSignalSinus.Text = "Sinus";
            rbSignalTTL.Text = "TTL";
            cbOffset.Text = "offset";

            // Sélection par défaut du radiobouton du signal TTL
            rbSignalTTL.Checked = true;

            // Desactivation du checkbox offset
            if(rbSignalTTL.Checked == true)
            {
                cbOffset.Enabled = false;
            }
        }

        private void RbSignalSinus_CheckedChanged(object sender, EventArgs e)
        {
            if(rbSignalSinus.Checked == true)
            {
                cbOffset.Enabled = true;
            }
            else
            {
                cbOffset.Enabled = false;
            }
        }
    }
}
