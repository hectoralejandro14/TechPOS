namespace WindowsFormsApp1
{
    partial class Reparacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reparacion));
            this.idLblRepa = new System.Windows.Forms.Label();
            this.estadoLblRepa = new System.Windows.Forms.Label();
            this.marccaLblRepa = new System.Windows.Forms.Label();
            this.modeloLblRepa = new System.Windows.Forms.Label();
            this.responsLblRepa = new System.Windows.Forms.Label();
            this.totalLblRepa = new System.Windows.Forms.Label();
            this.abonoLblRepa = new System.Windows.Forms.Label();
            this.dRapidoTxtBox = new System.Windows.Forms.TextBox();
            this.trabajoRealizadotxtC = new System.Windows.Forms.TextBox();
            this.idTxtBoxRepa = new System.Windows.Forms.TextBox();
            this.MarcaTxtBox = new System.Windows.Forms.TextBox();
            this.fallaTxtBoxRepa = new System.Windows.Forms.TextBox();
            this.ModeloTxtBoxRepa = new System.Windows.Forms.TextBox();
            this.ResponsableTxtBox = new System.Windows.Forms.TextBox();
            this.TotalTxtBox = new System.Windows.Forms.TextBox();
            this.AbonoTxtBox = new System.Windows.Forms.TextBox();
            this.ActualizarBtn = new System.Windows.Forms.Button();
            this.AbonarBtn = new System.Windows.Forms.Button();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.piezaOrderbtnC = new System.Windows.Forms.Button();
            this.estadoCBoxC = new System.Windows.Forms.ComboBox();
            this.layDatosReparacion = new System.Windows.Forms.TableLayoutPanel();
            this.FallaReparacionGBx = new System.Windows.Forms.GroupBox();
            this.DiagnosticoGBx = new System.Windows.Forms.GroupBox();
            this.TrabajoRealizadoGBx = new System.Windows.Forms.GroupBox();
            this.SlblCantidadRestanteAPagar = new System.Windows.Forms.Label();
            this.StxtCantidadRestanteAPagar = new System.Windows.Forms.TextBox();
            this.SlblAbonarAProductoCliente = new System.Windows.Forms.Label();
            this.StxtNuevoAbonoCliente = new System.Windows.Forms.TextBox();
            this.layDatosReparacion.SuspendLayout();
            this.FallaReparacionGBx.SuspendLayout();
            this.DiagnosticoGBx.SuspendLayout();
            this.TrabajoRealizadoGBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLblRepa
            // 
            this.idLblRepa.AutoSize = true;
            this.idLblRepa.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.idLblRepa.Location = new System.Drawing.Point(3, 0);
            this.idLblRepa.Name = "idLblRepa";
            this.idLblRepa.Size = new System.Drawing.Size(32, 34);
            this.idLblRepa.TabIndex = 0;
            this.idLblRepa.Text = "ID";
            this.idLblRepa.Click += new System.EventHandler(this.label1_Click);
            // 
            // estadoLblRepa
            // 
            this.estadoLblRepa.AutoSize = true;
            this.estadoLblRepa.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.estadoLblRepa.Location = new System.Drawing.Point(384, 0);
            this.estadoLblRepa.Name = "estadoLblRepa";
            this.estadoLblRepa.Size = new System.Drawing.Size(70, 34);
            this.estadoLblRepa.TabIndex = 1;
            this.estadoLblRepa.Text = "Estado";
            // 
            // marccaLblRepa
            // 
            this.marccaLblRepa.AutoSize = true;
            this.marccaLblRepa.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.marccaLblRepa.Location = new System.Drawing.Point(3, 37);
            this.marccaLblRepa.Name = "marccaLblRepa";
            this.marccaLblRepa.Size = new System.Drawing.Size(64, 34);
            this.marccaLblRepa.TabIndex = 2;
            this.marccaLblRepa.Text = "Marca";
            // 
            // modeloLblRepa
            // 
            this.modeloLblRepa.AutoSize = true;
            this.modeloLblRepa.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.modeloLblRepa.Location = new System.Drawing.Point(384, 37);
            this.modeloLblRepa.Name = "modeloLblRepa";
            this.modeloLblRepa.Size = new System.Drawing.Size(72, 34);
            this.modeloLblRepa.TabIndex = 3;
            this.modeloLblRepa.Text = "Modelo";
            // 
            // responsLblRepa
            // 
            this.responsLblRepa.AutoSize = true;
            this.responsLblRepa.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.responsLblRepa.Location = new System.Drawing.Point(40, 427);
            this.responsLblRepa.Name = "responsLblRepa";
            this.responsLblRepa.Size = new System.Drawing.Size(118, 34);
            this.responsLblRepa.TabIndex = 7;
            this.responsLblRepa.Text = "Responsable";
            // 
            // totalLblRepa
            // 
            this.totalLblRepa.AutoSize = true;
            this.totalLblRepa.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.totalLblRepa.Location = new System.Drawing.Point(345, 431);
            this.totalLblRepa.Name = "totalLblRepa";
            this.totalLblRepa.Size = new System.Drawing.Size(54, 34);
            this.totalLblRepa.TabIndex = 8;
            this.totalLblRepa.Text = "Total";
            // 
            // abonoLblRepa
            // 
            this.abonoLblRepa.AutoSize = true;
            this.abonoLblRepa.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.abonoLblRepa.Location = new System.Drawing.Point(41, 468);
            this.abonoLblRepa.Name = "abonoLblRepa";
            this.abonoLblRepa.Size = new System.Drawing.Size(136, 34);
            this.abonoLblRepa.TabIndex = 9;
            this.abonoLblRepa.Text = "Abono Anterios";
            // 
            // dRapidoTxtBox
            // 
            this.dRapidoTxtBox.AcceptsReturn = true;
            this.dRapidoTxtBox.Location = new System.Drawing.Point(23, 25);
            this.dRapidoTxtBox.Multiline = true;
            this.dRapidoTxtBox.Name = "dRapidoTxtBox";
            this.dRapidoTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dRapidoTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dRapidoTxtBox.Size = new System.Drawing.Size(584, 82);
            this.dRapidoTxtBox.TabIndex = 10;
            this.dRapidoTxtBox.TextChanged += new System.EventHandler(this.dRapidoTxtBox_TextChanged);
            // 
            // trabajoRealizadotxtC
            // 
            this.trabajoRealizadotxtC.Location = new System.Drawing.Point(27, 23);
            this.trabajoRealizadotxtC.Multiline = true;
            this.trabajoRealizadotxtC.Name = "trabajoRealizadotxtC";
            this.trabajoRealizadotxtC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.trabajoRealizadotxtC.Size = new System.Drawing.Size(578, 77);
            this.trabajoRealizadotxtC.TabIndex = 11;
            // 
            // idTxtBoxRepa
            // 
            this.idTxtBoxRepa.Enabled = false;
            this.idTxtBoxRepa.Location = new System.Drawing.Point(150, 3);
            this.idTxtBoxRepa.Name = "idTxtBoxRepa";
            this.idTxtBoxRepa.Size = new System.Drawing.Size(228, 20);
            this.idTxtBoxRepa.TabIndex = 12;
            // 
            // MarcaTxtBox
            // 
            this.MarcaTxtBox.Enabled = false;
            this.MarcaTxtBox.Location = new System.Drawing.Point(150, 40);
            this.MarcaTxtBox.Name = "MarcaTxtBox";
            this.MarcaTxtBox.Size = new System.Drawing.Size(228, 20);
            this.MarcaTxtBox.TabIndex = 13;
            // 
            // fallaTxtBoxRepa
            // 
            this.fallaTxtBoxRepa.Location = new System.Drawing.Point(24, 22);
            this.fallaTxtBoxRepa.Multiline = true;
            this.fallaTxtBoxRepa.Name = "fallaTxtBoxRepa";
            this.fallaTxtBoxRepa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fallaTxtBoxRepa.Size = new System.Drawing.Size(583, 76);
            this.fallaTxtBoxRepa.TabIndex = 14;
            // 
            // ModeloTxtBoxRepa
            // 
            this.ModeloTxtBoxRepa.Enabled = false;
            this.ModeloTxtBoxRepa.Location = new System.Drawing.Point(475, 40);
            this.ModeloTxtBoxRepa.Name = "ModeloTxtBoxRepa";
            this.ModeloTxtBoxRepa.Size = new System.Drawing.Size(135, 20);
            this.ModeloTxtBoxRepa.TabIndex = 16;
            // 
            // ResponsableTxtBox
            // 
            this.ResponsableTxtBox.Enabled = false;
            this.ResponsableTxtBox.Location = new System.Drawing.Point(183, 435);
            this.ResponsableTxtBox.Name = "ResponsableTxtBox";
            this.ResponsableTxtBox.Size = new System.Drawing.Size(156, 20);
            this.ResponsableTxtBox.TabIndex = 17;
            // 
            // TotalTxtBox
            // 
            this.TotalTxtBox.Enabled = false;
            this.TotalTxtBox.Location = new System.Drawing.Point(422, 435);
            this.TotalTxtBox.Name = "TotalTxtBox";
            this.TotalTxtBox.Size = new System.Drawing.Size(202, 20);
            this.TotalTxtBox.TabIndex = 18;
            // 
            // AbonoTxtBox
            // 
            this.AbonoTxtBox.Enabled = false;
            this.AbonoTxtBox.Location = new System.Drawing.Point(183, 476);
            this.AbonoTxtBox.Name = "AbonoTxtBox";
            this.AbonoTxtBox.Size = new System.Drawing.Size(156, 20);
            this.AbonoTxtBox.TabIndex = 19;
            // 
            // ActualizarBtn
            // 
            this.ActualizarBtn.BackColor = System.Drawing.Color.DimGray;
            this.ActualizarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ActualizarBtn.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.ActualizarBtn.ForeColor = System.Drawing.Color.White;
            this.ActualizarBtn.Location = new System.Drawing.Point(19, 542);
            this.ActualizarBtn.Name = "ActualizarBtn";
            this.ActualizarBtn.Size = new System.Drawing.Size(130, 43);
            this.ActualizarBtn.TabIndex = 20;
            this.ActualizarBtn.Text = "Actualizar";
            this.ActualizarBtn.UseVisualStyleBackColor = false;
            this.ActualizarBtn.Click += new System.EventHandler(this.ActualizarBtn_Click);
            // 
            // AbonarBtn
            // 
            this.AbonarBtn.BackColor = System.Drawing.Color.DimGray;
            this.AbonarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AbonarBtn.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.AbonarBtn.ForeColor = System.Drawing.Color.White;
            this.AbonarBtn.Location = new System.Drawing.Point(327, 542);
            this.AbonarBtn.Name = "AbonarBtn";
            this.AbonarBtn.Size = new System.Drawing.Size(130, 43);
            this.AbonarBtn.TabIndex = 21;
            this.AbonarBtn.Text = "Abonar";
            this.AbonarBtn.UseVisualStyleBackColor = false;
            this.AbonarBtn.Click += new System.EventHandler(this.AbonarBtn_Click);
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.BackColor = System.Drawing.Color.DimGray;
            this.AceptarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AceptarBtn.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.AceptarBtn.ForeColor = System.Drawing.Color.White;
            this.AceptarBtn.Location = new System.Drawing.Point(482, 542);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(130, 43);
            this.AceptarBtn.TabIndex = 22;
            this.AceptarBtn.Text = "Cerrar";
            this.AceptarBtn.UseVisualStyleBackColor = false;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // piezaOrderbtnC
            // 
            this.piezaOrderbtnC.BackColor = System.Drawing.Color.DimGray;
            this.piezaOrderbtnC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.piezaOrderbtnC.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.piezaOrderbtnC.ForeColor = System.Drawing.Color.White;
            this.piezaOrderbtnC.Location = new System.Drawing.Point(172, 542);
            this.piezaOrderbtnC.Name = "piezaOrderbtnC";
            this.piezaOrderbtnC.Size = new System.Drawing.Size(130, 43);
            this.piezaOrderbtnC.TabIndex = 23;
            this.piezaOrderbtnC.Text = "Pieza";
            this.piezaOrderbtnC.UseVisualStyleBackColor = false;
            this.piezaOrderbtnC.Click += new System.EventHandler(this.piezaOrderbtnC_Click);
            // 
            // estadoCBoxC
            // 
            this.estadoCBoxC.FormattingEnabled = true;
            this.estadoCBoxC.Location = new System.Drawing.Point(475, 3);
            this.estadoCBoxC.Name = "estadoCBoxC";
            this.estadoCBoxC.Size = new System.Drawing.Size(135, 21);
            this.estadoCBoxC.TabIndex = 24;
            // 
            // layDatosReparacion
            // 
            this.layDatosReparacion.ColumnCount = 4;
            this.layDatosReparacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.69347F));
            this.layDatosReparacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.30653F));
            this.layDatosReparacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.layDatosReparacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.layDatosReparacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.2561F));
            this.layDatosReparacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.7439F));
            this.layDatosReparacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.layDatosReparacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.layDatosReparacion.Controls.Add(this.estadoCBoxC, 3, 0);
            this.layDatosReparacion.Controls.Add(this.idLblRepa, 0, 0);
            this.layDatosReparacion.Controls.Add(this.MarcaTxtBox, 1, 1);
            this.layDatosReparacion.Controls.Add(this.estadoLblRepa, 2, 0);
            this.layDatosReparacion.Controls.Add(this.modeloLblRepa, 2, 1);
            this.layDatosReparacion.Controls.Add(this.ModeloTxtBoxRepa, 3, 1);
            this.layDatosReparacion.Controls.Add(this.marccaLblRepa, 0, 1);
            this.layDatosReparacion.Controls.Add(this.idTxtBoxRepa, 1, 0);
            this.layDatosReparacion.Location = new System.Drawing.Point(23, 12);
            this.layDatosReparacion.Name = "layDatosReparacion";
            this.layDatosReparacion.RowCount = 2;
            this.layDatosReparacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.70588F));
            this.layDatosReparacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.29412F));
            this.layDatosReparacion.Size = new System.Drawing.Size(613, 85);
            this.layDatosReparacion.TabIndex = 25;
            // 
            // FallaReparacionGBx
            // 
            this.FallaReparacionGBx.Controls.Add(this.fallaTxtBoxRepa);
            this.FallaReparacionGBx.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FallaReparacionGBx.Location = new System.Drawing.Point(23, 99);
            this.FallaReparacionGBx.Name = "FallaReparacionGBx";
            this.FallaReparacionGBx.Size = new System.Drawing.Size(613, 104);
            this.FallaReparacionGBx.TabIndex = 26;
            this.FallaReparacionGBx.TabStop = false;
            this.FallaReparacionGBx.Text = "Falla";
            // 
            // DiagnosticoGBx
            // 
            this.DiagnosticoGBx.Controls.Add(this.dRapidoTxtBox);
            this.DiagnosticoGBx.Font = new System.Drawing.Font("Cordia New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagnosticoGBx.Location = new System.Drawing.Point(23, 203);
            this.DiagnosticoGBx.Name = "DiagnosticoGBx";
            this.DiagnosticoGBx.Size = new System.Drawing.Size(607, 113);
            this.DiagnosticoGBx.TabIndex = 27;
            this.DiagnosticoGBx.TabStop = false;
            this.DiagnosticoGBx.Text = "Diagnóstico";
            // 
            // TrabajoRealizadoGBx
            // 
            this.TrabajoRealizadoGBx.Controls.Add(this.trabajoRealizadotxtC);
            this.TrabajoRealizadoGBx.Font = new System.Drawing.Font("Cordia New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrabajoRealizadoGBx.Location = new System.Drawing.Point(19, 322);
            this.TrabajoRealizadoGBx.Name = "TrabajoRealizadoGBx";
            this.TrabajoRealizadoGBx.Size = new System.Drawing.Size(611, 106);
            this.TrabajoRealizadoGBx.TabIndex = 28;
            this.TrabajoRealizadoGBx.TabStop = false;
            this.TrabajoRealizadoGBx.Text = "Trabajo Realizado";
            // 
            // SlblCantidadRestanteAPagar
            // 
            this.SlblCantidadRestanteAPagar.AutoSize = true;
            this.SlblCantidadRestanteAPagar.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.SlblCantidadRestanteAPagar.Location = new System.Drawing.Point(339, 505);
            this.SlblCantidadRestanteAPagar.Name = "SlblCantidadRestanteAPagar";
            this.SlblCantidadRestanteAPagar.Size = new System.Drawing.Size(85, 34);
            this.SlblCantidadRestanteAPagar.TabIndex = 29;
            this.SlblCantidadRestanteAPagar.Text = "Restante";
            // 
            // StxtCantidadRestanteAPagar
            // 
            this.StxtCantidadRestanteAPagar.Enabled = false;
            this.StxtCantidadRestanteAPagar.Location = new System.Drawing.Point(422, 514);
            this.StxtCantidadRestanteAPagar.Name = "StxtCantidadRestanteAPagar";
            this.StxtCantidadRestanteAPagar.Size = new System.Drawing.Size(202, 20);
            this.StxtCantidadRestanteAPagar.TabIndex = 30;
            // 
            // SlblAbonarAProductoCliente
            // 
            this.SlblAbonarAProductoCliente.AutoSize = true;
            this.SlblAbonarAProductoCliente.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.SlblAbonarAProductoCliente.Location = new System.Drawing.Point(343, 468);
            this.SlblAbonarAProductoCliente.Name = "SlblAbonarAProductoCliente";
            this.SlblAbonarAProductoCliente.Size = new System.Drawing.Size(72, 34);
            this.SlblAbonarAProductoCliente.TabIndex = 31;
            this.SlblAbonarAProductoCliente.Text = "Abonar";
            // 
            // StxtNuevoAbonoCliente
            // 
            this.StxtNuevoAbonoCliente.Enabled = false;
            this.StxtNuevoAbonoCliente.Location = new System.Drawing.Point(422, 476);
            this.StxtNuevoAbonoCliente.Name = "StxtNuevoAbonoCliente";
            this.StxtNuevoAbonoCliente.Size = new System.Drawing.Size(202, 20);
            this.StxtNuevoAbonoCliente.TabIndex = 32;
            // 
            // Reparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(656, 602);
            this.Controls.Add(this.StxtNuevoAbonoCliente);
            this.Controls.Add(this.SlblAbonarAProductoCliente);
            this.Controls.Add(this.StxtCantidadRestanteAPagar);
            this.Controls.Add(this.SlblCantidadRestanteAPagar);
            this.Controls.Add(this.TrabajoRealizadoGBx);
            this.Controls.Add(this.DiagnosticoGBx);
            this.Controls.Add(this.FallaReparacionGBx);
            this.Controls.Add(this.layDatosReparacion);
            this.Controls.Add(this.piezaOrderbtnC);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.AbonarBtn);
            this.Controls.Add(this.ActualizarBtn);
            this.Controls.Add(this.AbonoTxtBox);
            this.Controls.Add(this.TotalTxtBox);
            this.Controls.Add(this.ResponsableTxtBox);
            this.Controls.Add(this.abonoLblRepa);
            this.Controls.Add(this.totalLblRepa);
            this.Controls.Add(this.responsLblRepa);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reparacion";
            this.Text = "Equipo en reparación";
            this.Load += new System.EventHandler(this.Reparacion_Load);
            this.layDatosReparacion.ResumeLayout(false);
            this.layDatosReparacion.PerformLayout();
            this.FallaReparacionGBx.ResumeLayout(false);
            this.FallaReparacionGBx.PerformLayout();
            this.DiagnosticoGBx.ResumeLayout(false);
            this.DiagnosticoGBx.PerformLayout();
            this.TrabajoRealizadoGBx.ResumeLayout(false);
            this.TrabajoRealizadoGBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLblRepa;
        private System.Windows.Forms.Label estadoLblRepa;
        private System.Windows.Forms.Label marccaLblRepa;
        private System.Windows.Forms.Label modeloLblRepa;
        private System.Windows.Forms.Label responsLblRepa;
        private System.Windows.Forms.Label totalLblRepa;
        private System.Windows.Forms.Label abonoLblRepa;
        private System.Windows.Forms.TextBox dRapidoTxtBox;
        private System.Windows.Forms.TextBox trabajoRealizadotxtC;
        private System.Windows.Forms.TextBox idTxtBoxRepa;
        private System.Windows.Forms.TextBox MarcaTxtBox;
        private System.Windows.Forms.TextBox fallaTxtBoxRepa;
        private System.Windows.Forms.TextBox ModeloTxtBoxRepa;
        private System.Windows.Forms.TextBox ResponsableTxtBox;
        private System.Windows.Forms.TextBox TotalTxtBox;
        private System.Windows.Forms.TextBox AbonoTxtBox;
        private System.Windows.Forms.Button ActualizarBtn;
        private System.Windows.Forms.Button AbonarBtn;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.Button piezaOrderbtnC;
        private System.Windows.Forms.ComboBox estadoCBoxC;
        private System.Windows.Forms.TableLayoutPanel layDatosReparacion;
        private System.Windows.Forms.GroupBox FallaReparacionGBx;
        private System.Windows.Forms.GroupBox DiagnosticoGBx;
        private System.Windows.Forms.GroupBox TrabajoRealizadoGBx;
        private System.Windows.Forms.Label SlblCantidadRestanteAPagar;
        private System.Windows.Forms.TextBox StxtCantidadRestanteAPagar;
        private System.Windows.Forms.Label SlblAbonarAProductoCliente;
        private System.Windows.Forms.TextBox StxtNuevoAbonoCliente;
    }
}