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
    public partial class FrmMenuVendedor : Form
    {
        public FrmMenuVendedor()
        {
            InitializeComponent();
        }

        private void btnModificarContraseña_Click(object sender, EventArgs e)
        {
            FrmCambioContraseña cambiarpassword = new FrmCambioContraseña();
            cambiarpassword.Show();
            this.Hide(); // Esto ocultará el formulario actual
        }

        private void btnReporteVentasXVendedor_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmLogin logindatos = new FrmLogin();

            FrmCambioContraseña cambiarpassword = new FrmCambioContraseña();

            cambiarpassword.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmConfirmacionCerrarSesion confirmacion = new FrmConfirmacionCerrarSesion();
            confirmacion.ShowDialog(); // Mostrar el formulario de confirmación de manera modal

        }
    }
}
