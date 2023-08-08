// Formulario del menú principal
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
    public partial class FormMenuGerente : Form
    {
        // Variables para almacenar el usuario y la contraseña
        public string usuario = "", clave = "";

        // Instancia de la clase CN_GetData para acceder a los datos de la capa de negocio
        CN_GetData objCapaNegocio = new CN_GetData();

        public FormMenuGerente(string user, string password)
        {
            InitializeComponent();

            // Mostrar el rol de usuario en el formulario del menú
            lblUserRol.Text = objCapaNegocio.CN_Get_User_ROL(user, password);
            usuario = user;
            clave = password;

            panelSubMenuVehiculos.Visible = false;
            panelSubMenuChoferes.Visible = false;
            panelSubMenuRutas.Visible = false;
            panelSubMenuAsignaciones.Visible = false;
        }

        public FormMenuGerente()
        {
            InitializeComponent();
        }

        // Personalizar el diseño del formulario del menú
        private void customizeDesign()
        {
            panelSubMenuVehiculos.Visible = false;
            panelSubMenuChoferes.Visible = false;
            panelSubMenuRutas.Visible = false;
            panelSubMenuAsignaciones.Visible = false;
            // ...
        }

        // Ocultar el submenú
        private void hideSubMenu()
        {
            if (panelSubMenuVehiculos.Visible == true)
                panelSubMenuVehiculos.Visible = false;
            if (panelSubMenuChoferes.Visible == true)
                panelSubMenuChoferes.Visible = false;
            if (panelSubMenuRutas.Visible == true)
                panelSubMenuRutas.Visible = false;
            if (panelSubMenuAsignaciones.Visible == true)
                panelSubMenuAsignaciones.Visible = false;
        }

        // Mostrar el submenú especificado
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        // Variable para almacenar el formulario activo
        private Form activeForm = null;

        private void btnChoferes_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuChoferes);
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuVehiculos);
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuRutas);
        }

        private void btnAsignaciones_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuAsignaciones);
        }
        private void btnNuevoVehiculo_Click(object sender, EventArgs e)
        {
            openChildForm(new FormVehiculo());
            hideSubMenu();
        }

        private void btnNuevoChofer_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChoferes());
            hideSubMenu();
        }

        private void btnListaChoferes_Click(object sender, EventArgs e)
        {
            openChildForm(new FormListadoChoferes());
            hideSubMenu();
        }

        private void btnListaVehiculos_Click(object sender, EventArgs e)
        {
            openChildForm(new FormListadoVehiculos());
            hideSubMenu();
        }

        private void btnDisponibilidad_Click(object sender, EventArgs e)
        {
            openChildForm(new FormConsDispChofer());
            hideSubMenu();
        }


        // Abrir un formulario secundario dentro del panelChildForm
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRuta());
            hideSubMenu();
        }

        private void btnConsultarRuta_Click(object sender, EventArgs e)
        {
            openChildForm(new FormListadoRutas());
            hideSubMenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formlogin = new FormLogin();
            formlogin.ShowDialog();
            this.Close();

        }

        private void btnListadoRutasChoferes_Click(object sender, EventArgs e)
        {
            openChildForm(new FormListadoAsignacionRutas());
            hideSubMenu();
        }
    }
}

