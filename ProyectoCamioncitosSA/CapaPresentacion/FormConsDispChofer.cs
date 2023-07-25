using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormConsDispChofer : Form
    {
        CN_GetData objCapaNegocios = new CN_GetData();

        public FormConsDispChofer()
        {
            InitializeComponent();

        }

        private void FormConsDispChofer_Load(object sender, EventArgs e)
        {
            dtgDisponibilidad.ColumnCount = 1;
            dtgDisponibilidad.Columns[0].Name = "Disponibilidad";
            dtgDisponibilidad.ClearSelection();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int choferId;
            if (!int.TryParse(txtID.Text, out choferId))
            {
                MessageBox.Show("Ingrese un ID de chofer válido.");
                return;
            }

            string disponibilidad = objCapaNegocios.ConsultarDisponibilidadChofer(choferId);

            dtgDisponibilidad.Rows.Clear();
            if (disponibilidad == null)
            {
                MessageBox.Show("No hay choferes disponibles con el ID proporcionado.");
            }
            else
            {
                dtgDisponibilidad.Rows.Add(disponibilidad);
            }
        }
    }
}