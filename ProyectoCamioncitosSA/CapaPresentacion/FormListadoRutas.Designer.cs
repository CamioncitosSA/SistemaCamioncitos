namespace CapaPresentacion
{
    partial class FormListadoRutas
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
            dtgListadoRutas = new DataGridView();
            label1 = new Label();
            btnBuscar = new Button();
            txtFiltroDestino = new TextBox();
            label2 = new Label();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgListadoRutas).BeginInit();
            SuspendLayout();
            // 
            // dtgListadoRutas
            // 
            dtgListadoRutas.AllowUserToAddRows = false;
            dtgListadoRutas.AllowUserToDeleteRows = false;
            dtgListadoRutas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListadoRutas.Location = new Point(33, 127);
            dtgListadoRutas.Name = "dtgListadoRutas";
            dtgListadoRutas.ReadOnly = true;
            dtgListadoRutas.RowTemplate.Height = 25;
            dtgListadoRutas.Size = new Size(694, 300);
            dtgListadoRutas.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(30, 23);
            label1.Name = "label1";
            label1.Size = new Size(356, 27);
            label1.TabIndex = 2;
            label1.Text = "Listado de Rutas - Camioncitos S.A";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(68, 67, 110);
            btnBuscar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(390, 76);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(105, 34);
            btnBuscar.TabIndex = 30;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtFiltroDestino
            // 
            txtFiltroDestino.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtFiltroDestino.Location = new Point(195, 82);
            txtFiltroDestino.Name = "txtFiltroDestino";
            txtFiltroDestino.Size = new Size(162, 25);
            txtFiltroDestino.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 85);
            label2.Name = "label2";
            label2.Size = new Size(156, 20);
            label2.TabIndex = 28;
            label2.Text = "Buscar por Destino:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(68, 67, 110);
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(510, 76);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(105, 34);
            btnLimpiar.TabIndex = 31;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FormListadoRutas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(txtFiltroDestino);
            Controls.Add(label2);
            Controls.Add(dtgListadoRutas);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormListadoRutas";
            Text = "FormListadoRutas";
            Load += FormListadoRutas_Load;
            ((System.ComponentModel.ISupportInitialize)dtgListadoRutas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgListadoRutas;
        private Label label1;
        private Button btnBuscar;
        private TextBox txtFiltroDestino;
        private Label label2;
        private Button btnLimpiar;
    }
}