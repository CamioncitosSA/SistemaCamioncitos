using CapaDatos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestVehiculos
{
    [TestClass()]
    public class TestsVehiculo
    {

        [TestMethod()]
        public void RegistrarVehiculo()
        {
            // Preparaci�n
            CD_GetData data = new CD_GetData();
            string tipoVehiculo = "Car"; // Tipo de veh�culo: autom�vil
            string marcaV = "Toyota"; // Marca del veh�culo: Toyota
            string modeloV = "Camry"; // Modelo del veh�culo: Camry
            string placaV = "ABC123"; // N�mero de placa del veh�culo: ABC123
            float capacidadCarga = 1000.0f; // Capacidad de carga del veh�culo: 1000.0
            string estado = "Active"; // Estado del veh�culo: Activo

            // Ejecuci�n
            data.RegistrarVehiculo(tipoVehiculo, marcaV, modeloV, placaV, capacidadCarga, estado);
            DataTable result = data.ConsultarVehiculo();

            // Verificaci�n
            Assert.IsNotNull(result); // Verificar que el resultado no sea nulo
            Assert.IsTrue(result.Rows.Count > 0); // Verificar que se haya agregado al menos una fila al resultado
                                                  // Agrega afirmaciones adicionales para verificar que el nuevo veh�culo se registr� correctamente
        }

        [TestMethod()]
        public void ActualizarVehiculo()
        {
            // APreparaci�n
            CD_GetData data = new CD_GetData();
            int vehiculoId = 1; // Proporciona un ID de veh�culo existente
            string tipoVehiculo = "Truck"; // Tipo de veh�culo: cami�n
            string marcaV = "Ford"; // Marca del veh�culo: Ford
            string modeloV = "F-150"; // Modelo del veh�culo: F-150
            string placaV = "XYZ789"; // N�mero de placa del veh�culo: XYZ789
            float capacidadCarga = 2000.0f; // Capacidad de carga del veh�culo: 2000.0
            string estado = "Inactive"; // Estado del veh�culo: Inactivo

            // Ejecuci�n
            data.ActualizarVehiculo(vehiculoId, tipoVehiculo, marcaV, modeloV, placaV, capacidadCarga, estado);
            DataTable result = data.ConsultarVehiculo();

            // Verificaci�n
            Assert.IsNotNull(result); // Verificar que el resultado no sea nulo
                                      // Agrega afirmaciones adicionales para verificar que el veh�culo se actualiz� correctamente
        }

        [TestMethod]
        public void EliminarVehiculo()
        {
            // Preparaci�n
            CD_GetData data = new CD_GetData();
            int vehiculoId = 1; // Proporciona un ID de veh�culo existente

            // Ejecuci�n
            data.EliminarVehiculo(vehiculoId);
            DataTable result = data.ConsultarVehiculo();

            // Verificaci�n
            Assert.IsNotNull(result); // Verificar que el resultado no sea nulo
                                      // Agrega afirmaciones adicionales para verificar que el veh�culo se elimin� correctamente
        }

        [TestMethod]
        public void ConsultarVehiculo()
        {
            // Preparaci�n
            CD_GetData data = new CD_GetData();

            // Ejecuci�n
            DataTable result = data.ConsultarVehiculo();

            // Verificaci�n
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);

        }

    }
}

