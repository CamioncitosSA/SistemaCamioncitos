// Clase que establece y administra la conexión con la base de datos
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Connection
    {
        // Establece la cadena de conexión a la base de datos
        private SqlConnection db_connection = new SqlConnection("Server=Nombre_Servidor; Database=Nombre_BaseDatos; Integrated Security=true");

        // Abre la conexión con la base de datos
        public SqlConnection OpenConnection()
        {
            if (db_connection.State == ConnectionState.Closed)
                db_connection.Open();
            return db_connection;
        }

        // Cierra la conexión con la base de datos
        public SqlConnection CloseConnection()
        {
            if (db_connection.State == ConnectionState.Open)
                db_connection.Close();
            return db_connection;
        }
    }
}


