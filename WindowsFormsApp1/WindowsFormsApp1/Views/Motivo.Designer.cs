﻿namespace WindowsFormsApp1.Views
{
    partial class Motivo
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
            this.motivoLbl = new System.Windows.Forms.Label();
            this.cancelarVLbl = new System.Windows.Forms.Label();
            this.motivoTbxCancelarV = new System.Windows.Forms.RichTextBox();
            this.regresarBtnCVenta = new System.Windows.Forms.Button();
            this.aceptarBtnCancelV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // motivoLbl
            // 
            this.motivoLbl.AutoSize = true;
            this.motivoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motivoLbl.Location = new System.Drawing.Point(145, 105);
            this.motivoLbl.Name = "motivoLbl";
            this.motivoLbl.Size = new System.Drawing.Size(48, 16);
            this.motivoLbl.TabIndex = 0;
            this.motivoLbl.Text = "Motivo";
            // 
            // cancelarVLbl
            // 
            this.cancelarVLbl.AutoSize = true;
            this.cancelarVLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarVLbl.Location = new System.Drawing.Point(223, 32);
            this.cancelarVLbl.Name = "cancelarVLbl";
            this.cancelarVLbl.Size = new System.Drawing.Size(201, 31);
            this.cancelarVLbl.TabIndex = 1;
            this.cancelarVLbl.Text = "Cancelar Venta";
            // 
            // motivoTbxCancelarV
            // 
            this.motivoTbxCancelarV.Location = new System.Drawing.Point(131, 133);
            this.motivoTbxCancelarV.Name = "motivoTbxCancelarV";
            this.motivoTbxCancelarV.Size = new System.Drawing.Size(415, 180);
            this.motivoTbxCancelarV.TabIndex = 2;
            this.motivoTbxCancelarV.Text = "";
            // 
            // regresarBtnCVenta
            // 
            this.regresarBtnCVenta.Location = new System.Drawing.Point(358, 371);
            this.regresarBtnCVenta.Name = "regresarBtnCVenta";
            this.regresarBtnCVenta.Size = new System.Drawing.Size(75, 32);
            this.regresarBtnCVenta.TabIndex = 3;
            this.regresarBtnCVenta.Text = "Regresar";
            this.regresarBtnCVenta.UseVisualStyleBackColor = true;
            // 
            // aceptarBtnCancelV
            // 
            this.aceptarBtnCancelV.Location = new System.Drawing.Point(470, 371);
            this.aceptarBtnCancelV.Name = "aceptarBtnCancelV";
            this.aceptarBtnCancelV.Size = new System.Drawing.Size(76, 32);
            this.aceptarBtnCancelV.TabIndex = 4;
            this.aceptarBtnCancelV.Text = "Aceptar";
            this.aceptarBtnCancelV.UseVisualStyleBackColor = true;
            // 
            // Motivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 426);
            this.Controls.Add(this.aceptarBtnCancelV);
            this.Controls.Add(this.regresarBtnCVenta);
            this.Controls.Add(this.motivoTbxCancelarV);
            this.Controls.Add(this.cancelarVLbl);
            this.Controls.Add(this.motivoLbl);
            this.Name = "Motivo";
            this.Text = "Motivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label motivoLbl;
        private System.Windows.Forms.Label cancelarVLbl;
        private System.Windows.Forms.RichTextBox motivoTbxCancelarV;
        private System.Windows.Forms.Button regresarBtnCVenta;
        private System.Windows.Forms.Button aceptarBtnCancelV;
    }
}