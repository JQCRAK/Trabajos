using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppEjercicio4
{
    internal class CalcularSalarioN
    {
        private double TarifaxH, HorasTra;
        private double SalarioBr, Impuestos, SalarioNeto;

        public CalcularSalarioN(double TarifaxH, double HorasTra)
        {
            this.TarifaxH = TarifaxH;
            this.HorasTra = HorasTra;
            CalcularTodo();
        }

        private void CalcularTodo()
        {
            SalarioBr = Math.Round(TarifaxH * HorasTra, 2); 

            Impuestos = Math.Round(SalarioBr * 0.12, 2);

            SalarioNeto = Math.Round(SalarioBr - Impuestos, 2);
        }

        public double ObtenerSalarioBruto()
        {
            return SalarioBr;
        }

        public double ObtenerImpuestos()
        {
            return Impuestos;
        }

        public double ObtenerSalarioNeto()
        {
            return SalarioNeto;
        }   
    }
    
}
