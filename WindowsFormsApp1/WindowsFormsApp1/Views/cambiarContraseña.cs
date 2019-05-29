using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class cambiarContraseña : Form
    {
        public cambiarContraseña()
        {
            InitializeComponent();
        }

        private void btnAceptarA_Click(object sender, EventArgs e)
        {
            DBConnectio.Connection db = new DBConnectio.Connection();
            db.AbrirConexion();
            string coe = Controllers.Encrypt.GetMD5(txtNewPasswordA.Text);
            db.modificar("Update Usuario set Contra='"+coe+"' where NombreUsuario='"+txtUserNameA.Text+"'");
            Console.WriteLine("Update Usuario set Contra='" + coe + "' where NombreUsuario='" + txtUserNameA.Text + "'");
            db.CerrarConexion();
            ViewLogin vl = new ViewLogin();
            vl.Show();
            this.Hide();
        }

        private void btnSalirA_Click(object sender, EventArgs e)
        {
            ViewLogin vl = new ViewLogin();
            vl.Show();
            this.Hide();
        }
    }
}
