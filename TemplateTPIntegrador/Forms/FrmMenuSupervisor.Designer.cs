namespace TemplateTPIntegrador.Forms
{
    partial class FrmMenuSupervisor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDevolucionVenta = new System.Windows.Forms.Button();
            this.btnReporteStockCritico = new System.Windows.Forms.Button();
            this.btnRepProdMasVendidoXCategoria = new System.Windows.Forms.Button();
            this.btnReporteVentasXVendedor = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnModificarContraseña = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDevolucionVenta
            // 
            this.btnDevolucionVenta.Location = new System.Drawing.Point(16, 151);
            this.btnDevolucionVenta.Name = "btnDevolucionVenta";
            this.btnDevolucionVenta.Size = new System.Drawing.Size(153, 23);
            this.btnDevolucionVenta.TabIndex = 3;
            this.btnDevolucionVenta.Text = "Devolucion de venta";
            this.btnDevolucionVenta.UseVisualStyleBackColor = true;
            this.btnDevolucionVenta.Click += new System.EventHandler(this.btnDevolucionVenta_Click);
            // 
            // btnReporteStockCritico
            // 
            this.btnReporteStockCritico.Location = new System.Drawing.Point(15, 33);
            this.btnReporteStockCritico.Name = "btnReporteStockCritico";
            this.btnReporteStockCritico.Size = new System.Drawing.Size(153, 23);
            this.btnReporteStockCritico.TabIndex = 4;
            this.btnReporteStockCritico.Text = "Stock critico";
            this.btnReporteStockCritico.UseVisualStyleBackColor = true;
            // 
            // btnRepProdMasVendidoXCategoria
            // 
            this.btnRepProdMasVendidoXCategoria.Location = new System.Drawing.Point(15, 110);
            this.btnRepProdMasVendidoXCategoria.Name = "btnRepProdMasVendidoXCategoria";
            this.btnRepProdMasVendidoXCategoria.Size = new System.Drawing.Size(153, 23);
            this.btnRepProdMasVendidoXCategoria.TabIndex = 5;
            this.btnRepProdMasVendidoXCategoria.Text = "Productos más vendidos";
            this.btnRepProdMasVendidoXCategoria.UseVisualStyleBackColor = true;
            // 
            // btnReporteVentasXVendedor
            // 
            this.btnReporteVentasXVendedor.Location = new System.Drawing.Point(15, 72);
            this.btnReporteVentasXVendedor.Name = "btnReporteVentasXVendedor";
            this.btnReporteVentasXVendedor.Size = new System.Drawing.Size(153, 23);
            this.btnReporteVentasXVendedor.TabIndex = 6;
            this.btnReporteVentasXVendedor.Text = "Ventas por vendedor";
            this.btnReporteVentasXVendedor.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.btnModificarContraseña);
            this.groupBox4.Location = new System.Drawing.Point(25, 243);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(181, 110);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opciones Personales";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnModificarContraseña
            // 
            this.btnModificarContraseña.Location = new System.Drawing.Point(16, 30);
            this.btnModificarContraseña.Name = "btnModificarContraseña";
            this.btnModificarContraseña.Size = new System.Drawing.Size(153, 25);
            this.btnModificarContraseña.TabIndex = 10;
            this.btnModificarContraseña.Text = "Modificar Contraseña";
            this.btnModificarContraseña.UseVisualStyleBackColor = true;
            this.btnModificarContraseña.Click += new System.EventHandler(this.btnModificarContraseña_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btnDevolucionVenta);
            this.groupBox2.Location = new System.Drawing.Point(25, 36);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(189, 191);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control de Inventario";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Alta de Productos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Modificacion de Productos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Baja de Productos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 73);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 25);
            this.button5.TabIndex = 17;
            this.button5.Text = "Cerrar Sesión";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReporteVentasXVendedor);
            this.groupBox1.Controls.Add(this.btnRepProdMasVendidoXCategoria);
            this.groupBox1.Controls.Add(this.btnReporteStockCritico);
            this.groupBox1.Location = new System.Drawing.Point(228, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 317);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reportes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FrmMenuSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 363);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "FrmMenuSupervisor";
            this.Text = "Menu Principal - Supervisor";
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDevolucionVenta;
        private System.Windows.Forms.Button btnReporteStockCritico;
        private System.Windows.Forms.Button btnRepProdMasVendidoXCategoria;
        private System.Windows.Forms.Button btnReporteVentasXVendedor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnModificarContraseña;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}