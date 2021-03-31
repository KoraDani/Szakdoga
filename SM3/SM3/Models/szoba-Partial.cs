using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM3.Models
{
    public partial class szoba
    {
        public szoba(int id, string szobaNev, int terulet)
        {
            this.id = id;
            this.szobaNev = szobaNev;
            this.terulet = terulet;
        }
    }
}
