using SM3.Presenters;
using SM3.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM3.Views
{
    public partial class LoginForm : Form, ILoginView
    {
        private LoginPresenter presenter;
        public LoginForm()
        {
            InitializeComponent();
            presenter = new LoginPresenter(this);
        }

        public string felhNev
        {
            get => FelhNevTextBox.Text;
        }
        public string jelszo
        {
            get => JelszoTextBox.Text;
        }
        public string errorFelhNev
        {
            set => errorPFelhNev.SetError(FelhNevTextBox, value);
        }
        public string errorJelszo
        {
            set => errorPJelszo.SetError(JelszoTextBox, value);
        }

        private void BelepesButton_Click(object sender, EventArgs e)
        {
            if (presenter.Belepes())
            {
                
                MainForm loginForm = new MainForm();
                this.Hide();
                loginForm.ShowDialog();
                this.Close();
            }
        }
    }
}
