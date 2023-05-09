// -- TEST2 SLO QUESTION 3 --//
// -- Miguel Santos --//

// Chemin d'accès :
// O:\APPLICATIONS\Echanges_Eleves\ES\SLO2\Santos_Miguel\Epreuves\POBJ\TEST2_27-04-23_MSS

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2SLO_MSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbSignalSinus.Text = "Sinus";
            rbSignalSinus.Checked = false;

            rbSignalTTL.Text = "TTL";
            rbSignalTTL.Checked = true;

            cbOffset.Text = "Offset";
            cbOffset.Enabled = rbSignalSinus.Checked;
        }

        private void rbSignalSinus_CheckedChanged(object sender, EventArgs e)
        {
            cbOffset.Enabled = rbSignalSinus.Checked;
        }

        public void CalculMoyennePOBJ(ref int nbrNoteMax, ref float [] ptTbNote, out float moyenne)
        {
            //-- Déclaration variable --//
            int increment;
            float sommeNote = 0;
            for (increment = 0; increment < nbrNoteMax; increment++)
                sommeNote += ptTbNote[increment];

            moyenne = sommeNote / nbrNoteMax;
        }
    }
}
