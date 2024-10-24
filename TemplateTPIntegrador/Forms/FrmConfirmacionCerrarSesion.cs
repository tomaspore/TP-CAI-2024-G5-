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
    public partial class FrmConfirmacionCerrarSesion : Form
    {
        public FrmConfirmacionCerrarSesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close(); // Cierra el formulario de confirmación
            Application.OpenForms["FrmMenuSupervisor"].Close(); // Cierra el formulario de supervisor

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario de confirmación sin hacer nada
        }
    
    }
}
