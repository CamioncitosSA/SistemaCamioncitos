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
    public partial class FormAsignacionRutas : Form
    {
        // Instancia de la clase CN_GetData para acceder a los datos de la capa de negocio
        CN_GetData objCapaNegocio = new CN_GetData();
        int id_Asignacion = 0;

        public FormAsignacionRutas()
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

        private void FormAsignacionRutas_Load(object sender, EventArgs e)
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
                    MessageBox.Show("Asignacion creada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un chofer y una ruta disponible", "Error al Asignar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            if (dtgRutasChoferes.SelectedRows.Count > 0)
            {

                DialogResult dr = MessageBox.Show("¿Está seguro de que desea eliminar esta asignacion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes)
                {
                    objCapaNegocio.EliminarAsignacionRuta(dtgRutasChoferes.Rows[dtgRutasChoferes.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    CargarModulo();
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de la tabla de Asignacion de Rutas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        private void dtgRutas_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si hay al menos una fila seleccionada
            if (dtgRutas.SelectedRows.Count > 0)
            {
                // Obtener el valor de la columna 0 de la fila seleccionada
                txtRutaDisponible.Text = dtgRutas.SelectedRows[0].Cells[0].Value.ToString();

            }
        }




    }
}
