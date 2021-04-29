using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class PagoEfectivo: Pago
    {
        public decimal ValorRecibido { get; set; }

        public override String Pagar()
        {
            if (ValorRecibido < ValorPagar)
            {
                return "El Valor Recibido es insuficiente";
            }
            else
            {
                Cambio = ValorRecibido - ValorPagar;
                return "Pago Exitoso";
                    
            }

        }
    }
}
