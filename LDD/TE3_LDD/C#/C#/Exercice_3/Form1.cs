using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice_3
{
    public partial class Form1 : Form
    {
        short[] TableauTest = new short[100];
        public Form1()
        {
            InitializeComponent();
            
            for (int i = 0; i<100;i++)
            {
                
                TableauTest[i] = (short)(i * 10) ;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnTest1_Click(object sender, EventArgs e)
        {
            int tmpVal = 0xff;
            int TestVaulue;
            


            if (int.TryParse(txtValue.Text, out tmpVal)== true)
            {
                TestVaulue = int.Parse(txtValue.Text);
                if(TestVaulue == 0)
                {
                    txtResult.Text = "Valeur = 0";
                }
                else if (TestVaulue < 0)
                {
                    txtResult.Text = "Valeur < 0";
                }
                else if (TestVaulue > 0)
                {
                    txtResult.Text = "Valeur > 0";
                }

            }
            else
            {
                txtResult.Text = "Valeur dépasse 16 bits !";
            }
        }

        private void BtnDiviser_Click(object sender, EventArgs e)
        {
            int TestVaulue;
            int ValueDiv;
            int ValueRest;
            TestVaulue = int.Parse(txtValue.Text);

            ValueDiv = TestVaulue / 2;
            txtResult.Text = ValueDiv.ToString();

            ValueRest = TestVaulue % 2;
            txtRest.Text = ValueRest.ToString();
        }
        
        private void BtnAffîcher_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtIndice.Text.ToString()) < 100)
            {
                txtVali.Text = TableauTest[int.Parse(txtIndice.Text.ToString())].ToString();
            }
            else
            {
                txtVali.Text = "Indice??";
            }

        }
    }
}
