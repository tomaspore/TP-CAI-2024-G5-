﻿using System;

namespace TemplateTPIntegrador.Forms
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnDarBaja = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Purple;
            this.panelLeft.Controls.Add(this.pictureBoxIcon);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(250, 410);
            this.panelLeft.TabIndex = 0;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::TemplateTPIntegrador.Properties.Resources.eletrohogarx2;
            this.pictureBoxIcon.Location = new System.Drawing.Point(50, 100);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(300, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(241, 50);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Baja Usuario";
        
            // 
            // labelUsuario
            // 
            this.labelUsuario.Font = new System.Drawing.Font("Arial", 12F);
            this.labelUsuario.Location = new System.Drawing.Point(300, 70);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(241, 36);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "Ingresar ID:";
            
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(300, 109);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 26);
            this.txtUsuario.TabIndex = 3;
            // 
            // btnDarBaja
            // 
            this.btnDarBaja.BackColor = System.Drawing.Color.Purple;
            this.btnDarBaja.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnDarBaja.ForeColor = System.Drawing.Color.White;
            this.btnDarBaja.Location = new System.Drawing.Point(300, 150);
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.Size = new System.Drawing.Size(200, 40);
            this.btnDarBaja.TabIndex = 4;
            this.btnDarBaja.Text = "Dar de Baja";
            this.btnDarBaja.UseVisualStyleBackColor = false;
            this.btnDarBaja.Click += new System.EventHandler(this.btnDarBaja_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Arial", 10F);
            this.lblResultado.Location = new System.Drawing.Point(300, 210);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(100, 23);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado:";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Gray;
            this.buttonBack.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(300, 250);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(200, 40);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Volver al Menú";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmBajaUsuario
            // 
            this.ClientSize = new System.Drawing.Size(635, 410);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnDarBaja);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.buttonBack);
            this.Name = "FrmBajaUsuario";
            this.Text = "Baja de Usuario";
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnDarBaja;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Button buttonBack; // 
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
    }
}


