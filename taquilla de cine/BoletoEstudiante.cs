using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taquilla_de_cine
{
    internal class BoletoEstudiante:boleto
    {
        public string Matricula { get; set; }

        public BoletoEstudiante(float precioBase, string matricula) : base (precioBase)
        {
            Matricula = matricula;
        }

        public override float calcularPagoFinal()
        {
            return precioBase * 0.70f;
        }
    }
}
