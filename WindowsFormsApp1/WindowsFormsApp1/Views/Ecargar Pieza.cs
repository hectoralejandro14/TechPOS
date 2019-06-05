using System;
using System.Runtime.InteropServices;
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
            //---------------------------------------------------
            equipoTbxEncagar.Enabled = false;
            modeloTbxEncargar.Enabled = false;
            marcaTbxEncargar.Enabled = false;


        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparap, int lparam);

        private void BtnAceptarPieza_Click(object sender, EventArgs e)
        {
            if (piezasTbxEncargar.Text == "")
            {
                MessageBox.Show("PIEZA NO ENCARGADA POR CAMPOS VACIOS.", "PIEZA NO ENCARGADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DBConnectio.Connection conexion = new DBConnectio.Connection();
                conexion.AbrirConexion();
                DateTime fecha_pedida = DateTime.Now;
                DateTime fecha_llegada_aproximada = SdtCalendarFechaLlegada.Value;
                int IdPieza = conexion.generarId("SELECT MAX(Id) FROM Pieza");
                bool si = conexion.AddElements("INSERT INTO Pieza VALUES(" + IdPieza + ",'" + piezasTbxEncargar.Text + "','Ordenada','" + fecha_pedida + "','" + fecha_llegada_aproximada + "')","pieza");
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
        }
        private void btnCancelarPieza_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Ecargar_Pieza_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void EncargarPiezaPnl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
