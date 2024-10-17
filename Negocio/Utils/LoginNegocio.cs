using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LoginNegocio
    {
        private int intentos = 0; //Manejamos los intentos desde acá
        public String login(string usuario,string password)
        {
            String perfilLogin = "";
            string nombre = "";

            
            LoginDB loginDB = new LoginDB();
            
            
             // circuito de bloqueado de usuario - faltaaaa
            
           
            LoginWS loginWS = new LoginWS();
            // Obtener el ID del usuario desde el servicio
            String idUsuario = loginWS.login(usuario, password);

            if (idUsuario == "Error")
            {
                // Incrementar intentos si las credenciales no son válidas
                intentos++;
                if (intentos == 3)
                {
                    // Bloquear el usuario o manejar su inactividad
                    return "Inactivo";
                }
                return "Error";
            }
                // Paso 2.2: Credenciales invalidas --falta

                // Paso 2.3: Credenciales validas--falta


                List<UsuarioWS> usuariosActivos = loginWS.BuscarDatosUsuario(idUsuario);

                // Paseo 3.1: Verificar que el usuario este activo-- falta


                int perfilUsuarioLogueado = 0;
            // Usar el foreach para encontrar el usuario por ID y obtener su perfil y nombre
            foreach (UsuarioWS usuarioActivo in usuariosActivos)
                {
                    if (usuarioActivo.Id.Equals(idUsuario))
                    {
                        perfilUsuarioLogueado = usuarioActivo.Perfil;
                        nombre = usuarioActivo.Nombre;
                        break; // Salimos del foreach al encontrar el usuario
                    }
                }
                        // Verificar si encontramos un usuario con el ID dado

            if (string.IsNullOrEmpty(nombre))
                {
                    return "Usuario no activo"; // Si no encontramos el usuario, retornamos este mensaje
                }

            if (perfilUsuarioLogueado == 3)
                {
                    perfilLogin = "Administrador";
                    
                }
                else if (perfilUsuarioLogueado == 2)
                {
                    perfilLogin = "Supervisor";
                }
                else
                {
                    perfilLogin = "Vendedor";
                }
            
            intentos = 0; //reiniciar intentos si el login es exitoso

            return perfilLogin + nombre; //retornar perfil y nombre
        }
           

        }




    }

