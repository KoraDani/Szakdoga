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
                listBox1.DataSource = value;
                listBox1.DisplayMember = "felh";
                listBox1.ValueMember = "id";
            } 
        }
        public users users 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        private void FelhasznalokForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                if (listBox1.SelectedItem != null)
                {
                    var id = int.Parse(listBox1.SelectedValue.ToString());
                    presenter.GetFelhasznalo(id);
                }
            }
        }
    }
}
