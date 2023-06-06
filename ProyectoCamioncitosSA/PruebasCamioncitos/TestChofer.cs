using CapaDatos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestChofer
{
    [TestClass()]
    public class TestChofer
    {
        [TestMethod()]
        public void RegistrarChofer()
        {
            // Preparación
            CD_GetData data = new CD_GetData();
            string nombres = "John"; // Nombres del chofer: John
            string apellidos = "Doe"; // Apellidos del chofer: Doe
            string genero = "Male"; // Género del chofer: Masculino
            string direccion = "123 Main St"; // Dirección del chofer: 123 Main St
            string numLicencia = "ABC123"; // Número de licencia del chofer: ABC123
            DateTime venceLicencia = DateTime.Now.AddYears(1); // Fecha de vencimiento de la licencia: un año a partir de ahora
            string disponibilidad = "Available"; // Disponibilidad del chofer: Disponible

            // Ejecucucion
            data.RegistrarChofer(nombres, apellidos, genero, direccion, numLicencia, venceLicencia, disponibilidad);
        }

        [TestMethod]
        public void ActualizarChofer()
        {
            // Preparación
            CD_GetData data = new CD_GetData();
            int choferId = 1; // Proporciona un ID de chofer existente
            string nuevosNombres = "Juan"; // Nuevos nombres del chofer
            string nuevosApellidos = "Pérez"; // Nuevos apellidos del chofer
            string nuevoGenero = "Masculino"; // Nuevo género del chofer
            string nuevaDireccion = "Calle Principal"; // Nueva dirección del chofer
            string nuevoNumLicencia = "XYZ123"; // Nuevo número de licencia del chofer
            DateTime nuevaVenceLicencia = DateTime.Now.AddYears(1); // Nueva fecha de vencimiento de la licencia del chofer
            string nuevaDisponibilidad = "No disponible"; // Nueva disponibilidad del chofer

            // Ejecución
            data.ActualizarChofer(choferId, nuevosNombres, nuevosApellidos, nuevoGenero, nuevaDireccion, nuevoNumLicencia, nuevaVenceLicencia, nuevaDisponibilidad);

        }
        [TestMethod]
        public void EliminarChofer()
        {
            // Preparación
            CD_GetData data = new CD_GetData();
            int choferId = 1; // Proporciona un ID de chofer existente

            // Ejecución
            data.EliminarChofer(choferId);

        }
        [TestMethod]
        public void ConsultarChoferes()
        {
            // Preparación
            CD_GetData data = new CD_GetData();

            // (Ejecución
            DataTable result = data.ConsultarChoferes();

            // Verificacións
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);

        }



    }
}

