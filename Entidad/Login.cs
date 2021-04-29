using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class Login
    {
        public Login()
        {
        }

        public String Usuario { get; set; }
        public String Password { get; set; }

        public Login(string usuario, string password)
        {
            Usuario = usuario;
            Password = password;
        }
    }
}
