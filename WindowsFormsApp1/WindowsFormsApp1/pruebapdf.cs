using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class pruebapdf : Form
    {
        public pruebapdf(int index)
        {
            InitializeComponent();
            if (index == 1)
            {
                ReporteTres rpt = new ReporteTres();
                crystalReportViewer1.ReportSource = rpt;
            }
            else if (index == 2)
            {
                ReporteDos rpt = new ReporteDos();
                crystalReportViewer1.ReportSource = rpt;
            }
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
