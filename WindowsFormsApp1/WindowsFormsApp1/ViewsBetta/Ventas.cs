using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.ViewsBetta
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void buscarTbxVentas_TextChanged(object sender, EventArgs e)
        {

        }

        private void SbtnCerrarVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
