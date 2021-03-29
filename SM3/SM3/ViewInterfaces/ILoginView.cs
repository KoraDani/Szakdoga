using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM3.ViewInterfaces
{
    interface ILoginView
    {
        string felhNev { get; }
        string jelszo { get; }
        string errorFelhNev { set; }
        string errorJelszo { set; }
    }
}
