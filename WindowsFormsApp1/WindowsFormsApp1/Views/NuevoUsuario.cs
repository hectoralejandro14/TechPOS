using System;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsFormsApp1.DBConnectio;

namespace WindowsFormsApp1.Views
{
    public partial class NuevoUsuario : Form
    {
        private static int reciboPeticionDe = 0;
        public NuevoUsuario()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            CtxtContrasenaU.PasswordChar = '*';
            //------------------------------------------------------
            CtxtConfirmarContrasenaU.PasswordChar = '*';
            

            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparap, int lparam);

        private void btnAceptarr_Click(object sender, EventArgs e)
        {
            if (CtxtNombreUsuario.Text.Equals("") || CtxtNombreU.Text.Equals("") || CtxtApellidoU.Text.Equals("") || CtxtCorreoU.Text.Equals("")
                || CtxtTelefonoU.Text.Equals("") || CtxtContrasenaU.Text.Equals("") || CtxtConfirmarContrasenaU.Text.Equals(""))
            {
                MessageBox.Show("NO SE PUEDE AGREGAR UN NUEVO USUARIO POR LA EXISTENCIA DE CAMPOS VACIOS", "ERROR DE CAMPOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                CtxtNombreUsuario.Text = CtxtNombreUsuario.Text.ToUpper();
                string usuario = CtxtNombreUsuario.Text.ToUpper();
                if (validarEmail(CtxtCorreoU.Text))
                {
                    if (CtxtContrasenaU.Text == CtxtConfirmarContrasenaU.Text)
                    {
                        Connection conexion = new Connection();
                        conexion.AbrirConexion();
                        if (!(conexion.ExisteUsuario(CtxtNombreUsuario.Text.ToUpper())))
                        {
                            decimal id = GenerarId();
                            string coe = Controllers.Encrypt.GetMD5(CtxtContrasenaU.Text);
                            String _query = "INSERT INTO Usuario (Id,NombreUsuario,Nombre,Apellido,Telefono,Correo,Contra,Rol) VALUES (" + id + ",'" + CtxtNombreUsuario.Text + "','" + CtxtNombreU.Text + "','" + CtxtApellidoU.Text + "','" + CtxtTelefonoU.Text + "','" + CtxtCorreoU.Text + "','" + coe + "','Trabajador')";
                            conexion.AddElements(_query,"usuario");
                            //------------------------------------------------
                            DialogResult resultado = MessageBox.Show("¿Desea agregar otro usuario?", "Nuevo Usuario", MessageBoxButtons.YesNo);
                            if (resultado == DialogResult.Yes)
                            {
                                CtxtNombreUsuario.Text = "";
                                CtxtNombreU.Text = "";
                                CtxtApellidoU.Text = "";
                                CtxtTelefonoU.Text = "";
                                CtxtCorreoU.Text = "";
                                CtxtContrasenaU.Text = "";
                                CtxtConfirmarContrasenaU.Text = "";
                            }
                            else if (resultado == DialogResult.No)
                            {
                                ViewLogin login = new ViewLogin();
                                this.Hide();
                                login.Show();
                            }
                            conexion.CerrarConexion();
                        }
                        else
                        {
                            MessageBox.Show("NO SE PUEDE AGREGAR UN NUEVO USUARIO PORQUE EL NOMBRE DE USUARIO YA EXISTE", "NOMBRE DE USUARIO INVALIDO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            CtxtNombreUsuario.Text = "";
                        }
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
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ViewLogin login = new ViewLogin();
            if (reciboPeticionDe == 1)
            {
                this.Hide();
                reciboPeticionDe = 0;
            }
            else
            {
                login.Show();
                this.Hide();
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
        public void PeticionDe()
        {
            reciboPeticionDe = 1;
        }

        private void NuevoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(Char)Keys.Enter)
            {
                if (CtxtNombreUsuario.Text.Equals("") || CtxtNombreU.Text.Equals("") || CtxtApellidoU.Text.Equals("") || CtxtCorreoU.Text.Equals("")
               || CtxtTelefonoU.Text.Equals("") || CtxtContrasenaU.Text.Equals("") || CtxtConfirmarContrasenaU.Text.Equals(""))
                {
                    MessageBox.Show("NO SE PUEDE AGREGAR UN NUEVO USUARIO POR LA EXISTENCIA DE CAMPOS VACIOS", "ERROR DE CAMPOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    CtxtNombreUsuario.Text = CtxtNombreUsuario.Text.ToUpper();
                    string usuario = CtxtNombreUsuario.Text.ToUpper();
                    if (validarEmail(CtxtCorreoU.Text))
                    {
                        if (CtxtContrasenaU.Text == CtxtConfirmarContrasenaU.Text)
                        {
                            Connection conexion = new Connection();
                            conexion.AbrirConexion();
                            if (!(conexion.ExisteUsuario(CtxtNombreUsuario.Text.ToUpper())))
                            {
                                decimal id = GenerarId();
                                string coe = Controllers.Encrypt.GetMD5(CtxtContrasenaU.Text);
                                String _query = "INSERT INTO Usuario (Id,NombreUsuario,Nombre,Apellido,Telefono,Correo,Contra,Rol) VALUES (" + id + ",'" + CtxtNombreUsuario.Text + "','" + CtxtNombreU.Text + "','" + CtxtApellidoU.Text + "','" + CtxtTelefonoU.Text + "','" + CtxtCorreoU.Text + "','" + coe + "','Trabajador')";
                                conexion.AddElements(_query,"usuario");
                                //------------------------------------------------
                                conexion.CerrarConexion();
                                DialogResult resultado = MessageBox.Show("¿Desea agregar otro usuario?", "Nuevo Usuario", MessageBoxButtons.YesNo);
                                if (resultado == DialogResult.Yes)
                                {
                                    CtxtNombreUsuario.Text = "";
                                    CtxtNombreU.Text = "";
                                    CtxtApellidoU.Text = "";
                                    CtxtTelefonoU.Text = "";
                                    CtxtCorreoU.Text = "";
                                    CtxtContrasenaU.Text = "";
                                    CtxtConfirmarContrasenaU.Text = "";
                                }
                                else if (resultado==DialogResult.No)
                                {
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("NO SE PUEDE AGREGAR UN NUEVO USUARIO PORQUE EL NOMBRE DE USUARIO YA EXISTE", "NOMBRE DE USUARIO INVALIDO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                CtxtNombreUsuario.Text = "";
                            }
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
            }
        }

        private void CtxtConfirmarContrasenaU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (CtxtNombreUsuario.Text.Equals("") || CtxtNombreU.Text.Equals("") || CtxtApellidoU.Text.Equals("") || CtxtCorreoU.Text.Equals("")
               || CtxtTelefonoU.Text.Equals("") || CtxtContrasenaU.Text.Equals("") || CtxtConfirmarContrasenaU.Text.Equals(""))
                {
                    MessageBox.Show("NO SE PUEDE AGREGAR UN NUEVO USUARIO POR LA EXISTENCIA DE CAMPOS VACIOS", "ERROR DE CAMPOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    CtxtNombreUsuario.Text = CtxtNombreUsuario.Text.ToUpper();
                    string usuario = CtxtNombreUsuario.Text.ToUpper();
                    if (validarEmail(CtxtCorreoU.Text))
                    {
                        if (CtxtContrasenaU.Text == CtxtConfirmarContrasenaU.Text)
                        {
                            Connection conexion = new Connection();
                            conexion.AbrirConexion();
                            if (!(conexion.ExisteUsuario(CtxtNombreUsuario.Text.ToUpper())))
                            {
                                decimal id = GenerarId();
                                string coe = Controllers.Encrypt.GetMD5(CtxtContrasenaU.Text);
                                String _query = "INSERT INTO Usuario (Id,NombreUsuario,Nombre,Apellido,Telefono,Correo,Contra,Rol) VALUES (" + id + ",'" + CtxtNombreUsuario.Text + "','" + CtxtNombreU.Text + "','" + CtxtApellidoU.Text + "','" + CtxtTelefonoU.Text + "','" + CtxtCorreoU.Text + "','" + coe + "','Trabajador')";
                                conexion.AddElements(_query,"usuario");
                                //------------------------------------------------
                                DialogResult resultado = MessageBox.Show("¿Desea agregar otro usuario?", "Nuevo Usuario", MessageBoxButtons.YesNo);
                                if (resultado == DialogResult.Yes)
                                {
                                    CtxtNombreUsuario.Text = "";
                                    CtxtNombreU.Text = "";
                                    CtxtApellidoU.Text = "";
                                    CtxtTelefonoU.Text = "";
                                    CtxtCorreoU.Text = "";
                                    CtxtContrasenaU.Text = "";
                                    CtxtConfirmarContrasenaU.Text = "";
                                }
                                else if (resultado == DialogResult.No)
                                {
                                    this.Hide();
                                }
                                conexion.CerrarConexion();
                            }
                            else
                            {
                                MessageBox.Show("NO SE PUEDE AGREGAR UN NUEVO USUARIO PORQUE EL NOMBRE DE USUARIO YA EXISTE", "NOMBRE DE USUARIO INVALIDO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                CtxtNombreUsuario.Text = "";
                            }
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
            }
        }

        private void CtxtTelefonoU_TextChanged(object sender, EventArgs e)
        {
            if (CtxtTelefonoU.Text.Length > 10)
            {
                MessageBox.Show("Esta excediendo la longitud de número telefónico.", "Teléfono no válido.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CtxtTelefonoU.Text = "";
            }
            
        }

        private void NuevoUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PNewUser_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //public void PeticionDe()
        //{
        //    reciboPeticionDe = 1;
        //}
    }
}