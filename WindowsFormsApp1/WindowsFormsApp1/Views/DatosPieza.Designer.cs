namespace WindowsFormsApp1.Views
{
    partial class DatosPieza
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
            this.PBoxPieza = new System.Windows.Forms.PictureBox();
            this.txtDescPieza = new System.Windows.Forms.TextBox();
            this.lblDescPieza = new System.Windows.Forms.Label();
            this.lblEstadoPieza = new System.Windows.Forms.Label();
            this.lblFPedPieza = new System.Windows.Forms.Label();
            this.lblFLlegPieza = new System.Windows.Forms.Label();
            this.txtFechaPPieza = new System.Windows.Forms.TextBox();
            this.txtFechaLPieza = new System.Windows.Forms.TextBox();
            this.cBoxEstadosPieza = new System.Windows.Forms.ComboBox();
            this.BtnAceptarPieza = new System.Windows.Forms.Button();
            this.btnCancelarPieza = new System.Windows.Forms.Button();
            this.btnModifcarPieza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxPieza)).BeginInit();
            this.SuspendLayout();
            // 
            // PBoxPieza
            // 
            this.PBoxPieza.Image = global::WindowsFormsApp1.Properties.Resources.logoUp;
            this.PBoxPieza.Location = new System.Drawing.Point(12, 12);
            this.PBoxPieza.Name = "PBoxPieza";
            this.PBoxPieza.Size = new System.Drawing.Size(56, 86);
            this.PBoxPieza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxPieza.TabIndex = 5;
            this.PBoxPieza.TabStop = false;
            // 
            // txtDescPieza
            // 
            this.txtDescPieza.Enabled = false;
            this.txtDescPieza.Location = new System.Drawing.Point(185, 49);
            this.txtDescPieza.Multiline = true;
            this.txtDescPieza.Name = "txtDescPieza";
            this.txtDescPieza.Size = new System.Drawing.Size(247, 78);
            this.txtDescPieza.TabIndex = 7;
            // 
            // lblDescPieza
            // 
            this.lblDescPieza.AutoSize = true;
            this.lblDescPieza.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescPieza.Location = new System.Drawing.Point(179, 12);
            this.lblDescPieza.Name = "lblDescPieza";
            this.lblDescPieza.Size = new System.Drawing.Size(115, 34);
            this.lblDescPieza.TabIndex = 6;
            this.lblDescPieza.Text = "Descripcion:";
            // 
            // lblEstadoPieza
            // 
            this.lblEstadoPieza.AutoSize = true;
            this.lblEstadoPieza.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoPieza.Location = new System.Drawing.Point(179, 155);
            this.lblEstadoPieza.Name = "lblEstadoPieza";
            this.lblEstadoPieza.Size = new System.Drawing.Size(148, 34);
            this.lblEstadoPieza.TabIndex = 8;
            this.lblEstadoPieza.Text = "Estado de pieza:";
            // 
            // lblFPedPieza
            // 
            this.lblFPedPieza.AutoSize = true;
            this.lblFPedPieza.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFPedPieza.Location = new System.Drawing.Point(36, 239);
            this.lblFPedPieza.Name = "lblFPedPieza";
            this.lblFPedPieza.Size = new System.Drawing.Size(154, 34);
            this.lblFPedPieza.TabIndex = 10;
            this.lblFPedPieza.Text = "Fecha de pedido:";
            // 
            // lblFLlegPieza
            // 
            this.lblFLlegPieza.AutoSize = true;
            this.lblFLlegPieza.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFLlegPieza.Location = new System.Drawing.Point(302, 239);
            this.lblFLlegPieza.Name = "lblFLlegPieza";
            this.lblFLlegPieza.Size = new System.Drawing.Size(164, 34);
            this.lblFLlegPieza.TabIndex = 11;
            this.lblFLlegPieza.Text = "Fecha de Llegada:";
            // 
            // txtFechaPPieza
            // 
            this.txtFechaPPieza.Enabled = false;
            this.txtFechaPPieza.Location = new System.Drawing.Point(12, 287);
            this.txtFechaPPieza.Name = "txtFechaPPieza";
            this.txtFechaPPieza.Size = new System.Drawing.Size(203, 20);
            this.txtFechaPPieza.TabIndex = 12;
            // 
            // txtFechaLPieza
            // 
            this.txtFechaLPieza.Enabled = false;
            this.txtFechaLPieza.Location = new System.Drawing.Point(279, 287);
            this.txtFechaLPieza.Name = "txtFechaLPieza";
            this.txtFechaLPieza.Size = new System.Drawing.Size(203, 20);
            this.txtFechaLPieza.TabIndex = 13;
            // 
            // cBoxEstadosPieza
            // 
            this.cBoxEstadosPieza.Enabled = false;
            this.cBoxEstadosPieza.FormattingEnabled = true;
            this.cBoxEstadosPieza.Items.AddRange(new object[] {
            "Ordenada",
            "Recibida"});
            this.cBoxEstadosPieza.Location = new System.Drawing.Point(185, 192);
            this.cBoxEstadosPieza.Name = "cBoxEstadosPieza";
            this.cBoxEstadosPieza.Size = new System.Drawing.Size(247, 21);
            this.cBoxEstadosPieza.TabIndex = 14;
            // 
            // BtnAceptarPieza
            // 
            this.BtnAceptarPieza.BackColor = System.Drawing.Color.DimGray;
            this.BtnAceptarPieza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAceptarPieza.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptarPieza.ForeColor = System.Drawing.Color.White;
            this.BtnAceptarPieza.Location = new System.Drawing.Point(69, 370);
            this.BtnAceptarPieza.Name = "BtnAceptarPieza";
            this.BtnAceptarPieza.Size = new System.Drawing.Size(80, 37);
            this.BtnAceptarPieza.TabIndex = 15;
            this.BtnAceptarPieza.Text = "Aceptar";
            this.BtnAceptarPieza.UseVisualStyleBackColor = false;
            this.BtnAceptarPieza.Click += new System.EventHandler(this.BtnAceptarPieza_Click);
            // 
            // btnCancelarPieza
            // 
            this.btnCancelarPieza.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelarPieza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarPieza.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPieza.ForeColor = System.Drawing.Color.White;
            this.btnCancelarPieza.Location = new System.Drawing.Point(340, 370);
            this.btnCancelarPieza.Name = "btnCancelarPieza";
            this.btnCancelarPieza.Size = new System.Drawing.Size(83, 37);
            this.btnCancelarPieza.TabIndex = 16;
            this.btnCancelarPieza.Text = "Cancelar";
            this.btnCancelarPieza.UseVisualStyleBackColor = false;
            this.btnCancelarPieza.Visible = false;
            this.btnCancelarPieza.Click += new System.EventHandler(this.btnCancelarPieza_Click);
            // 
            // btnModifcarPieza
            // 
            this.btnModifcarPieza.BackColor = System.Drawing.Color.DimGray;
            this.btnModifcarPieza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifcarPieza.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifcarPieza.ForeColor = System.Drawing.Color.White;
            this.btnModifcarPieza.Location = new System.Drawing.Point(204, 370);
            this.btnModifcarPieza.Name = "btnModifcarPieza";
            this.btnModifcarPieza.Size = new System.Drawing.Size(80, 37);
            this.btnModifcarPieza.TabIndex = 17;
            this.btnModifcarPieza.Text = "Modificar";
            this.btnModifcarPieza.UseVisualStyleBackColor = false;
            this.btnModifcarPieza.Click += new System.EventHandler(this.btnModifcarPieza_Click);
            // 
            // DatosPieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.btnModifcarPieza);
            this.Controls.Add(this.btnCancelarPieza);
            this.Controls.Add(this.BtnAceptarPieza);
            this.Controls.Add(this.cBoxEstadosPieza);
            this.Controls.Add(this.txtFechaLPieza);
            this.Controls.Add(this.txtFechaPPieza);
            this.Controls.Add(this.lblFLlegPieza);
            this.Controls.Add(this.lblFPedPieza);
            this.Controls.Add(this.lblEstadoPieza);
            this.Controls.Add(this.txtDescPieza);
            this.Controls.Add(this.lblDescPieza);
            this.Controls.Add(this.PBoxPieza);
            this.Name = "DatosPieza";
            this.Text = "DatosPieza";
            ((System.ComponentModel.ISupportInitialize)(this.PBoxPieza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBoxPieza;
        private System.Windows.Forms.TextBox txtDescPieza;
        private System.Windows.Forms.Label lblDescPieza;
        private System.Windows.Forms.Label lblEstadoPieza;
        private System.Windows.Forms.Label lblFPedPieza;
        private System.Windows.Forms.Label lblFLlegPieza;
        private System.Windows.Forms.TextBox txtFechaPPieza;
        private System.Windows.Forms.TextBox txtFechaLPieza;
        private System.Windows.Forms.ComboBox cBoxEstadosPieza;
        private System.Windows.Forms.Button BtnAceptarPieza;
        private System.Windows.Forms.Button btnCancelarPieza;
        private System.Windows.Forms.Button btnModifcarPieza;
    }
}