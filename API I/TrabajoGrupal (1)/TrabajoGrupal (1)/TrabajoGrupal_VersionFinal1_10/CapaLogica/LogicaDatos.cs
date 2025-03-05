using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogicaDatos
    {
        Operaciones objOperacion = new Operaciones();
        Entidades objEntidades = new Entidades();

        public void InsertarProv(Entidades Datos)
        {
            objOperacion.IngresarProv(Datos);
        }

        public void InsertarPieza(Entidades Datos)
        {
            objOperacion.IngresarPieza(Datos);
        }

        public void IngresarCategoria(Entidades Datos)
        {
            objOperacion.IngresarCategoria(Datos);
        }

        public void IngresarSuministro(Entidades Datos)
        {
            objOperacion.IngresarSuministro(Datos);
        }

        public List<string> ObtenerCategorias()
        {
            return objOperacion.ObtenerCategorias();
        }

        public List<string> ObtenerPieza()
        {
            return objOperacion.ObtenerPiezas();
        }

        public List<string> ObtenerProvedor()
        {
            return objOperacion.ObtenerProve();
        }

        public Entidades ObtenerPiezaPorNombre(string nombrePieza)
        {
            return objOperacion.ObtenerPiezaPorNombre(nombrePieza);
        }

        public void EliminarProveedor(string nombreProveedor)
        {
            objOperacion.EliminarProveedor(nombreProveedor);
        }

        public Entidades ObtenerProveedor(string nombreProveedor)
        {
            return objOperacion.BuscarProveedorPorNombre(nombreProveedor);

        }

        public void ModificarProveedor(Entidades Datos)
        {
            objOperacion.ModificarProveedor(Datos);
        }

        public DataTable ObtenerProveedorYPiezas(string nombreProveedor)
        {
            return objOperacion.ObtenerProveedorYPiezas(nombreProveedor);
        }
        public DataTable ObtenerNombresProveedores()
        {
            return objOperacion.ObtenerNombresProveedores();
        }


    }
}
