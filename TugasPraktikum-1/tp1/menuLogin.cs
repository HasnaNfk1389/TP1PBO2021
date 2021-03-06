using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPraktikum_1
{
    class menuLogin
    {
        public string username { get; set; }
        public string password { get; set; }

        public menuLogin(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
