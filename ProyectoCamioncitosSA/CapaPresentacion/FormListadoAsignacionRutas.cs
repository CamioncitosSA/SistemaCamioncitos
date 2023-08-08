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
    public partial class FormListadoAsignacionRutas : Form
    {
        CN_GetData objCapaNegocio = new CapaNegocio.CN_GetData();

        public FormListadoAsignacionRutas()
        {
            InitializeComponent();
        }

        public void CargarModulo()
        {
            dtgRutasChoferes.DataSource = objCapaNegocio.ConsultarAsignacionesRuta();
        }

        private void FormListadoAsignacionRutas_Load(object sender, EventArgs e)
        {
            CargarModulo();
            dtgRutasChoferes.ClearSelection();
        }
    }
}
