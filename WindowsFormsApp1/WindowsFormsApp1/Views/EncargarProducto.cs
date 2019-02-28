using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class EncargarProducto : Form
    {
        public EncargarProducto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ViewTabs menu = new ViewTabs();
            this.Close();
            menu.Show();
        }
    }
}
