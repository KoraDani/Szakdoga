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
        szoba szoba { get; set; }
        List<eszkozok> eszkozoklista { set; get; }
        tobbeszkoz tobbeszkoz { get; set; }
        List<futes> futesLista { get; set; }
        tobbfutes tobbfutes { get; set; }
    }
}
