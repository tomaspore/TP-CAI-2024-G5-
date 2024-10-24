using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateTPIntegrador.Forms;

namespace TemplateTPIntegrador
{
    public partial class FrmMenuAdmin : Form
    {

        public FrmMenuAdmin()
        {
            InitializeComponent();
           
        }

        private void btnRegistroUsuario_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario menuregistrousuario = new FrmRegistroUsuario();

            menuregistrousuario.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin logindatos = new FrmLogin();
            
            FrmCambioContraseña cambiarpassword = new FrmCambioContraseña();

            cambiarpassword.Show();
            this.Hide();


        }

        private void btnRegistroUsuario__Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario menuregistrousuario = new FrmRegistroUsuario();

            menuregistrousuario.Show();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
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

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto altaproducto = new FrmAgregarProducto();

            altaproducto.Show();
            this.Hide();


        }
    }
}
