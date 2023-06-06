using CapaDatos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestLogin
{
    [TestClass()]
    public class SesionTests
    {
        // ...

        [TestMethod()]
        public void InicioBaseDeDatos()
        {
            // Preparación
            CD_Connection db_connection = new CD_Connection();
            SqlConnection connection = db_connection.OpenConnection();

            // Evaluación
            Assert.AreEqual(ConnectionState.Open, connection.State);
        }

        [TestMethod()]
        public void Login()
        {
            CD_GetData data = new CD_GetData();
            string username = "testuser";
            string clave = "testpassword";

            // Ejecucion
            string result = data.Set_User_Rol(username, clave);

            // Evaluacion
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Contains("USUARIO:"));
            Assert.IsTrue(result.Contains("ROL:"));

        }



    }
}

