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
        private LoginDB loginDB = new LoginDB();

        // Este método bloquea al usuario modificando su estado en la base de datos
        public void bloquearUsuario(string usuario)
        {
            DBHelper dbHelper = new DBHelper("estado_usuarios");
            dbHelper.Modificar(usuario, "bloqueado");
        }

        // Este método verifica si el usuario está bloqueado en la base de datos
        public bool estaBloqueado(string usuario)
        {
            DBHelper dbHelper = new DBHelper("estado_usuarios");
            string estado = dbHelper.Buscar(usuario);
            return estado == "bloqueado";
        }
        public String login(string usuario, string password)
        {
            String perfilLogin = "";
            string nombre = "";

            LoginWS loginWS = new LoginWS();

            // Verificar si el usuario está bloqueado
            if (estaBloqueado(usuario))
            {
                return "Usuario bloqueado. Contacte con el Administrador.";
            }

            // Obtener la lista de usuarios activos desde el servicio
            List<UsuarioWS> usuariosActivos = loginWS.buscarDatosUsuario();

            // Verificar si el usuario está en la lista de usuarios activos
            UsuarioWS usuarioActivo = usuariosActivos.FirstOrDefault(u => u.NombreUsuario == usuario);

            if (usuarioActivo == null)
            {
                // El usuario no está en la lista, lo marcamos como inactivo
                return "Usuario no activo";
            }

            // Obtener los intentos de login desde la base de datos
            int intentos = loginDB.obtenerIntentos(usuario);

            // Si ya excedió los 3 intentos, retornamos que la cuenta está bloqueada
            if (intentos >= 3)
            {
                bloquearUsuario(usuario); // Bloqueamos al usuario después de 3 intentos fallidos
                return "Cuenta bloqueada por intentos fallidos";
            }

            // Verificar las credenciales de login
            String idUsuario = loginWS.login(usuario, password);

            if (idUsuario == "Error")
            {
                // Incrementar intentos si las credenciales no son válidas
                intentos++;
                loginDB.actualizarIntento(usuario, intentos.ToString()); // Guardamos los intentos en la base de datos

                if (intentos < 3)
                {
                    return "Error"; // Si no alcanzamos el límite, retornamos "Error"
                }
                else
                {
                    // Si llega al tercer intento fallido, consideramos la cuenta bloqueada
                    bloquearUsuario(usuario); // Llamamos al método que bloquea al usuario
                    return "Cuenta bloqueada por intentos fallidos";
                }
            }

            // Si el login es exitoso, reiniciamos los intentos
            loginDB.actualizarIntento(usuario, "0");

            // Obtener el perfil del usuario logueado
            int perfilUsuarioLogueado = usuarioActivo.Host;
            nombre = usuarioActivo.Nombre;

            // Asignar el perfil según el valor del perfilUsuarioLogueado
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

            // Retornar el perfil y el nombre del usuario
            return perfilLogin + " " + nombre;
        }
    }
}





