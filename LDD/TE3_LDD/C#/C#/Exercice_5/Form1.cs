using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice_5
{
    public partial class Form1 : Form
    {
        int[] m_tabBin = new int[4];
        public Form1()
        {
            InitializeComponent();
            m_tabBin[0] = 0;
            m_tabBin[1] = 0;
            m_tabBin[2] = 0;
            m_tabBin[3] = 0;
        }

        private void Btncalcul_Click(object sender, EventArgs e)
        {
            int Angle = int.Parse(txtangle.Text);
            txtsinus.Text = CalculSin(Angle).ToString() ;

        }






        double CalculSin (double Angle)
        {
            Angle = Math.Sin(Angle);
            return Angle;
        }

        private void Btnbit1_Click(object sender, EventArgs e)
        {
            ToggleBit(0);
            btnbit1.Text = m_tabBin[0].ToString();
            DispDecimal();
        }

        private void Btnbit2_Click(object sender, EventArgs e)
        {
            ToggleBit(1);
            btnbit2.Text = m_tabBin[1].ToString();
            DispDecimal();
        }

        private void Btnbit3_Click(object sender, EventArgs e)
        {
            ToggleBit(2);
            btnbit3.Text = m_tabBin[2].ToString();
            DispDecimal();
        }

        private void Btnbit4_Click(object sender, EventArgs e)
        {
            ToggleBit(3);
            btnbit4.Text = m_tabBin[3].ToString();
            DispDecimal();
        }
        void ToggleBit (int Index)
        {
            if (m_tabBin[Index] == 1)
            {
                m_tabBin[Index] = 0;
            }
            else
            {
                m_tabBin[Index] = 1;
            }

        }
        void DispDecimal()
        {
            int Value;
            Value = 0;
            if (m_tabBin[0] == 1)
            {
                Value = Value + 1;
            }
            if (m_tabBin[1] == 1)
            {
                Value = Value + 2;
            }
            if (m_tabBin[2] == 1)
            {
                Value = Value + 4;
            }
            if (m_tabBin[3] == 1)
            {
                Value = Value + 8;
            }

            txtresult.Text = Value.ToString();

        }
    }
}

