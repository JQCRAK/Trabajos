using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio19._5
{
    internal class Matriz
    {
        private int[,] datos;

        public Matriz(int tamaño)
        {
            datos = new int[tamaño, tamaño];
        }

        public void EstablecerValor(int fila, int columna, int valor)
        {
            datos[fila, columna] = valor;
        }

        // Corregido: Triángulo superior SIN incluir la diagonal principal
        public int ObtenerMayorTrianguloSuperior()
        {
            int mayor = int.MinValue;
            int tamaño = datos.GetLength(0);

            // Recorremos solo el triángulo superior sin la diagonal
            for (int i = 0; i < tamaño; i++)
            {
                for (int j = i + 1; j < tamaño; j++) // j empieza en i + 1 para excluir la diagonal
                {
                    if (datos[i, j] > mayor)
                    {
                        mayor = datos[i, j];
                    }
                }
            }
            return mayor;
        }

        // Obtener el menor elemento de la diagonal principal
        public int ObtenerMenorDiagonal()
        {
            int menor = int.MaxValue;
            int tamaño = datos.GetLength(0);

            for (int i = 0; i < tamaño; i++)
            {
                if (datos[i, i] < menor)
                {
                    menor = datos[i, i];
                }
            }
            return menor;
        }

        // Corregido: Triángulo inferior SIN incluir la diagonal principal
        public int CalcularSumaTrianguloInferior()
        {
            int suma = 0;
            int tamaño = datos.GetLength(0);

            // Recorremos solo el triángulo inferior sin la diagonal
            for (int i = 1; i < tamaño; i++)
            {
                for (int j = 0; j < i; j++) // j < i para excluir la diagonal
                {
                    suma += datos[i, j];
                }
            }
            return suma;
        }
    }
}
