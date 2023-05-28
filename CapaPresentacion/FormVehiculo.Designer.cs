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
            button1 = new Button();
            lblTipoVehiculo = new Label();
            lblMatricula = new Label();
            gpbAsegurado = new GroupBox();
            lblMarca = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            gpbEstado = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgVehiculos).BeginInit();
            gpbAsegurado.SuspendLayout();
            gpbEstado.SuspendLayout();
            SuspendLayout();
            // 
            // dtgVehiculos
            // 
            dtgVehiculos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgVehiculos.Location = new Point(22, 207);
            dtgVehiculos.Name = "dtgVehiculos";
            dtgVehiculos.RowTemplate.Height = 25;
            dtgVehiculos.Size = new Size(705, 232);
            dtgVehiculos.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblTipoVehiculo
            // 
            lblTipoVehiculo.AutoSize = true;
            lblTipoVehiculo.Location = new Point(44, 54);
            lblTipoVehiculo.Name = "lblTipoVehiculo";
            lblTipoVehiculo.Size = new Size(55, 30);
            lblTipoVehiculo.TabIndex = 2;
            lblTipoVehiculo.Text = "Tipo de\r\nVehiculo:";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(44, 101);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(60, 15);
            lblMatricula.TabIndex = 3;
            lblMatricula.Text = "Matricula:";
            // 
            // gpbAsegurado
            // 
            gpbAsegurado.Controls.Add(radioButton2);
            gpbAsegurado.Controls.Add(radioButton1);
            gpbAsegurado.Location = new Point(44, 135);
            gpbAsegurado.Name = "gpbAsegurado";
            gpbAsegurado.Size = new Size(174, 66);
            gpbAsegurado.TabIndex = 4;
            gpbAsegurado.TabStop = false;
            gpbAsegurado.Text = "Asegurado";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(285, 61);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(43, 15);
            lblMarca.TabIndex = 5;
            lblMarca.Text = "Marca:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(334, 58);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 23);
            textBox3.TabIndex = 8;
            // 
            // gpbEstado
            // 
            gpbEstado.Controls.Add(radioButton4);
            gpbEstado.Controls.Add(radioButton3);
            gpbEstado.Location = new Point(285, 93);
            gpbEstado.Name = "gpbEstado";
            gpbEstado.Size = new Size(174, 66);
            gpbEstado.TabIndex = 9;
            gpbEstado.TabStop = false;
            gpbEstado.Text = "Estado";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(26, 29);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(34, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "SI";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(95, 29);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(43, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "NO";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(19, 29);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(60, 19);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "Nuevo";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(95, 29);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(58, 19);
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.Text = "Usado";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(591, 50);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(85, 31);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(591, 93);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(85, 31);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(591, 135);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(85, 31);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // FormAdmision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 461);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(gpbEstado);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblMarca);
            Controls.Add(gpbAsegurado);
            Controls.Add(lblMatricula);
            Controls.Add(lblTipoVehiculo);
            Controls.Add(button1);
            Controls.Add(dtgVehiculos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdmision";
            Text = "FormAdmision";
            ((System.ComponentModel.ISupportInitialize)dtgVehiculos).EndInit();
            gpbAsegurado.ResumeLayout(false);
            gpbAsegurado.PerformLayout();
            gpbEstado.ResumeLayout(false);
            gpbEstado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgVehiculos;
        private Button button1;
        private Label lblTipoVehiculo;
        private Label lblMatricula;
        private GroupBox gpbAsegurado;
        private Label lblMarca;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private GroupBox gpbEstado;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}