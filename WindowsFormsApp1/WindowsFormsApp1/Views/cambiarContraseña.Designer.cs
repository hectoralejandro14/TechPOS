namespace WindowsFormsApp1.Views
{
    partial class cambiarContraseña
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
            this.btnAceptarA = new System.Windows.Forms.Button();
            this.btnSalirA = new System.Windows.Forms.Button();
            this.lblUserNameA = new System.Windows.Forms.Label();
            this.labelNewPasswordA = new System.Windows.Forms.Label();
            this.txtUserNameA = new System.Windows.Forms.TextBox();
            this.txtNewPasswordA = new System.Windows.Forms.TextBox();
            this.changecontraPnl = new System.Windows.Forms.Panel();
            this.logoChangeContra = new System.Windows.Forms.PictureBox();
            this.changecontraPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoChangeContra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptarA
            // 
            this.btnAceptarA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAceptarA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptarA.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAceptarA.Location = new System.Drawing.Point(417, 161);
            this.btnAceptarA.Name = "btnAceptarA";
            this.btnAceptarA.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarA.TabIndex = 0;
            this.btnAceptarA.Text = "Aceptar";
            this.btnAceptarA.UseVisualStyleBackColor = false;
            this.btnAceptarA.Click += new System.EventHandler(this.btnAceptarA_Click);
            // 
            // btnSalirA
            // 
            this.btnSalirA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSalirA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirA.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSalirA.Location = new System.Drawing.Point(291, 161);
            this.btnSalirA.Name = "btnSalirA";
            this.btnSalirA.Size = new System.Drawing.Size(88, 23);
            this.btnSalirA.TabIndex = 1;
            this.btnSalirA.Text = "Salir";
            this.btnSalirA.UseVisualStyleBackColor = false;
            this.btnSalirA.Click += new System.EventHandler(this.btnSalirA_Click);
            // 
            // lblUserNameA
            // 
            this.lblUserNameA.AutoSize = true;
            this.lblUserNameA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameA.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblUserNameA.Location = new System.Drawing.Point(183, 46);
            this.lblUserNameA.Name = "lblUserNameA";
            this.lblUserNameA.Size = new System.Drawing.Size(64, 20);
            this.lblUserNameA.TabIndex = 2;
            this.lblUserNameA.Text = "Usuario";
            // 
            // labelNewPasswordA
            // 
            this.labelNewPasswordA.AutoSize = true;
            this.labelNewPasswordA.Font = new System.Drawing.Font("Cordia New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPasswordA.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelNewPasswordA.Location = new System.Drawing.Point(182, 100);
            this.labelNewPasswordA.Name = "labelNewPasswordA";
            this.labelNewPasswordA.Size = new System.Drawing.Size(132, 29);
            this.labelNewPasswordA.TabIndex = 3;
            this.labelNewPasswordA.Text = "Nueva Contraseña";
            // 
            // txtUserNameA
            // 
            this.txtUserNameA.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameA.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtUserNameA.Location = new System.Drawing.Point(320, 46);
            this.txtUserNameA.Name = "txtUserNameA";
            this.txtUserNameA.Size = new System.Drawing.Size(172, 20);
            this.txtUserNameA.TabIndex = 4;
            // 
            // txtNewPasswordA
            // 
            this.txtNewPasswordA.Location = new System.Drawing.Point(320, 100);
            this.txtNewPasswordA.Name = "txtNewPasswordA";
            this.txtNewPasswordA.Size = new System.Drawing.Size(172, 20);
            this.txtNewPasswordA.TabIndex = 5;
            // 
            // changecontraPnl
            // 
            this.changecontraPnl.BackColor = System.Drawing.Color.DimGray;
            this.changecontraPnl.Controls.Add(this.logoChangeContra);
            this.changecontraPnl.Location = new System.Drawing.Point(-8, -8);
            this.changecontraPnl.Name = "changecontraPnl";
            this.changecontraPnl.Size = new System.Drawing.Size(125, 243);
            this.changecontraPnl.TabIndex = 6;
            // 
            // logoChangeContra
            // 
            this.logoChangeContra.Image = global::WindowsFormsApp1.Properties.Resources.logoUp;
            this.logoChangeContra.Location = new System.Drawing.Point(20, 20);
            this.logoChangeContra.Name = "logoChangeContra";
            this.logoChangeContra.Size = new System.Drawing.Size(83, 108);
            this.logoChangeContra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoChangeContra.TabIndex = 0;
            this.logoChangeContra.TabStop = false;
            // 
            // cambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(536, 227);
            this.ControlBox = false;
            this.Controls.Add(this.changecontraPnl);
            this.Controls.Add(this.txtNewPasswordA);
            this.Controls.Add(this.txtUserNameA);
            this.Controls.Add(this.labelNewPasswordA);
            this.Controls.Add(this.lblUserNameA);
            this.Controls.Add(this.btnSalirA);
            this.Controls.Add(this.btnAceptarA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cambiarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.changecontraPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoChangeContra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarA;
        private System.Windows.Forms.Button btnSalirA;
        private System.Windows.Forms.Label lblUserNameA;
        private System.Windows.Forms.Label labelNewPasswordA;
        private System.Windows.Forms.TextBox txtUserNameA;
        private System.Windows.Forms.TextBox txtNewPasswordA;
        private System.Windows.Forms.Panel changecontraPnl;
        private System.Windows.Forms.PictureBox logoChangeContra;
    }
}