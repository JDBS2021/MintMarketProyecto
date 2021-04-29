using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class DetallePedido
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int IdPedido { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public DetallePedido()
        {

        }
        public DetallePedido(int id, int idProducto, int idPedido, decimal precio, int cantidad)
        {
            Id = id;
            IdProducto = idProducto;
            IdPedido = idPedido;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
}
