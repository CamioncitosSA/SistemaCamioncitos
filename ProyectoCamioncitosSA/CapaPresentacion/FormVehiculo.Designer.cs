namespace CapaPresentacion
{
    partial class FormVehiculo
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
            dtgVehiculos = new DataGridView();
            lblTipoVehiculo = new Label();
            lblPlaca = new Label();
            lblMarca = new Label();
            txtPlaca = new TextBox();
            txtMarca = new TextBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            txtModelo = new TextBox();
            lblModelo = new Label();
            txtCapacidadCarga = new TextBox();
            lblCapacidadCarga = new Label();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            cmbTipoVehiculo = new ComboBox();
            btnLimpiar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgVehiculos).BeginInit();
            SuspendLayout();
            // 
            // dtgVehiculos
            // 
            dtgVehiculos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgVehiculos.Location = new Point(22, 228);
            dtgVehiculos.Name = "dtgVehiculos";
            dtgVehiculos.RowTemplate.Height = 25;
            dtgVehiculos.Size = new Size(721, 266);
            dtgVehiculos.TabIndex = 0;
            // 
            // lblTipoVehiculo
            // 
            lblTipoVehiculo.AutoSize = true;
            lblTipoVehiculo.BackColor = Color.Transparent;
            lblTipoVehiculo.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoVehiculo.Location = new Point(22, 67);
            lblTipoVehiculo.Name = "lblTipoVehiculo";
            lblTipoVehiculo.Size = new Size(78, 40);
            lblTipoVehiculo.TabIndex = 2;
            lblTipoVehiculo.Text = "Tipo de \r\nVehiculo:";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.BackColor = Color.Transparent;
            lblPlaca.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlaca.Location = new Point(277, 125);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(53, 20);
            lblPlaca.TabIndex = 3;
            lblPlaca.Text = "Placa:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.BackColor = Color.Transparent;
            lblMarca.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMarca.Location = new Point(24, 125);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(59, 20);
            lblMarca.TabIndex = 5;
            lblMarca.Text = "Marca:";
            // 
            // txtPlaca
            // 
            txtPlaca.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPlaca.Location = new Point(345, 122);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(123, 27);
            txtPlaca.TabIndex = 7;
            txtPlaca.KeyPress += txtPlaca_KeyPress_1;
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMarca.Location = new Point(106, 125);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(145, 27);
            txtMarca.TabIndex = 8;
            txtMarca.KeyPress += txtMarca_KeyPress_1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(68, 67, 110);
            btnGuardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(539, 90);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(99, 48);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(68, 67, 110);
            btnModificar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(539, 144);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(99, 48);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(68, 67, 110);
            btnEliminar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(644, 144);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 48);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtModelo
            // 
            txtModelo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtModelo.Location = new Point(106, 165);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(145, 27);
            txtModelo.TabIndex = 14;
            txtModelo.KeyPress += txtModelo_KeyPress_1;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.BackColor = Color.Transparent;
            lblModelo.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblModelo.Location = new Point(24, 172);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(71, 20);
            lblModelo.TabIndex = 13;
            lblModelo.Text = "Modelo:";
            // 
            // txtCapacidadCarga
            // 
            txtCapacidadCarga.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCapacidadCarga.Location = new Point(401, 79);
            txtCapacidadCarga.Name = "txtCapacidadCarga";
            txtCapacidadCarga.Size = new Size(119, 27);
            txtCapacidadCarga.TabIndex = 16;
            txtCapacidadCarga.KeyPress += txtCapacidadCarga_KeyPress_1;
            // 
            // lblCapacidadCarga
            // 
            lblCapacidadCarga.AutoSize = true;
            lblCapacidadCarga.BackColor = Color.Transparent;
            lblCapacidadCarga.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCapacidadCarga.Location = new Point(277, 67);
            lblCapacidadCarga.Name = "lblCapacidadCarga";
            lblCapacidadCarga.Size = new Size(118, 40);
            lblCapacidadCarga.TabIndex = 15;
            lblCapacidadCarga.Text = "Capacidad \r\nde Carga (Kg):";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstado.Location = new Point(277, 168);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(64, 20);
            lblEstado.TabIndex = 17;
            lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "N (Nuevo)", "U (Usado)" });
            cmbEstado.Location = new Point(345, 162);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(123, 28);
            cmbEstado.TabIndex = 18;
            // 
            // cmbTipoVehiculo
            // 
            cmbTipoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoVehiculo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoVehiculo.FormattingEnabled = true;
            cmbTipoVehiculo.Items.AddRange(new object[] { "Camioneta", "Camion", "Grua" });
            cmbTipoVehiculo.Location = new Point(106, 79);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(146, 28);
            cmbTipoVehiculo.TabIndex = 19;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(68, 67, 110);
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(644, 90);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(99, 48);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(143, 32);
            label1.TabIndex = 21;
            label1.Text = "VEHÍCULOS";
            // 
            // FormVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(766, 538);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(cmbTipoVehiculo);
            Controls.Add(cmbEstado);
            Controls.Add(lblEstado);
            Controls.Add(txtCapacidadCarga);
            Controls.Add(lblCapacidadCarga);
            Controls.Add(txtModelo);
            Controls.Add(lblModelo);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(txtMarca);
            Controls.Add(txtPlaca);
            Controls.Add(lblMarca);
            Controls.Add(lblPlaca);
            Controls.Add(lblTipoVehiculo);
            Controls.Add(dtgVehiculos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVehiculo";
            Text = "FormAdmision";
            Load += FormVehiculo_Load_1;
            ((System.ComponentModel.ISupportInitialize)dtgVehiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgVehiculos;
        private Label lblTipoVehiculo;
        private Label lblPlaca;
        private Label lblMarca;
        private TextBox txtPlaca;
        private TextBox txtMarca;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private TextBox txtModelo;
        private Label lblModelo;
        private TextBox txtCapacidadCarga;
        private Label lblCapacidadCarga;
        private Label lblEstado;
        private ComboBox cmbEstado;
        private ComboBox cmbTipoVehiculo;
        private Button btnLimpiar;
        private Label label1;
    }
}