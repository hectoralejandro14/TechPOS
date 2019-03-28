namespace WindowsFormsApp1.Views
{
    partial class Reportes
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
            this.lblReportes = new System.Windows.Forms.Label();
            this.comboPor = new System.Windows.Forms.ComboBox();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.lblPor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cantidadClmReportes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descClmReportes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUClmReportes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalClmReportes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportes.Location = new System.Drawing.Point(308, 25);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(117, 34);
            this.lblReportes.TabIndex = 0;
            this.lblReportes.Text = "Reportes";
            // 
            // comboPor
            // 
            this.comboPor.FormattingEnabled = true;
            this.comboPor.Location = new System.Drawing.Point(92, 95);
            this.comboPor.Name = "comboPor";
            this.comboPor.Size = new System.Drawing.Size(121, 21);
            this.comboPor.TabIndex = 1;
            // 
            // textFecha
            // 
            this.textFecha.Location = new System.Drawing.Point(314, 95);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(126, 20);
            this.textFecha.TabIndex = 2;
            // 
            // lblPor
            // 
            this.lblPor.AutoSize = true;
            this.lblPor.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPor.Location = new System.Drawing.Point(39, 87);
            this.lblPor.Name = "lblPor";
            this.lblPor.Size = new System.Drawing.Size(42, 34);
            this.lblPor.TabIndex = 4;
            this.lblPor.Text = "Por";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.lblFecha.Location = new System.Drawing.Point(241, 87);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 34);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.DimGray;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.Turquoise;
            this.btnImprimir.Location = new System.Drawing.Point(374, 433);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(87, 39);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(60, 342);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 34);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cantidadClmReportes,
            this.descClmReportes,
            this.precioUClmReportes,
            this.totalClmReportes});
            this.dataGridView1.Location = new System.Drawing.Point(23, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 184);
            this.dataGridView1.TabIndex = 8;
            // 
            // cantidadClmReportes
            // 
            this.cantidadClmReportes.HeaderText = "Cantidad";
            this.cantidadClmReportes.Name = "cantidadClmReportes";
            this.cantidadClmReportes.Width = 140;
            // 
            // descClmReportes
            // 
            this.descClmReportes.HeaderText = "Descripción";
            this.descClmReportes.Name = "descClmReportes";
            this.descClmReportes.Width = 140;
            // 
            // precioUClmReportes
            // 
            this.precioUClmReportes.HeaderText = "Precio U.";
            this.precioUClmReportes.Name = "precioUClmReportes";
            this.precioUClmReportes.Width = 140;
            // 
            // totalClmReportes
            // 
            this.totalClmReportes.HeaderText = "Total";
            this.totalClmReportes.Name = "totalClmReportes";
            this.totalClmReportes.Width = 140;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(125, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "$";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(658, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblPor);
            this.Controls.Add(this.textFecha);
            this.Controls.Add(this.comboPor);
            this.Controls.Add(this.lblReportes);
            this.Name = "Reportes";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReportes;
        private System.Windows.Forms.ComboBox comboPor;
        private System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.Label lblPor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadClmReportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn descClmReportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUClmReportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalClmReportes;
    }
}