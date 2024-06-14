using Metodovirtuales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodosvirtuales
{
    public class Cilindro : CuerpoRevolucion
    {

        private double altura;
        public Cilindro(double altura, double radio) : base(radio)
        {
            this.altura = altura;
        }

        public override double Volumen()
        {
            return PI * radio * radio * altura;
        }
    }
}
