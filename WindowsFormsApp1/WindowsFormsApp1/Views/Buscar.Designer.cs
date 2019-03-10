namespace WindowsFormsApp1.Views
{
    partial class Buscar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buscarTbl = new System.Windows.Forms.DataGridView();
            this.codigoClmBuscar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadClmBuscar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoClmBuscar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioClmBuscar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscarProductoTbx = new System.Windows.Forms.TextBox();
            this.buscarLbl = new System.Windows.Forms.Label();
            this.cancelarBtnBuscar = new System.Windows.Forms.Button();
            this.aceptarBtnBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buscarTbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarTbl
            // 
            this.buscarTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buscarTbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoClmBuscar,
            this.cantidadClmBuscar,
            this.productoClmBuscar,
            this.precioClmBuscar});
            this.buscarTbl.Location = new System.Drawing.Point(27, 130);
            this.buscarTbl.Name = "buscarTbl";
            this.buscarTbl.Size = new System.Drawing.Size(442, 242);
            this.buscarTbl.TabIndex = 1;
            // 
            // codigoClmBuscar
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoClmBuscar.DefaultCellStyle = dataGridViewCellStyle1;
            this.codigoClmBuscar.HeaderText = "Código";
            this.codigoClmBuscar.Name = "codigoClmBuscar";
            // 
            // cantidadClmBuscar
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadClmBuscar.DefaultCellStyle = dataGridViewCellStyle2;
            this.cantidadClmBuscar.HeaderText = "Cantidad";
            this.cantidadClmBuscar.Name = "cantidadClmBuscar";
            // 
            // productoClmBuscar
            // 
            this.productoClmBuscar.HeaderText = "Producto";
            this.productoClmBuscar.Name = "productoClmBuscar";
            // 
            // precioClmBuscar
            // 
            this.precioClmBuscar.HeaderText = "Precio";
            this.precioClmBuscar.Name = "precioClmBuscar";
            // 
            // buscarProductoTbx
            // 
            this.buscarProductoTbx.Location = new System.Drawing.Point(84, 87);
            this.buscarProductoTbx.Name = "buscarProductoTbx";
            this.buscarProductoTbx.Size = new System.Drawing.Size(289, 20);
            this.buscarProductoTbx.TabIndex = 2;
            // 
            // buscarLbl
            // 
            this.buscarLbl.AutoSize = true;
            this.buscarLbl.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarLbl.Location = new System.Drawing.Point(153, 26);
            this.buscarLbl.Name = "buscarLbl";
            this.buscarLbl.Size = new System.Drawing.Size(176, 29);
            this.buscarLbl.TabIndex = 3;
            this.buscarLbl.Text = "Buscar Producto";
            // 
            // cancelarBtnBuscar
            // 
            this.cancelarBtnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancelarBtnBuscar.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtnBuscar.Location = new System.Drawing.Point(264, 396);
            this.cancelarBtnBuscar.Name = "cancelarBtnBuscar";
            this.cancelarBtnBuscar.Size = new System.Drawing.Size(96, 37);
            this.cancelarBtnBuscar.TabIndex = 5;
            this.cancelarBtnBuscar.Text = "Cancelar";
            this.cancelarBtnBuscar.UseVisualStyleBackColor = false;
            // 
            // aceptarBtnBuscar
            // 
            this.aceptarBtnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.aceptarBtnBuscar.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.aceptarBtnBuscar.Location = new System.Drawing.Point(381, 396);
            this.aceptarBtnBuscar.Name = "aceptarBtnBuscar";
            this.aceptarBtnBuscar.Size = new System.Drawing.Size(88, 37);
            this.aceptarBtnBuscar.TabIndex = 6;
            this.aceptarBtnBuscar.Text = "Aceptar";
            this.aceptarBtnBuscar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(391, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 445);
            this.Controls.Add(this.aceptarBtnBuscar);
            this.Controls.Add(this.cancelarBtnBuscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buscarLbl);
            this.Controls.Add(this.buscarProductoTbx);
            this.Controls.Add(this.buscarTbl);
            this.Name = "Buscar";
            this.Text = "Buscar";
            ((System.ComponentModel.ISupportInitialize)(this.buscarTbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView buscarTbl;
        private System.Windows.Forms.TextBox buscarProductoTbx;
        private System.Windows.Forms.Label buscarLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cancelarBtnBuscar;
        private System.Windows.Forms.Button aceptarBtnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoClmBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadClmBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoClmBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioClmBuscar;
    }
}