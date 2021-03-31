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
    class FelhasznalokListaPresenter
    {
        private IFelhasznalokView view;
        private OkosContext db;
        public FelhasznalokListaPresenter(IFelhasznalokView param)
        {
            view = param;
            db = new OkosContext();
            var felhasznalok = db.users.Where(x => x.lakasId == CurrentUser.lakasId);
        }
        public void LoadData()
        {
            view.felhasznalokLista = db.users.ToList();
        }
        public void GetFelhasznalo(int id)
        {
            view.users = db.users.Find(id);
        }
        public void SaveFelhasznalo(int kivalasztottID)
        {
            //Módosult vagy új feladat
            var felH = view.users;
            felH.id = kivalasztottID;
            //Adatbázisban lévő feladat
            var letezik = db.users.Find(felH.id);
            if (letezik != null)
            {
                //Kiszedi a társítást a db rekordból
                db.Entry(letezik).State = System.Data.Entity.EntityState.Detached;
                db.Entry(felH).State = System.Data.Entity.EntityState.Modified;
                //Újra társítja a feladatott új értékekkel
            }
            else
            {
                db.users.Add(felH);
            }
            db.SaveChanges();//HIBA VAN
            LoadData();
        }
        
        public void CreateFelhasznalo()
        {
            var id = db.users
                .Select(x => x.id)
                // Ha üres a tábla, akkor 0 lesz az értéke
                .DefaultIfEmpty(0)
                // Lekérdezi a legnagyobb számot
                .Max() + 1;
            view.users = new users(null,null,null,0);
            //view.tobbfutes = new tobbfutes(0, id);
            //view.tobbeszkoz = new tobbeszkoz(0, id);
        }

        public void DeleteFelhasznalo(int id)
        {
            var felh = db.users.Find(id);
            if (felh != null)
            {
                db.users.Remove(felh);
            }
            db.SaveChanges();
            LoadData();
        }
    }
}
