using System;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;
using WindowsFormsApp1.DBConnectio;

namespace WindowsFormsApp1.Views
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            //Font font2 = new Font("Arial", 18.0f);
            //CtxtContrasenaU.Font = font2;
            CtxtContrasenaU.PasswordChar = '*';
            //------------------------------------------------------
            //CtxtConfirmarContrasenaU.Font = font2;
            CtxtConfirmarContrasenaU.PasswordChar = '*';
        }
        private void btnAceptarr_Click(object sender, EventArgs e)
        {
            if (CtxtNombreUsuario.Text.Equals("") || CtxtNombreU.Text.Equals("") || CtxtApellidoU.Text.Equals("") || CtxtCorreoU.Text.Equals("") 
                || CtxtTelefonoU.Text.Equals("") || CtxtContrasenaU.Text.Equals("") || CtxtConfirmarContrasenaU.Text.Equals(""))
            {
                MessageBox.Show("NO SE PUEDE AGREGAR UN NUEVO USUARIO POR LA EXISTENCIA DE CAMPOS VACIOS", "ERROR DE CAMPOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                if (validarEmail(CtxtCorreoU.Text))
                {
                    if (CtxtContrasenaU.Text == CtxtConfirmarContrasenaU.Text)
                    {
                        Connection conexion = new Connection();
                        conexion.AbrirConexion();
                        decimal id = GenerarId();
                        String _query = "INSERT INTO Usuario (Id,NombreUsuario,Nombre,Apellido,Telefono,Correo,Contra,Rol) VALUES (" + id + ",'" + CtxtNombreUsuario.Text + "','" + CtxtNombreU.Text + "','" + CtxtApellidoU.Text + "','" + CtxtTelefonoU.Text + "','" + CtxtCorreoU.Text + "','" + CtxtContrasenaU.Text + "','Trabajador')";
                        conexion.AddElements(_query);
                        CtxtNombreUsuario.Text = "";
                        CtxtNombreU.Text = "";
                        CtxtApellidoU.Text = "";
                        CtxtTelefonoU.Text = "";
                        CtxtCorreoU.Text = "";
                        CtxtContrasenaU.Text = "";
                        CtxtConfirmarContrasenaU.Text = "";
                        conexion.CerrarConexion();
                    }
                    else
                    {
                        MessageBox.Show("LOS CAMPOS DE CONTRASEÑAS NO SON IGUALES", "NO COINCIDENCIAS", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        CtxtContrasenaU.Text = "";
                        CtxtConfirmarContrasenaU.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("NO SE PUEDE AGREGAR UN NUEVO USUARIO PORQUE EL FORMATO DE CORREO ES INVALIDO", "FORMATO NO VALIDO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }




            ViewLogin login = new ViewLogin();
            login.Show();
            this.Hide();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ViewLogin login = new ViewLogin();
            login.Show();
            this.Hide();
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
        public decimal GenerarId()
        {
            Connection conexion = new Connection();
            Random random = new Random();
            conexion.AbrirConexion();
            decimal idR = random.Next(0, 1000000000);
            do
            {
                idR = random.Next(0, 1000000000);
                if (!conexion.VerificarExistenciaDeId(idR))
                {
                    break;
                }
            } while (true);
            conexion.CerrarConexion();
            return idR;
        }
        private void CtxtTelefonoU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar))
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
    }
}
