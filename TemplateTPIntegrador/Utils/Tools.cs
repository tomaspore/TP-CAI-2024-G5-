using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    public class Tools
    {

        public bool ValidarVacio(string texto1, string texto2)
        {
       

            if (string.IsNullOrEmpty(texto1) && string.IsNullOrEmpty(texto2))
            {
               
                return true;

            }
            else if (string.IsNullOrEmpty(texto1) || string.IsNullOrEmpty(texto2))
            {

                return true;

            }
            else
            {
                return false;
            }
        }

        public void MensajeBienvenida(string nombreusuario)
        {
            MessageBox.Show("Bienvenido! " + nombreusuario);
        }

        public bool ValidarVacioRegistroUsuario(string texto1, string texto2, string texto3, string texto4, string texto5, string texto6, string texto7, string texto8, string texto9)
        {
            if(
                string.IsNullOrEmpty(texto1) && 
                string.IsNullOrEmpty(texto2) && 
                string.IsNullOrEmpty(texto3) && 
                string.IsNullOrEmpty(texto4) && 
                string.IsNullOrEmpty(texto5) && 
                string.IsNullOrEmpty(texto6) && 
                string.IsNullOrEmpty(texto7) && 
                string.IsNullOrEmpty(texto8) && 
                string.IsNullOrEmpty(texto9)
                )
            {
                return true;
            }
            else if(
                string.IsNullOrEmpty(texto1) || 
                string.IsNullOrEmpty(texto2) || 
                string.IsNullOrEmpty(texto3) || 
                string.IsNullOrEmpty(texto4) || 
                string.IsNullOrEmpty(texto5) || 
                string.IsNullOrEmpty(texto6) || 
                string.IsNullOrEmpty(texto7) || 
                string.IsNullOrEmpty(texto8) || 
                string.IsNullOrEmpty(texto9)
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
