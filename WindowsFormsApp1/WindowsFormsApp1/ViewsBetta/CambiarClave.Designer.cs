namespace WindowsFormsApp1.ViewsBetta
{
    partial class CambiarClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarClave));
            this.PanelRecuperarClave = new System.Windows.Forms.Panel();
            this.ImgCC = new System.Windows.Forms.PictureBox();
            this.lblCorreoCC = new System.Windows.Forms.LinkLabel();
            this.txtCorreoCC = new System.Windows.Forms.TextBox();
            this.SlbTituloLoginCC = new System.Windows.Forms.Label();
            this.btnAceptarCC = new System.Windows.Forms.Button();
            this.btnVolverCC = new System.Windows.Forms.Button();
            this.CCtxtPinSeguridad = new System.Windows.Forms.TextBox();
            this.CCbtnAceptarPinSeguridad = new System.Windows.Forms.Button();
            this.lblPinSeguridadCC = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PanelRecuperarClave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCC)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelRecuperarClave
            // 
            this.PanelRecuperarClave.BackColor = System.Drawing.Color.DimGray;
            this.PanelRecuperarClave.Controls.Add(this.ImgCC);
            this.PanelRecuperarClave.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelRecuperarClave.Location = new System.Drawing.Point(0, 0);
            this.PanelRecuperarClave.Name = "PanelRecuperarClave";
            this.PanelRecuperarClave.Size = new System.Drawing.Size(250, 330);
            this.PanelRecuperarClave.TabIndex = 0;
            // 
            // ImgCC
            // 
            this.ImgCC.Image = global::WindowsFormsApp1.Properties.Resources.logoUp;
            this.ImgCC.Location = new System.Drawing.Point(45, 43);
            this.ImgCC.Name = "ImgCC";
            this.ImgCC.Size = new System.Drawing.Size(161, 245);
            this.ImgCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgCC.TabIndex = 12;
            this.ImgCC.TabStop = false;
            this.ImgCC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImgCC_MouseDown);
            // 
            // lblCorreoCC
            // 
            this.lblCorreoCC.AutoSize = true;
            this.lblCorreoCC.LinkColor = System.Drawing.Color.DimGray;
            this.lblCorreoCC.Location = new System.Drawing.Point(294, 89);
            this.lblCorreoCC.Name = "lblCorreoCC";
            this.lblCorreoCC.Size = new System.Drawing.Size(457, 13);
            this.lblCorreoCC.TabIndex = 15;
            this.lblCorreoCC.TabStop = true;
            this.lblCorreoCC.Text = "___________________________________________________________________________";
            // 
            // txtCorreoCC
            // 
            this.txtCorreoCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtCorreoCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreoCC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoCC.ForeColor = System.Drawing.Color.DimGray;
            this.txtCorreoCC.Location = new System.Drawing.Point(297, 66);
            this.txtCorreoCC.Name = "txtCorreoCC";
            this.txtCorreoCC.Size = new System.Drawing.Size(454, 19);
            this.txtCorreoCC.TabIndex = 16;
            this.txtCorreoCC.Text = "Ingrese su correo";
            this.txtCorreoCC.Enter += new System.EventHandler(this.txtCorreoCC_Enter);
            this.txtCorreoCC.Leave += new System.EventHandler(this.txtCorreoCC_Leave);
            // 
            // SlbTituloLoginCC
            // 
            this.SlbTituloLoginCC.AutoSize = true;
            this.SlbTituloLoginCC.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlbTituloLoginCC.ForeColor = System.Drawing.Color.DimGray;
            this.SlbTituloLoginCC.Location = new System.Drawing.Point(422, 9);
            this.SlbTituloLoginCC.Name = "SlbTituloLoginCC";
            this.SlbTituloLoginCC.Size = new System.Drawing.Size(194, 32);
            this.SlbTituloLoginCC.TabIndex = 17;
            this.SlbTituloLoginCC.Text = "Cambiar Clave";
            // 
            // btnAceptarCC
            // 
            this.btnAceptarCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAceptarCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarCC.FlatAppearance.BorderSize = 0;
            this.btnAceptarCC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAceptarCC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptarCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarCC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarCC.ForeColor = System.Drawing.Color.Orange;
            this.btnAceptarCC.Location = new System.Drawing.Point(297, 117);
            this.btnAceptarCC.Name = "btnAceptarCC";
            this.btnAceptarCC.Size = new System.Drawing.Size(454, 40);
            this.btnAceptarCC.TabIndex = 18;
            this.btnAceptarCC.Text = "Buscar Correo";
            this.btnAceptarCC.UseVisualStyleBackColor = false;
            this.btnAceptarCC.Click += new System.EventHandler(this.btnAceptarCC_Click);
            // 
            // btnVolverCC
            // 
            this.btnVolverCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnVolverCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverCC.FlatAppearance.BorderSize = 0;
            this.btnVolverCC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnVolverCC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolverCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverCC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverCC.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnVolverCC.Location = new System.Drawing.Point(669, 287);
            this.btnVolverCC.Name = "btnVolverCC";
            this.btnVolverCC.Size = new System.Drawing.Size(82, 31);
            this.btnVolverCC.TabIndex = 20;
            this.btnVolverCC.Text = "Volver";
            this.btnVolverCC.UseVisualStyleBackColor = false;
            this.btnVolverCC.Click += new System.EventHandler(this.btnVolverCC_Click);
            // 
            // CCtxtPinSeguridad
            // 
            this.CCtxtPinSeguridad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CCtxtPinSeguridad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CCtxtPinSeguridad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCtxtPinSeguridad.ForeColor = System.Drawing.Color.DarkOrange;
            this.CCtxtPinSeguridad.Location = new System.Drawing.Point(297, 67);
            this.CCtxtPinSeguridad.Name = "CCtxtPinSeguridad";
            this.CCtxtPinSeguridad.Size = new System.Drawing.Size(454, 19);
            this.CCtxtPinSeguridad.TabIndex = 21;
            this.CCtxtPinSeguridad.Text = "Ingrese PIN  de Seguridad";
            // 
            // CCbtnAceptarPinSeguridad
            // 
            this.CCbtnAceptarPinSeguridad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CCbtnAceptarPinSeguridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CCbtnAceptarPinSeguridad.FlatAppearance.BorderSize = 0;
            this.CCbtnAceptarPinSeguridad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CCbtnAceptarPinSeguridad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CCbtnAceptarPinSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CCbtnAceptarPinSeguridad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCbtnAceptarPinSeguridad.ForeColor = System.Drawing.Color.Orange;
            this.CCbtnAceptarPinSeguridad.Location = new System.Drawing.Point(297, 117);
            this.CCbtnAceptarPinSeguridad.Name = "CCbtnAceptarPinSeguridad";
            this.CCbtnAceptarPinSeguridad.Size = new System.Drawing.Size(454, 40);
            this.CCbtnAceptarPinSeguridad.TabIndex = 22;
            this.CCbtnAceptarPinSeguridad.Text = "Verificar PIN";
            this.CCbtnAceptarPinSeguridad.UseVisualStyleBackColor = false;
            this.CCbtnAceptarPinSeguridad.Click += new System.EventHandler(this.CCbtnAceptarPinSeguridad_Click);
            // 
            // lblPinSeguridadCC
            // 
            this.lblPinSeguridadCC.AutoSize = true;
            this.lblPinSeguridadCC.LinkColor = System.Drawing.Color.DimGray;
            this.lblPinSeguridadCC.Location = new System.Drawing.Point(294, 89);
            this.lblPinSeguridadCC.Name = "lblPinSeguridadCC";
            this.lblPinSeguridadCC.Size = new System.Drawing.Size(457, 13);
            this.lblPinSeguridadCC.TabIndex = 23;
            this.lblPinSeguridadCC.TabStop = true;
            this.lblPinSeguridadCC.Text = "___________________________________________________________________________";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(297, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 13);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "Solo funcional en @gmail.com";
            // 
            // CambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPinSeguridadCC);
            this.Controls.Add(this.CCbtnAceptarPinSeguridad);
            this.Controls.Add(this.CCtxtPinSeguridad);
            this.Controls.Add(this.btnVolverCC);
            this.Controls.Add(this.btnAceptarCC);
            this.Controls.Add(this.SlbTituloLoginCC);
            this.Controls.Add(this.txtCorreoCC);
            this.Controls.Add(this.lblCorreoCC);
            this.Controls.Add(this.PanelRecuperarClave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CambiarClave";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambiarClave";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CambiarClave_MouseDown);
            this.PanelRecuperarClave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelRecuperarClave;
        private System.Windows.Forms.LinkLabel lblCorreoCC;
        private System.Windows.Forms.TextBox txtCorreoCC;
        private System.Windows.Forms.Label SlbTituloLoginCC;
        private System.Windows.Forms.PictureBox ImgCC;
        private System.Windows.Forms.Button btnAceptarCC;
        private System.Windows.Forms.Button btnVolverCC;
        private System.Windows.Forms.TextBox CCtxtPinSeguridad;
        private System.Windows.Forms.Button CCbtnAceptarPinSeguridad;
        private System.Windows.Forms.LinkLabel lblPinSeguridadCC;
        private System.Windows.Forms.TextBox textBox1;
    }
}