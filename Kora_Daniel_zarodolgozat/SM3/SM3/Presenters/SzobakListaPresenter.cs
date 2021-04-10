using SM3.Models;
using SM3.Services;
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
            view.szobaLista = db.szoba.Where(x=>x.lakasID== CurrentUser.lakasId).ToList();
        }
        public void GetSzoba(int id)
        {
            view.szoba = db.szoba.Find(id);
        }

        public void SaveFeladat()
        {
            var szoba1 = view.szoba;
            szoba1.lakasID = CurrentUser.lakasId;
            var dbletezik = db.szoba.Find(szoba1.id);
            if (dbletezik != null)
            {
                db.Entry(dbletezik).State = System.Data.Entity.EntityState.Detached;
                db.Entry(szoba1).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                db.szoba.Add(szoba1);
                db.SaveChanges();
            }
            db.SaveChanges();
            LoadData();
        }

        public void CreateSzoba()
        {
            var id = db.szoba
                .Select(x => x.id)
                .DefaultIfEmpty(0)
                .Max() + 1;
            view.szoba = new szoba(0,null,0);
        }

        public void DeleteFeladat(int id)
        {
            var szoba = db.szoba.Find(id);
            if (szoba != null)
            {
                db.szoba.Remove(szoba);
            }
            db.SaveChanges();
            LoadData();
        }
    }
}
