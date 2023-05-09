using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Q4
{
    public partial class Form1 : Form
    {
        // Enumération e_states
        enum e_states { INIT, WAIT, EXECUT };

        public Form1()
        {
            InitializeComponent();
        }

        private void Ex5TestSlo (e_states Etat)
        {
            switch (Etat)
            {
                case e_states.INIT:
                    System.Console.WriteLine("Activation Etat Initialisation");
                    break;

                case e_states.WAIT:
                    System.Console.WriteLine("Activation Etat Attente");
                    break;

                case e_states.EXECUT:
                    System.Console.WriteLine("Activation Etat Execution");
                    break;

                default:
                    System.Console.WriteLine("Pas d'état activé");
                    break;
            }
        }

      
    }
}
