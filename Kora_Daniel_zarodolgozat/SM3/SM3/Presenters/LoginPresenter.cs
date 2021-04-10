using SM3.Models;
using SM3.Repositories;
using SM3.Services;
using SM3.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM3.Presenters
{
    class LoginPresenter
    {
        private ILoginView view;
        private FelhasznaloRepositories repo;
        private OkosContext db;
        public LoginPresenter(ILoginView param)
        {
            view = param;
            repo = new FelhasznaloRepositories();
            db = new OkosContext();
        }

        public bool Belepes()
        {
            view.errorFelhNev = null;
            view.errorJelszo = null;

            if (string.IsNullOrWhiteSpace(view.felhNev))
            {
                view.errorFelhNev = "Kérem töltse ki ezt a mezőt.";
            }

            if (string.IsNullOrWhiteSpace(view.jelszo))
            {
                view.errorJelszo = "Kérem töltse ki ezt a mezőt.";
            }

            // Ha ki van töltve a felhasználónév és a jelszó
            if (!string.IsNullOrWhiteSpace(view.felhNev) && !string.IsNullOrWhiteSpace(view.jelszo))
            {
                // Létezik-e a felhasználó
                if (repo.FelhasznaloNevExist(view.felhNev))
                {
                    var felhId = repo.GetId(view.felhNev);
                    var jelszo = Hash.Encrypt(view.jelszo);

                    // Jó jelszó van a felhasználóhoz
                    if (repo.Authenticate(view.felhNev, jelszo))
                    {
                        CurrentUser.Id = felhId;
                        CurrentUser.UserName = view.felhNev;
                        CurrentUser.lakasId = repo.GetLakas(view.felhNev);
                        return true;
                    }
                    else
                    {
                        view.errorJelszo = "Hibás felhasználónév vagy jelszó.";
                    }
                }
                else
                {
                    view.errorFelhNev = "Felhasználó nem létezik.";
                }
            }
            return false;
        }
    }
}
