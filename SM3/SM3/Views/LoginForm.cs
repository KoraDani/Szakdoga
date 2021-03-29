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
    public partial class LoginForm : Form, ISzobakListView
    {
        private SzobakListaPresenter presenter;
        private bool loaded;
        public LoginForm()
        {
            InitializeComponent();
            presenter = new SzobakListaPresenter(this);
        }

        public List<szoba> szobaLista 
        { 
            set
            {
                checkedListBox1.DataSource = value;
                checkedListBox1.DisplayMember = "szobaNev";
                checkedListBox1.ValueMember = "id";
            } 
        }
        public szoba szobak 
        { 
            get => throw new NotImplementedException();
            set 
            {
                SzobaNTextBox.Text = value.szobaNev;
                TeruletTextBox.Text = value.terulet.ToString();
                //EszkozTextBox.Text = value.tobbeszkoz();
                //FutesTextBox.Text = value.tobbfutes();
            } 
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
            loaded = true;
        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                if (checkedListBox1.SelectedItem != null)
                {
                    var id = int.Parse(checkedListBox1.SelectedValue.ToString());
                    presenter.GetSzoba(id);
                }
            }
        }
    }
}
