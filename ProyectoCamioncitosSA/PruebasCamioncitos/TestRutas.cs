using CapaDatos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestRutas
{
    [TestClass()]
    public class TestRutas
    {
        [TestMethod]
        public void RegistrarRuta()
        {
            // Preparaci�n
            CD_GetData data = new CD_GetData();
            string origen = "Ciudad A"; // Origen de la ruta
            string destino = "Ciudad B"; // Destino de la ruta
            float distancia = 200.0f; // Distancia de la ruta
            float tiempoEstimado = 3.5f; // Tiempo estimado de la ruta
            string detallesPedido = "Detalles del pedido"; // Detalles del pedido de la ruta
            string estadoEntrega = "Pendiente"; // Estado de entrega de la ruta

            // Ejecuci�n
            data.RegistrarRuta(origen, destino, distancia, tiempoEstimado, detallesPedido, estadoEntrega);

        }


        [TestMethod]
        public void ActualizarRuta()
        {
            // Preparaci�n
            CD_GetData data = new CD_GetData();
            int rutaId = 1; // Proporciona un ID de ruta existente
            string nuevoOrigen = "Ciudad A"; // Nuevo origen para la ruta
            string nuevoDestino = "Ciudad B"; // Nuevo destino para la ruta
            float nuevaDistancia = 200.0f; // Nueva distancia para la ruta
            float nuevoTiempoEstimado = 3.5f; // Nuevo tiempo estimado para la ruta
            string nuevosDetallesPedido = "Detalles actualizados"; // Nuevos detalles de pedido para la ruta
            string nuevoEstadoEntrega = "Entregado"; // Nuevo estado de entrega para la ruta

            // Ejecuci�n
            data.ActualizarRuta(rutaId, nuevoOrigen, nuevoDestino, nuevaDistancia, nuevoTiempoEstimado, nuevosDetallesPedido, nuevoEstadoEntrega);

        } 
        [TestMethod]
        public void EliminarRuta()
        {
            // Preparaci�n
            CD_GetData data = new CD_GetData();
            int rutaId = 1; // Proporciona un ID de ruta existente

            // Ejecuci�n
            data.EliminarRuta(rutaId);

        }
        [TestMethod]
        public void ConsultarRuta()
        {
            // Preparaci�n
            CD_GetData data = new CD_GetData();

            // Ejecuci�n
            DataTable result = data.ConsultarRuta();

            // Verificaci�n
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }



    }
}

