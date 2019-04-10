namespace WindowsFormsApp1.ViewsBetta
{
    partial class Principal
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
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.SpbBtnRestaurar = new System.Windows.Forms.PictureBox();
            this.SpbBtnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.SpbBtnMaximizar = new System.Windows.Forms.PictureBox();
            this.SpbBtnCerrar = new System.Windows.Forms.PictureBox();
            this.SBtnClientes = new System.Windows.Forms.Button();
            this.SBtnVentas = new System.Windows.Forms.Button();
            this.SBtnProductos = new System.Windows.Forms.Button();
            this.LogoPrincipal = new System.Windows.Forms.PictureBox();
            this.MenuVertical.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpbBtnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpbBtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpbBtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpbBtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.DimGray;
            this.MenuVertical.Controls.Add(this.SBtnClientes);
            this.MenuVertical.Controls.Add(this.SBtnVentas);
            this.MenuVertical.Controls.Add(this.SBtnProductos);
            this.MenuVertical.Controls.Add(this.LogoPrincipal);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 650);
            this.MenuVertical.TabIndex = 0;
            this.MenuVertical.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuVertical_MouseDown);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BarraTitulo.Controls.Add(this.SpbBtnRestaurar);
            this.BarraTitulo.Controls.Add(this.SpbBtnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnSlide);
            this.BarraTitulo.Controls.Add(this.SpbBtnMaximizar);
            this.BarraTitulo.Controls.Add(this.SpbBtnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1050, 50);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(250, 50);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1050, 600);
            this.PanelContenedor.TabIndex = 2;
            this.PanelContenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelContenedor_MouseDown);
            // 
            // SpbBtnRestaurar
            // 
            this.SpbBtnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpbBtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpbBtnRestaurar.Image = global::WindowsFormsApp1.Properties.Resources.icon_restaurar;
            this.SpbBtnRestaurar.Location = new System.Drawing.Point(1001, 3);
            this.SpbBtnRestaurar.Name = "SpbBtnRestaurar";
            this.SpbBtnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.SpbBtnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpbBtnRestaurar.TabIndex = 0;
            this.SpbBtnRestaurar.TabStop = false;
            this.SpbBtnRestaurar.Click += new System.EventHandler(this.SpbBtnRestaurar_Click);
            // 
            // SpbBtnMinimizar
            // 
            this.SpbBtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpbBtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpbBtnMinimizar.Image = global::WindowsFormsApp1.Properties.Resources.icon_minimizar;
            this.SpbBtnMinimizar.Location = new System.Drawing.Point(975, 3);
            this.SpbBtnMinimizar.Name = "SpbBtnMinimizar";
            this.SpbBtnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.SpbBtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpbBtnMinimizar.TabIndex = 1;
            this.SpbBtnMinimizar.TabStop = false;
            this.SpbBtnMinimizar.Click += new System.EventHandler(this.SpbBtnMinimizar_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Image = global::WindowsFormsApp1.Properties.Resources.Mobile_Menu_Icon;
            this.btnSlide.Location = new System.Drawing.Point(6, 9);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(35, 35);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // SpbBtnMaximizar
            // 
            this.SpbBtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpbBtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpbBtnMaximizar.Image = global::WindowsFormsApp1.Properties.Resources.icon_maximizar;
            this.SpbBtnMaximizar.Location = new System.Drawing.Point(1001, 3);
            this.SpbBtnMaximizar.Name = "SpbBtnMaximizar";
            this.SpbBtnMaximizar.Size = new System.Drawing.Size(20, 20);
            this.SpbBtnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpbBtnMaximizar.TabIndex = 1;
            this.SpbBtnMaximizar.TabStop = false;
            this.SpbBtnMaximizar.Click += new System.EventHandler(this.SpbBtnMaximizar_Click);
            // 
            // SpbBtnCerrar
            // 
            this.SpbBtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpbBtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpbBtnCerrar.Image = global::WindowsFormsApp1.Properties.Resources.icon_cerrar2;
            this.SpbBtnCerrar.Location = new System.Drawing.Point(1027, 3);
            this.SpbBtnCerrar.Name = "SpbBtnCerrar";
            this.SpbBtnCerrar.Size = new System.Drawing.Size(20, 20);
            this.SpbBtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpbBtnCerrar.TabIndex = 1;
            this.SpbBtnCerrar.TabStop = false;
            this.SpbBtnCerrar.Click += new System.EventHandler(this.SpbBtnCerrar_Click);
            // 
            // SBtnClientes
            // 
            this.SBtnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnClientes.FlatAppearance.BorderSize = 0;
            this.SBtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.SBtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SBtnClientes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SBtnClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SBtnClientes.Image = global::WindowsFormsApp1.Properties.Resources.clientes;
            this.SBtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SBtnClientes.Location = new System.Drawing.Point(3, 237);
            this.SBtnClientes.Name = "SBtnClientes";
            this.SBtnClientes.Size = new System.Drawing.Size(245, 57);
            this.SBtnClientes.TabIndex = 3;
            this.SBtnClientes.Text = "Clientes";
            this.SBtnClientes.UseVisualStyleBackColor = true;
            // 
            // SBtnVentas
            // 
            this.SBtnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnVentas.FlatAppearance.BorderSize = 0;
            this.SBtnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.SBtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SBtnVentas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SBtnVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SBtnVentas.Image = global::WindowsFormsApp1.Properties.Resources.venta;
            this.SBtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SBtnVentas.Location = new System.Drawing.Point(3, 174);
            this.SBtnVentas.Name = "SBtnVentas";
            this.SBtnVentas.Size = new System.Drawing.Size(245, 57);
            this.SBtnVentas.TabIndex = 2;
            this.SBtnVentas.Text = "Ventas";
            this.SBtnVentas.UseVisualStyleBackColor = true;
            this.SBtnVentas.Click += new System.EventHandler(this.SBtnVentas_Click);
            // 
            // SBtnProductos
            // 
            this.SBtnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnProductos.FlatAppearance.BorderSize = 0;
            this.SBtnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.SBtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SBtnProductos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SBtnProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SBtnProductos.Image = global::WindowsFormsApp1.Properties.Resources.producto;
            this.SBtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SBtnProductos.Location = new System.Drawing.Point(3, 111);
            this.SBtnProductos.Name = "SBtnProductos";
            this.SBtnProductos.Size = new System.Drawing.Size(245, 57);
            this.SBtnProductos.TabIndex = 1;
            this.SBtnProductos.Text = "Productos";
            this.SBtnProductos.UseVisualStyleBackColor = true;
            this.SBtnProductos.Click += new System.EventHandler(this.SBtnProductos_Click);
            // 
            // LogoPrincipal
            // 
            this.LogoPrincipal.Image = global::WindowsFormsApp1.Properties.Resources.logoUp;
            this.LogoPrincipal.Location = new System.Drawing.Point(0, 3);
            this.LogoPrincipal.Name = "LogoPrincipal";
            this.LogoPrincipal.Size = new System.Drawing.Size(93, 102);
            this.LogoPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPrincipal.TabIndex = 0;
            this.LogoPrincipal.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Principal";
            this.MenuVertical.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpbBtnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpbBtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpbBtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpbBtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox LogoPrincipal;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox SpbBtnCerrar;
        private System.Windows.Forms.PictureBox SpbBtnMinimizar;
        private System.Windows.Forms.PictureBox SpbBtnMaximizar;
        private System.Windows.Forms.PictureBox SpbBtnRestaurar;
        private System.Windows.Forms.Button SBtnProductos;
        private System.Windows.Forms.Button SBtnVentas;
        private System.Windows.Forms.Button SBtnClientes;
    }
}