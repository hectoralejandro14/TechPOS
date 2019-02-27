using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class ViewTabs : Form
    {
        public ViewTabs()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void ViewTabs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                MessageBox.Show("TECLA SELECCIONADA");
            }
        }       
    }
}
