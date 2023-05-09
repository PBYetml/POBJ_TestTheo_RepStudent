using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Exercice_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            stPersonnes.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void StPersonnes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DomainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] Value = new string[3];
            Value[0] = stPersonnes.Text;
            if(rRueNumber.Value != 0)
            {
                Value[1] = RueName.Text + rRueNumber.Text;
            }
            else
            {
                Value[1] = RueName.Text ;
            }
            
            Value[2] = NomVille.Text;
            textBox1.Lines = Value;
        }
    }
}
