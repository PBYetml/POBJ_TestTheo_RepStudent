using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_6
{
    public partial class Form1 : Form
    {
        float moyenne = 10;
        public Form1()
        {
            InitializeComponent();
        }
        void CalculMoyennePOBJ(ref int nbrnotemax,ref float[] ptTbNote,out float moyenne)
        {
            float SommeNote = 0;


            for (int increment = 0; increment < nbrnotemax; increment++)
            {
                SommeNote += ptTbNote[increment];
            }
            moyenne = SommeNote / nbrnotemax;


        }


    }
}
