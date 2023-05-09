using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Q5
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

        // Point N°1 (déclaration ValNumUnicode)
        string ValNumUnicode = "\0031".ToString();

        // Point N°2 (méthode CalculerEchantillon)
        private void CalculerEchantillon(short Amp, ref float[] tbEchantillon)
        {
            // Point N°4 (itération d'un tableau)
            char[] Array = txtInput.Text.ToCharArray(); // Le code est écrit avec un exemple de textbox qui n'est pas présent dans notre cas
            int nbr = Array.Length;
            int[] tbChar = new int[nbr];
            int i = 0;

            foreach (char element in Array)
            {
                int value = Convert.ToInt32(element);
                tbChar[i] = value;
                i++;

                Console.WriteLine.
            }
        }

        // Point N°3 (déclaration et complément à 1)
        uint valX = 0xFF00FF00;
        valX ~= valX;
    




    }
}
