using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM3.Models
{
    public partial class users
    {
        public users(string felh, string email, int lakasId)
        {
            this.felh = felh;
            this.emial = email;
            this.lakasId = lakasId;
        }
        public users()
        {

        }
    }
}
