namespace WindowsFormsApp1.Views
{
    partial class ReportesEspecificos
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
            System.Windows.Forms.LinkLabel lbReportesEDiv;
            this.panelReportesEspecificos = new System.Windows.Forms.Panel();
            this.imgReportesEspecificos = new System.Windows.Forms.PictureBox();
            this.fechaReportePedido = new System.Windows.Forms.DateTimePicker();
            this.rbReportesDeCancelacion = new System.Windows.Forms.RadioButton();
            this.rbReportesDeVenta = new System.Windows.Forms.RadioButton();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lbReportesEDiv = new System.Windows.Forms.LinkLabel();
            this.panelReportesEspecificos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgReportesEspecificos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReportesEspecificos
            // 
            this.panelReportesEspecificos.BackColor = System.Drawing.Color.Black;
            this.panelReportesEspecificos.Controls.Add(this.imgReportesEspecificos);
            this.panelReportesEspecificos.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelReportesEspecificos.Location = new System.Drawing.Point(0, 0);
            this.panelReportesEspecificos.Name = "panelReportesEspecificos";
            this.panelReportesEspecificos.Size = new System.Drawing.Size(152, 609);
            this.panelReportesEspecificos.TabIndex = 13;
            this.panelReportesEspecificos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelReportesEspecificos_MouseDown);
            // 
            // imgReportesEspecificos
            // 
            this.imgReportesEspecificos.Image = global::WindowsFormsApp1.Properties.Resources.logoUp;
            this.imgReportesEspecificos.Location = new System.Drawing.Point(12, 3);
            this.imgReportesEspecificos.Name = "imgReportesEspecificos";
            this.imgReportesEspecificos.Size = new System.Drawing.Size(130, 222);
            this.imgReportesEspecificos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgReportesEspecificos.TabIndex = 11;
            this.imgReportesEspecificos.TabStop = false;
            // 
            // fechaReportePedido
            // 
            this.fechaReportePedido.Location = new System.Drawing.Point(461, 56);
            this.fechaReportePedido.Name = "fechaReportePedido";
            this.fechaReportePedido.Size = new System.Drawing.Size(242, 20);
            this.fechaReportePedido.TabIndex = 14;
            // 
            // rbReportesDeCancelacion
            // 
            this.rbReportesDeCancelacion.AutoSize = true;
            this.rbReportesDeCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReportesDeCancelacion.Location = new System.Drawing.Point(203, 56);
            this.rbReportesDeCancelacion.Name = "rbReportesDeCancelacion";
            this.rbReportesDeCancelacion.Size = new System.Drawing.Size(229, 24);
            this.rbReportesDeCancelacion.TabIndex = 15;
            this.rbReportesDeCancelacion.TabStop = true;
            this.rbReportesDeCancelacion.Text = "Reportes de Cancelacion";
            this.rbReportesDeCancelacion.UseVisualStyleBackColor = true;
            // 
            // rbReportesDeVenta
            // 
            this.rbReportesDeVenta.AutoSize = true;
            this.rbReportesDeVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReportesDeVenta.Location = new System.Drawing.Point(203, 86);
            this.rbReportesDeVenta.Name = "rbReportesDeVenta";
            this.rbReportesDeVenta.Size = new System.Drawing.Size(179, 24);
            this.rbReportesDeVenta.TabIndex = 18;
            this.rbReportesDeVenta.TabStop = true;
            this.rbReportesDeVenta.Text = "Reportes de Venta";
            this.rbReportesDeVenta.UseVisualStyleBackColor = true;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGenerarReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarReporte.FlatAppearance.BorderSize = 0;
            this.btnGenerarReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnGenerarReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnGenerarReporte.Location = new System.Drawing.Point(723, 56);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(217, 28);
            this.btnGenerarReporte.TabIndex = 19;
            this.btnGenerarReporte.Text = "Aceptar";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.BtnGenerarReporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 42);
            this.label1.TabIndex = 20;
            this.label1.Text = "Reportes";
            // 
            // lbReportesEDiv
            // 
            lbReportesEDiv.AutoSize = true;
            lbReportesEDiv.LinkColor = System.Drawing.Color.DimGray;
            lbReportesEDiv.Location = new System.Drawing.Point(172, 113);
            lbReportesEDiv.Name = "lbReportesEDiv";
            lbReportesEDiv.Size = new System.Drawing.Size(805, 13);
            lbReportesEDiv.TabIndex = 21;
            lbReportesEDiv.TabStop = true;
            lbReportesEDiv.Text = "_________________________________________________________________________________" +
    "____________________________________________________";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion,
            this.usuarioC});
            this.dataGridView1.Location = new System.Drawing.Point(175, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(802, 423);
            this.dataGridView1.TabIndex = 22;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.DarkOrange;
            this.BtnCerrar.Location = new System.Drawing.Point(760, 569);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(217, 28);
            this.BtnCerrar.TabIndex = 23;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 377;
            // 
            // usuarioC
            // 
            this.usuarioC.HeaderText = "Usuario quien realizo cancelacion";
            this.usuarioC.Name = "usuarioC";
            this.usuarioC.Width = 377;
            // 
            // ReportesEspecificos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 609);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(lbReportesEDiv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.rbReportesDeVenta);
            this.Controls.Add(this.rbReportesDeCancelacion);
            this.Controls.Add(this.fechaReportePedido);
            this.Controls.Add(this.panelReportesEspecificos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportesEspecificos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportesEspecificos";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ReportesEspecificos_MouseDown);
            this.panelReportesEspecificos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgReportesEspecificos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelReportesEspecificos;
        private System.Windows.Forms.PictureBox imgReportesEspecificos;
        private System.Windows.Forms.DateTimePicker fechaReportePedido;
        private System.Windows.Forms.RadioButton rbReportesDeCancelacion;
        private System.Windows.Forms.RadioButton rbReportesDeVenta;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioC;
    }
}