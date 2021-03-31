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
            view.eszkozoklista = db.eszkozok.ToList();
            view.futesLista = db.futes.ToList();
        }
        public void GetSzoba(int id)
        {
            view.szoba = db.szoba.Find(id);
            view.futesLista = db.tobbfutes.Where(x => x.szobaID == id).Select(y => y.futes).ToList();
            view.eszkozoklista = db.tobbeszkoz.Where(x => x.szobaID == id).Select(y => y.eszkozok).ToList();
        }

        public void SaveFeladat()
        {
            //Módosult vagy új feladat
            var szoba1 = view.szoba;
            var eszkozok = view.tobbeszkoz;
            var futes = view.tobbfutes;
            szoba1.lakasID = CurrentUser.lakasId;
            //Adatbázisban lévő feladat
            var dbletezik = db.szoba.Find(szoba1.id);
            if (dbletezik != null)
            {
                //Kiszedi a társítást a db rekordból
                db.Entry(dbletezik).State = System.Data.Entity.EntityState.Detached;
                //Újra társítja a feladatott új értékekkel
                db.Entry(szoba1).State = System.Data.Entity.EntityState.Modified;
                db.Entry(eszkozok).State = System.Data.Entity.EntityState.Modified;
                db.Entry(futes).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                db.szoba.Add(szoba1);
            }
            db.SaveChanges();
            LoadData();
        }

        public void CreateSzoba()
        {
            var id = db.szoba
                .Select(x => x.id)
                // Ha üres a tábla, akkor 0 lesz az értéke
                .DefaultIfEmpty(0)
                // Lekérdezi a legnagyobb számot
                .Max() + 1;
            view.szoba = new szoba(0,null,0);
            //view.tobbfutes = new tobbfutes(0, id);
            //view.tobbeszkoz = new tobbeszkoz(0, id);
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
