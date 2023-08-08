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
    public partial class FormRuta : Form
    {

        // Instancia de la clase CN_GetData para acceder a los datos de la capa de negocio
        CN_GetData objCapaNegocio = new CN_GetData();
        bool bandera = true;
        int id_Ruta = 0;

        public FormRuta()
        {
            InitializeComponent();
        }

        public void CargarModulo()
        {
            dtgRutas.DataSource = objCapaNegocio.ConsultarRuta();
        }

        private void LimpiarCampos()
        {
            txtOrigen.Text = string.Empty;
            txtDestino.Text = string.Empty;
            txtDistanciaRecorrida.Text = string.Empty;
            txtTiempoEstimado.Text = string.Empty;
            txtDetallesPedido.Text = string.Empty;
            cmbEstadoEntrega.SelectedIndex = -1;  // Reinicia la selección del ComboBox
        }

        private void FormRuta_Load(object sender, EventArgs e)
        {
            CargarModulo();
            dtgRutas.ClearSelection();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de entrada
            string origen = txtOrigen.Text;
            string destino = txtDestino.Text;
            float distanciaRecorrida = float.Parse(txtDistanciaRecorrida.Text);
            float tiempoEstimado = float.Parse(txtTiempoEstimado.Text);
            string detallesPedido = txtDetallesPedido.Text;
            string estadoEntrega = cmbEstadoEntrega.Text;

            try
            {
                if (objCapaNegocio.NoNulosRutas(origen, destino, txtDistanciaRecorrida.Text, txtTiempoEstimado.Text, detallesPedido, estadoEntrega))
                {

                    if (bandera)
                    {
                        objCapaNegocio.RegistrarRuta(origen, destino, distanciaRecorrida, tiempoEstimado, detallesPedido, estadoEntrega);
                        MessageBox.Show("Registro creado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        objCapaNegocio.ActualizarRuta(id_Ruta.ToString(), origen, destino, distanciaRecorrida, tiempoEstimado, detallesPedido, estadoEntrega);
                    }
                }
                else
                {
                    MessageBox.Show("Uno o varios de los campos se encuentran vacíos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                LimpiarCampos();
                bandera = true;
                CargarModulo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.GetType().ToString() + Environment.NewLine + "Mensaje: " + ex.Message);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (dtgRutas.SelectedRows.Count > 0)
            {
                int indice = dtgRutas.CurrentCell.RowIndex;
                id_Ruta = int.Parse(dtgRutas.Rows[indice].Cells[0].Value.ToString());

                txtOrigen.Text = dtgRutas.Rows[indice].Cells[1].Value.ToString();
                txtDestino.Text = dtgRutas.Rows[indice].Cells[2].Value.ToString();
                txtDistanciaRecorrida.Text = (dtgRutas.Rows[indice].Cells[3].Value.ToString());
                txtTiempoEstimado.Text = (dtgRutas.Rows[indice].Cells[4].Value.ToString());
                txtDetallesPedido.Text = dtgRutas.Rows[indice].Cells[5].Value.ToString();
                cmbEstadoEntrega.Text = dtgRutas.Rows[indice].Cells[6].Value.ToString();

                bandera = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dtgRutas.SelectedRows.Count > 0)
            {

                DialogResult dr = MessageBox.Show("¿Está seguro de que desea eliminar esta ruta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes)
                {
                    objCapaNegocio.EliminarRuta(dtgRutas.Rows[dtgRutas.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    CargarModulo();
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }



    }
}
