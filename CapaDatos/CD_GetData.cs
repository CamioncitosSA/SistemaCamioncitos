// Clase que obtiene datos de la base de datos y realiza validaciones
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_GetData
    {
        // Se instancia la clase CD_Connection para manejar la conexión a la base de datos
        public CD_Connection db_connection = new CD_Connection();
        SqlDataReader dataReader;

        // Método para obtener datos de la base de datos
        public DataTable GetData(string sql_Text)
        {
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataAdapter dataAdapter;

            // Se establece la conexión
            sqlCommand.Connection = db_connection.OpenConnection();
            // Se asigna el comando y se asigna el SQL
            sqlCommand.CommandText = sql_Text;
            // Se crea el DataAdapter
            dataAdapter = new SqlDataAdapter(sqlCommand);
            // Se llena el DataTable con los datos del DataAdapter
            dataAdapter.Fill(dataTable);

            // Se cierra la conexión
            db_connection.CloseConnection();

            return dataTable;
        }

        // Método para validar un usuario en el sistema
        public bool ValidarUsuario(string usuario, string password)
        {
            bool bandera = true;
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_connection.OpenConnection();
            comando.CommandText = "VALIDAR_LOGIN_USUARIO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@USERNAME", usuario);
            comando.Parameters.AddWithValue("@PASSWORD", password);
            string resultado = Convert.ToString(comando.ExecuteScalar().ToString());

            if (resultado.StartsWith("ERROR: USUARIO"))
            {
                // Mostrar mensaje de inicio de sesión fallido
                MessageBox.Show(resultado, "INICIO DE SESIÓN FALLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bandera = false;
            }
            else
            {
                // Mostrar mensaje de inicio de sesión exitoso
                MessageBox.Show(resultado, "INICIO DE SESIÓN EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Cerrar la conexión
            db_connection.CloseConnection();

            return bandera;
        }

        // Método para obtener el nombre de usuario y rol
        public string Set_User_Rol(string user, string clave)
        {
            string nombreUsuario = "";
            string nombreRol = "";
            SqlCommand command = new SqlCommand();
            command.Connection = db_connection.OpenConnection();
            command.CommandText = "OBTENER_USUARIO_Y_ROL";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@USERNAME", user);
            command.Parameters.AddWithValue("@PASSWORD", clave);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                nombreUsuario = reader["NOMBRE_USUARIO"].ToString();
                nombreRol = reader["NOMBRE_ROL"].ToString();
            }

            // Cerrar la conexión
            db_connection.CloseConnection();

            return "USUARIO: " + nombreUsuario + "    ROL: " + nombreRol;
        }

        //MODULO DE VEHICULOS

        public void RegistrarVehiculo(string tipoVehiculo, string matricula, bool asegurado, string marca, char estado)
        {
            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = db_connection.OpenConnection();
            sqlComando.CommandText = "REGISTRAR_VEHICULO";
            sqlComando.CommandType = CommandType.StoredProcedure;

            sqlComando.Parameters.AddWithValue("@TIPO_VEHICULO", tipoVehiculo);
            sqlComando.Parameters.AddWithValue("@MATRICULA", matricula);
            sqlComando.Parameters.AddWithValue("@ASEGURADO", asegurado);
            sqlComando.Parameters.AddWithValue("@MARCA", marca);
            sqlComando.Parameters.AddWithValue("@ESTADO", estado);

            sqlComando.ExecuteNonQuery();
            db_connection.CloseConnection();
        }

        public DataTable ConsultarVehiculo() => GetData("CONSULTAR_VEHICULO");

        public void ActualizarVehiculo(int vehiculoId, string tipoVehiculo, string matricula, bool asegurado, string marca, char estado)
        {
            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = db_connection.OpenConnection();
            sqlComando.CommandText = "ACTUALIZAR_VEHICULO";
            sqlComando.CommandType = CommandType.StoredProcedure;

            sqlComando.Parameters.AddWithValue("@ID_VEHICULO", vehiculoId);
            sqlComando.Parameters.AddWithValue("@TIPO_VEHICULO", tipoVehiculo);
            sqlComando.Parameters.AddWithValue("@MATRICULA", matricula);
            sqlComando.Parameters.AddWithValue("@ASEGURADO", asegurado);
            sqlComando.Parameters.AddWithValue("@MARCA", marca);
            sqlComando.Parameters.AddWithValue("@ESTADO", estado);

            sqlComando.ExecuteNonQuery();
            db_connection.CloseConnection();
        }

        public void EliminarVehiculo(int vehiculoId)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_connection.OpenConnection();
            comando.CommandText = "ELIMINAR_VEHICULO";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@ID_VEHICULO", vehiculoId);

            comando.ExecuteNonQuery();
            db_connection.CloseConnection();
        }

        



    }
}

