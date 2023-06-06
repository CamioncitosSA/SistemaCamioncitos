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
            btnCerrar = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dtgVehiculos).BeginInit();
            SuspendLayout();
            // 
            // dtgVehiculos
            // 
            dtgVehiculos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgVehiculos.Location = new Point(22, 207);
            dtgVehiculos.Name = "dtgVehiculos";
            dtgVehiculos.RowTemplate.Height = 25;
            dtgVehiculos.Size = new Size(721, 277);
            dtgVehiculos.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(12, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += button1_Click;
            // 
            // lblTipoVehiculo
            // 
            lblTipoVehiculo.AutoSize = true;
            lblTipoVehiculo.BackColor = Color.Transparent;
            lblTipoVehiculo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoVehiculo.Location = new Point(32, 54);
            lblTipoVehiculo.Name = "lblTipoVehiculo";
            lblTipoVehiculo.Size = new Size(68, 40);
            lblTipoVehiculo.TabIndex = 2;
            lblTipoVehiculo.Text = "Tipo de \r\nVehiculo:";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.BackColor = Color.Transparent;
            lblPlaca.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlaca.Location = new Point(287, 112);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(47, 20);
            lblPlaca.TabIndex = 3;
            lblPlaca.Text = "Placa:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.BackColor = Color.Transparent;
            lblMarca.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.Location = new Point(34, 116);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(53, 20);
            lblMarca.TabIndex = 5;
            lblMarca.Text = "Marca:";
            // 
            // txtPlaca
            // 
            txtPlaca.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPlaca.Location = new Point(355, 105);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(123, 27);
            txtPlaca.TabIndex = 7;
            txtPlaca.KeyPress += txtPlaca_KeyPress;
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMarca.Location = new Point(106, 109);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(145, 27);
            txtMarca.TabIndex = 8;
            txtMarca.KeyPress += txtMarca_KeyPress;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(539, 84);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(99, 48);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(539, 138);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(99, 48);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(644, 138);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 48);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtModelo
            // 
            txtModelo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtModelo.Location = new Point(107, 152);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(145, 27);
            txtModelo.TabIndex = 14;
            txtModelo.KeyPress += txtModelo_KeyPress;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.BackColor = Color.Transparent;
            lblModelo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblModelo.Location = new Point(34, 159);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(64, 20);
            lblModelo.TabIndex = 13;
            lblModelo.Text = "Modelo:";
            // 
            // txtCapacidadCarga
            // 
            txtCapacidadCarga.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCapacidadCarga.Location = new Point(397, 67);
            txtCapacidadCarga.Name = "txtCapacidadCarga";
            txtCapacidadCarga.Size = new Size(119, 27);
            txtCapacidadCarga.TabIndex = 16;
            txtCapacidadCarga.KeyPress += txtCapacidadCarga_KeyPress;
            // 
            // lblCapacidadCarga
            // 
            lblCapacidadCarga.AutoSize = true;
            lblCapacidadCarga.BackColor = Color.Transparent;
            lblCapacidadCarga.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCapacidadCarga.Location = new Point(287, 54);
            lblCapacidadCarga.Name = "lblCapacidadCarga";
            lblCapacidadCarga.Size = new Size(104, 40);
            lblCapacidadCarga.TabIndex = 15;
            lblCapacidadCarga.Text = "Capacidad \r\nde Carga (Kg):";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstado.Location = new Point(287, 155);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 20);
            lblEstado.TabIndex = 17;
            lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "N (Nuevo)", "U (Usado)" });
            cmbEstado.Location = new Point(355, 147);
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
            cmbTipoVehiculo.Location = new Point(106, 66);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(146, 28);
            cmbTipoVehiculo.TabIndex = 19;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(644, 84);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(99, 48);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FormVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 231, 232);
            ClientSize = new Size(766, 506);
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
            Controls.Add(btnCerrar);
            Controls.Add(dtgVehiculos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVehiculo";
            Text = "FormAdmision";
            Load += FormVehiculo_Load;
            ((System.ComponentModel.ISupportInitialize)dtgVehiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgVehiculos;
        private Button btnCerrar;
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
    }
}