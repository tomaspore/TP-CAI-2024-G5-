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
    public class LoginWS
    {
        private String adminId = "1653c7ec-870d-468a-b581-9800961d53d2";

        public String login(String username, String password)
        {
            Dictionary<String, String> datos = new Dictionary<String, String>();
            datos.Add("nombreUsuario", username);
            datos.Add("contraseña", password);

            // Convert the data to a JSON string
            var jsonData = JsonConvert.SerializeObject(datos);

            try
            {
                HttpResponseMessage response = WebHelper.Post("Usuario/Login", jsonData);

                // Si la respuesta no es exitosa, retornamos "Error" sin lanzar una excepción
                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    return "Error"; // Manejo del error sin lanzar excepción
                }

                String idUsuario = "";
                var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                idUsuario = JsonConvert.DeserializeObject<String>(reader.ReadToEnd());

                return idUsuario;
            }
            catch (Exception ex)
            {
                // Cualquier excepción durante el proceso, devolvemos "Error"
                Console.WriteLine($"Excepción: {ex.Message}");
                return "Error";
            }
        }

        public List<UsuarioWS> buscarDatosUsuario()
        {
            List<UsuarioWS> clientes = new List<UsuarioWS>();

            try
            {
                HttpResponseMessage response = WebHelper.Get("Usuario/TraerUsuariosActivos?id=" + adminId);

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    return null; // Devuelve null si hay un problema
                }

                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<UsuarioWS> listadoClientes = JsonConvert.DeserializeObject<List<UsuarioWS>>(contentStream);
                return listadoClientes;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción: {ex.Message}");
                return null;
            }
        }
    }
}


