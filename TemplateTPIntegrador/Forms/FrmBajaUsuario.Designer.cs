﻿namespace TemplateTPIntegrador.Forms
{
    partial class FrmBajaUsuario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnDarBaja = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(292, 70);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 26);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(50, 160);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(105, 24);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnDarBaja
            // 
            this.btnDarBaja.Location = new System.Drawing.Point(292, 115);
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.Size = new System.Drawing.Size(202, 30);
            this.btnDarBaja.TabIndex = 3;
            this.btnDarBaja.Text = "Dar de Baja";
            this.btnDarBaja.UseVisualStyleBackColor = true;
            this.btnDarBaja.Click += new System.EventHandler(this.btnDarBaja_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(150, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(282, 33);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Dar de Baja Usuario";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(50, 70);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(236, 23);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "Ingresar Nombre Usuario:";
            // 
            // FrmBajaUsuario
            // 
            this.ClientSize = new System.Drawing.Size(639, 250);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnDarBaja);
            this.Controls.Add(this.lblResultado);
            this.Name = "FrmBajaUsuario";
            this.Text = "Baja de Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnDarBaja;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUsuario;
    }
}