using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //nomer les boutton/checkbox
            rbSignalSinus.Text = "Sinus";
            rbSignalTTL.Text = "TTL";
            cbOffset.Text = "offset";
            //activer le bouton TTL
            rbSignalTTL.Checked = true;
            cbOffset.ForeColor = Color.Gray;
            
        }

        private void CbOffset_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbSignalTTL_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSignalTTL.Checked)
            {
                cbOffset.ForeColor = Color.Gray;
            }
            else
            {
                cbOffset.ForeColor = Color.Black;

            }
        }

        private void RbSignalSinus_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSignalTTL.Checked)
            {
                cbOffset.ForeColor = Color.Gray;
            }
            else
            {
                cbOffset.ForeColor = Color.Black;

            }
        }
    }
}
