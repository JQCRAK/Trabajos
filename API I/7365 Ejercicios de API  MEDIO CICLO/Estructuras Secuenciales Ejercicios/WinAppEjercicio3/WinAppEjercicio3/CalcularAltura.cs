using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio3
{
    internal class CalcularAltura
    {
        private double tiempo;
        public CalcularAltura(double tiempo)
        {
            this.tiempo = tiempo;
        }
        public double Caltura()
        {
            return 0.5 * 9.8 * Math.Pow(tiempo, 2);
        }
    }
}
