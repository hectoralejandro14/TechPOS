﻿using System;
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
            ccbTipoServicio.DisplayMember = "Nombre";
            ccbTipoServicio.ValueMember = "Id";
            ccbTipoServicio.DataSource = dt;
            //---------Combo box responsable
            DataTable dt1 = new DataTable();
            conexion.AbrirConexion();
            SqlDataAdapter da1 = conexion.consultaMasDatos("select Id, Nombre from Usuario");
            da1.Fill(dt1);
            conexion.CerrarConexion();
            comboResponsable.DisplayMember = "Nombre";
            comboResponsable.ValueMember = "Id";
            comboResponsable.DataSource = dt1;


        }
        private void linkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            ViewLogin view = new ViewLogin();
            view.Show();
        }
        //------------------------------------------------------------------------------------
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
            Ecargar_Pieza encargar = new Ecargar_Pieza();

            encargar.Show();
        }
        private void pictureBuscar_Click(object sender, System.EventArgs e)
        {
            bool encontro = false;
            DBConnectio.Connection db = new DBConnectio.Connection();
            db.AbrirConexion();
            SqlDataReader dr=db.consulta("select * from Cliente where Id=" + txtBuscarCliente.Text);
            MessageBox.Show("select * from Cliente where Id=" + txtBuscarCliente.Text);
            if (dr.Read())
            {
                txtNombre.Text= Convert.ToString(dr["Nombre"]);
                txtApellido.Text= Convert.ToString(dr["Apellido"]);
                txtTelefono.Text= Convert.ToString(dr["Telefono"]);
                txtCorreo.Text= Convert.ToString(dr["Contacto"]);
                encontro = true;
            }
            db.CerrarConexion();
            if (!encontro)
            {
                lblAvisoNoCliente.Visible = true;
                btnAgregarCliente.Visible = true;
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

            if (validarEmail(txtCorreo.Text))
            {
                MessageBox.Show("FORMATO DE CORREO CORRECTO", "ACEPTADO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                //Agregar Cliente en bd
            }
            else
            {
                MessageBox.Show("FORMATO DE CORREO NO VALIDO", "RECHAZADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void tabReparacion_Click(object sender, EventArgs e)
        {

        }
        //------------------------------------------------------------------------------------
        //Generales
        public void MostrarConfiguracionUsuarios(int IdRol)
        {
            if (IdRol == 1)
            {
                tabPuntoVenta.TabPages.Add(tabConfiguracionesDeUsuario);
            }
        }
        private void SbtnGuardarRol_Click(object sender, EventArgs e)
        {
            string _rol = StxtRol.Text;
            Random random = new Random();
            decimal id_random = random.Next(1, 1000000000);
            string consulta = "INSERT INTO Rol (Id,NombreRol) VALUES ("+id_random+",'"+_rol+"')";
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
            string tipoDiag = "";
            DateTime Hoy = DateTime.Today;
            string fecha_actual = Hoy.ToString("yyyy-MM-dd");
            DBConnectio.Connection db = new DBConnectio.Connection();
            db.AbrirConexion();
            if (rbDiagnosticoEspecifico.Checked)
            {
                tipoDiag = "Diagnóstico específico";
            }else if (rbDiagnosticoRapido.Checked)
            {
                tipoDiag = "Diagnóstico rápido";
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de diagnóstico", "Diagnóstico", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            if (rbDiagnosticoEspecifico.Checked || rbDiagnosticoRapido.Checked)
            {
                String sql = "Insert into Reparacion values(" + 17 + ",'" + txtMarca.Text
                    + "','" + txtModelo.Text
                    + "','" + txtDescripcionDeFalla.Text
                    + "','" + tipoDiag + ": " + txtDescripcionDiagnosticoEspecifico.Text
                    + "'," + ccbTipoServicio.SelectedValue.ToString()
                    + "," + txtAnticipo.Text + ",6,'" + fecha_actual + "','" + txtBuscarCliente.Text
                    + "'," + comboResponsable.SelectedValue.ToString() + "," + txtTotal.Text
                    + ",0)";
                MessageBox.Show(sql);
                db.AddElements(sql);
                db.CerrarConexion();
            }
        }

        private void ViewTabs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techPOSdbDataSet.Reparacion' table. You can move, or remove it, as needed.
            this.reparacionTableAdapter.Fill(this.techPOSdbDataSet.Reparacion);
        }

        //Carlos
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
                CDGReparacion.DataSource = connection.buscarReparacion("SELECT * FROM Reparacion WHERE Id ='"+ codigo +"'");
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
            CDGReparacion.DataSource = connection.buscarReparacion("SELECT * FROM Reparacion");
            connection.CerrarConexion();
        }

        private void JProceso_CheckedChanged(object sender, EventArgs e)
        {
            Jtxtbuscar.Text = "";
            Connection connection = new Connection();
            connection.AbrirConexion();
            CDGReparacion.DataSource = connection.buscarReparacion("SELECT * FROM Reparacion WHERE IdEstado = '" + 7 + "'");
            connection.CerrarConexion();
        }

        private void CEspera_CheckedChanged(object sender, EventArgs e)
        {
            Jtxtbuscar.Text = "";
            Connection connection = new Connection();
            connection.AbrirConexion();
            CDGReparacion.DataSource = connection.buscarReparacion("SELECT * FROM Reparacion WHERE IdEstado = '" + 6 + "'");
            connection.CerrarConexion();
        }

        private void JTerminados_CheckedChanged(object sender, EventArgs e)
        {
            Jtxtbuscar.Text = "";
            Connection connection = new Connection();
            connection.AbrirConexion();
            CDGReparacion.DataSource = connection.buscarReparacion("SELECT * FROM Reparacion WHERE IdEstado = '" + 3 + "'");
            connection.CerrarConexion();
        }
    }
        /*private void SbtnAgregarRol_Click(object sender, EventArgs e)
        {
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
}

