using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Operaciones
    {
        Conexion objConexion = new Conexion();
        public void IngresarProv(Entidades Datos)
        {

            objConexion.Abrir();
            string CadenaSql = "INSERT INTO prov(nombre, direccion, ciudad, provincia)" +
                "Values ('" + Datos.nombreE + "','" + Datos.direccionE + "', '" + Datos.ciudadE + "','" + Datos.provinciaE + "')";

            SqlCommand Comando = new SqlCommand(CadenaSql, objConexion.conectar);

            Comando.ExecuteNonQuery();
            objConexion.Cerrar();
        }


        public DataTable ObtenerProveedorYPiezas(string nombreProveedor)
        {
            DataTable dataTable = new DataTable();

            try
            {
                objConexion.Abrir();

                string query = @"
            SELECT 
                p.nombre AS NombreProveedor,
                p.direccion AS Direccion,
                p.ciudad AS Ciudad,
                p.provincia AS Provincia,
                pi.nombreP AS NombrePieza,
                pi.color AS Color,
                pi.categ AS Categoria,
                c.precio AS Precio,
                s.cantidad AS Cantidad
            FROM 
                prov p
            INNER JOIN 
                suministra s ON p.nombre = s.nombre
            INNER JOIN 
                pieza pi ON s.nombreP = pi.nombreP
            INNER JOIN 
                categoria c ON pi.categ = c.categ
            WHERE 
                p.nombre = @NombreProveedor";

                SqlCommand cmd = new SqlCommand(query, objConexion.conectar);
                cmd.Parameters.AddWithValue("@NombreProveedor", nombreProveedor);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);

                objConexion.Cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener proveedor y piezas: " + ex.Message);
                objConexion.Cerrar();
            }

            return dataTable;
        }



        public void IngresarPieza(Entidades Datos)
        {

            try
            {
                objConexion.Abrir();
                
                string CadenaSqlInsert = "INSERT INTO pieza (nombreP, color, centro, categ) " +
                                          "VALUES ('" + Datos.nombrePE + "','" + Datos.colorE + "','" + Datos.centroE + "','" + Datos.categE + "')";

                SqlCommand ComandoInsert = new SqlCommand(CadenaSqlInsert, objConexion.conectar);
                ComandoInsert.ExecuteNonQuery();
                
                string CadenaSqlActualizarCategoria = @"
                IF EXISTS (SELECT 1 FROM total_por_categoria WHERE categ = @Categ)
                    BEGIN
                        UPDATE total_por_categoria
                        SET total_piezas = total_piezas + 1
                        WHERE categ = @Categ
                    END
                ELSE
                    BEGIN
                        INSERT INTO total_por_categoria (categ, total_piezas)
                        VALUES (@Categ, 1)
                    END";

                SqlCommand ComandoActualizar = new SqlCommand(CadenaSqlActualizarCategoria, objConexion.conectar);
                ComandoActualizar.Parameters.AddWithValue("@Categ", Datos.categE);

                ComandoActualizar.ExecuteNonQuery();

                objConexion.Cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar pieza y actualizar la categoría: " + ex.Message);
                objConexion.Cerrar();
            }
        }

        public void IngresarSuministro(Entidades Datos)
        {

            try
            {
                objConexion.Abrir();

                string CadenaSqlInsert = "INSERT INTO suministra (nombre, nombreP, cantidad) " +
                                          "VALUES ('" + Datos.nombreE + "','" + Datos.nombrePE + "','" + Datos.cantidadE + "')";

                SqlCommand ComandoInsert = new SqlCommand(CadenaSqlInsert, objConexion.conectar);
                ComandoInsert.ExecuteNonQuery();

                string CadenaSqlActualizarProveedor = @"
                        IF EXISTS (SELECT 1 FROM total_suministros_proveedor WHERE nombre = @Nombre)
                            BEGIN
                                UPDATE total_suministros_proveedor
                                SET total_suministros = total_suministros + @Cantidad
                                WHERE nombre = @Nombre
                            END
                        ELSE
                            BEGIN
                                INSERT INTO total_suministros_proveedor (nombre, total_suministros)
                                VALUES (@Nombre, @Cantidad)
                            END";

                SqlCommand ComandoActualizarProveedor = new SqlCommand(CadenaSqlActualizarProveedor, objConexion.conectar);
                ComandoActualizarProveedor.Parameters.AddWithValue("@Nombre", Datos.nombreE);
                ComandoActualizarProveedor.Parameters.AddWithValue("@Cantidad", Datos.cantidadE);

                ComandoActualizarProveedor.ExecuteNonQuery();

                objConexion.Cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar suministro y actualizar el proveedor: " + ex.Message);
                objConexion.Cerrar();
            }
        }

        public void IngresarCategoria(Entidades Datos)
        {
            objConexion.Abrir();

            string precioTexto = Datos.precioE.ToString().Replace(',', '.');
            decimal precio = decimal.Parse(precioTexto, System.Globalization.CultureInfo.InvariantCulture);

            string CadenaSql = "INSERT INTO categoria (categ, precio) VALUES ('" + Datos.categE + "', @Precio)";

            SqlCommand Comando = new SqlCommand(CadenaSql, objConexion.conectar);

            Comando.Parameters.AddWithValue("@Precio", precio);

            Comando.ExecuteNonQuery();
            objConexion.Cerrar();
        }

        public List<string> ObtenerCategorias()
        {
            List<string> categorias = new List<string>();

            try
            {
                objConexion.Abrir();
                string query = "SELECT categ FROM categoria";
                SqlCommand cmd = new SqlCommand(query, objConexion.conectar);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    categorias.Add(reader["categ"].ToString());
                }
                objConexion.Cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar las categorías: " + ex.Message);
            }

            return categorias;
        }


        public List<string> ObtenerPiezas()
        {
            List<string> nombresP = new List<string>();

            try
            {
                objConexion.Abrir();
                string query = "SELECT nombreP FROM pieza";
                SqlCommand cmd = new SqlCommand(query, objConexion.conectar);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nombresP.Add(reader["nombreP"].ToString());
                }
                objConexion.Cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar las nombres de pieza: " + ex.Message);
            }

            return nombresP;
        }


        public List<string> ObtenerProve()
        {
            List<string> nombres = new List<string>();

            try
            {
                objConexion.Abrir();
                string query = "SELECT nombre FROM prov";
                SqlCommand cmd = new SqlCommand(query, objConexion.conectar);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nombres.Add(reader["nombre"].ToString());
                }
                objConexion.Cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar las nombres de pieza: " + ex.Message);
            }

            return nombres;
        }


        public Entidades ObtenerPiezaPorNombre(string nombrePieza)
        {
            Entidades pieza = null;

            try
            {
                objConexion.Abrir();
                string query = "SELECT * FROM pieza WHERE nombreP = '" + nombrePieza + "'";
                SqlCommand cmd = new SqlCommand(query, objConexion.conectar);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    pieza = new Entidades
                    {
                        nombrePE = reader["nombreP"].ToString(),
                        colorE = reader["color"].ToString(),
                        centroE = reader["centro"].ToString(),
                        categE = reader["categ"].ToString()
                    };
                }

                objConexion.Cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la pieza: " + ex.Message);
            }

            return pieza; 
        }

        public DataTable ObtenerNombresProveedores()
        {
            DataTable dataTable = new DataTable();

            try
            {
                objConexion.Abrir();

                string query = "SELECT nombre FROM prov";
                SqlCommand cmd = new SqlCommand(query, objConexion.conectar);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener nombres de proveedores: " + ex.Message);
            }
            finally
            {
                objConexion.Cerrar();
            }

            return dataTable;
        }


        public Entidades BuscarProveedorPorNombre(string nombreProveedor)
        {
            Entidades proveedor = null;

            try
            {
                objConexion.Abrir();
                string cadenaSQL = "SELECT * FROM prov WHERE nombre = '" + nombreProveedor + "'";
                SqlCommand comando = new SqlCommand(cadenaSQL, objConexion.conectar);
                SqlDataReader dataReader = comando.ExecuteReader();

                if (dataReader.Read())
                {
                    proveedor = new Entidades
                    {
                        nombreE = Convert.ToString(dataReader["nombre"]),
                        direccionE = Convert.ToString(dataReader["direccion"]),
                        ciudadE = Convert.ToString(dataReader["ciudad"]),
                        provinciaE = Convert.ToString(dataReader["provincia"])
                    };
                }

                dataReader.Close();
                objConexion.Cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar el proveedor: " + ex.Message);
            }

            return proveedor; 
        }


        public void ModificarProveedor(Entidades proveedor)
        {
            try
            {
                objConexion.Abrir();

                string query = "UPDATE prov SET direccion = '" + proveedor.direccionE + "', " +
                               "ciudad = '" + proveedor.ciudadE + "', " +
                               "provincia = '" + proveedor.provinciaE + "' " +
                               "WHERE nombre = '" + proveedor.nombreE + "'";

                SqlCommand comando = new SqlCommand(query, objConexion.conectar);
                SqlDataReader dataReader = comando.ExecuteReader();
                dataReader.Close();
                comando.ExecuteNonQuery();

                objConexion.Cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar el proveedor: " + ex.Message);
            }
        }

        public void EliminarProveedor(string nombreProveedor)
        {
            try
            {
                objConexion.Abrir();

                string eliminarProveedor = "DELETE FROM prov WHERE nombre = @nombreProveedor";
                SqlCommand cmd = new SqlCommand(eliminarProveedor, objConexion.conectar);
                cmd.Parameters.AddWithValue("@nombreProveedor", nombreProveedor);
                cmd.ExecuteNonQuery();

                objConexion.Cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el proveedor: " + ex.Message);
            }
        }
    }
}
