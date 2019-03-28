using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1.DBConnectio
{
    class Connection
    {
        
        private string cadena = "Data Source=.\\SQLEXPRESS;Initial Catalog=TechPOSdb; Integrated Security=True";
        //private string cadena = "Data Source=DESKTOP-4U4TDTF;Initial Catalog=TechPOSdb; Integrated Security=True";
        private SqlConnection conexion = new SqlConnection();
        SqlCommand SqlCommand;
        DataTable table = new DataTable();
        DataSet dataSet = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();
        //-----------------------------------------------------------------------------
        //Metodos de conexion
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
                MessageBox.Show("Ocurrió un problema en la conexión con la Base de Datos { " + e1.Message + " }",
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
        public bool AddElements(string SQL)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(SQL, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron registrados exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (System.Data.SqlClient.SqlException e2)
            {
                MessageBox.Show("Ocurrio un error con la conexión a la Base de Datos { " + e2.Message + " } ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void AgregarRoles(string cadena, decimal Id, string NombreROL)
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
        public void ActualizarDatos(string query,string rol)
        {
            try
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("EL ROL DE ["+rol+"] FUE AGREDADO CON EXITO AL USUARIO", "ROL ACTUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("NO SE PUDO AGREGAR EL ROL AL USUARIO POR PROBLEMAS DE CONECTIVIDAD. \nSI USTED NO ES TECNICO EN INFORMATICA PORFAVOR CONTACTESE CON UNO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EliminarDatos()
        {

        }
        public void modificar(string SQL)
        {
            SqlCommand = new SqlCommand (SQL, conexion);
            SqlCommand.ExecuteNonQuery();

        }
        //-----------------------------------------------------------------------------   
        public SqlDataReader consulta(string SQL)
        {
            SqlCommand cmd = new SqlCommand(SQL, conexion);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public SqlDataReader consultaq(string SQL)
        {
            SqlCommand cmd = new SqlCommand(SQL, conexion);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public SqlDataAdapter consultaMasDatos(String SQL)
        {
            SqlCommand cmd = new SqlCommand(SQL, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            return da;
        }
        public DataTable buscar(string cadena)
        {
            dataSet.Reset();
            adapter.SelectCommand = new SqlCommand(cadena, conexion);
            adapter.Fill(dataSet);
            table = dataSet.Tables[0];

            return table;
        }
        public SqlConnection getConexion()
        {
            return conexion;
        }
        //***************************************************************************
        //SE PUEDE OPTIMIZAR
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
        //***************************************************************************
        public string IniciarSesion(string nombreUsuario, string contra)
        {
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
                    }
                    else if (dt.Rows[0][0].ToString() == "Trabajador")
                    {
                        rol = "Trabajador";
                    }
                }
            }
            catch /*(IndexOutOfRangeException e3)*/
            {
                MessageBox.Show("ERROS SQL", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rol;
        }
        //***************************************************************************
        //SE PUEDE OPTIMIZAR
        public bool ExisteUsuario(string usuario)
        {
            bool aux = false;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT NombreUsuario FROM Usuario WHERE NombreUsuario = '" + usuario + "'", conexion);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][0].ToString().Equals(usuario))
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
        public bool Existe(string codigo)
        {
            bool aux = false;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT ClaveProducto FROM Producto WHERE ClaveProducto = '" + codigo + "'", conexion);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][0].ToString().Equals(codigo))
                    {
                        aux = true;
                    }
                }

            }
            catch /*(IndexOutOfRangeException e3)*/
            {
                MessageBox.Show("ERROR DE CONEXION CON SQL", "ERRO DE CONEXION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return aux;
        }

        public int modificarCliente(string sql)
        {
            int filas = 0;
            SqlCommand sc = new SqlCommand(sql, conexion);
            sc.CommandType = CommandType.Text;
            filas = sc.ExecuteNonQuery();
            return filas;
        }

        public DataTable buscarReparacion(string cadena)
        {
            dataSet.Reset();
            adapter.SelectCommand = new SqlCommand(cadena, conexion);
            adapter.Fill(dataSet);
            table = dataSet.Tables[0];

            return table;
        }
        

        public int generarIdCliente(string sql)
        {
            int id = 0;
            SqlCommand sqlCommand = new SqlCommand(sql, conexion);
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                id = Convert.ToInt32(sqlCommand.ExecuteScalar());
                id += 1;
            }
            catch (InvalidCastException)
            {
                id = 1;
            }
            return id;
        }
    }
}
