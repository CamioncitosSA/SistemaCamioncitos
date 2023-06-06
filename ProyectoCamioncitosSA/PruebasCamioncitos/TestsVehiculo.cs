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
            // Preparación
            CD_GetData data = new CD_GetData();
            string tipoVehiculo = "Car"; // Tipo de vehículo: automóvil
            string marcaV = "Toyota"; // Marca del vehículo: Toyota
            string modeloV = "Camry"; // Modelo del vehículo: Camry
            string placaV = "ABC123"; // Número de placa del vehículo: ABC123
            float capacidadCarga = 1000.0f; // Capacidad de carga del vehículo: 1000.0
            string estado = "Active"; // Estado del vehículo: Activo

            // Ejecución
            data.RegistrarVehiculo(tipoVehiculo, marcaV, modeloV, placaV, capacidadCarga, estado);
            DataTable result = data.ConsultarVehiculo();

            // Verificación
            Assert.IsNotNull(result); // Verificar que el resultado no sea nulo
            Assert.IsTrue(result.Rows.Count > 0); // Verificar que se haya agregado al menos una fila al resultado
                                                  // Agrega afirmaciones adicionales para verificar que el nuevo vehículo se registró correctamente
        }

        [TestMethod()]
        public void ActualizarVehiculo()
        {
            // APreparación
            CD_GetData data = new CD_GetData();
            int vehiculoId = 1; // Proporciona un ID de vehículo existente
            string tipoVehiculo = "Truck"; // Tipo de vehículo: camión
            string marcaV = "Ford"; // Marca del vehículo: Ford
            string modeloV = "F-150"; // Modelo del vehículo: F-150
            string placaV = "XYZ789"; // Número de placa del vehículo: XYZ789
            float capacidadCarga = 2000.0f; // Capacidad de carga del vehículo: 2000.0
            string estado = "Inactive"; // Estado del vehículo: Inactivo

            // Ejecución
            data.ActualizarVehiculo(vehiculoId, tipoVehiculo, marcaV, modeloV, placaV, capacidadCarga, estado);
            DataTable result = data.ConsultarVehiculo();

            // Verificación
            Assert.IsNotNull(result); // Verificar que el resultado no sea nulo
                                      // Agrega afirmaciones adicionales para verificar que el vehículo se actualizó correctamente
        }

        [TestMethod]
        public void EliminarVehiculo()
        {
            // Preparación
            CD_GetData data = new CD_GetData();
            int vehiculoId = 1; // Proporciona un ID de vehículo existente

            // Ejecución
            data.EliminarVehiculo(vehiculoId);
            DataTable result = data.ConsultarVehiculo();

            // Verificación
            Assert.IsNotNull(result); // Verificar que el resultado no sea nulo
                                      // Agrega afirmaciones adicionales para verificar que el vehículo se eliminó correctamente
        }

        [TestMethod]
        public void ConsultarVehiculo()
        {
            // Preparación
            CD_GetData data = new CD_GetData();

            // Ejecución
            DataTable result = data.ConsultarVehiculo();

            // Verificación
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);

        }

    }
}

