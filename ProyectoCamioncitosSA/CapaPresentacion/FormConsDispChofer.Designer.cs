namespace CapaPresentacion
{
    partial class FormConsDispChofer
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
            label2 = new Label();
            txtID = new TextBox();
            label4 = new Label();
            dtgDisponibilidad = new DataGridView();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDisponibilidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(382, 27);
            label1.TabIndex = 0;
            label1.Text = "Consultar Disponibilidad de Choferes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 124);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(63, 121);
            txtID.Name = "txtID";
            txtID.Size = new Size(140, 25);
            txtID.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(21, 66);
            label4.Name = "label4";
            label4.Size = new Size(397, 19);
            label4.TabIndex = 5;
            label4.Text = "Ingrese el ID del chofer que desea consultar si está disponible:";
            // 
            // dtgDisponibilidad
            // 
            dtgDisponibilidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDisponibilidad.Location = new Point(21, 173);
            dtgDisponibilidad.Name = "dtgDisponibilidad";
            dtgDisponibilidad.RowTemplate.Height = 25;
            dtgDisponibilidad.Size = new Size(717, 250);
            dtgDisponibilidad.TabIndex = 8;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(68, 67, 110);
            btnBuscar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(227, 115);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(105, 34);
            btnBuscar.TabIndex = 27;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FormConsDispChofer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(dtgDisponibilidad);
            Controls.Add(label4);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConsDispChofer";
            Text = "FormConsDispChofer";
            Load += FormConsDispChofer_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDisponibilidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtID;
        private Label label4;
        private DataGridView dtgDisponibilidad;
        private Button btnBuscar;
    }
}