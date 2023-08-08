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
            btnLimpiar = new Button();
            cmbGenero = new ComboBox();
            Genero = new Label();
            NLicencia = new Label();
            txtDireccion = new TextBox();
            Direccion = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            txtApellidos = new TextBox();
            Apellidos = new Label();
            Vencimiento = new Label();
            Nombres = new Label();
            cmbDisponibilidad = new ComboBox();
            Disponibilidad = new Label();
            txtNombres = new TextBox();
            dtpVencimiento = new DateTimePicker();
            txtNLicencia = new TextBox();
            dtgChoferes = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgChoferes).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(68, 67, 110);
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(664, 104);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(99, 48);
            btnLimpiar.TabIndex = 36;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cmbGenero
            // 
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "F (Femenino)", "M (Masculino)" });
            cmbGenero.Location = new Point(107, 169);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(145, 28);
            cmbGenero.TabIndex = 34;
            // 
            // Genero
            // 
            Genero.AutoSize = true;
            Genero.BackColor = Color.Transparent;
            Genero.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Genero.Location = new Point(16, 172);
            Genero.Name = "Genero";
            Genero.Size = new Size(67, 20);
            Genero.TabIndex = 33;
            Genero.Text = "Género:";
            // 
            // NLicencia
            // 
            NLicencia.AutoSize = true;
            NLicencia.BackColor = Color.Transparent;
            NLicencia.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            NLicencia.Location = new Point(269, 79);
            NLicencia.Name = "NLicencia";
            NLicencia.Size = new Size(98, 20);
            NLicencia.TabIndex = 31;
            NLicencia.Text = "N° Licencia:";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.Location = new Point(107, 219);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(145, 27);
            txtDireccion.TabIndex = 30;
            txtDireccion.KeyPress += txtDireccion_KeyPress;
            // 
            // Direccion
            // 
            Direccion.AutoSize = true;
            Direccion.BackColor = Color.Transparent;
            Direccion.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Direccion.Location = new Point(16, 222);
            Direccion.Name = "Direccion";
            Direccion.Size = new Size(85, 20);
            Direccion.TabIndex = 29;
            Direccion.Text = "Dirección:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(68, 67, 110);
            btnEliminar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(664, 158);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 48);
            btnEliminar.TabIndex = 28;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(68, 67, 110);
            btnModificar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(559, 158);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(99, 48);
            btnModificar.TabIndex = 27;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(68, 67, 110);
            btnGuardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(559, 104);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(99, 48);
            btnGuardar.TabIndex = 26;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellidos.Location = new Point(107, 120);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(145, 27);
            txtApellidos.TabIndex = 25;
            txtApellidos.KeyPress += txtApellidos_KeyPress;
            // 
            // Apellidos
            // 
            Apellidos.AutoSize = true;
            Apellidos.BackColor = Color.Transparent;
            Apellidos.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Apellidos.Location = new Point(16, 123);
            Apellidos.Name = "Apellidos";
            Apellidos.Size = new Size(85, 20);
            Apellidos.TabIndex = 23;
            Apellidos.Text = "Apellidos:";
            // 
            // Vencimiento
            // 
            Vencimiento.AutoSize = true;
            Vencimiento.BackColor = Color.Transparent;
            Vencimiento.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Vencimiento.Location = new Point(269, 123);
            Vencimiento.Name = "Vencimiento";
            Vencimiento.Size = new Size(107, 20);
            Vencimiento.TabIndex = 22;
            Vencimiento.Text = "Vencimiento:";
            // 
            // Nombres
            // 
            Nombres.AutoSize = true;
            Nombres.BackColor = Color.Transparent;
            Nombres.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Nombres.Location = new Point(16, 79);
            Nombres.Name = "Nombres";
            Nombres.Size = new Size(81, 20);
            Nombres.TabIndex = 21;
            Nombres.Text = "Nombres:";
            // 
            // cmbDisponibilidad
            // 
            cmbDisponibilidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDisponibilidad.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDisponibilidad.FormattingEnabled = true;
            cmbDisponibilidad.Items.AddRange(new object[] { "Disponible", "No Disponible" });
            cmbDisponibilidad.Location = new Point(396, 169);
            cmbDisponibilidad.Name = "cmbDisponibilidad";
            cmbDisponibilidad.Size = new Size(145, 28);
            cmbDisponibilidad.TabIndex = 38;
            // 
            // Disponibilidad
            // 
            Disponibilidad.AutoSize = true;
            Disponibilidad.BackColor = Color.Transparent;
            Disponibilidad.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Disponibilidad.Location = new Point(269, 172);
            Disponibilidad.Name = "Disponibilidad";
            Disponibilidad.Size = new Size(125, 20);
            Disponibilidad.TabIndex = 37;
            Disponibilidad.Text = "Disponibilidad:";
            // 
            // txtNombres
            // 
            txtNombres.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombres.Location = new Point(107, 76);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(145, 27);
            txtNombres.TabIndex = 39;
            txtNombres.KeyPress += txtNombres_KeyPress;
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.CustomFormat = "AAAA/MM/DD";
            dtpVencimiento.Format = DateTimePickerFormat.Short;
            dtpVencimiento.Location = new Point(385, 123);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(145, 23);
            dtpVencimiento.TabIndex = 40;
            dtpVencimiento.Value = new DateTime(2023, 7, 23, 15, 54, 36, 0);
            // 
            // txtNLicencia
            // 
            txtNLicencia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNLicencia.Location = new Point(373, 76);
            txtNLicencia.Name = "txtNLicencia";
            txtNLicencia.Size = new Size(145, 27);
            txtNLicencia.TabIndex = 41;
            txtNLicencia.KeyPress += txtNLicencia_KeyPress;
            // 
            // dtgChoferes
            // 
            dtgChoferes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgChoferes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgChoferes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgChoferes.Location = new Point(16, 270);
            dtgChoferes.Name = "dtgChoferes";
            dtgChoferes.RowTemplate.Height = 25;
            dtgChoferes.Size = new Size(735, 277);
            dtgChoferes.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 17);
            label1.Name = "label1";
            label1.Size = new Size(132, 32);
            label1.TabIndex = 43;
            label1.Text = "CHOFERES";
            // 
            // FormChoferes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 593);
            Controls.Add(label1);
            Controls.Add(dtgChoferes);
            Controls.Add(txtNLicencia);
            Controls.Add(dtpVencimiento);
            Controls.Add(txtNombres);
            Controls.Add(cmbDisponibilidad);
            Controls.Add(Disponibilidad);
            Controls.Add(btnLimpiar);
            Controls.Add(cmbGenero);
            Controls.Add(Genero);
            Controls.Add(NLicencia);
            Controls.Add(txtDireccion);
            Controls.Add(Direccion);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(txtApellidos);
            Controls.Add(Apellidos);
            Controls.Add(Vencimiento);
            Controls.Add(Nombres);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormChoferes";
            Text = "FormChoferes";
            Load += FormChoferes_Load;
            ((System.ComponentModel.ISupportInitialize)dtgChoferes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Label label1;
    }
}