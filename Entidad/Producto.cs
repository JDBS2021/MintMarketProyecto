using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class Producto
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal Costo { get; set; }
        public decimal Descuento { get; set; }
        public String Descripcion { get; set; }
        public int Cantidad { get; set; }

        public Producto()
        {
        }
        public Producto(int id, string nombre, decimal precio, decimal costo, decimal descuento, string descripcion, int cantidad)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Costo = costo;
            Descuento = descuento;
            Descripcion = descripcion;
            Cantidad = cantidad;
        }


    }
}
