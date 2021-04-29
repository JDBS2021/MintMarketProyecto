using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public abstract class  Pago
    {
        public decimal ValorPagar { get; set; }
        public decimal Cambio { get; set; }
        public int EstadoPago { get; set; }

        public abstract String Pagar();
    }
}
