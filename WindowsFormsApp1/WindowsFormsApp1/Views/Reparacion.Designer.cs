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
            this.fallaLblRepa = new System.Windows.Forms.Label();
            this.dRLblRepa = new System.Windows.Forms.Label();
            this.dEspLblRepa = new System.Windows.Forms.Label();
            this.responsLblRepa = new System.Windows.Forms.Label();
            this.totalLblRepa = new System.Windows.Forms.Label();
            this.abonoLblRepa = new System.Windows.Forms.Label();
            this.dRapidoTxtBox = new System.Windows.Forms.TextBox();
            this.dEspecificoTxtBox = new System.Windows.Forms.TextBox();
            this.idTxtBoxRepa = new System.Windows.Forms.TextBox();
            this.MarcaTxtBox = new System.Windows.Forms.TextBox();
            this.fallaTxtBoxRepa = new System.Windows.Forms.TextBox();
            this.EstadoTxtBox = new System.Windows.Forms.TextBox();
            this.ModeloTxtBoxRepa = new System.Windows.Forms.TextBox();
            this.ResponsableTxtBox = new System.Windows.Forms.TextBox();
            this.TotalTxtBox = new System.Windows.Forms.TextBox();
            this.AbonoTxtBox = new System.Windows.Forms.TextBox();
            this.ActualizarBtn = new System.Windows.Forms.Button();
            this.AbonarBtn = new System.Windows.Forms.Button();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLblRepa
            // 
            this.idLblRepa.AutoSize = true;
            this.idLblRepa.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.idLblRepa.Location = new System.Drawing.Point(21, 20);
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
            this.estadoLblRepa.Location = new System.Drawing.Point(202, 20);
            this.estadoLblRepa.Name = "estadoLblRepa";
            this.estadoLblRepa.Size = new System.Drawing.Size(70, 34);
            this.estadoLblRepa.TabIndex = 1;
            this.estadoLblRepa.Text = "Estado";
            // 
            // marccaLblRepa
            // 
            this.marccaLblRepa.AutoSize = true;
            this.marccaLblRepa.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.marccaLblRepa.Location = new System.Drawing.Point(13, 54);
            this.marccaLblRepa.Name = "marccaLblRepa";
            this.marccaLblRepa.Size = new System.Drawing.Size(64, 34);
            this.marccaLblRepa.TabIndex = 2;
            this.marccaLblRepa.Text = "Marca";
            // 
            // modeloLblRepa
            // 
            this.modeloLblRepa.AutoSize = true;
            this.modeloLblRepa.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.modeloLblRepa.Location = new System.Drawing.Point(202, 54);
            this.modeloLblRepa.Name = "modeloLblRepa";
            this.modeloLblRepa.Size = new System.Drawing.Size(72, 34);
            this.modeloLblRepa.TabIndex = 3;
            this.modeloLblRepa.Text = "Modelo";
            // 
            // fallaLblRepa
            // 
            this.fallaLblRepa.AutoSize = true;
            this.fallaLblRepa.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.fallaLblRepa.Location = new System.Drawing.Point(16, 86);
            this.fallaLblRepa.Name = "fallaLblRepa";
            this.fallaLblRepa.Size = new System.Drawing.Size(53, 34);
            this.fallaLblRepa.TabIndex = 4;
            this.fallaLblRepa.Text = "Falla";
            // 
            // dRLblRepa
            // 
            this.dRLblRepa.AutoSize = true;
            this.dRLblRepa.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.dRLblRepa.Location = new System.Drawing.Point(17, 188);
            this.dRLblRepa.Name = "dRLblRepa";
            this.dRLblRepa.Size = new System.Drawing.Size(164, 34);
            this.dRLblRepa.TabIndex = 5;
            this.dRLblRepa.Text = "Diagnóstico rápido";
            // 
            // dEspLblRepa
            // 
            this.dEspLblRepa.AutoSize = true;
            this.dEspLblRepa.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.dEspLblRepa.Location = new System.Drawing.Point(17, 310);
            this.dEspLblRepa.Name = "dEspLblRepa";
            this.dEspLblRepa.Size = new System.Drawing.Size(198, 34);
            this.dEspLblRepa.TabIndex = 6;
            this.dEspLblRepa.Text = "Diagnóstico específico";
            // 
            // responsLblRepa
            // 
            this.responsLblRepa.AutoSize = true;
            this.responsLblRepa.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.responsLblRepa.Location = new System.Drawing.Point(16, 427);
            this.responsLblRepa.Name = "responsLblRepa";
            this.responsLblRepa.Size = new System.Drawing.Size(118, 34);
            this.responsLblRepa.TabIndex = 7;
            this.responsLblRepa.Text = "Responsable";
            // 
            // totalLblRepa
            // 
            this.totalLblRepa.AutoSize = true;
            this.totalLblRepa.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.totalLblRepa.Location = new System.Drawing.Point(35, 462);
            this.totalLblRepa.Name = "totalLblRepa";
            this.totalLblRepa.Size = new System.Drawing.Size(54, 34);
            this.totalLblRepa.TabIndex = 8;
            this.totalLblRepa.Text = "Total";
            // 
            // abonoLblRepa
            // 
            this.abonoLblRepa.AutoSize = true;
            this.abonoLblRepa.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.abonoLblRepa.Location = new System.Drawing.Point(206, 462);
            this.abonoLblRepa.Name = "abonoLblRepa";
            this.abonoLblRepa.Size = new System.Drawing.Size(66, 34);
            this.abonoLblRepa.TabIndex = 9;
            this.abonoLblRepa.Text = "Abono";
            // 
            // dRapidoTxtBox
            // 
            this.dRapidoTxtBox.AcceptsReturn = true;
            this.dRapidoTxtBox.Location = new System.Drawing.Point(22, 225);
            this.dRapidoTxtBox.Multiline = true;
            this.dRapidoTxtBox.Name = "dRapidoTxtBox";
            this.dRapidoTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dRapidoTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dRapidoTxtBox.Size = new System.Drawing.Size(320, 82);
            this.dRapidoTxtBox.TabIndex = 10;
            // 
            // dEspecificoTxtBox
            // 
            this.dEspecificoTxtBox.Location = new System.Drawing.Point(22, 337);
            this.dEspecificoTxtBox.Multiline = true;
            this.dEspecificoTxtBox.Name = "dEspecificoTxtBox";
            this.dEspecificoTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dEspecificoTxtBox.Size = new System.Drawing.Size(320, 77);
            this.dEspecificoTxtBox.TabIndex = 11;
            // 
            // idTxtBoxRepa
            // 
            this.idTxtBoxRepa.Location = new System.Drawing.Point(52, 24);
            this.idTxtBoxRepa.Name = "idTxtBoxRepa";
            this.idTxtBoxRepa.Size = new System.Drawing.Size(120, 20);
            this.idTxtBoxRepa.TabIndex = 12;
            // 
            // MarcaTxtBox
            // 
            this.MarcaTxtBox.Location = new System.Drawing.Point(72, 62);
            this.MarcaTxtBox.Name = "MarcaTxtBox";
            this.MarcaTxtBox.Size = new System.Drawing.Size(120, 20);
            this.MarcaTxtBox.TabIndex = 13;
            // 
            // fallaTxtBoxRepa
            // 
            this.fallaTxtBoxRepa.Location = new System.Drawing.Point(23, 114);
            this.fallaTxtBoxRepa.Multiline = true;
            this.fallaTxtBoxRepa.Name = "fallaTxtBoxRepa";
            this.fallaTxtBoxRepa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fallaTxtBoxRepa.Size = new System.Drawing.Size(320, 76);
            this.fallaTxtBoxRepa.TabIndex = 14;
            // 
            // EstadoTxtBox
            // 
            this.EstadoTxtBox.Location = new System.Drawing.Point(278, 27);
            this.EstadoTxtBox.Name = "EstadoTxtBox";
            this.EstadoTxtBox.Size = new System.Drawing.Size(120, 20);
            this.EstadoTxtBox.TabIndex = 15;
            // 
            // ModeloTxtBoxRepa
            // 
            this.ModeloTxtBoxRepa.Location = new System.Drawing.Point(278, 60);
            this.ModeloTxtBoxRepa.Name = "ModeloTxtBoxRepa";
            this.ModeloTxtBoxRepa.Size = new System.Drawing.Size(120, 20);
            this.ModeloTxtBoxRepa.TabIndex = 16;
            // 
            // ResponsableTxtBox
            // 
            this.ResponsableTxtBox.Location = new System.Drawing.Point(140, 435);
            this.ResponsableTxtBox.Name = "ResponsableTxtBox";
            this.ResponsableTxtBox.Size = new System.Drawing.Size(247, 20);
            this.ResponsableTxtBox.TabIndex = 17;
            // 
            // TotalTxtBox
            // 
            this.TotalTxtBox.Location = new System.Drawing.Point(95, 470);
            this.TotalTxtBox.Name = "TotalTxtBox";
            this.TotalTxtBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTxtBox.TabIndex = 18;
            // 
            // AbonoTxtBox
            // 
            this.AbonoTxtBox.Location = new System.Drawing.Point(278, 470);
            this.AbonoTxtBox.Name = "AbonoTxtBox";
            this.AbonoTxtBox.Size = new System.Drawing.Size(100, 20);
            this.AbonoTxtBox.TabIndex = 19;
            // 
            // ActualizarBtn
            // 
            this.ActualizarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(198)))), ((int)(((byte)(206)))));
            this.ActualizarBtn.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.ActualizarBtn.ForeColor = System.Drawing.Color.Black;
            this.ActualizarBtn.Location = new System.Drawing.Point(43, 513);
            this.ActualizarBtn.Name = "ActualizarBtn";
            this.ActualizarBtn.Size = new System.Drawing.Size(104, 34);
            this.ActualizarBtn.TabIndex = 20;
            this.ActualizarBtn.Text = "Actualizar";
            this.ActualizarBtn.UseVisualStyleBackColor = false;
            // 
            // AbonarBtn
            // 
            this.AbonarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(198)))), ((int)(((byte)(206)))));
            this.AbonarBtn.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.AbonarBtn.Location = new System.Drawing.Point(167, 513);
            this.AbonarBtn.Name = "AbonarBtn";
            this.AbonarBtn.Size = new System.Drawing.Size(82, 34);
            this.AbonarBtn.TabIndex = 21;
            this.AbonarBtn.Text = "Abonar";
            this.AbonarBtn.UseVisualStyleBackColor = false;
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(198)))), ((int)(((byte)(206)))));
            this.AceptarBtn.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold);
            this.AceptarBtn.Location = new System.Drawing.Point(288, 513);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(90, 34);
            this.AceptarBtn.TabIndex = 22;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = false;
            // 
            // Reparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 568);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.AbonarBtn);
            this.Controls.Add(this.ActualizarBtn);
            this.Controls.Add(this.AbonoTxtBox);
            this.Controls.Add(this.TotalTxtBox);
            this.Controls.Add(this.ResponsableTxtBox);
            this.Controls.Add(this.ModeloTxtBoxRepa);
            this.Controls.Add(this.EstadoTxtBox);
            this.Controls.Add(this.fallaTxtBoxRepa);
            this.Controls.Add(this.MarcaTxtBox);
            this.Controls.Add(this.idTxtBoxRepa);
            this.Controls.Add(this.dEspecificoTxtBox);
            this.Controls.Add(this.dRapidoTxtBox);
            this.Controls.Add(this.abonoLblRepa);
            this.Controls.Add(this.totalLblRepa);
            this.Controls.Add(this.responsLblRepa);
            this.Controls.Add(this.dEspLblRepa);
            this.Controls.Add(this.dRLblRepa);
            this.Controls.Add(this.fallaLblRepa);
            this.Controls.Add(this.modeloLblRepa);
            this.Controls.Add(this.marccaLblRepa);
            this.Controls.Add(this.estadoLblRepa);
            this.Controls.Add(this.idLblRepa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reparacion";
            this.Text = "Equipo en reparación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLblRepa;
        private System.Windows.Forms.Label estadoLblRepa;
        private System.Windows.Forms.Label marccaLblRepa;
        private System.Windows.Forms.Label modeloLblRepa;
        private System.Windows.Forms.Label fallaLblRepa;
        private System.Windows.Forms.Label dRLblRepa;
        private System.Windows.Forms.Label dEspLblRepa;
        private System.Windows.Forms.Label responsLblRepa;
        private System.Windows.Forms.Label totalLblRepa;
        private System.Windows.Forms.Label abonoLblRepa;
        private System.Windows.Forms.TextBox dRapidoTxtBox;
        private System.Windows.Forms.TextBox dEspecificoTxtBox;
        private System.Windows.Forms.TextBox idTxtBoxRepa;
        private System.Windows.Forms.TextBox MarcaTxtBox;
        private System.Windows.Forms.TextBox fallaTxtBoxRepa;
        private System.Windows.Forms.TextBox EstadoTxtBox;
        private System.Windows.Forms.TextBox ModeloTxtBoxRepa;
        private System.Windows.Forms.TextBox ResponsableTxtBox;
        private System.Windows.Forms.TextBox TotalTxtBox;
        private System.Windows.Forms.TextBox AbonoTxtBox;
        private System.Windows.Forms.Button ActualizarBtn;
        private System.Windows.Forms.Button AbonarBtn;
        private System.Windows.Forms.Button AceptarBtn;
    }
}