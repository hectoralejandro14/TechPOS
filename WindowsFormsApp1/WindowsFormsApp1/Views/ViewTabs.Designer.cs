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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTabs));
            this.tabPuntoVenta = new System.Windows.Forms.TabControl();
            this.tabVenta = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRecepcion = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabReparacion = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.tabPuntoVenta.SuspendLayout();
            this.tabVenta.SuspendLayout();
            this.tabRecepcion.SuspendLayout();
            this.tabReparacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPuntoVenta
            // 
            this.tabPuntoVenta.Controls.Add(this.tabVenta);
            this.tabPuntoVenta.Controls.Add(this.tabRecepcion);
            this.tabPuntoVenta.Controls.Add(this.tabReparacion);
            this.tabPuntoVenta.Location = new System.Drawing.Point(2, 1);
            this.tabPuntoVenta.Name = "tabPuntoVenta";
            this.tabPuntoVenta.SelectedIndex = 0;
            this.tabPuntoVenta.Size = new System.Drawing.Size(628, 525);
            this.tabPuntoVenta.TabIndex = 0;
            // 
            // tabVenta
            // 
            this.tabVenta.Controls.Add(this.label1);
            this.tabVenta.Location = new System.Drawing.Point(4, 22);
            this.tabVenta.Name = "tabVenta";
            this.tabVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabVenta.Size = new System.Drawing.Size(620, 499);
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
            this.tabRecepcion.Size = new System.Drawing.Size(620, 499);
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
            this.tabReparacion.Controls.Add(this.radioButton3);
            this.tabReparacion.Controls.Add(this.radioButton2);
            this.tabReparacion.Controls.Add(this.radioButton1);
            this.tabReparacion.Controls.Add(this.label6);
            this.tabReparacion.Controls.Add(this.label5);
            this.tabReparacion.Controls.Add(this.label3);
            this.tabReparacion.Controls.Add(this.pictureBox1);
            this.tabReparacion.Controls.Add(this.dataGridView1);
            this.tabReparacion.Controls.Add(this.label4);
            this.tabReparacion.Controls.Add(this.textBox1);
            this.tabReparacion.Location = new System.Drawing.Point(4, 22);
            this.tabReparacion.Name = "tabReparacion";
            this.tabReparacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabReparacion.Size = new System.Drawing.Size(620, 499);
            this.tabReparacion.TabIndex = 2;
            this.tabReparacion.Text = "Reparación";
            this.tabReparacion.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Buscar:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(15, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 217);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Marca";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Modelo";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cliente";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Estado";
            this.Column5.Name = "Column5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(436, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pendientes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Terminado";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(82, 158);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Todos";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(247, 157);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(413, 158);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // ViewTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 523);
            this.Controls.Add(this.tabPuntoVenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewTabs";
            this.Text = "UP - Software";
            this.tabPuntoVenta.ResumeLayout(false);
            this.tabVenta.ResumeLayout(false);
            this.tabVenta.PerformLayout();
            this.tabRecepcion.ResumeLayout(false);
            this.tabRecepcion.PerformLayout();
            this.tabReparacion.ResumeLayout(false);
            this.tabReparacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPuntoVenta;
        private System.Windows.Forms.TabPage tabVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabRecepcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabReparacion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
    }
}