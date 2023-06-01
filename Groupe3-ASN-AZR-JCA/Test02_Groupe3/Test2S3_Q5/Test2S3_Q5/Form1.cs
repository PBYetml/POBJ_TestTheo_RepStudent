using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#pragma warning disable CS0219 // La variable est assignée mais sa valeur n'est jamais utilisée

namespace Test2S3_Q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            /*  Premier point   */
            short ValNumUnicode;
            char ValCharUnicode = '\u0031';
            ValNumUnicode = (short)ValCharUnicode;

            /*  Troisième point */
            uint valX = 0xFF00FF00;
            valX = ~valX;

            /*  Quatrième point   */
            char[] tbChar = {};

            foreach(char c in tbChar)
            {
                Console.Write("{0}", c);
            }
        }

        /*  Deuxième point   */
        private void CalculerEchantillon(sbyte Amp, float[] tbEchantillon)
        {

        }
    }
}
