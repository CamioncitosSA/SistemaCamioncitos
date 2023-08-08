namespace CapaPresentacion
{
    partial class FormMenuSecretaria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSideMenu = new Panel();
            panelSubMenuAsignaciones = new Panel();
            btnRutaChofer = new Button();
            btnAsignaciones = new Button();
            panelSubMenuRutas = new Panel();
            btnConsultarRuta = new Button();
            btnAgregarRuta = new Button();
            btnRutas = new Button();
            panelSubMenuChoferes = new Panel();
            btnDisponibilidad = new Button();
            btnListaChoferes = new Button();
            btnNuevoChofer = new Button();
            btnChoferes = new Button();
            panelSubMenuVehiculos = new Panel();
            btnListaVehiculos = new Button();
            btnNuevoVehiculo = new Button();
            btnVehiculos = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            lblUserRol = new Label();
            panel1 = new Panel();
            btnLogout = new PictureBox();
            label1 = new Label();
            panelChildForm = new Panel();
            pictureBox2 = new PictureBox();
            panelSideMenu.SuspendLayout();
            panelSubMenuAsignaciones.SuspendLayout();
            panelSubMenuRutas.SuspendLayout();
            panelSubMenuChoferes.SuspendLayout();
            panelSubMenuVehiculos.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnLogout).BeginInit();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(68, 67, 110);
            panelSideMenu.Controls.Add(panelSubMenuAsignaciones);
            panelSideMenu.Controls.Add(btnAsignaciones);
            panelSideMenu.Controls.Add(panelSubMenuRutas);
            panelSideMenu.Controls.Add(btnRutas);
            panelSideMenu.Controls.Add(panelSubMenuChoferes);
            panelSideMenu.Controls.Add(btnChoferes);
            panelSideMenu.Controls.Add(panelSubMenuVehiculos);
            panelSideMenu.Controls.Add(btnVehiculos);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(240, 547);
            panelSideMenu.TabIndex = 0;
            // 
            // panelSubMenuAsignaciones
            // 
            panelSubMenuAsignaciones.BackColor = Color.Silver;
            panelSubMenuAsignaciones.Controls.Add(btnRutaChofer);
            panelSubMenuAsignaciones.Dock = DockStyle.Top;
            panelSubMenuAsignaciones.Location = new Point(0, 574);
            panelSubMenuAsignaciones.Name = "panelSubMenuAsignaciones";
            panelSubMenuAsignaciones.Size = new Size(223, 36);
            panelSubMenuAsignaciones.TabIndex = 8;
            // 
            // btnRutaChofer
            // 
            btnRutaChofer.BackColor = Color.FromArgb(235, 231, 211);
            btnRutaChofer.Dock = DockStyle.Top;
            btnRutaChofer.FlatAppearance.BorderSize = 0;
            btnRutaChofer.FlatStyle = FlatStyle.Flat;
            btnRutaChofer.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRutaChofer.Location = new Point(0, 0);
            btnRutaChofer.Name = "btnRutaChofer";
            btnRutaChofer.Padding = new Padding(35, 0, 0, 0);
            btnRutaChofer.Size = new Size(223, 40);
            btnRutaChofer.TabIndex = 8;
            btnRutaChofer.Text = "Rutas/Choferes";
            btnRutaChofer.TextAlign = ContentAlignment.MiddleLeft;
            btnRutaChofer.UseVisualStyleBackColor = false;
            btnRutaChofer.Click += btnRutaChofer_Click;
            // 
            // btnAsignaciones
            // 
            btnAsignaciones.BackColor = Color.FromArgb(68, 67, 110);
            btnAsignaciones.Dock = DockStyle.Top;
            btnAsignaciones.FlatAppearance.BorderSize = 0;
            btnAsignaciones.FlatStyle = FlatStyle.Flat;
            btnAsignaciones.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAsignaciones.ForeColor = Color.White;
            btnAsignaciones.Location = new Point(0, 529);
            btnAsignaciones.Name = "btnAsignaciones";
            btnAsignaciones.Padding = new Padding(10, 0, 0, 0);
            btnAsignaciones.Size = new Size(223, 45);
            btnAsignaciones.TabIndex = 7;
            btnAsignaciones.Text = "Asignaciones";
            btnAsignaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnAsignaciones.UseVisualStyleBackColor = false;
            btnAsignaciones.Click += btnAsignaciones_Click;
            // 
            // panelSubMenuRutas
            // 
            panelSubMenuRutas.BackColor = Color.Silver;
            panelSubMenuRutas.Controls.Add(btnConsultarRuta);
            panelSubMenuRutas.Controls.Add(btnAgregarRuta);
            panelSubMenuRutas.Dock = DockStyle.Top;
            panelSubMenuRutas.Location = new Point(0, 449);
            panelSubMenuRutas.Name = "panelSubMenuRutas";
            panelSubMenuRutas.Size = new Size(223, 80);
            panelSubMenuRutas.TabIndex = 6;
            // 
            // btnConsultarRuta
            // 
            btnConsultarRuta.BackColor = Color.FromArgb(235, 231, 211);
            btnConsultarRuta.Dock = DockStyle.Top;
            btnConsultarRuta.FlatAppearance.BorderSize = 0;
            btnConsultarRuta.FlatStyle = FlatStyle.Flat;
            btnConsultarRuta.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultarRuta.Location = new Point(0, 40);
            btnConsultarRuta.Name = "btnConsultarRuta";
            btnConsultarRuta.Padding = new Padding(35, 0, 0, 0);
            btnConsultarRuta.Size = new Size(223, 40);
            btnConsultarRuta.TabIndex = 9;
            btnConsultarRuta.Text = "Listado de Rutas";
            btnConsultarRuta.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultarRuta.UseVisualStyleBackColor = false;
            btnConsultarRuta.Click += btnConsultarRuta_Click;
            // 
            // btnAgregarRuta
            // 
            btnAgregarRuta.BackColor = Color.FromArgb(235, 231, 211);
            btnAgregarRuta.Dock = DockStyle.Top;
            btnAgregarRuta.FlatAppearance.BorderSize = 0;
            btnAgregarRuta.FlatStyle = FlatStyle.Flat;
            btnAgregarRuta.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarRuta.Location = new Point(0, 0);
            btnAgregarRuta.Name = "btnAgregarRuta";
            btnAgregarRuta.Padding = new Padding(35, 0, 0, 0);
            btnAgregarRuta.Size = new Size(223, 40);
            btnAgregarRuta.TabIndex = 8;
            btnAgregarRuta.Text = "Agregar Ruta";
            btnAgregarRuta.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregarRuta.UseVisualStyleBackColor = false;
            btnAgregarRuta.Click += btnAgregarRuta_Click;
            // 
            // btnRutas
            // 
            btnRutas.BackColor = Color.FromArgb(68, 67, 110);
            btnRutas.Dock = DockStyle.Top;
            btnRutas.FlatAppearance.BorderSize = 0;
            btnRutas.FlatStyle = FlatStyle.Flat;
            btnRutas.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRutas.ForeColor = Color.White;
            btnRutas.Location = new Point(0, 404);
            btnRutas.Name = "btnRutas";
            btnRutas.Padding = new Padding(10, 0, 0, 0);
            btnRutas.Size = new Size(223, 45);
            btnRutas.TabIndex = 5;
            btnRutas.Text = "Rutas";
            btnRutas.TextAlign = ContentAlignment.MiddleLeft;
            btnRutas.UseVisualStyleBackColor = false;
            btnRutas.Click += btnRutas_Click;
            // 
            // panelSubMenuChoferes
            // 
            panelSubMenuChoferes.BackColor = Color.Silver;
            panelSubMenuChoferes.Controls.Add(btnDisponibilidad);
            panelSubMenuChoferes.Controls.Add(btnListaChoferes);
            panelSubMenuChoferes.Controls.Add(btnNuevoChofer);
            panelSubMenuChoferes.Dock = DockStyle.Top;
            panelSubMenuChoferes.Location = new Point(0, 277);
            panelSubMenuChoferes.Name = "panelSubMenuChoferes";
            panelSubMenuChoferes.Size = new Size(223, 127);
            panelSubMenuChoferes.TabIndex = 4;
            // 
            // btnDisponibilidad
            // 
            btnDisponibilidad.BackColor = Color.FromArgb(235, 231, 211);
            btnDisponibilidad.Dock = DockStyle.Top;
            btnDisponibilidad.FlatAppearance.BorderSize = 0;
            btnDisponibilidad.FlatStyle = FlatStyle.Flat;
            btnDisponibilidad.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDisponibilidad.Location = new Point(0, 80);
            btnDisponibilidad.Name = "btnDisponibilidad";
            btnDisponibilidad.Padding = new Padding(35, 0, 0, 0);
            btnDisponibilidad.Size = new Size(223, 45);
            btnDisponibilidad.TabIndex = 2;
            btnDisponibilidad.Text = "Consultar Disponibilidad";
            btnDisponibilidad.TextAlign = ContentAlignment.MiddleLeft;
            btnDisponibilidad.UseVisualStyleBackColor = false;
            btnDisponibilidad.Click += btnDisponibilidad_Click;
            // 
            // btnListaChoferes
            // 
            btnListaChoferes.BackColor = Color.FromArgb(235, 231, 211);
            btnListaChoferes.Dock = DockStyle.Top;
            btnListaChoferes.FlatAppearance.BorderSize = 0;
            btnListaChoferes.FlatStyle = FlatStyle.Flat;
            btnListaChoferes.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnListaChoferes.Location = new Point(0, 40);
            btnListaChoferes.Name = "btnListaChoferes";
            btnListaChoferes.Padding = new Padding(35, 0, 0, 0);
            btnListaChoferes.Size = new Size(223, 40);
            btnListaChoferes.TabIndex = 1;
            btnListaChoferes.Text = "Lista de Choferes";
            btnListaChoferes.TextAlign = ContentAlignment.MiddleLeft;
            btnListaChoferes.UseVisualStyleBackColor = false;
            btnListaChoferes.Click += btnListaChoferes_Click;
            // 
            // btnNuevoChofer
            // 
            btnNuevoChofer.BackColor = Color.FromArgb(235, 231, 211);
            btnNuevoChofer.Dock = DockStyle.Top;
            btnNuevoChofer.FlatAppearance.BorderSize = 0;
            btnNuevoChofer.FlatStyle = FlatStyle.Flat;
            btnNuevoChofer.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoChofer.Location = new Point(0, 0);
            btnNuevoChofer.Name = "btnNuevoChofer";
            btnNuevoChofer.Padding = new Padding(35, 0, 0, 0);
            btnNuevoChofer.Size = new Size(223, 40);
            btnNuevoChofer.TabIndex = 0;
            btnNuevoChofer.Text = "Nuevo Chofer";
            btnNuevoChofer.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevoChofer.UseVisualStyleBackColor = false;
            btnNuevoChofer.Click += btnNuevoChofer_Click;
            // 
            // btnChoferes
            // 
            btnChoferes.BackColor = Color.FromArgb(68, 67, 110);
            btnChoferes.Dock = DockStyle.Top;
            btnChoferes.FlatAppearance.BorderSize = 0;
            btnChoferes.FlatStyle = FlatStyle.Flat;
            btnChoferes.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnChoferes.ForeColor = Color.White;
            btnChoferes.Location = new Point(0, 232);
            btnChoferes.Name = "btnChoferes";
            btnChoferes.Padding = new Padding(10, 0, 0, 0);
            btnChoferes.Size = new Size(223, 45);
            btnChoferes.TabIndex = 3;
            btnChoferes.Text = "Choferes";
            btnChoferes.TextAlign = ContentAlignment.MiddleLeft;
            btnChoferes.UseVisualStyleBackColor = false;
            btnChoferes.Click += btnChoferes_Click_1;
            // 
            // panelSubMenuVehiculos
            // 
            panelSubMenuVehiculos.BackColor = Color.Silver;
            panelSubMenuVehiculos.Controls.Add(btnListaVehiculos);
            panelSubMenuVehiculos.Controls.Add(btnNuevoVehiculo);
            panelSubMenuVehiculos.Dock = DockStyle.Top;
            panelSubMenuVehiculos.Location = new Point(0, 145);
            panelSubMenuVehiculos.Name = "panelSubMenuVehiculos";
            panelSubMenuVehiculos.Size = new Size(223, 87);
            panelSubMenuVehiculos.TabIndex = 2;
            // 
            // btnListaVehiculos
            // 
            btnListaVehiculos.BackColor = Color.FromArgb(235, 231, 211);
            btnListaVehiculos.Dock = DockStyle.Top;
            btnListaVehiculos.FlatAppearance.BorderSize = 0;
            btnListaVehiculos.FlatStyle = FlatStyle.Flat;
            btnListaVehiculos.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnListaVehiculos.Location = new Point(0, 40);
            btnListaVehiculos.Name = "btnListaVehiculos";
            btnListaVehiculos.Padding = new Padding(35, 0, 0, 0);
            btnListaVehiculos.Size = new Size(223, 46);
            btnListaVehiculos.TabIndex = 2;
            btnListaVehiculos.Text = "Lista de Vehiculos";
            btnListaVehiculos.TextAlign = ContentAlignment.MiddleLeft;
            btnListaVehiculos.UseVisualStyleBackColor = false;
            btnListaVehiculos.Click += btnListaVehiculos_Click;
            // 
            // btnNuevoVehiculo
            // 
            btnNuevoVehiculo.BackColor = Color.FromArgb(235, 231, 211);
            btnNuevoVehiculo.Dock = DockStyle.Top;
            btnNuevoVehiculo.FlatAppearance.BorderSize = 0;
            btnNuevoVehiculo.FlatStyle = FlatStyle.Flat;
            btnNuevoVehiculo.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoVehiculo.Location = new Point(0, 0);
            btnNuevoVehiculo.Name = "btnNuevoVehiculo";
            btnNuevoVehiculo.Padding = new Padding(35, 0, 0, 0);
            btnNuevoVehiculo.Size = new Size(223, 40);
            btnNuevoVehiculo.TabIndex = 0;
            btnNuevoVehiculo.Text = "Nuevo Vehiculo";
            btnNuevoVehiculo.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevoVehiculo.UseVisualStyleBackColor = false;
            btnNuevoVehiculo.Click += btnNuevoVehiculo_Click;
            // 
            // btnVehiculos
            // 
            btnVehiculos.BackColor = Color.FromArgb(68, 67, 110);
            btnVehiculos.Dock = DockStyle.Top;
            btnVehiculos.FlatAppearance.BorderSize = 0;
            btnVehiculos.FlatStyle = FlatStyle.Flat;
            btnVehiculos.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVehiculos.ForeColor = Color.White;
            btnVehiculos.Location = new Point(0, 100);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Padding = new Padding(10, 0, 0, 0);
            btnVehiculos.Size = new Size(223, 45);
            btnVehiculos.TabIndex = 1;
            btnVehiculos.Text = "Vehiculos";
            btnVehiculos.TextAlign = ContentAlignment.MiddleLeft;
            btnVehiculos.UseVisualStyleBackColor = false;
            btnVehiculos.Click += btnVehiculos_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Thistle;
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(223, 100);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logocamion;
            pictureBox1.Location = new Point(69, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblUserRol
            // 
            lblUserRol.AutoSize = true;
            lblUserRol.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserRol.Location = new Point(404, 9);
            lblUserRol.Name = "lblUserRol";
            lblUserRol.Size = new Size(41, 17);
            lblUserRol.TabIndex = 1;
            lblUserRol.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(206, 135, 237);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblUserRol);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(240, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(766, 41);
            panel1.TabIndex = 3;
            // 
            // btnLogout
            // 
            btnLogout.Image = Properties.Resources.logout;
            btnLogout.Location = new Point(701, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(42, 41);
            btnLogout.SizeMode = PictureBoxSizeMode.CenterImage;
            btnLogout.TabIndex = 1;
            btnLogout.TabStop = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 9);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 2;
            label1.Text = "CAMIONCITOS S.A.";
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(224, 224, 224);
            panelChildForm.Controls.Add(pictureBox2);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(240, 41);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(766, 506);
            panelChildForm.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.logocamion;
            pictureBox2.Location = new Point(250, 104);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(272, 271);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // FormMenuSecretaria
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 547);
            Controls.Add(panelChildForm);
            Controls.Add(panel1);
            Controls.Add(panelSideMenu);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(1022, 586);
            Name = "FormMenuSecretaria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenuSecretaria";
            panelSideMenu.ResumeLayout(false);
            panelSubMenuAsignaciones.ResumeLayout(false);
            panelSubMenuRutas.ResumeLayout(false);
            panelSubMenuChoferes.ResumeLayout(false);
            panelSubMenuVehiculos.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnLogout).EndInit();
            panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Label lblUserRol;
        private Panel panelSubMenuChoferes;
        private Button btnDisponibilidad;
        private Button btnListaChoferes;
        private Button btnNuevoChofer;
        private Button btnChoferes;
        private Panel panelSubMenuVehiculos;
        private Button btnNuevoVehiculo;
        private Button btnVehiculos;
        private Panel panel1;
        private Panel panelChildForm;
        private PictureBox pictureBox2;
        private Button btnListaVehiculos;
        private Button btnRutas;
        private Panel panelSubMenuRutas;
        private Button btnAgregarRuta;
        private Button btnConsultarRuta;
        private Label label1;
        private PictureBox btnLogout;
        private Panel panelSubMenuAsignaciones;
        private Button btnRutaChofer;
        private Button btnAsignaciones;
    }
}