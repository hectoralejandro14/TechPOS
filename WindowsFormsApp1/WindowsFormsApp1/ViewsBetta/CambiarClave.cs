using System;
using System.Drawing;
using System.Net;
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
            SbtnAceptarCambiarContrasena.Visible = false;
            StxtNuevaContrasenaUsuario.Visible = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparap, int lparam);
        private void btnAceptarCC_Click(object sender, EventArgs e)
        {           
            if (validarEmail(txtCorreoCC.Text))
            {
                DBConnectio.Connection db = new DBConnectio.Connection();
                db.AbrirConexion();
                string query = "SELECT Correo FROM Usuario WHERE Correo = '"+txtCorreoCC.Text+"'";
                if (db.ExisteCorreo(query,txtCorreoCC.Text))
                {
                    //Quitar campos no requeridos
                    btnAceptarCC.Visible = false;
                    txtCorreoCC.Visible = false;
                    //Mostras campos de actualizacion
                    SbtnAceptarCambiarContrasena.Visible = true;
                    StxtNuevaContrasenaUsuario.Visible = true;
                }
                else
                {
                    MessageBox.Show("El correo ingreasado no fue encontrado en los registros.", "Correo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                db.CerrarConexion();

            }
            else
            {
                MessageBox.Show("El formato de correo ingresado no es válido.", "Correo no válido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SbtnAceptarCambiarContrasena_Click(object sender, EventArgs e)
        {
            if (StxtNuevaContrasenaUsuario.Text == "Ingrese nueva contraseña")
            {
                MessageBox.Show("El campo de nueva contraseña se encuentra vacio.", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //db.modificar("Update Usuario set Contra='"+coe+"' where NombreUsuario='"+txtUserNameA.Text+"'");
                DBConnectio.Connection db = new DBConnectio.Connection();
                //Encriptar contraseña
                db.AbrirConexion();
                string contrasena_encriptada = Controllers.Encrypt.GetMD5(StxtNuevaContrasenaUsuario.Text);
                int cambio_exitoso =  db.Updatepassword("UPDATE Usuario SET Contra = '"+contrasena_encriptada+"' WHERE Correo = '"+ txtCorreoCC .Text+ "'");
                if (cambio_exitoso > 0)
                {
                    MessageBox.Show("Los datos de contraseña para el usuario " + txtCorreoCC.Text + " fueron actualizados exitosamente.", "Cambio Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ViewLogin login = new ViewLogin();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Falló el cambió de contraseña por problemas de conectividad", "Cambio Fallido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                db.CerrarConexion();
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

        private void StxtNuevaContrasenaUsuario_Enter(object sender, EventArgs e)
        {
            if (StxtNuevaContrasenaUsuario.Text == "Ingrese nueva contraseña")
            {
                StxtNuevaContrasenaUsuario.Text = "";
                StxtNuevaContrasenaUsuario.ForeColor = Color.Orange;
                StxtNuevaContrasenaUsuario.UseSystemPasswordChar = true;
            }
        }

        private void StxtNuevaContrasenaUsuario_Leave(object sender, EventArgs e)
        {
            if (StxtNuevaContrasenaUsuario.Text == "")
            {
                StxtNuevaContrasenaUsuario.Text = "Ingrese nueva contraseña";
                StxtNuevaContrasenaUsuario.ForeColor = Color.DimGray;
                StxtNuevaContrasenaUsuario.UseSystemPasswordChar = false;
            }
        }
    }
}
