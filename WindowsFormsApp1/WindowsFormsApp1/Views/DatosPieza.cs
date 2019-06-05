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
    public partial class DatosPieza : Form
    {
        int idPieza=0;
        public DatosPieza(int id)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            Connection connection = new Connection();
            connection.AbrirConexion();
            SqlDataReader dataReader = connection.consulta("SELECT Descripcion,Estado,FechaEncargada,FechaLlegaAprox FROM Pieza WHERE Id=" + id);
            if (dataReader.Read())
            {
                txtDescPieza.Text = Convert.ToString(dataReader["Descripcion"]);
                cBoxEstadosPieza.Text = Convert.ToString(dataReader["Estado"]);
                txtFechaPPieza.Text = Convert.ToString(dataReader["FechaEncargada"]);
                txtFechaLPieza.Text = Convert.ToString(dataReader["FechaLlegaAprox"]);
            }
            idPieza = id;
            connection.CerrarConexion();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparap, int lparam);
        private void BtnAceptarPieza_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.AbrirConexion();
            if (BtnAceptarPieza.Text.Equals("Aceptar"))
            {
                this.Hide();
            }
            if (BtnAceptarPieza.Text.Equals("Guardar"))
            {
                DialogResult result = MessageBox.Show("Esta seguro que desea cambiar el estado?","Informacion",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (result==DialogResult.Yes)
                {
                    int filas = connection.actualizarDatos("UPDATE Pieza SET Estado='" + cBoxEstadosPieza.Text + "' WHERE Id=" + idPieza);
                    MessageBox.Show("Los datos se actualizaron correctamente");
                    BtnAceptarPieza.Text = "Aceptar";
                    btnCancelarPieza.Visible = false;
                    this.Hide();
                }
            }
            connection.CerrarConexion();
        }

        private void btnCancelarPieza_Click(object sender, EventArgs e)
        {

            Connection connection = new Connection();
            connection.AbrirConexion();
            DialogResult result = MessageBox.Show("Esta seguro que desea cancelar la modificacion?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                SqlDataReader dataReader = connection.consulta("SELECT Descripcion,Estado,FechaEncargada,FechaLlegaAprox FROM Pieza WHERE Id=" + idPieza);
                if (dataReader.Read())
                {
                    txtDescPieza.Text = Convert.ToString(dataReader["Descripcion"]);
                    cBoxEstadosPieza.Text = Convert.ToString(dataReader["Estado"]);
                    txtFechaPPieza.Text = Convert.ToString(dataReader["FechaEncargada"]);
                    txtFechaLPieza.Text = Convert.ToString(dataReader["FechaLlegaAprox"]);
                    cBoxEstadosPieza.Enabled = false;
                    btnCancelarPieza.Visible = false;
                    BtnAceptarPieza.Text = "Aceptar";
                }
                MessageBox.Show("Cancelacion exitosa");
            }
            connection.CerrarConexion();
        }

        private void btnModifcarPieza_Click(object sender, EventArgs e)
        {
            cBoxEstadosPieza.Enabled = true;
            BtnAceptarPieza.Text = "Guardar";
            btnCancelarPieza.Visible = true;
        }

        private void DatosPieza_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PDatosPieza_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
