using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class CategoriaProducto
    {
        public int Id { get; set; }
        public String Nombre { get; set; }

        private readonly List<Producto> Productos;

        public CategoriaProducto()
        {
            Productos = new List<Producto>();

        }

        public CategoriaProducto(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            Productos = new List<Producto>();

        }
    }
}
