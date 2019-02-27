using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class ViewTabs : Form
    {
        public ViewTabs()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
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
