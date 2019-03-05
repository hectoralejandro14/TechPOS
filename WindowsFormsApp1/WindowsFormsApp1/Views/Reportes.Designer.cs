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
            // dataReportes
            // 
            this.dataReportes.AllowUserToOrderColumns = true;
            this.dataReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataReportes.Location = new System.Drawing.Point(96, 123);
            this.dataReportes.Name = "dataReportes";
            this.dataReportes.Size = new System.Drawing.Size(628, 210);
            this.dataReportes.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.FillWeight = 200F;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Cantidad";
            this.Column1.Name = "Column1";
            this.Column1.Width = 74;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripción";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.Width = 56;
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
        private System.Windows.Forms.DataGridView dataReportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblPor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblTotal;
    }
}