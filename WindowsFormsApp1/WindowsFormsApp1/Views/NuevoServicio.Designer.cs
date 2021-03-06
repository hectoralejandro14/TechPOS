﻿namespace WindowsFormsApp1.Views
{
    partial class NuevoServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoServicio));
            this.SpbNuevoServicioIMG = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SlblNombreDelServicio = new System.Windows.Forms.Label();
            this.StxtNombreNuevoServicio = new System.Windows.Forms.TextBox();
            this.SlblPrecioNuevoServicio = new System.Windows.Forms.Label();
            this.SlblActividadNuevoServicio = new System.Windows.Forms.Label();
            this.StxtPrecioNuevoServicio = new System.Windows.Forms.TextBox();
            this.StxtActividadNuevoServicio = new System.Windows.Forms.TextBox();
            this.SbtnAceptarNuevoServicio = new System.Windows.Forms.Button();
            this.SbtnVolverPaginaPrincipal = new System.Windows.Forms.Button();
            this.nuevoUsuarioPnl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SpbNuevoServicioIMG)).BeginInit();
            this.nuevoUsuarioPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpbNuevoServicioIMG
            // 
            this.SpbNuevoServicioIMG.Image = global::WindowsFormsApp1.Properties.Resources.logoUp;
            this.SpbNuevoServicioIMG.Location = new System.Drawing.Point(10, 20);
            this.SpbNuevoServicioIMG.Name = "SpbNuevoServicioIMG";
            this.SpbNuevoServicioIMG.Size = new System.Drawing.Size(84, 108);
            this.SpbNuevoServicioIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpbNuevoServicioIMG.TabIndex = 0;
            this.SpbNuevoServicioIMG.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(273, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nuevo Servicio";
            // 
            // SlblNombreDelServicio
            // 
            this.SlblNombreDelServicio.AutoSize = true;
            this.SlblNombreDelServicio.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlblNombreDelServicio.ForeColor = System.Drawing.Color.DarkOrange;
            this.SlblNombreDelServicio.Location = new System.Drawing.Point(146, 69);
            this.SlblNombreDelServicio.Name = "SlblNombreDelServicio";
            this.SlblNombreDelServicio.Size = new System.Drawing.Size(77, 34);
            this.SlblNombreDelServicio.TabIndex = 2;
            this.SlblNombreDelServicio.Text = "Nombre";
            // 
            // StxtNombreNuevoServicio
            // 
            this.StxtNombreNuevoServicio.Location = new System.Drawing.Point(253, 77);
            this.StxtNombreNuevoServicio.Name = "StxtNombreNuevoServicio";
            this.StxtNombreNuevoServicio.Size = new System.Drawing.Size(260, 20);
            this.StxtNombreNuevoServicio.TabIndex = 5;
            // 
            // SlblPrecioNuevoServicio
            // 
            this.SlblPrecioNuevoServicio.AutoSize = true;
            this.SlblPrecioNuevoServicio.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlblPrecioNuevoServicio.ForeColor = System.Drawing.Color.DarkOrange;
            this.SlblPrecioNuevoServicio.Location = new System.Drawing.Point(146, 118);
            this.SlblPrecioNuevoServicio.Name = "SlblPrecioNuevoServicio";
            this.SlblPrecioNuevoServicio.Size = new System.Drawing.Size(66, 34);
            this.SlblPrecioNuevoServicio.TabIndex = 6;
            this.SlblPrecioNuevoServicio.Text = "Precio";
            // 
            // SlblActividadNuevoServicio
            // 
            this.SlblActividadNuevoServicio.AutoSize = true;
            this.SlblActividadNuevoServicio.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlblActividadNuevoServicio.ForeColor = System.Drawing.Color.DarkOrange;
            this.SlblActividadNuevoServicio.Location = new System.Drawing.Point(146, 155);
            this.SlblActividadNuevoServicio.Name = "SlblActividadNuevoServicio";
            this.SlblActividadNuevoServicio.Size = new System.Drawing.Size(87, 34);
            this.SlblActividadNuevoServicio.TabIndex = 7;
            this.SlblActividadNuevoServicio.Text = "Actividad";
            // 
            // StxtPrecioNuevoServicio
            // 
            this.StxtPrecioNuevoServicio.Location = new System.Drawing.Point(253, 126);
            this.StxtPrecioNuevoServicio.Name = "StxtPrecioNuevoServicio";
            this.StxtPrecioNuevoServicio.Size = new System.Drawing.Size(260, 20);
            this.StxtPrecioNuevoServicio.TabIndex = 8;
            this.StxtPrecioNuevoServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StxtPrecioNuevoServicio_KeyPress);
            // 
            // StxtActividadNuevoServicio
            // 
            this.StxtActividadNuevoServicio.Location = new System.Drawing.Point(253, 169);
            this.StxtActividadNuevoServicio.Name = "StxtActividadNuevoServicio";
            this.StxtActividadNuevoServicio.Size = new System.Drawing.Size(260, 20);
            this.StxtActividadNuevoServicio.TabIndex = 9;
            // 
            // SbtnAceptarNuevoServicio
            // 
            this.SbtnAceptarNuevoServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SbtnAceptarNuevoServicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SbtnAceptarNuevoServicio.ForeColor = System.Drawing.Color.DarkOrange;
            this.SbtnAceptarNuevoServicio.Location = new System.Drawing.Point(424, 240);
            this.SbtnAceptarNuevoServicio.Name = "SbtnAceptarNuevoServicio";
            this.SbtnAceptarNuevoServicio.Size = new System.Drawing.Size(97, 27);
            this.SbtnAceptarNuevoServicio.TabIndex = 10;
            this.SbtnAceptarNuevoServicio.Text = "Aceptar";
            this.SbtnAceptarNuevoServicio.UseVisualStyleBackColor = false;
            this.SbtnAceptarNuevoServicio.Click += new System.EventHandler(this.SbtnAceptarNuevoServicio_Click);
            // 
            // SbtnVolverPaginaPrincipal
            // 
            this.SbtnVolverPaginaPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SbtnVolverPaginaPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SbtnVolverPaginaPrincipal.ForeColor = System.Drawing.Color.DarkOrange;
            this.SbtnVolverPaginaPrincipal.Location = new System.Drawing.Point(278, 240);
            this.SbtnVolverPaginaPrincipal.Name = "SbtnVolverPaginaPrincipal";
            this.SbtnVolverPaginaPrincipal.Size = new System.Drawing.Size(103, 27);
            this.SbtnVolverPaginaPrincipal.TabIndex = 11;
            this.SbtnVolverPaginaPrincipal.Text = "Volver";
            this.SbtnVolverPaginaPrincipal.UseVisualStyleBackColor = false;
            this.SbtnVolverPaginaPrincipal.Click += new System.EventHandler(this.SbtnVolverPaginaPrincipal_Click);
            // 
            // nuevoUsuarioPnl
            // 
            this.nuevoUsuarioPnl.BackColor = System.Drawing.Color.DimGray;
            this.nuevoUsuarioPnl.Controls.Add(this.SpbNuevoServicioIMG);
            this.nuevoUsuarioPnl.Location = new System.Drawing.Point(2, -8);
            this.nuevoUsuarioPnl.Name = "nuevoUsuarioPnl";
            this.nuevoUsuarioPnl.Size = new System.Drawing.Size(108, 299);
            this.nuevoUsuarioPnl.TabIndex = 12;
            // 
            // NuevoServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 290);
            this.ControlBox = false;
            this.Controls.Add(this.nuevoUsuarioPnl);
            this.Controls.Add(this.SbtnVolverPaginaPrincipal);
            this.Controls.Add(this.SbtnAceptarNuevoServicio);
            this.Controls.Add(this.StxtActividadNuevoServicio);
            this.Controls.Add(this.StxtPrecioNuevoServicio);
            this.Controls.Add(this.SlblActividadNuevoServicio);
            this.Controls.Add(this.SlblPrecioNuevoServicio);
            this.Controls.Add(this.StxtNombreNuevoServicio);
            this.Controls.Add(this.SlblNombreDelServicio);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevoServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.SpbNuevoServicioIMG)).EndInit();
            this.nuevoUsuarioPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SpbNuevoServicioIMG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SlblNombreDelServicio;
        private System.Windows.Forms.TextBox StxtNombreNuevoServicio;
        private System.Windows.Forms.Label SlblPrecioNuevoServicio;
        private System.Windows.Forms.Label SlblActividadNuevoServicio;
        private System.Windows.Forms.TextBox StxtPrecioNuevoServicio;
        private System.Windows.Forms.TextBox StxtActividadNuevoServicio;
        private System.Windows.Forms.Button SbtnAceptarNuevoServicio;
        private System.Windows.Forms.Button SbtnVolverPaginaPrincipal;
        private System.Windows.Forms.Panel nuevoUsuarioPnl;
    }
}