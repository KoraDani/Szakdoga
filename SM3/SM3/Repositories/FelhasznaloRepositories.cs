using SM3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM3.Repositories
{
    class FelhasznaloRepositories
    {
        private OkosContext db = new OkosContext();
        public bool FelhasznaloNevExist(string felhnev)
        {
            return db.users.Any(x => x.felh == felhnev);
        }
        public int GetId(string felhnev)
        {
            var felhasznalo = db.users.SingleOrDefault(x => x.felh == felhnev);
            if (felhasznalo != null)
            {
                return felhasznalo.id;
            }
            return 0;
        }
        public bool Authenticate(string felhnev, string jelszo)
        {
            return db.users.Any(x => x.felh == felhnev && x.jelszo == jelszo);
        }
    }
}
