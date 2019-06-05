using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class ReportesEspecificos : Form
    {
        public ReportesEspecificos()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparap, int lparam);
        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            string fecha_pedida = fechaReportePedido.Value.Date.ToShortDateString();
            MessageBox.Show(fecha_pedida);
            //dataGridView1.Rows[fila].Cells[1].Value=Usuario[contadorUsuarios +1]=txtNewUsuario.Text;
            if (rbReportesDeCancelacion.Checked)
            {
                /*string cadena = "Data Source=.\\SQLEXPRESS;Initial Catalog=TechPOSdb; Integrated Security=True";
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                SqlCommand cmd = new SqlCommand("select * from Producto where ClaveProducto='" + buscarTbxVentas.Text + "'", conexion);
                SqlDataReader dr = cmd.ExecuteReader();
                DataRow row = dtVenta.NewRow();
                tableVender.DataSource = dtVenta;
                //---------------------------------
                if (dr.Read())
                {
                    double price = Convert.ToDouble(Convert.ToString(dr["Costo"]));
                    double subtotal = Convert.ToDouble(subTotalTbxVentas.Text) + (price);
                    double iva = Convert.ToDouble(((subtotal * 16) / 100));
                    row["cod"] = Convert.ToString(dr["ClaveProducto"]);
                    row["des"] = Convert.ToString(dr["Descripcion"]);
                    row["preciou"] = Convert.ToString(dr["Costo"]);
                    row["cant"] = Convert.ToString(txtCantidadVenta.Text);
                    row["preciot"] = Convert.ToString(Convert.ToDouble(Convert.ToString(txtCantidadVenta.Text)) * price);
                    //MessageBox.Show(Convert.ToString(dr["Costo"]));
                    dtVenta.Rows.Add(row);
                    subTotalTbxVentas.Text = Convert.ToString(subtotal);
                    ivaTbxVentas.Text = Convert.ToString(iva);
                    totalTbxVenta.Text = Convert.ToString(subtotal + iva);*/
                    //Buscar en tabla de cancelacion

                }
                else if (rbReportesDeVenta.Checked)
            {
                //buscar en tabla de ventas
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ReportesEspecificos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelReportesEspecificos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
