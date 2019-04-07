using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1.DBConnectio;
using WindowsFormsApp1.Views;
using System.Runtime.InteropServices;
using WindowsFormsApp1.ViewsBetta;

namespace WindowsFormsApp1
{
    public partial class ViewLogin : Form
    {
        private ViewTabs _vistaTabs = new ViewTabs();
        public ViewLogin()
        {
            InitializeComponent();
            //txtContrasena.PasswordChar = '*';
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparap, int lparam);
        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Length >= 25 && !(txtUsuario.Text.Equals("")))
            {
                MessageBox.Show("Usted " + txtUsuario.Text + ", esta excediendo la dimension de caracteres",
                    "Error de dimensiones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtContrasena.Text.Length >= 25)
            {
                MessageBox.Show("Usted esta excediendo la dimension de caracteres",
                    "Error de dimensiones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void ViewLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(Char)Keys.Enter)
            {
                if (txtContrasena.Text.Equals("") || txtUsuario.Text.Equals(""))
                {
                    MessageBox.Show("No se pudo iniciar sesión por existencia de campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtContrasena.Text = "";
                    txtUsuario.Text = "";
                }
                else
                {
                    Connection db = new Connection();
                    string auxNu = txtUsuario.Text;
                    string nu = auxNu.ToUpper();
                    string co = txtContrasena.Text;
                    //Controllers.Encrypt ect = new Controllers.Encrypt();
                    string coe = Controllers.Encrypt.GetMD5(txtContrasena.Text);
                    //MessageBox.Show(coe);
                    db.AbrirConexion();
                    if (db.IniciarSesion(nu, coe) == "Administrador")
                    {
                        _vistaTabs.Bienvenido(nu);
                        _vistaTabs.MostrarConfiguracionUsuarios("Administrador");
                        _vistaTabs.Show();
                        this.Hide();
                    }
                    else if (db.IniciarSesion(nu, coe) == "Trabajador")
                    {
                        _vistaTabs.Bienvenido(nu);
                        _vistaTabs.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error! Usuario y/o Contraseña Incorrectas", "Sesión fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    db.CerrarConexion();
                }
            }
            
        }
        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (txtContrasena.Text.Equals("") || txtUsuario.Text.Equals(""))
                {
                    MessageBox.Show("No se pudo iniciar sesión por existencia de campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtContrasena.Text = "";
                    txtUsuario.Text = "";
                }
                else
                {
                    Connection db = new Connection();
                    string auxNu = txtUsuario.Text;
                    string nu = auxNu.ToUpper();
                    string co = txtContrasena.Text;
                    //Controllers.Encrypt ect = new Controllers.Encrypt();
                    string coe = Controllers.Encrypt.GetMD5(txtContrasena.Text);
                    //MessageBox.Show(coe);
                    db.AbrirConexion();
                    if (db.IniciarSesion(nu, coe) == "Administrador")
                    {
                        _vistaTabs.Bienvenido(nu);
                        _vistaTabs.MostrarConfiguracionUsuarios("Administrador");
                        _vistaTabs.Show();
                        this.Hide();
                    }
                    else if (db.IniciarSesion(nu, coe) == "Trabajador")
                    {
                        _vistaTabs.Bienvenido(nu);
                        _vistaTabs.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error! Usuario y/o Contraseña Incorrectas", "Sesión fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    db.CerrarConexion();
                }
            }
        }
        //---------------------------------------------------------------------------
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Orange;
            }
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }
        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "CONTRASEÑA")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Orange;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }
        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.ForeColor = Color.DimGray;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }
        private void btnCerrarAplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimizarAplicacion_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void ViewLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void SpanelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //--------------------------------------------------------------------------------------------
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            if (txtContrasena.Text.Equals("CONTRASEÑA") || txtUsuario.Text.Equals("USUARIO"))
            {
                MessageBox.Show("No se pudo iniciar sesión por existencia de campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                Connection db = new Connection();
                string auxNu = txtUsuario.Text;
                string nu = auxNu.ToUpper();
                string co = txtContrasena.Text;
                //Controllers.Encrypt ect = new Controllers.Encrypt();
                string coe = Controllers.Encrypt.GetMD5(txtContrasena.Text);
                //MessageBox.Show(coe);
                db.AbrirConexion();
                if (db.IniciarSesion(nu, coe) == "Administrador")
                {
                    _vistaTabs.Bienvenido(nu);
                    _vistaTabs.MostrarConfiguracionUsuarios("Administrador");
                    _vistaTabs.Show();
                    this.Hide();
                }
                else if (db.IniciarSesion(nu, coe) == "Trabajador")
                {
                    _vistaTabs.Bienvenido(nu);
                    _vistaTabs.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error! Usuario y/o Contraseña Incorrectas", "Sesión fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                db.CerrarConexion();
            }
        }

        private void SlLOlvidasteContasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cambiarContraseña c = new cambiarContraseña();
            c.Show();
            this.Hide();
        }

        private void SlLNuevoUsuarioL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NuevoUsuario nu = new NuevoUsuario();
            nu.Show();
            this.Hide();
        }
    }
    
}