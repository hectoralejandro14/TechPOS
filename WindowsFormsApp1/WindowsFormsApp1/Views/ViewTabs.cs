using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Windows.Forms;
using WindowsFormsApp1.DBConnectio;

namespace WindowsFormsApp1.Views
{
    public partial class ViewTabs : Form
    {
        private DBConnectio.Connection conexion = new DBConnectio.Connection();
        private static int index = 0;
        public ViewTabs()
        {
            InitializeComponent();
            txtDescripcionDeFalla.ScrollBars = ScrollBars.Vertical;
            txtDescripcionDiagnosticoEspecifico.ScrollBars = ScrollBars.Vertical;
            tabPuntoVenta.TabPages.Remove(tabConfiguracionesDeUsuario);
            Jtxtbuscar.MaxLength = 4;
            DataTable dt = new DataTable();
            //---------Combo box servicio
            conexion.AbrirConexion();
            SqlDataAdapter da = conexion.consultaMasDatos("select Id, Nombre from Servicio");
            da.Fill(dt);
            conexion.CerrarConexion();
            //GenerarIdEquipo();
            ccbTipoServicio1.DisplayMember = "Nombre";
            ccbTipoServicio1.ValueMember = "Id";
            ccbTipoServicio1.DataSource = dt;
            //---------Combo box responsable
            DataTable dt1 = new DataTable();
            conexion.AbrirConexion();
            SqlDataAdapter da1 = conexion.consultaMasDatos("select Id, Nombre from Usuario");
            da1.Fill(dt1);
            conexion.CerrarConexion();
            comboResponsable.DisplayMember = "Nombre";
            comboResponsable.ValueMember = "Id";
            comboResponsable.DataSource = dt1;
            //------------------------------------------
            SbtnCancelar.Visible = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
            //------------------------------------------
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            GenerarIdEquipo();
            //-------------------------------------------
           

        }
        private void linkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ViewLogin view = new ViewLogin();
            view.Show();
        }
        //---------------------------------------------------------------------------------------------------
        //Tab Recibir Equipo
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
            if (txtBuscarCliente.Text=="")
            {
                MessageBox.Show("El campo esta vacio","Alerta");
            }
            else
            {
                bool encontro = false;
                DBConnectio.Connection db = new DBConnectio.Connection();
                db.AbrirConexion();
                SqlDataReader dr = db.consulta("select * from Cliente where Id=" + txtBuscarCliente.Text);
                //MessageBox.Show("select * from Cliente where Id=" + txtBuscarCliente.Text);
                if (dr.Read())
                {
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
                    //---------------------------------------
                    GenerarId();

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
            else
            {
                e.Handled = true;
            }
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

            Connection conexion = new Connection();
            conexion.AbrirConexion();
            if ((!txtNombre.Text.Equals("")) && (!txtApellido.Text.Equals("")) && (!txtTelefono.Text.Equals("")) && (!txtCorreo.Text.Equals("")))
            {
                if (validarEmail(txtCorreo.Text))
                {
                    
                    decimal idR = Convert.ToDecimal(txtBuscarCliente.Text);
                    //Agregar cliente
                    String sql = "INSERT INTO Cliente (Id,Nombre,Apellido,Telefono,Contacto) VALUES (" + idR + ",'" + txtNombre.Text + "','" + txtApellido.Text + "'," + txtTelefono.Text + ",'" + txtCorreo.Text + "')";
                    conexion.AddElements(sql);
                    conexion.CerrarConexion();

                    //--------------------------------------------------
                    btnAgregarCliente.Visible = false;
                    SbtnCancelar.Visible = false;
                    txtBuscarCliente.Enabled = true;
                    SbtnCancelar.Enabled = false;
                    btnAgregarCliente.Visible = false;
                    SbtnCancelar.Visible = false;
                    //--------------------------------------------------
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtCorreo.Enabled = false;
                    lblAvisoNoCliente.Visible = false;
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
            btnAgregarCliente.Visible = false;
            SbtnCancelar.Visible = false;
            conexion.CerrarConexion();

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
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void tabReparacion_Click(object sender, EventArgs e)
        {

        }
        //---------------------------------------------------------------------------------------------------
        //Generales
        public void MostrarConfiguracionUsuarios(string Rol)
        {
            if (Rol == "Administrador")
            {
                tabPuntoVenta.TabPages.Add(tabConfiguracionesDeUsuario);
            }
        }
        private void SbtnGuardarRol_Click(object sender, EventArgs e)
        {
            string _rol = StxtRol.Text;
            Random random = new Random();
            decimal id_random = random.Next(1, 1000000000);
            string consulta = "INSERT INTO Rol (Id,NombreRol) VALUES (" + id_random + ",'" + _rol + "')";
            MessageBox.Show(consulta);
            conexion.AddElements(consulta);
        }
        private void SbtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevoUsuario = new NuevoUsuario();
            nuevoUsuario.Show();
        }
        private void btnAgregrEquipos_Click(object sender, EventArgs e)
        {
            if (txtBuscarCliente.Text != "")
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
                    string concatenarDiagTex = tipoDiag + " : "+txtDescripcionDiagnosticoEspecifico.Text;
                    String sql = "Insert into Reparacion (Id,Marca,Modelo,Falla,Diagnostico,IdServicio,Anticipo,IdEstado,Fecha,IdCliente,IdUsuario,CostoTotal,IdPieza) values(" 
                        + lblIdEquipo.Text + ",'" + txtMarca.Text
                        + "','" + txtModelo.Text
                        + "','" + txtDescripcionDeFalla.Text
                        + "','" + concatenarDiagTex
                        + "','" + ccbTipoServicio1.SelectedValue
                        + "'," + txtAnticipo.Text + ",6,'" + fecha_actual + "','" + txtBuscarCliente.Text
                        + "','" + comboResponsable.SelectedValue.ToString() + "'," + txtTotal.Text
                        + ",1)";
                    /*String sql = "Insert into Reparacion values(" + lblIdEquipo.Text + ",'" + txtMarca.Text
                        + "','" + txtModelo.Text
                        + "','" + txtDescripcionDeFalla.Text
                        + "','" + tipoDiag + ": " + txtDescripcionDiagnosticoEspecifico.Text
                        + "'," + ccbTipoServicio1.SelectedValue.ToString()
                        + "," + txtAnticipo.Text + ",6,'" + fecha_actual + "','" + txtBuscarCliente.Text
                        + "'," + comboResponsable.SelectedValue.ToString() + "," + txtTotal.Text
                        + ",0)";*/
                    //MessageBox.Show(sql);
                    db.AddElements(sql);
                    db.CerrarConexion();
                }
            }
            else
            {
                MessageBox.Show("Id del cliente vacio");
            }
        }
        private void ViewTabs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techPOSdbDataSet.Reparacion' table. You can move, or remove it, as needed.
            //this.reparacionTableAdapter.Fill(this.techPOSdbDataSet.Reparacion);
            Connection connection = new Connection();
            connection.AbrirConexion();
            CDGReparacion.DataSource = connection.buscarReparacion("SELECT Reparacion.Id as ID, Reparacion.Marca as Marca,Reparacion.Modelo as Modelo,Reparacion.Falla as Falla,Reparacion.Diagnostico as Diagnostico,Servicio.Nombre as Servicio,Reparacion.Anticipo as Anticipo,Estado.Nombre as Estado,Reparacion.Fecha as Fecha,Cliente.Nombre as Cliente, Usuario.Nombre as Usuario, Reparacion.CostoTotal as Total, Pieza.Descripcion as Pieza FROM Reparacion INNER JOIN Servicio on Reparacion.IdServicio=Servicio.Id INNER JOIN Cliente on Reparacion.IdCliente=Cliente.Id INNER JOIN Estado on Reparacion.IdEstado=Estado.Id INNER JOIN Usuario on Reparacion.IdUsuario=Usuario.Id INNER JOIN Pieza on Reparacion.IdPieza=Pieza.Id");
            connection.CerrarConexion();
        }
        //----------------------------------------------------------------------------------------------------
        private void JPicture_Click(object sender, EventArgs e)
        {
            if (Jtxtbuscar.Text == "")
            {
                MessageBox.Show("El campo esta vacio");
            }
            else
            {
                JradioTodos.Checked = false;
                JTerminados.Checked = false;
                JProceso.Checked = false;
                CEspera.Checked = false;
                Connection connection = new Connection();
                connection.AbrirConexion();
                int codigo = Convert.ToInt32(Jtxtbuscar.Text);
                CDGReparacion.DataSource = connection.buscarReparacion("SELECT * FROM Reparacion WHERE Id ='" + codigo + "'");
                connection.CerrarConexion();
                Jtxtbuscar.Text = "";
            }
            //Carlos

            /*private void SbtnAgregarRol_Click(object sender, EventArgs e)
            {
                Random random = new Random();
                decimal _random = random.Next(1, 1000000000);
                string _Rol = StxtAgregarRol.Text;
                string consulta = "INSERT INTO Rol (Id,NombreRol) VALUES (@Id,@NombreRol)";
                //Abrir conexion
                conexion.AbrirConexion();
                //Agregar datos
                conexion.AgregarRoles(consulta,_random,_Rol);
                //cerrar conexion
                conexion.CerrarConexion(); 
            }*/
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
            Jtxtbuscar.Text = "";
            Connection connection = new Connection();
            connection.AbrirConexion();
            CDGReparacion.DataSource = connection.buscarReparacion("SELECT Reparacion.Id as ID, Reparacion.Marca as Marca,Reparacion.Modelo as Modelo,Reparacion.Falla as Falla,Reparacion.Diagnostico as Diagnostico,Servicio.Nombre as Servicio,Reparacion.Anticipo as Anticipo,Estado.Nombre as Estado,Reparacion.Fecha as Fecha,Cliente.Nombre as Cliente, Usuario.Nombre as Usuario, Reparacion.CostoTotal as Total, Pieza.Descripcion as Pieza FROM Reparacion INNER JOIN Servicio on Reparacion.IdServicio=Servicio.Id INNER JOIN Cliente on Reparacion.IdCliente=Cliente.Id INNER JOIN Estado on Reparacion.IdEstado=Estado.Id INNER JOIN Usuario on Reparacion.IdUsuario=Usuario.Id INNER JOIN Pieza on Reparacion.IdPieza=Pieza.Id");
            connection.CerrarConexion();
        }
        private void JProceso_CheckedChanged(object sender, EventArgs e)
        {
            Jtxtbuscar.Text = "";
            Connection connection = new Connection();
            connection.AbrirConexion();
            CDGReparacion.DataSource = connection.buscarReparacion("SELECT Reparacion.Id as ID, Reparacion.Marca as Marca,Reparacion.Modelo as Modelo,Reparacion.Falla as Falla,Reparacion.Diagnostico as Diagnostico,Servicio.Nombre as Servicio,Reparacion.Anticipo as Anticipo,Estado.Nombre as Estado,Reparacion.Fecha as Fecha,Cliente.Nombre as Cliente, Usuario.Nombre as Usuario, Reparacion.CostoTotal as Total, Pieza.Descripcion as Pieza FROM Reparacion INNER JOIN Servicio on Reparacion.IdServicio=Servicio.Id INNER JOIN Cliente on Reparacion.IdCliente=Cliente.Id INNER JOIN Estado on Reparacion.IdEstado=Estado.Id INNER JOIN Usuario on Reparacion.IdUsuario=Usuario.Id INNER JOIN Pieza on Reparacion.IdPieza=Pieza.Id WHERE IdEstado = '" + 7 + "'");
            connection.CerrarConexion();
        }
        private void CEspera_CheckedChanged(object sender, EventArgs e)
        {
            Jtxtbuscar.Text = "";
            Connection connection = new Connection();
            connection.AbrirConexion();
            CDGReparacion.DataSource = connection.buscarReparacion("SELECT Reparacion.Id as ID, Reparacion.Marca as Marca,Reparacion.Modelo as Modelo,Reparacion.Falla as Falla,Reparacion.Diagnostico as Diagnostico,Servicio.Nombre as Servicio,Reparacion.Anticipo as Anticipo,Estado.Nombre as Estado,Reparacion.Fecha as Fecha,Cliente.Nombre as Cliente, Usuario.Nombre as Usuario, Reparacion.CostoTotal as Total, Pieza.Descripcion as Pieza FROM Reparacion INNER JOIN Servicio on Reparacion.IdServicio=Servicio.Id INNER JOIN Cliente on Reparacion.IdCliente=Cliente.Id INNER JOIN Estado on Reparacion.IdEstado=Estado.Id INNER JOIN Usuario on Reparacion.IdUsuario=Usuario.Id INNER JOIN Pieza on Reparacion.IdPieza=Pieza.Id WHERE IdEstado = '" + 6 + "'");
            connection.CerrarConexion();
        }
        private void JTerminados_CheckedChanged(object sender, EventArgs e)
        {
            Jtxtbuscar.Text = "";
            Connection connection = new Connection();
            connection.AbrirConexion();
            CDGReparacion.DataSource = connection.buscarReparacion("SELECT Reparacion.Id as ID, Reparacion.Marca as Marca,Reparacion.Modelo as Modelo,Reparacion.Falla as Falla,Reparacion.Diagnostico as Diagnostico,Servicio.Nombre as Servicio,Reparacion.Anticipo as Anticipo,Estado.Nombre as Estado,Reparacion.Fecha as Fecha,Cliente.Nombre as Cliente, Usuario.Nombre as Usuario, Reparacion.CostoTotal as Total, Pieza.Descripcion as Pieza FROM Reparacion INNER JOIN Servicio on Reparacion.IdServicio=Servicio.Id INNER JOIN Cliente on Reparacion.IdCliente=Cliente.Id INNER JOIN Estado on Reparacion.IdEstado=Estado.Id INNER JOIN Usuario on Reparacion.IdUsuario=Usuario.Id INNER JOIN Pieza on Reparacion.IdPieza=Pieza.Id WHERE IdEstado = '" + 3 + "'");
            connection.CerrarConexion();
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
       //-------------------------------------------------------------------------------------------------------
        public void Bienvenido(string usuario)
        {
            this.CNombreUsuarioLblVenta.Text = usuario;
        }
        public void GenerarId()
        {
            Connection conexion = new Connection();
            Random random = new Random();
            conexion.AbrirConexion();
            decimal idR = random.Next(0, 1000000000);
            do
            {
                idR = random.Next(0, 1000000000);
                if (!conexion.VerificarExistenciaDeId(idR))
                {
                    break;
                }
            } while (true);
            conexion.CerrarConexion();
            txtBuscarCliente.Text = "" + idR;
        }
        public void GenerarIdEquipo()
        {
            Connection conexion = new Connection();
            Random random = new Random();
            conexion.AbrirConexion();
            decimal idR = random.Next(0, 1000000000);
            do
            {
                idR = random.Next(0, 1000000000);
                if (!conexion.VerificarExistenciaDeIdRep(Convert.ToString(idR)))
                {
                    break;
                }
            } while (true);
            conexion.CerrarConexion();
            lblIdEquipo.Text = "" + idR;
        }
        private void SbtnCancelar_Click(object sender, EventArgs e)
        {
            txtBuscarCliente.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            //--------------------------------
            SbtnCancelar.Visible = false;
            btnAddClientH.Visible = true;
            btnAgregarCliente.Visible = false;
            //--------------------------------
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
            

        }
        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void ViewTabs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
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
            txtTelefono.Text= "";
            txtCorreo.Enabled = true;
            txtCorreo.Text = "";
            btnAddClientH.Visible = false;
            
        }
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtBuscarCliente.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            //----------------------------------------------
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtDescripcionDeFalla.Text = "";
            txtDescripcionDiagnosticoEspecifico.Text = "";
            //---------------------------------------------
            txtTotal.Text = "";
            txtAnticipo.Text = "";
        }
        private void lupaImg_Click(object sender, EventArgs e)
        {
            Connection db = new Connection();
            db.AbrirConexion();
            if (db.Existe(buscarTbxVentas.Text))
            {              
                Venta(index);
                index = index + 1;             
            }
            else
            {
                MessageBox.Show("PRODUCTO NO ENCONTRADO \n VERIFIQUE QUE EL CODIGO ESTE INGRESADO CORRECTAMENTE", "PRODUCTO NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buscarTbxVentas.Text = "";
            }
            db.CerrarConexion();
        }
        private void Venta(int fila)
        {
           
        }
    }    
}
