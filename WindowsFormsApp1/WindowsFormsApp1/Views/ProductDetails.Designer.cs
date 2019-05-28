namespace WindowsFormsApp1.Views
{
    partial class ProductDetails
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
            this.cBoxCategoriaProd = new System.Windows.Forms.ComboBox();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnCancelarProducto = new System.Windows.Forms.Button();
            this.btnAceptarProduct = new System.Windows.Forms.Button();
            this.tBoxDescripcion = new System.Windows.Forms.TextBox();
            this.tBoxCantidadProd = new System.Windows.Forms.TextBox();
            this.tBoxMoneda = new System.Windows.Forms.TextBox();
            this.tBoxCostoProducto = new System.Windows.Forms.TextBox();
            this.tBoxMarca = new System.Windows.Forms.TextBox();
            this.tBoxClaveFabricante = new System.Windows.Forms.TextBox();
            this.tBoxClaveProducto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCategoriaProducto = new System.Windows.Forms.Label();
            this.lblMarcaProducto = new System.Windows.Forms.Label();
            this.lblClaveFabricante = new System.Windows.Forms.Label();
            this.lblClaveProducto = new System.Windows.Forms.Label();
            this.lblProductDetail = new System.Windows.Forms.Label();
            this.PProducts = new System.Windows.Forms.Panel();
            this.LogoProducts = new System.Windows.Forms.PictureBox();
            this.btnEliminateProduct = new System.Windows.Forms.Button();
            this.PProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxCategoriaProd
            // 
            this.cBoxCategoriaProd.Enabled = false;
            this.cBoxCategoriaProd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxCategoriaProd.FormattingEnabled = true;
            this.cBoxCategoriaProd.Location = new System.Drawing.Point(602, 132);
            this.cBoxCategoriaProd.Name = "cBoxCategoriaProd";
            this.cBoxCategoriaProd.Size = new System.Drawing.Size(206, 26);
            this.cBoxCategoriaProd.TabIndex = 60;
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnModificarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarProducto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProducto.ForeColor = System.Drawing.Color.Orange;
            this.btnModificarProducto.Location = new System.Drawing.Point(675, 283);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(112, 34);
            this.btnModificarProducto.TabIndex = 59;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = false;
            this.btnModificarProducto.Click += new System.EventHandler(this.BtnModificarProducto_Click);
            // 
            // btnCancelarProducto
            // 
            this.btnCancelarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancelarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarProducto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProducto.ForeColor = System.Drawing.Color.Orange;
            this.btnCancelarProducto.Location = new System.Drawing.Point(675, 363);
            this.btnCancelarProducto.Name = "btnCancelarProducto";
            this.btnCancelarProducto.Size = new System.Drawing.Size(112, 34);
            this.btnCancelarProducto.TabIndex = 58;
            this.btnCancelarProducto.Text = "Cancelar";
            this.btnCancelarProducto.UseVisualStyleBackColor = false;
            this.btnCancelarProducto.Visible = false;
            this.btnCancelarProducto.Click += new System.EventHandler(this.BtnCancelarProducto_Click);
            // 
            // btnAceptarProduct
            // 
            this.btnAceptarProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAceptarProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAceptarProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptarProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarProduct.ForeColor = System.Drawing.Color.Orange;
            this.btnAceptarProduct.Location = new System.Drawing.Point(523, 283);
            this.btnAceptarProduct.Name = "btnAceptarProduct";
            this.btnAceptarProduct.Size = new System.Drawing.Size(112, 34);
            this.btnAceptarProduct.TabIndex = 57;
            this.btnAceptarProduct.Text = "Aceptar";
            this.btnAceptarProduct.UseVisualStyleBackColor = false;
            this.btnAceptarProduct.Click += new System.EventHandler(this.BtnAceptarProduct_Click);
            // 
            // tBoxDescripcion
            // 
            this.tBoxDescripcion.Enabled = false;
            this.tBoxDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tBoxDescripcion.Location = new System.Drawing.Point(267, 229);
            this.tBoxDescripcion.Multiline = true;
            this.tBoxDescripcion.Name = "tBoxDescripcion";
            this.tBoxDescripcion.Size = new System.Drawing.Size(206, 183);
            this.tBoxDescripcion.TabIndex = 56;
            // 
            // tBoxCantidadProd
            // 
            this.tBoxCantidadProd.Enabled = false;
            this.tBoxCantidadProd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxCantidadProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tBoxCantidadProd.Location = new System.Drawing.Point(602, 226);
            this.tBoxCantidadProd.Name = "tBoxCantidadProd";
            this.tBoxCantidadProd.Size = new System.Drawing.Size(206, 26);
            this.tBoxCantidadProd.TabIndex = 55;
            this.tBoxCantidadProd.Text = "0";
            // 
            // tBoxMoneda
            // 
            this.tBoxMoneda.BackColor = System.Drawing.SystemColors.Window;
            this.tBoxMoneda.Enabled = false;
            this.tBoxMoneda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxMoneda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tBoxMoneda.Location = new System.Drawing.Point(602, 181);
            this.tBoxMoneda.Name = "tBoxMoneda";
            this.tBoxMoneda.Size = new System.Drawing.Size(206, 26);
            this.tBoxMoneda.TabIndex = 54;
            // 
            // tBoxCostoProducto
            // 
            this.tBoxCostoProducto.Enabled = false;
            this.tBoxCostoProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxCostoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tBoxCostoProducto.Location = new System.Drawing.Point(267, 181);
            this.tBoxCostoProducto.Name = "tBoxCostoProducto";
            this.tBoxCostoProducto.Size = new System.Drawing.Size(206, 26);
            this.tBoxCostoProducto.TabIndex = 53;
            this.tBoxCostoProducto.Text = "0";
            // 
            // tBoxMarca
            // 
            this.tBoxMarca.Enabled = false;
            this.tBoxMarca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tBoxMarca.Location = new System.Drawing.Point(602, 85);
            this.tBoxMarca.Name = "tBoxMarca";
            this.tBoxMarca.Size = new System.Drawing.Size(206, 26);
            this.tBoxMarca.TabIndex = 52;
            // 
            // tBoxClaveFabricante
            // 
            this.tBoxClaveFabricante.Enabled = false;
            this.tBoxClaveFabricante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxClaveFabricante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tBoxClaveFabricante.Location = new System.Drawing.Point(267, 132);
            this.tBoxClaveFabricante.Name = "tBoxClaveFabricante";
            this.tBoxClaveFabricante.Size = new System.Drawing.Size(206, 26);
            this.tBoxClaveFabricante.TabIndex = 51;
            // 
            // tBoxClaveProducto
            // 
            this.tBoxClaveProducto.Enabled = false;
            this.tBoxClaveProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxClaveProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tBoxClaveProducto.Location = new System.Drawing.Point(267, 85);
            this.tBoxClaveProducto.Name = "tBoxClaveProducto";
            this.tBoxClaveProducto.Size = new System.Drawing.Size(206, 26);
            this.tBoxClaveProducto.TabIndex = 50;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCantidad.Location = new System.Drawing.Point(511, 229);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(76, 18);
            this.lblCantidad.TabIndex = 49;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMoneda.Location = new System.Drawing.Point(520, 184);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(69, 18);
            this.lblMoneda.TabIndex = 48;
            this.lblMoneda.Text = "Moneda:";
            this.lblMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCosto.Location = new System.Drawing.Point(198, 184);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(54, 18);
            this.lblCosto.TabIndex = 47;
            this.lblCosto.Text = "Costo:";
            this.lblCosto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblDescripcion.Location = new System.Drawing.Point(158, 232);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(96, 18);
            this.lblDescripcion.TabIndex = 46;
            this.lblDescripcion.Text = "Descripcion:";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategoriaProducto
            // 
            this.lblCategoriaProducto.AutoSize = true;
            this.lblCategoriaProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaProducto.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCategoriaProducto.Location = new System.Drawing.Point(507, 135);
            this.lblCategoriaProducto.Name = "lblCategoriaProducto";
            this.lblCategoriaProducto.Size = new System.Drawing.Size(82, 18);
            this.lblCategoriaProducto.TabIndex = 45;
            this.lblCategoriaProducto.Text = "Categoria:";
            this.lblCategoriaProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMarcaProducto
            // 
            this.lblMarcaProducto.AutoSize = true;
            this.lblMarcaProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaProducto.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMarcaProducto.Location = new System.Drawing.Point(533, 88);
            this.lblMarcaProducto.Name = "lblMarcaProducto";
            this.lblMarcaProducto.Size = new System.Drawing.Size(56, 18);
            this.lblMarcaProducto.TabIndex = 44;
            this.lblMarcaProducto.Text = "Marca:";
            // 
            // lblClaveFabricante
            // 
            this.lblClaveFabricante.AutoSize = true;
            this.lblClaveFabricante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveFabricante.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblClaveFabricante.Location = new System.Drawing.Point(99, 135);
            this.lblClaveFabricante.Name = "lblClaveFabricante";
            this.lblClaveFabricante.Size = new System.Drawing.Size(156, 18);
            this.lblClaveFabricante.TabIndex = 43;
            this.lblClaveFabricante.Text = "Clave del Fabricante:";
            // 
            // lblClaveProducto
            // 
            this.lblClaveProducto.AutoSize = true;
            this.lblClaveProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveProducto.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblClaveProducto.Location = new System.Drawing.Point(113, 88);
            this.lblClaveProducto.Name = "lblClaveProducto";
            this.lblClaveProducto.Size = new System.Drawing.Size(142, 18);
            this.lblClaveProducto.TabIndex = 42;
            this.lblClaveProducto.Text = "Clave del producto:";
            // 
            // lblProductDetail
            // 
            this.lblProductDetail.AutoSize = true;
            this.lblProductDetail.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDetail.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblProductDetail.Location = new System.Drawing.Point(315, 20);
            this.lblProductDetail.Name = "lblProductDetail";
            this.lblProductDetail.Size = new System.Drawing.Size(274, 32);
            this.lblProductDetail.TabIndex = 41;
            this.lblProductDetail.Text = "Detalles del Producto";
            // 
            // PProducts
            // 
            this.PProducts.BackColor = System.Drawing.Color.DimGray;
            this.PProducts.Controls.Add(this.LogoProducts);
            this.PProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.PProducts.Location = new System.Drawing.Point(0, 0);
            this.PProducts.Name = "PProducts";
            this.PProducts.Size = new System.Drawing.Size(93, 450);
            this.PProducts.TabIndex = 40;
            this.PProducts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PProducts_MouseDown);
            // 
            // LogoProducts
            // 
            this.LogoProducts.Image = global::WindowsFormsApp1.Properties.Resources.logoUp;
            this.LogoProducts.Location = new System.Drawing.Point(1, 9);
            this.LogoProducts.Name = "LogoProducts";
            this.LogoProducts.Size = new System.Drawing.Size(93, 102);
            this.LogoProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoProducts.TabIndex = 1;
            this.LogoProducts.TabStop = false;
            // 
            // btnEliminateProduct
            // 
            this.btnEliminateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEliminateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminateProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminateProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminateProduct.ForeColor = System.Drawing.Color.Orange;
            this.btnEliminateProduct.Location = new System.Drawing.Point(523, 363);
            this.btnEliminateProduct.Name = "btnEliminateProduct";
            this.btnEliminateProduct.Size = new System.Drawing.Size(112, 34);
            this.btnEliminateProduct.TabIndex = 61;
            this.btnEliminateProduct.Text = "Eliminar";
            this.btnEliminateProduct.UseVisualStyleBackColor = false;
            this.btnEliminateProduct.Click += new System.EventHandler(this.BtnEliminateProduct_Click);
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.btnEliminateProduct);
            this.Controls.Add(this.cBoxCategoriaProd);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.btnCancelarProducto);
            this.Controls.Add(this.btnAceptarProduct);
            this.Controls.Add(this.tBoxDescripcion);
            this.Controls.Add(this.tBoxCantidadProd);
            this.Controls.Add(this.tBoxMoneda);
            this.Controls.Add(this.tBoxCostoProducto);
            this.Controls.Add(this.tBoxMarca);
            this.Controls.Add(this.tBoxClaveFabricante);
            this.Controls.Add(this.tBoxClaveProducto);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCategoriaProducto);
            this.Controls.Add(this.lblMarcaProducto);
            this.Controls.Add(this.lblClaveFabricante);
            this.Controls.Add(this.lblClaveProducto);
            this.Controls.Add(this.lblProductDetail);
            this.Controls.Add(this.PProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductDetails";
            this.Opacity = 0.9D;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProductDetails_MouseDown);
            this.PProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxCategoriaProd;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnCancelarProducto;
        private System.Windows.Forms.Button btnAceptarProduct;
        private System.Windows.Forms.TextBox tBoxDescripcion;
        private System.Windows.Forms.TextBox tBoxCantidadProd;
        private System.Windows.Forms.TextBox tBoxMoneda;
        private System.Windows.Forms.TextBox tBoxCostoProducto;
        private System.Windows.Forms.TextBox tBoxMarca;
        private System.Windows.Forms.TextBox tBoxClaveFabricante;
        private System.Windows.Forms.TextBox tBoxClaveProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCategoriaProducto;
        private System.Windows.Forms.Label lblMarcaProducto;
        private System.Windows.Forms.Label lblClaveFabricante;
        private System.Windows.Forms.Label lblClaveProducto;
        private System.Windows.Forms.Label lblProductDetail;
        private System.Windows.Forms.Panel PProducts;
        private System.Windows.Forms.PictureBox LogoProducts;
        private System.Windows.Forms.Button btnEliminateProduct;
    }
}