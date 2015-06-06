using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMe.WebServerContract.Authentication
{
    public class LoginRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ClientVersion { get; set; }
    }
}
