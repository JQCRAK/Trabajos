using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_AreaTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Área de un Triángulo");
            Console.WriteLine("Ingrese la Base");
            double Base_T = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Altura");
            double Altura_T = double.Parse(Console.ReadLine());
            double Area_Triangulo = Base_T * Altura_T/2;
            Console.WriteLine("El area del triangulo es : {0}",Area_Triangulo.ToString());
        }
    }
}

