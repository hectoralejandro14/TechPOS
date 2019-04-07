using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1.ViewsBetta
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            SpbBtnRestaurar.Visible = false;
        }
        //-------------------------------------------------------------------------------------------
        //DISEÑO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparap, int lparam);
        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 86;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }
        private void SpbBtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SpbBtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            SpbBtnMaximizar.Visible = false;
            SpbBtnRestaurar.Visible = true;
        }
        private void SpbBtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            SpbBtnMaximizar.Visible = true;
            SpbBtnRestaurar.Visible = false;
        }
        private void SpbBtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void MenuVertical_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void PanelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //--------------------------------------------------------------------------------------------
        //EVENTOS
        private void SBtnProductos_Click(object sender, EventArgs e)
        {
            
        }
        private void SBtnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Ventas());
        }
        //--------------------------------------------------------------------------------------------
        //METODOS
        private void AbrirFormEnPanel(object FormHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }
            Form form = FormHijo as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(form);
            this.PanelContenedor.Tag = form;
            form.Show();
        }
    }
}
