namespace WindowsFormsApp1
{
    partial class ViewLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLogin));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.SpanelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SlLInUser = new System.Windows.Forms.LinkLabel();
            this.SlLInContraseña = new System.Windows.Forms.LinkLabel();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.SlbTituloLogin = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SlLOlvidasteContasena = new System.Windows.Forms.LinkLabel();
            this.btnMinimizarAplicacion = new System.Windows.Forms.PictureBox();
            this.btnCerrarAplicacion = new System.Windows.Forms.PictureBox();
            this.SlLNuevoUsuarioL = new System.Windows.Forms.LinkLabel();
            this.SpanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarAplicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarAplicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtUsuario.HideSelection = false;
            this.txtUsuario.Location = new System.Drawing.Point(296, 59);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(454, 19);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // SpanelLogo
            // 
            this.SpanelLogo.BackColor = System.Drawing.Color.DimGray;
            this.SpanelLogo.Controls.Add(this.pictureBox1);
            this.SpanelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.SpanelLogo.Location = new System.Drawing.Point(0, 0);
            this.SpanelLogo.Name = "SpanelLogo";
            this.SpanelLogo.Size = new System.Drawing.Size(250, 330);
            this.SpanelLogo.TabIndex = 12;
            this.SpanelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SpanelLogo_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logoUp;
            this.pictureBox1.Location = new System.Drawing.Point(40, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // SlLInUser
            // 
            this.SlLInUser.AutoSize = true;
            this.SlLInUser.LinkColor = System.Drawing.Color.DimGray;
            this.SlLInUser.Location = new System.Drawing.Point(293, 88);
            this.SlLInUser.Name = "SlLInUser";
            this.SlLInUser.Size = new System.Drawing.Size(457, 13);
            this.SlLInUser.TabIndex = 13;
            this.SlLInUser.TabStop = true;
            this.SlLInUser.Text = "___________________________________________________________________________";
            // 
            // SlLInContraseña
            // 
            this.SlLInContraseña.AutoSize = true;
            this.SlLInContraseña.LinkColor = System.Drawing.Color.DimGray;
            this.SlLInContraseña.Location = new System.Drawing.Point(293, 154);
            this.SlLInContraseña.Name = "SlLInContraseña";
            this.SlLInContraseña.Size = new System.Drawing.Size(457, 13);
            this.SlLInContraseña.TabIndex = 14;
            this.SlLInContraseña.TabStop = true;
            this.SlLInContraseña.Text = "___________________________________________________________________________";
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtContrasena.HideSelection = false;
            this.txtContrasena.Location = new System.Drawing.Point(296, 132);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(454, 19);
            this.txtContrasena.TabIndex = 2;
            this.txtContrasena.Text = "CONTRASEÑA";
            this.txtContrasena.Enter += new System.EventHandler(this.txtContrasena_Enter);
            this.txtContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContrasena_KeyPress_1);
            this.txtContrasena.Leave += new System.EventHandler(this.txtContrasena_Leave);
            // 
            // SlbTituloLogin
            // 
            this.SlbTituloLogin.AutoSize = true;
            this.SlbTituloLogin.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlbTituloLogin.ForeColor = System.Drawing.Color.DarkOrange;
            this.SlbTituloLogin.Location = new System.Drawing.Point(473, 9);
            this.SlbTituloLogin.Name = "SlbTituloLogin";
            this.SlbTituloLogin.Size = new System.Drawing.Size(81, 32);
            this.SlbTituloLogin.TabIndex = 16;
            this.SlbTituloLogin.Text = "Login";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAceptar.Location = new System.Drawing.Point(296, 200);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(454, 40);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Acceder";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // SlLOlvidasteContasena
            // 
            this.SlLOlvidasteContasena.ActiveLinkColor = System.Drawing.Color.Orange;
            this.SlLOlvidasteContasena.AutoSize = true;
            this.SlLOlvidasteContasena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlLOlvidasteContasena.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlLOlvidasteContasena.LinkColor = System.Drawing.Color.DimGray;
            this.SlLOlvidasteContasena.Location = new System.Drawing.Point(432, 260);
            this.SlLOlvidasteContasena.Name = "SlLOlvidasteContasena";
            this.SlLOlvidasteContasena.Size = new System.Drawing.Size(179, 17);
            this.SlLOlvidasteContasena.TabIndex = 0;
            this.SlLOlvidasteContasena.TabStop = true;
            this.SlLOlvidasteContasena.Text = "¿Olvidaste tu contraseña?";
            this.SlLOlvidasteContasena.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SlLOlvidasteContasena_LinkClicked);
            // 
            // btnMinimizarAplicacion
            // 
            this.btnMinimizarAplicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarAplicacion.Image = global::WindowsFormsApp1.Properties.Resources.minimazar;
            this.btnMinimizarAplicacion.Location = new System.Drawing.Point(741, 0);
            this.btnMinimizarAplicacion.Name = "btnMinimizarAplicacion";
            this.btnMinimizarAplicacion.Size = new System.Drawing.Size(15, 15);
            this.btnMinimizarAplicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizarAplicacion.TabIndex = 20;
            this.btnMinimizarAplicacion.TabStop = false;
            this.btnMinimizarAplicacion.Click += new System.EventHandler(this.btnMinimizarAplicacion_Click);
            // 
            // btnCerrarAplicacion
            // 
            this.btnCerrarAplicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarAplicacion.Image = global::WindowsFormsApp1.Properties.Resources.cerrar;
            this.btnCerrarAplicacion.Location = new System.Drawing.Point(762, 0);
            this.btnCerrarAplicacion.Name = "btnCerrarAplicacion";
            this.btnCerrarAplicacion.Size = new System.Drawing.Size(15, 15);
            this.btnCerrarAplicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarAplicacion.TabIndex = 19;
            this.btnCerrarAplicacion.TabStop = false;
            this.btnCerrarAplicacion.Click += new System.EventHandler(this.btnCerrarAplicacion_Click);
            // 
            // SlLNuevoUsuarioL
            // 
            this.SlLNuevoUsuarioL.ActiveLinkColor = System.Drawing.Color.Orange;
            this.SlLNuevoUsuarioL.AutoSize = true;
            this.SlLNuevoUsuarioL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlLNuevoUsuarioL.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlLNuevoUsuarioL.LinkColor = System.Drawing.Color.DimGray;
            this.SlLNuevoUsuarioL.Location = new System.Drawing.Point(476, 289);
            this.SlLNuevoUsuarioL.Name = "SlLNuevoUsuarioL";
            this.SlLNuevoUsuarioL.Size = new System.Drawing.Size(103, 17);
            this.SlLNuevoUsuarioL.TabIndex = 21;
            this.SlLNuevoUsuarioL.TabStop = true;
            this.SlLNuevoUsuarioL.Text = "Nuevo Usuario";
            this.SlLNuevoUsuarioL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SlLNuevoUsuarioL_LinkClicked);
            // 
            // ViewLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.SlLNuevoUsuarioL);
            this.Controls.Add(this.btnMinimizarAplicacion);
            this.Controls.Add(this.btnCerrarAplicacion);
            this.Controls.Add(this.SlLOlvidasteContasena);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.SlbTituloLogin);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.SlLInContraseña);
            this.Controls.Add(this.SlLInUser);
            this.Controls.Add(this.SpanelLogo);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UP - Software : Soluciones de TI";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ViewLogin_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewLogin_MouseDown);
            this.SpanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarAplicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarAplicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SpanelLogo;
        private System.Windows.Forms.LinkLabel SlLInUser;
        private System.Windows.Forms.LinkLabel SlLInContraseña;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label SlbTituloLogin;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.LinkLabel SlLOlvidasteContasena;
        private System.Windows.Forms.PictureBox btnCerrarAplicacion;
        private System.Windows.Forms.PictureBox btnMinimizarAplicacion;
        private System.Windows.Forms.LinkLabel SlLNuevoUsuarioL;
    }
}

