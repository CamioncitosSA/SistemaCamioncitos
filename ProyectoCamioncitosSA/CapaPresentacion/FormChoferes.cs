using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class FormChoferes : Form
    {
        CN_GetData objCapaNegocio = new CapaNegocio.CN_GetData();
        bool bandera = true;
        int id_Chofer = 0;

        public FormChoferes()
        {
            InitializeComponent();
        }

        private void FormChoferes_Load(object sender, EventArgs e)
        {
            CargarModulo();
            dtgChoferes.ClearSelection();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string genero = cmbGenero.SelectedIndex == 0 ? "F" : "M";
            string direccion = txtDireccion.Text.Trim();
            string numLicencia = txtNLicencia.Text.Trim();
            DateTime venceLicencia = dtpVencimiento.Value;
            string disponibilidad = cmbDisponibilidad.SelectedIndex == 0 ? "D" : "N"; //cambie esto para guardar con literales en vez de la palabra

            try
            {
                if (objCapaNegocio.NoNulosChofer(nombres, apellidos, genero, direccion, numLicencia, venceLicencia, disponibilidad))
                {

                    if (bandera)
                    {
                        objCapaNegocio.RegistrarChofer(nombres, apellidos, genero, direccion, numLicencia, venceLicencia, disponibilidad);
                        MessageBox.Show("Registro creado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        objCapaNegocio.ActualizarChofer(id_Chofer.ToString(), nombres, apellidos, genero, direccion, numLicencia, venceLicencia, disponibilidad);
                    }
                }
                else
                {
                    MessageBox.Show("Uno o varios de los campos se encuentran vacíos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                Limpiar();
                bandera = true;
                CargarModulo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.GetType().ToString() + Environment.NewLine + "Mensaje: " + ex.Message);
            }
        }



        public void CargarModulo()
        {
            dtgChoferes.DataSource = objCapaNegocio.ConsultarChoferes();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (dtgChoferes.SelectedRows.Count > 0)
            {
                if (dtgChoferes.SelectedRows.Count > 0)
                {
                    int indice = dtgChoferes.CurrentCell.RowIndex;
                    id_Chofer = int.Parse(dtgChoferes.Rows[indice].Cells[0].Value.ToString());
                    txtNombres.Text = dtgChoferes.Rows[indice].Cells[1].Value.ToString();
                    txtApellidos.Text = dtgChoferes.Rows[indice].Cells[2].Value.ToString();
                    cmbGenero.SelectedIndex = GetGeneroIndexFromCellValue(dtgChoferes.Rows[indice].Cells[3].Value.ToString());
                    txtDireccion.Text = dtgChoferes.Rows[indice].Cells[4].Value.ToString();
                    txtNLicencia.Text = dtgChoferes.Rows[indice].Cells[5].Value.ToString();
                    dtpVencimiento.Value = Convert.ToDateTime(dtgChoferes.Rows[indice].Cells[6].Value);
                    cmbDisponibilidad.SelectedIndex = GetDisponibilidadIndexFromCellValue(dtgChoferes.Rows[indice].Cells[7].Value.ToString());

                    bandera = false;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private int GetGeneroIndexFromCellValue(string cellValue)
        {
            return cellValue == "F" ? 0 : 1;
        }

        private int GetDisponibilidadIndexFromCellValue(string cellValue)
        {
            if (cellValue == "D")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgChoferes.SelectedRows.Count > 0)
            {

                DialogResult dr = MessageBox.Show("¿Está seguro de que desea eliminar a este chofer?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes)
                {
                    objCapaNegocio.EliminarChofer(dtgChoferes.Rows[dtgChoferes.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    CargarModulo();
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        public void Limpiar()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            cmbGenero.SelectedIndex = -1;
            txtDireccion.Text = "";
            txtNLicencia.Text = "";
            dtpVencimiento.Text = "";
            cmbDisponibilidad.SelectedIndex = -1;
            btnGuardar.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsLetter(c) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsLetter(c) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsLetterOrDigit(c) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNLicencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsDigit(c) || c == '.' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (txtNLicencia.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
