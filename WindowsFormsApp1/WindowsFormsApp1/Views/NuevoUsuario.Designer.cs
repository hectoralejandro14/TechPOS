namespace WindowsFormsApp1.Views
{
    partial class NuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoUsuario));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.CtxtNombreU = new System.Windows.Forms.TextBox();
            this.CtxtApellidoU = new System.Windows.Forms.TextBox();
            this.CtxtTelefonoU = new System.Windows.Forms.TextBox();
            this.btnAceptarr = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SlblNombreDeUsuario = new System.Windows.Forms.Label();
            this.CtxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.CpictureNuevoUsuario = new System.Windows.Forms.PictureBox();
            this.SlblCorreo = new System.Windows.Forms.Label();
            this.CtxtCorreoU = new System.Windows.Forms.TextBox();
            this.ClblContrasenaU = new System.Windows.Forms.Label();
            this.CtxtContrasenaU = new System.Windows.Forms.TextBox();
            this.ClblConfirmarContrasenaU = new System.Windows.Forms.Label();
            this.CtxtConfirmarContrasenaU = new System.Windows.Forms.TextBox();
            this.ClblNotaNU = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CpictureNuevoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(216, 18);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(177, 34);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Nuevo Usuario";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(131, 103);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(91, 34);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre/s";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.lblApellido.Location = new System.Drawing.Point(131, 153);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(92, 34);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido/s";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.Location = new System.Drawing.Point(131, 213);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(84, 34);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Teléfono";
            // 
            // CtxtNombreU
            // 
            this.CtxtNombreU.Location = new System.Drawing.Point(137, 130);
            this.CtxtNombreU.Name = "CtxtNombreU";
            this.CtxtNombreU.Size = new System.Drawing.Size(351, 20);
            this.CtxtNombreU.TabIndex = 5;
            // 
            // CtxtApellidoU
            // 
            this.CtxtApellidoU.Location = new System.Drawing.Point(137, 190);
            this.CtxtApellidoU.Name = "CtxtApellidoU";
            this.CtxtApellidoU.Size = new System.Drawing.Size(351, 20);
            this.CtxtApellidoU.TabIndex = 6;
            // 
            // CtxtTelefonoU
            // 
            this.CtxtTelefonoU.Location = new System.Drawing.Point(137, 241);
            this.CtxtTelefonoU.Name = "CtxtTelefonoU";
            this.CtxtTelefonoU.Size = new System.Drawing.Size(351, 20);
            this.CtxtTelefonoU.TabIndex = 7;
            this.CtxtTelefonoU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CtxtTelefonoU_KeyPress);
            // 
            // btnAceptarr
            // 
            this.btnAceptarr.BackColor = System.Drawing.Color.DimGray;
            this.btnAceptarr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptarr.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.btnAceptarr.ForeColor = System.Drawing.Color.Turquoise;
            this.btnAceptarr.Location = new System.Drawing.Point(237, 478);
            this.btnAceptarr.Name = "btnAceptarr";
            this.btnAceptarr.Size = new System.Drawing.Size(93, 39);
            this.btnAceptarr.TabIndex = 9;
            this.btnAceptarr.Text = "Aceptar";
            this.btnAceptarr.UseVisualStyleBackColor = false;
            this.btnAceptarr.Click += new System.EventHandler(this.btnAceptarr_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.Turquoise;
            this.btnCancelar.Location = new System.Drawing.Point(120, 478);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 39);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // SlblNombreDeUsuario
            // 
            this.SlblNombreDeUsuario.AutoSize = true;
            this.SlblNombreDeUsuario.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.SlblNombreDeUsuario.Location = new System.Drawing.Point(131, 52);
            this.SlblNombreDeUsuario.Name = "SlblNombreDeUsuario";
            this.SlblNombreDeUsuario.Size = new System.Drawing.Size(168, 34);
            this.SlblNombreDeUsuario.TabIndex = 11;
            this.SlblNombreDeUsuario.Text = "Nombre de Usuario";
            // 
            // CtxtNombreUsuario
            // 
            this.CtxtNombreUsuario.Location = new System.Drawing.Point(137, 80);
            this.CtxtNombreUsuario.Name = "CtxtNombreUsuario";
            this.CtxtNombreUsuario.Size = new System.Drawing.Size(351, 20);
            this.CtxtNombreUsuario.TabIndex = 12;
            // 
            // CpictureNuevoUsuario
            // 
            this.CpictureNuevoUsuario.Image = global::WindowsFormsApp1.Properties.Resources.logoUp;
            this.CpictureNuevoUsuario.Location = new System.Drawing.Point(7, 6);
            this.CpictureNuevoUsuario.Name = "CpictureNuevoUsuario";
            this.CpictureNuevoUsuario.Size = new System.Drawing.Size(118, 177);
            this.CpictureNuevoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CpictureNuevoUsuario.TabIndex = 13;
            this.CpictureNuevoUsuario.TabStop = false;
            // 
            // SlblCorreo
            // 
            this.SlblCorreo.AutoSize = true;
            this.SlblCorreo.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.SlblCorreo.Location = new System.Drawing.Point(131, 264);
            this.SlblCorreo.Name = "SlblCorreo";
            this.SlblCorreo.Size = new System.Drawing.Size(69, 34);
            this.SlblCorreo.TabIndex = 14;
            this.SlblCorreo.Text = "Correo";
            // 
            // CtxtCorreoU
            // 
            this.CtxtCorreoU.Location = new System.Drawing.Point(137, 301);
            this.CtxtCorreoU.Name = "CtxtCorreoU";
            this.CtxtCorreoU.Size = new System.Drawing.Size(351, 20);
            this.CtxtCorreoU.TabIndex = 15;
            // 
            // ClblContrasenaU
            // 
            this.ClblContrasenaU.AutoSize = true;
            this.ClblContrasenaU.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.ClblContrasenaU.Location = new System.Drawing.Point(131, 324);
            this.ClblContrasenaU.Name = "ClblContrasenaU";
            this.ClblContrasenaU.Size = new System.Drawing.Size(107, 34);
            this.ClblContrasenaU.TabIndex = 16;
            this.ClblContrasenaU.Text = "Contraseña";
            // 
            // CtxtContrasenaU
            // 
            this.CtxtContrasenaU.Location = new System.Drawing.Point(137, 361);
            this.CtxtContrasenaU.Name = "CtxtContrasenaU";
            this.CtxtContrasenaU.Size = new System.Drawing.Size(351, 20);
            this.CtxtContrasenaU.TabIndex = 17;
            // 
            // ClblConfirmarContrasenaU
            // 
            this.ClblConfirmarContrasenaU.AutoSize = true;
            this.ClblConfirmarContrasenaU.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.ClblConfirmarContrasenaU.Location = new System.Drawing.Point(131, 384);
            this.ClblConfirmarContrasenaU.Name = "ClblConfirmarContrasenaU";
            this.ClblConfirmarContrasenaU.Size = new System.Drawing.Size(189, 34);
            this.ClblConfirmarContrasenaU.TabIndex = 18;
            this.ClblConfirmarContrasenaU.Text = "Confirmar Contraseña";
            // 
            // CtxtConfirmarContrasenaU
            // 
            this.CtxtConfirmarContrasenaU.Location = new System.Drawing.Point(137, 421);
            this.CtxtConfirmarContrasenaU.Name = "CtxtConfirmarContrasenaU";
            this.CtxtConfirmarContrasenaU.Size = new System.Drawing.Size(351, 20);
            this.CtxtConfirmarContrasenaU.TabIndex = 19;
            //this.CtxtConfirmarContrasenaU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CtxtConfirmarContrasenaU_KeyPress);
            // 
            // ClblNotaNU
            // 
            this.ClblNotaNU.AutoSize = true;
            this.ClblNotaNU.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClblNotaNU.ForeColor = System.Drawing.Color.Red;
            this.ClblNotaNU.Location = new System.Drawing.Point(315, 520);
            this.ClblNotaNU.Name = "ClblNotaNU";
            this.ClblNotaNU.Size = new System.Drawing.Size(183, 9);
            this.ClblNotaNU.TabIndex = 20;
            this.ClblNotaNU.Text = "NOTA : Nombre de Usuario siempre en Mayusculas";
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(500, 529);
            this.Controls.Add(this.ClblNotaNU);
            this.Controls.Add(this.CtxtConfirmarContrasenaU);
            this.Controls.Add(this.ClblConfirmarContrasenaU);
            this.Controls.Add(this.CtxtContrasenaU);
            this.Controls.Add(this.ClblContrasenaU);
            this.Controls.Add(this.CtxtCorreoU);
            this.Controls.Add(this.SlblCorreo);
            this.Controls.Add(this.CpictureNuevoUsuario);
            this.Controls.Add(this.CtxtNombreUsuario);
            this.Controls.Add(this.SlblNombreDeUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptarr);
            this.Controls.Add(this.CtxtTelefonoU);
            this.Controls.Add(this.CtxtApellidoU);
            this.Controls.Add(this.CtxtNombreU);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevoUsuario";
            this.Text = "Nuevo Usuario";
            //this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NuevoUsuario_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.CpictureNuevoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox CtxtNombreU;
        private System.Windows.Forms.TextBox CtxtApellidoU;
        private System.Windows.Forms.TextBox CtxtTelefonoU;
        private System.Windows.Forms.Button btnAceptarr;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label SlblNombreDeUsuario;
        private System.Windows.Forms.TextBox CtxtNombreUsuario;
        private System.Windows.Forms.PictureBox CpictureNuevoUsuario;
        private System.Windows.Forms.Label SlblCorreo;
        private System.Windows.Forms.TextBox CtxtCorreoU;
        private System.Windows.Forms.Label ClblContrasenaU;
        private System.Windows.Forms.TextBox CtxtContrasenaU;
        private System.Windows.Forms.Label ClblConfirmarContrasenaU;
        private System.Windows.Forms.TextBox CtxtConfirmarContrasenaU;
        private System.Windows.Forms.Label ClblNotaNU;
    }
}