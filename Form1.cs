using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeSharp
{
    public partial class Form1 : Form
    {
        string version = "Alpha 1.0";
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutSafeSharpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: " + version + "\nSafe place for all your passwords!", "About SafeSharp", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // may come handy
        }
    }
}
