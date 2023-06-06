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
    public partial class FormVehiculo : Form
    {
        CN_GetData objCapaNegocio = new CapaNegocio.CN_GetData();
        bool bandera = true;
        int id_Vehiculo = 0;
        public FormVehiculo()
        {
            InitializeComponent();
        }

        private void FormVehiculo_Load(object sender, EventArgs e)
        {
            CargarModulo();
            dtgVehiculos.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string tipoVehiculo = cmbTipoVehiculo.Text;
            string marca = txtMarca.Text.Trim();
            string modelo = txtModelo.Text.Trim();
            string placa = txtPlaca.Text.Trim();
            float capacidadCarga = float.Parse(txtCapacidadCarga.Text.Trim());
            string estado;

            if (cmbEstado.SelectedIndex == 0)
            {
                estado = "N";
            }
            else
            {
                estado = "U";
            }


            try
            {
                if (!objCapaNegocio.NoNulos(tipoVehiculo, marca, modelo, placa, txtCapacidadCarga.Text.Trim(), estado))
                {
                    if (!objCapaNegocio.ExisteVehiculo(tipoVehiculo, marca, modelo, placa, capacidadCarga, estado))
                    {
                        if (bandera)
                        {
                            objCapaNegocio.RegistrarVehiculo(tipoVehiculo, marca, modelo, placa, capacidadCarga, estado);
                            MessageBox.Show("Registro creado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                        else
                        {
                            objCapaNegocio.ActualizarVehiculo(id_Vehiculo.ToString(), tipoVehiculo, marca, modelo, placa, capacidadCarga, estado);
                            Limpiar();
                            bandera = true;
                        }
                        CargarModulo();
                    }
                    else
                    {
                        MessageBox.Show("El módulo y objeto ingresados ya existen en la base de datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("Uno o varios de los campos se encuentran vacíos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.GetType().ToString() + Environment.NewLine + "Mensaje: " + ex.Message);
            }
        }

        public void CargarModulo()
        {
            dtgVehiculos.DataSource = objCapaNegocio.ConsultarVehiculo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgVehiculos.SelectedRows.Count > 0)
            {
                //Coloco en los campos del formulario, los valores de la fila del DataGriedView
                int indice = dtgVehiculos.CurrentCell.RowIndex;
                id_Vehiculo = int.Parse(dtgVehiculos.Rows[indice].Cells[0].Value.ToString());

                cmbTipoVehiculo.Text = dtgVehiculos.Rows[indice].Cells[1].Value.ToString();
                txtMarca.Text = dtgVehiculos.Rows[indice].Cells[2].Value.ToString();
                txtModelo.Text = dtgVehiculos.Rows[indice].Cells[3].Value.ToString();
                txtPlaca.Text = dtgVehiculos.Rows[indice].Cells[4].Value.ToString();
                txtCapacidadCarga.Text = (dtgVehiculos.Rows[indice].Cells[5].Value.ToString());
                cmbEstado.Text = dtgVehiculos.Rows[indice].Cells[6].Value.ToString();

                if (cmbEstado.Text == "N")
                {
                    cmbEstado.Text = "N (Nuevo)";
                }
                else
                {
                    cmbEstado.Text = "U (Usado)";
                }
                bandera = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dtgVehiculos.SelectedRows.Count > 0)
            {

                DialogResult dr = MessageBox.Show("¿Está seguro de que desea eliminar este vehiculo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes)
                {
                    objCapaNegocio.EliminarVehiculo(dtgVehiculos.Rows[dtgVehiculos.CurrentCell.RowIndex].Cells[0].Value.ToString());
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
            cmbTipoVehiculo.SelectedIndex = -1;
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtCapacidadCarga.Text = "";
            txtPlaca.Text = "";
            cmbEstado.SelectedIndex = -1;
            btnGuardar.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCapacidadCarga_KeyPress(object sender, KeyPressEventArgs e)
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
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            char c = e.KeyChar;
            if ((Char.IsLetterOrDigit(c) && txtPlaca.Text.Length < 8) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
    }
}
