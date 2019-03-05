namespace WindowsFormsApp1.Views
{
    partial class ViewTabs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTabs));
            this.tabPuntoVenta = new System.Windows.Forms.TabControl();
            this.tabVenta = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabRecibirEquipo = new System.Windows.Forms.TabPage();
            this.pictureBuscar = new System.Windows.Forms.PictureBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.SlblApellido = new System.Windows.Forms.Label();
            this.btnPedirPieza = new System.Windows.Forms.Button();
            this.btnAgregrEquipos = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.comboResponsable = new System.Windows.Forms.ComboBox();
            this.txtAnticipo = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SlblResponsable = new System.Windows.Forms.Label();
            this.txtDescripcionDiagnosticoEspecifico = new System.Windows.Forms.TextBox();
            this.rbDiagnosticoEspecifico = new System.Windows.Forms.RadioButton();
            this.rbDiagnosticoRapido = new System.Windows.Forms.RadioButton();
            this.txtDescripcionDeFalla = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.SlblIdEquipo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.SlblMarca = new System.Windows.Forms.Label();
            this.SlblModelo = new System.Windows.Forms.Label();
            this.SlblDescripcionDeFalla = new System.Windows.Forms.Label();
            this.SlblTipoDiagnostico = new System.Windows.Forms.Label();
            this.SlblTotal = new System.Windows.Forms.Label();
            this.SlblAnticipo = new System.Windows.Forms.Label();
            this.SlblDatosEquipo = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.SlblCorreo = new System.Windows.Forms.Label();
            this.SlblTelefono = new System.Windows.Forms.Label();
            this.SlblNombre = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.SlbBuscarCliente = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabReparacion = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.UnaLabel = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id_Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.tabPuntoVenta.SuspendLayout();
            this.tabVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabRecibirEquipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPuntoVenta
            // 
            this.tabPuntoVenta.Controls.Add(this.tabVenta);
            this.tabPuntoVenta.Controls.Add(this.tabRecibirEquipo);
            this.tabPuntoVenta.Controls.Add(this.tabReparacion);
            this.tabPuntoVenta.Controls.Add(this.tabPage2);
            this.tabPuntoVenta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPuntoVenta.Location = new System.Drawing.Point(2, 0);
            this.tabPuntoVenta.Name = "tabPuntoVenta";
            this.tabPuntoVenta.SelectedIndex = 0;
            this.tabPuntoVenta.Size = new System.Drawing.Size(1336, 716);
            this.tabPuntoVenta.TabIndex = 0;
            // 
            // tabVenta
            // 
            this.tabVenta.Controls.Add(this.button2);
            this.tabVenta.Controls.Add(this.button1);
            this.tabVenta.Controls.Add(this.label3);
            this.tabVenta.Controls.Add(this.label1);
            this.tabVenta.Controls.Add(this.pictureBox3);
            this.tabVenta.Location = new System.Drawing.Point(4, 31);
            this.tabVenta.Name = "tabVenta";
            this.tabVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabVenta.Size = new System.Drawing.Size(1328, 681);
            this.tabVenta.TabIndex = 0;
            this.tabVenta.Text = "Venta";
            this.tabVenta.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1130, 615);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cobrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(921, 615);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Todos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1149, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.lupa;
            this.pictureBox3.Location = new System.Drawing.Point(951, 124);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // tabRecibirEquipo
            // 
            this.tabRecibirEquipo.Controls.Add(this.pictureBuscar);
            this.tabRecibirEquipo.Controls.Add(this.txtApellido);
            this.tabRecibirEquipo.Controls.Add(this.txtNombre);
            this.tabRecibirEquipo.Controls.Add(this.txtCorreo);
            this.tabRecibirEquipo.Controls.Add(this.txtTelefono);
            this.tabRecibirEquipo.Controls.Add(this.SlblApellido);
            this.tabRecibirEquipo.Controls.Add(this.btnPedirPieza);
            this.tabRecibirEquipo.Controls.Add(this.btnAgregrEquipos);
            this.tabRecibirEquipo.Controls.Add(this.btnLimpiarCampos);
            this.tabRecibirEquipo.Controls.Add(this.comboResponsable);
            this.tabRecibirEquipo.Controls.Add(this.txtAnticipo);
            this.tabRecibirEquipo.Controls.Add(this.txtTotal);
            this.tabRecibirEquipo.Controls.Add(this.SlblResponsable);
            this.tabRecibirEquipo.Controls.Add(this.txtDescripcionDiagnosticoEspecifico);
            this.tabRecibirEquipo.Controls.Add(this.rbDiagnosticoEspecifico);
            this.tabRecibirEquipo.Controls.Add(this.rbDiagnosticoRapido);
            this.tabRecibirEquipo.Controls.Add(this.txtDescripcionDeFalla);
            this.tabRecibirEquipo.Controls.Add(this.txtModelo);
            this.tabRecibirEquipo.Controls.Add(this.txtMarca);
            this.tabRecibirEquipo.Controls.Add(this.SlblIdEquipo);
            this.tabRecibirEquipo.Controls.Add(this.lblId);
            this.tabRecibirEquipo.Controls.Add(this.SlblMarca);
            this.tabRecibirEquipo.Controls.Add(this.SlblModelo);
            this.tabRecibirEquipo.Controls.Add(this.SlblDescripcionDeFalla);
            this.tabRecibirEquipo.Controls.Add(this.SlblTipoDiagnostico);
            this.tabRecibirEquipo.Controls.Add(this.SlblTotal);
            this.tabRecibirEquipo.Controls.Add(this.SlblAnticipo);
            this.tabRecibirEquipo.Controls.Add(this.SlblDatosEquipo);
            this.tabRecibirEquipo.Controls.Add(this.btnAgregarCliente);
            this.tabRecibirEquipo.Controls.Add(this.SlblCorreo);
            this.tabRecibirEquipo.Controls.Add(this.SlblTelefono);
            this.tabRecibirEquipo.Controls.Add(this.SlblNombre);
            this.tabRecibirEquipo.Controls.Add(this.label7);
            this.tabRecibirEquipo.Controls.Add(this.txtBuscarCliente);
            this.tabRecibirEquipo.Controls.Add(this.SlbBuscarCliente);
            this.tabRecibirEquipo.Controls.Add(this.pictureBox2);
            this.tabRecibirEquipo.Location = new System.Drawing.Point(4, 31);
            this.tabRecibirEquipo.Name = "tabRecibirEquipo";
            this.tabRecibirEquipo.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecibirEquipo.Size = new System.Drawing.Size(1328, 681);
            this.tabRecibirEquipo.TabIndex = 1;
            this.tabRecibirEquipo.Text = "Recibir Equipo";
            this.tabRecibirEquipo.UseVisualStyleBackColor = true;
            // 
            // pictureBuscar
            // 
            this.pictureBuscar.Image = global::WindowsFormsApp1.Properties.Resources.lupa;
            this.pictureBuscar.Location = new System.Drawing.Point(877, 22);
            this.pictureBuscar.Name = "pictureBuscar";
            this.pictureBuscar.Size = new System.Drawing.Size(22, 22);
            this.pictureBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBuscar.TabIndex = 42;
            this.pictureBuscar.TabStop = false;
            this.pictureBuscar.Click += new System.EventHandler(this.pictureBuscar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(269, 121);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(313, 29);
            this.txtApellido.TabIndex = 41;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(269, 66);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(313, 29);
            this.txtNombre.TabIndex = 40;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(707, 121);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(313, 29);
            this.txtCorreo.TabIndex = 39;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(707, 66);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(313, 29);
            this.txtTelefono.TabIndex = 38;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // SlblApellido
            // 
            this.SlblApellido.AutoSize = true;
            this.SlblApellido.ForeColor = System.Drawing.Color.Black;
            this.SlblApellido.Location = new System.Drawing.Point(172, 124);
            this.SlblApellido.Name = "SlblApellido";
            this.SlblApellido.Size = new System.Drawing.Size(97, 22);
            this.SlblApellido.TabIndex = 36;
            this.SlblApellido.Text = "Apellido :";
            // 
            // btnPedirPieza
            // 
            this.btnPedirPieza.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPedirPieza.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedirPieza.Location = new System.Drawing.Point(877, 631);
            this.btnPedirPieza.Name = "btnPedirPieza";
            this.btnPedirPieza.Size = new System.Drawing.Size(132, 33);
            this.btnPedirPieza.TabIndex = 35;
            this.btnPedirPieza.Text = "Pedir Pieza";
            this.btnPedirPieza.UseVisualStyleBackColor = false;
            this.btnPedirPieza.Click += new System.EventHandler(this.btnPedirPieza_Click);
            // 
            // btnAgregrEquipos
            // 
            this.btnAgregrEquipos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregrEquipos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregrEquipos.Location = new System.Drawing.Point(1015, 631);
            this.btnAgregrEquipos.Name = "btnAgregrEquipos";
            this.btnAgregrEquipos.Size = new System.Drawing.Size(132, 33);
            this.btnAgregrEquipos.TabIndex = 34;
            this.btnAgregrEquipos.Text = "Agregar Equipo";
            this.btnAgregrEquipos.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(1153, 631);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(132, 33);
            this.btnLimpiarCampos.TabIndex = 33;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // comboResponsable
            // 
            this.comboResponsable.FormattingEnabled = true;
            this.comboResponsable.Location = new System.Drawing.Point(269, 628);
            this.comboResponsable.Name = "comboResponsable";
            this.comboResponsable.Size = new System.Drawing.Size(207, 30);
            this.comboResponsable.TabIndex = 32;
            // 
            // txtAnticipo
            // 
            this.txtAnticipo.Location = new System.Drawing.Point(269, 582);
            this.txtAnticipo.Multiline = true;
            this.txtAnticipo.Name = "txtAnticipo";
            this.txtAnticipo.Size = new System.Drawing.Size(207, 29);
            this.txtAnticipo.TabIndex = 31;
            this.txtAnticipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnticipo_KeyPress);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(269, 542);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(207, 29);
            this.txtTotal.TabIndex = 30;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // SlblResponsable
            // 
            this.SlblResponsable.AutoSize = true;
            this.SlblResponsable.ForeColor = System.Drawing.Color.Black;
            this.SlblResponsable.Location = new System.Drawing.Point(81, 631);
            this.SlblResponsable.Name = "SlblResponsable";
            this.SlblResponsable.Size = new System.Drawing.Size(148, 22);
            this.SlblResponsable.TabIndex = 29;
            this.SlblResponsable.Text = "Responsable : ";
            // 
            // txtDescripcionDiagnosticoEspecifico
            // 
            this.txtDescripcionDiagnosticoEspecifico.Location = new System.Drawing.Point(63, 440);
            this.txtDescripcionDiagnosticoEspecifico.Multiline = true;
            this.txtDescripcionDiagnosticoEspecifico.Name = "txtDescripcionDiagnosticoEspecifico";
            this.txtDescripcionDiagnosticoEspecifico.Size = new System.Drawing.Size(939, 63);
            this.txtDescripcionDiagnosticoEspecifico.TabIndex = 28;
            // 
            // rbDiagnosticoEspecifico
            // 
            this.rbDiagnosticoEspecifico.AutoSize = true;
            this.rbDiagnosticoEspecifico.ForeColor = System.Drawing.Color.Black;
            this.rbDiagnosticoEspecifico.Location = new System.Drawing.Point(382, 404);
            this.rbDiagnosticoEspecifico.Name = "rbDiagnosticoEspecifico";
            this.rbDiagnosticoEspecifico.Size = new System.Drawing.Size(130, 26);
            this.rbDiagnosticoEspecifico.TabIndex = 27;
            this.rbDiagnosticoEspecifico.TabStop = true;
            this.rbDiagnosticoEspecifico.Text = "Específico.";
            this.rbDiagnosticoEspecifico.UseVisualStyleBackColor = true;
            // 
            // rbDiagnosticoRapido
            // 
            this.rbDiagnosticoRapido.AutoSize = true;
            this.rbDiagnosticoRapido.ForeColor = System.Drawing.Color.Black;
            this.rbDiagnosticoRapido.Location = new System.Drawing.Point(278, 404);
            this.rbDiagnosticoRapido.Name = "rbDiagnosticoRapido";
            this.rbDiagnosticoRapido.Size = new System.Drawing.Size(98, 26);
            this.rbDiagnosticoRapido.TabIndex = 26;
            this.rbDiagnosticoRapido.TabStop = true;
            this.rbDiagnosticoRapido.Text = "Rápido.";
            this.rbDiagnosticoRapido.UseVisualStyleBackColor = true;
            // 
            // txtDescripcionDeFalla
            // 
            this.txtDescripcionDeFalla.Location = new System.Drawing.Point(276, 345);
            this.txtDescripcionDeFalla.Multiline = true;
            this.txtDescripcionDeFalla.Name = "txtDescripcionDeFalla";
            this.txtDescripcionDeFalla.Size = new System.Drawing.Size(726, 37);
            this.txtDescripcionDeFalla.TabIndex = 25;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(276, 295);
            this.txtModelo.Multiline = true;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(726, 29);
            this.txtModelo.TabIndex = 24;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(276, 246);
            this.txtMarca.Multiline = true;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(726, 29);
            this.txtMarca.TabIndex = 23;
            // 
            // SlblIdEquipo
            // 
            this.SlblIdEquipo.AutoSize = true;
            this.SlblIdEquipo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlblIdEquipo.ForeColor = System.Drawing.Color.Black;
            this.SlblIdEquipo.Location = new System.Drawing.Point(1039, 186);
            this.SlblIdEquipo.Name = "SlblIdEquipo";
            this.SlblIdEquipo.Size = new System.Drawing.Size(183, 29);
            this.SlblIdEquipo.TabIndex = 22;
            this.SlblIdEquipo.Text = "ID de Equipo : ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblId.Location = new System.Drawing.Point(1217, 186);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(65, 29);
            this.lblId.TabIndex = 21;
            this.lblId.Text = "0000";
            // 
            // SlblMarca
            // 
            this.SlblMarca.AutoSize = true;
            this.SlblMarca.ForeColor = System.Drawing.Color.Black;
            this.SlblMarca.Location = new System.Drawing.Point(59, 253);
            this.SlblMarca.Name = "SlblMarca";
            this.SlblMarca.Size = new System.Drawing.Size(80, 22);
            this.SlblMarca.TabIndex = 20;
            this.SlblMarca.Text = "Marca :";
            // 
            // SlblModelo
            // 
            this.SlblModelo.AutoSize = true;
            this.SlblModelo.ForeColor = System.Drawing.Color.Black;
            this.SlblModelo.Location = new System.Drawing.Point(59, 298);
            this.SlblModelo.Name = "SlblModelo";
            this.SlblModelo.Size = new System.Drawing.Size(91, 22);
            this.SlblModelo.TabIndex = 19;
            this.SlblModelo.Text = "Modelo :";
            // 
            // SlblDescripcionDeFalla
            // 
            this.SlblDescripcionDeFalla.AutoSize = true;
            this.SlblDescripcionDeFalla.ForeColor = System.Drawing.Color.Black;
            this.SlblDescripcionDeFalla.Location = new System.Drawing.Point(59, 348);
            this.SlblDescripcionDeFalla.Name = "SlblDescripcionDeFalla";
            this.SlblDescripcionDeFalla.Size = new System.Drawing.Size(211, 22);
            this.SlblDescripcionDeFalla.TabIndex = 18;
            this.SlblDescripcionDeFalla.Text = "Descripción de Falla :";
            // 
            // SlblTipoDiagnostico
            // 
            this.SlblTipoDiagnostico.AutoSize = true;
            this.SlblTipoDiagnostico.ForeColor = System.Drawing.Color.Black;
            this.SlblTipoDiagnostico.Location = new System.Drawing.Point(59, 408);
            this.SlblTipoDiagnostico.Name = "SlblTipoDiagnostico";
            this.SlblTipoDiagnostico.Size = new System.Drawing.Size(213, 22);
            this.SlblTipoDiagnostico.TabIndex = 17;
            this.SlblTipoDiagnostico.Text = "Tipo de Diagnóstico : ";
            // 
            // SlblTotal
            // 
            this.SlblTotal.AutoSize = true;
            this.SlblTotal.ForeColor = System.Drawing.Color.Black;
            this.SlblTotal.Location = new System.Drawing.Point(81, 542);
            this.SlblTotal.Name = "SlblTotal";
            this.SlblTotal.Size = new System.Drawing.Size(73, 22);
            this.SlblTotal.TabIndex = 13;
            this.SlblTotal.Text = "Total : ";
            // 
            // SlblAnticipo
            // 
            this.SlblAnticipo.AutoSize = true;
            this.SlblAnticipo.ForeColor = System.Drawing.Color.Black;
            this.SlblAnticipo.Location = new System.Drawing.Point(81, 585);
            this.SlblAnticipo.Name = "SlblAnticipo";
            this.SlblAnticipo.Size = new System.Drawing.Size(103, 22);
            this.SlblAnticipo.TabIndex = 12;
            this.SlblAnticipo.Text = "Anticipo : ";
            // 
            // SlblDatosEquipo
            // 
            this.SlblDatosEquipo.AutoSize = true;
            this.SlblDatosEquipo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlblDatosEquipo.ForeColor = System.Drawing.Color.Black;
            this.SlblDatosEquipo.Location = new System.Drawing.Point(1, 186);
            this.SlblDatosEquipo.Name = "SlblDatosEquipo";
            this.SlblDatosEquipo.Size = new System.Drawing.Size(204, 29);
            this.SlblDatosEquipo.TabIndex = 11;
            this.SlblDatosEquipo.Text = "Datos de Equipo";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.Location = new System.Drawing.Point(1110, 124);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(132, 33);
            this.btnAgregarCliente.TabIndex = 10;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // SlblCorreo
            // 
            this.SlblCorreo.AutoSize = true;
            this.SlblCorreo.ForeColor = System.Drawing.Color.Black;
            this.SlblCorreo.Location = new System.Drawing.Point(598, 121);
            this.SlblCorreo.Name = "SlblCorreo";
            this.SlblCorreo.Size = new System.Drawing.Size(92, 22);
            this.SlblCorreo.TabIndex = 6;
            this.SlblCorreo.Text = "Correo : ";
            // 
            // SlblTelefono
            // 
            this.SlblTelefono.AutoSize = true;
            this.SlblTelefono.ForeColor = System.Drawing.Color.Black;
            this.SlblTelefono.Location = new System.Drawing.Point(598, 69);
            this.SlblTelefono.Name = "SlblTelefono";
            this.SlblTelefono.Size = new System.Drawing.Size(103, 22);
            this.SlblTelefono.TabIndex = 5;
            this.SlblTelefono.Text = "Teléfono :";
            // 
            // SlblNombre
            // 
            this.SlblNombre.AutoSize = true;
            this.SlblNombre.ForeColor = System.Drawing.Color.Black;
            this.SlblNombre.Location = new System.Drawing.Point(172, 69);
            this.SlblNombre.Name = "SlblNombre";
            this.SlblNombre.Size = new System.Drawing.Size(95, 22);
            this.SlblNombre.TabIndex = 4;
            this.SlblNombre.Text = "Nombre :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-46, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1440, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "_________________________________________________________________________________" +
    "_________________________________________________";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(509, 19);
            this.txtBuscarCliente.Multiline = true;
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(359, 29);
            this.txtBuscarCliente.TabIndex = 2;
            // 
            // SlbBuscarCliente
            // 
            this.SlbBuscarCliente.AutoSize = true;
            this.SlbBuscarCliente.Location = new System.Drawing.Point(357, 22);
            this.SlbBuscarCliente.Name = "SlbBuscarCliente";
            this.SlbBuscarCliente.Size = new System.Drawing.Size(146, 22);
            this.SlbBuscarCliente.TabIndex = 1;
            this.SlbBuscarCliente.Text = "Buscar Cliente";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.logoUp;
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tabReparacion
            // 
            this.tabReparacion.Location = new System.Drawing.Point(4, 31);
            this.tabReparacion.Name = "tabReparacion";
            this.tabReparacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabReparacion.Size = new System.Drawing.Size(1328, 681);
            this.tabReparacion.TabIndex = 2;
            this.tabReparacion.Text = "Reparación";
            this.tabReparacion.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1328, 681);
            this.tabPage2.TabIndex = 3;
            // 
            // UnaLabel
            // 
            this.UnaLabel.Location = new System.Drawing.Point(0, 0);
            this.UnaLabel.Name = "UnaLabel";
            this.UnaLabel.Size = new System.Drawing.Size(100, 23);
            this.UnaLabel.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.Name = "Column5";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // id_Orden
            // 
            this.id_Orden.HeaderText = "ID";
            this.id_Orden.Name = "id_Orden";
            // 
            // Description
            // 
            this.Description.HeaderText = "Descripción";
            this.Description.Name = "Description";
            // 
            // Status
            // 
            this.Status.HeaderText = "Estado";
            this.Status.Name = "Status";
            // 
            // idReparacion
            // 
            this.idReparacion.HeaderText = "ID reparación";
            this.idReparacion.Name = "idReparacion";
            // 
            // linkCerrarSesion
            // 
            this.linkCerrarSesion.AutoSize = true;
            this.linkCerrarSesion.Location = new System.Drawing.Point(1261, 715);
            this.linkCerrarSesion.Name = "linkCerrarSesion";
            this.linkCerrarSesion.Size = new System.Drawing.Size(73, 13);
            this.linkCerrarSesion.TabIndex = 1;
            this.linkCerrarSesion.TabStop = true;
            this.linkCerrarSesion.Text = "Cerrar Sesión.";
            this.linkCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCerrarSesion_LinkClicked);
            // 
            // ViewTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 734);
            this.Controls.Add(this.linkCerrarSesion);
            this.Controls.Add(this.tabPuntoVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewTabs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UP - Software";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabPuntoVenta.ResumeLayout(false);
            this.tabVenta.ResumeLayout(false);
            this.tabVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabRecibirEquipo.ResumeLayout(false);
            this.tabRecibirEquipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPuntoVenta;
        private System.Windows.Forms.TabPage tabVenta;
        private System.Windows.Forms.TabPage tabRecibirEquipo;
        private System.Windows.Forms.TabPage tabReparacion;
        //private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label UnaLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        //private System.Windows.Forms.TabPage tabPage1;
        //private System.Windows.Forms.DataGridView dataGridView1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idResponsable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReparacion;
        private System.Windows.Forms.LinkLabel linkCerrarSesion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label SlbBuscarCliente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Label SlblCorreo;
        private System.Windows.Forms.Label SlblTelefono;
        private System.Windows.Forms.Label SlblNombre;
        private System.Windows.Forms.Button btnPedirPieza;
        private System.Windows.Forms.Button btnAgregrEquipos;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.ComboBox comboResponsable;
        private System.Windows.Forms.TextBox txtAnticipo;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label SlblResponsable;
        private System.Windows.Forms.TextBox txtDescripcionDiagnosticoEspecifico;
        private System.Windows.Forms.RadioButton rbDiagnosticoEspecifico;
        private System.Windows.Forms.RadioButton rbDiagnosticoRapido;
        private System.Windows.Forms.TextBox txtDescripcionDeFalla;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label SlblIdEquipo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label SlblMarca;
        private System.Windows.Forms.Label SlblModelo;
        private System.Windows.Forms.Label SlblDescripcionDeFalla;
        private System.Windows.Forms.Label SlblTipoDiagnostico;
        private System.Windows.Forms.Label SlblTotal;
        private System.Windows.Forms.Label SlblAnticipo;
        private System.Windows.Forms.Label SlblDatosEquipo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label SlblApellido;
        private System.Windows.Forms.PictureBox pictureBuscar;
       // private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
      //  private System.Windows.Forms.TextBox textBox1;
        //private System.Windows.Forms.Label UnaLabel;
      //  private System.Windows.Forms.Label label5;
       // private System.Windows.Forms.Label label4;
      /*  private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;*/
    }
}