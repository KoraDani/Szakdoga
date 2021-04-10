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
        public void SaveFelhasznalo()
        {
            var felh = view.users;
            var letezik = db.users.Find(felh.id);
            if (letezik != null)
            {
                db.Entry(letezik).State = System.Data.Entity.EntityState.Detached;
                db.Entry(felh).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                db.users.Add(felh);
            }
            db.SaveChanges();
            LoadData();
        }
        
        public void CreateFelhasznalo()
        {
            var id = db.users
                .Select(x => x.id)
                .DefaultIfEmpty(0)
                .Max() + 1;
            view.users = new users(null,null,0);
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
