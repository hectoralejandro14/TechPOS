using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsFormsApp1.DBConnectio;

namespace WindowsFormsApp1.Views
{
    public partial class CancelarProductoVenta : Form
    {
        static int indice = 0;
        public CancelarProductoVenta()
        {
            InitializeComponent();
            //-----------------------------------------
            //Datos no editables
            txtCodigoCancelacion.Enabled = false;
            txtDescripcionCancelacion.Enabled = false;
            txtCantidadCancelacion.Enabled = false;
            txtTotalDeCancelacion.Enabled = false;
            //-----------------------------------------
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparap, int lparam);
        private void btnAceptarCancelacionVenta_Click(object sender, System.EventArgs e)
        {
            if (txtMotivoDeCancelacion.Text =="")
            {
                MessageBox.Show("Es necesario agregar un motivo de cancelación", "¿Motivo?", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Connection connection = new Connection();
                connection.AbrirConexion();
                decimal id = UltimoIdIngresado();
                string mifecha = DateTime.Today.ToString();//Dia/Mes/Año : Hora
                string datos = "Código : " + txtCodigoCancelacion.Text + ". Producto cancelado :" + txtDescripcionCancelacion.Text + ". Devolución de efectivo : " + txtTotalDeCancelacion.Text;
                string query = "INSERT INTO Cancelacion (Id, Motivo, Fecha, IdUsuario, IdVenta) VALUES (" + id + ", '" + datos + "'," + mifecha + ",1,1)";
                if (connection.AgregarCancelacion(query, id, datos, mifecha, 1, 1) > 0)
                {
                    MessageBox.Show("Cancelacion Exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    ViewTabs v = new ViewTabs();
                    v.RemoveElement(indice);
                }
                else
                {
                    MessageBox.Show("Cancelacion Fallida", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                connection.CerrarConexion();
                this.Hide();
            }
        }
        public void setDatos(string cod,string des,string cant,string tot,int i)
        {
            txtCodigoCancelacion.Text = cod;
            txtDescripcionCancelacion.Text = des;
            txtCantidadCancelacion.Text = cant;
            txtTotalDeCancelacion.Text = tot;
            indice = i;
        }

        private void CancelarProductoVenta_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void SpanelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public decimal UltimoIdIngresado()
        {
            decimal id = 0;
            Connection connection = new Connection();
            connection.AbrirConexion();
            decimal idCancelacion = connection.generarId("SELECT MAX(Id) FROM Cancelacion");
            if (idCancelacion == 0)
            {
                idCancelacion = 1;
            }
            return idCancelacion;
        }
    }
}
