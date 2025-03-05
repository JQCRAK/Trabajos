using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio20._6
{
    internal class Vector
    {
        private int[] vector;
        private int size;

        public Vector(int[] vector, int size)
        {
            this.vector = vector;
            this.size = size;
        }

        public void OrdenarAscendente()
        {
            Array.Sort(vector, 0, size);
        }

        public void OrdenarDescendente()
        {
            Array.Sort(vector, 0, size);
            Array.Reverse(vector, 0, size);
        }

        public int EncontrarMenor()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("El vector está vacío.");
            }

            int menor = vector[0];
            for (int i = 1; i < size; i++)
            {
                if (vector[i] < menor)
                {
                    menor = vector[i];
                }
            }
            return menor; 
        }

        public int EncontrarPosicionMenor()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("El vector está vacío.");
            }

            int menor = vector[0];
            int posicion = 0;
            for (int i = 1; i < size; i++)
            {
                if (vector[i] < menor)
                {
                    menor = vector[i];
                    posicion = i;
                }
            }
            return posicion+1; 
        }

        public int EncontrarMaximo()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("El vector está vacío.");
            }

            int maximo = vector[0];
            for (int i = 1; i < size; i++)
            {
                if (vector[i] > maximo)
                {
                    maximo = vector[i];
                }
            }
            return maximo; 
        }

        public int EncontrarPosicionMaximo()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("El vector está vacío.");
            }

            int maximo = vector[0];
            int posicion = 0;
            for (int i = 1; i < size; i++)
            {
                if (vector[i] > maximo)
                {
                    maximo = vector[i];
                    posicion = i;
                }
            }
            return posicion+1;
        }

        public int[] ObtenerVector()
        {
            return vector.Take(size).ToArray();
        }
    }
}
