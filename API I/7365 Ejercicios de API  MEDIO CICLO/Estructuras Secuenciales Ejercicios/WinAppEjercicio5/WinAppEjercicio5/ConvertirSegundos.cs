using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio5
{
    internal class ConvertirSegundos
    {
        int segundos,horas,minutos;

        public ConvertirSegundos(int segundos) {
            this.segundos = segundos;
        }
        public string Convertir()
        {
            horas = segundos / 3600; 
            segundos %= 3600; 
            minutos = segundos / 60; 
            segundos %= 60; 

            return $"{horas:D2}:{minutos:D2}:{segundos:D2}";
        }
    }
}
