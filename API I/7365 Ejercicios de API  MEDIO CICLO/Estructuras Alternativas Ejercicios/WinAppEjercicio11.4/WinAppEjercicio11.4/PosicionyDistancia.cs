using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio11._4
{
    internal class PosicionyDistancia
    {
        double ValorX, ValorY;
        int n;
        string fraseC;

        public PosicionyDistancia(double ValorX, double ValorY)
        {
            this.ValorX = ValorX;
            this.ValorY = ValorY;
        }

        public string Posicion()
        {
            if (ValorX == 0 && ValorY == 0)
            {
                fraseC = "En el origen";
            }
            else if (ValorX == 0)
            {
                fraseC = "En el eje Y";
            }
            else if (ValorY == 0)
            {
                fraseC = "En el eje X";
            }
            else if (ValorX > 0 && ValorY > 0)
            {
                fraseC = "En el primer cuadrante";
            }
            else if (ValorX < 0 && ValorY > 0)
            {
                fraseC = "En el segundo cuadrante";
            }
            else if (ValorX < 0 && ValorY < 0)
            {
                fraseC = "En el tercer cuadrante";
            }
            else if (ValorX > 0 && ValorY < 0)
            {
                fraseC = "En el cuarto cuadrante";
            }

            return fraseC;
        }

        public int ImagenC()
        {
            if (ValorX == 0 && ValorY == 0)
            {
                n = 0;
            }
            else if (ValorX == 0)
            {
                n = 5; 
            }
            else if (ValorY == 0)
            {
                n = 6; 
            }
            else if (ValorX > 0 && ValorY > 0)
            {
                n = 1; 
            }
            else if (ValorX < 0 && ValorY > 0)
            {
                n = 2; 
            }
            else if (ValorX < 0 && ValorY < 0)
            {
                n = 3; 
            }
            else if (ValorX > 0 && ValorY < 0)
            {
                n = 4; 
            }

            return n;
        }

        public double CalcularD()
        {
            return Math.Sqrt(ValorX * ValorX + ValorY * ValorY);
        }
    }
}
