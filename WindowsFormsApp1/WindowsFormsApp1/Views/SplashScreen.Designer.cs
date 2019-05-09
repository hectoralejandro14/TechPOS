namespace WindowsFormsApp1.Views
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.SplasScreenImg = new System.Windows.Forms.PictureBox();
            this.metroLabelCargando = new MetroFramework.Controls.MetroLabel();
            this.TiempoRespuestaBar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SplasScreenImg)).BeginInit();
            this.SuspendLayout();
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(48, 323);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(305, 23);
            this.metroProgressBar1.TabIndex = 0;
            // 
            // SplasScreenImg
            // 
            this.SplasScreenImg.Image = global::WindowsFormsApp1.Properties.Resources.logoUp;
            this.SplasScreenImg.Location = new System.Drawing.Point(142, 63);
            this.SplasScreenImg.Name = "SplasScreenImg";
            this.SplasScreenImg.Size = new System.Drawing.Size(161, 245);
            this.SplasScreenImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SplasScreenImg.TabIndex = 1;
            this.SplasScreenImg.TabStop = false;
            // 
            // metroLabelCargando
            // 
            this.metroLabelCargando.AutoSize = true;
            this.metroLabelCargando.Location = new System.Drawing.Point(48, 373);
            this.metroLabelCargando.Name = "metroLabelCargando";
            this.metroLabelCargando.Size = new System.Drawing.Size(77, 19);
            this.metroLabelCargando.TabIndex = 2;
            this.metroLabelCargando.Text = "Cargando...";
            // 
            // TiempoRespuestaBar
            // 
            this.TiempoRespuestaBar.Enabled = true;
            this.TiempoRespuestaBar.Tick += new System.EventHandler(this.TiempoRespuestaBar_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 401);
            this.Controls.Add(this.metroLabelCargando);
            this.Controls.Add(this.SplasScreenImg);
            this.Controls.Add(this.metroProgressBar1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.Text = "UP - Software";
            ((System.ComponentModel.ISupportInitialize)(this.SplasScreenImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.PictureBox SplasScreenImg;
        private MetroFramework.Controls.MetroLabel metroLabelCargando;
        private System.Windows.Forms.Timer TiempoRespuestaBar;
    }
}