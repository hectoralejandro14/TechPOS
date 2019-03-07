namespace WindowsFormsApp1.Views
{
    partial class Notificaciones
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
            this.panelNotificacion = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNotificaciones = new System.Windows.Forms.Label();
            this.panelNotificacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNotificacion
            // 
            this.panelNotificacion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelNotificacion.Controls.Add(this.label2);
            this.panelNotificacion.Location = new System.Drawing.Point(148, 80);
            this.panelNotificacion.Name = "panelNotificacion";
            this.panelNotificacion.Size = new System.Drawing.Size(416, 94);
            this.panelNotificacion.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(27, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = ".....";
            // 
            // lblNotificaciones
            // 
            this.lblNotificaciones.AutoSize = true;
            this.lblNotificaciones.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificaciones.Location = new System.Drawing.Point(279, 27);
            this.lblNotificaciones.Name = "lblNotificaciones";
            this.lblNotificaciones.Size = new System.Drawing.Size(154, 29);
            this.lblNotificaciones.TabIndex = 1;
            this.lblNotificaciones.Text = "Notificaciones";
            // 
            // Notificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 490);
            this.Controls.Add(this.lblNotificaciones);
            this.Controls.Add(this.panelNotificacion);
            this.Name = "Notificaciones";
            this.Text = "Notificaciones";
            this.panelNotificacion.ResumeLayout(false);
            this.panelNotificacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNotificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNotificaciones;
    }
}