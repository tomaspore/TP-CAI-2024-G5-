using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace TemplateTPIntegrador.Forms
{
    public partial class FrmRegistroUsuario : Form
    {
        private static int UserId = 1; // Inicializa el Id una sola vez

        public FrmRegistroUsuario()
        {
            InitializeComponent();
            LlenarcmbHost(); // Para poner los posibles valores a elegir en cmbHost
            MostrarIDUsuarioActual();
        }

        private void MostrarIDUsuarioActual()
        {
            txtIdUsuario.Text = UserId.ToString(); // Muestra el Id actual
            txtIdUsuario.ReadOnly = true; // Hace que no se pueda editar el campo manualmente
        }

        private void LlenarcmbHost()
        {
            // Se llena el comboBox Host con sus diferentes opciones
            cmbHost.Items.Add("Administrador (3)");
            cmbHost.Items.Add("Supervisor (2)");
            cmbHost.Items.Add("Vendedor (1)");
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            // Obtiene los valores de los campos del formulario
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string usuario = txtUsuario.Text;
            string dni = txtDNI.Text;
            string contraseña = txtContraseña.Text;
            string host = cmbHost.SelectedItem?.ToString();

            // Validaciones de negocio
            ValidacionesNegocio validacionesRegistro = new ValidacionesNegocio();
            string error;

            // Validaciones de nombre de usuario y contraseña
            if (!validacionesRegistro.ValidarNombreRegistroUsuario(usuario, nombre, apellido, out error))
            {
                MessageBox.Show(error);
                return;
            }

            if (!validacionesRegistro.ValidacionContraseña(contraseña, out error))
            {
                MessageBox.Show(error);
                return;
            }

            // Validar campos vacíos
            ValidacionesUtils validacionUntilRegistro = new ValidacionesUtils();
            if (validacionUntilRegistro.ValidarVacioRegistroUsuario(nombre, apellido, direccion, telefono, email, usuario, dni, contraseña, host))
            {
                MessageBox.Show("Le está faltando ingresar datos.");
                return;
            }

            // Si las validaciones son exitosas, registrar al usuario
            MessageBox.Show("Usuario se ha registrado con éxito.");

            // Incrementar el ID después del registro exitoso
            UserId++;

            // Volver al formulario de FrmMenuAdmin
            FrmMenuAdmin menuadmin = new FrmMenuAdmin();
            menuadmin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //VOLVER AL MENU INICIAL
            this.Close();  // Cierra el formulario actual (Registrar Usuario)
            FrmMenuAdmin menu = new FrmMenuAdmin(); // Crea una instancia del menú administrador
            menu.Show();  // Muestra el formulario del menú administrador
        }
    }
}
