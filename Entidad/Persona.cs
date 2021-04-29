using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class Persona
    {
        public String Id { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String Email { get; set; }

        public Login User { get; set; }
        public Persona()
        {

        }

        public Persona(string id, string nombres, string apellidos, string email, Login user)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Email = email;
            User = user;
        }
    }
}
