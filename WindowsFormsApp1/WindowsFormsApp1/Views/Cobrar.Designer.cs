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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cobrar));
            this.totalLbl = new System.Windows.Forms.Label();
            this.tipoPagoLlb = new System.Windows.Forms.Label();
            this.cambioLbl = new System.Windows.Forms.Label();
            this.efectivoLbl = new System.Windows.Forms.Label();
            this.totalFinalLbl = new System.Windows.Forms.Label();
            this.cobrarLbl = new System.Windows.Forms.Label();
            this.tipoPagoCbx = new System.Windows.Forms.ComboBox();
            this.btnCobrarVentaNI = new System.Windows.Forms.Button();
            this.txtReciboVenta = new System.Windows.Forms.TextBox();
            this.txtCambioVenta = new System.Windows.Forms.TextBox();
            this.SpanelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTotalVenta = new System.Windows.Forms.TextBox();
            this.SpanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.totalLbl.Location = new System.Drawing.Point(150, 171);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(64, 34);
            this.totalLbl.TabIndex = 0;
            this.totalLbl.Text = "Total :";
            // 
            // tipoPagoLlb
            // 
            this.tipoPagoLlb.AutoSize = true;
            this.tipoPagoLlb.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.tipoPagoLlb.ForeColor = System.Drawing.Color.DarkOrange;
            this.tipoPagoLlb.Location = new System.Drawing.Point(96, 43);
            this.tipoPagoLlb.Name = "tipoPagoLlb";
            this.tipoPagoLlb.Size = new System.Drawing.Size(129, 34);
            this.tipoPagoLlb.TabIndex = 1;
            this.tipoPagoLlb.Text = "Tipo de pago :";
            // 
            // cambioLbl
            // 
            this.cambioLbl.AutoSize = true;
            this.cambioLbl.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.cambioLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.cambioLbl.Location = new System.Drawing.Point(140, 129);
            this.cambioLbl.Name = "cambioLbl";
            this.cambioLbl.Size = new System.Drawing.Size(85, 34);
            this.cambioLbl.TabIndex = 2;
            this.cambioLbl.Text = "Cambio :";
            // 
            // efectivoLbl
            // 
            this.efectivoLbl.AutoSize = true;
            this.efectivoLbl.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.efectivoLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.efectivoLbl.Location = new System.Drawing.Point(140, 86);
            this.efectivoLbl.Name = "efectivoLbl";
            this.efectivoLbl.Size = new System.Drawing.Size(85, 34);
            this.efectivoLbl.TabIndex = 3;
            this.efectivoLbl.Text = "Recibo : ";
            // 
            // totalFinalLbl
            // 
            this.totalFinalLbl.AutoSize = true;
            this.totalFinalLbl.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.totalFinalLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.totalFinalLbl.Location = new System.Drawing.Point(210, 171);
            this.totalFinalLbl.Name = "totalFinalLbl";
            this.totalFinalLbl.Size = new System.Drawing.Size(25, 34);
            this.totalFinalLbl.TabIndex = 4;
            this.totalFinalLbl.Text = "$";
            // 
            // cobrarLbl
            // 
            this.cobrarLbl.AutoSize = true;
            this.cobrarLbl.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobrarLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.cobrarLbl.Location = new System.Drawing.Point(225, 9);
            this.cobrarLbl.Name = "cobrarLbl";
            this.cobrarLbl.Size = new System.Drawing.Size(79, 34);
            this.cobrarLbl.TabIndex = 7;
            this.cobrarLbl.Text = "Venta";
            // 
            // tipoPagoCbx
            // 
            this.tipoPagoCbx.FormattingEnabled = true;
            this.tipoPagoCbx.Location = new System.Drawing.Point(231, 51);
            this.tipoPagoCbx.Name = "tipoPagoCbx";
            this.tipoPagoCbx.Size = new System.Drawing.Size(227, 21);
            this.tipoPagoCbx.TabIndex = 8;
            // 
            // btnCobrarVentaNI
            // 
            this.btnCobrarVentaNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCobrarVentaNI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobrarVentaNI.FlatAppearance.BorderSize = 0;
            this.btnCobrarVentaNI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCobrarVentaNI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCobrarVentaNI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrarVentaNI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrarVentaNI.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnCobrarVentaNI.Location = new System.Drawing.Point(310, 217);
            this.btnCobrarVentaNI.Name = "btnCobrarVentaNI";
            this.btnCobrarVentaNI.Size = new System.Drawing.Size(127, 29);
            this.btnCobrarVentaNI.TabIndex = 11;
            this.btnCobrarVentaNI.Text = "Cobrar";
            this.btnCobrarVentaNI.UseVisualStyleBackColor = false;
            this.btnCobrarVentaNI.Click += new System.EventHandler(this.btnCobrarVentaNI_Click);
            // 
            // txtReciboVenta
            // 
            this.txtReciboVenta.Location = new System.Drawing.Point(231, 94);
            this.txtReciboVenta.Name = "txtReciboVenta";
            this.txtReciboVenta.Size = new System.Drawing.Size(227, 20);
            this.txtReciboVenta.TabIndex = 12;
            this.txtReciboVenta.TextChanged += new System.EventHandler(this.txtReciboVenta_TextChanged);
            this.txtReciboVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtReciboVenta_KeyPress);
            // 
            // txtCambioVenta
            // 
            this.txtCambioVenta.Location = new System.Drawing.Point(231, 137);
            this.txtCambioVenta.Name = "txtCambioVenta";
            this.txtCambioVenta.Size = new System.Drawing.Size(227, 20);
            this.txtCambioVenta.TabIndex = 13;
            // 
            // SpanelLogo
            // 
            this.SpanelLogo.BackColor = System.Drawing.Color.DimGray;
            this.SpanelLogo.Controls.Add(this.pictureBox1);
            this.SpanelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.SpanelLogo.Location = new System.Drawing.Point(0, 0);
            this.SpanelLogo.Name = "SpanelLogo";
            this.SpanelLogo.Size = new System.Drawing.Size(81, 258);
            this.SpanelLogo.TabIndex = 14;
            this.SpanelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SpanelLogo_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logoUp;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtTotalVenta
            // 
            this.txtTotalVenta.Location = new System.Drawing.Point(231, 179);
            this.txtTotalVenta.Name = "txtTotalVenta";
            this.txtTotalVenta.Size = new System.Drawing.Size(227, 20);
            this.txtTotalVenta.TabIndex = 9;
            // 
            // Cobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(500, 258);
            this.Controls.Add(this.SpanelLogo);
            this.Controls.Add(this.txtCambioVenta);
            this.Controls.Add(this.txtReciboVenta);
            this.Controls.Add(this.btnCobrarVentaNI);
            this.Controls.Add(this.txtTotalVenta);
            this.Controls.Add(this.tipoPagoCbx);
            this.Controls.Add(this.cobrarLbl);
            this.Controls.Add(this.totalFinalLbl);
            this.Controls.Add(this.efectivoLbl);
            this.Controls.Add(this.cambioLbl);
            this.Controls.Add(this.tipoPagoLlb);
            this.Controls.Add(this.totalLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobrar";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cobrar_MouseDown);
            this.SpanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label tipoPagoLlb;
        private System.Windows.Forms.Label cambioLbl;
        private System.Windows.Forms.Label efectivoLbl;
        private System.Windows.Forms.Label totalFinalLbl;
        private System.Windows.Forms.Label cobrarLbl;
        private System.Windows.Forms.ComboBox tipoPagoCbx;
        private System.Windows.Forms.Button btnCobrarVentaNI;
        private System.Windows.Forms.TextBox txtReciboVenta;
        private System.Windows.Forms.TextBox txtCambioVenta;
        private System.Windows.Forms.Panel SpanelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTotalVenta;
    }
}