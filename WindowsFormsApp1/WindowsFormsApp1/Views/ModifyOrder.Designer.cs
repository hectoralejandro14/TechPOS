namespace WindowsFormsApp1.Views
{
    partial class ModifyOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.idLblMOrdenes = new System.Windows.Forms.Label();
            this.descripcionLlbMOrdenes = new System.Windows.Forms.Label();
            this.estadosLblMOrdenes = new System.Windows.Forms.Label();
            this.idTbxMOrdenes = new System.Windows.Forms.TextBox();
            this.descTbxOrdenes = new System.Windows.Forms.TextBox();
            this.estadosTbxOrdenes = new System.Windows.Forms.TextBox();
            this.cancelarBtnMOrdens = new System.Windows.Forms.Button();
            this.aceptarBtnMOrdenes = new System.Windows.Forms.Button();
            this.modificarLblOrdenes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // idLblMOrdenes
            // 
            this.idLblMOrdenes.AutoSize = true;
            this.idLblMOrdenes.Location = new System.Drawing.Point(46, 53);
            this.idLblMOrdenes.Name = "idLblMOrdenes";
            this.idLblMOrdenes.Size = new System.Drawing.Size(18, 13);
            this.idLblMOrdenes.TabIndex = 1;
            this.idLblMOrdenes.Text = "ID";
            // 
            // descripcionLlbMOrdenes
            // 
            this.descripcionLlbMOrdenes.AutoSize = true;
            this.descripcionLlbMOrdenes.Location = new System.Drawing.Point(15, 88);
            this.descripcionLlbMOrdenes.Name = "descripcionLlbMOrdenes";
            this.descripcionLlbMOrdenes.Size = new System.Drawing.Size(63, 13);
            this.descripcionLlbMOrdenes.TabIndex = 2;
            this.descripcionLlbMOrdenes.Text = "Descripción";
            // 
            // estadosLblMOrdenes
            // 
            this.estadosLblMOrdenes.AutoSize = true;
            this.estadosLblMOrdenes.Location = new System.Drawing.Point(30, 130);
            this.estadosLblMOrdenes.Name = "estadosLblMOrdenes";
            this.estadosLblMOrdenes.Size = new System.Drawing.Size(45, 13);
            this.estadosLblMOrdenes.TabIndex = 3;
            this.estadosLblMOrdenes.Text = "Estados";
            // 
            // idTbxMOrdenes
            // 
            this.idTbxMOrdenes.Location = new System.Drawing.Point(82, 46);
            this.idTbxMOrdenes.Name = "idTbxMOrdenes";
            this.idTbxMOrdenes.Size = new System.Drawing.Size(100, 20);
            this.idTbxMOrdenes.TabIndex = 4;
            // 
            // descTbxOrdenes
            // 
            this.descTbxOrdenes.Location = new System.Drawing.Point(82, 88);
            this.descTbxOrdenes.Name = "descTbxOrdenes";
            this.descTbxOrdenes.Size = new System.Drawing.Size(100, 20);
            this.descTbxOrdenes.TabIndex = 5;
            // 
            // estadosTbxOrdenes
            // 
            this.estadosTbxOrdenes.Location = new System.Drawing.Point(82, 127);
            this.estadosTbxOrdenes.Name = "estadosTbxOrdenes";
            this.estadosTbxOrdenes.Size = new System.Drawing.Size(100, 20);
            this.estadosTbxOrdenes.TabIndex = 6;
            // 
            // cancelarBtnMOrdens
            // 
            this.cancelarBtnMOrdens.Location = new System.Drawing.Point(18, 165);
            this.cancelarBtnMOrdens.Name = "cancelarBtnMOrdens";
            this.cancelarBtnMOrdens.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtnMOrdens.TabIndex = 7;
            this.cancelarBtnMOrdens.Text = "Cancelar";
            this.cancelarBtnMOrdens.UseVisualStyleBackColor = true;
            // 
            // aceptarBtnMOrdenes
            // 
            this.aceptarBtnMOrdenes.Location = new System.Drawing.Point(137, 165);
            this.aceptarBtnMOrdenes.Name = "aceptarBtnMOrdenes";
            this.aceptarBtnMOrdenes.Size = new System.Drawing.Size(75, 23);
            this.aceptarBtnMOrdenes.TabIndex = 8;
            this.aceptarBtnMOrdenes.Text = "Aceptar";
            this.aceptarBtnMOrdenes.UseVisualStyleBackColor = true;
            // 
            // modificarLblOrdenes
            // 
            this.modificarLblOrdenes.AutoSize = true;
            this.modificarLblOrdenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarLblOrdenes.Location = new System.Drawing.Point(93, 17);
            this.modificarLblOrdenes.Name = "modificarLblOrdenes";
            this.modificarLblOrdenes.Size = new System.Drawing.Size(63, 16);
            this.modificarLblOrdenes.TabIndex = 9;
            this.modificarLblOrdenes.Text = "Modificar";
            // 
            // ModifyOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 209);
            this.Controls.Add(this.modificarLblOrdenes);
            this.Controls.Add(this.aceptarBtnMOrdenes);
            this.Controls.Add(this.cancelarBtnMOrdens);
            this.Controls.Add(this.estadosTbxOrdenes);
            this.Controls.Add(this.descTbxOrdenes);
            this.Controls.Add(this.idTbxMOrdenes);
            this.Controls.Add(this.estadosLblMOrdenes);
            this.Controls.Add(this.descripcionLlbMOrdenes);
            this.Controls.Add(this.idLblMOrdenes);
            this.Controls.Add(this.label1);
            this.Name = "ModifyOrder";
            this.Text = "Órdenes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idLblMOrdenes;
        private System.Windows.Forms.Label descripcionLlbMOrdenes;
        private System.Windows.Forms.Label estadosLblMOrdenes;
        private System.Windows.Forms.TextBox idTbxMOrdenes;
        private System.Windows.Forms.TextBox descTbxOrdenes;
        private System.Windows.Forms.TextBox estadosTbxOrdenes;
        private System.Windows.Forms.Button cancelarBtnMOrdens;
        private System.Windows.Forms.Button aceptarBtnMOrdenes;
        private System.Windows.Forms.Label modificarLblOrdenes;
    }
}