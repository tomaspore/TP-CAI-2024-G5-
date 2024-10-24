using Negocio.Login;
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
    public partial class FrmAgregarProducto : Form
    {
        public FrmAgregarProducto()
        {
            InitializeComponent();
            cmbCategoria.Items.Add("Audio");

            cmbCategoria.Items.Add("Celulares");

            cmbCategoria.Items.Add("Electro Hogar");

            cmbCategoria.Items.Add("Informática");

            cmbCategoria.Items.Add("Smart TV");
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Acá voy a tener que agregar la lista de proveedores
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreProducto.Text;
            string proveedor = lstProveedores.SelectedItem?.ToString();
            string categoria = cmbCategoria.SelectedItem?.ToString();
            string preciovalidador = txtPrecio.Text;
            string stockvalidador = txtStock.Text;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(nombre) ||/* string.IsNullOrWhiteSpace(proveedor) ||*/
                string.IsNullOrWhiteSpace(categoria) || string.IsNullOrWhiteSpace(preciovalidador) ||
                string.IsNullOrWhiteSpace(stockvalidador))
            {
                MessageBox.Show("Todos los campos deben estar completos.");
                return;
            }

            // Validar y convertir los valores de precio y stock
            if (!double.TryParse(preciovalidador, out double precio))
            {
                MessageBox.Show("El precio debe ser un valor numérico.");
                return;
            }

            if (!int.TryParse(stockvalidador, out int stock))
            {
                MessageBox.Show("El stock debe ser un valor numérico.");
                return;
            }

            int idcategoria;

            if (categoria == "Audio")
            {
                idcategoria = 1;
            }
            else if (categoria == "Celulares")
            {
                idcategoria = 2;
            }
            else if (categoria == "Electro Hogar")
            {
                idcategoria = 3;
            }
            else if (categoria == "Informática")
            {
                idcategoria = 4;
            }
            else idcategoria = 5;

            // Aquí debes obtener los Guid correspondientes para la categoría y proveedor
            // Esto depende de cómo estén estructurados tus datos

            
            
            string idProveedor = "984c5534-0b26-46f1-8b89-04496bff9957";
            string idUsuario = "1653c7ec-870d-468a-b581-9800961d53d2"; 

            // Instanciar o inyectar el servicio de negocio
            AgregarProductos productoService = new AgregarProductos();

            // Llamar al servicio de negocio para agregar el producto
            string resultado = productoService.AgregarProductoConValidaciones(idcategoria, idUsuario, idProveedor, nombre, precio, stock);

            // Verificar el resultado
            if (resultado == "Error")
            {
                MessageBox.Show("Ocurrió un error al agregar el producto.");
            }
            else
            {
                MessageBox.Show("Producto agregado exitosamente.");
                txtNombreProducto.Clear();
                lstProveedores.SelectedIndex = -1;
                cmbCategoria.SelectedIndex = -1;
                txtPrecio.Clear();
                txtStock.Clear();


            }

           
        }

    }
}
