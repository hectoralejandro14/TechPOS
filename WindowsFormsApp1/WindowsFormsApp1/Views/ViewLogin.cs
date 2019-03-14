﻿using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Views;
using System.Security.Cryptography;
using System.Text;
using WindowsFormsApp1.DBConnectio;

namespace WindowsFormsApp1
{
    public partial class ViewLogin : Form
    {
        private ViewTabs _vistaTabs = new ViewTabs();
        public ViewLogin()
        {
            InitializeComponent();
            //Cambiar el tipo de letra que se muestra en el TextBox
            

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Equals("") || txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("No se pudo iniciar sesión por existencia de campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtContrasena.Text = "";
                txtUsuario.Text = "";
            }
            else
            {
                Connection db = new Connection();
                string auxNu = txtUsuario.Text;
                string nu = auxNu.ToUpper();
                string co = txtContrasena.Text;
                /*MD5 md5Hash = MD5.Create();
                string hash = encriptar.GetMd5Hash(md5Hash, co);*/
                db.AbrirConexion();
                if (db.IniciarSesion(nu, co) == "Administrador")
                {
                    _vistaTabs.MostrarConfiguracionUsuarios("Administrador");
                    _vistaTabs.Show();
                    this.Hide();
                }
                else if (db.IniciarSesion(nu, co) == "Trabajador")
                {
                    _vistaTabs.Show();
                    this.Hide();
                }
                else{
                    MessageBox.Show("Error! Usuario y/o Contraseña Incorrectas", "Sesión fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                db.CerrarConexion();               
                /*
                 *NO BORRAR COMENTARIO 
                 *DBConnection.Connection conexion = new DBConnection.Connection();
                conexion.AbrirConexion();
                String pass = txtContrasena.Text;
                MD5 md5Hash = MD5.Create();
                string hash = GetMd5Hash(md5Hash, pass);
                conexion.CerrarConexion();*/
            }
            
        }
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Length >= 25 && !(txtUsuario.Text.Equals("")))
            {
                MessageBox.Show("Usted " + txtUsuario.Text + ", esta excediendo la dimension de caracteres",
                    "Error de dimensiones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtContrasena.Text.Length >= 25)
            {
                MessageBox.Show("Usted esta excediendo la dimension de caracteres",
                    "Error de dimensiones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void SlinklabelNuevoTrabajador_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NuevoUsuario nuevoUsuario = new NuevoUsuario();
            this.Hide();
            nuevoUsuario.Show();
        }
        private void ViewLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtUsuario.Text.Equals("")&&txtContrasena.Text.Equals(""))
            {
                MessageBox.Show("No se permiten campos vacios","Alerta",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    Connection db = new Connection();
                    string nu = txtUsuario.Text;
                    string co = txtContrasena.Text;
                    /*MD5 md5Hash = MD5.Create();
                    string hash = encriptar.GetMd5Hash(md5Hash, co);*/
                    db.AbrirConexion();
                    if (db.IniciarSesion(nu, co) == "Administrador")
                    {
                        _vistaTabs.MostrarConfiguracionUsuarios("Administrador");
                        _vistaTabs.Show();
                        this.Hide();
                    }
                    else if (db.IniciarSesion(nu, co) == "Trabajador")
                    {
                        _vistaTabs.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error! Usuario y/o Contraseña Incorrectas", "Sesión fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    db.CerrarConexion();
                }
            }
        }
        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtUsuario.Text.Equals("") && txtContrasena.Text.Equals(""))
            {
                MessageBox.Show("No se permiten campos vacios", "Alerta",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    Connection db = new Connection();
                    string nu = txtUsuario.Text;
                    string co = txtContrasena.Text;
                    /*MD5 md5Hash = MD5.Create();
                    string hash = encriptar.GetMd5Hash(md5Hash, co);*/
                    db.AbrirConexion();
                    if (db.IniciarSesion(nu, co) == "Administrador")
                    {
                        _vistaTabs.MostrarConfiguracionUsuarios("Administrador");
                        _vistaTabs.Show();
                        this.Hide();
                    }
                    else if (db.IniciarSesion(nu, co) == "Trabajador")
                    {
                        _vistaTabs.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error! Usuario y/o Contraseña Incorrectas", "Sesión fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    db.CerrarConexion();
                }
            }
        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}