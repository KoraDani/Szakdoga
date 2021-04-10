using SM3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM3.ViewInterfaces
{
    interface IEszkozokView
    {
        List<eszkozok> eszkozokLista { set; }
        eszkozok eszkozok { get; set; }
        List<futes> futesLista { set; }
        futes futes { get; set; }
    }
}
