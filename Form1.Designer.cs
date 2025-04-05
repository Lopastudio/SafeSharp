namespace SafeSharp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Title_Label = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSafeSharpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_Label
            // 
            this.Title_Label.AutoSize = true;
            this.Title_Label.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Label.Location = new System.Drawing.Point(10, 28);
            this.Title_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(250, 44);
            this.Title_Label.TabIndex = 0;
            this.Title_Label.Text = "SafeSharp!";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(108, 26);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1113, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSafeSharpToolStripMenuItem,
            this.aboutMeeeToolStripMenuItem});
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
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
            this.aboutMeeeToolStripMenuItem.Text = "About meee";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 625);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Title_Label);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutSafeSharpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeeeToolStripMenuItem;
    }
}

