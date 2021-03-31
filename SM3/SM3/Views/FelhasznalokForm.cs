using SM3.Models;
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
    public partial class FelhasznalokForm : Form, IFelhasznalokView
    {
        private FelhasznalokListaPresenter presenter;
        private bool loaded;
        public FelhasznalokForm()
        {
            InitializeComponent();
            presenter = new FelhasznalokListaPresenter(this);
        }

        public List<users> felhasznalokLista 
        {
            set 
            {
                FelhasznalokListBox.DataSource = value;
                FelhasznalokListBox.DisplayMember = "felh";
                FelhasznalokListBox.ValueMember = "id";
            } 
        }
        public users users 
        {
            get 
            {
                return new users(FelhasznalokListBox.Text,EmailTextBox.Text, JelszoTextBox.Text, int.Parse(LakasIDTextBox.Text));
            }
            set 
            {
                FelhTextBox.Text = value.felh;
                EmailTextBox.Text = value.emial;
                LakasIDTextBox.Text = value.lakasId.ToString();
            }
        }

        private void FelhasznalokForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
            loaded = true;
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                if (FelhasznalokListBox.SelectedItem != null)
                {
                    var id = int.Parse(FelhasznalokListBox.SelectedValue.ToString());
                    presenter.GetFelhasznalo(id);
                }
            }
        }

        private void felhasználókToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void szobákToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
