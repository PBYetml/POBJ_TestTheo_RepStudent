using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_4
{
    public partial class Form1 : Form
    {
        enum e_state {INIT, WAIT, EXECUT };
        public Form1()
        {
            InitializeComponent();
        }
        private void Ex5TestSlo(e_state etat)
        {
            switch(etat)
            {
                case e_state.INIT: 
                System.Console.WriteLine("etat init");
                    break;
                case e_state.WAIT:
                    System.Console.WriteLine("etat wait");
                    break;
                case e_state.EXECUT:
                    System.Console.WriteLine("etat execute");
                    break;
                default:
                    System.Console.WriteLine("pas d'états");

                    break;
            }
        }
    }
}
    

