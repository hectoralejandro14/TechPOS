﻿using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;
using WindowsFormsApp1.DBConnectio;

namespace WindowsFormsApp1.Views
{
    public partial class ViewTabs : Form
    {
        private DBConnectio.Connection conexion = new DBConnectio.Connection();
        //GENERALES  
        public ViewTabs()
        {
            InitializeComponent();
            txtDescripcionDeFalla.ScrollBars = ScrollBars.Vertical;
            txtDescripcionDiagnosticoEspecifico.ScrollBars = ScrollBars.Vertical;
            tabPuntoVenta.TabPages.Remove(tabConfiguracionesDeUsuario);

            DataTable dt = new DataTable();
            //---------Combo box servicio
            conexion.AbrirConexion();
            SqlDataAdapter da = conexion.consultaMasDatos("select Id, Nombre from Servicio");
            da.Fill(dt);
            conexion.CerrarConexion();
           
            ccbTipoServicio1.DisplayMember = "Nombre";
            ccbTipoServicio1.ValueMember = "Id";
            ccbTipoServicio1.DataSource = dt;
            //------------------------------------------------------------------------------------------------------------------------------------------------------
            //Combo box responsable
            DataTable dt1 = new DataTable();
            conexion.AbrirConexion();
            SqlDataAdapter da1 = conexion.consultaMasDatos("select Id, Nombre from Usuario");
            da1.Fill(dt1);
            conexion.CerrarConexion();
            comboResponsable.DisplayMember = "Nombre";
            comboResponsable.ValueMember = "Id";
            comboResponsable.DataSource = dt1;
            //------------------------------------------------------------------------------------------------------------------------------------------------------
            //Combo box asignar rol a usuario
            DataTable dt2 = new DataTable();
            conexion.AbrirConexion();
            SqlDataAdapter da2 = conexion.consultaMasDatos("select Id, Nombre from Usuario");
            da2.Fill(dt2);
            conexion.CerrarConexion();
            ScbxUsuariosRol.DisplayMember = "Nombre";
            ScbxUsuariosRol.ValueMember = "Id";
            ScbxUsuariosRol.DataSource = dt2;
            //------------------------------------------------------------------------------------------------------------------------------------------------------
            SbtnCancelar.Visible = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
            //------------------------------------------------------------------------------------------------------------------------------------------------------
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            GenerarIdEquipo();
            //------------------------------------------------------------------------------------------------------------------------------------------------------
            ArrayList roles = new ArrayList();
            ScbxSeleccionarRol.Text = "Elija el Rol de Usuario";
            roles.Add("Administrador");
            roles.Add("Trabajador");
            for (int i = 0;i<roles.Count;i++)
            {
                ScbxSeleccionarRol.Items.Add(roles[i]);
            }
            //------------------------------------------------------------------------------------------------------------------------------------------------------
            //limitar tamañ de ComboBox
            //ccbTipoServicio1
            Connection connection = new Connection();
            connection.AbrirConexion();
            CDGReparacion.DataSource = connection.buscarReparacion("SELECT Reparacion.Id as ID,Cliente.Nombre as Cliente, Reparacion.Marca as Marca,Reparacion.Modelo as Modelo, Servicio.Nombre as Servicio, Pieza.Descripcion as Pieza, Estado.Nombre as Estado, Reparacion.Fecha as Fecha, Reparacion.Anticipo as Anticipo, Reparacion.CostoTotal as Total FROM Reparacion INNER JOIN Servicio on Reparacion.IdServicio=Servicio.Id INNER JOIN Cliente on Reparacion.IdCliente=Cliente.Id INNER JOIN Estado on Reparacion.IdEstado=Estado.Id INNER JOIN Pieza on Reparacion.IdPieza=Pieza.Id  order by Reparacion.Fecha asc");
            connection.CerrarConexion();
            //------------------------------------------------------------------------------------------------------------------------------------------------------
            conexion.AbrirConexion();
            tableOrdenes.DataSource = conexion.buscarReparacion("SELECT * FROM Pieza order by FechaPedida asc");
            conexion.CerrarConexion();
            //Adaptar datos a DataGridTableView
            tableOrdenes.AutoResizeColumns();
            tableOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //------------------------------------------------------------------------------------------------------------------------------------------------------
            colores();
        }
       
