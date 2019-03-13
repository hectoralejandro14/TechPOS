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
                //MessageBox.Show("Conexion establecida con la Base de Datos", "Conexion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
               // MessageBox.Show("Conexion cerrada con la Base de Datos", "Conexion Cerrada", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
        //-----------------------------------------------------------------------------
        //Agregar general
        public bool AddElements(string SQL)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(SQL, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron registrados exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch
            {
                MessageBox.Show("Ocurrio un error con la conexión a la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public SqlDataReader consulta (string SQL)
        {
            SqlCommand cmd = new SqlCommand(SQL, conexion);
            SqlDataReader dr= cmd.ExecuteReader();
            return dr;
        }
        public SqlDataAdapter consultaMasDatos(String SQL)
        {
            SqlCommand cmd = new SqlCommand(SQL, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            return da;
        }
        public DataTable buscarReparacion(string cadena)
        {
            adapter.SelectCommand = new SqlCommand(cadena, conexion);
            dataSet.Reset();
            adapter.Fill(dataSet);
            table = dataSet.Tables[0];

            return table;
        }
        //------------------------------------------------------------------------------
        public bool VerificarExistenciaDeId(decimal id)
        {
            string _IdString = id.ToString();
            bool aux = false;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Id FROM Usuario", conexion);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][0].ToString() == _IdString)
                    {
                        aux = true;
                    }
                }
               
            }
            catch /*(IndexOutOfRangeException e3)*/
            {
                MessageBox.Show("ERROR SQL", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return aux;
        }
        public bool VerificarExistenciaDeIdRep(String id)
        {
            string _IdString = id.ToString();
            bool aux = false;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Id FROM Reparacion", conexion);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][0].ToString() == _IdString)
                    {
                        aux = true;
                    }
                }
                
            }
            catch /*(IndexOutOfRangeException e3)*/
            {
                MessageBox.Show("ERROR SQL", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return aux;
        }
        public string IniciarSesion(string nombreUsuario, string contra)
        {
            bool existe = false;
            string rol = "";
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Rol FROM Usuario WHERE NombreUsuario = @usu AND Contra = @pass ", conexion);
                cmd.Parameters.AddWithValue("usu", nombreUsuario);
                cmd.Parameters.AddWithValue("pass", contra);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][0].ToString() == "Administrador")
                    {
                        rol = "Administrador";
                        existe = true;
                    }
                    else if (dt.Rows[0][0].ToString() == "Trabajador")
                    {
                        rol = "Trabajador";
                        existe = true;
                    }
                }
                if (!existe)
                {
                    MessageBox.Show("Error! Usuario y/o Contraseña Incorrectas", "Sesión fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch /*(IndexOutOfRangeException e3)*/
            {
                MessageBox.Show("ERROS SQL", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rol;
        }
    }
}

