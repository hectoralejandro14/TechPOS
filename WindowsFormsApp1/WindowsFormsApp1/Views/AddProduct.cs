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
            Connection connection = new Connection();
            if (tBoxAddClaveP.Text.Equals("") || tBoxAddClaveF.Text.Equals("") || tBoxAddCostoP.Text.Equals("") || tBoxAddMarca.Text.Equals("") 
                || tBoxAddDescripcion.Text.Equals("") || tBoxAddCantidadP.Text.Equals("") || cBoxAddCategoriaP.Text.Equals(""))
            {
                MessageBox.Show("No se permiten datos vacios","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                if (Convert.ToDouble(tBoxAddCostoP.Text)<=0)
                {
                    MessageBox.Show("No se permiten cantidades menores o igual a 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string pesos = "pesos";
                    connection.AbrirConexion();
                    int idCategoria = connection.IdCategoria("SELECT Id From Categoria WHERE Nombre = '" + cBoxAddCategoriaP.Text + "'");
                    connection.CerrarConexion();
                    connection.AbrirConexion();
                    int newId = connection.idProducto("SELECT MAX(Id)+1 FROM Producto");
                    connection.CerrarConexion();
                    connection.AbrirConexion();
                    int filas = connection.ingresarDatos("INSERT INTO Producto (Id,ClaveProducto, ClaveFabricante, Marca, IdCategoria, Descripcion, Costo, Moneda, Cantidad) VALUES ("+newId+",'" + tBoxAddClaveP.Text + "', '" + tBoxAddClaveF.Text + "', '" + tBoxAddMarca.Text + "', " + idCategoria + ", '" + tBoxAddDescripcion.Text + "', " + Convert.ToDouble(tBoxAddCostoP.Text) + ", '"+pesos+"', " + Convert.ToInt32(tBoxAddCantidadP.Text) + ")");
                    if (filas>0)
                    {
                        MessageBox.Show("El producto se agrego correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    connection.CerrarConexion();
                }
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

        private void TBoxAddCostoP_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TBoxAddCantidadP_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
