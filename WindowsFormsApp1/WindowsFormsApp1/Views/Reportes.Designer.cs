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
            this.dtgReportes = new System.Windows.Forms.DataGridView();
            this.cantidadDTGRepor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descDTGRepor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDTGRepor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDtgRepor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportes.Location = new System.Drawing.Point(308, 25);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(125, 31);
            this.lblReportes.TabIndex = 0;
            this.lblReportes.Text = "Reportes";
            // 
            // comboPor
            // 
            this.comboPor.FormattingEnabled = true;
            this.comboPor.Location = new System.Drawing.Point(194, 87);
            this.comboPor.Name = "comboPor";
            this.comboPor.Size = new System.Drawing.Size(121, 21);
            this.comboPor.TabIndex = 1;
            // 
            // textFecha
            // 
            this.textFecha.Location = new System.Drawing.Point(455, 87);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(126, 20);
            this.textFecha.TabIndex = 2;
            // 
            // lblPor
            // 
            this.lblPor.AutoSize = true;
            this.lblPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPor.Location = new System.Drawing.Point(159, 91);
            this.lblPor.Name = "lblPor";
            this.lblPor.Size = new System.Drawing.Size(29, 16);
            this.lblPor.TabIndex = 4;
            this.lblPor.Text = "Por";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(403, 88);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 16);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(171, 418);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(77, 27);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(102, 377);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 16);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total";
            // 
            // dtgReportes
            // 
            this.dtgReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cantidadDTGRepor,
            this.descDTGRepor,
            this.precioDTGRepor,
            this.totalDtgRepor});
            this.dtgReportes.Location = new System.Drawing.Point(105, 125);
            this.dtgReportes.Name = "dtgReportes";
            this.dtgReportes.Size = new System.Drawing.Size(562, 223);
            this.dtgReportes.TabIndex = 8;
            // 
            // cantidadDTGRepor
            // 
            this.cantidadDTGRepor.HeaderText = "Cantidad";
            this.cantidadDTGRepor.Name = "cantidadDTGRepor";
            this.cantidadDTGRepor.Width = 130;
            // 
            // descDTGRepor
            // 
            this.descDTGRepor.HeaderText = "Descripción";
            this.descDTGRepor.Name = "descDTGRepor";
            this.descDTGRepor.Width = 130;
            // 
            // precioDTGRepor
            // 
            this.precioDTGRepor.HeaderText = "Precio";
            this.precioDTGRepor.Name = "precioDTGRepor";
            this.precioDTGRepor.Width = 130;
            // 
            // totalDtgRepor
            // 
            this.totalDtgRepor.HeaderText = "Total";
            this.totalDtgRepor.Name = "totalDtgRepor";
            this.totalDtgRepor.Width = 130;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 481);
            this.Controls.Add(this.dtgReportes);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblPor);
            this.Controls.Add(this.textFecha);
            this.Controls.Add(this.comboPor);
            this.Controls.Add(this.lblReportes);
            this.Name = "Reportes";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgReportes)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgReportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDTGRepor;
        private System.Windows.Forms.DataGridViewTextBoxColumn descDTGRepor;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDTGRepor;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDtgRepor;
    }
}