// Formulario de inicio de sesión
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
    public partial class FormLogin : Form
    {
        // Se instancia la clase CN_GetData para acceder a los datos de la capa de negocio
        CN_GetData objCapaNegocio = new CN_GetData();

        public FormLogin()
        {
            InitializeComponent();
        }

        // Evento Enter del campo de texto Usuario
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        // Evento Leave del campo de texto Usuario
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        // Evento Enter del campo de texto Contraseña
        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Contraseña")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        // Evento Leave del campo de texto Contraseña
        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "Contraseña";
                txtContrasena.ForeColor = Color.FromArgb(64, 64, 64);
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        // Evento KeyPress del campo de texto Usuario
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (Char.IsLetter(c) && txtUsuario.Text.Length <= 14)
            {
                e.Handled = false;
            }
            else if (c == (char)Keys.Back || c == (char)Keys.LShiftKey || c == (char)Keys.RShiftKey || c == '_')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (txtUsuario.Text.Length > 14 && c != ((char)Keys.Back))
            {
                // Mostrar mensaje de validación cuando se supera la longitud máxima permitida
                MessageBox.Show("Solo se pueden ingresar 14 caracteres", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Evento KeyPress del campo de texto Contraseña
        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back && txtContrasena.Text.Length <= 15)
            {
                e.Handled = false;
            }

            if (txtContrasena.Text.Length > 15 && e.KeyChar != ((char)Keys.Back))
            {
                // Mostrar mensaje de validación cuando se supera la longitud máxima permitida
                MessageBox.Show("La contraseña solo puede contener 15 caracteres", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Evento Click del botón Iniciar Sesión

        //private void btnIniciarSesion_Click(object sender, EventArgs e)
        //{
        //    if (objCapaNegocio.Set_Login(txtUsuario.Text, txtContrasena.Text))
        //    {
        //        // Ocultar el formulario de inicio de sesión y mostrar el formulario del menú principal
        //        this.Hide();
        //        FormMenu form1 = new FormMenu(txtUsuario.Text, txtContrasena.Text);
        //        form1.ShowDialog();
        //        this.Close();
        //    }
        //}


        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (objCapaNegocio.Set_Login(txtUsuario.Text, txtContrasena.Text))
            {
                // Obtener el rol del usuario después de validar el inicio de sesión
                string rolUsuario = objCapaNegocio.CN_Obtener_Rol(txtUsuario.Text, txtContrasena.Text);

                // Ocultar el formulario de inicio de sesión
                this.Hide();

                // Mostrar el formulario específico de acuerdo al rol del usuario
                if (rolUsuario == "ADMINISTRADOR")
                {
                    FormMenu formAdmin = new FormMenu(txtUsuario.Text, txtContrasena.Text);
                    formAdmin.ShowDialog();
                }
                else if (rolUsuario == "SECRETARIA")
                {
                    FormMenuSecretaria formSecretaria = new FormMenuSecretaria(txtUsuario.Text, txtContrasena.Text);
                    formSecretaria.ShowDialog();
                }
                else if (rolUsuario == "GERENTE")
                {
                    FormMenuGerente formGerente = new FormMenuGerente(txtUsuario.Text, txtContrasena.Text);
                    formGerente.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sigue el error Madge por: "+rolUsuario+".", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                // Cerrar el formulario de inicio de sesión
                this.Close();
            }
        }



    }
}
