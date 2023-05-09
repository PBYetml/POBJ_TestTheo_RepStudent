using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice_5b
{
    public partial class Form1 : Form
    {
        //création du tableau pour avoir la valeur binaire 
        int[] m_tableau = new int[5];
        int bitnub;


        public Form1()
        {
            InitializeComponent();
            //initialisation du tableau avec valeur binaire 00000
            m_tableau[0] = 0;
            m_tableau[1] = 0;
            m_tableau[2] = 0;
            m_tableau[3] = 0;
            m_tableau[4] = 0;
        }

        private void Btnextract_Click(object sender, EventArgs e)
        {
            byte Value;

            short valhex = Convert.ToInt16(txtvalhex.Text, 16);
            //prise du premier byte
            Extract(valhex, out Value);
            // écrture de LSB
            txtlsb.Text = String.Format(" {0:X}", Value);
            //décalage de  byte afin d'avoir la deuxième partie du message
            valhex = (short)(valhex >> 8);
            //extraire le premier byte
            Extract(valhex, out Value);
            //écriture du MSB en hexadécimale
            txtmsb.Text = String.Format(" {0:X}", Value);

        }
        void Extract(short Valhex, out byte Value)
        {
            //transformation de la valeur en byte
            Value = (byte)Valhex;
        }

        private void Btnpermuter_Click(object sender, EventArgs e)
        {
            //appelle la méthode qui permet de permuter les deux texts
            Permute(ref txtvala, ref txtvalb);
        }
        private void Permute(ref TextBox ValA, ref TextBox ValB)
        {
            //sauvegarde première zone de texte 
            string save = ValA.Text;
            //écriture deuxième zone de texte dans première zone de texte 
            ValA.Text = ValB.Text;
            //écrirue de la première zone de texte dans la deuxième 
            ValB.Text = save;
        }

        private void Btnbit4_Click(object sender, EventArgs e)
        {
            

            bitnub = 4;
            GestionBit(ref m_tableau, ref bitnub);
            btnbit4.Text = m_tableau[4].ToString();

        }

        private void Btnbit3_Click(object sender, EventArgs e)
        {
            

            bitnub = 3;
            GestionBit(ref m_tableau, ref bitnub);
            btnbit3.Text = m_tableau[3].ToString();
        }

        private void Btnbit2_Click(object sender, EventArgs e)
        {
            bitnub = 2;
            GestionBit(ref m_tableau, ref bitnub);
            btnbit2.Text = m_tableau[2].ToString();
        }

        private void Btnbit1_Click(object sender, EventArgs e)
        {
            bitnub = 1;
            GestionBit(ref m_tableau, ref bitnub);
            btnbit1.Text = m_tableau[1].ToString();
        }

        private void Btnbit0_Click(object sender, EventArgs e)
        {
            bitnub = 0;
            GestionBit(ref m_tableau, ref bitnub);
            btnbit0.Text = m_tableau[0].ToString();
        }
        void GestionBit(ref int[] m_tableau ,ref int Bitnub )
        {
            if(m_tableau[Bitnub] ==  0)
            {
                m_tableau[Bitnub] = 1;
            }
            else
            {
                m_tableau[Bitnub] = 0;
            }
            
            DeiDecimal(ref m_tableau);

        }
        void DeiDecimal(ref int[] m_tableau)
        {
            int value = 0;

            if (m_tableau[0] ==1)
            {
                value = value + 1;
            }
            if (m_tableau[1] == 1)
            {
                value = value + 2;
            }
            if (m_tableau[2] == 1)
            {
                value = value + 4;
            }
            if (m_tableau[3] == 1)
            {
                value = value + 8;
            }
            if (m_tableau[4] == 1)
            {
                value = value + 16;
            }
            txtresult.Text = String.Format(" {0:X}", value);
        }
    }
}
