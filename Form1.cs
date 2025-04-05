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
    public partial class SafeSharp : Form
    {
        string version = "Alpha 1.0";
        string GenedPassword = ""; // propably dangerous and not secure?? IDK


        public SafeSharp()
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
            Clipboard.SetText(password);
            GenedPassword = password;
            return password;
        }

        private void aboutSafeSharpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: " + version + "\nSafe place for all your passwords!", "About SafeSharp", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the DataGridView to fill the form
            dataGridView1.Columns["Date"].Width = 150;
            dataGridView1.Columns["Website"].Width = 200;
            dataGridView1.Columns["Username"].Width = 150;
            dataGridView1.Columns["Password"].Width = 150;
            dataGridView1.Columns["EditBtn"].Width = 60;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(passwordLengthField.Value);
            GenPass_Box.Text = generatePassword(length); // Generate password and set it to the textbox
            Clipboard.SetText(GenedPassword);
            MessageBox.Show("Password copied to clipboard!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Website_textbox.Text == "" || Username_textbox.Text == "" || GenedPassword == "") // Check if smthing is not empty
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string date = DateTime.Now.ToString("dd-MM-yyyy");
            dataGridView1.Rows.Add(date, Website_textbox.Text, Username_textbox.Text, GenedPassword, "Edit");

            // Clear input fields
            Website_textbox.Text = "";
            Username_textbox.Text = "";
            GenedPassword = "";
        }




        private void label5_Click(object sender, EventArgs e)
        {
            // Nasilie je reč idiotov quite incomming
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm f2 = new SettingsForm();
            f2.Show();
        }

        private void aboutMeeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Lopastudio/SafeSharp");
        }
    }
}
