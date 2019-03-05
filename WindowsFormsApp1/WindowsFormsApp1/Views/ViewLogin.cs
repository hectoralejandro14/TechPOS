using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Views;
namespace WindowsFormsApp1
{
    public partial class ViewLogin : Form
    {
        public ViewLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //Cambiar el tipo de letra que se muestra en el TextBox
            Font font = new Font("Arial", 13.0f);
            txtUsuario.Font = font;

            Font font2 = new Font("Arial", 18.0f);
            txtContrasena.Font = font2;
            txtContrasena.PasswordChar = '*';  
            txtContrasena.MaxLength = 25;

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ViewTabs tabs = new ViewTabs();
            this.Hide();
            tabs.Show();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Length >= 25 && !(txtUsuario.Text.Equals("")))
            {
                MessageBox.Show("Usted " +txtUsuario.Text+", esta excediendo la dimension de caracteres", 
                    "Erro de dimensiones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtContrasena.Text.Length >= 25)
            {
                MessageBox.Show("Usted esta excediendo la dimension de caracteres",
                    "Erro de dimensiones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
