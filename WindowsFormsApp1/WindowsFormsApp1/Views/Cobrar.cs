using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsFormsApp1.DBConnectio;

namespace WindowsFormsApp1.Views
{
    public partial class Cobrar : Form
    {
        DataGridView datos = new DataGridView();
        decimal dineroRecibido = 0;
        decimal totalAPagar = 0;
        Connection connection = new Connection();
        int idUsuario = 0;
        public Cobrar(decimal totalPagar,int idUsuarioVenta)
        {
            InitializeComponent();
            ArrayList tipoPago = new ArrayList();
            tipoPagoCbx.Text = "Elija tipo de pago";
            tipoPago.Add("Efectivo");
            tipoPago.Add("Tarjeta de crédito");
            tipoPago.Add("Tarjeta de débito");
            for (int i = 0; i < tipoPago.Count; i++)
            {
                tipoPagoCbx.Items.Add(tipoPago[i]);
            }
            //------------------------------
            txtTotalVenta.Enabled = false;
            txtCambioVenta.Enabled = false;
            txtTotalVenta.Text = totalPagar.ToString();
            totalAPagar = totalPagar;
            //------------------------------;
            idUsuario = idUsuarioVenta;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparap, int lparam);
        private void Cobrar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void SpanelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCobrarVentaNI_Click(object sender, System.EventArgs e)
        {
            int idVenta = 0;
            DateTime date = DateTime.Now;
            if (dineroRecibido<totalAPagar)
            {
                MessageBox.Show("No cumple con el pago total");
            }
            else
            {
                MessageBox.Show("LA VENTA SE REALIZO EXITOSAMENTE");
                connection.AbrirConexion();
                idVenta = connection.generarId("Select MAX(Id) from Venta");
                connection.CerrarConexion();
                connection.AbrirConexion();
                connection.guardarVenta("INSERT INTO Venta Values ("+ idVenta +","+ idUsuario +",'"+ date +"',"+ totalAPagar +")");
                connection.CerrarConexion();
                this.Hide();

                
            }
            //this.Hide();
        }

        private void txtReciboVenta_TextChanged(object sender, System.EventArgs e)
        {
            if (!txtReciboVenta.Text.Equals(""))
            {
                dineroRecibido = Convert.ToDecimal(txtReciboVenta.Text);
                totalAPagar = Convert.ToDecimal(txtTotalVenta.Text);
                txtCambioVenta.Text = (dineroRecibido - totalAPagar).ToString();
            }
        }

        private void TxtReciboVenta_KeyPress(object sender, KeyPressEventArgs e)
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
        public DataGridView AlimentarTabla(DataGridView d)
        {
            return d;
        }
    }
}
