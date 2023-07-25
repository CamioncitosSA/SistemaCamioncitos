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
    public partial class FormListadoChoferes : Form
    {
        CN_GetData objCapaNegocio = new CapaNegocio.CN_GetData();

        public FormListadoChoferes()
        {
            InitializeComponent();
        }

        private void FormListadoChoferes_Load(object sender, EventArgs e)
        {
            CargarModulo();
            dtgListadoChoferes.ClearSelection();
        }

        public void CargarModulo()
        {
            dtgListadoChoferes.DataSource = objCapaNegocio.ConsultarChoferes();
        }
    }
}
