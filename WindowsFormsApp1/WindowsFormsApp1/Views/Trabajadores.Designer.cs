namespace WindowsFormsApp1.Views
{
    partial class Trabajadores
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.labelTrabajador = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.todo = new System.Windows.Forms.RadioButton();
            this.dataTrabajadores = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboTrabajador = new System.Windows.Forms.ComboBox();
            this.dateTiempo = new System.Windows.Forms.DateTimePicker();
            this.btncerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTrabajadores)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::WindowsFormsApp1.Properties.Resources.logoUp;
            this.picLogo.Location = new System.Drawing.Point(-1, -1);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(68, 106);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelTrabajador
            // 
            this.labelTrabajador.AutoSize = true;
            this.labelTrabajador.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.labelTrabajador.Location = new System.Drawing.Point(204, 43);
            this.labelTrabajador.Name = "labelTrabajador";
            this.labelTrabajador.Size = new System.Drawing.Size(106, 34);
            this.labelTrabajador.TabIndex = 1;
            this.labelTrabajador.Text = "Trabajador:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.labelFecha.Location = new System.Drawing.Point(216, 121);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(70, 34);
            this.labelFecha.TabIndex = 2;
            this.labelFecha.Text = "Fecha:";
            // 
            // todo
            // 
            this.todo.AutoSize = true;
            this.todo.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.todo.Location = new System.Drawing.Point(247, 167);
            this.todo.Name = "todo";
            this.todo.Size = new System.Drawing.Size(73, 38);
            this.todo.TabIndex = 4;
            this.todo.TabStop = true;
            this.todo.Text = "Todo";
            this.todo.UseVisualStyleBackColor = true;
            // 
            // dataTrabajadores
            // 
            this.dataTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTrabajadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataTrabajadores.Location = new System.Drawing.Point(153, 211);
            this.dataTrabajadores.Name = "dataTrabajadores";
            this.dataTrabajadores.Size = new System.Drawing.Size(466, 196);
            this.dataTrabajadores.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            this.Column1.Width = 210;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Trabajo";
            this.Column2.Name = "Column2";
            this.Column2.Width = 210;
            // 
            // comboTrabajador
            // 
            this.comboTrabajador.FormattingEnabled = true;
            this.comboTrabajador.Location = new System.Drawing.Point(307, 51);
            this.comboTrabajador.Name = "comboTrabajador";
            this.comboTrabajador.Size = new System.Drawing.Size(200, 21);
            this.comboTrabajador.TabIndex = 6;
            // 
            // dateTiempo
            // 
            this.dateTiempo.Font = new System.Drawing.Font("Cordia New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTiempo.Location = new System.Drawing.Point(307, 121);
            this.dateTiempo.Name = "dateTiempo";
            this.dateTiempo.Size = new System.Drawing.Size(200, 30);
            this.dateTiempo.TabIndex = 7;
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.DimGray;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncerrar.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.btncerrar.ForeColor = System.Drawing.Color.Turquoise;
            this.btncerrar.Location = new System.Drawing.Point(489, 424);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(90, 39);
            this.btncerrar.TabIndex = 8;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = false;
            // 
            // Trabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(713, 475);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.dateTiempo);
            this.Controls.Add(this.comboTrabajador);
            this.Controls.Add(this.dataTrabajadores);
            this.Controls.Add(this.todo);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelTrabajador);
            this.Controls.Add(this.picLogo);
            this.Name = "Trabajadores";
            this.Text = "Trabajadores";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTrabajadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label labelTrabajador;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.RadioButton todo;
        private System.Windows.Forms.DataGridView dataTrabajadores;
        private System.Windows.Forms.ComboBox comboTrabajador;
        private System.Windows.Forms.DateTimePicker dateTiempo;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}