        private void linkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ViewLogin view = new ViewLogin();
            view.Show();
        }
        private void ViewTabs_Load(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.AbrirConexion();
            dgClientes.DataSource = connection.buscar("SELECT * FROM Cliente");
            connection.CerrarConexion();
            colores();

            tabPuntoVenta.DrawMode=TabDrawMode.OwnerDrawFixed;
        }
        private void ViewTabs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------
        //TAB "VENTA"
        private void CbtnCobrarVenta_Click(object sender, EventArgs e)
        {

        }
        private void CbtnCancelarVenta_Click(object sender, EventArgs e)
        {

        }
        private void buscarTbxVentas_TextChanged(object sender, EventArgs e)
        {

        }
        private void lupaImg_Click(object sender, EventArgs e)
        {
            Connection db = new Connection();
            db.AbrirConexion();
            if (db.Existe(buscarTbxVentas.Text))
            {

            }
            else
            {
                MessageBox.Show("PRODUCTO NO ENCONTRADO \n VERIFIQUE QUE EL CODIGO ESTE INGRESADO CORRECTAMENTE", "PRODUCTO NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buscarTbxVentas.Text = "";
            }
            db.CerrarConexion();
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------
        private void JPicture_Click(object sender, EventArgs e)
        {
            if (JtxtBuscar2.Text == "")
            {
                MessageBox.Show("El campo esta vacio");
            }
            else
            {
                // MessageBox.Show(JtxtBuscar2.Text);

                string c = JtxtBuscar2.Text;
                Connection connection = new Connection();
                connection.AbrirConexion();
                CDGReparacion.DataSource = connection.buscarReparacion("SELECT Reparacion.Id as ID,Cliente.Nombre as Cliente, Reparacion.Marca as Marca,Reparacion.Modelo as Modelo, Servicio.Nombre as Servicio, Pieza.Descripcion as Pieza, Estado.Nombre as Estado, Reparacion.Fecha as Fecha, Reparacion.Anticipo as Anticipo, Reparacion.CostoTotal as Total FROM Reparacion INNER JOIN Servicio on Reparacion.IdServicio=Servicio.Id INNER JOIN Cliente on Reparacion.IdCliente=Cliente.Id INNER JOIN Estado on Reparacion.IdEstado=Estado.Id INNER JOIN Pieza on Reparacion.IdPieza=Pieza.Id WHERE Reparacion.Id =" + c + "   order by Reparacion.Fecha asc");
                connection.CerrarConexion();
                JradioTodos.Checked = false;
                JTerminados.Checked = false;
                JProceso.Checked = false;
                CEspera.Checked = false;
                JtxtBuscar2.Text = "";

            }

        }
        private void Jtxtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void JradioTodos_CheckedChanged(object sender, EventArgs e)
        {

            Connection connection = new Connection();
            connection.AbrirConexion();
            CDGReparacion.DataSource = connection.buscarReparacion("SELECT Reparacion.Id as ID,Cliente.Nombre as Cliente, Reparacion.Marca as Marca,Reparacion.Modelo as Modelo, Servicio.Nombre as Servicio, Pieza.Descripcion as Pieza, Estado.Nombre as Estado, Reparacion.Fecha as Fecha, Reparacion.Anticipo as Anticipo, Reparacion.CostoTotal as Total FROM Reparacion INNER JOIN Servicio on Reparacion.IdServicio=Servicio.Id INNER JOIN Cliente on Reparacion.IdCliente=Cliente.Id INNER JOIN Estado on Reparacion.IdEstado=Estado.Id INNER JOIN Pieza on Reparacion.IdPieza=Pieza.Id   order by Reparacion.Fecha asc");
            connection.CerrarConexion();
            colores();
        }
        private void JProceso_CheckedChanged(object sender, EventArgs e)
        {

            Connection connection = new Connection();
            connection.AbrirConexion();
            CDGReparacion.DataSource = connection.buscarReparacion("SELECT Reparacion.Id as ID,Cliente.Nombre as Cliente, Reparacion.Marca as Marca,Reparacion.Modelo as Modelo, Servicio.Nombre as Servicio, Pieza.Descripcion as Pieza, Estado.Nombre as Estado, Reparacion.Fecha as Fecha, Reparacion.Anticipo as Anticipo, Reparacion.CostoTotal as Total FROM Reparacion INNER JOIN Servicio on Reparacion.IdServicio=Servicio.Id INNER JOIN Cliente on Reparacion.IdCliente=Cliente.Id INNER JOIN Estado on Reparacion.IdEstado=Estado.Id INNER JOIN Pieza on Reparacion.IdPieza=Pieza.Id WHERE IdEstado = '" + 7 + "'  order by Reparacion.Fecha asc");
            connection.CerrarConexion();
            colores();

        }
        public void colores()
        {
            foreach (DataGridViewRow row in CDGReparacion.Rows)
            {
                DateTime Hoy = DateTime.Today;
                DateTime fecha = Convert.ToDateTime(row.Cells["Fecha"].Value.ToString());
                string fecha_actual = Hoy.ToString("yyyy-MM-dd");
                int daysDiff = ((TimeSpan)(Hoy - fecha)).Days;

                if (daysDiff <=3)
                {
                    row.DefaultCellStyle.BackColor = Color.YellowGreen;
                    // MessageBox.Show(daysDiff + "");
                }else if (daysDiff > 3 && daysDiff <=5)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (daysDiff > 5)
                {
                    row.DefaultCellStyle.BackColor = Color.Tomato;
                }
            }
        }
        private void CEspera_CheckedChanged(object sender, EventArgs e)
        {

            Connection connection = new Connection();
            connection.AbrirConexion();
            CDGReparacion.DataSource = connection.buscarReparacion("SELECT Reparacion.Id as ID,Cliente.Nombre as Cliente, Reparacion.Marca as Marca,Reparacion.Modelo as Modelo, Servicio.Nombre as Servicio, Pieza.Descripcion as Pieza, Estado.Nombre as Estado, Reparacion.Fecha as Fecha, Reparacion.Anticipo as Anticipo, Reparacion.CostoTotal as Total FROM Reparacion INNER JOIN Servicio on Reparacion.IdServicio=Servicio.Id INNER JOIN Cliente on Reparacion.IdCliente=Cliente.Id INNER JOIN Estado on Reparacion.IdEstado=Estado.Id INNER JOIN Pieza on Reparacion.IdPieza=Pieza.Id WHERE IdEstado = '" + 6 + "'  order by Reparacion.Fecha asc");
            connection.CerrarConexion();
            colores();
        }
        private void JTerminados_CheckedChanged(object sender, EventArgs e)
        {

            Connection connection = new Connection();
            connection.AbrirConexion();
            CDGReparacion.DataSource = connection.buscarReparacion("SELECT Reparacion.Id as ID,Cliente.Nombre as Cliente, Reparacion.Marca as Marca,Reparacion.Modelo as Modelo, Servicio.Nombre as Servicio, Pieza.Descripcion as Pieza, Estado.Nombre as Estado, Reparacion.Fecha as Fecha, Reparacion.Anticipo as Anticipo, Reparacion.CostoTotal as Total FROM Reparacion INNER JOIN Servicio on Reparacion.IdServicio=Servicio.Id INNER JOIN Cliente on Reparacion.IdCliente=Cliente.Id INNER JOIN Estado on Reparacion.IdEstado=Estado.Id INNER JOIN Pieza on Reparacion.IdPieza=Pieza.Id WHERE IdEstado = '" + 3 + "'   order by Reparacion.Fecha asc");
            connection.CerrarConexion();
            colores();
        }
        private void CDGReparacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = CDGReparacion.Rows[e.RowIndex];
            String id = Convert.ToString(fila.Cells["ID"].Value);
            Reparacion r = new Reparacion(id);
            r.Show();
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------        
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtMarca.Text = "";
            txtDescripcionDeFalla.Text = "";
            txtDescripcionDiagnosticoEspecifico.Text = "";
            txtModelo.Text = "";
            txtTotal.Text = "";
            txtAnticipo.Text = "";
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------
        //TAB "RECIBIRI EQUIPO"
        private void btnAddClientH_Click(object sender, EventArgs e)
        {
            GenerarId();
            btnAgregarCliente.Visible = true;
            SbtnCancelar.Visible = true;
            txtNombre.Enabled = true;
            txtNombre.Text = "";
            txtApellido.Enabled = true;
            txtApellido.Text = "";
            txtTelefono.Enabled = true;
            txtTelefono.Text = "";
            txtCorreo.Enabled = true;
            txtCorreo.Text = "";
            btnAddClientH.Visible = false;

        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Connection conexion = new Connection();
            conexion.AbrirConexion();

            if ((!txtNombre.Text.Equals("")) && (!txtApellido.Text.Equals("")) && (!txtTelefono.Text.Equals("")) )
            {
                string idVerif = conexion.verificarExistenciaUser(txtNombre.Text, txtApellido.Text);
                if (idVerif!="")
                {
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtCorreo.Text = "";
                    txtTelefono.Text = "";
                    MessageBox.Show("Existe un cliente con el nombre " + txtNombre.Text + " " + txtApellido.Text+" con el id: "+idVerif);
                }
                else if (txtCorreo.Text=="")
                {
                    int idR = Convert.ToInt32(lblIdCliente.Text);
                    //Agregar cliente
                    String sql = "INSERT INTO Cliente (Id,Nombre,Apellido,Telefono,Contacto) VALUES (" + idR + ",'" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtTelefono.Text + "','" + txtCorreo.Text + "')";
                    conexion.AddElements(sql);
                    conexion.CerrarConexion();
                    //--------------------------------------------------
                    SbtnCancelar.Visible = false;
                    btnAgregarCliente.Visible = false;
                    //--------------------------------------------------
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtCorreo.Enabled = false;
                    lblAvisoNoCliente.Visible = false;
                    txtBuscarCliente.Enabled = true;
                    //lblTextoIdCliente.Visible = false;
                    //lblIdCliente.Visible = false;
                    dgClientes.DataSource = conexion.buscar("SELECT * FROM Cliente");
                }
                else if (validarEmail(txtCorreo.Text)==true)
                {

                    int idR = Convert.ToInt32(lblIdCliente.Text);
                    //Agregar cliente
                    String sql = "INSERT INTO Cliente (Id,Nombre,Apellido,Telefono,Contacto) VALUES (" + idR + ",'" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtTelefono.Text + "','" + txtCorreo.Text + "')";
                    conexion.AddElements(sql);
                    conexion.CerrarConexion();
                    //------------------------------------------------------------------------------------------------------------------------------------------------------
                    SbtnCancelar.Visible = false;
                    btnAgregarCliente.Visible = false;
                    //------------------------------------------------------------------------------------------------------------------------------------------------------
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtCorreo.Enabled = false;
                    lblAvisoNoCliente.Visible = false;
                    txtBuscarCliente.Enabled = true;
                    //lblTextoIdCliente.Visible = false;
                    //lblIdCliente.Visible = false;
                    dgClientes.DataSource = conexion.buscar("SELECT * FROM Cliente");
                }
                else
                {
                    MessageBox.Show("FORMATO DE CORREO NO VALIDO", "RECHAZADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("SE HA DETECTADO LA EXISTENCIA DE CAMPOS VACIOS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            conexion.CerrarConexion();

        }
        private void btnPedirPieza_Click(object sender, System.EventArgs e)
        {
            if (lblIdEquipo.Text != "0000" || txtModelo.Text != "" || txtMarca.Text != "")
            {
                Ecargar_Pieza encargar = new Ecargar_Pieza(lblIdEquipo.Text, txtModelo.Text, txtMarca.Text);

                encargar.Show();
            }
            else
            {
                MessageBox.Show("Se requiere de una marca y modelo");
            }

        }
        private void pictureBuscar_Click(object sender, System.EventArgs e)
        {
            if (txtBuscarCliente.Text == "")
            {
                MessageBox.Show("El campo esta vacio", "Alerta");
            }
            else
            {
                bool encontro = false;
                Connection db = new DBConnectio.Connection();
                db.AbrirConexion();

                SqlDataReader dr = db.consulta("select * from Cliente where Id = '" + txtBuscarCliente.Text+"'");
                //MessageBox.Show("select * from Cliente where Id=" + txtBuscarCliente.Text);
                if (dr.Read())
                {
                    lblTextoIdCliente.Visible = true;
                    lblIdCliente.Visible = true;
                    lblIdEquipo.Visible = true;
                    SlblRecibirEquipo.Visible = true;
                    lblIdCliente.Text= Convert.ToString(dr["Id"]);
                    txtNombre.Text = Convert.ToString(dr["Nombre"]);
                    txtApellido.Text = Convert.ToString(dr["Apellido"]);
                    txtTelefono.Text = Convert.ToString(dr["Telefono"]);
                    txtCorreo.Text = Convert.ToString(dr["Contacto"]);
                    encontro = true;
                }
                
                dr.Close();
                db.CerrarConexion();
                if (!encontro)
                {
                    SbtnCancelar.Visible = true;
                    lblAvisoNoCliente.Visible = true;
                    btnAgregarCliente.Visible = true;
                    //------------------------------------------------------------------------------------------------------------------------------------------------------
                    SbtnCancelar.Visible = true;
                    txtNombre.Enabled = true;
                    txtApellido.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtCorreo.Text = "";
                    txtTelefono.Text = "";
                    pictureBuscar.Visible = true;
                    //------------------------------------------------------------------------------------------------------------------------------------------------------
                    GenerarId();
                    GenerarIdEquipo();

                }
                else
                {
                    lblAvisoNoCliente.Visible = false;
                    btnAddClientH.Visible = true;
                    btnAgregarCliente.Visible = false;
                    SbtnCancelar.Visible = false;
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;

                }
            }
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtAnticipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void tabReparacion_Click(object sender, EventArgs e)
        {

        }
        private void SbtnCancelar_Click(object sender, EventArgs e)
        {
            txtBuscarCliente.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            //------------------------------------------------------------------------------------------------------------------------------------------------------
            SbtnCancelar.Visible = false;
            btnAddClientH.Visible = true;
            btnAgregarCliente.Visible = false;
            //------------------------------------------------------------------------------------------------------------------------------------------------------
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
            lblTextoIdCliente.Visible = false;
            lblIdCliente.Visible = false;
            txtBuscarCliente.Enabled = true;


        }
        private void btnAgregrEquipos_Click(object sender, EventArgs e)
        {
            if (lblIdCliente.Text != "")
            {
                if (txtDescripcionDeFalla.Text != "" && txtMarca.Text != "" && txtModelo.Text != "")
                {
                    string tipoDiag = "";
                    DateTime Hoy = DateTime.Today;
                    string fecha_actual = Hoy.ToString("yyyy-MM-dd");
                    DBConnectio.Connection db = new DBConnectio.Connection();
                    db.AbrirConexion();
                    if (rbDiagnosticoEspecifico.Checked)
                    {
                        tipoDiag = "Diagnóstico específico";
                    }
                    else if (rbDiagnosticoRapido.Checked)
                    {
                        tipoDiag = "Diagnóstico rápido";
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un tipo de diagnóstico", "Diagnóstico", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    if (rbDiagnosticoEspecifico.Checked || rbDiagnosticoRapido.Checked)
                    {
                        string concatenarDiagTex = tipoDiag + " : " + txtDescripcionDiagnosticoEspecifico.Text;
                        String sql = "";
                        if (txtAnticipo.Text == "")
                        {
                            sql = "Insert into Reparacion (Id,Marca,Modelo,Falla,Diagnostico,IdServicio,Anticipo,IdEstado,Fecha,IdCliente,IdUsuario,CostoTotal,IdPieza,trabajoRealizado) values("
                                                        + lblIdEquipo.Text + ",'" + txtMarca.Text
                                                        + "','" + txtModelo.Text
                                                        + "','" + txtDescripcionDeFalla.Text
                                                        + "','" + concatenarDiagTex
                                                        + "','" + ccbTipoServicio1.SelectedValue
                                                        + "',0,6,'" + fecha_actual + "','" + lblIdCliente.Text
                                                        + "','" + comboResponsable.SelectedValue.ToString() + "'," + txtTotal.Text
                                                        + ",1,'')";
                        }
                        else
                        {
                            sql = "Insert into Reparacion (Id,Marca,Modelo,Falla,Diagnostico,IdServicio,Anticipo,IdEstado,Fecha,IdCliente,IdUsuario,CostoTotal,IdPieza,trabajoRealizado) values("
                                + lblIdEquipo.Text + ",'" + txtMarca.Text
                                + "','" + txtModelo.Text
                                + "','" + txtDescripcionDeFalla.Text
                                + "','" + concatenarDiagTex
                                + "','" + ccbTipoServicio1.SelectedValue
                                + "'," + txtAnticipo.Text + ",6,'" + fecha_actual + "','" + lblIdCliente.Text
                                + "','" + comboResponsable.SelectedValue.ToString() + "'," + txtTotal.Text
                                + ",1,'')";
                        }
                        Console.WriteLine(sql);
                        bool data=db.AddElements(sql);
                        db.CerrarConexion();
                        if (!data)
                        {
                            MessageBox.Show("Ocurrio un error con la conexión a la Base de Datos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        txtMarca.Text = "";
                        txtDescripcionDeFalla.Text = "";
                        txtDescripcionDiagnosticoEspecifico.Text = "";
                        txtModelo.Text = "";
                        txtTotal.Text = "";
                        txtAnticipo.Text = "";
                        txtNombre.Text = "";
                        txtApellido.Text = "";
                        txtTelefono.Text = "";
                        txtCorreo.Text = "";
                        txtBuscarCliente.Text = "";
                        lblIdCliente.Visible = false;
                        lblTextoIdCliente.Visible = false;
                        lblIdEquipo.Visible = false;
                        SlblRecibirEquipo.Visible = false;
                        
                        //------------------------------------------------------------------------------------------------
                        btnAddClientH.Visible = true;
                        GenerarIdEquipo();
                    }
                }
            }
            else
            {
                MessageBox.Show("Id del cliente vacio");
            }
        }
        private void btnLimpiarCampos_Click_1(object sender, EventArgs e)
        {
            txtBuscarCliente.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            //------------------------------------------------------------------------------------------------------------------------------------------------
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtDescripcionDeFalla.Text = "";
            txtDescripcionDiagnosticoEspecifico.Text = "";
            //-----------------------------------------------------------------------------------------------------------------------------------------------
            txtTotal.Text = "";
            txtAnticipo.Text = "";
            //------------------------------------------------------------------------------------------------------------------------------------------------
            txtBuscarCliente.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtCorreo.Text = "";
            //-------------------------------------------------------------------------------------------------------------------------------------------------
            btnAddClientH.Visible = true;

        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //TAB "CONFIGURACION DE USUARIO"
        private void SbtnGuardarRol_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (i == 1)
            {
                string _rol = StxtRol.Text;
                Random random = new Random();
                decimal id_random = random.Next(1, 1000000000);
                string consulta = "INSERT INTO Rol (Id,NombreRol) VALUES (" + id_random + ",'" + _rol + "')";
                MessageBox.Show(consulta);
                conexion.AddElements(consulta);
            }
            else
            {
                MessageBox.Show("ES NECESARIO SER DESARROLLADOR PARA CREAR ROLES DE USUARIO, DEBIDO A QUE ES NECESARIO LA ACTUALIZACION DEL SISTEMA", "PERMISO DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void SbtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevoUsuario = new NuevoUsuario();
            nuevoUsuario.Show();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //METOODOS PROGRAMADOS POR NOSOTROS
        public void GenerarId()
        {
            Connection connection = new Connection();
            connection.AbrirConexion();
            int idCliente = connection.generarId("SELECT MAX(Id) FROM Cliente");
            if (idCliente == null)
            {
                idCliente = 1;
            }
            lblIdCliente.Text = Convert.ToString(idCliente);
            connection.CerrarConexion();
        }

        public void GenerarIdEquipo()
        {
            Connection connection = new Connection();
            connection.AbrirConexion();
            int idReparacion = connection.generarId("SELECT MAX(Id) FROM Reparacion");
            lblIdEquipo.Text = Convert.ToString(idReparacion);
            connection.CerrarConexion();
        }

        public void Bienvenido(string usuario)
        {
            this.CNombreUsuarioLblVenta.Text = usuario;
        }
        public void MostrarConfiguracionUsuarios(string Rol)
        {
            if (Rol == "Administrador")
            {
                tabPuntoVenta.TabPages.Add(tabConfiguracionesDeUsuario);
            }
        }
        public static bool validarEmail(string email)
        {
            try
            {
                new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void SbtnAsiganrRolAUsuario_Click(object sender, EventArgs e)
        {
            string idUsuario = ScbxUsuariosRol.SelectedValue.ToString();
            string rol = ScbxSeleccionarRol.SelectedItem.ToString();
            Connection db = new Connection();
            db.AbrirConexion();
            string query = "UPDATE Usuario SET Rol ='"+rol+"' WHERE Id = "+idUsuario;
            db.ActualizarDatos(query);
            db.CerrarConexion();
        }
        private void ccbTipoServicio1_MeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    e.ItemHeight = 45;
                    break;
                case 1:
                    e.ItemHeight = 20;
                    break;
                case 2:
                    e.ItemHeight = 35;
                    break;
            }
            e.ItemWidth = 260;
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarCliente.Text=="")
            {
                lblAvisoNoCliente.Hide();
            }
        }

        private void btnAddClientH_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text!=""||txtApellido.Text!=""||txtTelefono.Text!=""||txtCorreo.Text!="")
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";
                allValues();
            }
            else
            {
                allValues();
            }
        }
        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                Connection connection = new Connection();
                connection.AbrirConexion();
                if (txtCliente.Text == "")
                {
                    MessageBox.Show("FAVOR DE LLENAR LOS COMPOS", "ADVERTENCIA",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else
                {
                    dgClientes.DataSource = connection.buscar("SELECT * FROM Cliente WHERE Nombre LIKE '%" + txtCliente.Text + "%'");
                }
                connection.CerrarConexion();
            }
        }
        private void pbBuscar_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.AbrirConexion();
            if (txtCliente.Text=="")
            {
                MessageBox.Show("Favor de llenar el campo","Advertencia");
            }
            else
            {
                dgClientes.DataSource = connection.buscar("SELECT * FROM Cliente WHERE Nombre LIKE '%" + txtCliente.Text + "%'");
            }
            connection.CerrarConexion();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.AbrirConexion();
            if (txtCliente.Text=="")
            {
                dgClientes.DataSource = connection.buscar("SELECT * FROM Cliente");
            }
            connection.CerrarConexion();
        }

        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgClientes.Rows[e.RowIndex];
            if (Convert.ToString(fila.Cells["Id"].Value).Equals("") || Convert.ToString(fila.Cells["Nombre"].Value).Equals("")
                || Convert.ToString(fila.Cells["Apellido"].Value).Equals("") || Convert.ToString(fila.Cells["Telefono"].Value).Equals("")
                || Convert.ToString(fila.Cells["Contacto"].Value).Equals(""))
            {
                Console.WriteLine("Datos vacios");
            }
            else
            {
                int id = Convert.ToInt32(fila.Cells["Id"].Value);
                DatosCliente datosCliente = new DatosCliente(id);
                datosCliente.Show();
            }
        }
        private void allValues()
        {
            GenerarId();
            btnAgregarCliente.Show();
            SbtnCancelar.Show();
            lblIdCliente.Show();
            lblTextoIdCliente.Show();
            btnAddClientH.Hide();
            txtBuscarCliente.Enabled = false;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            txtBuscarCliente.Text = "";
        }
        private void CDGReparacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void tabPuntoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            Connection connection = new Connection();
            connection.AbrirConexion();
            CDGReparacion.DataSource = connection.buscarReparacion("SELECT Reparacion.Id as ID,Cliente.Nombre as Cliente, Reparacion.Marca as Marca,Reparacion.Modelo as Modelo, Servicio.Nombre as Servicio, Pieza.Descripcion as Pieza, Estado.Nombre as Estado, Reparacion.Fecha as Fecha, Reparacion.Anticipo as Anticipo, Reparacion.CostoTotal as Total FROM Reparacion INNER JOIN Servicio on Reparacion.IdServicio=Servicio.Id INNER JOIN Cliente on Reparacion.IdCliente=Cliente.Id INNER JOIN Estado on Reparacion.IdEstado=Estado.Id INNER JOIN Pieza on Reparacion.IdPieza=Pieza.Id");
            connection.CerrarConexion();
            colores();
        }
        private void tabPuntoVenta_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            TabPage tp = tabPuntoVenta.TabPages[e.Index];
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            RectangleF headerRect = new RectangleF(e.Bounds.X, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height - 2);
            SolidBrush sb = new SolidBrush(Color.LightGray);
            if (tabPuntoVenta.SelectedIndex == e.Index)
                sb.Color = Color.LightSkyBlue;
            g.FillRectangle(sb, e.Bounds);
            g.DrawString(tp.Text, tabPuntoVenta.Font, new SolidBrush(Color.Black), headerRect, sf);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewLogin view = new ViewLogin();
            view.Show();
        }
        private void SbtnAgregarNuevoServicioCU_Click_1(object sender, EventArgs e)
        {
            NuevoServicio nuevo = new NuevoServicio();
            nuevo.Show();
        }

        private void JtxtBuscar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                Connection connection = new Connection();
                connection.AbrirConexion();
                CDGReparacion.DataSource = connection.buscarReparacion("SELECT Reparacion.Id as ID,Cliente.Nombre as Cliente, Reparacion.Marca as Marca,Reparacion.Modelo as Modelo, Servicio.Nombre as Servicio, Pieza.Descripcion as Pieza, Estado.Nombre as Estado, Reparacion.Fecha as Fecha, Reparacion.Anticipo as Anticipo, Reparacion.CostoTotal as Total FROM Reparacion INNER JOIN Servicio on Reparacion.IdServicio=Servicio.Id INNER JOIN Cliente on Reparacion.IdCliente=Cliente.Id INNER JOIN Estado on Reparacion.IdEstado=Estado.Id INNER JOIN Pieza on Reparacion.IdPieza=Pieza.Id where Reparacion.Id = "+JtxtBuscar2.Text);
                connection.CerrarConexion();
            }
        }

        private void pBoxBuscarRep_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.AbrirConexion();
            CDGReparacion.DataSource = connection.buscarReparacion("SELECT Reparacion.Id as ID,Cliente.Nombre as Cliente, Reparacion.Marca as Marca,Reparacion.Modelo as Modelo, Servicio.Nombre as Servicio, Pieza.Descripcion as Pieza, Estado.Nombre as Estado, Reparacion.Fecha as Fecha, Reparacion.Anticipo as Anticipo, Reparacion.CostoTotal as Total FROM Reparacion INNER JOIN Servicio on Reparacion.IdServicio=Servicio.Id INNER JOIN Cliente on Reparacion.IdCliente=Cliente.Id INNER JOIN Estado on Reparacion.IdEstado=Estado.Id INNER JOIN Pieza on Reparacion.IdPieza=Pieza.Id where Reparacion.Id = " + JtxtBuscar2.Text);
            connection.CerrarConexion();
        }

        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                if (txtBuscarCliente.Text == "")
                {
                    MessageBox.Show("El campo esta vacio", "Alerta");
                }
                else
                {
                    bool encontro = false;
                    Connection db = new DBConnectio.Connection();
                    db.AbrirConexion();

                    SqlDataReader dr = db.consulta("select * from Cliente where Id = '" + txtBuscarCliente.Text + "'");
                    //MessageBox.Show("select * from Cliente where Id=" + txtBuscarCliente.Text);
                    if (dr.Read())
                    {
                        lblTextoIdCliente.Visible = true;
                        lblIdCliente.Visible = true;
                        lblIdEquipo.Visible = true;
                        SlblRecibirEquipo.Visible = true;
                        lblIdCliente.Text = Convert.ToString(dr["Id"]);
                        txtNombre.Text = Convert.ToString(dr["Nombre"]);
                        txtApellido.Text = Convert.ToString(dr["Apellido"]);
                        txtTelefono.Text = Convert.ToString(dr["Telefono"]);
                        txtCorreo.Text = Convert.ToString(dr["Contacto"]);
                        encontro = true;
                    }

                    dr.Close();
                    db.CerrarConexion();
                    if (!encontro)
                    {
                        SbtnCancelar.Visible = true;
                        lblAvisoNoCliente.Visible = true;
                        btnAgregarCliente.Visible = true;
                        //---------------------------------------
                        SbtnCancelar.Visible = true;
                        txtNombre.Enabled = true;
                        txtApellido.Enabled = true;
                        txtTelefono.Enabled = true;
                        txtCorreo.Enabled = true;
                        txtNombre.Text = "";
                        txtApellido.Text = "";
                        txtCorreo.Text = "";
                        txtTelefono.Text = "";
                        pictureBuscar.Visible = true;
                        //---------------------------------------
                        GenerarId();
                        GenerarIdEquipo();

                    }
                    else
                    {
                        lblAvisoNoCliente.Visible = false;
                        btnAddClientH.Visible = true;
                        btnAgregarCliente.Visible = false;
                        SbtnCancelar.Visible = false;
                        txtNombre.Enabled = false;
                        txtApellido.Enabled = false;

                    }
                }
            }
        }

        private void tableOrdenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = tableOrdenes.Rows[e.RowIndex];
                if (Convert.ToString(fila.Cells["Id"].Value).Equals("") || Convert.ToString(fila.Cells["Descripcion"].Value).Equals("")
                    || Convert.ToString(fila.Cells["Estado"].Value).Equals("") || Convert.ToString(fila.Cells["FechaPedida"].Value).Equals("")
                    || Convert.ToString(fila.Cells["FechaLlegaAprox"].Value).Equals(""))
                {
                    Console.WriteLine("Datos vacios");
                }
                else
                {
                    int id = Convert.ToInt32(fila.Cells["Id"].Value);
                    DatosPieza datosPieza = new DatosPieza(id);
                    datosPieza.Show();
                }
            }
            catch (Exception)
            {
            }
        }

        private void ordenesTab_Enter(object sender, EventArgs e)
        {
            conexion.AbrirConexion();
            tableOrdenes.DataSource = conexion.buscarReparacion("SELECT * FROM Pieza order by FechaPedida asc");
            conexion.CerrarConexion();
        }

        private void SlblPiezasOrdenadas_MouseMove(object sender, MouseEventArgs e)
        {
            conexion.AbrirConexion();
            tableOrdenes.DataSource = conexion.buscarReparacion("SELECT * FROM Pieza order by FechaPedida asc");
            conexion.CerrarConexion();
        }

        private void JbtnaddServicio_Click(object sender, EventArgs e)
        {
            NuevoServicio nuevo = new NuevoServicio();
            nuevo.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if(JradioTodos.Checked){
                JradioTodos_CheckedChanged(sender, e);
            }else if (JTerminados.Checked)
            {
                JTerminados_CheckedChanged(sender, e);
            }else if (CEspera.Checked)
            {
                CEspera_CheckedChanged(sender, e);
            }
            else if (JProceso.Checked)
            {
                JProceso_CheckedChanged(sender, e);
            }
        }

        private void ccbTipoServicio1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}