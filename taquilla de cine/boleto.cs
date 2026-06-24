using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taquilla_de_cine
{
    public abstract class boleto
    {
        public float precioBase { get; set; }   
        protected boleto(float precioBase)
        {
            this.precioBase = precioBase;
        }
        public abstract float calcularPagoFinal();  
    }
}
