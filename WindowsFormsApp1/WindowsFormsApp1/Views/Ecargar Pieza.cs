using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class Ecargar_Pieza : Form
    {
        
        public Ecargar_Pieza(string id, string modelo, string marca)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            equipoTbxEncagar.Text = id;
            modeloTbxEncargar.Text = modelo;
            marcaTbxEncargar.Text = marca;
            
          
        }
        private void BtnAceptarPieza_Click(object sender, EventArgs e)
        {
            DBConnectio.Connection conexion = new DBConnectio.Connection();
            conexion.AbrirConexion();
            DateTime fecha_pedida = DateTime.Now;
            DateTime fecha_llegada_aproximada = SdtCalendarFechaLlegada.Value;
            int IdPieza = conexion.generarId("SELECT MAX(Id) FROM Pieza");
            bool si = conexion.AddElements("INSERT INTO Pieza VALUES(" + IdPieza + ",'" + piezasTbxEncargar.Text + "','Ordenada','" + fecha_pedida + "','" + fecha_llegada_aproximada + "')");
            conexion.CerrarConexion();
            if (si)
            {
                MessageBox.Show("SE AH ENCARGADO LA PIEZA CORRECTAMENTE.", "PIEZA ENCARGADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("PIEZA NO ENCARGADA POR PROBLEMAS DE CONECTIVIDAD.", "PIEZA NO ENCARGADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarPieza_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
