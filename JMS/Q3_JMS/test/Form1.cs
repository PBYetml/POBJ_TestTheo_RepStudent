using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbSignalSinus.Text = "Sinus";
            rbSignalTTL.Text = "TTL";
            cbOffset.Text = "offset";

        }

        private void RbSignalSinus_CheckedChanged(object sender, EventArgs e)
        {
            cbOffset.Enabled = true;

        }

        private void RbSignalTTL_CheckedChanged(object sender, EventArgs e)
        {
            cbOffset.Enabled = false;

        }

        private void CbOffset_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
