using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2S3_Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CbOffset.Text = "Offset";
            RbSignalSinus.Text = "Sinus";
            RbSignalTTL.Text = "TTL";
            RbSignalTTL.Checked = true;
        }

        private void RbSignalSinus_CheckedChanged(object sender, EventArgs e)
        {
            CbOffset.Enabled = true;
        }

        private void RbSignalTTL_CheckedChanged(object sender, EventArgs e)
        {
            CbOffset.Enabled = false;
        }

        private void CbOffset_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
