using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class ViewTabs : Form
    {
        private DBConnectio.Connection conexion = new DBConnectio.Connection();
        public ViewTabs()
        {
            InitializeComponent();
            txtDescripcionDeFalla.ScrollBars = ScrollBars.Vertical;
            txtDescripcionDiagnosticoEspecifico.ScrollBars = ScrollBars.Vertical;
            tabPuntoVenta.TabPages.Remove(tabConfiguracionesDeUsuario);
        }

        private void linkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            ViewLogin view = new ViewLogin();
            view.Show();
        }

        //------------------------------------------------------------------------------------
        //Tab Recibir Equipo
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

        //------------------------------------------------------------------------------------
        //Generales
        public void MostrarConfiguracionUsuarios (int IdRol)
        {
            if (IdRol == 1)
            {
                tabPuntoVenta.TabPages.Add(tabConfiguracionesDeUsuario);
            }
        }

        private void SbtnAgregarRol_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            decimal _random = random.Next(1, 1000000000);
            string _Rol = StxtAgregarRol.Text;
            string consulta = "INSERT INTO Rol (Id,NombreRol) VALUES (@Id,@NombreRol)";
            //Abrir conexion
            conexion.AbrirConexion();
            //Agregar datos
            conexion.AgregarRoles(consulta,_random,_Rol);
            //cerrar conexion
            conexion.CerrarConexion();
            //@"INSERT INTO Users (UserName, Password, Name, 
            //LastName, JobTitle, ID_UserType) 
                                    //VALUES(@Username, @pass, @name, @Lastname,
                                        //@Jobtitle, @IDusertype)"


        }
    }       
}

