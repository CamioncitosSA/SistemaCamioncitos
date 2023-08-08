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
    public partial class FormAsignacionRutasVer2 : Form
    {
        // Instancia de la clase CN_GetData para acceder a los datos de la capa de negocio
        CN_GetData objCapaNegocio = new CN_GetData();
        int id_Asignacion = 0;

        public FormAsignacionRutasVer2()
        {
            InitializeComponent();
        }

        public void CargarModulo()
        {
            dtgRutasChoferes.DataSource = objCapaNegocio.ConsultarAsignacionesRuta();
            dtgChoferes.DataSource = objCapaNegocio.ObtenerChoferesDisponibles();
            dtgRutas.DataSource = objCapaNegocio.ObtenerRutasPendientes();
        }

        private void LimpiarCampos()
        {
            txtChoferDisponible.Text = string.Empty;
            txtRutaDisponible.Text = string.Empty;

        }

        private void FormAsignacionRutasVer2_Load(object sender, EventArgs e)
        {
            CargarModulo();
            dtgRutasChoferes.ClearSelection();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

            // Obtener los valores de los campos de entrada
            int choferDisponible = int.Parse(txtChoferDisponible.Text);
            int rutaDisponible = int.Parse(txtRutaDisponible.Text);

            try
            {
                if (objCapaNegocio.NoNulosAsignaciones(txtChoferDisponible.Text, txtRutaDisponible.Text))
                {
                    objCapaNegocio.RegistrarAsignacionRuta(choferDisponible, rutaDisponible);
                    MessageBox.Show("Registro creado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uno o varios de los campos se encuentran vacíos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                LimpiarCampos();
                CargarModulo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.GetType().ToString() + Environment.NewLine + "Mensaje: " + ex.Message);
            }

        }

        private void btnDesasignar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            //
        }

        private void dtgChoferes_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si hay al menos una fila seleccionada
            if (dtgChoferes.SelectedRows.Count > 0)
            {
                // Obtener el valor de la columna 0 de la fila seleccionada
                txtChoferDisponible.Text = dtgChoferes.SelectedRows[0].Cells[0].Value.ToString();

            }
        }
    }
}
