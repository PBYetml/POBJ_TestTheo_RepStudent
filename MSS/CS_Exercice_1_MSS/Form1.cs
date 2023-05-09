using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Exercice_1
{
    public partial class Form1 : Form
    {
        bool enableConv = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void conversion()
        {
            if (enableConv)
            {
                double Montant = double.Parse(txtMontant.Text);

                double Resultat = 0;

                if (rbnCHF.Checked)
                    Resultat = Montant;
                if (rbnUSD.Checked)
                    Resultat = Montant * 0.91;
                if (rbnGBP.Checked)
                    Resultat = Montant * 1.12;
                if (rbnYEN.Checked)
                    Resultat = Montant * 0.0071;

                txtResultat.Text = Resultat.ToString();
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enableConv = true;
            conversion();
        }

        private void rbnCHF_CheckedChanged(object sender, EventArgs e)
        {
            picDevise.Image = Properties.Resources.Flag_of_Switzerland;
            conversion();
        }

        private void rbnUSD_CheckedChanged(object sender, EventArgs e)
        {
            picDevise.Image = Properties.Resources.Flag_of_the_United_States;
            conversion();
        }

        private void rbnGBP_CheckedChanged(object sender, EventArgs e)
        {
            picDevise.Image = Properties.Resources.Flag_of_the_United_Kingdom;
            conversion();
        }

        private void rbnYEN_CheckedChanged(object sender, EventArgs e)
        {
            picDevise.Image = Properties.Resources.Flag_of_Japan;
            conversion();
        }
    }
}
