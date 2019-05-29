namespace WindowsFormsApp1.Views
{
    partial class AddProduct
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
            this.cBoxAddCategoriaP = new System.Windows.Forms.ComboBox();
            this.btnAddCancelarP = new System.Windows.Forms.Button();
            this.btnAddAceptarP = new System.Windows.Forms.Button();
            this.tBoxAddDescripcion = new System.Windows.Forms.TextBox();
            this.tBoxAddCantidadP = new System.Windows.Forms.TextBox();
            this.tBoxAddCostoP = new System.Windows.Forms.TextBox();
            this.tBoxAddMarca = new System.Windows.Forms.TextBox();
            this.tBoxAddClaveF = new System.Windows.Forms.TextBox();
            this.tBoxAddClaveP = new System.Windows.Forms.TextBox();
            this.lblAddCantidad = new System.Windows.Forms.Label();
            this.lblAddCosto = new System.Windows.Forms.Label();
            this.lblAddDescripcion = new System.Windows.Forms.Label();
            this.lblAddCategoriaProducto = new System.Windows.Forms.Label();
            this.lblAddMarcaProducto = new System.Windows.Forms.Label();
            this.lblAddClaveFabricante = new System.Windows.Forms.Label();
            this.lblAddClaveProducto = new System.Windows.Forms.Label();
            this.PAddProducts = new System.Windows.Forms.Panel();
            this.LogoAddProducts = new System.Windows.Forms.PictureBox();
            this.lblAddProduct = new System.Windows.Forms.Label();
            this.PAddProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoAddProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxAddCategoriaP
            // 
            this.cBoxAddCategoriaP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxAddCategoriaP.FormattingEnabled = true;
            this.cBoxAddCategoriaP.Location = new System.Drawing.Point(598, 132);
            this.cBoxAddCategoriaP.Name = "cBoxAddCategoriaP";
            this.cBoxAddCategoriaP.Size = new System.Drawing.Size(206, 26);
            this.cBoxAddCategoriaP.TabIndex = 79;
            // 
            // btnAddCancelarP
            // 
            this.btnAddCancelarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAddCancelarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCancelarP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddCancelarP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCancelarP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCancelarP.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAddCancelarP.Location = new System.Drawing.Point(598, 359);
            this.btnAddCancelarP.Name = "btnAddCancelarP";
            this.btnAddCancelarP.Size = new System.Drawing.Size(112, 34);
            this.btnAddCancelarP.TabIndex = 78;
            this.btnAddCancelarP.Text = "Cancelar";
            this.btnAddCancelarP.UseVisualStyleBackColor = false;
            this.btnAddCancelarP.Click += new System.EventHandler(this.BtnAddCancelarP_Click);
            // 
            // btnAddAceptarP
            // 
            this.btnAddAceptarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAddAceptarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAceptarP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddAceptarP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAceptarP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAceptarP.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAddAceptarP.Location = new System.Drawing.Point(598, 289);
            this.btnAddAceptarP.Name = "btnAddAceptarP";
            this.btnAddAceptarP.Size = new System.Drawing.Size(112, 34);
            this.btnAddAceptarP.TabIndex = 77;
            this.btnAddAceptarP.Text = "Aceptar";
            this.btnAddAceptarP.UseVisualStyleBackColor = false;
            this.btnAddAceptarP.Click += new System.EventHandler(this.BtnAddAceptarP_Click);
            // 
            // tBoxAddDescripcion
            // 
            this.tBoxAddDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxAddDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tBoxAddDescripcion.Location = new System.Drawing.Point(285, 229);
            this.tBoxAddDescripcion.Multiline = true;
            this.tBoxAddDescripcion.Name = "tBoxAddDescripcion";
            this.tBoxAddDescripcion.Size = new System.Drawing.Size(206, 183);
            this.tBoxAddDescripcion.TabIndex = 76;
            // 
            // tBoxAddCantidadP
            // 
            this.tBoxAddCantidadP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxAddCantidadP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tBoxAddCantidadP.Location = new System.Drawing.Point(598, 184);
            this.tBoxAddCantidadP.Name = "tBoxAddCantidadP";
            this.tBoxAddCantidadP.Size = new System.Drawing.Size(206, 26);
            this.tBoxAddCantidadP.TabIndex = 75;
            this.tBoxAddCantidadP.Text = "0";
            this.tBoxAddCantidadP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBoxAddCantidadP_KeyPress);
            // 
            // tBoxAddCostoP
            // 
            this.tBoxAddCostoP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxAddCostoP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tBoxAddCostoP.Location = new System.Drawing.Point(285, 181);
            this.tBoxAddCostoP.Name = "tBoxAddCostoP";
            this.tBoxAddCostoP.Size = new System.Drawing.Size(206, 26);
            this.tBoxAddCostoP.TabIndex = 73;
            this.tBoxAddCostoP.Text = "0";
            this.tBoxAddCostoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBoxAddCostoP_KeyPress);
            // 
            // tBoxAddMarca
            // 
            this.tBoxAddMarca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxAddMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tBoxAddMarca.Location = new System.Drawing.Point(598, 85);
            this.tBoxAddMarca.Name = "tBoxAddMarca";
            this.tBoxAddMarca.Size = new System.Drawing.Size(206, 26);
            this.tBoxAddMarca.TabIndex = 72;
            // 
            // tBoxAddClaveF
            // 
            this.tBoxAddClaveF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxAddClaveF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tBoxAddClaveF.Location = new System.Drawing.Point(285, 132);
            this.tBoxAddClaveF.Name = "tBoxAddClaveF";
            this.tBoxAddClaveF.Size = new System.Drawing.Size(206, 26);
            this.tBoxAddClaveF.TabIndex = 71;
            // 
            // tBoxAddClaveP
            // 
            this.tBoxAddClaveP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxAddClaveP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tBoxAddClaveP.Location = new System.Drawing.Point(285, 85);
            this.tBoxAddClaveP.Name = "tBoxAddClaveP";
            this.tBoxAddClaveP.Size = new System.Drawing.Size(206, 26);
            this.tBoxAddClaveP.TabIndex = 70;
            // 
            // lblAddCantidad
            // 
            this.lblAddCantidad.AutoSize = true;
            this.lblAddCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCantidad.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAddCantidad.Location = new System.Drawing.Point(507, 187);
            this.lblAddCantidad.Name = "lblAddCantidad";
            this.lblAddCantidad.Size = new System.Drawing.Size(76, 18);
            this.lblAddCantidad.TabIndex = 69;
            this.lblAddCantidad.Text = "Cantidad:";
            // 
            // lblAddCosto
            // 
            this.lblAddCosto.AutoSize = true;
            this.lblAddCosto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCosto.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAddCosto.Location = new System.Drawing.Point(216, 184);
            this.lblAddCosto.Name = "lblAddCosto";
            this.lblAddCosto.Size = new System.Drawing.Size(54, 18);
            this.lblAddCosto.TabIndex = 67;
            this.lblAddCosto.Text = "Costo:";
            this.lblAddCosto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddDescripcion
            // 
            this.lblAddDescripcion.AutoSize = true;
            this.lblAddDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDescripcion.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAddDescripcion.Location = new System.Drawing.Point(176, 232);
            this.lblAddDescripcion.Name = "lblAddDescripcion";
            this.lblAddDescripcion.Size = new System.Drawing.Size(96, 18);
            this.lblAddDescripcion.TabIndex = 66;
            this.lblAddDescripcion.Text = "Descripcion:";
            this.lblAddDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddCategoriaProducto
            // 
            this.lblAddCategoriaProducto.AutoSize = true;
            this.lblAddCategoriaProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCategoriaProducto.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAddCategoriaProducto.Location = new System.Drawing.Point(503, 135);
            this.lblAddCategoriaProducto.Name = "lblAddCategoriaProducto";
            this.lblAddCategoriaProducto.Size = new System.Drawing.Size(82, 18);
            this.lblAddCategoriaProducto.TabIndex = 65;
            this.lblAddCategoriaProducto.Text = "Categoria:";
            this.lblAddCategoriaProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddMarcaProducto
            // 
            this.lblAddMarcaProducto.AutoSize = true;
            this.lblAddMarcaProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMarcaProducto.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAddMarcaProducto.Location = new System.Drawing.Point(529, 88);
            this.lblAddMarcaProducto.Name = "lblAddMarcaProducto";
            this.lblAddMarcaProducto.Size = new System.Drawing.Size(56, 18);
            this.lblAddMarcaProducto.TabIndex = 64;
            this.lblAddMarcaProducto.Text = "Marca:";
            // 
            // lblAddClaveFabricante
            // 
            this.lblAddClaveFabricante.AutoSize = true;
            this.lblAddClaveFabricante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddClaveFabricante.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAddClaveFabricante.Location = new System.Drawing.Point(117, 135);
            this.lblAddClaveFabricante.Name = "lblAddClaveFabricante";
            this.lblAddClaveFabricante.Size = new System.Drawing.Size(156, 18);
            this.lblAddClaveFabricante.TabIndex = 63;
            this.lblAddClaveFabricante.Text = "Clave del Fabricante:";
            // 
            // lblAddClaveProducto
            // 
            this.lblAddClaveProducto.AutoSize = true;
            this.lblAddClaveProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddClaveProducto.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAddClaveProducto.Location = new System.Drawing.Point(131, 88);
            this.lblAddClaveProducto.Name = "lblAddClaveProducto";
            this.lblAddClaveProducto.Size = new System.Drawing.Size(142, 18);
            this.lblAddClaveProducto.TabIndex = 62;
            this.lblAddClaveProducto.Text = "Clave del producto:";
            // 
            // PAddProducts
            // 
            this.PAddProducts.BackColor = System.Drawing.Color.DimGray;
            this.PAddProducts.Controls.Add(this.LogoAddProducts);
            this.PAddProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.PAddProducts.Location = new System.Drawing.Point(0, 0);
            this.PAddProducts.Name = "PAddProducts";
            this.PAddProducts.Size = new System.Drawing.Size(93, 450);
            this.PAddProducts.TabIndex = 61;
            this.PAddProducts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PAddProducts_MouseDown);
            // 
            // LogoAddProducts
            // 
            this.LogoAddProducts.Image = global::WindowsFormsApp1.Properties.Resources.logoUp;
            this.LogoAddProducts.Location = new System.Drawing.Point(1, 9);
            this.LogoAddProducts.Name = "LogoAddProducts";
            this.LogoAddProducts.Size = new System.Drawing.Size(93, 102);
            this.LogoAddProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoAddProducts.TabIndex = 1;
            this.LogoAddProducts.TabStop = false;
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProduct.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAddProduct.Location = new System.Drawing.Point(332, 20);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(227, 32);
            this.lblAddProduct.TabIndex = 80;
            this.lblAddProduct.Text = "Agregar Producto";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.lblAddProduct);
            this.Controls.Add(this.cBoxAddCategoriaP);
            this.Controls.Add(this.btnAddCancelarP);
            this.Controls.Add(this.btnAddAceptarP);
            this.Controls.Add(this.tBoxAddDescripcion);
            this.Controls.Add(this.tBoxAddCantidadP);
            this.Controls.Add(this.tBoxAddCostoP);
            this.Controls.Add(this.tBoxAddMarca);
            this.Controls.Add(this.tBoxAddClaveF);
            this.Controls.Add(this.tBoxAddClaveP);
            this.Controls.Add(this.lblAddCantidad);
            this.Controls.Add(this.lblAddCosto);
            this.Controls.Add(this.lblAddDescripcion);
            this.Controls.Add(this.lblAddCategoriaProducto);
            this.Controls.Add(this.lblAddMarcaProducto);
            this.Controls.Add(this.lblAddClaveFabricante);
            this.Controls.Add(this.lblAddClaveProducto);
            this.Controls.Add(this.PAddProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddProduct_MouseDown);
            this.PAddProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoAddProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxAddCategoriaP;
        private System.Windows.Forms.Button btnAddCancelarP;
        private System.Windows.Forms.Button btnAddAceptarP;
        private System.Windows.Forms.TextBox tBoxAddDescripcion;
        private System.Windows.Forms.TextBox tBoxAddCantidadP;
        private System.Windows.Forms.TextBox tBoxAddCostoP;
        private System.Windows.Forms.TextBox tBoxAddMarca;
        private System.Windows.Forms.TextBox tBoxAddClaveF;
        private System.Windows.Forms.TextBox tBoxAddClaveP;
        private System.Windows.Forms.Label lblAddCantidad;
        private System.Windows.Forms.Label lblAddCosto;
        private System.Windows.Forms.Label lblAddDescripcion;
        private System.Windows.Forms.Label lblAddCategoriaProducto;
        private System.Windows.Forms.Label lblAddMarcaProducto;
        private System.Windows.Forms.Label lblAddClaveFabricante;
        private System.Windows.Forms.Label lblAddClaveProducto;
        private System.Windows.Forms.Panel PAddProducts;
        private System.Windows.Forms.PictureBox LogoAddProducts;
        private System.Windows.Forms.Label lblAddProduct;
    }
}