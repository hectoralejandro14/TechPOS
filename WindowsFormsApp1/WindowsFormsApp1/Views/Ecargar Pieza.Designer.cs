namespace WindowsFormsApp1.Views
{
    partial class Ecargar_Pieza
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
            this.equipoLblEncargar = new System.Windows.Forms.Label();
            this.marcaLblEncargar = new System.Windows.Forms.Label();
            this.piezaLblEncargar = new System.Windows.Forms.Label();
            this.modeloLblEncargar = new System.Windows.Forms.Label();
            this.equipoTbxEncagar = new System.Windows.Forms.TextBox();
            this.marcaTbxEncargar = new System.Windows.Forms.TextBox();
            this.modeloTbxEncargar = new System.Windows.Forms.TextBox();
            this.piezasTbxEncargar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // equipoLblEncargar
            // 
            this.equipoLblEncargar.AutoSize = true;
            this.equipoLblEncargar.Location = new System.Drawing.Point(158, 94);
            this.equipoLblEncargar.Name = "equipoLblEncargar";
            this.equipoLblEncargar.Size = new System.Drawing.Size(40, 13);
            this.equipoLblEncargar.TabIndex = 0;
            this.equipoLblEncargar.Text = "Equipo";
            // 
            // marcaLblEncargar
            // 
            this.marcaLblEncargar.AutoSize = true;
            this.marcaLblEncargar.Location = new System.Drawing.Point(161, 171);
            this.marcaLblEncargar.Name = "marcaLblEncargar";
            this.marcaLblEncargar.Size = new System.Drawing.Size(37, 13);
            this.marcaLblEncargar.TabIndex = 1;
            this.marcaLblEncargar.Text = "Marca";
            // 
            // piezaLblEncargar
            // 
            this.piezaLblEncargar.AutoSize = true;
            this.piezaLblEncargar.Location = new System.Drawing.Point(161, 265);
            this.piezaLblEncargar.Name = "piezaLblEncargar";
            this.piezaLblEncargar.Size = new System.Drawing.Size(44, 13);
            this.piezaLblEncargar.TabIndex = 2;
            this.piezaLblEncargar.Text = "Pieza(s)";
            // 
            // modeloLblEncargar
            // 
            this.modeloLblEncargar.AutoSize = true;
            this.modeloLblEncargar.Location = new System.Drawing.Point(482, 135);
            this.modeloLblEncargar.Name = "modeloLblEncargar";
            this.modeloLblEncargar.Size = new System.Drawing.Size(42, 13);
            this.modeloLblEncargar.TabIndex = 3;
            this.modeloLblEncargar.Text = "Modelo";
            // 
            // equipoTbxEncagar
            // 
            this.equipoTbxEncagar.Location = new System.Drawing.Point(204, 91);
            this.equipoTbxEncagar.Multiline = true;
            this.equipoTbxEncagar.Name = "equipoTbxEncagar";
            this.equipoTbxEncagar.Size = new System.Drawing.Size(182, 29);
            this.equipoTbxEncagar.TabIndex = 4;
            this.equipoTbxEncagar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // marcaTbxEncargar
            // 
            this.marcaTbxEncargar.Location = new System.Drawing.Point(204, 168);
            this.marcaTbxEncargar.Multiline = true;
            this.marcaTbxEncargar.Name = "marcaTbxEncargar";
            this.marcaTbxEncargar.Size = new System.Drawing.Size(182, 33);
            this.marcaTbxEncargar.TabIndex = 5;
            // 
            // modeloTbxEncargar
            // 
            this.modeloTbxEncargar.Location = new System.Drawing.Point(534, 127);
            this.modeloTbxEncargar.Multiline = true;
            this.modeloTbxEncargar.Name = "modeloTbxEncargar";
            this.modeloTbxEncargar.Size = new System.Drawing.Size(183, 28);
            this.modeloTbxEncargar.TabIndex = 6;
            // 
            // piezasTbxEncargar
            // 
            this.piezasTbxEncargar.Location = new System.Drawing.Point(161, 299);
            this.piezasTbxEncargar.Multiline = true;
            this.piezasTbxEncargar.Name = "piezasTbxEncargar";
            this.piezasTbxEncargar.Size = new System.Drawing.Size(545, 173);
            this.piezasTbxEncargar.TabIndex = 7;
            this.piezasTbxEncargar.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logoUp;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Ecargar_Pieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.piezasTbxEncargar);
            this.Controls.Add(this.modeloTbxEncargar);
            this.Controls.Add(this.marcaTbxEncargar);
            this.Controls.Add(this.equipoTbxEncagar);
            this.Controls.Add(this.modeloLblEncargar);
            this.Controls.Add(this.piezaLblEncargar);
            this.Controls.Add(this.marcaLblEncargar);
            this.Controls.Add(this.equipoLblEncargar);
            this.Name = "Ecargar_Pieza";
            this.Text = "Ecargar_Pieza";
            this.Load += new System.EventHandler(this.Ecargar_Pieza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label equipoLblEncargar;
        private System.Windows.Forms.Label marcaLblEncargar;
        private System.Windows.Forms.Label piezaLblEncargar;
        private System.Windows.Forms.Label modeloLblEncargar;
        private System.Windows.Forms.TextBox equipoTbxEncagar;
        private System.Windows.Forms.TextBox marcaTbxEncargar;
        private System.Windows.Forms.TextBox modeloTbxEncargar;
        private System.Windows.Forms.TextBox piezasTbxEncargar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}