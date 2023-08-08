namespace CapaPresentacion
{
    partial class FormListadoVehiculos
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
            label1 = new Label();
            dtgListadoVehiculos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgListadoVehiculos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(30, 42);
            label1.Name = "label1";
            label1.Size = new Size(394, 27);
            label1.TabIndex = 0;
            label1.Text = "Listado de Vehículos - Camioncitos S.A";
            // 
            // dtgListadoVehiculos
            // 
            dtgListadoVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListadoVehiculos.Location = new Point(27, 99);
            dtgListadoVehiculos.Name = "dtgListadoVehiculos";
            dtgListadoVehiculos.RowTemplate.Height = 25;
            dtgListadoVehiculos.Size = new Size(710, 305);
            dtgListadoVehiculos.TabIndex = 1;
            // 
            // FormListadoVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(dtgListadoVehiculos);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormListadoVehiculos";
            Text = "FormListadoVehiculos";
            Load += FormListadoVehiculos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgListadoVehiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgListadoVehiculos;
    }
}