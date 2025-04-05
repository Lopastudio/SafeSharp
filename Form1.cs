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

        private string generatePassword(int length)
        {
            // Generate a random password
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#$%&\\'()*+,-./:;<=>?@[\\\\]^_`{|}~";
            Random random = new Random();
            string password = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return password;
        }

        private void aboutSafeSharpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: " + version + "\nSafe place for all your passwords!", "About SafeSharp", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // may come handy
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(passwordLengthField.Value);
            MessageBox.Show(generatePassword(length));
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
