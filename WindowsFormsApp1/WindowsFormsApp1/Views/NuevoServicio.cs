using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class NuevoServicio : Form
    {
        public NuevoServicio()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        private void SbtnAceptarNuevoServicio_Click(object sender, System.EventArgs e)
        {
            if ((StxtNombreNuevoServicio.Text == "") || (StxtPrecioNuevoServicio.Text == ""))
            {
                MessageBox.Show("NO SE PUEDE AGREGAR NUEVO SERVICIO POR LA EXITENCIA DE CAMPOS VACIOS", "CAMPOS INVALIDOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DBConnectio.Connection connection = new DBConnectio.Connection();
                connection.AbrirConexion();
                int idServicio = connection.generarId("SELECT MAX(Id) FROM Servicio");
                String query = "INSERT INTO Servicio (Id,Nombre,Precio,Actividad) VALUES (" + idServicio + ",'" + StxtNombreNuevoServicio.Text + "'," + StxtPrecioNuevoServicio.Text + ",'" + StxtActividadNuevoServicio.Text + "')";
                connection.AddElements(query);
                DialogResult result = MessageBox.Show("DESEA AGREGAR UN NUEVO SERVICIO?", "SERVICIOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    StxtNombreNuevoServicio.Text = "";
                    StxtPrecioNuevoServicio.Text = "";
                    StxtActividadNuevoServicio.Text = "";
                }
                else if (result == DialogResult.No)
                {
                    this.Hide();
                }
                connection.CerrarConexion();
            }
        }
        private void StxtPrecioNuevoServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void SbtnVolverPaginaPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
