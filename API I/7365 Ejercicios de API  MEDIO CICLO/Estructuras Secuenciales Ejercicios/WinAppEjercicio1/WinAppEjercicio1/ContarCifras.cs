using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio1
{
    internal class ContarCifras
    {
        long numero;
        int cc;

        public ContarCifras(long numero)
        {
            this.numero = numero;
            this.cc = 0;
        }

        public int CifraNumero()
        {
            numero = Math.Abs(numero);
            return cc = (int)(Math.Log10(numero)) + 1;
        }
    }
}
