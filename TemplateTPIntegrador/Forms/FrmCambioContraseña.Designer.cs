namespace TemplateTPIntegrador.Forms
{
    partial class FrmCambioContraseña
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
            this.txtContraseñaActual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseñaNueva = new System.Windows.Forms.TextBox();
            this.txtModificarContraseña = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.chkMostrarContraseñaNueva = new System.Windows.Forms.CheckBox();
            this.chkMostrarContraseñaActual = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtContraseñaActual
            // 
            this.txtContraseñaActual.Location = new System.Drawing.Point(123, 54);
            this.txtContraseñaActual.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseñaActual.Name = "txtContraseñaActual";
            this.txtContraseñaActual.Size = new System.Drawing.Size(106, 20);
            this.txtContraseñaActual.TabIndex = 0;
            this.txtContraseñaActual.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contraseña Actual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nueva Contraseña:";
            // 
            // txtContraseñaNueva
            // 
            this.txtContraseñaNueva.Location = new System.Drawing.Point(123, 106);
            this.txtContraseñaNueva.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseñaNueva.Name = "txtContraseñaNueva";
            this.txtContraseñaNueva.Size = new System.Drawing.Size(106, 20);
            this.txtContraseñaNueva.TabIndex = 3;
            this.txtContraseñaNueva.UseSystemPasswordChar = true;
            // 
            // txtModificarContraseña
            // 
            this.txtModificarContraseña.Location = new System.Drawing.Point(87, 164);
            this.txtModificarContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtModificarContraseña.Name = "txtModificarContraseña";
            this.txtModificarContraseña.Size = new System.Drawing.Size(94, 21);
            this.txtModificarContraseña.TabIndex = 4;
            this.txtModificarContraseña.Text = "Modificar";
            this.txtModificarContraseña.UseVisualStyleBackColor = true;
            this.txtModificarContraseña.Click += new System.EventHandler(this.txtModificarContraseña_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(123, 25);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(106, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // chkMostrarContraseñaNueva
            // 
            this.chkMostrarContraseñaNueva.AutoSize = true;
            this.chkMostrarContraseñaNueva.Location = new System.Drawing.Point(35, 132);
            this.chkMostrarContraseñaNueva.Margin = new System.Windows.Forms.Padding(2);
            this.chkMostrarContraseñaNueva.Name = "chkMostrarContraseñaNueva";
            this.chkMostrarContraseñaNueva.Size = new System.Drawing.Size(153, 17);
            this.chkMostrarContraseñaNueva.TabIndex = 8;
            this.chkMostrarContraseñaNueva.Text = "Mostrar Contraseña Nueva";
            this.chkMostrarContraseñaNueva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkMostrarContraseñaNueva.UseVisualStyleBackColor = true;
            this.chkMostrarContraseñaNueva.CheckedChanged += new System.EventHandler(this.ChkMostrarContraseñaNueva_CheckedChanged);
            this.chkMostrarContraseñaNueva.Click += new System.EventHandler(this.ChkMostrarContraseñaNueva_CheckedChanged);
            // 
            // chkMostrarContraseñaActual
            // 
            this.chkMostrarContraseñaActual.AutoSize = true;
            this.chkMostrarContraseñaActual.Location = new System.Drawing.Point(35, 85);
            this.chkMostrarContraseñaActual.Margin = new System.Windows.Forms.Padding(2);
            this.chkMostrarContraseñaActual.Name = "chkMostrarContraseñaActual";
            this.chkMostrarContraseñaActual.Size = new System.Drawing.Size(151, 17);
            this.chkMostrarContraseñaActual.TabIndex = 9;
            this.chkMostrarContraseñaActual.Text = "Mostrar Contraseña Actual";
            this.chkMostrarContraseñaActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkMostrarContraseñaActual.UseVisualStyleBackColor = true;
            this.chkMostrarContraseñaActual.CheckedChanged += new System.EventHandler(this.ChkMostrarContraseñaActual_CheckedChanged);
            this.chkMostrarContraseñaActual.Click += new System.EventHandler(this.ChkMostrarContraseñaActual_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario:";
            // 
            // FrmCambioContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 202);
            this.Controls.Add(this.chkMostrarContraseñaActual);
            this.Controls.Add(this.chkMostrarContraseñaNueva);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModificarContraseña);
            this.Controls.Add(this.txtContraseñaNueva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseñaActual);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCambioContraseña";
            this.Text = "FrmCambioContraseña";
            this.Load += new System.EventHandler(this.FrmCambioContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContraseñaActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseñaNueva;
        private System.Windows.Forms.Button txtModificarContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.CheckBox chkMostrarContraseñaNueva;
        private System.Windows.Forms.CheckBox chkMostrarContraseñaActual;
        private System.Windows.Forms.Label label3;
    }
}