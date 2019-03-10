using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1.DBConnectio
{
    class Connection
    {
        private string cadena = "Data Source=.\\SQLEXPRESS;Initial Catalog=TechPOSdb; Integrated Security=True";
        private SqlConnection conexion = new SqlConnection();
        SqlCommand SqlCommand;
        DataTable table = new DataTable();
        DataSet dataSet = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();
        //-----------------------------------------------------------------------------
        public Connection()
        {
            conexion.ConnectionString = cadena;
        }
        public void AbrirConexion()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion establecida con la Base de Datos");
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
                Console.WriteLine("Conexion cerrada con la Base de Datos");
            }
            catch (System.Exception e2)
            {
                MessageBox.Show("No se pudo cerrar la conexión { " + e2.Message + " } :(",
                  "Falló Cerradura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----------------------------------------------------------------------------
        //Agregar Roles
        public void AgregarRoles(string cadena,decimal Id,string NombreROL)
        {
            try
            {
                SqlCommand = new SqlCommand(cadena, conexion);
                SqlCommand.Parameters.AddWithValue("@Id", Id);
                SqlCommand.Parameters.AddWithValue("@NombreRol", NombreROL);
                int modificacion = Convert.ToInt32(SqlCommand.ExecuteNonQuery());
                if (modificacion > 0)
                {
                    MessageBox.Show("Rol Agregado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al momento de agregar Rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error con la conexión a la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Modificar Roles
        public void ModificarRol(string cadena)
        {

        }

        //Eliminar Roles
        public void EliminarRol(string cadena)
        {

        }
        //-----------------------------------------------------------------------------
        public void getId(string cadena)
        {

        }
        //Agregar general
        public void AddElements(string SQL)
        {
            SqlCommand cmd = new SqlCommand(SQL, conexion);
            cmd.ExecuteNonQuery();
        }
        //Buscar Reparacion por codigo
        public DataTable buscarReparacion(string cadena)
        {
            adapter.SelectCommand = new SqlCommand(cadena, conexion);
            adapter.Fill(dataSet);
            table = dataSet.Tables[0];
            return table;
        }
    }
}
