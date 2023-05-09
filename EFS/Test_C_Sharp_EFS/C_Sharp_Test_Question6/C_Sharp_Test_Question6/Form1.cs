using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Test_Question6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Fonction question 6
        public void CalculMoyennePOBJ(ref int nbrNoteMax, ref float[] TbNote, out float moyenne)
        {
            // Déclaraton de variable
            int increment;
            float sommeNote = 0;

            for (increment = 0; increment < nbrNoteMax; increment++)
            {
                sommeNote += TbNote[increment];
            }

            moyenne = sommeNote / nbrNoteMax;
        }
    }

    

}
