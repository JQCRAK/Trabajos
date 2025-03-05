using System;
using System.Collections.Generic;
using System.Linq;

public class PuntuacionGimnasta
{
    private decimal[] puntuaciones; 

    public PuntuacionGimnasta(float valor1, float valor2, float valor3, float valor4, float valor5)
    {
        puntuaciones = new decimal[] {
            (decimal)valor1,
            (decimal)valor2,
            (decimal)valor3,
            (decimal)valor4,
            (decimal)valor5
        };
    }

    public decimal CalcularPuntuacion()
    {
        decimal min = puntuaciones.Min();
        decimal max = puntuaciones.Max();
        decimal sumaTotal = puntuaciones.Sum();
        decimal sumaFiltrada = sumaTotal - min - max;
        decimal puntuacionFinal = sumaFiltrada / 3;

        return Math.Round(puntuacionFinal, 1); 
    }
}