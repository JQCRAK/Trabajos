using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio20._6
{
    internal class BuscarElemento
    {
        int[] arreglo;
        int tamaño;

        public BuscarElemento(int[] arreglo, int tamaño)
        {
            this.arreglo = arreglo;
            this.tamaño = tamaño;
        }

        public string Existe(int numero)
        {
            for (int i = 0; i < tamaño; i++)
            {
                if (arreglo[i] == numero)
                {
                    return "Sí Existe";
                }
            }
            return "No Existe";
        }

        public int ObtenerPosicion(int numero)
        {
            for (int i = 0; i < tamaño; i++)
            {
                if (arreglo[i] == numero)
                {
                    return i + 1;
                }
            }
            return -1;
        }
    }
}
