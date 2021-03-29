using SM3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM3.ViewInterfaces
{
    interface ISzobakListView
    {
        List<szoba> szobaLista { set; }
        szoba szobak { get; set; }
    }
}
