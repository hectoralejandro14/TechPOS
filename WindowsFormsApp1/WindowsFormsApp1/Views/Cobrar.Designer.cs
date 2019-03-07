namespace WindowsFormsApp1.Views
{
    partial class Cobrar
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
            this.totalLbl = new System.Windows.Forms.Label();
            this.tipoPagoLlb = new System.Windows.Forms.Label();
            this.cambioLbl = new System.Windows.Forms.Label();
            this.efectivoLbl = new System.Windows.Forms.Label();
            this.totalFinalLbl = new System.Windows.Forms.Label();
            this.cancelarBtnCobrar = new System.Windows.Forms.Button();
            this.cobrarBtn = new System.Windows.Forms.Button();
            this.cobrarLbl = new System.Windows.Forms.Label();
            this.tipoPagoCbx = new System.Windows.Forms.ComboBox();
            this.efectivoTbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(83, 76);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(59, 34);
            this.totalLbl.TabIndex = 0;
            this.totalLbl.Text = "Total:";
            // 
            // tipoPagoLlb
            // 
            this.tipoPagoLlb.AutoSize = true;
            this.tipoPagoLlb.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.tipoPagoLlb.Location = new System.Drawing.Point(83, 115);
            this.tipoPagoLlb.Name = "tipoPagoLlb";
            this.tipoPagoLlb.Size = new System.Drawing.Size(124, 34);
            this.tipoPagoLlb.TabIndex = 1;
            this.tipoPagoLlb.Text = "Tipo de pago:";
            // 
            // cambioLbl
            // 
            this.cambioLbl.AutoSize = true;
            this.cambioLbl.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.cambioLbl.Location = new System.Drawing.Point(87, 200);
            this.cambioLbl.Name = "cambioLbl";
            this.cambioLbl.Size = new System.Drawing.Size(80, 34);
            this.cambioLbl.TabIndex = 2;
            this.cambioLbl.Text = "Cambio:";
            // 
            // efectivoLbl
            // 
            this.efectivoLbl.AutoSize = true;
            this.efectivoLbl.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.efectivoLbl.Location = new System.Drawing.Point(87, 158);
            this.efectivoLbl.Name = "efectivoLbl";
            this.efectivoLbl.Size = new System.Drawing.Size(83, 34);
            this.efectivoLbl.TabIndex = 3;
            this.efectivoLbl.Text = "Efectivo:";
            // 
            // totalFinalLbl
            // 
            this.totalFinalLbl.AutoSize = true;
            this.totalFinalLbl.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.totalFinalLbl.Location = new System.Drawing.Point(142, 76);
            this.totalFinalLbl.Name = "totalFinalLbl";
            this.totalFinalLbl.Size = new System.Drawing.Size(25, 34);
            this.totalFinalLbl.TabIndex = 4;
            this.totalFinalLbl.Text = "$";
            // 
            // cancelarBtnCobrar
            // 
            this.cancelarBtnCobrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancelarBtnCobrar.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.cancelarBtnCobrar.Location = new System.Drawing.Point(128, 262);
            this.cancelarBtnCobrar.Name = "cancelarBtnCobrar";
            this.cancelarBtnCobrar.Size = new System.Drawing.Size(79, 35);
            this.cancelarBtnCobrar.TabIndex = 5;
            this.cancelarBtnCobrar.Text = "Cancelar";
            this.cancelarBtnCobrar.UseVisualStyleBackColor = false;
            // 
            // cobrarBtn
            // 
            this.cobrarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cobrarBtn.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.cobrarBtn.Location = new System.Drawing.Point(254, 262);
            this.cobrarBtn.Name = "cobrarBtn";
            this.cobrarBtn.Size = new System.Drawing.Size(78, 35);
            this.cobrarBtn.TabIndex = 6;
            this.cobrarBtn.Text = "Cobrar";
            this.cobrarBtn.UseVisualStyleBackColor = false;
            // 
            // cobrarLbl
            // 
            this.cobrarLbl.AutoSize = true;
            this.cobrarLbl.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobrarLbl.Location = new System.Drawing.Point(156, 19);
            this.cobrarLbl.Name = "cobrarLbl";
            this.cobrarLbl.Size = new System.Drawing.Size(80, 29);
            this.cobrarLbl.TabIndex = 7;
            this.cobrarLbl.Text = "Cobrar";
            // 
            // tipoPagoCbx
            // 
            this.tipoPagoCbx.FormattingEnabled = true;
            this.tipoPagoCbx.Location = new System.Drawing.Point(232, 123);
            this.tipoPagoCbx.Name = "tipoPagoCbx";
            this.tipoPagoCbx.Size = new System.Drawing.Size(97, 21);
            this.tipoPagoCbx.TabIndex = 8;
            // 
            // efectivoTbx
            // 
            this.efectivoTbx.Location = new System.Drawing.Point(232, 158);
            this.efectivoTbx.Name = "efectivoTbx";
            this.efectivoTbx.Size = new System.Drawing.Size(97, 20);
            this.efectivoTbx.TabIndex = 9;
            // 
            // Cobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 324);
            this.Controls.Add(this.efectivoTbx);
            this.Controls.Add(this.tipoPagoCbx);
            this.Controls.Add(this.cobrarLbl);
            this.Controls.Add(this.cobrarBtn);
            this.Controls.Add(this.cancelarBtnCobrar);
            this.Controls.Add(this.totalFinalLbl);
            this.Controls.Add(this.efectivoLbl);
            this.Controls.Add(this.cambioLbl);
            this.Controls.Add(this.tipoPagoLlb);
            this.Controls.Add(this.totalLbl);
            this.Name = "Cobrar";
            this.Text = "Cobrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label tipoPagoLlb;
        private System.Windows.Forms.Label cambioLbl;
        private System.Windows.Forms.Label efectivoLbl;
        private System.Windows.Forms.Label totalFinalLbl;
        private System.Windows.Forms.Button cancelarBtnCobrar;
        private System.Windows.Forms.Button cobrarBtn;
        private System.Windows.Forms.Label cobrarLbl;
        private System.Windows.Forms.ComboBox tipoPagoCbx;
        private System.Windows.Forms.TextBox efectivoTbx;
    }
}