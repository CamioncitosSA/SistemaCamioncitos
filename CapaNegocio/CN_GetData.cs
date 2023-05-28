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

        public void RegistrarVehiculo(string tipoVehiculo, string matricula, bool asegurado, string marca, char estado)
        {
            // Llamar al método de la capa de datos
            objectCD.RegistrarVehiculo(tipoVehiculo, matricula, asegurado, marca, estado);
        }

        public DataTable ConsultarVehiculo()
        {
            return objectCD.ConsultarVehiculo();
        }

        public void ActualizarVehiculo(int vehiculoId, string tipoVehiculo, string matricula, bool asegurado, string marca, char estado)
        {

            // Llamar al método de la capa de datos
            objectCD.ActualizarVehiculo(vehiculoId, tipoVehiculo, matricula, asegurado, marca, estado);
        }

        public void EliminarVehiculo(int vehiculoId)
        {
            // Llamar al método de la capa de datos
            objectCD.EliminarVehiculo(vehiculoId);
        }


    }
}

