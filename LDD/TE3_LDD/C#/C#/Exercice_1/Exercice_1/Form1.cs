using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice_1
{
    public partial class Form1 : Form
    {
        public double TauxChange = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double Montant = double.Parse(TextIn.Text);
            double Resultat;
            Resultat = Montant * TauxChange;
            TextOut.Text = Resultat.ToString();

        }
        private void Resultat_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            TauxChange = 0.91 ;
            pictureBox1.Image = imageList1.Images[3];
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            TauxChange = 1.12;
            pictureBox1.Image = imageList1.Images[1];
        }

        private void RadBtnCH_CheckedChanged(object sender, EventArgs e)
        {
            TauxChange = 1;
            pictureBox1.Image = imageList1.Images[0];
            radBtnCH.e
        }

        private void RadBtnJP_CheckedChanged(object sender, EventArgs e)
        {
            TauxChange = 0.0071;
            pictureBox1.Image = imageList1.Images[2];
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
