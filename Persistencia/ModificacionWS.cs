using Datos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Persistencia
{
    internal class ModificacionWS
    {
    }

    public class UsuarioRepository 
    {
        private readonly HttpClient _httpClient;

        public UsuarioRepository()
        {
            _httpClient = new HttpClient();
        }

        public bool CambioPassword(string nombreuser, string contraseña, string nuevacontraseña)
        {
            string jsonrequest = $"{{\"nombreUsuario\":\"{nombreuser}\",\"contraseña\":\"{contraseña}\",\"contraseñaNueva\":\"{nuevacontraseña}\"}}";
            HttpResponseMessage response = WebHelper.Patch("Usuario/CambiarContraseña", jsonrequest);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                return false;
            }

            return true;
        }
           
    }

}
