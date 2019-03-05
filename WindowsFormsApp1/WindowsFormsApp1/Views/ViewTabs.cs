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
            EncargarProducto encargar = new EncargarProducto();
            this.Close();
            encargar.Show();
        }
        private void pictureBuscar_Click(object sender, System.EventArgs e)
        {
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
            }
            else
            {
                MessageBox.Show("FORMATO DE CORREO NO VALIDO", "RECHAZADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool validarEmail(string email)
        {
            try
            {
                if (!txtTelefono.Text.Equals(""))
                {
                    new MailAddress(email);
                    return true;
                }
                else
                {
                    return false;
                }
                    
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
        //------------------------------------------------------------------------------------
    }       
}

