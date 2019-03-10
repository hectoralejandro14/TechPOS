using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1
{
    public partial class Reparacion : Form
    {
        public String ID;
        public Reparacion(String id)
        {
            

            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            //MessageBox.Show("SELECT Reparacion.Id as ID, Reparacion.Marca as Marca, Reparacion.Modelo as Modelo, Reparacion.Falla as Falla, Reparacion.Diagnostico as Diagnostico, Servicio.Nombre as Servicio, Reparacion.Anticipo as Anticipo, Estado.Nombre as Estado, Reparacion.Fecha as Fecha, Cliente.Nombre as Cliente, Usuario.Nombre as Usuario, Reparacion.CostoTotal as Total, Pieza.Descripcion as Pieza FROM Reparacion INNER JOIN Servicio on Reparacion.IdServicio = Servicio.Id INNER JOIN Cliente on Reparacion.IdCliente = Cliente.Id INNER JOIN Estado on Reparacion.IdEstado = Estado.Id INNER JOIN Usuario on Reparacion.IdUsuario = Usuario.Id INNER JOIN Pieza on Reparacion.IdPieza = Pieza.Id WHERE Reparacion.Id =" + id);
            DBConnectio.Connection conn = new DBConnectio.Connection();
            conn.AbrirConexion();
            SqlDataReader dr = conn.consulta("SELECT Reparacion.Id as ID, Reparacion.Marca as Marca, Reparacion.Modelo as Modelo, Reparacion.Falla as Falla, Reparacion.Diagnostico as Diagnostico, Servicio.Nombre as Servicio, Reparacion.Anticipo as Anticipo, Estado.Nombre as Estado, Reparacion.Fecha as Fecha, Cliente.Nombre as Cliente, Usuario.Nombre as Usuario, Reparacion.CostoTotal as Total, Pieza.Descripcion as Pieza FROM Reparacion INNER JOIN Servicio on Reparacion.IdServicio = Servicio.Id INNER JOIN Cliente on Reparacion.IdCliente = Cliente.Id INNER JOIN Estado on Reparacion.IdEstado = Estado.Id INNER JOIN Usuario on Reparacion.IdUsuario = Usuario.Id INNER JOIN Pieza on Reparacion.IdPieza = Pieza.Id WHERE Reparacion.Id = '" + id + "'");
            if (dr.Read())
            {
                idTxtBoxRepa.Text = Convert.ToString(dr["ID"]);
                MarcaTxtBox.Text = Convert.ToString(dr["Marca"]);
                ModeloTxtBoxRepa.Text = Convert.ToString(dr["Modelo"]);
                EstadoTxtBox.Text = Convert.ToString(dr["Estado"]);
                fallaTxtBoxRepa.Text = Convert.ToString(dr["Falla"]);
                dRapidoTxtBox.Text = Convert.ToString(dr["Diagnostico"]);
                ResponsableTxtBox.Text = Convert.ToString(dr["Usuario"]);
                TotalTxtBox.Text = Convert.ToString(dr["Total"]);
                AbonoTxtBox.Text = Convert.ToString(dr["Anticipo"]);
            }
            conn.CerrarConexion();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Reparacion_Load(object sender, EventArgs e)
        {

        }

        private void AbonarBtn_Click(object sender, EventArgs e)
        {

        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
