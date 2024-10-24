using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador.Forms
{
    public partial class FrmCambioContraseña : Form
    {
        public FrmCambioContraseña()
        {
            InitializeComponent();
            UsuarioService _usuarioService = new UsuarioService();
            // Asegurarse de que las contraseñas estén ocultas al iniciar el formulario
            txtContraseñaActual.UseSystemPasswordChar = true;
            txtContraseñaNueva.UseSystemPasswordChar = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCambioContraseña_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtModificarContraseña_Click(object sender, EventArgs e)
        {
            // Capturar los valores de los TextBoxes
            UsuarioService _usuarioService = new UsuarioService();
            string nombreUsuario = txtUsuario.Text;
            string contraseñaActual = txtContraseñaActual.Text;
            string nuevaContraseña = txtContraseñaNueva.Text;

            // Validar que los campos no estén vacíos (validación básica en la capa de presentación)
            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contraseñaActual) || string.IsNullOrEmpty(nuevaContraseña))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Llamar al método de la capa de negocio para cambiar la contraseña
                bool resultado = _usuarioService.CambiarContraseñaAsync(nombreUsuario, contraseñaActual, nuevaContraseña);

                // Mostrar el resultado al usuario
                if (resultado)
                {
                    MessageBox.Show("La contraseña se ha cambiado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al cambiar la contraseña. Verifique los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ChkMostrarContraseñaActual_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarContraseñaActual.CheckState == CheckState.Checked)
            {
                txtContraseñaActual.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseñaActual.UseSystemPasswordChar = true;
            }
        }
        private void ChkMostrarContraseñaNueva_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarContraseñaNueva.CheckState == CheckState.Checked)
            {
                txtContraseñaNueva.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseñaNueva.UseSystemPasswordChar = true;
            }
        }
    }
}
