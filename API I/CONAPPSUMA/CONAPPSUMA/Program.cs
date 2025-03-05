using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONAPPSUMA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Numero de parametros son {0}",args.Length);
            if (args.Length == 2)
            {
                int Suma = int.Parse(args[0]) + int.Parse(args[1]);
                Console.WriteLine("La suma de 2 numero es: {0}", Suma);
            }
            else
            {
                Console.WriteLine("Solo ingrese 2 valores");
            }

        }

    }
}
