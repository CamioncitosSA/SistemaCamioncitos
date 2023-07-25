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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgListadoVehiculos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListadoVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Vehículos - Camioncitos S.A";
            // 
            // dtgListadoVehiculos
            // 
            this.dtgListadoVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListadoVehiculos.Location = new System.Drawing.Point(43, 98);
            this.dtgListadoVehiculos.Name = "dtgListadoVehiculos";
            this.dtgListadoVehiculos.RowTemplate.Height = 25;
            this.dtgListadoVehiculos.Size = new System.Drawing.Size(710, 305);
            this.dtgListadoVehiculos.TabIndex = 1;
            // 
            // FormListadoVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgListadoVehiculos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListadoVehiculos";
            this.Text = "FormListadoVehiculos";
            this.Load += new System.EventHandler(this.FormListadoVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListadoVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dtgListadoVehiculos;
    }
}