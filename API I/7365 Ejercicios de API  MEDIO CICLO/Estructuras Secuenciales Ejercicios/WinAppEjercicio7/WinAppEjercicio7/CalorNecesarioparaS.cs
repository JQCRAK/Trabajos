using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio7
{

    public class CalorNecesarioparaS
    {
        double Masa, Capacidad, TInicial, TFinal;

        public CalorNecesarioparaS(double Masa, double Capacidad, double TInicial, double TFinal)
        {
            this.Masa = Masa;
            this.Capacidad = Capacidad;
            this.TInicial = TInicial;
            this.TFinal = TFinal;
        }

        public double CNecesario()
        {
            return (Masa * Capacidad * (TFinal - TInicial)); 
        }
    }

}
