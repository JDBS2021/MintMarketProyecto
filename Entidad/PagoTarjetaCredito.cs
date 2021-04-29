using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class PagoTarjetaCredito : Pago
    {
        public String numeroTarjeta { get; set; }
        public String fechaVencimiento { get; set; }
        public int CCV { get; set; }
        public override string Pagar()
        {
            return "Pago Exitoso";
        }
    }
}
