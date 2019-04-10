namespace WindowsFormsApp1.ViewsBetta
{
    partial class Ventas
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
            this.ClblCodigoDeBarras = new System.Windows.Forms.Label();
            this.buscarTbxVentas = new System.Windows.Forms.TextBox();
            this.tableVender = new System.Windows.Forms.DataGridView();
            this.codClmVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantClVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrClmVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUClmVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTClmVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTbxVenta = new System.Windows.Forms.TextBox();
            this.ivaTbxVentas = new System.Windows.Forms.TextBox();
            this.subTotalTbxVentas = new System.Windows.Forms.TextBox();
            this.totalLblVentas = new System.Windows.Forms.Label();
            this.ivaLblVenta = new System.Windows.Forms.Label();
            this.subTotalLblVenta = new System.Windows.Forms.Label();
            this.CbtnCancelarVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SBtnRealizarVenta = new System.Windows.Forms.Button();
            this.SbtnCerrarVenta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableVender)).BeginInit();
            this.SuspendLayout();
            // 
            // ClblCodigoDeBarras
            // 
            this.ClblCodigoDeBarras.AutoSize = true;
            this.ClblCodigoDeBarras.Location = new System.Drawing.Point(175, 51);
            this.ClblCodigoDeBarras.Name = "ClblCodigoDeBarras";
            this.ClblCodigoDeBarras.Size = new System.Drawing.Size(101, 13);
            this.ClblCodigoDeBarras.TabIndex = 20;
            this.ClblCodigoDeBarras.Text = "Codigo de Producto";
            // 
            // buscarTbxVentas
            // 
            this.buscarTbxVentas.Location = new System.Drawing.Point(282, 48);
            this.buscarTbxVentas.Name = "buscarTbxVentas";
            this.buscarTbxVentas.Size = new System.Drawing.Size(405, 20);
            this.buscarTbxVentas.TabIndex = 21;
            // 
            // tableVender
            // 
            this.tableVender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableVender.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codClmVenta,
            this.cantClVenta,
            this.descrClmVenta,
            this.precioUClmVenta,
            this.precioTClmVenta});
            this.tableVender.Location = new System.Drawing.Point(12, 86);
            this.tableVender.Name = "tableVender";
            this.tableVender.RowHeadersVisible = false;
            this.tableVender.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableVender.Size = new System.Drawing.Size(776, 321);
            this.tableVender.TabIndex = 22;
            // 
            // codClmVenta
            // 
            this.codClmVenta.HeaderText = "Código";
            this.codClmVenta.Name = "codClmVenta";
            // 
            // cantClVenta
            // 
            this.cantClVenta.HeaderText = "Cantidad";
            this.cantClVenta.Name = "cantClVenta";
            // 
            // descrClmVenta
            // 
            this.descrClmVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descrClmVenta.HeaderText = "Descripción";
            this.descrClmVenta.Name = "descrClmVenta";
            // 
            // precioUClmVenta
            // 
            this.precioUClmVenta.HeaderText = "Precio U.";
            this.precioUClmVenta.Name = "precioUClmVenta";
            this.precioUClmVenta.Width = 125;
            // 
            // precioTClmVenta
            // 
            this.precioTClmVenta.HeaderText = "Precio T.";
            this.precioTClmVenta.Name = "precioTClmVenta";
            this.precioTClmVenta.Width = 125;
            // 
            // totalTbxVenta
            // 
            this.totalTbxVenta.Location = new System.Drawing.Point(71, 462);
            this.totalTbxVenta.Name = "totalTbxVenta";
            this.totalTbxVenta.Size = new System.Drawing.Size(210, 20);
            this.totalTbxVenta.TabIndex = 28;
            // 
            // ivaTbxVentas
            // 
            this.ivaTbxVentas.Location = new System.Drawing.Point(71, 436);
            this.ivaTbxVentas.Name = "ivaTbxVentas";
            this.ivaTbxVentas.Size = new System.Drawing.Size(210, 20);
            this.ivaTbxVentas.TabIndex = 27;
            // 
            // subTotalTbxVentas
            // 
            this.subTotalTbxVentas.Location = new System.Drawing.Point(71, 410);
            this.subTotalTbxVentas.Name = "subTotalTbxVentas";
            this.subTotalTbxVentas.Size = new System.Drawing.Size(210, 20);
            this.subTotalTbxVentas.TabIndex = 26;
            // 
            // totalLblVentas
            // 
            this.totalLblVentas.AutoSize = true;
            this.totalLblVentas.Location = new System.Drawing.Point(12, 465);
            this.totalLblVentas.Name = "totalLblVentas";
            this.totalLblVentas.Size = new System.Drawing.Size(34, 13);
            this.totalLblVentas.TabIndex = 25;
            this.totalLblVentas.Text = "Total:";
            // 
            // ivaLblVenta
            // 
            this.ivaLblVenta.AutoSize = true;
            this.ivaLblVenta.Location = new System.Drawing.Point(12, 438);
            this.ivaLblVenta.Name = "ivaLblVenta";
            this.ivaLblVenta.Size = new System.Drawing.Size(33, 13);
            this.ivaLblVenta.TabIndex = 24;
            this.ivaLblVenta.Text = "I.V.A:";
            // 
            // subTotalLblVenta
            // 
            this.subTotalLblVenta.AutoSize = true;
            this.subTotalLblVenta.Location = new System.Drawing.Point(12, 410);
            this.subTotalLblVenta.Name = "subTotalLblVenta";
            this.subTotalLblVenta.Size = new System.Drawing.Size(53, 13);
            this.subTotalLblVenta.TabIndex = 23;
            this.subTotalLblVenta.Text = "SubTotal:";
            // 
            // CbtnCancelarVenta
            // 
            this.CbtnCancelarVenta.BackColor = System.Drawing.Color.DimGray;
            this.CbtnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbtnCancelarVenta.ForeColor = System.Drawing.Color.White;
            this.CbtnCancelarVenta.Location = new System.Drawing.Point(543, 458);
            this.CbtnCancelarVenta.Name = "CbtnCancelarVenta";
            this.CbtnCancelarVenta.Size = new System.Drawing.Size(245, 26);
            this.CbtnCancelarVenta.TabIndex = 30;
            this.CbtnCancelarVenta.Text = "Cancelar";
            this.CbtnCancelarVenta.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ventas UP - Software";
            // 
            // SBtnRealizarVenta
            // 
            this.SBtnRealizarVenta.BackColor = System.Drawing.Color.DarkOrange;
            this.SBtnRealizarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnRealizarVenta.FlatAppearance.BorderSize = 0;
            this.SBtnRealizarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.SBtnRealizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SBtnRealizarVenta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SBtnRealizarVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SBtnRealizarVenta.Image = global::WindowsFormsApp1.Properties.Resources.producto;
            this.SBtnRealizarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SBtnRealizarVenta.Location = new System.Drawing.Point(543, 422);
            this.SBtnRealizarVenta.Name = "SBtnRealizarVenta";
            this.SBtnRealizarVenta.Size = new System.Drawing.Size(245, 29);
            this.SBtnRealizarVenta.TabIndex = 32;
            this.SBtnRealizarVenta.Text = "Realizar Venta";
            this.SBtnRealizarVenta.UseVisualStyleBackColor = false;
            // 
            // SbtnCerrarVenta
            // 
            this.SbtnCerrarVenta.AutoSize = true;
            this.SbtnCerrarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SbtnCerrarVenta.ForeColor = System.Drawing.Color.Red;
            this.SbtnCerrarVenta.Location = new System.Drawing.Point(787, 0);
            this.SbtnCerrarVenta.Name = "SbtnCerrarVenta";
            this.SbtnCerrarVenta.Size = new System.Drawing.Size(14, 13);
            this.SbtnCerrarVenta.TabIndex = 33;
            this.SbtnCerrarVenta.Text = "X";
            this.SbtnCerrarVenta.Click += new System.EventHandler(this.SbtnCerrarVenta_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.SbtnCerrarVenta);
            this.Controls.Add(this.SBtnRealizarVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbtnCancelarVenta);
            this.Controls.Add(this.totalTbxVenta);
            this.Controls.Add(this.ivaTbxVentas);
            this.Controls.Add(this.subTotalTbxVentas);
            this.Controls.Add(this.totalLblVentas);
            this.Controls.Add(this.ivaLblVenta);
            this.Controls.Add(this.subTotalLblVenta);
            this.Controls.Add(this.tableVender);
            this.Controls.Add(this.buscarTbxVentas);
            this.Controls.Add(this.ClblCodigoDeBarras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.tableVender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClblCodigoDeBarras;
        private System.Windows.Forms.TextBox buscarTbxVentas;
        private System.Windows.Forms.DataGridView tableVender;
        private System.Windows.Forms.DataGridViewTextBoxColumn codClmVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantClVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrClmVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUClmVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTClmVenta;
        private System.Windows.Forms.TextBox totalTbxVenta;
        private System.Windows.Forms.TextBox ivaTbxVentas;
        private System.Windows.Forms.TextBox subTotalTbxVentas;
        private System.Windows.Forms.Label totalLblVentas;
        private System.Windows.Forms.Label ivaLblVenta;
        private System.Windows.Forms.Label subTotalLblVenta;
        private System.Windows.Forms.Button CbtnCancelarVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SBtnRealizarVenta;
        private System.Windows.Forms.Label SbtnCerrarVenta;
    }
}