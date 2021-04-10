
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FelhNevTextBox = new System.Windows.Forms.TextBox();
            this.JelszoTextBox = new System.Windows.Forms.TextBox();
            this.BelepesButton = new System.Windows.Forms.Button();
            this.errorPFelhNev = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPJelszo = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorPFelhNev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPJelszo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(34, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználónév";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(93, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jelszó";
            // 
            // FelhNevTextBox
            // 
            this.FelhNevTextBox.Location = new System.Drawing.Point(147, 67);
            this.FelhNevTextBox.Name = "FelhNevTextBox";
            this.FelhNevTextBox.Size = new System.Drawing.Size(136, 20);
            this.FelhNevTextBox.TabIndex = 2;
            // 
            // JelszoTextBox
            // 
            this.JelszoTextBox.Location = new System.Drawing.Point(147, 116);
            this.JelszoTextBox.Name = "JelszoTextBox";
            this.JelszoTextBox.Size = new System.Drawing.Size(136, 20);
            this.JelszoTextBox.TabIndex = 3;
            // 
            // BelepesButton
            // 
            this.BelepesButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BelepesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BelepesButton.Location = new System.Drawing.Point(147, 164);
            this.BelepesButton.Name = "BelepesButton";
            this.BelepesButton.Size = new System.Drawing.Size(136, 36);
            this.BelepesButton.TabIndex = 4;
            this.BelepesButton.Text = "Belépés";
            this.BelepesButton.UseVisualStyleBackColor = false;
            this.BelepesButton.Click += new System.EventHandler(this.BelepesButton_Click);
            // 
            // errorPFelhNev
            // 
            this.errorPFelhNev.ContainerControl = this;
            // 
            // errorPJelszo
            // 
            this.errorPJelszo.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(108, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bejelentkezés";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(372, 269);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BelepesButton);
            this.Controls.Add(this.JelszoTextBox);
            this.Controls.Add(this.FelhNevTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Bejelentkezés";
            ((System.ComponentModel.ISupportInitialize)(this.errorPFelhNev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPJelszo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FelhNevTextBox;
        private System.Windows.Forms.TextBox JelszoTextBox;
        private System.Windows.Forms.Button BelepesButton;
        private System.Windows.Forms.ErrorProvider errorPFelhNev;
        private System.Windows.Forms.ErrorProvider errorPJelszo;
        private System.Windows.Forms.Label label3;
    }
}