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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTabs));
            this.tabPuntoVenta = new System.Windows.Forms.TabControl();
            this.tabVenta = new System.Windows.Forms.TabPage();
            this.ventaLogoCh = new System.Windows.Forms.PictureBox();
            this.ClblCodigoDeBarras = new System.Windows.Forms.Label();
            this.CNombreUsuarioLblVenta = new System.Windows.Forms.Label();
            this.totalTbxVenta = new System.Windows.Forms.TextBox();
            this.ivaTbxVentas = new System.Windows.Forms.TextBox();
            this.subTotalTbxVentas = new System.Windows.Forms.TextBox();
            this.totalLblVentas = new System.Windows.Forms.Label();
            this.ivaLblVenta = new System.Windows.Forms.Label();
            this.subTotalLblVenta = new System.Windows.Forms.Label();
            this.buscarTbxVentas = new System.Windows.Forms.TextBox();
            this.tableVender = new System.Windows.Forms.DataGridView();
            this.codClmVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantClVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrClmVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUClmVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTClmVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CbtnCobrarVenta = new System.Windows.Forms.Button();
            this.CbtnCancelarVenta = new System.Windows.Forms.Button();
            this.usuarioLblVenta = new System.Windows.Forms.Label();
            this.tabRecibirEquipo = new System.Windows.Forms.TabPage();
            this.layoutTotales = new System.Windows.Forms.TableLayoutPanel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SlblTotal = new System.Windows.Forms.Label();
            this.SlblAnticipo = new System.Windows.Forms.Label();
            this.txtAnticipo = new System.Windows.Forms.TextBox();
            this.SlblResponsable = new System.Windows.Forms.Label();
            this.comboResponsable = new System.Windows.Forms.ComboBox();
            this.EquipoGbx = new System.Windows.Forms.GroupBox();
            this.LayEquipo = new System.Windows.Forms.TableLayoutPanel();
            this.SlblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.SlblModelo = new System.Windows.Forms.Label();
            this.ccbTipoServicio1 = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.tiposervicioC1 = new System.Windows.Forms.Label();
            this.SlblDescripcionFalla = new System.Windows.Forms.Label();
            this.txtDescripcionDeFalla = new System.Windows.Forms.TextBox();
            this.SbtnNuevoServicioRE = new System.Windows.Forms.Button();
            this.lblIdEquipo = new System.Windows.Forms.Label();
            this.SlblRecibirEquipo = new System.Windows.Forms.Label();
            this.txtDescripcionDiagnosticoEspecifico = new System.Windows.Forms.TextBox();
            this.rbDiagnosticoEspecifico = new System.Windows.Forms.RadioButton();
            this.rbDiagnosticoRapido = new System.Windows.Forms.RadioButton();
            this.SlblTipoDeDiagnostico = new System.Windows.Forms.Label();
            this.ClienteGBx = new System.Windows.Forms.GroupBox();
            this.layCliente = new System.Windows.Forms.FlowLayoutPanel();
            this.SlblBuscarCliente = new System.Windows.Forms.Label();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            //this.pictureBuscar = new System.Windows.Forms.PictureBox();
            this.lblAvisoNoCliente = new System.Windows.Forms.Label();
            this.layoutCliente = new System.Windows.Forms.TableLayoutPanel();
            this.SlblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SlblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.SlblTelefono = new System.Windows.Forms.Label();
            this.SlblCorreo = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.SbtnCancelar = new System.Windows.Forms.Button();
            this.btnAddClientH = new System.Windows.Forms.Button();
            this.lblTextoIdCliente = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnPedirPieza = new System.Windows.Forms.Button();
            this.btnAgregrEquipos = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.recibirLogoCh = new System.Windows.Forms.PictureBox();
            this.tabReparacion = new System.Windows.Forms.TabPage();
            this.refresIconCheno = new System.Windows.Forms.PictureBox();
            this.pBoxBuscarRep = new System.Windows.Forms.PictureBox();
            this.reparacionLogoCh = new System.Windows.Forms.PictureBox();
            this.JtxtBuscar2 = new System.Windows.Forms.TextBox();
            this.CDGReparacion = new System.Windows.Forms.DataGridView();
            this.CEspera = new System.Windows.Forms.RadioButton();
            this.JTerminados = new System.Windows.Forms.RadioButton();
            this.JProceso = new System.Windows.Forms.RadioButton();
            this.JradioTodos = new System.Windows.Forms.RadioButton();
            this.JlblBuscar = new System.Windows.Forms.Label();
            this.tabConfiguracionesDeUsuario = new System.Windows.Forms.TabPage();
            this.SgbConfiguraciones = new System.Windows.Forms.GroupBox();
            this.SbtnAgregarNuevoServicioCU = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SbtnAgregarUsuario = new System.Windows.Forms.Button();
            this.SgbAsignarRolATrabajador = new System.Windows.Forms.GroupBox();
            this.SbtnAsiganrRolAUsuario = new System.Windows.Forms.Button();
            this.SlblSeleccioneRol = new System.Windows.Forms.Label();
            this.ScbxSeleccionarRol = new System.Windows.Forms.ComboBox();
            this.ScbxUsuariosRol = new System.Windows.Forms.ComboBox();
            this.SlblSeleccioneNombreDeUsuario = new System.Windows.Forms.Label();
            this.SgbRoles = new System.Windows.Forms.GroupBox();
            this.StxtRol = new System.Windows.Forms.TextBox();
            this.SlblNombreRol = new System.Windows.Forms.Label();
            this.SbtnGuardarRol = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ordenesTab = new System.Windows.Forms.TabPage();
            this.SlblPiezasOrdenadas = new System.Windows.Forms.Label();
            this.tableOrdenes = new System.Windows.Forms.DataGridView();
            this.ordenesLogoCh = new System.Windows.Forms.PictureBox();
            this.TabClientes = new System.Windows.Forms.TabPage();
            this.layBuscarCliente = new System.Windows.Forms.FlowLayoutPanel();
            this.lblClienteBuscar = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.ClientesLogoCh = new System.Windows.Forms.PictureBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techPOSdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techPOSdbDataSet = new WindowsFormsApp1.TechPOSdbDataSet();
            this.reparacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.reparacionTableAdapter = new WindowsFormsApp1.TechPOSdbDataSetTableAdapters.ReparacionTableAdapter();
            this.clienteTableAdapter = new WindowsFormsApp1.TechPOSdbDataSetTableAdapters.ClienteTableAdapter();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabPuntoVenta.SuspendLayout();
            this.tabVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventaLogoCh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableVender)).BeginInit();
            this.tabRecibirEquipo.SuspendLayout();
            this.layoutTotales.SuspendLayout();
            this.EquipoGbx.SuspendLayout();
            this.LayEquipo.SuspendLayout();
            this.ClienteGBx.SuspendLayout();
            this.layCliente.SuspendLayout();
           // ((System.ComponentModel.ISupportInitialize)(this.pictureBuscar)).BeginInit();
            this.layoutCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recibirLogoCh)).BeginInit();
            this.tabReparacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresIconCheno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBuscarRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reparacionLogoCh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CDGReparacion)).BeginInit();
            this.tabConfiguracionesDeUsuario.SuspendLayout();
            this.SgbConfiguraciones.SuspendLayout();
            this.SgbAsignarRolATrabajador.SuspendLayout();
            this.SgbRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.ordenesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableOrdenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesLogoCh)).BeginInit();
            this.TabClientes.SuspendLayout();
            this.layBuscarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesLogoCh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techPOSdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techPOSdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reparacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPuntoVenta
            // 
            this.tabPuntoVenta.Controls.Add(this.tabVenta);
            this.tabPuntoVenta.Controls.Add(this.tabRecibirEquipo);
            this.tabPuntoVenta.Controls.Add(this.tabReparacion);
            this.tabPuntoVenta.Controls.Add(this.tabConfiguracionesDeUsuario);
            this.tabPuntoVenta.Controls.Add(this.ordenesTab);
            this.tabPuntoVenta.Controls.Add(this.TabClientes);
            this.tabPuntoVenta.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPuntoVenta.Location = new System.Drawing.Point(2, 0);
            this.tabPuntoVenta.Name = "tabPuntoVenta";
            this.tabPuntoVenta.SelectedIndex = 0;
            this.tabPuntoVenta.Size = new System.Drawing.Size(1336, 716);
            this.tabPuntoVenta.TabIndex = 0;
            this.tabPuntoVenta.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabPuntoVenta_DrawItem);
            this.tabPuntoVenta.SelectedIndexChanged += new System.EventHandler(this.tabPuntoVenta_SelectedIndexChanged);
            // 
            // tabVenta
            // 
            this.tabVenta.BackColor = System.Drawing.Color.LightGray;
            this.tabVenta.Controls.Add(this.ventaLogoCh);
            this.tabVenta.Controls.Add(this.ClblCodigoDeBarras);
            this.tabVenta.Controls.Add(this.CNombreUsuarioLblVenta);
            this.tabVenta.Controls.Add(this.totalTbxVenta);
            this.tabVenta.Controls.Add(this.ivaTbxVentas);
            this.tabVenta.Controls.Add(this.subTotalTbxVentas);
            this.tabVenta.Controls.Add(this.totalLblVentas);
            this.tabVenta.Controls.Add(this.ivaLblVenta);
            this.tabVenta.Controls.Add(this.subTotalLblVenta);
            this.tabVenta.Controls.Add(this.buscarTbxVentas);
            this.tabVenta.Controls.Add(this.tableVender);
            this.tabVenta.Controls.Add(this.CbtnCobrarVenta);
            this.tabVenta.Controls.Add(this.CbtnCancelarVenta);
            this.tabVenta.Controls.Add(this.usuarioLblVenta);
            this.tabVenta.Location = new System.Drawing.Point(4, 43);
            this.tabVenta.Name = "tabVenta";
            this.tabVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabVenta.Size = new System.Drawing.Size(1328, 669);
            this.tabVenta.TabIndex = 0;
            this.tabVenta.Text = "Venta";
            // 
            // ventaLogoCh
            // 
            this.ventaLogoCh.Image = global::WindowsFormsApp1.Properties.Resources.logoUp;
            this.ventaLogoCh.Location = new System.Drawing.Point(6, 6);
            this.ventaLogoCh.Name = "ventaLogoCh";
            this.ventaLogoCh.Size = new System.Drawing.Size(118, 177);
            this.ventaLogoCh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ventaLogoCh.TabIndex = 20;
            this.ventaLogoCh.TabStop = false;
            // 
            // ClblCodigoDeBarras
            // 
            this.ClblCodigoDeBarras.AutoSize = true;
            this.ClblCodigoDeBarras.Location = new System.Drawing.Point(295, 59);
            this.ClblCodigoDeBarras.Name = "ClblCodigoDeBarras";
            this.ClblCodigoDeBarras.Size = new System.Drawing.Size(173, 34);
            this.ClblCodigoDeBarras.TabIndex = 19;
            this.ClblCodigoDeBarras.Text = "Codigo de Producto";
            // 
            // CNombreUsuarioLblVenta
            // 
            this.CNombreUsuarioLblVenta.AutoSize = true;
            this.CNombreUsuarioLblVenta.Location = new System.Drawing.Point(1211, 6);
            this.CNombreUsuarioLblVenta.Name = "CNombreUsuarioLblVenta";
            this.CNombreUsuarioLblVenta.Size = new System.Drawing.Size(74, 34);
            this.CNombreUsuarioLblVenta.TabIndex = 18;
            this.CNombreUsuarioLblVenta.Text = "usuario";
            // 
            // totalTbxVenta
            // 
            this.totalTbxVenta.Location = new System.Drawing.Point(281, 616);
            this.totalTbxVenta.Multiline = true;
            this.totalTbxVenta.Name = "totalTbxVenta";
            this.totalTbxVenta.Size = new System.Drawing.Size(210, 34);
            this.totalTbxVenta.TabIndex = 17;
            // 
            // ivaTbxVentas
            // 
            this.ivaTbxVentas.Location = new System.Drawing.Point(281, 567);
            this.ivaTbxVentas.Multiline = true;
            this.ivaTbxVentas.Name = "ivaTbxVentas";
            this.ivaTbxVentas.Size = new System.Drawing.Size(210, 34);
            this.ivaTbxVentas.TabIndex = 16;
            // 
            // subTotalTbxVentas
            // 
            this.subTotalTbxVentas.Location = new System.Drawing.Point(281, 514);
            this.subTotalTbxVentas.Multiline = true;
            this.subTotalTbxVentas.Name = "subTotalTbxVentas";
            this.subTotalTbxVentas.Size = new System.Drawing.Size(210, 34);
            this.subTotalTbxVentas.TabIndex = 15;
            // 
            // totalLblVentas
            // 
            this.totalLblVentas.AutoSize = true;
            this.totalLblVentas.Location = new System.Drawing.Point(185, 619);
            this.totalLblVentas.Name = "totalLblVentas";
            this.totalLblVentas.Size = new System.Drawing.Size(59, 34);
            this.totalLblVentas.TabIndex = 14;
            this.totalLblVentas.Text = "Total:";
            // 
            // ivaLblVenta
            // 
            this.ivaLblVenta.AutoSize = true;
            this.ivaLblVenta.Location = new System.Drawing.Point(185, 570);
            this.ivaLblVenta.Name = "ivaLblVenta";
            this.ivaLblVenta.Size = new System.Drawing.Size(57, 34);
            this.ivaLblVenta.TabIndex = 13;
            this.ivaLblVenta.Text = "I.V.A:";
            // 
            // subTotalLblVenta
            // 
            this.subTotalLblVenta.AutoSize = true;
            this.subTotalLblVenta.Location = new System.Drawing.Point(185, 514);
            this.subTotalLblVenta.Name = "subTotalLblVenta";
            this.subTotalLblVenta.Size = new System.Drawing.Size(90, 34);
            this.subTotalLblVenta.TabIndex = 12;
            this.subTotalLblVenta.Text = "SubTotal:";
            // 
            // buscarTbxVentas
            // 
            this.buscarTbxVentas.Location = new System.Drawing.Point(474, 59);
            this.buscarTbxVentas.Multiline = true;
            this.buscarTbxVentas.Name = "buscarTbxVentas";
            this.buscarTbxVentas.Size = new System.Drawing.Size(405, 32);
            this.buscarTbxVentas.TabIndex = 10;
            this.buscarTbxVentas.TextChanged += new System.EventHandler(this.buscarTbxVentas_TextChanged);
            // 
            // tableVender
            // 
            this.tableVender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableVender.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codClmVenta,
            this.cantClVenta,
            this.descrClmVenta,
            this.precioUClmVenta,
            this.precioTClmVenta});
            this.tableVender.Location = new System.Drawing.Point(191, 110);
            this.tableVender.Name = "tableVender";
            this.tableVender.RowHeadersVisible = false;
            this.tableVender.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableVender.Size = new System.Drawing.Size(938, 382);
            this.tableVender.TabIndex = 8;
            // 
            // codClmVenta
            // 
            this.codClmVenta.HeaderText = "Código";
            this.codClmVenta.Name = "codClmVenta";
            // 
            // cantClVenta
            // 
            this.cantClVenta.HeaderText = "Cantidad";
            this.cantClVenta.Name = "cantClVenta";
            // 
            // descrClmVenta
            // 
            this.descrClmVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descrClmVenta.HeaderText = "Descripción";
            this.descrClmVenta.Name = "descrClmVenta";
            // 
            // precioUClmVenta
            // 
            this.precioUClmVenta.HeaderText = "Precio U.";
            this.precioUClmVenta.Name = "precioUClmVenta";
            this.precioUClmVenta.Width = 125;
            // 
            // precioTClmVenta
            // 
            this.precioTClmVenta.HeaderText = "Precio T.";
            this.precioTClmVenta.Name = "precioTClmVenta";
            this.precioTClmVenta.Width = 125;
            // 
            // CbtnCobrarVenta
            // 
            this.CbtnCobrarVenta.BackColor = System.Drawing.Color.DimGray;
            this.CbtnCobrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbtnCobrarVenta.ForeColor = System.Drawing.Color.White;
            this.CbtnCobrarVenta.Location = new System.Drawing.Point(970, 570);
            this.CbtnCobrarVenta.Name = "CbtnCobrarVenta";
            this.CbtnCobrarVenta.Size = new System.Drawing.Size(159, 37);
            this.CbtnCobrarVenta.TabIndex = 6;
            this.CbtnCobrarVenta.Text = "Cobrar";
            this.CbtnCobrarVenta.UseVisualStyleBackColor = false;
            this.CbtnCobrarVenta.Click += new System.EventHandler(this.CbtnCobrarVenta_Click);
            // 
            // CbtnCancelarVenta
            // 
            this.CbtnCancelarVenta.BackColor = System.Drawing.Color.DimGray;
            this.CbtnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbtnCancelarVenta.ForeColor = System.Drawing.Color.White;
            this.CbtnCancelarVenta.Location = new System.Drawing.Point(970, 613);
            this.CbtnCancelarVenta.Name = "CbtnCancelarVenta";
            this.CbtnCancelarVenta.Size = new System.Drawing.Size(159, 37);
            this.CbtnCancelarVenta.TabIndex = 2;
            this.CbtnCancelarVenta.Text = "Cancelar";
            this.CbtnCancelarVenta.UseVisualStyleBackColor = false;
            this.CbtnCancelarVenta.Click += new System.EventHandler(this.CbtnCancelarVenta_Click);
            // 
            // usuarioLblVenta
            // 
            this.usuarioLblVenta.AutoSize = true;
            this.usuarioLblVenta.Location = new System.Drawing.Point(1090, 6);
            this.usuarioLblVenta.Name = "usuarioLblVenta";
            this.usuarioLblVenta.Size = new System.Drawing.Size(124, 34);
            this.usuarioLblVenta.TabIndex = 4;
            this.usuarioLblVenta.Text = "Bienvenido(a)";
            // 
            // tabRecibirEquipo
            // 
            this.tabRecibirEquipo.BackColor = System.Drawing.Color.LightGray;
            this.tabRecibirEquipo.Controls.Add(this.layoutTotales);
            this.tabRecibirEquipo.Controls.Add(this.EquipoGbx);
            this.tabRecibirEquipo.Controls.Add(this.ClienteGBx);
            this.tabRecibirEquipo.Controls.Add(this.btnPedirPieza);
            this.tabRecibirEquipo.Controls.Add(this.btnAgregrEquipos);
            this.tabRecibirEquipo.Controls.Add(this.btnLimpiarCampos);
            this.tabRecibirEquipo.Controls.Add(this.recibirLogoCh);
            this.tabRecibirEquipo.Location = new System.Drawing.Point(4, 43);
            this.tabRecibirEquipo.Name = "tabRecibirEquipo";
            this.tabRecibirEquipo.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecibirEquipo.Size = new System.Drawing.Size(1328, 669);
            this.tabRecibirEquipo.TabIndex = 1;
            this.tabRecibirEquipo.Text = "Recibir Equipo";
            // 
            // layoutTotales
            // 
            this.layoutTotales.ColumnCount = 2;
            this.layoutTotales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutTotales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutTotales.Controls.Add(this.txtTotal, 1, 0);
            this.layoutTotales.Controls.Add(this.SlblTotal, 0, 0);
            this.layoutTotales.Controls.Add(this.SlblAnticipo, 0, 1);
            this.layoutTotales.Controls.Add(this.txtAnticipo, 1, 1);
            this.layoutTotales.Controls.Add(this.SlblResponsable, 0, 2);
            this.layoutTotales.Controls.Add(this.comboResponsable, 1, 2);
            this.layoutTotales.Location = new System.Drawing.Point(148, 542);
            this.layoutTotales.Name = "layoutTotales";
            this.layoutTotales.RowCount = 3;
            this.layoutTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.33333F));
            this.layoutTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.66667F));
            this.layoutTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.layoutTotales.Size = new System.Drawing.Size(352, 115);
            this.layoutTotales.TabIndex = 54;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(179, 3);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(170, 29);
            this.txtTotal.TabIndex = 30;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // SlblTotal
            // 
            this.SlblTotal.AutoSize = true;
            this.SlblTotal.ForeColor = System.Drawing.Color.Black;
            this.SlblTotal.Location = new System.Drawing.Point(3, 0);
            this.SlblTotal.Name = "SlblTotal";
            this.SlblTotal.Size = new System.Drawing.Size(69, 34);
            this.SlblTotal.TabIndex = 13;
            this.SlblTotal.Text = "Total : ";
            // 
            // SlblAnticipo
            // 
            this.SlblAnticipo.AutoSize = true;
            this.SlblAnticipo.ForeColor = System.Drawing.Color.Black;
            this.SlblAnticipo.Location = new System.Drawing.Point(3, 35);
            this.SlblAnticipo.Name = "SlblAnticipo";
            this.SlblAnticipo.Size = new System.Drawing.Size(94, 34);
            this.SlblAnticipo.TabIndex = 12;
            this.SlblAnticipo.Text = "Anticipo : ";
            // 
            // txtAnticipo
            // 
            this.txtAnticipo.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnticipo.Location = new System.Drawing.Point(179, 38);
            this.txtAnticipo.Multiline = true;
            this.txtAnticipo.Name = "txtAnticipo";
            this.txtAnticipo.Size = new System.Drawing.Size(170, 29);
            this.txtAnticipo.TabIndex = 31;
            this.txtAnticipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnticipo_KeyPress);
            // 
            // SlblResponsable
            // 
            this.SlblResponsable.AutoSize = true;
            this.SlblResponsable.ForeColor = System.Drawing.Color.Black;
            this.SlblResponsable.Location = new System.Drawing.Point(3, 77);
            this.SlblResponsable.Name = "SlblResponsable";
            this.SlblResponsable.Size = new System.Drawing.Size(133, 34);
            this.SlblResponsable.TabIndex = 29;
            this.SlblResponsable.Text = "Responsable : ";
            // 
            // comboResponsable
            // 
            this.comboResponsable.DropDownHeight = 207;
            this.comboResponsable.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboResponsable.FormattingEnabled = true;
            this.comboResponsable.IntegralHeight = false;
            this.comboResponsable.Location = new System.Drawing.Point(179, 80);
            this.comboResponsable.Name = "comboResponsable";
            this.comboResponsable.Size = new System.Drawing.Size(170, 34);
            this.comboResponsable.TabIndex = 32;
            // 
            // EquipoGbx
            // 
            this.EquipoGbx.Controls.Add(this.LayEquipo);
            this.EquipoGbx.Controls.Add(this.lblIdEquipo);
            this.EquipoGbx.Controls.Add(this.SlblRecibirEquipo);
            this.EquipoGbx.Controls.Add(this.txtDescripcionDiagnosticoEspecifico);
            this.EquipoGbx.Controls.Add(this.rbDiagnosticoEspecifico);
            this.EquipoGbx.Controls.Add(this.rbDiagnosticoRapido);
            this.EquipoGbx.Controls.Add(this.SlblTipoDeDiagnostico);
            this.EquipoGbx.Location = new System.Drawing.Point(116, 198);
            this.EquipoGbx.Name = "EquipoGbx";
            this.EquipoGbx.Size = new System.Drawing.Size(1202, 338);
            this.EquipoGbx.TabIndex = 53;
            this.EquipoGbx.TabStop = false;
            this.EquipoGbx.Text = "Equipo";
            // 
            // LayEquipo
            // 
            this.LayEquipo.ColumnCount = 4;
            this.LayEquipo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.33448F));
            this.LayEquipo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.66552F));
            this.LayEquipo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.LayEquipo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.LayEquipo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.LayEquipo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.33448F));
            this.LayEquipo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.66552F));
            this.LayEquipo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.LayEquipo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.LayEquipo.Controls.Add(this.SlblMarca, 0, 0);
            this.LayEquipo.Controls.Add(this.txtMarca, 1, 0);
            this.LayEquipo.Controls.Add(this.SlblModelo, 2, 0);
            this.LayEquipo.Controls.Add(this.ccbTipoServicio1, 1, 1);
            this.LayEquipo.Controls.Add(this.txtModelo, 3, 0);
            this.LayEquipo.Controls.Add(this.tiposervicioC1, 0, 1);
            this.LayEquipo.Controls.Add(this.SlblDescripcionFalla, 0, 2);
            this.LayEquipo.Controls.Add(this.txtDescripcionDeFalla, 1, 2);
            this.LayEquipo.Controls.Add(this.SbtnNuevoServicioRE, 3, 1);
            this.LayEquipo.Location = new System.Drawing.Point(23, 29);
            this.LayEquipo.Name = "LayEquipo";
            this.LayEquipo.RowCount = 3;
            this.LayEquipo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.3299F));
            this.LayEquipo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.6701F));
            this.LayEquipo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.LayEquipo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.3299F));
            this.LayEquipo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.6701F));
            this.LayEquipo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.LayEquipo.Size = new System.Drawing.Size(925, 165);
            this.LayEquipo.TabIndex = 54;
            // 
            // SlblMarca
            // 
            this.SlblMarca.AutoSize = true;
            this.SlblMarca.ForeColor = System.Drawing.Color.Black;
            this.SlblMarca.Location = new System.Drawing.Point(3, 0);
            this.SlblMarca.Name = "SlblMarca";
            this.SlblMarca.Size = new System.Drawing.Size(74, 34);
            this.SlblMarca.TabIndex = 20;
            this.SlblMarca.Text = "Marca :";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(217, 3);
            this.txtMarca.Multiline = true;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(385, 29);
            this.txtMarca.TabIndex = 23;
            // 
            // SlblModelo
            // 
            this.SlblModelo.AutoSize = true;
            this.SlblModelo.ForeColor = System.Drawing.Color.Black;
            this.SlblModelo.Location = new System.Drawing.Point(610, 0);
            this.SlblModelo.Name = "SlblModelo";
            this.SlblModelo.Size = new System.Drawing.Size(82, 34);
            this.SlblModelo.TabIndex = 19;
            this.SlblModelo.Text = "Modelo :";
            // 
            // ccbTipoServicio1
            // 
            this.ccbTipoServicio1.DropDownHeight = 300;
            this.ccbTipoServicio1.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccbTipoServicio1.FormattingEnabled = true;
            this.ccbTipoServicio1.IntegralHeight = false;
            this.ccbTipoServicio1.Location = new System.Drawing.Point(217, 46);
            this.ccbTipoServicio1.Name = "ccbTipoServicio1";
            this.ccbTipoServicio1.Size = new System.Drawing.Size(385, 42);
            this.ccbTipoServicio1.TabIndex = 46;
            this.ccbTipoServicio1.SelectedIndexChanged += new System.EventHandler(this.ccbTipoServicio1_SelectedIndexChanged);
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(702, 3);
            this.txtModelo.Multiline = true;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(220, 29);
            this.txtModelo.TabIndex = 24;
            // 
            // tiposervicioC1
            // 
            this.tiposervicioC1.AutoSize = true;
            this.tiposervicioC1.Location = new System.Drawing.Point(3, 43);
            this.tiposervicioC1.Name = "tiposervicioC1";
            this.tiposervicioC1.Size = new System.Drawing.Size(145, 34);
            this.tiposervicioC1.TabIndex = 45;
            this.tiposervicioC1.Text = "Tipo de servicio:";
            // 
            // SlblDescripcionFalla
            // 
            this.SlblDescripcionFalla.AutoSize = true;
            this.SlblDescripcionFalla.ForeColor = System.Drawing.Color.Black;
            this.SlblDescripcionFalla.Location = new System.Drawing.Point(3, 97);
            this.SlblDescripcionFalla.Name = "SlblDescripcionFalla";
            this.SlblDescripcionFalla.Size = new System.Drawing.Size(188, 34);
            this.SlblDescripcionFalla.TabIndex = 18;
            this.SlblDescripcionFalla.Text = "Descripción de Falla :";
            // 
            // txtDescripcionDeFalla
            // 
            this.txtDescripcionDeFalla.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionDeFalla.Location = new System.Drawing.Point(217, 100);
            this.txtDescripcionDeFalla.Multiline = true;
            this.txtDescripcionDeFalla.Name = "txtDescripcionDeFalla";
            this.txtDescripcionDeFalla.Size = new System.Drawing.Size(385, 37);
            this.txtDescripcionDeFalla.TabIndex = 25;
            // 
            // SbtnNuevoServicioRE
            // 
            this.SbtnNuevoServicioRE.BackColor = System.Drawing.Color.DimGray;
            this.SbtnNuevoServicioRE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SbtnNuevoServicioRE.ForeColor = System.Drawing.Color.Turquoise;
            this.SbtnNuevoServicioRE.Location = new System.Drawing.Point(702, 46);
            this.SbtnNuevoServicioRE.Name = "SbtnNuevoServicioRE";
            this.SbtnNuevoServicioRE.Size = new System.Drawing.Size(220, 37);
            this.SbtnNuevoServicioRE.TabIndex = 47;
            this.SbtnNuevoServicioRE.Text = "Agregar Nuevo Servicio";
            this.SbtnNuevoServicioRE.UseVisualStyleBackColor = false;
            this.SbtnNuevoServicioRE.Click += new System.EventHandler(this.SbtnNuevoServicioRE_Click);
            // 
            // lblIdEquipo
            // 
            this.lblIdEquipo.AutoSize = true;
            this.lblIdEquipo.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEquipo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblIdEquipo.Location = new System.Drawing.Point(1107, 29);
            this.lblIdEquipo.Name = "lblIdEquipo";
            this.lblIdEquipo.Size = new System.Drawing.Size(55, 34);
            this.lblIdEquipo.TabIndex = 21;
            this.lblIdEquipo.Text = "0000";
            this.lblIdEquipo.Visible = false;
            // 
            // SlblRecibirEquipo
            // 
            this.SlblRecibirEquipo.AutoSize = true;
            this.SlblRecibirEquipo.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlblRecibirEquipo.ForeColor = System.Drawing.Color.Black;
            this.SlblRecibirEquipo.Location = new System.Drawing.Point(977, 29);
            this.SlblRecibirEquipo.Name = "SlblRecibirEquipo";
            this.SlblRecibirEquipo.Size = new System.Drawing.Size(132, 34);
            this.SlblRecibirEquipo.TabIndex = 22;
            this.SlblRecibirEquipo.Text = "ID de Equipo : ";
            this.SlblRecibirEquipo.Visible = false;
            // 
            // txtDescripcionDiagnosticoEspecifico
            // 
            this.txtDescripcionDiagnosticoEspecifico.Enabled = false;
            this.txtDescripcionDiagnosticoEspecifico.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionDiagnosticoEspecifico.Location = new System.Drawing.Point(32, 224);
            this.txtDescripcionDiagnosticoEspecifico.Multiline = true;
            this.txtDescripcionDiagnosticoEspecifico.Name = "txtDescripcionDiagnosticoEspecifico";
            this.txtDescripcionDiagnosticoEspecifico.Size = new System.Drawing.Size(913, 97);
            this.txtDescripcionDiagnosticoEspecifico.TabIndex = 28;
            this.txtDescripcionDiagnosticoEspecifico.TextChanged += new System.EventHandler(this.txtDescripcionDiagnosticoEspecifico_TextChanged);
            // 
            // rbDiagnosticoEspecifico
            // 
            this.rbDiagnosticoEspecifico.AutoSize = true;
            this.rbDiagnosticoEspecifico.Enabled = false;
            this.rbDiagnosticoEspecifico.ForeColor = System.Drawing.Color.Black;
            this.rbDiagnosticoEspecifico.Location = new System.Drawing.Point(342, 195);
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
            this.rbDiagnosticoRapido.Enabled = false;
            this.rbDiagnosticoRapido.ForeColor = System.Drawing.Color.Black;
            this.rbDiagnosticoRapido.Location = new System.Drawing.Point(220, 193);
            this.rbDiagnosticoRapido.Name = "rbDiagnosticoRapido";
            this.rbDiagnosticoRapido.Size = new System.Drawing.Size(93, 38);
            this.rbDiagnosticoRapido.TabIndex = 26;
            this.rbDiagnosticoRapido.TabStop = true;
            this.rbDiagnosticoRapido.Text = "Rápido.";
            this.rbDiagnosticoRapido.UseVisualStyleBackColor = true;
            // 
            // SlblTipoDeDiagnostico
            // 
            this.SlblTipoDeDiagnostico.AutoSize = true;
            this.SlblTipoDeDiagnostico.Enabled = false;
            this.SlblTipoDeDiagnostico.ForeColor = System.Drawing.Color.Black;
            this.SlblTipoDeDiagnostico.Location = new System.Drawing.Point(26, 197);
            this.SlblTipoDeDiagnostico.Name = "SlblTipoDeDiagnostico";
            this.SlblTipoDeDiagnostico.Size = new System.Drawing.Size(188, 34);
            this.SlblTipoDeDiagnostico.TabIndex = 17;
            this.SlblTipoDeDiagnostico.Text = "Tipo de Diagnóstico : ";
            // 
            // ClienteGBx
            // 
            this.ClienteGBx.Controls.Add(this.layCliente);
            this.ClienteGBx.Controls.Add(this.layoutCliente);
            this.ClienteGBx.Controls.Add(this.SbtnCancelar);
            this.ClienteGBx.Controls.Add(this.btnAddClientH);
            this.ClienteGBx.Controls.Add(this.lblTextoIdCliente);
            this.ClienteGBx.Controls.Add(this.lblIdCliente);
            this.ClienteGBx.Controls.Add(this.btnAgregarCliente);
            this.ClienteGBx.Location = new System.Drawing.Point(116, 6);
            this.ClienteGBx.Name = "ClienteGBx";
            this.ClienteGBx.Size = new System.Drawing.Size(1202, 193);
            this.ClienteGBx.TabIndex = 52;
            this.ClienteGBx.TabStop = false;
            this.ClienteGBx.Text = "Cliente";
            // 
            // layCliente
            // 
            this.layCliente.Controls.Add(this.SlblBuscarCliente);
            this.layCliente.Controls.Add(this.txtBuscarCliente);
            this.layCliente.Controls.Add(this.lblAvisoNoCliente);
            this.layCliente.Location = new System.Drawing.Point(84, 44);
            this.layCliente.Name = "layCliente";
            this.layCliente.Size = new System.Drawing.Size(760, 41);
            this.layCliente.TabIndex = 1;
            // 
            // SlblBuscarCliente
            // 
            this.SlblBuscarCliente.AutoSize = true;
            this.SlblBuscarCliente.Location = new System.Drawing.Point(3, 0);
            this.SlblBuscarCliente.Name = "SlblBuscarCliente";
            this.SlblBuscarCliente.Size = new System.Drawing.Size(131, 34);
            this.SlblBuscarCliente.TabIndex = 1;
            this.SlblBuscarCliente.Text = "Buscar Cliente";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(140, 3);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(359, 34);
            this.txtBuscarCliente.TabIndex = 2;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            this.txtBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCliente_KeyPress);
            // 
            // pictureBuscar
            // 
            //this.pictureBuscar.Image = global::WindowsFormsApp1.Properties.Resources.Lupa_Codigo;
            //this.pictureBuscar.Location = new System.Drawing.Point(505, 3);
            //this.pictureBuscar.Name = "pictureBuscar";
            //this.pictureBuscar.Size = new System.Drawing.Size(30, 30);
            //this.pictureBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            //this.pictureBuscar.TabIndex = 42;
            //this.pictureBuscar.TabStop = false;
            //this.pictureBuscar.Click += new System.EventHandler(this.pictureBuscar_Click);
            // 
            // lblAvisoNoCliente
            // 
            this.lblAvisoNoCliente.AutoSize = true;
            this.lblAvisoNoCliente.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoNoCliente.Location = new System.Drawing.Point(505, 0);
            this.lblAvisoNoCliente.Name = "lblAvisoNoCliente";
            this.lblAvisoNoCliente.Size = new System.Drawing.Size(200, 34);
            this.lblAvisoNoCliente.TabIndex = 43;
            this.lblAvisoNoCliente.Text = "No se encontró cliente.";
            this.lblAvisoNoCliente.Visible = false;
            // 
            // layoutCliente
            // 
            this.layoutCliente.ColumnCount = 4;
            this.layoutCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.95349F));
            this.layoutCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.04651F));
            this.layoutCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.layoutCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 279F));
            this.layoutCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 278F));
            this.layoutCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.95349F));
            this.layoutCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.04651F));
            this.layoutCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.layoutCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.layoutCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.95349F));
            this.layoutCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.04651F));
            this.layoutCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.layoutCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.layoutCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.95349F));
            this.layoutCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.04651F));
            this.layoutCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.layoutCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.layoutCliente.Controls.Add(this.SlblNombre, 0, 0);
            this.layoutCliente.Controls.Add(this.txtNombre, 1, 0);
            this.layoutCliente.Controls.Add(this.SlblApellido, 0, 1);
            this.layoutCliente.Controls.Add(this.txtApellido, 1, 1);
            this.layoutCliente.Controls.Add(this.SlblTelefono, 2, 0);
            this.layoutCliente.Controls.Add(this.SlblCorreo, 2, 1);
            this.layoutCliente.Controls.Add(this.txtTelefono, 3, 0);
            this.layoutCliente.Controls.Add(this.txtCorreo, 3, 1);
            this.layoutCliente.Location = new System.Drawing.Point(46, 106);
            this.layoutCliente.Name = "layoutCliente";
            this.layoutCliente.RowCount = 2;
            this.layoutCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutCliente.Size = new System.Drawing.Size(801, 97);
            this.layoutCliente.TabIndex = 0;
            // 
            // SlblNombre
            // 
            this.SlblNombre.AutoSize = true;
            this.SlblNombre.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlblNombre.ForeColor = System.Drawing.Color.Black;
            this.SlblNombre.Location = new System.Drawing.Point(3, 0);
            this.SlblNombre.Name = "SlblNombre";
            this.SlblNombre.Size = new System.Drawing.Size(87, 34);
            this.SlblNombre.TabIndex = 4;
            this.SlblNombre.Text = "Nombre :";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtNombre.Location = new System.Drawing.Point(104, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(313, 34);
            this.txtNombre.TabIndex = 40;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // SlblApellido
            // 
            this.SlblApellido.AutoSize = true;
            this.SlblApellido.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlblApellido.ForeColor = System.Drawing.Color.Black;
            this.SlblApellido.Location = new System.Drawing.Point(3, 48);
            this.SlblApellido.Name = "SlblApellido";
            this.SlblApellido.Size = new System.Drawing.Size(88, 34);
            this.SlblApellido.TabIndex = 36;
            this.SlblApellido.Text = "Apellido :";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtApellido.Location = new System.Drawing.Point(104, 51);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(313, 34);
            this.txtApellido.TabIndex = 41;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // SlblTelefono
            // 
            this.SlblTelefono.AutoSize = true;
            this.SlblTelefono.ForeColor = System.Drawing.Color.Black;
            this.SlblTelefono.Location = new System.Drawing.Point(426, 0);
            this.SlblTelefono.Name = "SlblTelefono";
            this.SlblTelefono.Size = new System.Drawing.Size(89, 48);
            this.SlblTelefono.TabIndex = 5;
            this.SlblTelefono.Text = "Teléfono :";
            // 
            // SlblCorreo
            // 
            this.SlblCorreo.AutoSize = true;
            this.SlblCorreo.ForeColor = System.Drawing.Color.Black;
            this.SlblCorreo.Location = new System.Drawing.Point(426, 48);
            this.SlblCorreo.Name = "SlblCorreo";
            this.SlblCorreo.Size = new System.Drawing.Size(84, 34);
            this.SlblCorreo.TabIndex = 6;
            this.SlblCorreo.Text = "Correo : ";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtTelefono.Location = new System.Drawing.Point(524, 3);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(266, 34);
            this.txtTelefono.TabIndex = 38;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtCorreo.Location = new System.Drawing.Point(524, 51);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(266, 34);
            this.txtCorreo.TabIndex = 39;
            // 
            // SbtnCancelar
            // 
            this.SbtnCancelar.BackColor = System.Drawing.Color.DimGray;
            this.SbtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SbtnCancelar.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SbtnCancelar.ForeColor = System.Drawing.Color.White;
            this.SbtnCancelar.Location = new System.Drawing.Point(1049, 152);
            this.SbtnCancelar.Name = "SbtnCancelar";
            this.SbtnCancelar.Size = new System.Drawing.Size(120, 36);
            this.SbtnCancelar.TabIndex = 47;
            this.SbtnCancelar.Text = "Cancelar";
            this.SbtnCancelar.UseVisualStyleBackColor = false;
            this.SbtnCancelar.Visible = false;
            this.SbtnCancelar.Click += new System.EventHandler(this.SbtnCancelar_Click);
            // 
            // btnAddClientH
            // 
            this.btnAddClientH.BackColor = System.Drawing.Color.DimGray;
            this.btnAddClientH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddClientH.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClientH.ForeColor = System.Drawing.Color.White;
            this.btnAddClientH.Location = new System.Drawing.Point(923, 109);
            this.btnAddClientH.Name = "btnAddClientH";
            this.btnAddClientH.Size = new System.Drawing.Size(246, 38);
            this.btnAddClientH.TabIndex = 48;
            this.btnAddClientH.Text = "Agregar nuevo cliente";
            this.btnAddClientH.UseVisualStyleBackColor = false;
            this.btnAddClientH.Click += new System.EventHandler(this.btnAddClientH_Click_1);
            // 
            // lblTextoIdCliente
            // 
            this.lblTextoIdCliente.AutoSize = true;
            this.lblTextoIdCliente.Location = new System.Drawing.Point(961, 25);
            this.lblTextoIdCliente.Name = "lblTextoIdCliente";
            this.lblTextoIdCliente.Size = new System.Drawing.Size(124, 34);
            this.lblTextoIdCliente.TabIndex = 49;
            this.lblTextoIdCliente.Text = "ID del cliente:";
            this.lblTextoIdCliente.Visible = false;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblIdCliente.Location = new System.Drawing.Point(1091, 25);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(55, 34);
            this.lblIdCliente.TabIndex = 50;
            this.lblIdCliente.Text = "0000";
            this.lblIdCliente.Visible = false;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.DimGray;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCliente.Location = new System.Drawing.Point(923, 152);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(120, 38);
            this.btnAgregarCliente.TabIndex = 10;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Visible = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnPedirPieza
            // 
            this.btnPedirPieza.BackColor = System.Drawing.Color.DimGray;
            this.btnPedirPieza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPedirPieza.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedirPieza.ForeColor = System.Drawing.Color.White;
            this.btnPedirPieza.Location = new System.Drawing.Point(877, 621);
            this.btnPedirPieza.Name = "btnPedirPieza";
            this.btnPedirPieza.Size = new System.Drawing.Size(132, 43);
            this.btnPedirPieza.TabIndex = 35;
            this.btnPedirPieza.Text = "Pedido";
            this.btnPedirPieza.UseVisualStyleBackColor = false;
            this.btnPedirPieza.Click += new System.EventHandler(this.btnPedirPieza_Click);
            // 
            // btnAgregrEquipos
            // 
            this.btnAgregrEquipos.BackColor = System.Drawing.Color.DimGray;
            this.btnAgregrEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregrEquipos.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregrEquipos.ForeColor = System.Drawing.Color.White;
            this.btnAgregrEquipos.Location = new System.Drawing.Point(1015, 621);
            this.btnAgregrEquipos.Name = "btnAgregrEquipos";
            this.btnAgregrEquipos.Size = new System.Drawing.Size(132, 43);
            this.btnAgregrEquipos.TabIndex = 34;
            this.btnAgregrEquipos.Text = "Agregar Equipo";
            this.btnAgregrEquipos.UseVisualStyleBackColor = false;
            this.btnAgregrEquipos.Click += new System.EventHandler(this.btnAgregrEquipos_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.DimGray;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(1153, 621);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(132, 43);
            this.btnLimpiarCampos.TabIndex = 33;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click_1);
            // 
            // recibirLogoCh
            // 
            this.recibirLogoCh.Image = global::WindowsFormsApp1.Properties.Resources.logoUp;
            this.recibirLogoCh.Location = new System.Drawing.Point(6, 6);
            this.recibirLogoCh.Name = "recibirLogoCh";
            this.recibirLogoCh.Size = new System.Drawing.Size(66, 104);
            this.recibirLogoCh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recibirLogoCh.TabIndex = 51;
            this.recibirLogoCh.TabStop = false;
            // 
            // tabReparacion
            // 
            this.tabReparacion.BackColor = System.Drawing.Color.LightGray;
            this.tabReparacion.Controls.Add(this.refresIconCheno);
            this.tabReparacion.Controls.Add(this.pBoxBuscarRep);
            this.tabReparacion.Controls.Add(this.reparacionLogoCh);
            this.tabReparacion.Controls.Add(this.JtxtBuscar2);
            this.tabReparacion.Controls.Add(this.CDGReparacion);
            this.tabReparacion.Controls.Add(this.CEspera);
            this.tabReparacion.Controls.Add(this.JTerminados);
            this.tabReparacion.Controls.Add(this.JProceso);
            this.tabReparacion.Controls.Add(this.JradioTodos);
            this.tabReparacion.Controls.Add(this.JlblBuscar);
            this.tabReparacion.Location = new System.Drawing.Point(4, 43);
            this.tabReparacion.Name = "tabReparacion";
            this.tabReparacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabReparacion.Size = new System.Drawing.Size(1328, 669);
            this.tabReparacion.TabIndex = 2;
            this.tabReparacion.Text = "Reparación";
            this.tabReparacion.Click += new System.EventHandler(this.tabReparacion_Click);
            // 
            // refresIconCheno
            // 
            this.refresIconCheno.Image = global::WindowsFormsApp1.Properties.Resources.refrescar;
            this.refresIconCheno.Location = new System.Drawing.Point(1269, 183);
            this.refresIconCheno.Name = "refresIconCheno";
            this.refresIconCheno.Size = new System.Drawing.Size(53, 55);
            this.refresIconCheno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refresIconCheno.TabIndex = 13;
            this.refresIconCheno.TabStop = false;
            this.refresIconCheno.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pBoxBuscarRep
            // 
            this.pBoxBuscarRep.Image = global::WindowsFormsApp1.Properties.Resources.Lupa_Codigo;
            this.pBoxBuscarRep.Location = new System.Drawing.Point(754, 131);
            this.pBoxBuscarRep.Name = "pBoxBuscarRep";
            this.pBoxBuscarRep.Size = new System.Drawing.Size(44, 34);
            this.pBoxBuscarRep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxBuscarRep.TabIndex = 12;
            this.pBoxBuscarRep.TabStop = false;
            this.pBoxBuscarRep.Click += new System.EventHandler(this.pBoxBuscarRep_Click);
            // 
            // reparacionLogoCh
            // 
            this.reparacionLogoCh.Image = global::WindowsFormsApp1.Properties.Resources.logoUp;
            this.reparacionLogoCh.Location = new System.Drawing.Point(6, 6);
            this.reparacionLogoCh.Name = "reparacionLogoCh";
            this.reparacionLogoCh.Size = new System.Drawing.Size(62, 101);
            this.reparacionLogoCh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reparacionLogoCh.TabIndex = 11;
            this.reparacionLogoCh.TabStop = false;
            // 
            // JtxtBuscar2
            // 
            this.JtxtBuscar2.Font = new System.Drawing.Font("Cordia New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JtxtBuscar2.Location = new System.Drawing.Point(444, 131);
            this.JtxtBuscar2.Name = "JtxtBuscar2";
            this.JtxtBuscar2.Size = new System.Drawing.Size(289, 34);
            this.JtxtBuscar2.TabIndex = 10;
            this.JtxtBuscar2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JtxtBuscar2_KeyPress);
            // 
            // CDGReparacion
            // 
            this.CDGReparacion.AllowUserToAddRows = false;
            this.CDGReparacion.AllowUserToDeleteRows = false;
            this.CDGReparacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CDGReparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CDGReparacion.Location = new System.Drawing.Point(3, 241);
            this.CDGReparacion.Name = "CDGReparacion";
            this.CDGReparacion.ReadOnly = true;
            this.CDGReparacion.RowHeadersVisible = false;
            this.CDGReparacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CDGReparacion.Size = new System.Drawing.Size(1319, 422);
            this.CDGReparacion.TabIndex = 9;
            this.CDGReparacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CDGReparacion_CellClick);
            this.CDGReparacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CDGReparacion_CellContentClick);
            // 
            // CEspera
            // 
            this.CEspera.AutoSize = true;
            this.CEspera.Location = new System.Drawing.Point(579, 182);
            this.CEspera.Name = "CEspera";
            this.CEspera.Size = new System.Drawing.Size(89, 38);
            this.CEspera.TabIndex = 8;
            this.CEspera.Text = "Espera";
            this.CEspera.UseVisualStyleBackColor = true;
            this.CEspera.CheckedChanged += new System.EventHandler(this.CEspera_CheckedChanged);
            // 
            // JTerminados
            // 
            this.JTerminados.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JTerminados.Location = new System.Drawing.Point(674, 183);
            this.JTerminados.Name = "JTerminados";
            this.JTerminados.Size = new System.Drawing.Size(124, 37);
            this.JTerminados.TabIndex = 6;
            this.JTerminados.Text = "Terminado";
            this.JTerminados.UseVisualStyleBackColor = true;
            this.JTerminados.CheckedChanged += new System.EventHandler(this.JTerminados_CheckedChanged);
            // 
            // JProceso
            // 
            this.JProceso.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JProceso.Location = new System.Drawing.Point(464, 180);
            this.JProceso.Name = "JProceso";
            this.JProceso.Size = new System.Drawing.Size(127, 43);
            this.JProceso.TabIndex = 5;
            this.JProceso.Text = "Proceso";
            this.JProceso.UseVisualStyleBackColor = true;
            this.JProceso.CheckedChanged += new System.EventHandler(this.JProceso_CheckedChanged);
            // 
            // JradioTodos
            // 
            this.JradioTodos.Checked = true;
            this.JradioTodos.Font = new System.Drawing.Font("Cordia New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JradioTodos.Location = new System.Drawing.Point(374, 180);
            this.JradioTodos.Name = "JradioTodos";
            this.JradioTodos.Size = new System.Drawing.Size(84, 43);
            this.JradioTodos.TabIndex = 4;
            this.JradioTodos.TabStop = true;
            this.JradioTodos.Text = "Todos";
            this.JradioTodos.UseVisualStyleBackColor = true;
            this.JradioTodos.CheckedChanged += new System.EventHandler(this.JradioTodos_CheckedChanged);
            // 
            // JlblBuscar
            // 
            this.JlblBuscar.AutoSize = true;
            this.JlblBuscar.Location = new System.Drawing.Point(367, 131);
            this.JlblBuscar.Name = "JlblBuscar";
            this.JlblBuscar.Size = new System.Drawing.Size(71, 34);
            this.JlblBuscar.TabIndex = 1;
            this.JlblBuscar.Text = "Buscar";
            // 
            // tabConfiguracionesDeUsuario
            // 
            this.tabConfiguracionesDeUsuario.BackColor = System.Drawing.Color.LightGray;
            this.tabConfiguracionesDeUsuario.Controls.Add(this.SgbConfiguraciones);
            this.tabConfiguracionesDeUsuario.Controls.Add(this.SgbAsignarRolATrabajador);
            this.tabConfiguracionesDeUsuario.Controls.Add(this.SgbRoles);
            this.tabConfiguracionesDeUsuario.Controls.Add(this.pictureBox4);
            this.tabConfiguracionesDeUsuario.Location = new System.Drawing.Point(4, 43);
            this.tabConfiguracionesDeUsuario.Name = "tabConfiguracionesDeUsuario";
            this.tabConfiguracionesDeUsuario.Size = new System.Drawing.Size(1328, 669);
            this.tabConfiguracionesDeUsuario.TabIndex = 3;
            this.tabConfiguracionesDeUsuario.Text = "Configuraciones de Usuario";
            // 
            // SgbConfiguraciones
            // 
            this.SgbConfiguraciones.Controls.Add(this.SbtnAgregarNuevoServicioCU);
            this.SgbConfiguraciones.Controls.Add(this.button1);
            this.SgbConfiguraciones.Controls.Add(this.SbtnAgregarUsuario);
            this.SgbConfiguraciones.Location = new System.Drawing.Point(331, 432);
            this.SgbConfiguraciones.Name = "SgbConfiguraciones";
            this.SgbConfiguraciones.Size = new System.Drawing.Size(580, 198);
            this.SgbConfiguraciones.TabIndex = 6;
            this.SgbConfiguraciones.TabStop = false;
            this.SgbConfiguraciones.Text = "Configuraciones";
            // 
            // SbtnAgregarNuevoServicioCU
            // 
            this.SbtnAgregarNuevoServicioCU.BackColor = System.Drawing.Color.DimGray;
            this.SbtnAgregarNuevoServicioCU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SbtnAgregarNuevoServicioCU.ForeColor = System.Drawing.Color.White;
            this.SbtnAgregarNuevoServicioCU.Location = new System.Drawing.Point(115, 126);
            this.SbtnAgregarNuevoServicioCU.Name = "SbtnAgregarNuevoServicioCU";
            this.SbtnAgregarNuevoServicioCU.Size = new System.Drawing.Size(277, 37);
            this.SbtnAgregarNuevoServicioCU.TabIndex = 5;
            this.SbtnAgregarNuevoServicioCU.Text = "Agregar Nuevo Servicio";
            this.SbtnAgregarNuevoServicioCU.UseVisualStyleBackColor = false;
            this.SbtnAgregarNuevoServicioCU.Click += new System.EventHandler(this.SbtnAgregarNuevoServicioCU_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(115, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reporte de Ventas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SbtnAgregarUsuario
            // 
            this.SbtnAgregarUsuario.BackColor = System.Drawing.Color.DimGray;
            this.SbtnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SbtnAgregarUsuario.ForeColor = System.Drawing.Color.White;
            this.SbtnAgregarUsuario.Location = new System.Drawing.Point(115, 40);
            this.SbtnAgregarUsuario.Name = "SbtnAgregarUsuario";
            this.SbtnAgregarUsuario.Size = new System.Drawing.Size(277, 37);
            this.SbtnAgregarUsuario.TabIndex = 2;
            this.SbtnAgregarUsuario.Text = "Agregar Nuevo Trabajador";
            this.SbtnAgregarUsuario.UseVisualStyleBackColor = false;
            this.SbtnAgregarUsuario.Click += new System.EventHandler(this.SbtnAgregarUsuario_Click);
            // 
            // SgbAsignarRolATrabajador
            // 
            this.SgbAsignarRolATrabajador.Controls.Add(this.SbtnAsiganrRolAUsuario);
            this.SgbAsignarRolATrabajador.Controls.Add(this.SlblSeleccioneRol);
            this.SgbAsignarRolATrabajador.Controls.Add(this.ScbxSeleccionarRol);
            this.SgbAsignarRolATrabajador.Controls.Add(this.ScbxUsuariosRol);
            this.SgbAsignarRolATrabajador.Controls.Add(this.SlblSeleccioneNombreDeUsuario);
            this.SgbAsignarRolATrabajador.Location = new System.Drawing.Point(331, 178);
            this.SgbAsignarRolATrabajador.Name = "SgbAsignarRolATrabajador";
            this.SgbAsignarRolATrabajador.Size = new System.Drawing.Size(580, 220);
            this.SgbAsignarRolATrabajador.TabIndex = 4;
            this.SgbAsignarRolATrabajador.TabStop = false;
            this.SgbAsignarRolATrabajador.Text = "Asignar Rol a Trabajador";
            this.SgbAsignarRolATrabajador.Enter += new System.EventHandler(this.SgbAsignarRolATrabajador_Enter);
            // 
            // SbtnAsiganrRolAUsuario
            // 
            this.SbtnAsiganrRolAUsuario.BackColor = System.Drawing.Color.DimGray;
            this.SbtnAsiganrRolAUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SbtnAsiganrRolAUsuario.ForeColor = System.Drawing.Color.White;
            this.SbtnAsiganrRolAUsuario.Location = new System.Drawing.Point(428, 173);
            this.SbtnAsiganrRolAUsuario.Name = "SbtnAsiganrRolAUsuario";
            this.SbtnAsiganrRolAUsuario.Size = new System.Drawing.Size(146, 41);
            this.SbtnAsiganrRolAUsuario.TabIndex = 3;
            this.SbtnAsiganrRolAUsuario.Text = "Asignar Rol";
            this.SbtnAsiganrRolAUsuario.UseVisualStyleBackColor = false;
            this.SbtnAsiganrRolAUsuario.Click += new System.EventHandler(this.SbtnAsiganrRolAUsuario_Click);
            // 
            // SlblSeleccioneRol
            // 
            this.SlblSeleccioneRol.AutoSize = true;
            this.SlblSeleccioneRol.Location = new System.Drawing.Point(6, 102);
            this.SlblSeleccioneRol.Name = "SlblSeleccioneRol";
            this.SlblSeleccioneRol.Size = new System.Drawing.Size(134, 34);
            this.SlblSeleccioneRol.TabIndex = 3;
            this.SlblSeleccioneRol.Text = "Seleccione Rol";
            // 
            // ScbxSeleccionarRol
            // 
            this.ScbxSeleccionarRol.FormattingEnabled = true;
            this.ScbxSeleccionarRol.Location = new System.Drawing.Point(176, 99);
            this.ScbxSeleccionarRol.Name = "ScbxSeleccionarRol";
            this.ScbxSeleccionarRol.Size = new System.Drawing.Size(283, 42);
            this.ScbxSeleccionarRol.TabIndex = 2;
            // 
            // ScbxUsuariosRol
            // 
            this.ScbxUsuariosRol.FormattingEnabled = true;
            this.ScbxUsuariosRol.Location = new System.Drawing.Point(176, 34);
            this.ScbxUsuariosRol.Name = "ScbxUsuariosRol";
            this.ScbxUsuariosRol.Size = new System.Drawing.Size(283, 42);
            this.ScbxUsuariosRol.TabIndex = 1;
            // 
            // SlblSeleccioneNombreDeUsuario
            // 
            this.SlblSeleccioneNombreDeUsuario.AutoSize = true;
            this.SlblSeleccioneNombreDeUsuario.Location = new System.Drawing.Point(6, 37);
            this.SlblSeleccioneNombreDeUsuario.Name = "SlblSeleccioneNombreDeUsuario";
            this.SlblSeleccioneNombreDeUsuario.Size = new System.Drawing.Size(170, 34);
            this.SlblSeleccioneNombreDeUsuario.TabIndex = 0;
            this.SlblSeleccioneNombreDeUsuario.Text = "Seleccione Usuario";
            // 
            // SgbRoles
            // 
            this.SgbRoles.Controls.Add(this.StxtRol);
            this.SgbRoles.Controls.Add(this.SlblNombreRol);
            this.SgbRoles.Controls.Add(this.SbtnGuardarRol);
            this.SgbRoles.Location = new System.Drawing.Point(331, 20);
            this.SgbRoles.Name = "SgbRoles";
            this.SgbRoles.Size = new System.Drawing.Size(580, 131);
            this.SgbRoles.TabIndex = 1;
            this.SgbRoles.TabStop = false;
            this.SgbRoles.Text = "Roles";
            // 
            // StxtRol
            // 
            this.StxtRol.Location = new System.Drawing.Point(52, 34);
            this.StxtRol.Multiline = true;
            this.StxtRol.Name = "StxtRol";
            this.StxtRol.Size = new System.Drawing.Size(283, 41);
            this.StxtRol.TabIndex = 2;
            // 
            // SlblNombreRol
            // 
            this.SlblNombreRol.AutoSize = true;
            this.SlblNombreRol.Location = new System.Drawing.Point(6, 37);
            this.SlblNombreRol.Name = "SlblNombreRol";
            this.SlblNombreRol.Size = new System.Drawing.Size(40, 34);
            this.SlblNombreRol.TabIndex = 1;
            this.SlblNombreRol.Text = "Rol";
            // 
            // SbtnGuardarRol
            // 
            this.SbtnGuardarRol.BackColor = System.Drawing.Color.DimGray;
            this.SbtnGuardarRol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SbtnGuardarRol.ForeColor = System.Drawing.Color.White;
            this.SbtnGuardarRol.Location = new System.Drawing.Point(458, 84);
            this.SbtnGuardarRol.Name = "SbtnGuardarRol";
            this.SbtnGuardarRol.Size = new System.Drawing.Size(116, 41);
            this.SbtnGuardarRol.TabIndex = 0;
            this.SbtnGuardarRol.Text = "Agregar";
            this.SbtnGuardarRol.UseVisualStyleBackColor = false;
            this.SbtnGuardarRol.Click += new System.EventHandler(this.SbtnGuardarRol_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.logoUp;
            this.pictureBox4.Location = new System.Drawing.Point(6, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(65, 104);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // ordenesTab
            // 
            this.ordenesTab.BackColor = System.Drawing.Color.LightGray;
            this.ordenesTab.Controls.Add(this.SlblPiezasOrdenadas);
            this.ordenesTab.Controls.Add(this.tableOrdenes);
            this.ordenesTab.Controls.Add(this.ordenesLogoCh);
            this.ordenesTab.Location = new System.Drawing.Point(4, 43);
            this.ordenesTab.Name = "ordenesTab";
            this.ordenesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ordenesTab.Size = new System.Drawing.Size(1328, 669);
            this.ordenesTab.TabIndex = 4;
            this.ordenesTab.Text = "Piezas Ordenadas";
            this.ordenesTab.Click += new System.EventHandler(this.ordenesTab_Click);
            this.ordenesTab.Enter += new System.EventHandler(this.ordenesTab_Enter);
            // 
            // SlblPiezasOrdenadas
            // 
            this.SlblPiezasOrdenadas.AutoSize = true;
            this.SlblPiezasOrdenadas.Font = new System.Drawing.Font("Cordia New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlblPiezasOrdenadas.Location = new System.Drawing.Point(574, 45);
            this.SlblPiezasOrdenadas.Name = "SlblPiezasOrdenadas";
            this.SlblPiezasOrdenadas.Size = new System.Drawing.Size(291, 66);
            this.SlblPiezasOrdenadas.TabIndex = 6;
            this.SlblPiezasOrdenadas.Text = "Piezas Ordenadas";
            this.SlblPiezasOrdenadas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SlblPiezasOrdenadas_MouseMove);
            // 
            // tableOrdenes
            // 
            this.tableOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableOrdenes.Location = new System.Drawing.Point(150, 147);
            this.tableOrdenes.Name = "tableOrdenes";
            this.tableOrdenes.RowHeadersVisible = false;
            this.tableOrdenes.RowTemplate.ReadOnly = true;
            this.tableOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableOrdenes.Size = new System.Drawing.Size(1142, 488);
            this.tableOrdenes.TabIndex = 1;
            this.tableOrdenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableOrdenes_CellClick);
            // 
            // ordenesLogoCh
            // 
            this.ordenesLogoCh.Image = global::WindowsFormsApp1.Properties.Resources.logoUp;
            this.ordenesLogoCh.Location = new System.Drawing.Point(6, 6);
            this.ordenesLogoCh.Name = "ordenesLogoCh";
            this.ordenesLogoCh.Size = new System.Drawing.Size(64, 105);
            this.ordenesLogoCh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ordenesLogoCh.TabIndex = 5;
            this.ordenesLogoCh.TabStop = false;
            // 
            // TabClientes
            // 
            this.TabClientes.BackColor = System.Drawing.Color.LightGray;
            this.TabClientes.Controls.Add(this.layBuscarCliente);
            this.TabClientes.Controls.Add(this.dgClientes);
            this.TabClientes.Controls.Add(this.ClientesLogoCh);
            this.TabClientes.Location = new System.Drawing.Point(4, 43);
            this.TabClientes.Name = "TabClientes";
            this.TabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.TabClientes.Size = new System.Drawing.Size(1328, 669);
            this.TabClientes.TabIndex = 5;
            this.TabClientes.Text = "Clientes";
            // 
            // layBuscarCliente
            // 
            this.layBuscarCliente.Controls.Add(this.lblClienteBuscar);
            this.layBuscarCliente.Controls.Add(this.txtCliente);
            this.layBuscarCliente.Controls.Add(this.pbBuscar);
            this.layBuscarCliente.Location = new System.Drawing.Point(297, 56);
            this.layBuscarCliente.Name = "layBuscarCliente";
            this.layBuscarCliente.Size = new System.Drawing.Size(585, 56);
            this.layBuscarCliente.TabIndex = 9;
            // 
            // lblClienteBuscar
            // 
            this.lblClienteBuscar.AutoSize = true;
            this.lblClienteBuscar.Location = new System.Drawing.Point(3, 0);
            this.lblClienteBuscar.Name = "lblClienteBuscar";
            this.lblClienteBuscar.Size = new System.Drawing.Size(134, 34);
            this.lblClienteBuscar.TabIndex = 6;
            this.lblClienteBuscar.Text = "Buscar cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(143, 3);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(296, 41);
            this.txtCliente.TabIndex = 7;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // pbBuscar
            // 
            this.pbBuscar.Image = global::WindowsFormsApp1.Properties.Resources.Lupa_Codigo;
            this.pbBuscar.Location = new System.Drawing.Point(445, 3);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(37, 41);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 8;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.Click += new System.EventHandler(this.pbBuscar_Click);
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToAddRows = false;
            this.dgClientes.AllowUserToDeleteRows = false;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(130, 150);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.ReadOnly = true;
            this.dgClientes.RowHeadersVisible = false;
            this.dgClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgClientes.RowTemplate.ReadOnly = true;
            this.dgClientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClientes.Size = new System.Drawing.Size(901, 320);
            this.dgClientes.TabIndex = 5;
            this.dgClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellClick);
            // 
            // ClientesLogoCh
            // 
            this.ClientesLogoCh.Image = global::WindowsFormsApp1.Properties.Resources.logoUp;
            this.ClientesLogoCh.Location = new System.Drawing.Point(6, 6);
            this.ClientesLogoCh.Name = "ClientesLogoCh";
            this.ClientesLogoCh.Size = new System.Drawing.Size(61, 106);
            this.ClientesLogoCh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClientesLogoCh.TabIndex = 4;
            this.ClientesLogoCh.TabStop = false;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.techPOSdbDataSetBindingSource;
            // 
            // techPOSdbDataSetBindingSource
            // 
            this.techPOSdbDataSetBindingSource.DataSource = this.techPOSdbDataSet;
            this.techPOSdbDataSetBindingSource.Position = 0;
            // 
            // techPOSdbDataSet
            // 
            this.techPOSdbDataSet.DataSetName = "TechPOSdbDataSet";
            this.techPOSdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reparacionBindingSource
            // 
            this.reparacionBindingSource.DataMember = "Reparacion";
            this.reparacionBindingSource.DataSource = this.techPOSdbDataSetBindingSource;
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
            // reparacionTableAdapter
            // 
            this.reparacionTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1257, 718);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ViewTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 749);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tabPuntoVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewTabs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UP - Software";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewTabs_FormClosed);
            this.Load += new System.EventHandler(this.ViewTabs_Load);
            this.tabPuntoVenta.ResumeLayout(false);
            this.tabVenta.ResumeLayout(false);
            this.tabVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventaLogoCh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableVender)).EndInit();
            this.tabRecibirEquipo.ResumeLayout(false);
            this.layoutTotales.ResumeLayout(false);
            this.layoutTotales.PerformLayout();
            this.EquipoGbx.ResumeLayout(false);
            this.EquipoGbx.PerformLayout();
            this.LayEquipo.ResumeLayout(false);
            this.LayEquipo.PerformLayout();
            this.ClienteGBx.ResumeLayout(false);
            this.ClienteGBx.PerformLayout();
            this.layCliente.ResumeLayout(false);
            this.layCliente.PerformLayout();
          //  ((System.ComponentModel.ISupportInitialize)(this.pictureBuscar)).EndInit();
            this.layoutCliente.ResumeLayout(false);
            this.layoutCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recibirLogoCh)).EndInit();
            this.tabReparacion.ResumeLayout(false);
            this.tabReparacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresIconCheno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBuscarRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reparacionLogoCh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CDGReparacion)).EndInit();
            this.tabConfiguracionesDeUsuario.ResumeLayout(false);
            this.SgbConfiguraciones.ResumeLayout(false);
            this.SgbAsignarRolATrabajador.ResumeLayout(false);
            this.SgbAsignarRolATrabajador.PerformLayout();
            this.SgbRoles.ResumeLayout(false);
            this.SgbRoles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ordenesTab.ResumeLayout(false);
            this.ordenesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableOrdenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesLogoCh)).EndInit();
            this.TabClientes.ResumeLayout(false);
            this.layBuscarCliente.ResumeLayout(false);
            this.layBuscarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesLogoCh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techPOSdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techPOSdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reparacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label SlblBuscarCliente;
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
        private System.Windows.Forms.Label SlblRecibirEquipo;
        private System.Windows.Forms.Label lblIdEquipo;
        private System.Windows.Forms.Label SlblMarca;
        private System.Windows.Forms.Label SlblModelo;
        private System.Windows.Forms.Label SlblDescripcionFalla;
        private System.Windows.Forms.Label SlblTipoDeDiagnostico;
        private System.Windows.Forms.Label SlblTotal;
        private System.Windows.Forms.Label SlblAnticipo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label SlblApellido;
       // private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CbtnCobrarVenta;
        private System.Windows.Forms.Button CbtnCancelarVenta;
        private System.Windows.Forms.Label usuarioLblVenta;
        //
      //  private System.Windows.Forms.PictureBox JpictureBox;
        ////
       // private System.Windows.Forms.PictureBox JPicture;
        private System.Windows.Forms.Label JlblBuscar;
        private System.Windows.Forms.RadioButton JTerminados;
        private System.Windows.Forms.RadioButton JProceso;
        private System.Windows.Forms.RadioButton JradioTodos;
        private System.Windows.Forms.Label lblAvisoNoCliente;
        //
       // private System.Windows.Forms.PictureBox logoImg;
        private System.Windows.Forms.DataGridView tableVender;
        private System.Windows.Forms.Label totalLblVentas;
        private System.Windows.Forms.Label ivaLblVenta;
        private System.Windows.Forms.Label subTotalLblVenta;
        //
        //private System.Windows.Forms.PictureBox lupaImg;
        private System.Windows.Forms.TextBox buscarTbxVentas;
        private System.Windows.Forms.TabPage ordenesTab;
        private System.Windows.Forms.TextBox totalTbxVenta;
        private System.Windows.Forms.TextBox ivaTbxVentas;
        private System.Windows.Forms.TextBox subTotalTbxVentas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView tableOrdenes;
       // private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox SgbRoles;
        private System.Windows.Forms.TextBox StxtRol;
        private System.Windows.Forms.Label SlblNombreRol;
        private System.Windows.Forms.Button SbtnGuardarRol;
        private System.Windows.Forms.Button SbtnAgregarUsuario;
        private System.Windows.Forms.ComboBox ccbTipoServicio1;
        private System.Windows.Forms.Label tiposervicioC1;
        private System.Windows.Forms.RadioButton CEspera;
        private System.Windows.Forms.DataGridView CDGReparacion;
        private System.Windows.Forms.BindingSource techPOSdbDataSetBindingSource;
        private TechPOSdbDataSet techPOSdbDataSet;
        private System.Windows.Forms.BindingSource reparacionBindingSource;
        private TechPOSdbDataSetTableAdapters.ReparacionTableAdapter reparacionTableAdapter;
        private System.Windows.Forms.Button SbtnCancelar;
        private System.Windows.Forms.Button btnAddClientH;
        private System.Windows.Forms.Label CNombreUsuarioLblVenta;
        private System.Windows.Forms.Label ClblCodigoDeBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn codClmVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantClVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrClmVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUClmVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTClmVenta;
        private System.Windows.Forms.TextBox JtxtBuscar2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox SgbConfiguraciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox SgbAsignarRolATrabajador;
        private System.Windows.Forms.Label SlblSeleccioneRol;
        private System.Windows.Forms.ComboBox ScbxSeleccionarRol;
        private System.Windows.Forms.ComboBox ScbxUsuariosRol;
        private System.Windows.Forms.Label SlblSeleccioneNombreDeUsuario;
        private System.Windows.Forms.Button SbtnAsiganrRolAUsuario;
        private System.Windows.Forms.TabPage TabClientes;
        private System.Windows.Forms.PictureBox ClientesLogoCh;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private TechPOSdbDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblClienteBuscar;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label lblTextoIdCliente;
        private System.Windows.Forms.PictureBox ventaLogoCh;
        private System.Windows.Forms.PictureBox recibirLogoCh;
        private System.Windows.Forms.PictureBox reparacionLogoCh;
        private System.Windows.Forms.PictureBox ordenesLogoCh;
        private System.Windows.Forms.TableLayoutPanel layoutTotales;
        private System.Windows.Forms.GroupBox EquipoGbx;
        private System.Windows.Forms.TableLayoutPanel LayEquipo;
        private System.Windows.Forms.GroupBox ClienteGBx;
        private System.Windows.Forms.FlowLayoutPanel layCliente;
        private System.Windows.Forms.TableLayoutPanel layoutCliente;
        private System.Windows.Forms.FlowLayoutPanel layBuscarCliente;
        private System.Windows.Forms.Label SlblPiezasOrdenadas;
        private System.Windows.Forms.Button SbtnAgregarNuevoServicioCU;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pBoxBuscarRep;
        private System.Windows.Forms.PictureBox refresIconCheno;
        private System.Windows.Forms.Button SbtnNuevoServicioRE;
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