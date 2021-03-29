using SM3.Models;
using SM3.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM3.Presenters
{
    class SzobakListaPresenter
    {
        private ISzobakListView view;
        private OkosContext db;
        public SzobakListaPresenter(ISzobakListView param)
        {
            view = param;
            db = new OkosContext();
        }
        public void LoadData()
        {
            view.szobaLista = db.szoba.Where(x=>x.lakasID==1).ToList();
        }
        public void GetSzoba(int id)
        {
            view.szobak = db.szoba.Find(id);
        }
    }
}
