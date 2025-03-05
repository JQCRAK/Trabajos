using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio17._3
{
    internal class Serie
    {
        private int numeroTerminos;

        public Serie(int numeroTerminos)
        {
            this.numeroTerminos = numeroTerminos;
        }

        public double CalcularSerie()
        {
            double resultado = 0;

            for (int i = 1; i <= numeroTerminos; i++)
            {
                if (i % 2 == 1) 
                {
                    int numerador = 4 * ((i - 1) / 2) + 1;
                    int exponente = 2 * ((i - 1) / 2) + 1; 
                    int factorialDenominador = 4 * ((i - 1) / 2) + 2;

                    resultado += Math.Pow(numerador, exponente) / CalcularFactorial(factorialDenominador);
                }
                else 
                {
                    int factorialNumerador = 4 * (i / 2);
                    int baseDenominador = 4 * (i / 2) - 1;
                    int exponenteDenominador = 2 * (i / 2); 

                    resultado += -CalcularFactorial(factorialNumerador) / Math.Pow(baseDenominador, exponenteDenominador);
                }
            }

            return resultado;
        }

        private double CalcularFactorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return n * CalcularFactorial(n - 1);
        }
    }
}
