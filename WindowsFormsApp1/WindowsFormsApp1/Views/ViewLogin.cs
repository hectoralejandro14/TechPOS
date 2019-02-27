using System;
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
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ViewTabs tabs = new ViewTabs();
            this.Hide();
            tabs.Show();
        }
    }
}
