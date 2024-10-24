using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Login
{
    public class AgregarProductos
    {
        //string idadmin = "1653c7ec-870d-468a-b581-9800961d53d2";

        public AgregarProductos()
        {
        }

        public String AgregarProductoConValidaciones(int idCategoria, string idUsuario, string idProveedor, String nombre, double precio, int stock)
        {
            ObtenerProductosWS _obtenerproductos = new ObtenerProductosWS();
            // Aquí puedes añadir reglas de negocio, como validaciones adicionales
            if (precio <= 0)
            {
                return "El precio debe ser mayor que cero";
            }

            if (stock < 0)
            {
                return "El stock no puede ser negativo";
            }

            // Llamamos al método de la capa de datos (repositorio)
            return _obtenerproductos.AgregarProducto(idCategoria, idUsuario, idProveedor, nombre, precio, stock);
        }

    }
}
