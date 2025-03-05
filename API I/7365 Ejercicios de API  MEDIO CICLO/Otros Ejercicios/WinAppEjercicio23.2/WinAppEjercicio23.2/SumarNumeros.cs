using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinAppEjercicio23._2
{
    internal class SumarNumeros
    {
        private string cadena;

        public SumarNumeros(string cadena)
        {
            this.cadena = cadena;
        }

        public int CalcularSuma()
        {
            int sumaTotal = 0;

            var matches = Regex.Matches(cadena, @"\d+");

            foreach (var match in matches)
            {
                sumaTotal += int.Parse(match.ToString());
            }

            return sumaTotal;
        }
    }
}
