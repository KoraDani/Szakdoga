using SM3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM3.ViewInterfaces
{
    interface IFelhasznalokView
    {
        List<users> felhasznalokLista { set; }
        users users { get; set; }
    }
}
