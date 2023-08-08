namespace CapaPresentacion
{
    partial class FormListadoAsignacionRutas
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
            lblAsignacion = new Label();
            dtgRutasChoferes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgRutasChoferes).BeginInit();
            SuspendLayout();
            // 
            // lblAsignacion
            // 
            lblAsignacion.AutoSize = true;
            lblAsignacion.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAsignacion.Location = new Point(23, 18);
            lblAsignacion.Name = "lblAsignacion";
            lblAsignacion.Size = new Size(326, 32);
            lblAsignacion.TabIndex = 54;
            lblAsignacion.Text = "Listado de Rutas Asignadas";
            // 
            // dtgRutasChoferes
            // 
            dtgRutasChoferes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgRutasChoferes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgRutasChoferes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRutasChoferes.Location = new Point(23, 68);
            dtgRutasChoferes.Name = "dtgRutasChoferes";
            dtgRutasChoferes.RowTemplate.Height = 25;
            dtgRutasChoferes.Size = new Size(326, 472);
            dtgRutasChoferes.TabIndex = 53;
            // 
            // FormListadoAsignacionRutas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 593);
            Controls.Add(lblAsignacion);
            Controls.Add(dtgRutasChoferes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormListadoAsignacionRutas";
            Text = "FormListadoAsignacionRutas";
            Load += FormListadoAsignacionRutas_Load;
            ((System.ComponentModel.ISupportInitialize)dtgRutasChoferes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAsignacion;
        private DataGridView dtgRutasChoferes;
    }
}