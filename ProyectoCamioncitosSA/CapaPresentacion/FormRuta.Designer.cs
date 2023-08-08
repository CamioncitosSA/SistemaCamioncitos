namespace CapaPresentacion
{
    partial class FormRuta
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
            txtDetallesPedido = new RichTextBox();
            txtTiempoEstimado = new TextBox();
            txtDistanciaRecorrida = new TextBox();
            txtDestino = new TextBox();
            txtOrigen = new TextBox();
            cmbEstadoEntrega = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtgRutas = new DataGridView();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgRutas).BeginInit();
            SuspendLayout();
            // 
            // txtDetallesPedido
            // 
            txtDetallesPedido.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDetallesPedido.Location = new Point(324, 156);
            txtDetallesPedido.Margin = new Padding(3, 2, 3, 2);
            txtDetallesPedido.Name = "txtDetallesPedido";
            txtDetallesPedido.Size = new Size(266, 98);
            txtDetallesPedido.TabIndex = 31;
            txtDetallesPedido.Text = "";
            // 
            // txtTiempoEstimado
            // 
            txtTiempoEstimado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTiempoEstimado.Location = new Point(435, 78);
            txtTiempoEstimado.Margin = new Padding(3, 2, 3, 2);
            txtTiempoEstimado.Name = "txtTiempoEstimado";
            txtTiempoEstimado.Size = new Size(133, 27);
            txtTiempoEstimado.TabIndex = 30;
            // 
            // txtDistanciaRecorrida
            // 
            txtDistanciaRecorrida.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDistanciaRecorrida.Location = new Point(165, 174);
            txtDistanciaRecorrida.Margin = new Padding(3, 2, 3, 2);
            txtDistanciaRecorrida.Name = "txtDistanciaRecorrida";
            txtDistanciaRecorrida.Size = new Size(133, 27);
            txtDistanciaRecorrida.TabIndex = 29;
            // 
            // txtDestino
            // 
            txtDestino.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDestino.Location = new Point(110, 117);
            txtDestino.Margin = new Padding(3, 2, 3, 2);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(161, 27);
            txtDestino.TabIndex = 28;
            // 
            // txtOrigen
            // 
            txtOrigen.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtOrigen.Location = new Point(110, 72);
            txtOrigen.Margin = new Padding(3, 2, 3, 2);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(161, 27);
            txtOrigen.TabIndex = 27;
            // 
            // cmbEstadoEntrega
            // 
            cmbEstadoEntrega.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoEntrega.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEstadoEntrega.FormattingEnabled = true;
            cmbEstadoEntrega.Items.AddRange(new object[] { "Entregado", "En proceso", "Pendiente", "Cancelado" });
            cmbEstadoEntrega.Location = new Point(154, 226);
            cmbEstadoEntrega.Margin = new Padding(3, 2, 3, 2);
            cmbEstadoEntrega.Name = "cmbEstadoEntrega";
            cmbEstadoEntrega.Size = new Size(133, 28);
            cmbEstadoEntrega.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(33, 214);
            label7.Name = "label7";
            label7.Size = new Size(90, 40);
            label7.TabIndex = 25;
            label7.Text = "Estado de \r\nla entrega:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(324, 126);
            label6.Name = "label6";
            label6.Size = new Size(163, 20);
            label6.TabIndex = 24;
            label6.Text = "Detalles del pedido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(324, 65);
            label5.Name = "label5";
            label5.Size = new Size(109, 40);
            label5.TabIndex = 23;
            label5.Text = "Tiempo \r\nestimado (h):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 159);
            label4.Name = "label4";
            label4.Size = new Size(126, 40);
            label4.TabIndex = 22;
            label4.Text = "Distancia \r\nrecorrida (km) :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 120);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 21;
            label3.Text = "Destino:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 73);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 20;
            label2.Text = "Origen:";
            // 
            // dtgRutas
            // 
            dtgRutas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgRutas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgRutas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRutas.Location = new Point(29, 281);
            dtgRutas.Name = "dtgRutas";
            dtgRutas.RowTemplate.Height = 25;
            dtgRutas.Size = new Size(737, 284);
            dtgRutas.TabIndex = 43;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(68, 67, 110);
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(627, 217);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(99, 48);
            btnLimpiar.TabIndex = 47;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(68, 67, 110);
            btnEliminar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(627, 163);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 48);
            btnEliminar.TabIndex = 46;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(68, 67, 110);
            btnModificar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(627, 109);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(99, 48);
            btnModificar.TabIndex = 45;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(68, 67, 110);
            btnGuardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(627, 55);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(99, 48);
            btnGuardar.TabIndex = 44;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 20);
            label1.Name = "label1";
            label1.Size = new Size(89, 32);
            label1.TabIndex = 48;
            label1.Text = "RUTAS";
            // 
            // FormRuta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 593);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(dtgRutas);
            Controls.Add(txtDetallesPedido);
            Controls.Add(txtTiempoEstimado);
            Controls.Add(txtDistanciaRecorrida);
            Controls.Add(txtDestino);
            Controls.Add(txtOrigen);
            Controls.Add(cmbEstadoEntrega);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormRuta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRuta";
            Load += FormRuta_Load;
            ((System.ComponentModel.ISupportInitialize)dtgRutas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox txtDetallesPedido;
        private TextBox txtTiempoEstimado;
        private TextBox txtDistanciaRecorrida;
        private TextBox txtDestino;
        private TextBox txtOrigen;
        private ComboBox cmbEstadoEntrega;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dtgRutas;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private Label label1;
    }
}