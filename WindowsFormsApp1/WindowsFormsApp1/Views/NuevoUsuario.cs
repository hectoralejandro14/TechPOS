using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnAceptarr_Click(object sender, EventArgs e)
        {
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
    }
}
