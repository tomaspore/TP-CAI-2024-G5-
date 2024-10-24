using Datos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ObtenerProductosWS
    {
        //private String adminId = "1653c7ec-870d-468a-b581-9800961d53d2";

        public String AgregarProducto(int idCategoria, string idUsuario, string idProveedor, String nombre, double precio, int stock)
        {
            // Crear el diccionario con los parámetros del producto
            Dictionary<String, Object> datos = new Dictionary<String, Object>
    {
        { "idCategoria", idCategoria },
        { "idUsuario", idUsuario },
        { "idProveedor", idProveedor },
        { "nombre", nombre },
        { "precio", precio },
        { "stock", stock }
    };

            // Convertir los datos a una cadena JSON
            var jsonData = JsonConvert.SerializeObject(datos);

            try
            {
                // Enviar la solicitud POST al servicio web
                HttpResponseMessage response = WebHelper.Post("Producto/AgregarProducto", jsonData);

                // Si la respuesta no es exitosa, retornar "Error" sin lanzar una excepción
                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    return "Error";
                }

                // Leer la respuesta y deserializarla
                var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                var resultado = JsonConvert.DeserializeObject<String>(reader.ReadToEnd());

                return resultado; // Devolver el resultado del servicio web
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine($"Excepción: {ex.Message}");
                return "Error";
            }
        }

        public List<ProductoWS> buscarDatosProductos()
        {
            List<ProductoWS> productos = new List<ProductoWS>();

            try
            {
                HttpResponseMessage response = WebHelper.Get("Producto/TraerProductos");

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    return null; // Devuelve null si hay un problema
                }

                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<ProductoWS> listadoProductos = JsonConvert.DeserializeObject<List<ProductoWS>>(contentStream);
                return listadoProductos;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción: {ex.Message}");
                return null;
            }
        }
    }
}


