using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodosvirtuales
{
    public class Program
    {
        static void Main(string[] args)
        {

            Cono obj = new Cono(5,10,4);
            Cilindro obj2 = new Cilindro(6,14);
            Console.WriteLine("El volumen del cono es: " + obj.Volumen().ToString());
            Console.WriteLine("El volumen del cilindro es: " + obj2.Volumen().ToString());
            Console.ReadKey();
        }
    }
}
