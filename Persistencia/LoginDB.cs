using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class LoginDB
    {
        // Guardar el intento inicial en la base de datos (cuando es el primer intento fallido)
        public void guardarIntento(String username)
        {
            DBHelper dbHelper = new DBHelper("intentos_login");
            dbHelper.Insertar(username, "1");
        }

        // Actualizar la cantidad de intentos para el usuario
        public void actualizarIntento(String username, String newValue)
        {
            DBHelper dbHelper = new DBHelper("intentos_login");
            dbHelper.Modificar(username, newValue);
        }

        // Obtener la cantidad de intentos fallidos de login para un usuario
        public int obtenerIntentos(String username)
        {
            DBHelper dbHelper = new DBHelper("intentos_login");
            String valor = dbHelper.Buscar(username);

            if (valor == null)
            {
                // Si no hay ningún intento registrado, retornamos 0
                valor = "0";
                guardarIntento(username); // Lo registramos para próximas fallas
            }

            return int.Parse(valor);
        }
    


        public String obtenerArray(String key)
        {
            DBHelper dbHelper = new DBHelper("intentos_login");
            String valor = dbHelper.Buscar(key);
            return valor;
        }

        public void modificarDatos(String key, String newValue)
        {
            DBHelper dbHelper = new DBHelper("intentos_login");
            dbHelper.Modificar(key, newValue);
        }

        public void guardarArray(List<String> datos)
        {
            DBHelper dbHelper = new DBHelper("intentos_login");
            String correosElectronicos = "";
            foreach (String correo in datos)
            {
                correosElectronicos = correosElectronicos + "," + correo;
            }
            dbHelper.Insertar("correosElectronicos", correosElectronicos);

        }
    }
}

