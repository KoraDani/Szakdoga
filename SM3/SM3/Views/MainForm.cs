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
    public partial class MainForm : Form, ISzobakListView
    {
        private SzobakListaPresenter presenter;
        private bool loaded;
        public MainForm()
        {
            InitializeComponent();
            presenter = new SzobakListaPresenter(this);
        }
        #region Szoba
        public List<szoba> szobaLista 
        { 
            set
            {
                listBox1.DataSource = value;
                listBox1.DisplayMember = "szobaNev";
                listBox1.ValueMember = "id";
            } 
        }

        public szoba szoba
        {
            get
            {
                var id = int.Parse(SzobaIdLabel.Text);
                return new szoba(id, SzobaNTextBox.Text, int.Parse(TeruletTextBox.Text.ToString()));
            }
            set
            {
                SzobaIdLabel.Text = value.id.ToString();
                SzobaNTextBox.Text = value.szobaNev;
                TeruletTextBox.Text = value.terulet.ToString();
            }
        }
        #endregion
        #region Eszközök

        
        public List<eszkozok> eszkozoklista
        {
            get => (List<eszkozok>)comboBox1.DataSource;
            set 
            {
                comboBox1.DataSource = value;
                comboBox1.DisplayMember = "eszkozNev";
                comboBox1.ValueMember = "id";
            }
        }
        public tobbeszkoz tobbeszkoz
        {
            get
            {
                var id = int.Parse(SzobaIdLabel.Text);
                var tobbeszkoz = new tobbeszkoz(/*Convert.ToInt32(comboBox2.SelectedValue)*/);
                tobbeszkoz.eszkozID = Convert.ToInt32(comboBox2.SelectedValue);
                return tobbeszkoz;
            }
            set
            {
                //comboBox2.Text = value.eszkozID.ToString();
                //label7.Text = value.szoba.tobbeszkoz.ToString();
                //comboBox2.Text = value.szoba.tobbeszkoz.ToString();
            }
        }


        #endregion
        #region Fűtés
        public List<futes> futesLista 
        { 
            get => (List<futes>)comboBox2.DataSource;
            set
            {
                comboBox2.DataSource = value;
                comboBox2.DisplayMember = "futesTipus";
                comboBox2.ValueMember = "id";
            }
        }
        public tobbfutes tobbfutes
        {
            get
            {
                //var id = int.Parse(SzobaIdLabel.Text);
                return new tobbfutes(/*Convert.ToInt32(comboBox1.SelectedValue)*/);
            }
            set
            {
                comboBox2.Text = value.futesID.ToString();
            }
        }
        #endregion


        private void LoginForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
            loaded = true;
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                if (listBox1.SelectedItem != null)
                {
                    var id = int.Parse(listBox1.SelectedValue.ToString());
                    presenter.GetSzoba(id);
                }
            }
        }

        private void mentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            presenter.SaveFeladat();
        }

        private void ujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.CreateSzoba();
        }

        private void torlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = int.Parse(listBox1.SelectedValue.ToString());
            presenter.DeleteFeladat(id);
        }

        private void felhasználókToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FelhasznalokForm felhForm = new FelhasznalokForm();
            this.Hide();
            felhForm.ShowDialog();
            this.Close();
        }
    }
}
