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

            RbSignalSinus.Text = "Sinus";
            RbSignalSinus.Checked = false;
            RbSignalTTL.Text = "TTL";
            RbSignalTTL.Checked = true;
            CbOffset.Text = "Offset";
            CbOffset.Enabled = false;
        }
    }
}
