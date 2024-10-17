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
using TemplateTPIntegrador.Forms;

namespace TemplateTPIntegrador
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private int intentos; //Temporalmente la variable intentos va a estar acá

        private void button1_Click(object sender, EventArgs e)
        {
            ValidacionesUtils validacionUntil = new ValidacionesUtils();
            string usuario = "";
            string contraseña = "";

            usuario = txtUsuario.Text;
            contraseña = txtContraseña.Text;

            if (validacionUntil.ValidarVacio(usuario, contraseña))
            {
                MessageBox.Show("Debe ingresar usuario y/o contraseña.");

            }

            else
            {
                
                //Acá en un futuro voy a poner el nombre de la persona y no el user
                LoginNegocio negocio = new LoginNegocio();

                string perfil = negocio.login(usuario, contraseña);

                if (perfil == "Administrador")
                {
                    MessageBox.Show("Bienvenido! " + usuario);
                    FrmMenuAdmin admin = new FrmMenuAdmin();
                    admin.Show();
                    this.Hide();

                }
                else if (perfil == "Supervisor")
                {
                    MessageBox.Show("Bienvenido! " + usuario);
                    FrmMenuSupervisor supervisor = new FrmMenuSupervisor();
                    supervisor.Show();
                }
                else if (perfil == "Vendedor")
                {
                    MessageBox.Show("Bienvenido! " + usuario);
                    FrmMenuVendedor vendedor = new FrmMenuVendedor();
                    vendedor.Show();
                    this.Hide();
                }
                else if (perfil == "Error")
                {
                    intentos++;
                    if (intentos == 3)
                    {
                        MessageBox.Show("El usuario " + usuario + " pasa a estado INACTIVO.\nContacte con el Administrador");
                        intentos = 0;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña y/o usuario incorrecto. Vuelta a intentarlo");
                        
                        //Usuarios inactivos guardar en memoria FileInfo
                        //Pasar a capa Negocio esta validacion.
                    }

                }

            }

            

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
