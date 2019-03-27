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
            this.SuspendLayout();
            // 
            // btnAceptarA
            // 
            this.btnAceptarA.Location = new System.Drawing.Point(25, 161);
            this.btnAceptarA.Name = "btnAceptarA";
            this.btnAceptarA.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarA.TabIndex = 0;
            this.btnAceptarA.Text = "Aceptar";
            this.btnAceptarA.UseVisualStyleBackColor = true;
            this.btnAceptarA.Click += new System.EventHandler(this.btnAceptarA_Click);
            // 
            // btnSalirA
            // 
            this.btnSalirA.Location = new System.Drawing.Point(172, 161);
            this.btnSalirA.Name = "btnSalirA";
            this.btnSalirA.Size = new System.Drawing.Size(75, 23);
            this.btnSalirA.TabIndex = 1;
            this.btnSalirA.Text = "Salir";
            this.btnSalirA.UseVisualStyleBackColor = true;
            this.btnSalirA.Click += new System.EventHandler(this.btnSalirA_Click);
            // 
            // lblUserNameA
            // 
            this.lblUserNameA.AutoSize = true;
            this.lblUserNameA.Location = new System.Drawing.Point(35, 49);
            this.lblUserNameA.Name = "lblUserNameA";
            this.lblUserNameA.Size = new System.Drawing.Size(55, 13);
            this.lblUserNameA.TabIndex = 2;
            this.lblUserNameA.Text = "Username";
            // 
            // labelNewPasswordA
            // 
            this.labelNewPasswordA.AutoSize = true;
            this.labelNewPasswordA.Location = new System.Drawing.Point(12, 100);
            this.labelNewPasswordA.Name = "labelNewPasswordA";
            this.labelNewPasswordA.Size = new System.Drawing.Size(78, 13);
            this.labelNewPasswordA.TabIndex = 3;
            this.labelNewPasswordA.Text = "New Password";
            // 
            // txtUserNameA
            // 
            this.txtUserNameA.Location = new System.Drawing.Point(96, 46);
            this.txtUserNameA.Name = "txtUserNameA";
            this.txtUserNameA.Size = new System.Drawing.Size(172, 20);
            this.txtUserNameA.TabIndex = 4;
            // 
            // txtNewPasswordA
            // 
            this.txtNewPasswordA.Location = new System.Drawing.Point(96, 97);
            this.txtNewPasswordA.Name = "txtNewPasswordA";
            this.txtNewPasswordA.Size = new System.Drawing.Size(172, 20);
            this.txtNewPasswordA.TabIndex = 5;
            // 
            // cambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 189);
            this.Controls.Add(this.txtNewPasswordA);
            this.Controls.Add(this.txtUserNameA);
            this.Controls.Add(this.labelNewPasswordA);
            this.Controls.Add(this.lblUserNameA);
            this.Controls.Add(this.btnSalirA);
            this.Controls.Add(this.btnAceptarA);
            this.Name = "cambiarContraseña";
            this.Text = "cambiarContraseña";
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
    }
}