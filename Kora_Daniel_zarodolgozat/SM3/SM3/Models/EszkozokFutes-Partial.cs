using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM3.Models
{
    public partial class eszkozok
    {
        public eszkozok(string eszkozNev)
        {
            this.eszkozNev = eszkozNev;
        }
    }
    public partial class futes
    {
        public futes(string futesTipus)
        {
            this.futesTipus = futesTipus;
        }
    }
}
