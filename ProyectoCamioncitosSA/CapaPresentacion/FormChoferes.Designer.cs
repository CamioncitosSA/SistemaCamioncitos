namespace CapaPresentacion
{
    partial class FormChoferes
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.Genero = new System.Windows.Forms.Label();
            this.NLicencia = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.Apellidos = new System.Windows.Forms.Label();
            this.Vencimiento = new System.Windows.Forms.Label();
            this.Nombres = new System.Windows.Forms.Label();
            this.cmbDisponibilidad = new System.Windows.Forms.ComboBox();
            this.Disponibilidad = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtNLicencia = new System.Windows.Forms.TextBox();
            this.dtgChoferes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChoferes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(12, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(662, 81);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(99, 48);
            this.btnLimpiar.TabIndex = 36;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "F (Femenino)",
            "M (Masculino)"});
            this.cmbGenero.Location = new System.Drawing.Point(117, 170);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(145, 28);
            this.cmbGenero.TabIndex = 34;
            // 
            // Genero
            // 
            this.Genero.AutoSize = true;
            this.Genero.BackColor = System.Drawing.Color.Transparent;
            this.Genero.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Genero.Location = new System.Drawing.Point(40, 173);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(60, 20);
            this.Genero.TabIndex = 33;
            this.Genero.Text = "Género:";
            // 
            // NLicencia
            // 
            this.NLicencia.AutoSize = true;
            this.NLicencia.BackColor = System.Drawing.Color.Transparent;
            this.NLicencia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NLicencia.Location = new System.Drawing.Point(279, 80);
            this.NLicencia.Name = "NLicencia";
            this.NLicencia.Size = new System.Drawing.Size(86, 20);
            this.NLicencia.TabIndex = 31;
            this.NLicencia.Text = "N° Licencia:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDireccion.Location = new System.Drawing.Point(117, 220);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(145, 27);
            this.txtDireccion.TabIndex = 30;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.BackColor = System.Drawing.Color.Transparent;
            this.Direccion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Direccion.Location = new System.Drawing.Point(40, 223);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(75, 20);
            this.Direccion.TabIndex = 29;
            this.Direccion.Text = "Dirección:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(662, 135);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 48);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(557, 135);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 48);
            this.btnModificar.TabIndex = 27;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(557, 81);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 48);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellidos.Location = new System.Drawing.Point(117, 121);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(145, 27);
            this.txtApellidos.TabIndex = 25;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // Apellidos
            // 
            this.Apellidos.AutoSize = true;
            this.Apellidos.BackColor = System.Drawing.Color.Transparent;
            this.Apellidos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Apellidos.Location = new System.Drawing.Point(40, 124);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(75, 20);
            this.Apellidos.TabIndex = 23;
            this.Apellidos.Text = "Apellidos:";
            // 
            // Vencimiento
            // 
            this.Vencimiento.AutoSize = true;
            this.Vencimiento.BackColor = System.Drawing.Color.Transparent;
            this.Vencimiento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Vencimiento.Location = new System.Drawing.Point(279, 124);
            this.Vencimiento.Name = "Vencimiento";
            this.Vencimiento.Size = new System.Drawing.Size(94, 20);
            this.Vencimiento.TabIndex = 22;
            this.Vencimiento.Text = "Vencimiento:";
            // 
            // Nombres
            // 
            this.Nombres.AutoSize = true;
            this.Nombres.BackColor = System.Drawing.Color.Transparent;
            this.Nombres.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nombres.Location = new System.Drawing.Point(40, 80);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(73, 20);
            this.Nombres.TabIndex = 21;
            this.Nombres.Text = "Nombres:";
            // 
            // cmbDisponibilidad
            // 
            this.cmbDisponibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisponibilidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbDisponibilidad.FormattingEnabled = true;
            this.cmbDisponibilidad.Items.AddRange(new object[] {
            "Disponible",
            "No Disponible"});
            this.cmbDisponibilidad.Location = new System.Drawing.Point(395, 170);
            this.cmbDisponibilidad.Name = "cmbDisponibilidad";
            this.cmbDisponibilidad.Size = new System.Drawing.Size(145, 28);
            this.cmbDisponibilidad.TabIndex = 38;
            // 
            // Disponibilidad
            // 
            this.Disponibilidad.AutoSize = true;
            this.Disponibilidad.BackColor = System.Drawing.Color.Transparent;
            this.Disponibilidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Disponibilidad.Location = new System.Drawing.Point(279, 173);
            this.Disponibilidad.Name = "Disponibilidad";
            this.Disponibilidad.Size = new System.Drawing.Size(110, 20);
            this.Disponibilidad.TabIndex = 37;
            this.Disponibilidad.Text = "Disponibilidad:";
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombres.Location = new System.Drawing.Point(117, 77);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(145, 27);
            this.txtNombres.TabIndex = 39;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.CustomFormat = "AAAA/MM/DD";
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimiento.Location = new System.Drawing.Point(395, 124);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(145, 23);
            this.dtpVencimiento.TabIndex = 40;
            this.dtpVencimiento.Value = new System.DateTime(2023, 7, 23, 15, 54, 36, 0);
            // 
            // txtNLicencia
            // 
            this.txtNLicencia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNLicencia.Location = new System.Drawing.Point(395, 77);
            this.txtNLicencia.Name = "txtNLicencia";
            this.txtNLicencia.Size = new System.Drawing.Size(145, 27);
            this.txtNLicencia.TabIndex = 41;
            this.txtNLicencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNLicencia_KeyPress);
            // 
            // dtgChoferes
            // 
            this.dtgChoferes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgChoferes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgChoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChoferes.Location = new System.Drawing.Point(40, 269);
            this.dtgChoferes.Name = "dtgChoferes";
            this.dtgChoferes.RowTemplate.Height = 25;
            this.dtgChoferes.Size = new System.Drawing.Size(721, 277);
            this.dtgChoferes.TabIndex = 42;
            // 
            // FormChoferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.dtgChoferes);
            this.Controls.Add(this.txtNLicencia);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.cmbDisponibilidad);
            this.Controls.Add(this.Disponibilidad);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.NLicencia);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.Vencimiento);
            this.Controls.Add(this.Nombres);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChoferes";
            this.Text = "FormChoferes";
            this.Load += new System.EventHandler(this.FormChoferes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChoferes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCerrar;
        private Button btnLimpiar;
        private ComboBox cmbGenero;
        private Label Genero;
        private Label NLicencia;
        private TextBox txtDireccion;
        private Label Direccion;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private TextBox txtApellidos;
        private Label Apellidos;
        private Label Vencimiento;
        private Label Nombres;
        private ComboBox cmbDisponibilidad;
        private Label Disponibilidad;
        private TextBox txtNombres;
        private DateTimePicker dtpVencimiento;
        private TextBox txtNLicencia;
        private DataGridView dtgChoferes;
    }
}