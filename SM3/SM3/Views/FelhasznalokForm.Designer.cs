﻿
namespace SM3.Views
{
    partial class FelhasznalokForm
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
            this.FelhasznalokListBox = new System.Windows.Forms.ListBox();
            this.FelhTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szobákToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.LakasIDTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FelhasznalokListBox
            // 
            this.FelhasznalokListBox.FormattingEnabled = true;
            this.FelhasznalokListBox.Location = new System.Drawing.Point(12, 44);
            this.FelhasznalokListBox.Name = "FelhasznalokListBox";
            this.FelhasznalokListBox.Size = new System.Drawing.Size(120, 264);
            this.FelhasznalokListBox.TabIndex = 0;
            this.FelhasznalokListBox.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // FelhTextBox
            // 
            this.FelhTextBox.Location = new System.Drawing.Point(249, 48);
            this.FelhTextBox.Name = "FelhTextBox";
            this.FelhTextBox.Size = new System.Drawing.Size(100, 20);
            this.FelhTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Felhasználónév";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lakás neve";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ujToolStripMenuItem,
            this.mentesToolStripMenuItem,
            this.torlesToolStripMenuItem,
            this.szobákToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // ujToolStripMenuItem
            // 
            this.ujToolStripMenuItem.Name = "ujToolStripMenuItem";
            this.ujToolStripMenuItem.Size = new System.Drawing.Size(30, 20);
            this.ujToolStripMenuItem.Text = "Új";
            this.ujToolStripMenuItem.Click += new System.EventHandler(this.ujToolStripMenuItem_Click);
            // 
            // mentesToolStripMenuItem
            // 
            this.mentesToolStripMenuItem.Name = "mentesToolStripMenuItem";
            this.mentesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.mentesToolStripMenuItem.Text = "Mentés";
            this.mentesToolStripMenuItem.Click += new System.EventHandler(this.mentesToolStripMenuItem_Click);
            // 
            // torlesToolStripMenuItem
            // 
            this.torlesToolStripMenuItem.Name = "torlesToolStripMenuItem";
            this.torlesToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.torlesToolStripMenuItem.Text = "Törlés";
            this.torlesToolStripMenuItem.Click += new System.EventHandler(this.torlesToolStripMenuItem_Click);
            // 
            // szobákToolStripMenuItem
            // 
            this.szobákToolStripMenuItem.Name = "szobákToolStripMenuItem";
            this.szobákToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.szobákToolStripMenuItem.Text = "Szobák";
            this.szobákToolStripMenuItem.Click += new System.EventHandler(this.szobákToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email cím";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(249, 95);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmailTextBox.TabIndex = 14;
            // 
            // LakasIDTextBox
            // 
            this.LakasIDTextBox.Location = new System.Drawing.Point(249, 134);
            this.LakasIDTextBox.Name = "LakasIDTextBox";
            this.LakasIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.LakasIDTextBox.TabIndex = 3;
            // 
            // FelhasznalokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 343);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LakasIDTextBox);
            this.Controls.Add(this.FelhTextBox);
            this.Controls.Add(this.FelhasznalokListBox);
            this.Name = "FelhasznalokForm";
            this.Text = "Felhasznalok";
            this.Load += new System.EventHandler(this.FelhasznalokForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FelhasznalokListBox;
        private System.Windows.Forms.TextBox FelhTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torlesToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.ToolStripMenuItem szobákToolStripMenuItem;
        private System.Windows.Forms.TextBox LakasIDTextBox;
    }
}