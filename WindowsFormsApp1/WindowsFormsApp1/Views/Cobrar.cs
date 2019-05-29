using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class Cobrar : Form
    {
        DataGridView datos = new DataGridView();
        int dineroRecibido = 0;
        int totalAPagar = 0;
        public Cobrar()
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
            //------------------------------;
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
            if (dineroRecibido<totalAPagar)
            {
                MessageBox.Show("No cumple con el pago total");
            }
            else
            {
                MessageBox.Show("LA VENTA SE REALIZO EXITOSAMENTE");
                this.Hide();

                //Insertar datos a la base de datos
                //select Cantidad from Producto where ClaveProducto = 'AC-1164'
                for (int i = 0; i <datos.RowCount;i++)
                {
                    if (datos.Rows[i].Cells[0].ToString() == )
                    {

                    }
                }
                
            }
            //this.Hide();
        }
        public void setTotal(decimal t)
        {
            txtTotalVenta.Text = "" + t;
        }

        private void txtReciboVenta_TextChanged(object sender, System.EventArgs e)
        {
            if (!txtReciboVenta.Text.Equals(""))
            {
                dineroRecibido = Convert.ToInt32(txtReciboVenta.Text);
                totalAPagar = Convert.ToInt32(txtTotalVenta.Text);
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
