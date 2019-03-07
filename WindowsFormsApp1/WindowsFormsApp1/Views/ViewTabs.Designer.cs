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
            this.tabRecibirEquipo = new System.Windows.Forms.TabPage();
            this.lblAvisoNoCliente = new System.Windows.Forms.Label();
            this.pictureBuscar = new System.Windows.Forms.PictureBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnPedirPieza = new System.Windows.Forms.Button();
            this.btnAgregrEquipos = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.comboResponsable = new System.Windows.Forms.ComboBox();
            this.txtAnticipo = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDescripcionDiagnosticoEspecifico = new System.Windows.Forms.TextBox();
            this.rbDiagnosticoEspecifico = new System.Windows.Forms.RadioButton();
            this.rbDiagnosticoRapido = new System.Windows.Forms.RadioButton();
            this.txtDescripcionDeFalla = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabReparacion = new System.Windows.Forms.TabPage();
            this.JdataGridRep = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMArca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JTerminados = new System.Windows.Forms.RadioButton();
            this.JPendientes = new System.Windows.Forms.RadioButton();
            this.JradioTodos = new System.Windows.Forms.RadioButton();
            this.Jtxtbuscar = new System.Windows.Forms.TextBox();
            this.JlblBuscar = new System.Windows.Forms.Label();
            this.JPicture = new System.Windows.Forms.PictureBox();
            this.JpictureBox = new System.Windows.Forms.PictureBox();
            this.tabConfiguracionesDeUsuario = new System.Windows.Forms.TabPage();
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
            this.tabRecibirEquipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBuscar)).BeginInit();
            this.tabReparacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JdataGridRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPuntoVenta
            // 
            this.tabPuntoVenta.Controls.Add(this.tabVenta);
            this.tabPuntoVenta.Controls.Add(this.tabRecibirEquipo);
            this.tabPuntoVenta.Controls.Add(this.tabReparacion);
            this.tabPuntoVenta.Controls.Add(this.tabConfiguracionesDeUsuario);
            this.tabPuntoVenta.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tabVenta.Location = new System.Drawing.Point(4, 43);
            this.tabVenta.Name = "tabVenta";
            this.tabVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabVenta.Size = new System.Drawing.Size(1328, 669);
            this.tabVenta.TabIndex = 0;
            this.tabVenta.Text = "Venta";
            this.tabVenta.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1221, 626);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cobrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1105, 626);
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
            this.label3.Location = new System.Drawing.Point(6, 15);
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
            this.label1.Size = new System.Drawing.Size(76, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // tabRecibirEquipo
            // 
            this.tabRecibirEquipo.Controls.Add(this.lblAvisoNoCliente);
            this.tabRecibirEquipo.Controls.Add(this.pictureBuscar);
            this.tabRecibirEquipo.Controls.Add(this.txtApellido);
            this.tabRecibirEquipo.Controls.Add(this.txtNombre);
            this.tabRecibirEquipo.Controls.Add(this.txtCorreo);
            this.tabRecibirEquipo.Controls.Add(this.txtTelefono);
            this.tabRecibirEquipo.Controls.Add(this.label14);
            this.tabRecibirEquipo.Controls.Add(this.btnPedirPieza);
            this.tabRecibirEquipo.Controls.Add(this.btnAgregrEquipos);
            this.tabRecibirEquipo.Controls.Add(this.btnLimpiarCampos);
            this.tabRecibirEquipo.Controls.Add(this.comboResponsable);
            this.tabRecibirEquipo.Controls.Add(this.txtAnticipo);
            this.tabRecibirEquipo.Controls.Add(this.txtTotal);
            this.tabRecibirEquipo.Controls.Add(this.label15);
            this.tabRecibirEquipo.Controls.Add(this.txtDescripcionDiagnosticoEspecifico);
            this.tabRecibirEquipo.Controls.Add(this.rbDiagnosticoEspecifico);
            this.tabRecibirEquipo.Controls.Add(this.rbDiagnosticoRapido);
            this.tabRecibirEquipo.Controls.Add(this.txtDescripcionDeFalla);
            this.tabRecibirEquipo.Controls.Add(this.txtModelo);
            this.tabRecibirEquipo.Controls.Add(this.txtMarca);
            this.tabRecibirEquipo.Controls.Add(this.label22);
            this.tabRecibirEquipo.Controls.Add(this.lblId);
            this.tabRecibirEquipo.Controls.Add(this.label20);
            this.tabRecibirEquipo.Controls.Add(this.label19);
            this.tabRecibirEquipo.Controls.Add(this.label18);
            this.tabRecibirEquipo.Controls.Add(this.label17);
            this.tabRecibirEquipo.Controls.Add(this.label13);
            this.tabRecibirEquipo.Controls.Add(this.label12);
            this.tabRecibirEquipo.Controls.Add(this.label11);
            this.tabRecibirEquipo.Controls.Add(this.btnAgregarCliente);
            this.tabRecibirEquipo.Controls.Add(this.label10);
            this.tabRecibirEquipo.Controls.Add(this.label9);
            this.tabRecibirEquipo.Controls.Add(this.label8);
            this.tabRecibirEquipo.Controls.Add(this.label7);
            this.tabRecibirEquipo.Controls.Add(this.txtBuscarCliente);
            this.tabRecibirEquipo.Controls.Add(this.label2);
            this.tabRecibirEquipo.Location = new System.Drawing.Point(4, 43);
            this.tabRecibirEquipo.Name = "tabRecibirEquipo";
            this.tabRecibirEquipo.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecibirEquipo.Size = new System.Drawing.Size(1328, 669);
            this.tabRecibirEquipo.TabIndex = 1;
            this.tabRecibirEquipo.Text = "Recibir Equipo";
            this.tabRecibirEquipo.UseVisualStyleBackColor = true;
            // 
            // lblAvisoNoCliente
            // 
            this.lblAvisoNoCliente.AutoSize = true;
            this.lblAvisoNoCliente.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoNoCliente.Location = new System.Drawing.Point(917, 14);
            this.lblAvisoNoCliente.Name = "lblAvisoNoCliente";
            this.lblAvisoNoCliente.Size = new System.Drawing.Size(190, 34);
            this.lblAvisoNoCliente.TabIndex = 43;
            this.lblAvisoNoCliente.Text = "No se econtró cliente.";
            this.lblAvisoNoCliente.Visible = false;
            // 
            // pictureBuscar
            // 
            this.pictureBuscar.Image = global::WindowsFormsApp1.Properties.Resources.lupa;
            this.pictureBuscar.Location = new System.Drawing.Point(874, 18);
            this.pictureBuscar.Name = "pictureBuscar";
            this.pictureBuscar.Size = new System.Drawing.Size(30, 30);
            this.pictureBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBuscar.TabIndex = 42;
            this.pictureBuscar.TabStop = false;
            this.pictureBuscar.Click += new System.EventHandler(this.pictureBuscar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(269, 121);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(313, 29);
            this.txtApellido.TabIndex = 41;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(269, 66);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(313, 29);
            this.txtNombre.TabIndex = 40;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(707, 121);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(313, 29);
            this.txtCorreo.TabIndex = 39;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(707, 66);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(313, 29);
            this.txtTelefono.TabIndex = 38;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(185, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 34);
            this.label14.TabIndex = 36;
            this.label14.Text = "Apellido :";
            // 
            // btnPedirPieza
            // 
            this.btnPedirPieza.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPedirPieza.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedirPieza.Location = new System.Drawing.Point(877, 621);
            this.btnPedirPieza.Name = "btnPedirPieza";
            this.btnPedirPieza.Size = new System.Drawing.Size(132, 43);
            this.btnPedirPieza.TabIndex = 35;
            this.btnPedirPieza.Text = "Pedir Pieza";
            this.btnPedirPieza.UseVisualStyleBackColor = false;
            this.btnPedirPieza.Click += new System.EventHandler(this.btnPedirPieza_Click);
            // 
            // btnAgregrEquipos
            // 
            this.btnAgregrEquipos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregrEquipos.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregrEquipos.Location = new System.Drawing.Point(1015, 621);
            this.btnAgregrEquipos.Name = "btnAgregrEquipos";
            this.btnAgregrEquipos.Size = new System.Drawing.Size(132, 43);
            this.btnAgregrEquipos.TabIndex = 34;
            this.btnAgregrEquipos.Text = "Agregar Equipo";
            this.btnAgregrEquipos.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(1153, 621);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(132, 43);
            this.btnLimpiarCampos.TabIndex = 33;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // comboResponsable
            // 
            this.comboResponsable.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboResponsable.FormattingEnabled = true;
            this.comboResponsable.Location = new System.Drawing.Point(269, 621);
            this.comboResponsable.Name = "comboResponsable";
            this.comboResponsable.Size = new System.Drawing.Size(207, 34);
            this.comboResponsable.TabIndex = 32;
            // 
            // txtAnticipo
            // 
            this.txtAnticipo.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnticipo.Location = new System.Drawing.Point(269, 582);
            this.txtAnticipo.Multiline = true;
            this.txtAnticipo.Name = "txtAnticipo";
            this.txtAnticipo.Size = new System.Drawing.Size(207, 29);
            this.txtAnticipo.TabIndex = 31;
            this.txtAnticipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnticipo_KeyPress);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(269, 542);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(207, 29);
            this.txtTotal.TabIndex = 30;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(81, 631);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 34);
            this.label15.TabIndex = 29;
            this.label15.Text = "Responsable : ";
            // 
            // txtDescripcionDiagnosticoEspecifico
            // 
            this.txtDescripcionDiagnosticoEspecifico.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.rbDiagnosticoEspecifico.Size = new System.Drawing.Size(123, 38);
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
            this.rbDiagnosticoRapido.Size = new System.Drawing.Size(93, 38);
            this.rbDiagnosticoRapido.TabIndex = 26;
            this.rbDiagnosticoRapido.TabStop = true;
            this.rbDiagnosticoRapido.Text = "Rápido.";
            this.rbDiagnosticoRapido.UseVisualStyleBackColor = true;
            // 
            // txtDescripcionDeFalla
            // 
            this.txtDescripcionDeFalla.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionDeFalla.Location = new System.Drawing.Point(276, 345);
            this.txtDescripcionDeFalla.Multiline = true;
            this.txtDescripcionDeFalla.Name = "txtDescripcionDeFalla";
            this.txtDescripcionDeFalla.Size = new System.Drawing.Size(726, 37);
            this.txtDescripcionDeFalla.TabIndex = 25;
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(276, 295);
            this.txtModelo.Multiline = true;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(726, 29);
            this.txtModelo.TabIndex = 24;
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(276, 246);
            this.txtMarca.Multiline = true;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(726, 29);
            this.txtMarca.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(1039, 186);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(132, 34);
            this.label22.TabIndex = 22;
            this.label22.Text = "ID de Equipo : ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblId.Location = new System.Drawing.Point(1167, 186);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(55, 34);
            this.lblId.TabIndex = 21;
            this.lblId.Text = "0000";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(59, 253);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 34);
            this.label20.TabIndex = 20;
            this.label20.Text = "Marca :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(59, 298);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 34);
            this.label19.TabIndex = 19;
            this.label19.Text = "Modelo :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(59, 348);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(188, 34);
            this.label18.TabIndex = 18;
            this.label18.Text = "Descripción de Falla :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(59, 408);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(188, 34);
            this.label17.TabIndex = 17;
            this.label17.Text = "Tipo de Diagnóstico : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(81, 542);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 34);
            this.label13.TabIndex = 13;
            this.label13.Text = "Total : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(81, 585);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 34);
            this.label12.TabIndex = 12;
            this.label12.Text = "Anticipo : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(1, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 29);
            this.label11.TabIndex = 11;
            this.label11.Text = "Datos de Equipo";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.Location = new System.Drawing.Point(1112, 119);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(120, 38);
            this.btnAgregarCliente.TabIndex = 10;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Visible = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(617, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 34);
            this.label10.TabIndex = 6;
            this.label10.Text = "Correo : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(607, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 34);
            this.label9.TabIndex = 5;
            this.label9.Text = "Teléfono :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(185, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 34);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nombre :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-46, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1383, 34);
            this.label7.TabIndex = 3;
            this.label7.Text = "_________________________________________________________________________________" +
    "_______________________________________________________________________";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(509, 19);
            this.txtBuscarCliente.Multiline = true;
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(359, 29);
            this.txtBuscarCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar Cliente";
            // 
            // tabReparacion
            // 
            this.tabReparacion.Controls.Add(this.JdataGridRep);
            this.tabReparacion.Controls.Add(this.JTerminados);
            this.tabReparacion.Controls.Add(this.JPendientes);
            this.tabReparacion.Controls.Add(this.JradioTodos);
            this.tabReparacion.Controls.Add(this.Jtxtbuscar);
            this.tabReparacion.Controls.Add(this.JlblBuscar);
            this.tabReparacion.Controls.Add(this.JPicture);
            this.tabReparacion.Controls.Add(this.JpictureBox);
            this.tabReparacion.Location = new System.Drawing.Point(4, 43);
            this.tabReparacion.Name = "tabReparacion";
            this.tabReparacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabReparacion.Size = new System.Drawing.Size(1328, 669);
            this.tabReparacion.TabIndex = 2;
            this.tabReparacion.Text = "Reparación";
            this.tabReparacion.UseVisualStyleBackColor = true;
            this.tabReparacion.Click += new System.EventHandler(this.tabReparacion_Click);
            // 
            // JdataGridRep
            // 
            this.JdataGridRep.AllowUserToAddRows = false;
            this.JdataGridRep.AllowUserToDeleteRows = false;
            this.JdataGridRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JdataGridRep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.JMArca,
            this.JModelo,
            this.JCliente,
            this.JEstado});
            this.JdataGridRep.Location = new System.Drawing.Point(172, 260);
            this.JdataGridRep.Name = "JdataGridRep";
            this.JdataGridRep.ReadOnly = true;
            this.JdataGridRep.Size = new System.Drawing.Size(915, 317);
            this.JdataGridRep.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 200;
            // 
            // JMArca
            // 
            this.JMArca.HeaderText = "Marca";
            this.JMArca.Name = "JMArca";
            this.JMArca.ReadOnly = true;
            this.JMArca.Width = 150;
            // 
            // JModelo
            // 
            this.JModelo.HeaderText = "Modelo";
            this.JModelo.Name = "JModelo";
            this.JModelo.ReadOnly = true;
            this.JModelo.Width = 150;
            // 
            // JCliente
            // 
            this.JCliente.HeaderText = "Cliente";
            this.JCliente.Name = "JCliente";
            this.JCliente.ReadOnly = true;
            this.JCliente.Width = 225;
            // 
            // JEstado
            // 
            this.JEstado.HeaderText = "Estado";
            this.JEstado.Name = "JEstado";
            this.JEstado.ReadOnly = true;
            this.JEstado.Width = 150;
            // 
            // JTerminados
            // 
            this.JTerminados.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JTerminados.Location = new System.Drawing.Point(590, 180);
            this.JTerminados.Name = "JTerminados";
            this.JTerminados.Size = new System.Drawing.Size(124, 37);
            this.JTerminados.TabIndex = 6;
            this.JTerminados.TabStop = true;
            this.JTerminados.Text = "Terminado";
            this.JTerminados.UseVisualStyleBackColor = true;
            // 
            // JPendientes
            // 
            this.JPendientes.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JPendientes.Location = new System.Drawing.Point(464, 180);
            this.JPendientes.Name = "JPendientes";
            this.JPendientes.Size = new System.Drawing.Size(120, 43);
            this.JPendientes.TabIndex = 5;
            this.JPendientes.TabStop = true;
            this.JPendientes.Text = "Pendientes";
            this.JPendientes.UseVisualStyleBackColor = true;
            // 
            // JradioTodos
            // 
            this.JradioTodos.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JradioTodos.Location = new System.Drawing.Point(374, 180);
            this.JradioTodos.Name = "JradioTodos";
            this.JradioTodos.Size = new System.Drawing.Size(84, 43);
            this.JradioTodos.TabIndex = 4;
            this.JradioTodos.TabStop = true;
            this.JradioTodos.Text = "Todos";
            this.JradioTodos.UseVisualStyleBackColor = true;
            // 
            // Jtxtbuscar
            // 
            this.Jtxtbuscar.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jtxtbuscar.Location = new System.Drawing.Point(434, 78);
            this.Jtxtbuscar.Name = "Jtxtbuscar";
            this.Jtxtbuscar.Size = new System.Drawing.Size(313, 34);
            this.Jtxtbuscar.TabIndex = 2;
            // 
            // JlblBuscar
            // 
            this.JlblBuscar.AutoSize = true;
            this.JlblBuscar.Location = new System.Drawing.Point(365, 78);
            this.JlblBuscar.Name = "JlblBuscar";
            this.JlblBuscar.Size = new System.Drawing.Size(71, 34);
            this.JlblBuscar.TabIndex = 1;
            this.JlblBuscar.Text = "Buscar";
            // 
            // JPicture
            // 
            this.JPicture.Image = global::WindowsFormsApp1.Properties.Resources.lupa;
            this.JPicture.Location = new System.Drawing.Point(753, 82);
            this.JPicture.Name = "JPicture";
            this.JPicture.Size = new System.Drawing.Size(30, 30);
            this.JPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.JPicture.TabIndex = 3;
            this.JPicture.TabStop = false;
            // 
            // JpictureBox
            // 
            this.JpictureBox.Image = global::WindowsFormsApp1.Properties.Resources.logoUp1;
            this.JpictureBox.Location = new System.Drawing.Point(0, 0);
            this.JpictureBox.Name = "JpictureBox";
            this.JpictureBox.Size = new System.Drawing.Size(118, 177);
            this.JpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.JpictureBox.TabIndex = 0;
            this.JpictureBox.TabStop = false;
            this.JpictureBox.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // tabConfiguracionesDeUsuario
            // 
            this.tabConfiguracionesDeUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabConfiguracionesDeUsuario.Location = new System.Drawing.Point(4, 43);
            this.tabConfiguracionesDeUsuario.Name = "tabConfiguracionesDeUsuario";
            this.tabConfiguracionesDeUsuario.Size = new System.Drawing.Size(1328, 669);
            this.tabConfiguracionesDeUsuario.TabIndex = 3;
            this.tabConfiguracionesDeUsuario.Text = "Configuraciones de Usuario";
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
            this.linkCerrarSesion.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCerrarSesion.Location = new System.Drawing.Point(1230, 715);
            this.linkCerrarSesion.Name = "linkCerrarSesion";
            this.linkCerrarSesion.Size = new System.Drawing.Size(101, 26);
            this.linkCerrarSesion.TabIndex = 1;
            this.linkCerrarSesion.TabStop = true;
            this.linkCerrarSesion.Text = "Cerrar Sesión";
            this.linkCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCerrarSesion_LinkClicked);
            // 
            // ViewTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 756);
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
            this.tabRecibirEquipo.ResumeLayout(false);
            this.tabRecibirEquipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBuscar)).EndInit();
            this.tabReparacion.ResumeLayout(false);
            this.tabReparacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JdataGridRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JpictureBox)).EndInit();
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
        private System.Windows.Forms.TabPage tabConfiguracionesDeUsuario;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReparacion;
        private System.Windows.Forms.LinkLabel linkCerrarSesion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPedirPieza;
        private System.Windows.Forms.Button btnAgregrEquipos;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.ComboBox comboResponsable;
        private System.Windows.Forms.TextBox txtAnticipo;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDescripcionDiagnosticoEspecifico;
        private System.Windows.Forms.RadioButton rbDiagnosticoEspecifico;
        private System.Windows.Forms.RadioButton rbDiagnosticoRapido;
        private System.Windows.Forms.TextBox txtDescripcionDeFalla;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label14;
       // private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox JpictureBox;
        private System.Windows.Forms.PictureBox JPicture;
        private System.Windows.Forms.TextBox Jtxtbuscar;
        private System.Windows.Forms.Label JlblBuscar;
        private System.Windows.Forms.RadioButton JTerminados;
        private System.Windows.Forms.RadioButton JPendientes;
        private System.Windows.Forms.RadioButton JradioTodos;
        private System.Windows.Forms.DataGridView JdataGridRep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMArca;
        private System.Windows.Forms.DataGridViewTextBoxColumn JModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn JCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn JEstado;
        private System.Windows.Forms.Label lblAvisoNoCliente;
        private System.Windows.Forms.PictureBox pictureBuscar;
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