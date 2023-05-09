using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Exercice_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtConv_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            txtConv.Text = String.Empty ;
            string Value = txtValue.Text;
            int lengt = Value.Length;

            for (int i = 0; i< lengt; i++)
            {
                char Chartest = Value[i];

                int conbv = Chartest ;

                //int resultHex =int.Parse(conbv.ToString(), NumberStyles.AllowHexSpecifier);

                int resultHex = Convert.ToInt32(Chartest);

                string cvhaine = txtConv.Text + String.Format(" {0:X}", resultHex); 
                

                txtConv.Text = cvhaine;
            }







        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
