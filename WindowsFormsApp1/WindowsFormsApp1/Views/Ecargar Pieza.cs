﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class Ecargar_Pieza : Form
    {
        public Ecargar_Pieza()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ecargar_Pieza_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptarPieza_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Se encargó pieza correctamente.", "Pieza encargada", MessageBoxButtons.OK);
            
        }
    }
}
