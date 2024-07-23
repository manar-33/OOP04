using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string username, int password)
        {
            if (username == "Manar" && password == 1234)
            { return true; }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (username == "Manar" && role == "Dev")
            { return true; }
            return false;

        }
    }
}
