using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio6
{
    internal class CalcularFuerzaG
    {
        double masa1, masa2, distancia;

        public CalcularFuerzaG(double masa1, double masa2, double distancia)
        {
            this.masa1 = masa1;
            this.masa2 = masa2;
            this.distancia = distancia;
        }

        public double FuerzaGra()
        {
            const double G = 6.67430e-11; 
            return G * (masa1 * masa2) / Math.Pow(distancia, 2); 
        }
    }
}
