namespace WindowsFormsApp1.Views
{
    partial class ViewAddRoles
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
            this.SbtnAgregarRol = new System.Windows.Forms.Button();
            this.SdgvRoles = new System.Windows.Forms.DataGridView();
            this.SlblRolesDisponibles = new System.Windows.Forms.Label();
            this.SbtnCerrar = new System.Windows.Forms.Button();
            this.SlblAgregarRoles = new System.Windows.Forms.Label();
            this.StxtNombreRol = new System.Windows.Forms.TextBox();
            this.SlblRol = new System.Windows.Forms.Label();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SdgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // SbtnAgregarRol
            // 
            this.SbtnAgregarRol.Location = new System.Drawing.Point(356, 45);
            this.SbtnAgregarRol.Name = "SbtnAgregarRol";
            this.SbtnAgregarRol.Size = new System.Drawing.Size(149, 23);
            this.SbtnAgregarRol.TabIndex = 0;
            this.SbtnAgregarRol.Text = "Agregar Rol";
            this.SbtnAgregarRol.UseVisualStyleBackColor = true;
            // 
            // SdgvRoles
            // 
            this.SdgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SdgvRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRol,
            this.NombreRol});
            this.SdgvRoles.Location = new System.Drawing.Point(12, 114);
            this.SdgvRoles.Name = "SdgvRoles";
            this.SdgvRoles.Size = new System.Drawing.Size(493, 386);
            this.SdgvRoles.TabIndex = 1;
            // 
            // SlblRolesDisponibles
            // 
            this.SlblRolesDisponibles.AutoSize = true;
            this.SlblRolesDisponibles.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlblRolesDisponibles.Location = new System.Drawing.Point(12, 92);
            this.SlblRolesDisponibles.Name = "SlblRolesDisponibles";
            this.SlblRolesDisponibles.Size = new System.Drawing.Size(148, 19);
            this.SlblRolesDisponibles.TabIndex = 2;
            this.SlblRolesDisponibles.Text = "Roles Disponibles";
            // 
            // SbtnCerrar
            // 
            this.SbtnCerrar.Location = new System.Drawing.Point(394, 506);
            this.SbtnCerrar.Name = "SbtnCerrar";
            this.SbtnCerrar.Size = new System.Drawing.Size(111, 23);
            this.SbtnCerrar.TabIndex = 3;
            this.SbtnCerrar.Text = "Cerrar";
            this.SbtnCerrar.UseVisualStyleBackColor = true;
            this.SbtnCerrar.Click += new System.EventHandler(this.SbtnCerrar_Click);
            // 
            // SlblAgregarRoles
            // 
            this.SlblAgregarRoles.AutoSize = true;
            this.SlblAgregarRoles.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlblAgregarRoles.Location = new System.Drawing.Point(12, 9);
            this.SlblAgregarRoles.Name = "SlblAgregarRoles";
            this.SlblAgregarRoles.Size = new System.Drawing.Size(118, 19);
            this.SlblAgregarRoles.TabIndex = 4;
            this.SlblAgregarRoles.Text = "Agregar Roles";
            // 
            // StxtNombreRol
            // 
            this.StxtNombreRol.Location = new System.Drawing.Point(50, 45);
            this.StxtNombreRol.Name = "StxtNombreRol";
            this.StxtNombreRol.Size = new System.Drawing.Size(300, 20);
            this.StxtNombreRol.TabIndex = 5;
            // 
            // SlblRol
            // 
            this.SlblRol.AutoSize = true;
            this.SlblRol.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlblRol.Location = new System.Drawing.Point(13, 45);
            this.SlblRol.Name = "SlblRol";
            this.SlblRol.Size = new System.Drawing.Size(31, 18);
            this.SlblRol.TabIndex = 6;
            this.SlblRol.Text = "Rol";
            // 
            // IdRol
            // 
            this.IdRol.HeaderText = "Id Rol";
            this.IdRol.Name = "IdRol";
            this.IdRol.Width = 150;
            // 
            // NombreRol
            // 
            this.NombreRol.HeaderText = "Nombre de Rol";
            this.NombreRol.Name = "NombreRol";
            this.NombreRol.Width = 300;
            // 
            // ViewAddRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(519, 541);
            this.Controls.Add(this.SlblRol);
            this.Controls.Add(this.StxtNombreRol);
            this.Controls.Add(this.SlblAgregarRoles);
            this.Controls.Add(this.SbtnCerrar);
            this.Controls.Add(this.SlblRolesDisponibles);
            this.Controls.Add(this.SdgvRoles);
            this.Controls.Add(this.SbtnAgregarRol);
            this.Name = "ViewAddRoles";
            this.Text = "Agregar Roles";
            ((System.ComponentModel.ISupportInitialize)(this.SdgvRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SbtnAgregarRol;
        private System.Windows.Forms.DataGridView SdgvRoles;
        private System.Windows.Forms.Label SlblRolesDisponibles;
        private System.Windows.Forms.Button SbtnCerrar;
        private System.Windows.Forms.Label SlblAgregarRoles;
        private System.Windows.Forms.TextBox StxtNombreRol;
        private System.Windows.Forms.Label SlblRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreRol;
    }
}