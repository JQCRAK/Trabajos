using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio18._4
{
    public class Matriz
{
    private int[,] valores;
    private int filas;
    private int columnas;

    public Matriz(int filas, int columnas)
    {
        this.filas = filas;
        this.columnas = columnas;
        valores = new int[filas, columnas];
    }

    public void AsignarValor(int fila, int columna, int valor)
    {
    if (fila >= 0 && fila < filas && columna >= 0 && columna < columnas)
    {
        if (valor < 0 || valor > 0) 
        {
            valores[fila, columna] = valor;
        }
        else
        {
            throw new ArgumentException("Solo se permiten valores positivos o negativos.");
        }
    }
    else
    {
        throw new ArgumentException("Índice fuera de rango.");
    }
    }


    public int ContarPositivos()
    {
        int positivos = 0;
        foreach (int valor in valores)
        {
            if (valor > 0)
                positivos++;
        }
        return positivos;
    }

    public int ContarNegativos()
    {
        int negativos = 0;
        foreach (int valor in valores)
        {
            if (valor < 0)
                negativos++;
        }
        return negativos;
    }

    public int SumarElementos()
    {
        int suma = 0;
        foreach (int valor in valores)
            suma += valor;
        return suma;
    }

    public int SumarColumnasPares()
    {
        int suma = 0;
        for (int j = 1; j < columnas; j += 2)  
        {
            for (int i = 0; i < filas; i++)
            {
                suma += valores[i, j];
            }
        }
        return suma;
    }

    public long MultiplicarNegativos()
    {
        long producto = 1;
        bool hayNegativos = false;

        foreach (int valor in valores)
        {
            if (valor < 0)
            {
                producto *= valor;
                hayNegativos = true;
            }
        }

        return hayNegativos ? producto : 0;
    }
}
}
