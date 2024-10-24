using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioService()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        public bool CambiarContraseñaAsync(string nombreUsuario, string contraseñaActual, string nuevaContraseña)
        {

            // Validar que la nueva contraseña cumpla con ciertas reglas de negocio
            if (string.IsNullOrWhiteSpace(nuevaContraseña))
            {
                throw new ArgumentException("La nueva contraseña no puede estar vacía.");
            }

            if (nuevaContraseña.Length < 8)
            {
                throw new ArgumentException("La nueva contraseña debe tener al menos 8 caracteres.");
            }

            // Si las validaciones pasan, se delega la llamada al repositorio (capa de Datos)
            bool resultado = _usuarioRepository.CambioPassword(nombreUsuario, contraseñaActual, nuevaContraseña);


            return resultado;
        }
    }
}
