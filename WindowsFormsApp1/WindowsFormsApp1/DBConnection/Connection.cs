using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1.DBConnection
{
    class Connection
    {
        string cadena = "Data Source=.\\SQLEXPRESS;Initial Catalog=TechPOSdb; Integrated Security=True";
        SqlConnection conexion = new SqlConnection();
        public Connection()
        {
            conexion.ConnectionString = cadena;
        }
        public void AbrirConexion()
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conexion establecida con la Base de Datos", "Conexion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (System.Exception e1)
            {
                MessageBox.Show("Ocurrió un problema en la conexión con la Base de Datos { "+e1.Message+" }",
                   "Conexion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  
        public void CerrarConexion()
        {
            try
            {
                conexion.Close();
                MessageBox.Show("Conexion cerrada con la Base de Datos", "Conexion Cerrada", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (System.Exception e2)
            {
                MessageBox.Show("No se pudo cerrar la conexión { " + e2.Message + " } :(",
                  "Falló Cerradura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
