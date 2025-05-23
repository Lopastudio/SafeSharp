﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using Microsoft.Win32;

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

        private void LoadDatabaseIntoGrid()
        {
            dataGridView1.Rows.Clear();
            var entries = DatabaseHelper.LoadPasswords();
            foreach (var (date, website, username, password) in entries)
            {
                dataGridView1.Rows.Add(date, website, username, password, "Edit");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseHelper.InitializeDatabase();

            dataGridView1.Columns["Date"].Width = 150;
            dataGridView1.Columns["Website"].Width = 200;
            dataGridView1.Columns["Username"].Width = 150;
            dataGridView1.Columns["Password"].Width = 150;
            dataGridView1.Columns["EditBtn"].Width = 60;

            LoadDatabaseIntoGrid();
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
            DatabaseHelper.SavePassword(date, Website_textbox.Text, Username_textbox.Text, GenedPassword);


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

        private void createDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void loadDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "SQLite Database|*.db";
            openDialog.Title = "Open Existing Database";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                File.Copy(openDialog.FileName, "safesharp.db", overwrite: true);
                MessageBox.Show("Database loaded successfully.");
                LoadDatabaseIntoGrid();
            }
        }

        private void saveDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string backupPath = $"backup_{DateTime.Now:yyyyMMdd_HHmmss}.db";
            File.Copy("safesharp.db", backupPath, overwrite: true);
            MessageBox.Show($"Database saved as {backupPath}");
        }

        private void saveAsDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "SQLite Database|*.db";
            saveDialog.Title = "Save Database As";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                File.Copy("safesharp.db", saveDialog.FileName, overwrite: true);
                MessageBox.Show("Database saved to new location.");
            }
        }

        private void changeDBPassphraseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Passphrase changing is not yet implemented.\nYou would need to re-encrypt each value with a new key.", "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
