using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio21._7
{
    internal class VentasTotales
    {
        private double[,] ventas;

        public VentasTotales(double[,] ventas)
        {
            this.ventas = ventas;
        }

        public double[] CalcularTotalesPorProducto()
        {
            double[] totalesPorProducto = new double[4]; 

            CalcularTotalesPorProductoRecursivo(0, totalesPorProducto);
            return totalesPorProducto;
        }

        private void CalcularTotalesPorProductoRecursivo(int fila, double[] totalesPorProducto)
        {
            if (fila == 4) 
                return;

            double total = 0;
            for (int columna = 0; columna < 3; columna++) 
            {
                total += ventas[fila, columna];
            }

            totalesPorProducto[fila] = total;

            CalcularTotalesPorProductoRecursivo(fila + 1, totalesPorProducto);
        }

        public double[] CalcularTotalesPorMes()
        {
            double[] totalesPorMes = new double[3]; 

            CalcularTotalesPorMesRecursivo(0, totalesPorMes);
            return totalesPorMes;
        }

        private void CalcularTotalesPorMesRecursivo(int mes, double[] totalesPorMes)
        {
            if (mes == 3) 
                return;

            double total = 0;
            for (int fila = 0; fila < 4; fila++) 
            {
                total += ventas[fila, mes];
            }

            totalesPorMes[mes] = total;

            CalcularTotalesPorMesRecursivo(mes + 1, totalesPorMes);
        }
    }
}
