using Metodovirtuales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodosvirtuales
{
    
    public class Cono : CuerpoRevolucion
    {
        private double altura, generatriz;

        public Cono(double radio, double altura, double generatriz) : base(radio)
        {
            this.altura = altura;
            this.generatriz = generatriz;
        }

        public override double Volumen()
        {
            return (1.0 / 3) * PI * radio * radio * altura;
        }
    }
}
