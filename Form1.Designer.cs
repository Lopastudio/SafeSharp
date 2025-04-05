namespace SafeSharp
{
    partial class SafeSharp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SafeSharp));
            this.Title_Label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDBPassphraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.createDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yamlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlite3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yamlToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLite3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.printPasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSafeSharpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GenPass_Button = new System.Windows.Forms.Button();
            this.passwordLengthField = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Website_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GenPass_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddToDB_Button = new System.Windows.Forms.Button();
            this.Username_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Website = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthField)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_Label
            // 
            this.Title_Label.AutoSize = true;
            this.Title_Label.Font = new System.Drawing.Font("Stencil", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Label.Location = new System.Drawing.Point(2, 39);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(321, 57);
            this.Title_Label.TabIndex = 0;
            this.Title_Label.Text = "SafeSharp!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1205, 29);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeDBPassphraseToolStripMenuItem,
            this.toolStripSeparator2,
            this.createDBToolStripMenuItem,
            this.loadDBToolStripMenuItem,
            this.saveDBToolStripMenuItem,
            this.saveAsDBToolStripMenuItem,
            this.toolStripSeparator1,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator4,
            this.printPasswordsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // changeDBPassphraseToolStripMenuItem
            // 
            this.changeDBPassphraseToolStripMenuItem.Name = "changeDBPassphraseToolStripMenuItem";
            this.changeDBPassphraseToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.changeDBPassphraseToolStripMenuItem.Text = "Change DB passphrase";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // createDBToolStripMenuItem
            // 
            this.createDBToolStripMenuItem.Name = "createDBToolStripMenuItem";
            this.createDBToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.createDBToolStripMenuItem.Text = "Create DB";
            // 
            // loadDBToolStripMenuItem
            // 
            this.loadDBToolStripMenuItem.Name = "loadDBToolStripMenuItem";
            this.loadDBToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.loadDBToolStripMenuItem.Text = "Load DB";
            // 
            // saveDBToolStripMenuItem
            // 
            this.saveDBToolStripMenuItem.Name = "saveDBToolStripMenuItem";
            this.saveDBToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.saveDBToolStripMenuItem.Text = "Save DB";
            // 
            // saveAsDBToolStripMenuItem
            // 
            this.saveAsDBToolStripMenuItem.Name = "saveAsDBToolStripMenuItem";
            this.saveAsDBToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.saveAsDBToolStripMenuItem.Text = "Save DB As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jsonToolStripMenuItem,
            this.yamlToolStripMenuItem,
            this.sqlite3ToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // jsonToolStripMenuItem
            // 
            this.jsonToolStripMenuItem.Name = "jsonToolStripMenuItem";
            this.jsonToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.jsonToolStripMenuItem.Text = "Json";
            // 
            // yamlToolStripMenuItem
            // 
            this.yamlToolStripMenuItem.Name = "yamlToolStripMenuItem";
            this.yamlToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.yamlToolStripMenuItem.Text = "Yaml";
            // 
            // sqlite3ToolStripMenuItem
            // 
            this.sqlite3ToolStripMenuItem.Name = "sqlite3ToolStripMenuItem";
            this.sqlite3ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.sqlite3ToolStripMenuItem.Text = "SQLite3";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jsonToolStripMenuItem1,
            this.yamlToolStripMenuItem1,
            this.sQLite3ToolStripMenuItem1});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // jsonToolStripMenuItem1
            // 
            this.jsonToolStripMenuItem1.Name = "jsonToolStripMenuItem1";
            this.jsonToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.jsonToolStripMenuItem1.Text = "Json";
            // 
            // yamlToolStripMenuItem1
            // 
            this.yamlToolStripMenuItem1.Name = "yamlToolStripMenuItem1";
            this.yamlToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.yamlToolStripMenuItem1.Text = "Yaml";
            // 
            // sQLite3ToolStripMenuItem1
            // 
            this.sQLite3ToolStripMenuItem1.Name = "sQLite3ToolStripMenuItem1";
            this.sQLite3ToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.sQLite3ToolStripMenuItem1.Text = "SQLite3";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(191, 6);
            // 
            // printPasswordsToolStripMenuItem
            // 
            this.printPasswordsToolStripMenuItem.Name = "printPasswordsToolStripMenuItem";
            this.printPasswordsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.printPasswordsToolStripMenuItem.Text = "Print Passwords";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editPasswordToolStripMenuItem,
            this.removePasswordToolStripMenuItem,
            this.toolStripSeparator3});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // editPasswordToolStripMenuItem
            // 
            this.editPasswordToolStripMenuItem.Name = "editPasswordToolStripMenuItem";
            this.editPasswordToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.editPasswordToolStripMenuItem.Text = "Edit password";
            // 
            // removePasswordToolStripMenuItem
            // 
            this.removePasswordToolStripMenuItem.Name = "removePasswordToolStripMenuItem";
            this.removePasswordToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.removePasswordToolStripMenuItem.Text = "Remove password";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(167, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSafeSharpToolStripMenuItem,
            this.aboutMeeeToolStripMenuItem});
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 19);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // aboutSafeSharpToolStripMenuItem
            // 
            this.aboutSafeSharpToolStripMenuItem.Name = "aboutSafeSharpToolStripMenuItem";
            this.aboutSafeSharpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutSafeSharpToolStripMenuItem.Text = "About SafeSharp";
            this.aboutSafeSharpToolStripMenuItem.Click += new System.EventHandler(this.aboutSafeSharpToolStripMenuItem_Click);
            // 
            // aboutMeeeToolStripMenuItem
            // 
            this.aboutMeeeToolStripMenuItem.Name = "aboutMeeeToolStripMenuItem";
            this.aboutMeeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutMeeeToolStripMenuItem.Text = "GitHub";
            this.aboutMeeeToolStripMenuItem.Click += new System.EventHandler(this.aboutMeeeToolStripMenuItem_Click);
            // 
            // GenPass_Button
            // 
            this.GenPass_Button.Location = new System.Drawing.Point(11, 242);
            this.GenPass_Button.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.GenPass_Button.Name = "GenPass_Button";
            this.GenPass_Button.Size = new System.Drawing.Size(172, 34);
            this.GenPass_Button.TabIndex = 4;
            this.GenPass_Button.Text = "Generate password";
            this.GenPass_Button.UseVisualStyleBackColor = true;
            this.GenPass_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordLengthField
            // 
            this.passwordLengthField.Location = new System.Drawing.Point(150, 137);
            this.passwordLengthField.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.passwordLengthField.Name = "passwordLengthField";
            this.passwordLengthField.Size = new System.Drawing.Size(223, 44);
            this.passwordLengthField.TabIndex = 5;
            this.passwordLengthField.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email/Username:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Website_textbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.GenPass_Box);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AddToDB_Button);
            this.groupBox1.Controls.Add(this.Username_textbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.passwordLengthField);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.GenPass_Button);
            this.groupBox1.Location = new System.Drawing.Point(12, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 293);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password Generator";
            // 
            // Website_textbox
            // 
            this.Website_textbox.Location = new System.Drawing.Point(150, 87);
            this.Website_textbox.Name = "Website_textbox";
            this.Website_textbox.Size = new System.Drawing.Size(223, 44);
            this.Website_textbox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 36);
            this.label4.TabIndex = 12;
            this.label4.Text = "Length:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GenPass_Box
            // 
            this.GenPass_Box.Location = new System.Drawing.Point(200, 188);
            this.GenPass_Box.Name = "GenPass_Box";
            this.GenPass_Box.ReadOnly = true;
            this.GenPass_Box.ShortcutsEnabled = false;
            this.GenPass_Box.Size = new System.Drawing.Size(172, 44);
            this.GenPass_Box.TabIndex = 11;
            this.GenPass_Box.TabStop = false;
            this.GenPass_Box.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "Generated Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddToDB_Button
            // 
            this.AddToDB_Button.Location = new System.Drawing.Point(200, 242);
            this.AddToDB_Button.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.AddToDB_Button.Name = "AddToDB_Button";
            this.AddToDB_Button.Size = new System.Drawing.Size(172, 34);
            this.AddToDB_Button.TabIndex = 9;
            this.AddToDB_Button.Text = "Add to DB";
            this.AddToDB_Button.UseVisualStyleBackColor = true;
            this.AddToDB_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Username_textbox
            // 
            this.Username_textbox.Location = new System.Drawing.Point(150, 37);
            this.Username_textbox.Name = "Username_textbox";
            this.Username_textbox.Size = new System.Drawing.Size(223, 44);
            this.Username_textbox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "App / Website:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Magneto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(1028, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "I stand with Ukraine!";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Website,
            this.Username,
            this.Password,
            this.EditBtn});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(420, 39);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(773, 465);
            this.dataGridView1.TabIndex = 12;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date created";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Website
            // 
            this.Website.HeaderText = "Website";
            this.Website.Name = "Website";
            this.Website.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // EditBtn
            // 
            this.EditBtn.HeaderText = "Edit";
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::SafeSharp.Properties.Resources.SafeSharp_transparent;
            this.pictureBox2.Location = new System.Drawing.Point(329, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SafeSharp.Properties.Resources.ukraine_flag;
            this.pictureBox1.Location = new System.Drawing.Point(1167, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 14);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // SafeSharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 513);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Title_Label);
            this.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.MaximizeBox = false;
            this.Name = "SafeSharp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SafeSharp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthField)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutSafeSharpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeeeToolStripMenuItem;
        private System.Windows.Forms.Button GenPass_Button;
        private System.Windows.Forms.NumericUpDown passwordLengthField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Username_textbox;
        private System.Windows.Forms.TextBox GenPass_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddToDB_Button;
        private System.Windows.Forms.TextBox Website_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yamlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sqlite3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jsonToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yamlToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sQLite3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem changeDBPassphraseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Website;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewButtonColumn EditBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem printPasswordsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

