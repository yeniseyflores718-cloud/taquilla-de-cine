using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taquilla_de_cine.Resources
{
    public class BoletoAdultoMayor : boleto
    {
        public string NumCredencialInapam { get; set; }

        public BoletoAdultoMayor(float precioBase,string numCredencial):
            base(precioBase)

        {
            NumCredencialInapam = numCredencial;

        }
        public override float calcularPagoFinal()
        {
            return precioBase * 0.50f;
        }

    }
}
