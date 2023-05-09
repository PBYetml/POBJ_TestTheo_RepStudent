using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbOffset.Text = "offset";
            cbOffset.Enabled = false;
            rbSignalSinus.Text = "Sinus";
            rbSignalTTL.Text = "TTL";
            rbSignalTTL.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RbSignalSinus_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
