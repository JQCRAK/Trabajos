using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinAppEjercicio2
{
    internal class CalcularEnergiaCinetica
    {
        double masa, velocidad;

        public CalcularEnergiaCinetica(double masa, double velocidad)
        {
            this.masa = masa;
            this.velocidad = velocidad;
        }

        public double EnergiaCinetica()
        {
            return 0.5 * masa * Math.Pow(velocidad, 2);
        }
    }
}
