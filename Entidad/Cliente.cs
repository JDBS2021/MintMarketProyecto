using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class Cliente: Persona
    {

        public String Direccion { get; set; }
        public String Telefono { get; set; }

        public readonly List<Pedido> pedidos;
        public Cliente()
        {
            pedidos = new List<Pedido>();
        }

        public Cliente(string id, string nombres, string apellidos, string email, Login user, String direccion, String telefono) : 
            base(id, nombres, apellidos, email, user)
        {
            Direccion = direccion;
            Telefono = telefono;
            pedidos = new List<Pedido>();
        }


    }
}
