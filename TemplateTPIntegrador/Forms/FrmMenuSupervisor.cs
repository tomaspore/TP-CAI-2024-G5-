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
    public partial class FrmMenuSupervisor : Form
    {
        public FrmMenuSupervisor()
        {
            InitializeComponent();
        }

        private void btnBajaProductos_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarContraseña_Click(object sender, EventArgs e)
        {
            FrmLogin logindatos = new FrmLogin();

            FrmCambioContraseña cambiarpassword = new FrmCambioContraseña();

            cambiarpassword.Show();
            this.Hide();
        }

        private void btnModificacionProductos_Click(object sender, EventArgs e)
        {

        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmConfirmacionCerrarSesion confirmacion = new FrmConfirmacionCerrarSesion();
            confirmacion.ShowDialog(); // Mostrar el formulario de confirmación de manera modal

        }

        private void btnDevolucionVenta_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
