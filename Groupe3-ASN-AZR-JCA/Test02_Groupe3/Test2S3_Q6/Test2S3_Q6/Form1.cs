using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2S3_Q6
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

        void CalculMoyennePOBJ(ref int nbrNotemax, in float[] ptTbNote, out float moyennne)
        {
            int increment;
            float sommeNote = 0;

            for (increment = 0; increment < nbrNotemax; increment++)
            {
                sommeNote += ptTbNote[increment];
            }
            moyennne = sommeNote / nbrNotemax;
        }
    }
}
