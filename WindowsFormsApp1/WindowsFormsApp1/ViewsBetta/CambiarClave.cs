using System;
using System.Drawing;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1.ViewsBetta
{
    public partial class CambiarClave : Form
    {
        public CambiarClave()
        {
            InitializeComponent();
            CCtxtPinSeguridad.Visible = false;
            lblPinSeguridadCC.Visible = false;
            CCbtnAceptarPinSeguridad.Visible = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparap, int lparam);
        private void btnAceptarCC_Click(object sender, EventArgs e)
        {           
            if (validarEmail(txtCorreoCC.Text))
            {
                //clavesrecuperadasup@hotmail.com
                //upsoftware2019
                Random random = new Random();
                decimal r = random.Next(1000, 9999);
                MailMessage mensaje = new MailMessage();
                mensaje.To.Add(txtCorreoCC.Text);
                mensaje.Subject = "Correo de verificacion de usuario";
                mensaje.SubjectEncoding = System.Text.Encoding.UTF8;
                //upmendoza@unisierra.edu.mx
                mensaje.Bcc.Add("carloshudm@gmail.com");
                mensaje.Body = "Correo enviado desde c#";
                mensaje.BodyEncoding = System.Text.Encoding.UTF8;
                mensaje.IsBodyHtml = true;
                mensaje.From = new MailAddress(txtCorreoCC.Text);

                SmtpClient cliente = new SmtpClient();
                cliente.Credentials = new System.Net.NetworkCredential("clavesrecuperadasup@hotmailcom", "upsoftware2019");
                cliente.Port = 587;
                cliente.EnableSsl = true;
                cliente.Host = "smpt.gmail.com";//mail.dominio.com

                try
                {
                    cliente.Send(mensaje);
                    txtCorreoCC.Visible = false;
                    lblCorreoCC.Visible = false;
                    btnAceptarCC.Visible = false;
                    //------------------------------------------------------------------------
                    CCtxtPinSeguridad.Visible = true;
                    lblPinSeguridadCC.Visible = true;
                    CCbtnAceptarPinSeguridad.Visible = true;
                    //------------------------------------------------------------------------
                }
                catch
                {
                    MessageBox.Show("Error al momento de enviar correo por problemas de conectividad", "Error de conectividad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("El formato de correo ingresado no es válido.", "Correo no válido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //--------------------------------------------------------------------------------------------
        //DISEÑO
        private void txtCorreoCC_Enter(object sender, EventArgs e)
        {
            if (txtCorreoCC.Text == "Ingrese su correo")
            {
                txtCorreoCC.Text = "";
                txtCorreoCC.ForeColor = Color.Orange;
            }
        }

        private void txtCorreoCC_Leave(object sender, EventArgs e)
        {
            if (txtCorreoCC.Text == "")
            {
                txtCorreoCC.Text = "Ingrese su correo";
                txtCorreoCC.ForeColor = Color.DimGray;
            }
        }

        private void ImgVolverCC_Click(object sender, EventArgs e)
        {
            ViewLogin login = new ViewLogin();
            this.Hide();
            login.Show();
        }

        private void btnVolverCC_Click(object sender, EventArgs e)
        {
            ViewLogin login = new ViewLogin();
            this.Hide();
            login.Show();
        }

        private void CambiarClave_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ImgCC_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private Boolean validarEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void CCbtnAceptarPinSeguridad_Click(object sender, EventArgs e)
        {

        }
    }
}
