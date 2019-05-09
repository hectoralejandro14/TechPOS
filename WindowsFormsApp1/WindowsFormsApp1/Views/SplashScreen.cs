using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class SplashScreen : MetroFramework.Forms.MetroForm
    {
        public SplashScreen()
        {
            InitializeComponent();
            
        }

        private void TiempoRespuestaBar_Tick(object sender, System.EventArgs e)
        {
            this.metroProgressBar1.Increment(1);
            if(metroProgressBar1.Value == 100)
            {
                this.TiempoRespuestaBar.Stop();
            }
        }
    }
}
