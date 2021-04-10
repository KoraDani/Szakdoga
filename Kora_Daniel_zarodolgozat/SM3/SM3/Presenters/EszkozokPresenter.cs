using SM3.Models;
using SM3.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM3.Presenters
{
    class EszkozokPresenter
    {
        private IEszkozokView view;
        private OkosContext db;
        public EszkozokPresenter(IEszkozokView param)
        {
            view = param;
            db = new OkosContext();
        }
        public void LoadData()
        {
            view.eszkozokLista = db.eszkozok.ToList();
            view.futesLista = db.futes.ToList();
        }
        public void SaveEszkoz()
        {
            var eszkoz = view.eszkozok;
            db.eszkozok.Add(eszkoz);
            db.SaveChanges();
            LoadData();
        }
        public void SaveFutes()
        {
            var futes = view.futes;
            db.futes.Add(futes);
            db.SaveChanges();
            LoadData();
        }
        public void DeleteEszkoz(int id)
        {
            var eszkoz = db.eszkozok.Find(id);
            if (eszkoz != null)
            {
                db.eszkozok.Remove(eszkoz);
            }
            db.SaveChanges();
            LoadData();
        }
        public void DeleteFutes(int id)
        {
            var futes = db.futes.Find(id);
            if (futes != null)
            {
                db.futes.Remove(futes);
            }
            db.SaveChanges();
            LoadData();
        }
    }
}
