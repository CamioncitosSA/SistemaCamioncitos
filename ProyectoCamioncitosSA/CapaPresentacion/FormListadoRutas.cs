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
    public partial class FormListadoRutas : Form
    {
        CN_GetData objCapaNegocio = new CapaNegocio.CN_GetData();
        public FormListadoRutas()
        {
            InitializeComponent();
        }

        private void FormListadoRutas_Load(object sender, EventArgs e)
        {
            CargarModulo();
            dtgListadoRutas.ClearSelection();
        }

        public void CargarModulo()
        {
            dtgListadoRutas.DataSource = objCapaNegocio.ConsultarRuta();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string destino = txtFiltroDestino.Text.Trim();

            // Verificar si el valor ingresado es válido (no está vacío)
            if (!string.IsNullOrEmpty(destino))
            {
                // Llama al método de la capa de negocio para buscar por destino
                DataTable resultado = objCapaNegocio.BuscarRutaPorDestino(destino);
                dtgListadoRutas.DataSource = resultado;
            }
            else
            {
                MessageBox.Show("Ingrese un destino válido para la búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFiltroDestino.Text = string.Empty;
            CargarModulo();
        }
    }
}
