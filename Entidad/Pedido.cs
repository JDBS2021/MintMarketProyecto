using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class Pedido
    {


        public int Id { get; set; }
        public String DireccionEntrega { get; set; }
        public int Estado { get; set; }
        public decimal Flete { get; set; }

        private readonly List<DetallePedido> productos;

        public Pedido()
        {
            productos = new List<DetallePedido>();
        }

        public Pedido(int id, string direccionEntrega, int estado, decimal flete)
        {
            Id = id;
            DireccionEntrega = direccionEntrega;
            Estado = estado;
            Flete = flete;
            productos = new List<DetallePedido>();
        }

        public void CalcularValorPagar()
        {
            decimal valor = 0;
            foreach (DetallePedido detalle in productos)
            {
                valor += detalle.Precio;
            }
            Flete = valor;
            
        }
    }
}
