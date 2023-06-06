// Clase que maneja la lógica de negocio y actúa como intermediario entre la capa de datos y la capa de presentación
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_GetData
    {

        //Creación del objeto de la Capa de Datos
        private CD_GetData objectCD = new CD_GetData();

        //Conexion con la capa de Datos
        public DataTable CN_ShowData(string sql_text) => objectCD.GetData(sql_text);

        //VALIDACION DEL USUARIO REGISTRADO - LOGIN
        public bool Set_Login(string usuario, string clave) => (objectCD.ValidarUsuario(usuario, clave) ? true : false);
        public string CN_Get_User_ROL(string usuario, string clave) => objectCD.Set_User_Rol(usuario, clave);


        //MODULO DE VEHICULOS

        public void RegistrarVehiculo(string tipoVehiculo, string marcaV, string modeloV, string placaV, float capacidadCarga, string estado)
        {
            // Llamar al método de la capa de datos
            objectCD.RegistrarVehiculo(tipoVehiculo, marcaV, modeloV, placaV, capacidadCarga, estado);
        }

        public DataTable ConsultarVehiculo()
        {
            return objectCD.ConsultarVehiculo();
        }

        public void ActualizarVehiculo(string vehiculoId, string tipoVehiculo, string marcaV, string modeloV, string placaV, float capacidadCarga, string estado)
        {
            // Llamar al método de la capa de datos
            objectCD.ActualizarVehiculo(int.Parse(vehiculoId), tipoVehiculo, marcaV, modeloV, placaV, capacidadCarga, estado);
        }

        public void EliminarVehiculo(string vehiculoId)
        {
            // Llamar al método de la capa de datos
            objectCD.EliminarVehiculo(int.Parse(vehiculoId));
        }

        //VALIDACIONES
        public bool NoNulos(string tipoVehiculo, string marcaV, string modeloV, string placaV, string capacidadCarga, string estado) => (!string.IsNullOrEmpty(tipoVehiculo) || !string.IsNullOrEmpty(marcaV) || !string.IsNullOrEmpty(modeloV) || !string.IsNullOrEmpty(placaV) || !string.IsNullOrEmpty(capacidadCarga) || !string.IsNullOrEmpty(estado) ? false : true);
        public bool ExisteVehiculo(string tipoVehiculo, string marcaV, string modeloV, string placaV, float capacidadCarga, string estado)
        {
            // Llamar al método de la capa de datos
            return objectCD.ValidarDatosVehiculo(tipoVehiculo, marcaV, modeloV, placaV, capacidadCarga, estado);
        }

        //MODULO DE CHOFERES
        public void RegistrarChofer(string nombres, string apellidos, string genero, string direccion, string numLicencia, DateTime venceLicencia, string disponibilidad)
        {
            // Llamar al método de la capa de datos
            objectCD.RegistrarChofer(nombres, apellidos, genero, direccion, numLicencia, venceLicencia, disponibilidad);
        }

        public DataTable ConsultarChoferes()
        {
            return objectCD.ConsultarChoferes();
        }

        public void ActualizarChofer(string choferId, string nombres, string apellidos, string genero, string direccion, string numLicencia, DateTime venceLicencia, string disponibilidad)
        {
            // Llamar al método de la capa de datos
            objectCD.ActualizarChofer(int.Parse(choferId), nombres, apellidos, genero, direccion, numLicencia, venceLicencia, disponibilidad);
        }

        public void EliminarChofer(string choferId)
        {
            // Llamar al método de la capa de datos
            objectCD.EliminarChofer(int.Parse(choferId));
        }

        //VALIDACIONES
        public bool NoNulos(string nombres, string apellidos, string genero, string direccion, string numLicencia, DateTime venceLicencia, string disponibilidad)
        {
            return !string.IsNullOrEmpty(nombres) && !string.IsNullOrEmpty(apellidos) && !string.IsNullOrEmpty(genero) &&
                   !string.IsNullOrEmpty(direccion) && !string.IsNullOrEmpty(numLicencia) && venceLicencia != DateTime.MinValue &&
                   !string.IsNullOrEmpty(disponibilidad);
        }

        public string ConsultarDisponibilidadChofer(int choferId)
        {
            // Llamar al método de la capa de datos
            string disponibilidad = objectCD.ConsultarDisponibilidadChofer(choferId);

            // Devolver la disponibilidad del chofer
            return disponibilidad;
        }

        //MODULO DE RUTAS

        public void RegistrarRuta(string origen, string destino, float distancia, float tiempoEstimado, string detallesPedido, string estadoEntrega)
        {
            // Llamar al método de la capa de datos
            objectCD.RegistrarRuta(origen, destino, distancia, tiempoEstimado, detallesPedido, estadoEntrega);
        }

        public DataTable ConsultarRuta()
        {
            return objectCD.ConsultarRuta();
        }

        public void ActualizarRuta(int idRuta, string origen, string destino, float distancia, float tiempoEstimado, string detallesPedido, string estadoEntrega)
        {
            // Llamar al método de la capa de datos
            objectCD.ActualizarRuta(idRuta, origen, destino, distancia, tiempoEstimado, detallesPedido, estadoEntrega);
        }

        public void EliminarRuta(int idRuta)
        {
            // Llamar al método de la capa de datos
            objectCD.EliminarRuta(idRuta);
        }

        public void GenerarComprobanteEntrega(int idRuta)
        {
            // Llamar al método de la capa de datos
            objectCD.GenerarComprobanteEntrega(idRuta);
        }


    }
}

