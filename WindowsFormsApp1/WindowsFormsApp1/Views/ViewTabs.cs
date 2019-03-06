using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class ViewTabs : Form
    {
        public ViewTabs()
        {
            InitializeComponent();
            txtDescripcionDeFalla.ScrollBars = ScrollBars.Vertical;
            txtDescripcionDiagnosticoEspecifico.ScrollBars = ScrollBars.Vertical;
            Jtxtbuscar.MaxLength = 4;
            
        }

        private void linkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            ViewLogin view = new ViewLogin();
            view.Show();
        }

        //------------------------------------------------------------------------------------
        //SERGIO
        private void btnPedirPieza_Click(object sender, System.EventArgs e)
        {
            Ecargar_Pieza encargar = new Ecargar_Pieza();
            
            encargar.Show();
        }
        private void pictureBuscar_Click(object sender, System.EventArgs e)
        {
            bool encontro = false;
            if (!encontro)
            {
                lblAvisoNoCliente.Visible = true;
                btnAgregarCliente.Visible = true;
            }
            MessageBox.Show("Picture Buscar");
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtAnticipo_KeyPress(object sender, KeyPressEventArgs e)
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
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

            if (validarEmail(txtCorreo.Text))
            {
                MessageBox.Show("FORMATO DE CORREO CORRECTO", "ACEPTADO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                //Agregar Cliente en bd
            }
            else
            {
                MessageBox.Show("FORMATO DE CORREO NO VALIDO", "RECHAZADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public static bool validarEmail(string email)
        {
            try
            {
                new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void tabReparacion_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregrEquipos_Click(object sender, EventArgs e)
        {
            //Agregar en bd nuevo equipo de reparacion
        }

        private void JPicture_Click(object sender, EventArgs e)
        {
            bool encontrarEquipo = false;
            if (!encontrarEquipo)
            {
                MessageBox.Show("No se encontro equipo en reparacion con el numero: " + Jtxtbuscar.Text);
            }
        }

        private void Jtxtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (!(Jtxtbuscar.TextLength <= 4))
            {

            }
        }

        private void JdataGridRep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //------------------------------------------------------------------------------------
    }       
}

