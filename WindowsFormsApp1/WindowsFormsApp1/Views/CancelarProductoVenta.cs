using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsFormsApp1.DBConnectio;

namespace WindowsFormsApp1.Views
{
    public partial class CancelarProductoVenta : Form
    {
        static int indice = 0;
        static string responsable = "";
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
                //-------------------------------------------------------------------
                //Buscar IdUsuario
                string idUsuario = connection.getIdUsuario("SELECT Id FROM Usuario WHERE NombreUsuario = '"+ responsable + "'");
                connection.CerrarConexion();
                //-------------------------------------------------------------------
                //Insertar datos en tabla cancelacion
                connection.AbrirConexion();
                string mifecha = DateTime.Today.ToString();//Dia/Mes/Año : Hora
                string hora_de_cancelacion = DateTime.Now.ToLongTimeString();
                string datos = "[Código : " + txtCodigoCancelacion.Text + "] [Producto cancelado : " + txtDescripcionCancelacion.Text + "] [Motivo : "+txtMotivoDeCancelacion.Text+"] [Devolución de efectivo : " + txtTotalDeCancelacion.Text+"] [Hora de cancelacion : "+ hora_de_cancelacion+"]";
                string query = "INSERT INTO Cancelacion (Id, Motivo, Fecha, IdUsuario, IdVenta) VALUES (@Id,@Motivo,@Fecha,@IdUsuario,@IdVenta)";
                if (connection.AgregarCancelacion(query, id, datos, mifecha, idUsuario, 1) > 0)
                {
                    MessageBox.Show("Cancelacion Exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    ViewTabs v = new ViewTabs();
                }
                else
                {
                    MessageBox.Show("Cancelacion Fallida", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                connection.CerrarConexion();
                this.Hide();
            }
        }
        public void setDatos(string cod,string des,string cant,string tot,int i,string res)
        {
            txtCodigoCancelacion.Text = cod;
            txtDescripcionCancelacion.Text = des;
            txtCantidadCancelacion.Text = cant;
            txtTotalDeCancelacion.Text = tot;
            indice = i;
            responsable = res;
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
