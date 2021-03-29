
namespace SM3.Views
{
    partial class LoginForm
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SzobaNTextBox = new System.Windows.Forms.TextBox();
            this.TeruletTextBox = new System.Windows.Forms.TextBox();
            this.EszkozTextBox = new System.Windows.Forms.TextBox();
            this.FutesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 394);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedValueChanged += new System.EventHandler(this.checkedListBox1_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Szoba neve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Terület";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Eszköz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fűtés Típus";
            // 
            // SzobaNTextBox
            // 
            this.SzobaNTextBox.Location = new System.Drawing.Point(263, 18);
            this.SzobaNTextBox.Name = "SzobaNTextBox";
            this.SzobaNTextBox.Size = new System.Drawing.Size(100, 20);
            this.SzobaNTextBox.TabIndex = 5;
            // 
            // TeruletTextBox
            // 
            this.TeruletTextBox.Location = new System.Drawing.Point(263, 82);
            this.TeruletTextBox.Name = "TeruletTextBox";
            this.TeruletTextBox.Size = new System.Drawing.Size(100, 20);
            this.TeruletTextBox.TabIndex = 6;
            // 
            // EszkozTextBox
            // 
            this.EszkozTextBox.Location = new System.Drawing.Point(263, 145);
            this.EszkozTextBox.Name = "EszkozTextBox";
            this.EszkozTextBox.Size = new System.Drawing.Size(100, 20);
            this.EszkozTextBox.TabIndex = 7;
            // 
            // FutesTextBox
            // 
            this.FutesTextBox.Location = new System.Drawing.Point(263, 203);
            this.FutesTextBox.Name = "FutesTextBox";
            this.FutesTextBox.Size = new System.Drawing.Size(100, 20);
            this.FutesTextBox.TabIndex = 8;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FutesTextBox);
            this.Controls.Add(this.EszkozTextBox);
            this.Controls.Add(this.TeruletTextBox);
            this.Controls.Add(this.SzobaNTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "LoginForm";
            this.Text = "LoginView";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SzobaNTextBox;
        private System.Windows.Forms.TextBox TeruletTextBox;
        private System.Windows.Forms.TextBox EszkozTextBox;
        private System.Windows.Forms.TextBox FutesTextBox;
    }
}