using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormListadoVehiculos : Form
    {
        CN_GetData objCapaNegocio = new CapaNegocio.CN_GetData();

        public FormListadoVehiculos()
        {
            InitializeComponent();
        }

        private void FormListadoVehiculos_Load(object sender, EventArgs e)
        {
            CargarModulo();
            dtgListadoVehiculos.ClearSelection();
        }

        public void CargarModulo()
        {
            dtgListadoVehiculos.DataSource = objCapaNegocio.ConsultarVehiculo();
        }
    }
}
