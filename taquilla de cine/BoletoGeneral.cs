using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taquilla_de_cine
{
    public class BoletoGeneral : boleto
    {
        public BoletoGeneral(float precioBase):base (precioBase)
        {

        }

        public override float calcularPagoFinal()
        {
            return precioBase;
        }
    }
}
