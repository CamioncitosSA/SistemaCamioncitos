﻿// Clase que obtiene datos de la base de datos y realiza validaciones
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

        // Método para obtener rol del usuario
        public string Obtener_Rol(string user, string clave)
        {
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
                nombreRol = reader["NOMBRE_ROL"].ToString();
            }

            // Cerrar la conexión
            db_connection.CloseConnection();

            return nombreRol;
        }

        // MODULO DE VEHICULOS

        // Método para registrar un vehículo en la base de datos
        public void RegistrarVehiculo(string tipoVehiculo, string marcaV, string modeloV, string placaV, float capacidadCarga, string estado)
        {
            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = db_connection.OpenConnection();
            sqlComando.CommandText = "REGISTRAR_VEHICULO";
            sqlComando.CommandType = CommandType.StoredProcedure;

            // Agregar parámetros para la consulta
            sqlComando.Parameters.AddWithValue("@TipoVehiculo", tipoVehiculo);
            sqlComando.Parameters.AddWithValue("@MarcaV", marcaV);
            sqlComando.Parameters.AddWithValue("@ModeloV", modeloV);
            sqlComando.Parameters.AddWithValue("@PlacaV", placaV);
            sqlComando.Parameters.AddWithValue("@CapacidadCarga", capacidadCarga);
            sqlComando.Parameters.AddWithValue("@Estado", estado);

            // Ejecutar la consulta
            sqlComando.ExecuteNonQuery();
            db_connection.CloseConnection();
        }

        // Método para consultar vehículos en la base de datos
        public DataTable ConsultarVehiculo() => GetData("CONSULTAR_VEHICULO");

        // Método para actualizar un vehículo en la base de datos
        public void ActualizarVehiculo(int vehiculoId, string tipoVehiculo, string marcaV, string modeloV, string placaV, float capacidadCarga, string estado)
        {
            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = db_connection.OpenConnection();
            sqlComando.CommandText = "ACTUALIZAR_VEHICULO";
            sqlComando.CommandType = CommandType.StoredProcedure;

            // Agregar parámetros para la consulta
            sqlComando.Parameters.AddWithValue("@IdVehiculo", vehiculoId);
            sqlComando.Parameters.AddWithValue("@TipoVehiculo", tipoVehiculo);
            sqlComando.Parameters.AddWithValue("@MarcaV", marcaV);
            sqlComando.Parameters.AddWithValue("@ModeloV", modeloV);
            sqlComando.Parameters.AddWithValue("@PlacaV", placaV);
            sqlComando.Parameters.AddWithValue("@CapacidadCarga", capacidadCarga);
            sqlComando.Parameters.AddWithValue("@Estado", estado);

            // Ejecutar la consulta
            sqlComando.ExecuteNonQuery();
            db_connection.CloseConnection();
        }

        // Método para eliminar un vehículo de la base de datos
        public void EliminarVehiculo(int vehiculoId)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_connection.OpenConnection();
            comando.CommandText = "ELIMINAR_VEHICULO";
            comando.CommandType = CommandType.StoredProcedure;

            // Agregar parámetros para la consulta
            comando.Parameters.AddWithValue("@IdVehiculo", vehiculoId);

            // Ejecutar la consulta
            comando.ExecuteNonQuery();
            db_connection.CloseConnection();
        }

        // Método para validar los datos de un vehículo
        public bool ValidarDatosVehiculo(string tipoVehiculo, string marcaV, string modeloV, string placaV, float capacidadCarga, string estado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db_connection.OpenConnection();
            cmd.CommandText = "VALIDAR_DATOS_VEHICULO";
            cmd.CommandType = CommandType.StoredProcedure;

            // Agregar parámetros para la consulta
            cmd.Parameters.AddWithValue("@TipoVehiculo", tipoVehiculo);
            cmd.Parameters.AddWithValue("@MarcaV", marcaV);
            cmd.Parameters.AddWithValue("@ModeloV", modeloV);
            cmd.Parameters.AddWithValue("@PlacaV", placaV);
            cmd.Parameters.AddWithValue("@CapacidadCarga", capacidadCarga);
            cmd.Parameters.AddWithValue("@Estado", estado);

            // Agregar parámetro de salida para almacenar el resultado
            SqlParameter outputParam = new SqlParameter("@Resultado", SqlDbType.Int);
            outputParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputParam);

            // Ejecutar la consulta
            cmd.ExecuteNonQuery();

            // Obtener el valor del parámetro de salida
            int resultado = Convert.ToInt32(cmd.Parameters["@Resultado"].Value);

            return resultado > 0;
        }

        // MODULO DE CHOFERES

        // Método para registrar un chofer en la base de datos
        public void RegistrarChofer(string nombres, string apellidos, string genero, string direccion, string numLicencia, DateTime venceLicencia, string disponibilidad)
        {
            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = db_connection.OpenConnection();
            sqlComando.CommandText = "REGISTRAR_CHOFER";
            sqlComando.CommandType = CommandType.StoredProcedure;

            // Agregar parámetros para la consulta
            sqlComando.Parameters.AddWithValue("@Nombres", nombres);
            sqlComando.Parameters.AddWithValue("@Apellidos", apellidos);
            sqlComando.Parameters.AddWithValue("@Genero", genero);
            sqlComando.Parameters.AddWithValue("@Direccion", direccion);
            sqlComando.Parameters.AddWithValue("@NumLicencia", numLicencia);
            sqlComando.Parameters.AddWithValue("@VenceLicencia", venceLicencia);
            sqlComando.Parameters.AddWithValue("@DisponibilidadC", disponibilidad);

            // Ejecutar la consulta
            sqlComando.ExecuteNonQuery();
            db_connection.CloseConnection();
        }

        // Método para consultar choferes en la base de datos
        public DataTable ConsultarChoferes() => GetData("CONSULTAR_CHOFER");

        // Método para actualizar un chofer en la base de datos
        public void ActualizarChofer(int choferId, string nombres, string apellidos, string genero, string direccion, string numLicencia, DateTime venceLicencia, string disponibilidad)
        {
            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = db_connection.OpenConnection();
            sqlComando.CommandText = "ACTUALIZAR_CHOFER";
            sqlComando.CommandType = CommandType.StoredProcedure;

            // Agregar parámetros para la consulta
            sqlComando.Parameters.AddWithValue("@IdChofer", choferId);
            sqlComando.Parameters.AddWithValue("@Nombres", nombres);
            sqlComando.Parameters.AddWithValue("@Apellidos", apellidos);
            sqlComando.Parameters.AddWithValue("@Genero", genero);
            sqlComando.Parameters.AddWithValue("@Direccion", direccion);
            sqlComando.Parameters.AddWithValue("@NumLicencia", numLicencia);
            sqlComando.Parameters.AddWithValue("@VenceLicencia", venceLicencia);
            sqlComando.Parameters.AddWithValue("@DisponibilidadC", disponibilidad);

            // Ejecutar la consulta
            sqlComando.ExecuteNonQuery();
            db_connection.CloseConnection();
        }

        // Método para eliminar un chofer de la base de datos
        public void EliminarChofer(int choferId)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_connection.OpenConnection();
            comando.CommandText = "ELIMINAR_CHOFER";
            comando.CommandType = CommandType.StoredProcedure;

            // Agregar parámetros para la consulta
            comando.Parameters.AddWithValue("@IdChofer", choferId);

            // Ejecutar la consulta
            comando.ExecuteNonQuery();
            db_connection.CloseConnection();
        }

        // Método para consultar la disponibilidad de un chofer
        public string ConsultarDisponibilidadChofer(int choferId)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db_connection.OpenConnection();
            cmd.CommandText = "CONSULTAR_DISPONIBILIDAD_CHOFER";
            cmd.CommandType = CommandType.StoredProcedure;

            // Agregar parámetros para la consulta
            cmd.Parameters.AddWithValue("@IdChofer", choferId);

            // Ejecutar la consulta
            SqlDataReader reader = cmd.ExecuteReader();

            string disponibilidad = null;

            // Verificar si hay filas en el resultado
            if (reader.HasRows)
            {
                // Leer la primera fila del resultado
                reader.Read();

                // Obtener el valor de disponibilidad de la columna "DisponibilidadC"
                disponibilidad = reader["DisponibilidadC"].ToString();
            }

            // Cerrar el SqlDataReader
            reader.Close();

            db_connection.CloseConnection();

            return disponibilidad;
        }

        // MODULOS DE RUTAS

        // Método para registrar una ruta en la base de datos
        public void RegistrarRuta(string origen, string destino, float distancia, float tiempoEstimado, string detallesPedido, string estadoEntrega)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = db_connection.OpenConnection();
            sqlCommand.CommandText = "REGISTRAR_RUTA";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Agregar parámetros para la consulta
            sqlCommand.Parameters.AddWithValue("@Origen", origen);
            sqlCommand.Parameters.AddWithValue("@Destino", destino);
            sqlCommand.Parameters.AddWithValue("@DistanciaR", distancia);
            sqlCommand.Parameters.AddWithValue("@TiempoEstimado", tiempoEstimado);
            sqlCommand.Parameters.AddWithValue("@DetallesPedido", detallesPedido);
            sqlCommand.Parameters.AddWithValue("@EstadoEntrega", estadoEntrega);

            // Ejecutar la consulta
            sqlCommand.ExecuteNonQuery();
            db_connection.CloseConnection();
        }

        // Método para consultar rutas en la base de datos
        public DataTable ConsultarRuta() => GetData("CONSULTAR_RUTA");

        // Método para actualizar una ruta en la base de datos
        public void ActualizarRuta(int rutaId, string origen, string destino, float distancia, float tiempoEstimado, string detallesPedido, string estadoEntrega)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = db_connection.OpenConnection();
            sqlCommand.CommandText = "ACTUALIZAR_RUTA";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Agregar parámetros para la consulta
            sqlCommand.Parameters.AddWithValue("@IDRuta", rutaId);
            sqlCommand.Parameters.AddWithValue("@Origen", origen);
            sqlCommand.Parameters.AddWithValue("@Destino", destino);
            sqlCommand.Parameters.AddWithValue("@DistanciaR", distancia);
            sqlCommand.Parameters.AddWithValue("@TiempoEstimado", tiempoEstimado);
            sqlCommand.Parameters.AddWithValue("@DetallesPedido", detallesPedido);
            sqlCommand.Parameters.AddWithValue("@EstadoEntrega", estadoEntrega);

            // Ejecutar la consulta
            sqlCommand.ExecuteNonQuery();
            db_connection.CloseConnection();
        }

        // Método para eliminar una ruta de la base de datos
        public void EliminarRuta(int rutaId)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = db_connection.OpenConnection();
            sqlCommand.CommandText = "ELIMINAR_RUTA";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Agregar parámetros para la consulta
            sqlCommand.Parameters.AddWithValue("@IDRuta", rutaId);

            // Ejecutar la consulta
            sqlCommand.ExecuteNonQuery();
            db_connection.CloseConnection();
        }

        // Método para buscar rutas por Destino
        public DataTable BuscarRutaPorDestino(string destino)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = db_connection.OpenConnection();
            sqlCommand.CommandText = "BuscarRutaPorDestino";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Agregar parámetros para el procedimiento almacenado
            sqlCommand.Parameters.AddWithValue("@Destino", destino);

            // Ejecutar la consulta y obtener los resultados en un DataTable
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataTable);

            // Cerrar la conexión a la base de datos
            db_connection.CloseConnection();

            return dataTable;
        }


        // ASIGNACIONES RUTAS/CHOFERES

        // Método para registrar una asignación de ruta en la base de datos
        public void RegistrarAsignacionRuta(int idChofer, int idRuta)
        {
            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = db_connection.OpenConnection();
            sqlComando.CommandText = "RegistrarAsignacionRuta";
            sqlComando.CommandType = CommandType.StoredProcedure;

            // Agregar parámetros para la consulta
            sqlComando.Parameters.AddWithValue("@IdChofer", idChofer);
            sqlComando.Parameters.AddWithValue("@IDRuta", idRuta);

            // Ejecutar la consulta
            sqlComando.ExecuteNonQuery();
            db_connection.CloseConnection();

            // Cambiar disponibilidad del chofer a 'N'
            ActualizarDisponibilidadChofer(idChofer, "N");

            // Cambiar estado de entrega de la ruta a 'En Proceso'
            ActualizarEstadoEntregaRuta(idRuta, "En Proceso");
        }


        // Método para consultar las asignaciones de ruta en la base de datos
        public DataTable ConsultarAsignacionesRuta()
        {
            return GetData("ConsultarAsignacionesRuta");
        }

        public void EliminarAsignacionRuta(int idAsignacionRuta)
        {
            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = db_connection.OpenConnection();
            sqlComando.CommandText = "EliminarAsignacionRuta";
            sqlComando.CommandType = CommandType.StoredProcedure;

            // Agregar parámetros para la consulta
            sqlComando.Parameters.AddWithValue("@IdAsignacionRuta", idAsignacionRuta);

            // Obtener IdChofer e IDRuta de la asignación de ruta para revertir cambios
            int idChofer = ObtenerIdChoferPorAsignacion(idAsignacionRuta);
            int idRuta = ObtenerIdRutaPorAsignacion(idAsignacionRuta);

            // Cambiar disponibilidad del chofer a 'D'
            ActualizarDisponibilidadChofer(idChofer, "D");

            sqlComando.Connection = db_connection.OpenConnection();

            // Cambiar estado de entrega de la ruta a 'Disponible'
            ActualizarEstadoEntregaRuta(idRuta, "Pendiente");

            sqlComando.Connection = db_connection.OpenConnection();

            // Ejecutar la consulta
            sqlComando.ExecuteNonQuery();
            db_connection.CloseConnection();
        }

        // Método para obtener una lista de choferes disponibles en la base de datos
        public DataTable ObtenerChoferesDisponibles() => GetData("ObtenerChoferesDisponibles");

        // Método para obtener una lista de rutas pendientes en la base de datos
        public DataTable ObtenerRutasPendientes() => GetData("ObtenerRutasPendientes");



        private int ObtenerIdChoferPorAsignacion(int idAsignacionRuta)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = db_connection.OpenConnection();
            sqlCommand.CommandText = "ObtenerIdChoferPorAsignacion";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Agregar parámetros para el procedimiento almacenado
            sqlCommand.Parameters.AddWithValue("@IdAsignacionRuta", idAsignacionRuta);

            // Ejecutar la consulta y obtener el resultado
            int idChofer = Convert.ToInt32(sqlCommand.ExecuteScalar());

            db_connection.CloseConnection();

            return idChofer;
        }

        private int ObtenerIdRutaPorAsignacion(int idAsignacionRuta)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = db_connection.OpenConnection();
            sqlCommand.CommandText = "ObtenerIdRutaPorAsignacion";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Agregar parámetros para el procedimiento almacenado
            sqlCommand.Parameters.AddWithValue("@IdAsignacionRuta", idAsignacionRuta);

            // Ejecutar la consulta y obtener el resultado
            int idRuta = Convert.ToInt32(sqlCommand.ExecuteScalar());

            db_connection.CloseConnection();

            return idRuta;
        }

        public void ActualizarDisponibilidadChofer(int idChofer, string disponibilidad)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = db_connection.OpenConnection();
            sqlCommand.CommandText = "ActualizarDisponibilidadChofer";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Agregar parámetros para el procedimiento almacenado
            sqlCommand.Parameters.AddWithValue("@IdChofer", idChofer);
            sqlCommand.Parameters.AddWithValue("@DisponibilidadC", disponibilidad);

            // Ejecutar la consulta
            sqlCommand.ExecuteNonQuery();
            db_connection.CloseConnection();
        }

        public void ActualizarEstadoEntregaRuta(int idRuta, string estadoEntrega)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = db_connection.OpenConnection();
            sqlCommand.CommandText = "ActualizarEstadoEntregaRuta";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Agregar parámetros para el procedimiento almacenado
            sqlCommand.Parameters.AddWithValue("@IDRuta", idRuta);
            sqlCommand.Parameters.AddWithValue("@EstadoEntrega", estadoEntrega);

            // Ejecutar la consulta
            sqlCommand.ExecuteNonQuery();
            db_connection.CloseConnection();
        }


    }
}

