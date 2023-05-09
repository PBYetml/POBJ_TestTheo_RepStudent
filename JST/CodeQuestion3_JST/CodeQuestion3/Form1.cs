using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeQuestion3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbSignalTTL.Checked = true;
        }

        private void rbSignalSinus_CheckedChanged(object sender, EventArgs e)
        {
            cbOffset.Enabled = true;
        }
        

        private void rbSignalTTL_CheckedChanged(object sender, EventArgs e)
        {
            cbOffset.Enabled = false;
        }
    }
}
