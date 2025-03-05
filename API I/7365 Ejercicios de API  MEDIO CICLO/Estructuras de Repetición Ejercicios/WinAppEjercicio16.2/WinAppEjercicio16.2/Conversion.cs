using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio16._2
{
    internal class Conversion
    {
        private int inicio;
        private int fin;

        public Conversion(int inicio, int fin)
        {
            this.inicio = inicio;
            this.fin = fin;
        }

        public List<(string pulgadas, string centimetros)> GenerarTabla()
        {
            if (inicio < 48 || fin > 84 || inicio > fin)
                return null; 

            return GenerarTablaRecursiva(inicio);
        }

        private List<(string pulgadas, string centimetros)> GenerarTablaRecursiva(int actual)
        {
            if (actual > fin)
                return new List<(string pulgadas, string centimetros)>();

            double centimetros = actual * 2.54;
            string pulgadasFormateadas = $"{actual}\"";
            string centimetrosFormateados = $"{centimetros:F2} cm";

            var tabla = GenerarTablaRecursiva(actual + 1);

            tabla.Insert(0, (pulgadasFormateadas, centimetrosFormateados));
            return tabla;
        }
    }
}
