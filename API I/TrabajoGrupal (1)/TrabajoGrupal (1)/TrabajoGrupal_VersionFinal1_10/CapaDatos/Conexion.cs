using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        public string cadena = "Data Source = DESKTOP-MRQRIVS; Initial Catalog = Ejercicio5; Integrated Security = True ";
        public SqlConnection conectar = new SqlConnection();

        public Conexion()
        {
            conectar.ConnectionString = cadena;
        }
        public void Abrir()
        {
            try
            {
                conectar.Open();
                Console.WriteLine("Conexion Exitosa");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void Cerrar()
        {
            conectar.Close();
        }
    }
}
