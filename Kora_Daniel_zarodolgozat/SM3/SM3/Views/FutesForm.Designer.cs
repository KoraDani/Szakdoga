
namespace SM3.Views
{
    partial class FutesForm
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
            this.EszkozokListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EszkozTextBox = new System.Windows.Forms.TextBox();
            this.FutesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FutesListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasználókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EszkozokListBox
            // 
            this.EszkozokListBox.FormattingEnabled = true;
            this.EszkozokListBox.Location = new System.Drawing.Point(22, 48);
            this.EszkozokListBox.Name = "EszkozokListBox";
            this.EszkozokListBox.Size = new System.Drawing.Size(120, 329);
            this.EszkozokListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eszközök";
            // 
            // EszkozTextBox
            // 
            this.EszkozTextBox.Location = new System.Drawing.Point(191, 87);
            this.EszkozTextBox.Name = "EszkozTextBox";
            this.EszkozTextBox.Size = new System.Drawing.Size(110, 20);
            this.EszkozTextBox.TabIndex = 2;
            // 
            // FutesTextBox
            // 
            this.FutesTextBox.Location = new System.Drawing.Point(516, 87);
            this.FutesTextBox.Name = "FutesTextBox";
            this.FutesTextBox.Size = new System.Drawing.Size(100, 20);
            this.FutesTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fűtés";
            // 
            // FutesListBox
            // 
            this.FutesListBox.FormattingEnabled = true;
            this.FutesListBox.Location = new System.Drawing.Point(347, 48);
            this.FutesListBox.Name = "FutesListBox";
            this.FutesListBox.Size = new System.Drawing.Size(120, 329);
            this.FutesListBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Eszköz hozzáadás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(516, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Fűtés hozzáadás";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ujToolStripMenuItem,
            this.mentesToolStripMenuItem,
            this.torlesToolStripMenuItem,
            this.felhasználókToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
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
            // 
            // mentesToolStripMenuItem
            // 
            this.mentesToolStripMenuItem.Name = "mentesToolStripMenuItem";
            this.mentesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.mentesToolStripMenuItem.Text = "Mentés";
            // 
            // torlesToolStripMenuItem
            // 
            this.torlesToolStripMenuItem.Name = "torlesToolStripMenuItem";
            this.torlesToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.torlesToolStripMenuItem.Text = "Törlés";
            // 
            // felhasználókToolStripMenuItem
            // 
            this.felhasználókToolStripMenuItem.Name = "felhasználókToolStripMenuItem";
            this.felhasználókToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.felhasználókToolStripMenuItem.Text = "Szobák";
            this.felhasználókToolStripMenuItem.Click += new System.EventHandler(this.felhasználókToolStripMenuItem_Click);
            // 
            // FutesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FutesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FutesListBox);
            this.Controls.Add(this.EszkozTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EszkozokListBox);
            this.Name = "FutesForm";
            this.Text = "Eszközök hozzáadása";
            this.Load += new System.EventHandler(this.FutesForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EszkozokListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EszkozTextBox;
        private System.Windows.Forms.TextBox FutesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox FutesListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felhasználókToolStripMenuItem;
    }
}