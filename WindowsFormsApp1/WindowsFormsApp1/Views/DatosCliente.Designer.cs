namespace WindowsFormsApp1.Views
{
    partial class DatosCliente
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
            this.lblClienteBuscar = new System.Windows.Forms.Label();
            this.logoImg = new System.Windows.Forms.PictureBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContactoCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnAceptarCliente = new System.Windows.Forms.Button();
            this.btnCancelarMod = new System.Windows.Forms.Button();
            this.datosClienteLayout = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            this.datosClienteLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClienteBuscar
            // 
            this.lblClienteBuscar.AutoSize = true;
            this.lblClienteBuscar.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteBuscar.Location = new System.Drawing.Point(172, 12);
            this.lblClienteBuscar.Name = "lblClienteBuscar";
            this.lblClienteBuscar.Size = new System.Drawing.Size(218, 36);
            this.lblClienteBuscar.TabIndex = 7;
            this.lblClienteBuscar.Text = "Datos del Cliente";
            // 
            // logoImg
            // 
            this.logoImg.Image = global::WindowsFormsApp1.Properties.Resources.logoUp1;
            this.logoImg.Location = new System.Drawing.Point(12, 12);
            this.logoImg.Name = "logoImg";
            this.logoImg.Size = new System.Drawing.Size(64, 104);
            this.logoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoImg.TabIndex = 10;
            this.logoImg.TabStop = false;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(170, 3);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(161, 20);
            this.txtNombreCliente.TabIndex = 14;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.lblNombreCliente.Location = new System.Drawing.Point(3, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(91, 34);
            this.lblNombreCliente.TabIndex = 13;
            this.lblNombreCliente.Text = "Nombre/s";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Enabled = false;
            this.txtApellidoCliente.Location = new System.Drawing.Point(170, 58);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(161, 20);
            this.txtApellidoCliente.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 34);
            this.label1.TabIndex = 15;
            this.label1.Text = "Apellido/s";
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Enabled = false;
            this.txtTelefonoCliente.Location = new System.Drawing.Point(170, 115);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(161, 20);
            this.txtTelefonoCliente.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "Telefono";
            // 
            // txtContactoCliente
            // 
            this.txtContactoCliente.Enabled = false;
            this.txtContactoCliente.Location = new System.Drawing.Point(170, 177);
            this.txtContactoCliente.Name = "txtContactoCliente";
            this.txtContactoCliente.Size = new System.Drawing.Size(161, 20);
            this.txtContactoCliente.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 34);
            this.label3.TabIndex = 19;
            this.label3.Text = "Contacto";
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.DimGray;
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarCliente.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.btnModificarCliente.ForeColor = System.Drawing.Color.Turquoise;
            this.btnModificarCliente.Location = new System.Drawing.Point(232, 334);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(118, 39);
            this.btnModificarCliente.TabIndex = 21;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnAceptarCliente
            // 
            this.btnAceptarCliente.BackColor = System.Drawing.Color.DimGray;
            this.btnAceptarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptarCliente.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.btnAceptarCliente.ForeColor = System.Drawing.Color.Turquoise;
            this.btnAceptarCliente.Location = new System.Drawing.Point(90, 334);
            this.btnAceptarCliente.Name = "btnAceptarCliente";
            this.btnAceptarCliente.Size = new System.Drawing.Size(118, 39);
            this.btnAceptarCliente.TabIndex = 22;
            this.btnAceptarCliente.Text = "Aceptar";
            this.btnAceptarCliente.UseVisualStyleBackColor = false;
            this.btnAceptarCliente.Click += new System.EventHandler(this.btnAceptarCliente_Click);
            // 
            // btnCancelarMod
            // 
            this.btnCancelarMod.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelarMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarMod.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.btnCancelarMod.ForeColor = System.Drawing.Color.Turquoise;
            this.btnCancelarMod.Location = new System.Drawing.Point(368, 334);
            this.btnCancelarMod.Name = "btnCancelarMod";
            this.btnCancelarMod.Size = new System.Drawing.Size(118, 39);
            this.btnCancelarMod.TabIndex = 23;
            this.btnCancelarMod.Text = "Cancelar";
            this.btnCancelarMod.UseVisualStyleBackColor = false;
            this.btnCancelarMod.Visible = false;
            this.btnCancelarMod.Click += new System.EventHandler(this.btnCancelarMod_Click);
            // 
            // datosClienteLayout
            // 
            this.datosClienteLayout.ColumnCount = 2;
            this.datosClienteLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.datosClienteLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.datosClienteLayout.Controls.Add(this.lblNombreCliente, 0, 0);
            this.datosClienteLayout.Controls.Add(this.txtNombreCliente, 1, 0);
            this.datosClienteLayout.Controls.Add(this.label1, 0, 1);
            this.datosClienteLayout.Controls.Add(this.txtApellidoCliente, 1, 1);
            this.datosClienteLayout.Controls.Add(this.txtContactoCliente, 1, 3);
            this.datosClienteLayout.Controls.Add(this.label2, 0, 2);
            this.datosClienteLayout.Controls.Add(this.label3, 0, 3);
            this.datosClienteLayout.Controls.Add(this.txtTelefonoCliente, 1, 2);
            this.datosClienteLayout.Location = new System.Drawing.Point(121, 66);
            this.datosClienteLayout.Name = "datosClienteLayout";
            this.datosClienteLayout.RowCount = 4;
            this.datosClienteLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.80952F));
            this.datosClienteLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.19048F));
            this.datosClienteLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.datosClienteLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.datosClienteLayout.Size = new System.Drawing.Size(334, 217);
            this.datosClienteLayout.TabIndex = 24;
            // 
            // DatosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(521, 393);
            this.Controls.Add(this.datosClienteLayout);
            this.Controls.Add(this.btnCancelarMod);
            this.Controls.Add(this.btnAceptarCliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.logoImg);
            this.Controls.Add(this.lblClienteBuscar);
            this.Name = "DatosCliente";
            this.Text = "DatosCliente";
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            this.datosClienteLayout.ResumeLayout(false);
            this.datosClienteLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClienteBuscar;
        private System.Windows.Forms.PictureBox logoImg;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContactoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnAceptarCliente;
        private System.Windows.Forms.Button btnCancelarMod;
        private System.Windows.Forms.TableLayoutPanel datosClienteLayout;
    }
}