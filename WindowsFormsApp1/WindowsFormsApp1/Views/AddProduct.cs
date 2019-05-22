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
    public partial class AddProduct : Form
    {
        Connection connection = new Connection();
        public AddProduct()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            connection.AbrirConexion();
            SqlDataAdapter da = connection.consultaMasDatos("select Id, Nombre from Categoria");
            da.Fill(dt);
            connection.CerrarConexion();
            cBoxAddCategoriaP.DisplayMember = "Nombre";
            cBoxAddCategoriaP.ValueMember = "Id";
            cBoxAddCategoriaP.DataSource = dt;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparap, int lparam);

        private void BtnAddAceptarP_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }

        private void BtnAddCancelarP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro que desea cancelar el producto?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Se a cancelado el agregado de producto","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
            }
        }

        private void AddProduct_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PAddProducts_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
