namespace WindowsFormsApp1.Views
{
    partial class ViewTabs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTabs));
            this.tabPuntoVenta = new System.Windows.Forms.TabControl();
            this.tabVenta = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRecepcion = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabReparacion = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPuntoVenta.SuspendLayout();
            this.tabVenta.SuspendLayout();
            this.tabRecepcion.SuspendLayout();
            this.tabReparacion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPuntoVenta
            // 
            this.tabPuntoVenta.Controls.Add(this.tabVenta);
            this.tabPuntoVenta.Controls.Add(this.tabRecepcion);
            this.tabPuntoVenta.Controls.Add(this.tabReparacion);
            this.tabPuntoVenta.Controls.Add(this.tabPage1);
            this.tabPuntoVenta.Location = new System.Drawing.Point(2, 1);
            this.tabPuntoVenta.Location = new System.Drawing.Point(2, 0);
            this.tabPuntoVenta.Name = "tabPuntoVenta";
            this.tabPuntoVenta.SelectedIndex = 0;
            this.tabPuntoVenta.Size = new System.Drawing.Size(798, 451);
            this.tabPuntoVenta.TabIndex = 0;
            // 
            // tabVenta
            // 
            this.tabVenta.Controls.Add(this.label1);
            this.tabVenta.Location = new System.Drawing.Point(4, 22);
            this.tabVenta.Name = "tabVenta";
            this.tabVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabVenta.Size = new System.Drawing.Size(790, 425);
            this.tabVenta.TabIndex = 0;
            this.tabVenta.Text = "Venta";
            this.tabVenta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tab de Venta";
            // 
            // tabRecepcion
            // 
            this.tabRecepcion.Controls.Add(this.label2);
            this.tabRecepcion.Location = new System.Drawing.Point(4, 22);
            this.tabRecepcion.Name = "tabRecepcion";
            this.tabRecepcion.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecepcion.Size = new System.Drawing.Size(790, 425);
            this.tabRecepcion.TabIndex = 1;
            this.tabRecepcion.Text = "Recepción";
            this.tabRecepcion.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tab Recepcion";
            // 
            // tabReparacion
            // 
            this.tabReparacion.Controls.Add(this.label3);
            this.tabReparacion.Location = new System.Drawing.Point(4, 22);
            this.tabReparacion.Name = "tabReparacion";
            this.tabReparacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabReparacion.Size = new System.Drawing.Size(790, 425);
            this.tabReparacion.TabIndex = 2;
            this.tabReparacion.Text = "Reparación";
            this.tabReparacion.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tab Repacion";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 424);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Ordenes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.Estado,
            this.idResponsable});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(783, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // idResponsable
            // 
            this.idResponsable.HeaderText = "ID Responsable";
            this.idResponsable.Name = "idResponsable";
            // 
            // ViewTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tabPuntoVenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewTabs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UP - Software";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabPuntoVenta.ResumeLayout(false);
            this.tabVenta.ResumeLayout(false);
            this.tabVenta.PerformLayout();
            this.tabRecepcion.ResumeLayout(false);
            this.tabRecepcion.PerformLayout();
            this.tabReparacion.ResumeLayout(false);
            this.tabReparacion.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPuntoVenta;
        private System.Windows.Forms.TabPage tabVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabRecepcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabReparacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idResponsable;
    }
}