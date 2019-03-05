using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Views;
using System.Security.Cryptography;
using System.Text;

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
            String pass = txtContrasena.Text;
            using (MD5 md5Hash = MD5.Create())
            {
                string hash = GetMd5Hash(md5Hash, pass);
                Console.WriteLine(hash);
            }
            
            ViewTabs tabs = new ViewTabs();
            this.Hide();
            tabs.Show();
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
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
