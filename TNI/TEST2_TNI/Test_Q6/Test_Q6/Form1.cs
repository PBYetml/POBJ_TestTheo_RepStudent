using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Q6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void CalculMoyennePOBJ(int nbrNotemax, float ptTbNote, out float moyenne)
        {
            int increment;
            float sommeNote = 0;

            for (increment = 0; increment < *nbrNotemax; increment ++)
            {
                sommeNote += ptTbNote[increment];
            }

            *moyenne = sommeNote / *nbrNotemax;
        }

        public void CalculMoyennePOBJ(int nbrNotemax, float ptTbNote, ref float moyenne)
        {
            int increment;
            float sommeNote = 0;

            for (increment = 0; increment < *nbrNotemax; increment++)
            {
                sommeNote += ptTbNote[increment];
            }

            *moyenne = sommeNote / *nbrNotemax;
        }
    }
}
