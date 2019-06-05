using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DBConnectio;

namespace WindowsFormsApp1.Views
{
    public partial class DatosCliente : Form
    {
        int idCliente;
        public DatosCliente(int id)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            Connection connection = new Connection();
            connection.AbrirConexion();
            SqlDataReader dataReader = connection.consulta("SELECT Nombre,Apellido,Telefono,Contacto FROM Cliente WHERE Id="+id);
            if (dataReader.Read())
            {
                txtNombreCliente.Text = Convert.ToString(dataReader["Nombre"]);
                txtApellidoCliente.Text = Convert.ToString(dataReader["Apellido"]);
                txtTelefonoCliente.Text = Convert.ToString(dataReader["Telefono"]);
                txtContactoCliente.Text = Convert.ToString(dataReader["Contacto"]);
            }
            connection.CerrarConexion();
            idCliente = id;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparap, int lparam);

        private void btnAceptarCliente_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            if (btnAceptarCliente.Text.Equals("Aceptar"))
            {
                this.Hide();
            }
            if (btnAceptarCliente.Text.Equals("Guardar"))
            {
                if (txtNombreCliente.Text.Equals("") || txtApellidoCliente.Text.Equals("")||
                    txtTelefonoCliente.Text.Equals("") || txtContactoCliente.Text.Equals(""))
                {
                    MessageBox.Show("No se permiten espacios vacios","Advertencia");
                }
                else
                {
                    connection.AbrirConexion();
                    DialogResult resultado = MessageBox.Show("Esta seguro que desea guardar los cambios", "Seguridad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado==DialogResult.Yes)
                    {
                        connection.modificarCliente("UPDATE Cliente SET Nombre='"+txtNombreCliente.Text+"', Apellido='"+txtApellidoCliente.Text+"', " +
                            "Telefono='"+txtTelefonoCliente.Text+"', Contacto='"+txtContactoCliente.Text+"' WHERE Id="+idCliente);
                        MessageBox.Show("Los datos se han cambiado correctamente");
                        consultaSeleccionarCliente();
                        btnAceptarCliente.Text="Aceptar";
                        inhabilitarTxtBox();
                        this.Hide();
                    }
                    else
                    {
                        consultaSeleccionarCliente();
                        inhabilitarTxtBox();
                        btnAceptarCliente.Text = "Guardar";
                    }
                    connection.CerrarConexion();
                }
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            txtNombreCliente.Enabled = true;
            txtApellidoCliente.Enabled = true;
            txtTelefonoCliente.Enabled = true;
            txtContactoCliente.Enabled = true;
            btnAceptarCliente.Text = "Guardar";
            btnCancelarMod.Visible = true;
        }

        public void consultaSeleccionarCliente()
        {
            Connection connection = new Connection();
            connection.AbrirConexion();
            SqlDataReader dataReader = connection.consulta("SELECT Nombre,Apellido,Telefono,Contacto FROM Cliente WHERE Id=" + idCliente);
            if (dataReader.Read())
            {
                txtNombreCliente.Text = Convert.ToString(dataReader["Nombre"]);
                txtApellidoCliente.Text = Convert.ToString(dataReader["Apellido"]);
                txtTelefonoCliente.Text = Convert.ToString(dataReader["Telefono"]);
                txtContactoCliente.Text = Convert.ToString(dataReader["Contacto"]);
            }
            connection.CerrarConexion();
        }

        public void inhabilitarTxtBox()
        {
            txtNombreCliente.Enabled = false;
            txtApellidoCliente.Enabled = false;
            txtTelefonoCliente.Enabled = false;
            txtContactoCliente.Enabled = false;
        }

        private void btnCancelarMod_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro que desea cancelar la modificacion", "Cancelacion", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Se ha cancelado la modificacion");
                consultaSeleccionarCliente();
                inhabilitarTxtBox();
                btnCancelarMod.Visible = false;
                btnAceptarCliente.Text = "Aceptar";
            }
        }

        private void DatosCliente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PDatosCliente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
