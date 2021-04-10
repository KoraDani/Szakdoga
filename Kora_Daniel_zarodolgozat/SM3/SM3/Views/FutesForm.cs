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
    public partial class FutesForm : Form, IEszkozokView
    {
        private EszkozokPresenter presenter;
        private bool loaded;
        public FutesForm()
        {
            InitializeComponent();
            presenter = new EszkozokPresenter(this);
        }

        public List<eszkozok> eszkozokLista 
        { 
            set
            {
                EszkozokListBox.DataSource = value;
                EszkozokListBox.DisplayMember = "eszkozNev";
                EszkozokListBox.ValueMember = "id";
            } 
        }
        public eszkozok eszkozok 
        {
            get 
            {
                return new eszkozok(EszkozTextBox.Text);
            } 
            set => throw new NotImplementedException(); 
        }
        public List<futes> futesLista 
        {
            set 
            {
                FutesListBox.DataSource = value;
                FutesListBox.DisplayMember = "futesTipus";
                FutesListBox.ValueMember = "id";
            }
        }
        public futes futes 
        {
            get 
            {
                return new futes(FutesTextBox.Text);
            }
            set => throw new NotImplementedException(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EszkozokListBox.ClearSelected();
            presenter.SaveEszkoz();
        }

        private void FutesForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
            loaded = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FutesListBox.ClearSelected();
            presenter.SaveFutes();
        }

        private void felhasználókToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //nem itt zárja be
            MainForm main2Form = new MainForm();
            this.Hide();
            main2Form.Show();
            this.Close();
        }
    }
}
