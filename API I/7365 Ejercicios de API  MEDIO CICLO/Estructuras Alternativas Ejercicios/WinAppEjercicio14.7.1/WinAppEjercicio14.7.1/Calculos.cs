using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio14._7._1
{
    internal class Calculos
    {
        private decimal iva;
        private decimal total;
        private decimal subtotal;

        public Calculos(decimal iva, decimal total, decimal subtotal)
        {
            this.iva = iva;
            this.total = total;
            this.subtotal = subtotal;
        }

        public decimal CIva()
        {
            iva = subtotal * 0.12m;
            return iva;
        }

        public decimal Ctotal()
        {
            total = subtotal + iva;
            return total;
        }
    }
}
