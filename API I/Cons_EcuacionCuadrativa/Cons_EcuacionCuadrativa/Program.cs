using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cons_EcuacionCuadrativa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de una Ecuación Cuadrática");
            Console.WriteLine("Ingrese el valor de a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de c: ");
            double c = double.Parse(Console.ReadLine());

            double dis = (b * b) - 4 * a * c;
            Console.WriteLine("El cálculo de la Ecuación Cuadrática es: {0}",dis);
        }
    }
}
