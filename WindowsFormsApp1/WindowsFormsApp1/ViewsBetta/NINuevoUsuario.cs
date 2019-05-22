using System;
using System.Drawing;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsFormsApp1.DBConnectio;

namespace WindowsFormsApp1.ViewsBetta
{
    public partial class NINuevoUsuario : Form
    {
        public NINuevoUsuario()
        {
            InitializeComponent();
        }
        //------------------------------------------------------------------------------------------
        //DISEÑO
        //PODER MOVER FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparap, int lparam);
        private void BtnVolverLoginNUNI_Click(object sender, EventArgs e)
        {
            ViewLogin login = new ViewLogin();
            this.Hide();
            login.Show();

        }
        private void NINuevoUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void LogoPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void PanelNiNuevoUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //EFECTOS PLACEHOLDER
        private void NICtxtNombreUsuario_Enter(object sender, EventArgs e)
        {
            if (NICtxtNombreUsuario.Text == "NOMBRE DE USUARIO")
            {
                NICtxtNombreUsuario.Text = "";
                NICtxtNombreUsuario.ForeColor = Color.Orange;
            }
        }
        private void NICtxtNombreUsuario_Leave(object sender, EventArgs e)
        {
            if (NICtxtNombreUsuario.Text == "")
            {
                NICtxtNombreUsuario.Text = "NOMBRE DE USUARIO";
                NICtxtNombreUsuario.ForeColor = Color.DimGray;
            }
        }
        private void NICtxtNombreU_Enter(object sender, EventArgs e)
        {
            if (NICtxtNombreU.Text == "NOMBRE")
            {
                NICtxtNombreU.Text = "";
                NICtxtNombreU.ForeColor = Color.Orange;
            }

        }
        private void NICtxtNombreU_Leave(object sender, EventArgs e)
        {
            if (NICtxtNombreU.Text == "")
            {
                NICtxtNombreU.Text = "NOMBRE";
                NICtxtNombreU.ForeColor = Color.DimGray;
            }
        }
        private void NICtxtApellidoU_Enter(object sender, EventArgs e)
        {
            if (NICtxtApellidoU.Text == "APELLIDO")
            {
                NICtxtApellidoU.Text = "";
                NICtxtApellidoU.ForeColor = Color.Orange;
            }
        }
        private void NICtxtApellidoU_Leave(object sender, EventArgs e)
        {
            if (NICtxtApellidoU.Text == "")
            {
                NICtxtApellidoU.Text = "APELLIDO";
                NICtxtApellidoU.ForeColor = Color.DimGray;
            }
        }
        private void NiCtxtTelefonoU_Enter(object sender, EventArgs e)
        {
            if (NiCtxtTelefonoU.Text == "TELEFONO")
            {
                NiCtxtTelefonoU.Text = "";
                NiCtxtTelefonoU.ForeColor = Color.Orange;
            }
        }
        private void NiCtxtTelefonoU_Leave(object sender, EventArgs e)
        {
            if (NiCtxtTelefonoU.Text == "")
            {
                NiCtxtTelefonoU.Text = "TELEFONO";
                NiCtxtTelefonoU.ForeColor = Color.DimGray;
            }
        }
        private void NICtxtCorreoU_Enter(object sender, EventArgs e)
        {
            if (NICtxtCorreoU.Text == "CORREO")
            {
                NICtxtCorreoU.Text = "";
                NICtxtCorreoU.ForeColor = Color.Orange;
            }
        }
        private void NICtxtCorreoU_Leave(object sender, EventArgs e)
        {
            if (NICtxtCorreoU.Text == "")
            {
                NICtxtCorreoU.Text = "CORREO";
                NICtxtCorreoU.ForeColor = Color.DimGray;
            }
        }
        private void NICtxtContrasenaU_Enter(object sender, EventArgs e)
        {
            if (NICtxtContrasenaU.Text == "CONTRASEÑA")
            {
                NICtxtContrasenaU.Text = "";
                NICtxtContrasenaU.ForeColor = Color.Orange;
                NICtxtContrasenaU.UseSystemPasswordChar = true;
            }
        }
        private void NICtxtContrasenaU_Leave(object sender, EventArgs e)
        {
            if (NICtxtContrasenaU.Text == "")
            {
                NICtxtContrasenaU.Text = "CONTRASEÑA";
                NICtxtContrasenaU.ForeColor = Color.DimGray;
                NICtxtContrasenaU.UseSystemPasswordChar = false;
            }
        }
        private void NICtxtConfirmarContrasenaU_Enter(object sender, EventArgs e)
        {
            if (NICtxtConfirmarContrasenaU.Text == "CONFIRMAR CONTRASEÑA")
            {
                NICtxtConfirmarContrasenaU.Text = "";
                NICtxtConfirmarContrasenaU.ForeColor = Color.Orange;
                NICtxtConfirmarContrasenaU.UseSystemPasswordChar = true;
            }

        }
        private void NICtxtConfirmarContrasenaU_Leave(object sender, EventArgs e)
        {
            if (NICtxtConfirmarContrasenaU.Text == "")
            {
                NICtxtConfirmarContrasenaU.Text = "CONFIRMAR CONTRASEÑA";
                NICtxtConfirmarContrasenaU.ForeColor = Color.DimGray;
                NICtxtConfirmarContrasenaU.UseSystemPasswordChar = false;
            }
        }
        private void BtnRegistrarNuevoUsuario_Click(object sender, EventArgs e)
        {
            if (NICtxtNombreUsuario.Text.Equals("NOMBRE DE USUARIO") || NICtxtNombreU.Text.Equals("NOMBRE") || NICtxtApellidoU.Text.Equals("APELLIDO") || NICtxtCorreoU.Text.Equals("CORREO")
                || NiCtxtTelefonoU.Text.Equals("TELEFONO") || NICtxtContrasenaU.Text.Equals("CONTRASEÑA") || NICtxtConfirmarContrasenaU.Text.Equals("CONFIRMAR CONTRASEÑA"))
            {
                MessageBox.Show("NO SE PUEDE AGREGAR UN NUEVO USUARIO POR LA EXISTENCIA DE CAMPOS VACIOS", "ERROR DE CAMPOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                NICtxtNombreUsuario.Text = NICtxtNombreUsuario.Text.ToUpper();
                string usuario = NICtxtNombreUsuario.Text.ToUpper();
                if (validarEmail(NICtxtCorreoU.Text))
                {
                    if (NICtxtContrasenaU.Text == NICtxtConfirmarContrasenaU.Text)
                    {
                        Connection conexion = new Connection();
                        conexion.AbrirConexion();
                        if (!(conexion.ExisteUsuario(NICtxtNombreUsuario.Text.ToUpper())))
                        {
                            decimal id = GenerarId();
                            string coe = Controllers.Encrypt.GetMD5(NICtxtContrasenaU.Text);
                            String _query = "INSERT INTO Usuario (Id,NombreUsuario,Nombre,Apellido,Telefono,Correo,Contra,Rol) VALUES (" + id + ",'" + NICtxtNombreUsuario.Text + "','" + NICtxtNombreU.Text + "','" + NICtxtApellidoU.Text + "','" + NiCtxtTelefonoU.Text + "','" + NICtxtCorreoU.Text + "','" + coe + "','Trabajador')";
                            conexion.AddElements(_query, "usuario");
                            //------------------------------------------------
                            DialogResult resultado = MessageBox.Show("¿Desea agregar otro usuario?", "Nuevo Usuario", MessageBoxButtons.YesNo);
                            if (resultado == DialogResult.Yes)
                            {
                                NICtxtNombreUsuario.Text = "NOMBRE DE USUARIO";
                                NICtxtNombreU.Text = "NOMBRE";
                                NICtxtApellidoU.Text = "APELLIDO";
                                NiCtxtTelefonoU.Text = "TELEFONO";
                                NICtxtCorreoU.Text = "CORREO";
                                NICtxtContrasenaU.Text = "CONTRASEÑA";
                                NICtxtConfirmarContrasenaU.Text = "CONFIRMAR CONTRASEÑA";
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
                            NICtxtNombreUsuario.Text = "NOMBRE DE USUARIO";
                        }
                    }
                    else
                    {
                        MessageBox.Show("LOS CAMPOS DE CONTRASEÑAS NO SON IGUALES", "NO COINCIDENCIAS", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        NICtxtContrasenaU.Text = "CONTRASEÑA";
                        NICtxtConfirmarContrasenaU.Text = "CONFIRMAR CONTRASEÑA";
                    }
                }
                else
                {
                    MessageBox.Show("NO SE PUEDE AGREGAR UN NUEVO USUARIO PORQUE EL FORMATO DE CORREO ES INVALIDO", "FORMATO NO VALIDO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
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
        private void NiCtxtTelefonoU_KeyPress(object sender, KeyPressEventArgs e)
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
        private void NICtxtConfirmarContrasenaU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (NICtxtNombreUsuario.Text.Equals("NOMBRE DE USUARIO") || NICtxtNombreU.Text.Equals("NOMBRE") || NICtxtApellidoU.Text.Equals("NOMBRE") || NICtxtCorreoU.Text.Equals("CORREO")
               || NiCtxtTelefonoU.Text.Equals("TELEFONO") || NICtxtContrasenaU.Text.Equals("CONTRASEÑA") || NICtxtConfirmarContrasenaU.Text.Equals("CONFIRMAR CONTRASEÑA"))
                {
                    MessageBox.Show("NO SE PUEDE AGREGAR UN NUEVO USUARIO POR LA EXISTENCIA DE CAMPOS VACIOS", "ERROR DE CAMPOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    NICtxtNombreUsuario.Text = NICtxtNombreUsuario.Text.ToUpper();
                    string usuario = NICtxtNombreUsuario.Text.ToUpper();
                    if (validarEmail(NICtxtCorreoU.Text))
                    {
                        if (NICtxtContrasenaU.Text == NICtxtConfirmarContrasenaU.Text)
                        {
                            Connection conexion = new Connection();
                            conexion.AbrirConexion();
                            if (!(conexion.ExisteUsuario(NICtxtNombreUsuario.Text.ToUpper())))
                            {
                                decimal id = GenerarId();
                                string coe = Controllers.Encrypt.GetMD5(NICtxtContrasenaU.Text);
                                String _query = "INSERT INTO Usuario (Id,NombreUsuario,Nombre,Apellido,Telefono,Correo,Contra,Rol) VALUES (" + id + ",'" + NICtxtNombreUsuario.Text + "','" + NICtxtNombreU.Text + "','" + NICtxtApellidoU.Text + "','" + NiCtxtTelefonoU.Text + "','" + NICtxtCorreoU.Text + "','" + coe + "','Trabajador')";
                                conexion.AddElements(_query, "usuario");
                                //------------------------------------------------
                                DialogResult resultado = MessageBox.Show("¿Desea agregar otro usuario?", "Nuevo Usuario", MessageBoxButtons.YesNo);
                                if (resultado == DialogResult.Yes)
                                {
                                    NICtxtNombreUsuario.Text = "NOMBRE DE USUARIO";
                                    NICtxtNombreU.Text = "NOMBRE";
                                    NICtxtApellidoU.Text = "NOMBRE";
                                    NiCtxtTelefonoU.Text = "TELEFONO";
                                    NICtxtCorreoU.Text = "CORREO";
                                    NICtxtContrasenaU.Text = "CONTRASEÑA";
                                    NICtxtConfirmarContrasenaU.Text = "CONFIRMAR CONTRASEÑA";
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
                                NICtxtNombreUsuario.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("LOS CAMPOS DE CONTRASEÑAS NO SON IGUALES", "NO COINCIDENCIAS", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            NICtxtContrasenaU.Text = "CONTRASEÑA";
                            NICtxtConfirmarContrasenaU.Text = "CONFIRMAR CONTRASEÑA";
                        }
                    }
                    else
                    {
                        MessageBox.Show("NO SE PUEDE AGREGAR UN NUEVO USUARIO PORQUE EL FORMATO DE CORREO ES INVALIDO", "FORMATO NO VALIDO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
        }
        private void NiCtxtTelefonoU_TextChanged(object sender, EventArgs e)
        {
            if (NiCtxtTelefonoU.Text.Length > 10)
            {
                MessageBox.Show("Esta excediendo la longitud de número telefónico.", "Teléfono no válido.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NiCtxtTelefonoU.Text = "";
                NiCtxtTelefonoU.ForeColor = Color.DarkGray;
            }
        }
    }
}
