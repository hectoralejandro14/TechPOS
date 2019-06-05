using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DBConnectio;

namespace WindowsFormsApp1.Views
{
    public partial class ProductDetails : Form
    {
        Connection connection = new Connection();
        string claveProducto = "";
        public ProductDetails(string clave)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            DataTable dt = new DataTable();
            connection.AbrirConexion();
            SqlDataAdapter da = connection.consultaMasDatos("select Id, Nombre from Categoria");
            da.Fill(dt);
            connection.CerrarConexion();
            cBoxCategoriaProd.DisplayMember = "Nombre";
            cBoxCategoriaProd.ValueMember = "Id";
            cBoxCategoriaProd.DataSource = dt;
            connection.AbrirConexion();
            SqlDataReader dataReader = connection.consulta("SELECT ClaveProducto AS Clave, ClaveFabricante AS Fabricante, Marca, Categoria.Nombre AS Categoria, Descripcion, Costo, Cantidad from Producto INNER JOIN Categoria ON Producto.IdCategoria = Categoria.Id WHERE ClaveProducto ='" + clave + "'");
            if (dataReader.Read())
            {
                tBoxClaveProducto.Text = Convert.ToString(dataReader["Clave"]);
                tBoxClaveFabricante.Text = Convert.ToString(dataReader["Fabricante"]);
                tBoxMarca.Text = Convert.ToString(dataReader["Marca"]);
                cBoxCategoriaProd.Text = Convert.ToString(dataReader["Categoria"]);
                tBoxDescripcion.Text = Convert.ToString(dataReader["Descripcion"]);
                tBoxCostoProducto.Text = Convert.ToString(dataReader["Costo"]);
                tBoxCantidadProd.Text = Convert.ToString(dataReader["Cantidad"]);
            }
            claveProducto = clave;
            connection.CerrarConexion();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparap, int lparam);
        

        private void BtnAceptarProduct_Click(object sender, EventArgs e)
        {
            connection.AbrirConexion();
            if (btnAceptarProduct.Text.Equals("Aceptar"))
            {
                this.Hide();
            }
            if (btnAceptarProduct.Text.Equals("Guardar"))
            {
                DialogResult result = MessageBox.Show("Esta seguro que desea realizar la modificacion?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    if (tBoxClaveProducto.Text.Equals("") || tBoxClaveFabricante.Text.Equals("") || tBoxMarca.Text.Equals("")
                        || cBoxCategoriaProd.Text.Equals("") || tBoxDescripcion.Text.Equals(""))
                    {
                        MessageBox.Show("Favor de no dejar datos vacios", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (Convert.ToInt32(tBoxCostoProducto.Text) <= 0 || Convert.ToInt32(tBoxCantidadProd.Text) <= 0)
                        {
                            MessageBox.Show("Las cantidades no pueden ser menor o igual a 0", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            int idCategoria = connection.IdCategoria("SELECT Id From Categoria WHERE Nombre='" + cBoxCategoriaProd.Text + "'");
                            connection.actualizarDatos("UPDATE Producto SET ClaveProducto='" + tBoxClaveProducto.Text + "', ClaveFabricante='" + tBoxClaveFabricante.Text + "', Marca='" + tBoxMarca.Text + "', IdCategoria=" + idCategoria + ", Descripcion='" + tBoxDescripcion.Text + "', Costo=" + Convert.ToDouble(tBoxCostoProducto.Text) + ", Cantidad=" + Convert.ToInt32(tBoxCantidadProd.Text) + " WHERE ClaveProducto = '" + claveProducto + "'");
                            MessageBox.Show("Los datos se actualizaron correctamente");
                            btnAceptarProduct.Text = "Aceptar";
                            btnCancelarProducto.Visible = false;
                            tBoxClaveProducto.Enabled = false;
                            tBoxClaveFabricante.Enabled = false;
                            tBoxMarca.Enabled = false;
                            cBoxCategoriaProd.Enabled = false;
                            tBoxDescripcion.Enabled = false;
                            tBoxCostoProducto.Enabled = false;
                            tBoxCantidadProd.Enabled = false;
                        }
                    }
                }
            }
            connection.CerrarConexion();
        }

        private void BtnModificarProducto_Click(object sender, EventArgs e)
        {
            btnEliminateProduct.Visible = false;
            btnAceptarProduct.Text = "Guardar";
            btnCancelarProducto.Visible = true;
            tBoxClaveProducto.Enabled = true;
            tBoxClaveFabricante.Enabled = true;
            tBoxMarca.Enabled = true;
            cBoxCategoriaProd.Enabled = true;
            tBoxDescripcion.Enabled = true;
            tBoxCostoProducto.Enabled = true;
            tBoxCantidadProd.Enabled = true;
        }

        private void BtnCancelarProducto_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea cancelar la modificacion?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Cancelacion exitosa");
                btnAceptarProduct.Text = "Aceptar";
                btnCancelarProducto.Visible = false;
                tBoxClaveProducto.Enabled = false;
                tBoxClaveFabricante.Enabled = false;
                tBoxMarca.Enabled = false;
                cBoxCategoriaProd.Enabled = false;
                tBoxDescripcion.Enabled = false;
                tBoxCostoProducto.Enabled = false;
                tBoxCantidadProd.Enabled = false;
                btnEliminateProduct.Visible = true;
                connection.AbrirConexion();
                SqlDataReader dataReader = connection.consulta("SELECT ClaveProducto AS Clave, ClaveFabricante AS Fabricante, Marca, Categoria.Nombre AS Categoria, Descripcion, Costo, Cantidad from Producto INNER JOIN Categoria ON Producto.IdCategoria = Categoria.Id WHERE ClaveProducto ='" + claveProducto + "'");
                if (dataReader.Read())
                {
                    tBoxClaveProducto.Text = Convert.ToString(dataReader["Clave"]);
                    tBoxClaveFabricante.Text = Convert.ToString(dataReader["Fabricante"]);
                    tBoxMarca.Text = Convert.ToString(dataReader["Marca"]);
                    cBoxCategoriaProd.Text = Convert.ToString(dataReader["Categoria"]);
                    tBoxDescripcion.Text = Convert.ToString(dataReader["Descripcion"]);
                    tBoxCostoProducto.Text = Convert.ToString(dataReader["Costo"]);
                    tBoxCantidadProd.Text = Convert.ToString(dataReader["Cantidad"]);
                }
                connection.CerrarConexion();
            }
        }

        private void BtnEliminateProduct_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar el producto?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                connection.AbrirConexion();
                connection.actualizarDatos("DELETE FROM Producto WHERE ClaveProducto = '"+claveProducto+"'");
                connection.CerrarConexion();
                MessageBox.Show("El producto ha sido eliminado correctamente","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
            }
        }

        private void ProductDetails_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PProducts_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TBoxCostoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (Char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
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

        private void TBoxCantidadProd_KeyPress(object sender, KeyPressEventArgs e)
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