using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio15._1
{
    internal class SerieFibonacci
    {
        private int numero;

        public SerieFibonacci(int numero)
        {
            this.numero = numero;
        }

        public string GenerarSerie()
        {
            if (numero < 1 || numero >= 50)
                return "Número inválido.Solo es hasta 50.";

            string resultado = string.Empty;

            for (int i = 0; i < numero; i++)
            {
                resultado += CalcularFibonacciRecursivo(i).ToString();
                if (i < numero - 1) resultado += ", "; 
            }

            return resultado;
        }

        private int CalcularFibonacciRecursivo(int n)
        {
            if (n == 0) return 0; 
            if (n == 1) return 1; 
            return CalcularFibonacciRecursivo(n - 1) + CalcularFibonacciRecursivo(n - 2);
        }
    }
}
