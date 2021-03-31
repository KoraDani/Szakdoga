using SM3.Models;
using SM3.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM3.Presenters
{
    class FelhasznalokListaPresenter
    {
        private IFelhasznalokView view;
        private OkosContext db;
        public FelhasznalokListaPresenter(IFelhasznalokView param)
        {
            view = param;
            db = new OkosContext();
        }
        public void LoadData()
        {
            view.felhasznalokLista = db.users.ToList();
        }
        public void GetFelhasznalo(int id)
        {
            view.users = db.users.Find(id);
        }
    }
}
