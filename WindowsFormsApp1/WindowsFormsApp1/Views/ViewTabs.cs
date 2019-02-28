using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class ViewTabs : Form
    {
        public ViewTabs()
        {
            InitializeComponent();
            txtDescripcionDeFalla.ScrollBars = ScrollBars.Vertical;
            txtDescripcionDiagnosticoEspecifico.ScrollBars = ScrollBars.Vertical;
        }

        private void linkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            ViewLogin view = new ViewLogin();
            view.Show();
        }

        private void btnPedirPieza_Click(object sender, System.EventArgs e)
        {
            EncargarProducto encargar = new EncargarProducto();
            this.Close();
            encargar.Show();
        }

        private void pictureBuscar_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Picture Buscar");
        }
    }       
}

