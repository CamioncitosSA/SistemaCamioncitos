namespace CapaPresentacion
{
    partial class FormMenu
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelSubMenuChoferes = new System.Windows.Forms.Panel();
            this.btnDisponibilidad = new System.Windows.Forms.Button();
            this.btnListaChoferes = new System.Windows.Forms.Button();
            this.btnNuevoChofer = new System.Windows.Forms.Button();
            this.btnChoferes = new System.Windows.Forms.Button();
            this.panelSubMenuVehiculos = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnNuevoVehiculo = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserRol = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelSubMenuChoferes.SuspendLayout();
            this.panelSubMenuVehiculos.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(86)))), ((int)(((byte)(149)))));
            this.panelSideMenu.Controls.Add(this.panelSubMenuChoferes);
            this.panelSideMenu.Controls.Add(this.btnChoferes);
            this.panelSideMenu.Controls.Add(this.panelSubMenuVehiculos);
            this.panelSideMenu.Controls.Add(this.btnVehiculos);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(240, 547);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelSubMenuChoferes
            // 
            this.panelSubMenuChoferes.BackColor = System.Drawing.Color.Silver;
            this.panelSubMenuChoferes.Controls.Add(this.btnDisponibilidad);
            this.panelSubMenuChoferes.Controls.Add(this.btnListaChoferes);
            this.panelSubMenuChoferes.Controls.Add(this.btnNuevoChofer);
            this.panelSubMenuChoferes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuChoferes.Location = new System.Drawing.Point(0, 277);
            this.panelSubMenuChoferes.Name = "panelSubMenuChoferes";
            this.panelSubMenuChoferes.Size = new System.Drawing.Size(240, 125);
            this.panelSubMenuChoferes.TabIndex = 4;
            // 
            // btnDisponibilidad
            // 
            this.btnDisponibilidad.BackColor = System.Drawing.Color.Azure;
            this.btnDisponibilidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDisponibilidad.FlatAppearance.BorderSize = 0;
            this.btnDisponibilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisponibilidad.Location = new System.Drawing.Point(0, 80);
            this.btnDisponibilidad.Name = "btnDisponibilidad";
            this.btnDisponibilidad.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDisponibilidad.Size = new System.Drawing.Size(240, 45);
            this.btnDisponibilidad.TabIndex = 2;
            this.btnDisponibilidad.Text = "Consultar Disponibilidad";
            this.btnDisponibilidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisponibilidad.UseVisualStyleBackColor = false;
            this.btnDisponibilidad.Click += new System.EventHandler(this.btnDisponibilidad_Click);
            // 
            // btnListaChoferes
            // 
            this.btnListaChoferes.BackColor = System.Drawing.Color.Azure;
            this.btnListaChoferes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaChoferes.FlatAppearance.BorderSize = 0;
            this.btnListaChoferes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaChoferes.Location = new System.Drawing.Point(0, 40);
            this.btnListaChoferes.Name = "btnListaChoferes";
            this.btnListaChoferes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListaChoferes.Size = new System.Drawing.Size(240, 40);
            this.btnListaChoferes.TabIndex = 1;
            this.btnListaChoferes.Text = "Lista de Choferes";
            this.btnListaChoferes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaChoferes.UseVisualStyleBackColor = false;
            this.btnListaChoferes.Click += new System.EventHandler(this.btnListaChoferes_Click);
            // 
            // btnNuevoChofer
            // 
            this.btnNuevoChofer.BackColor = System.Drawing.Color.Azure;
            this.btnNuevoChofer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoChofer.FlatAppearance.BorderSize = 0;
            this.btnNuevoChofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoChofer.Location = new System.Drawing.Point(0, 0);
            this.btnNuevoChofer.Name = "btnNuevoChofer";
            this.btnNuevoChofer.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNuevoChofer.Size = new System.Drawing.Size(240, 40);
            this.btnNuevoChofer.TabIndex = 0;
            this.btnNuevoChofer.Text = "Nuevo Chofer";
            this.btnNuevoChofer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoChofer.UseVisualStyleBackColor = false;
            this.btnNuevoChofer.Click += new System.EventHandler(this.btnNuevoChofer_Click);
            // 
            // btnChoferes
            // 
            this.btnChoferes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChoferes.FlatAppearance.BorderSize = 0;
            this.btnChoferes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoferes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChoferes.ForeColor = System.Drawing.Color.White;
            this.btnChoferes.Location = new System.Drawing.Point(0, 232);
            this.btnChoferes.Name = "btnChoferes";
            this.btnChoferes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnChoferes.Size = new System.Drawing.Size(240, 45);
            this.btnChoferes.TabIndex = 3;
            this.btnChoferes.Text = "Choferes";
            this.btnChoferes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoferes.UseVisualStyleBackColor = true;
            this.btnChoferes.Click += new System.EventHandler(this.btnChoferes_Click_1);
            // 
            // panelSubMenuVehiculos
            // 
            this.panelSubMenuVehiculos.BackColor = System.Drawing.Color.Silver;
            this.panelSubMenuVehiculos.Controls.Add(this.button4);
            this.panelSubMenuVehiculos.Controls.Add(this.btnNuevoVehiculo);
            this.panelSubMenuVehiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuVehiculos.Location = new System.Drawing.Point(0, 145);
            this.panelSubMenuVehiculos.Name = "panelSubMenuVehiculos";
            this.panelSubMenuVehiculos.Size = new System.Drawing.Size(240, 87);
            this.panelSubMenuVehiculos.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Azure;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 40);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(240, 46);
            this.button4.TabIndex = 2;
            this.button4.Text = "Lista de Vehiculos";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnNuevoVehiculo
            // 
            this.btnNuevoVehiculo.BackColor = System.Drawing.Color.Azure;
            this.btnNuevoVehiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoVehiculo.FlatAppearance.BorderSize = 0;
            this.btnNuevoVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoVehiculo.Location = new System.Drawing.Point(0, 0);
            this.btnNuevoVehiculo.Name = "btnNuevoVehiculo";
            this.btnNuevoVehiculo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNuevoVehiculo.Size = new System.Drawing.Size(240, 40);
            this.btnNuevoVehiculo.TabIndex = 0;
            this.btnNuevoVehiculo.Text = "Nuevo Vehiculo";
            this.btnNuevoVehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoVehiculo.UseVisualStyleBackColor = false;
            this.btnNuevoVehiculo.Click += new System.EventHandler(this.btnNuevoVehiculo_Click);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehiculos.FlatAppearance.BorderSize = 0;
            this.btnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVehiculos.ForeColor = System.Drawing.Color.White;
            this.btnVehiculos.Location = new System.Drawing.Point(0, 100);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVehiculos.Size = new System.Drawing.Size(240, 45);
            this.btnVehiculos.TabIndex = 1;
            this.btnVehiculos.Text = "Vehiculos";
            this.btnVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehiculos.UseVisualStyleBackColor = true;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(240, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.logocamion;
            this.pictureBox1.Location = new System.Drawing.Point(69, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserRol
            // 
            this.lblUserRol.AutoSize = true;
            this.lblUserRol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserRol.Location = new System.Drawing.Point(24, 10);
            this.lblUserRol.Name = "lblUserRol";
            this.lblUserRol.Size = new System.Drawing.Size(43, 17);
            this.lblUserRol.TabIndex = 1;
            this.lblUserRol.Text = "label1";
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(3)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::CapaPresentacion.Properties.Resources.cerrar1;
            this.btnCerrar.Location = new System.Drawing.Point(716, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(42, 25);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lblUserRol);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(240, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 41);
            this.panel1.TabIndex = 3;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(240, 41);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(766, 506);
            this.panelChildForm.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.logocamion;
            this.pictureBox2.Location = new System.Drawing.Point(289, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 234);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 547);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(1022, 586);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubMenuChoferes.ResumeLayout(false);
            this.panelSubMenuVehiculos.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

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
        private Button btnCerrar;
        private Panel panel1;
        private Panel panelChildForm;
        private PictureBox pictureBox2;
        private Button button4;
    }
}