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
            char ValNumUnicode = '\u0031';

            /*  Troisième point */
            uint valX = 0xFF00FF00;
            valX = ~valX;

            /*  Quatrième point   */
            char tbChar[];
        }

        /*  Deuxième point   */
        private void CalculerEchantillon(sbyte Amp, float tbEchantillon[])
        {

        }
    }
}
