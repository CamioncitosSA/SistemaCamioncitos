using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaControlador
{
    internal class ControladorModulos
    {
        private CD_GetData capaDatos = new CD_GetData();

        
        //LOGIN Y MENU

        public DataTable GetData(string sql_Text)
        {
            try
            {
                return capaDatos.GetData(sql_Text);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, "Error al obtener datos de la base de datos");
                return null; // Otra acción a realizar en caso de error, como retornar un DataTable vacío
            }
        }

        public bool ValidarUsuario(string usuario, string password)
        {
            try
            {
                return capaDatos.ValidarUsuario(usuario, password);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, "Error al validar el usuario");
                return false;
            }
        }


        public string ObtenerUsuarioYRol(string user, string clave)
        {
            try
            {
                return capaDatos.Set_User_Rol(user, clave);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, "Error al obtener nombre de usuario y rol");
                return string.Empty; // Otra acción a realizar en caso de error
            }
        }

        public string ObtenerRol(string user, string clave)
        {
            try
            {
                return capaDatos.Obtener_Rol(user, clave);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, "Error al obtener el rol del usuario");
                return string.Empty; // Otra acción a realizar en caso de error
            }
        }


        //CHOFERES 

        public void RegistrarVehiculo(string tipoVehiculo, string marcaV, string modeloV, string placaV, float capacidadCarga, string estado)
        {
            try
            {
                capaDatos.RegistrarVehiculo(tipoVehiculo, marcaV, modeloV, placaV, capacidadCarga, estado);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, "Error al registrar el vehículo");
            }
        }

        public DataTable ConsultarVehiculo()
        {
            try
            {
                return capaDatos.ConsultarVehiculo();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, "Error al consultar vehículos");
                return null; // Otra acción a realizar en caso de error
            }
        }

        public void ActualizarVehiculo(int vehiculoId, string tipoVehiculo, string marcaV, string modeloV, string placaV, float capacidadCarga, string estado)
        {
            try
            {
                capaDatos.ActualizarVehiculo(vehiculoId, tipoVehiculo, marcaV, modeloV, placaV, capacidadCarga, estado);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, "Error al actualizar el vehículo");
            }
        }

        public void EliminarVehiculo(int vehiculoId)
        {
            try
            {
                capaDatos.EliminarVehiculo(vehiculoId);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, "Error al eliminar el vehículo");
            }
        }

        public bool ValidarDatosVehiculo(string tipoVehiculo, string marcaV, string modeloV, string placaV, float capacidadCarga, string estado)
        {
            try
            {
                return capaDatos.ValidarDatosVehiculo(tipoVehiculo, marcaV, modeloV, placaV, capacidadCarga, estado);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, "Error al validar los datos del vehículo");
                return false;
            }
        }

        //CHOFERES

        public void RegistrarChofer(string nombres, string apellidos, string genero, string direccion, string numLicencia, DateTime venceLicencia, string disponibilidad)
        {
            try
            {
                capaDatos.RegistrarChofer(nombres, apellidos, genero, direccion, numLicencia, venceLicencia, disponibilidad);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, "Error al registrar el chofer");
            }
        }

        public DataTable ConsultarChoferes()
        {
            try
            {
                return capaDatos.ConsultarChoferes();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, "Error al consultar choferes");
                return null; // Otra acción a realizar en caso de error
            }
        }

        public void ActualizarChofer(int choferId, string nombres, string apellidos, string genero, string direccion, string numLicencia, DateTime venceLicencia, string disponibilidad)
        {
            try
            {
                capaDatos.ActualizarChofer(choferId, nombres, apellidos, genero, direccion, numLicencia, venceLicencia, disponibilidad);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, "Error al actualizar el chofer");
            }
        }

        public void EliminarChofer(int choferId)
        {
            try
            {
                capaDatos.EliminarChofer(choferId);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, "Error al eliminar el chofer");
            }
        }

        public string ConsultarDisponibilidadChofer(int choferId)
        {
            try
            {
                return capaDatos.ConsultarDisponibilidadChofer(choferId);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, "Error al consultar la disponibilidad del chofer");
                return string.Empty; // Otra acción a realizar en caso de error
            }
        }

        //RUTAS
        public void RegistrarRuta(string origen, string destino, float distancia, float tiempoEstimado, string detallesPedido, string estadoEntrega)
        {
            try
            {
                capaDatos.RegistrarRuta(origen, destino, distancia, tiempoEstimado, detallesPedido, estadoEntrega);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, "Error al registrar la ruta");
            }
        }

        public DataTable ConsultarRuta()
        {
            try
            {
                return capaDatos.ConsultarRuta();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, "Error al consultar rutas");
                return null; // Otra acción a realizar en caso de error
            }
        }

        public void ActualizarRuta(int rutaId, string origen, string destino, float distancia, float tiempoEstimado, string detallesPedido, string estadoEntrega)
        {
            try
            {
                capaDatos.ActualizarRuta(rutaId, origen, destino, distancia, tiempoEstimado, detallesPedido, estadoEntrega);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, "Error al actualizar la ruta");
            }
        }

        public void EliminarRuta(int rutaId)
        {
            try
            {
                capaDatos.EliminarRuta(rutaId);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, "Error al eliminar la ruta");
            }
        }

        public DataTable BuscarRutaPorDestino(string destino)
        {
            try
            {
                return capaDatos.BuscarRutaPorDestino(destino);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, "Error al buscar rutas por destino");
                return null; // Otra acción a realizar en caso de error
            }
        }

        //ASIGNACIONES DE RUTAS Y CHOFERES

        public DataTable ConsultarAsignacionesRuta()
        {
            try
            {
                return capaDatos.ConsultarAsignacionesRuta();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, "Error al consultar asignaciones de ruta");
                return null;
            }
        }

        public DataTable ObtenerChoferesDisponibles()
        {
            try
            {
                return capaDatos.ObtenerChoferesDisponibles();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, "Error al obtener choferes disponibles");
                return null;
            }
        }

        public DataTable ObtenerRutasPendientes()
        {
            try
            {
                return capaDatos.ObtenerRutasPendientes();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, "Error al obtener rutas pendientes");
                return null;
            }
        }

    }
}
