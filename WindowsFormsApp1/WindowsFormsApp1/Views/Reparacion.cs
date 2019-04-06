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
        DBConnectio.Connection conn = new DBConnectio.Connection();
        public String ID;
        public Reparacion(String id)
        {
            

            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            DataTable dt = new DataTable();
            //MessageBox.Show("SELECT Reparacion.Id as ID, Reparacion.Marca as Marca, Reparacion.Modelo as Modelo, Reparacion.Falla as Falla, Reparacion.Diagnostico as Diagnostico, Servicio.Nombre as Servicio, Reparacion.Anticipo as Anticipo, Estado.Nombre as Estado, Reparacion.Fecha as Fecha, Cliente.Nombre as Cliente, Usuario.Nombre as Usuario, Reparacion.CostoTotal as Total, Pieza.Descripcion as Pieza FROM Reparacion INNER JOIN Servicio on Reparacion.IdServicio = Servicio.Id INNER JOIN Cliente on Reparacion.IdCliente = Cliente.Id INNER JOIN Estado on Reparacion.IdEstado = Estado.Id INNER JOIN Usuario on Reparacion.IdUsuario = Usuario.Id INNER JOIN Pieza on Reparacion.IdPieza = Pieza.Id WHERE Reparacion.Id =" + id);
            conn.AbrirConexion();
            SqlDataAdapter da = conn.consultaMasDatos("select Id, Nombre from Estado");
            da.Fill(dt);
            conn.CerrarConexion();
            estadoCBoxC.DisplayMember = "Nombre";
            estadoCBoxC.ValueMember = "Id";
            estadoCBoxC.DataSource = dt;
            conn.AbrirConexion();
            SqlDataReader dr = conn.consulta("SELECT Reparacion.trabajoRealizado as Trabajo, Reparacion.Id as ID, Reparacion.Marca as Marca, Reparacion.Modelo as Modelo, Reparacion.Falla as Falla, Reparacion.Diagnostico as Diagnostico, Servicio.Nombre as Servicio, Reparacion.Anticipo as Anticipo, Estado.Id as Estado, Reparacion.Fecha as Fecha, Cliente.Nombre as Cliente, Usuario.Nombre as Usuario, Reparacion.CostoTotal as Total, Pieza.Descripcion as Pieza FROM Reparacion INNER JOIN Servicio on Reparacion.IdServicio = Servicio.Id INNER JOIN Cliente on Reparacion.IdCliente = Cliente.Id INNER JOIN Estado on Reparacion.IdEstado = Estado.Id INNER JOIN Usuario on Reparacion.IdUsuario = Usuario.Id INNER JOIN Pieza on Reparacion.IdPieza = Pieza.Id WHERE Reparacion.Id = '" + id + "'");
            if (dr.Read())
            {
                idTxtBoxRepa.Text = Convert.ToString(dr["ID"]);
                MarcaTxtBox.Text = Convert.ToString(dr["Marca"]);
                ModeloTxtBoxRepa.Text = Convert.ToString(dr["Modelo"]);
                estadoCBoxC.SelectedIndex = Convert.ToInt32(dr["Estado"])-1;
                fallaTxtBoxRepa.Text = Convert.ToString(dr["Falla"]);
                dRapidoTxtBox.Text = Convert.ToString(dr["Diagnostico"]);
                trabajoRealizadotxtC.Text= Convert.ToString(dr["Trabajo"]);
                ResponsableTxtBox.Text = Convert.ToString(dr["Usuario"]);
                TotalTxtBox.Text = Convert.ToString(dr["Total"]);
                AbonoTxtBox.Text = Convert.ToString(dr["Anticipo"]);
            }
            conn.CerrarConexion();
            //---------------------------------------------------------------------------------------------------------------------------
            StxtCantidadRestanteAPagar.Enabled = false;
            StxtNuevoAbonoCliente.Enabled = true;
            //----------------------------------------------------------------------------------------------------------------------------
            decimal restante = Convert.ToDecimal(TotalTxtBox.Text) - Convert.ToDecimal(AbonoTxtBox.Text);
            StxtCantidadRestanteAPagar.Text = "" + restante;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Reparacion_Load(object sender, EventArgs e)
        {

        }
        private void AbonarBtn_Click(object sender, EventArgs e)
        {
            DBConnectio.Connection con = new DBConnectio.Connection();
            con.AbrirConexion();
            if (StxtNuevoAbonoCliente.Text.Equals("") || Convert.ToDouble(StxtNuevoAbonoCliente.Text)<=0)
            {
                MessageBox.Show("No se puede realizar un abono al equipo con identificador [" + idTxtBoxRepa.Text + "] debido a la existencia de campos vacios o un abono menor a 0.", "Abono no realizado.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                decimal restante = Convert.ToDecimal(TotalTxtBox.Text) - Convert.ToDecimal(AbonoTxtBox.Text);
                if ((Convert.ToDecimal(StxtNuevoAbonoCliente.Text)) > restante)
                {
                    MessageBox.Show("Se esta excediendo el total de costo de reparación.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿SEGURO QUE DESEA ABONAR AL EQUIPO " + idTxtBoxRepa.Text + "?", "ABONO", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        //AbonoTxtBox - TotalTxtBox < StxtNuevoAbonoCliente
                        if (((Convert.ToDecimal(AbonoTxtBox.Text)) + (Convert.ToDecimal(StxtNuevoAbonoCliente.Text))) <= (Convert.ToDecimal(TotalTxtBox.Text)))
                        {
                            con.ActualizarDatos("UPDATE Reparacion set Anticipo = " + StxtNuevoAbonoCliente.Text + "+Anticipo WHERE Id ='" + idTxtBoxRepa.Text + "'");
                            StxtNuevoAbonoCliente.Text = "";
                            StxtCantidadRestanteAPagar.Text = "" + restante;
                        }
                        else
                        {
                            MessageBox.Show("No se puede recibir abono porque excede el limite del total del servicio.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            StxtNuevoAbonoCliente.Text = "";
                        }
                    }
                    else if (resultado == DialogResult.No)
                    {
                        this.Hide();
                    }
                }
            }
            con.CerrarConexion();
        }
        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ActualizarBtn_Click(object sender, EventArgs e)
        {
            conn.AbrirConexion();
            conn.modificar("Update Reparacion set Falla='" + fallaTxtBoxRepa.Text + "', IdEstado='"+estadoCBoxC.SelectedValue+"', Diagnostico='"+dRapidoTxtBox.Text+"', trabajoRealizado='"+trabajoRealizadotxtC.Text+"' where Id="+idTxtBoxRepa.Text);
            conn.CerrarConexion();
            MessageBox.Show("Realizado con exito");
        }
        private void piezaOrderbtnC_Click(object sender, EventArgs e)
        {
            Ecargar_Pieza p = new Ecargar_Pieza(idTxtBoxRepa.Text, ModeloTxtBoxRepa.Text, MarcaTxtBox.Text);
            p.Show();
        }
        private void dRapidoTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
