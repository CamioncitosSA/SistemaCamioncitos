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
    public partial class FormMenu : Form
    {
        // Variables para almacenar el usuario y la contraseña
        public string usuario = "", clave = "";

        // Instancia de la clase CN_GetData para acceder a los datos de la capa de negocio
        CN_GetData objCapaNegocio = new CN_GetData();

        public FormMenu(string user, string password)
        {
            InitializeComponent();

            // Mostrar el rol de usuario en el formulario del menú
            lblUserRol.Text = objCapaNegocio.CN_Get_User_ROL(user, password);
            usuario = user;
            clave = password;

            panelSubMenuVehiculos.Visible = false;
            panelSubMenuChoferes.Visible = false;
        }

        public FormMenu()
        {
            InitializeComponent();
        }

        // Personalizar el diseño del formulario del menú
        private void customizeDesign()
        {
            panelSubMenuVehiculos.Visible = false;
            panelSubMenuChoferes.Visible = false;
            // ...
        }

        // Ocultar el submenú
        private void hideSubMenu()
        {
            if (panelSubMenuVehiculos.Visible == true)
                panelSubMenuVehiculos.Visible = false;
            if (panelSubMenuChoferes.Visible == true)
                panelSubMenuChoferes.Visible = false;
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

        // Evento Click del botón AtencionMedica
        private void btnAtencionMedica_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuVehiculos);
        }

        // Evento Click del botón Enfermeria
        private void btnEnfermeria_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuChoferes);
        }

        // Evento Click del botón de Admisión
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new FormVehiculo());
            hideSubMenu();
        }

        // Evento Click del botón Cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Variable para almacenar el formulario activo
        private Form activeForm = null;

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
    }
}

