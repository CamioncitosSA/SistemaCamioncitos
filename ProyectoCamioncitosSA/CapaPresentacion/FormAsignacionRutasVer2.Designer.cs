namespace CapaPresentacion
{
    partial class FormAsignacionRutasVer2
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
            label2 = new Label();
            lblRutasAsignadas = new Label();
            label1 = new Label();
            btnAsignar = new Button();
            btnDesasignar = new Button();
            btnLimpiar = new Button();
            dtgChoferes = new DataGridView();
            txtRutaDisponible = new TextBox();
            txtChoferDisponible = new TextBox();
            dtgRutas = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtgRutasChoferes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgChoferes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgRutas).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblAsignacion
            // 
            lblAsignacion.AutoSize = true;
            lblAsignacion.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAsignacion.Location = new Point(12, 6);
            lblAsignacion.Name = "lblAsignacion";
            lblAsignacion.Size = new Size(374, 32);
            lblAsignacion.TabIndex = 52;
            lblAsignacion.Text = "Asignación de Rutas a Choferes";
            // 
            // dtgRutasChoferes
            // 
            dtgRutasChoferes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgRutasChoferes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgRutasChoferes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRutasChoferes.Location = new Point(41, 42);
            dtgRutasChoferes.Name = "dtgRutasChoferes";
            dtgRutasChoferes.RowTemplate.Height = 25;
            dtgRutasChoferes.Size = new Size(373, 159);
            dtgRutasChoferes.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 49;
            label2.Text = "Ruta Seleccionada:";
            // 
            // lblRutasAsignadas
            // 
            lblRutasAsignadas.AutoSize = true;
            lblRutasAsignadas.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRutasAsignadas.Location = new Point(41, 7);
            lblRutasAsignadas.Name = "lblRutasAsignadas";
            lblRutasAsignadas.Size = new Size(152, 25);
            lblRutasAsignadas.TabIndex = 53;
            lblRutasAsignadas.Text = "Rutas Asignadas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 54;
            label1.Text = "Chofer Seleccionado:";
            // 
            // btnAsignar
            // 
            btnAsignar.BackColor = Color.FromArgb(68, 67, 110);
            btnAsignar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAsignar.ForeColor = Color.White;
            btnAsignar.Location = new Point(482, 93);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(173, 51);
            btnAsignar.TabIndex = 56;
            btnAsignar.Text = "ASIGNAR";
            btnAsignar.UseVisualStyleBackColor = false;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // btnDesasignar
            // 
            btnDesasignar.BackColor = Color.FromArgb(68, 67, 110);
            btnDesasignar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDesasignar.ForeColor = Color.White;
            btnDesasignar.Location = new Point(482, 150);
            btnDesasignar.Name = "btnDesasignar";
            btnDesasignar.Size = new Size(173, 51);
            btnDesasignar.TabIndex = 57;
            btnDesasignar.Text = "DESASIGNAR";
            btnDesasignar.UseVisualStyleBackColor = false;
            btnDesasignar.Click += btnDesasignar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(68, 67, 110);
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(482, 36);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(173, 51);
            btnLimpiar.TabIndex = 58;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dtgChoferes
            // 
            dtgChoferes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgChoferes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgChoferes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgChoferes.Location = new Point(13, 78);
            dtgChoferes.Name = "dtgChoferes";
            dtgChoferes.RowTemplate.Height = 25;
            dtgChoferes.Size = new Size(365, 240);
            dtgChoferes.TabIndex = 59;
            dtgChoferes.SelectionChanged += dtgChoferes_SelectionChanged;
            // 
            // txtRutaDisponible
            // 
            txtRutaDisponible.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRutaDisponible.Location = new Point(12, 37);
            txtRutaDisponible.Margin = new Padding(3, 2, 3, 2);
            txtRutaDisponible.Name = "txtRutaDisponible";
            txtRutaDisponible.ReadOnly = true;
            txtRutaDisponible.Size = new Size(203, 27);
            txtRutaDisponible.TabIndex = 55;
            // 
            // txtChoferDisponible
            // 
            txtChoferDisponible.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtChoferDisponible.Location = new Point(13, 37);
            txtChoferDisponible.Margin = new Padding(3, 2, 3, 2);
            txtChoferDisponible.Name = "txtChoferDisponible";
            txtChoferDisponible.ReadOnly = true;
            txtChoferDisponible.Size = new Size(203, 27);
            txtChoferDisponible.TabIndex = 50;
            // 
            // dtgRutas
            // 
            dtgRutas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgRutas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgRutas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRutas.Location = new Point(12, 78);
            dtgRutas.Name = "dtgRutas";
            dtgRutas.RowTemplate.Height = 25;
            dtgRutas.Size = new Size(353, 240);
            dtgRutas.TabIndex = 60;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(lblAsignacion);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 43);
            panel1.TabIndex = 61;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Controls.Add(dtgRutasChoferes);
            panel2.Controls.Add(lblRutasAsignadas);
            panel2.Controls.Add(btnDesasignar);
            panel2.Controls.Add(btnAsignar);
            panel2.Controls.Add(btnLimpiar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 377);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 216);
            panel2.TabIndex = 62;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgRutas);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtRutaDisponible);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 43);
            panel3.Name = "panel3";
            panel3.Size = new Size(397, 334);
            panel3.TabIndex = 63;
            // 
            // panel4
            // 
            panel4.Controls.Add(dtgChoferes);
            panel4.Controls.Add(txtChoferDisponible);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(396, 43);
            panel4.Name = "panel4";
            panel4.Size = new Size(404, 334);
            panel4.TabIndex = 64;
            // 
            // FormAsignacionRutasVer2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 593);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAsignacionRutasVer2";
            Text = "FormAsignacionRutas";
            Load += FormAsignacionRutasVer2_Load;
            ((System.ComponentModel.ISupportInitialize)dtgRutasChoferes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgChoferes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgRutas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblAsignacion;
        private DataGridView dtgRutasChoferes;
        private Label label2;
        private Label lblRutasAsignadas;
        private Label label1;
        private Button btnAsignar;
        private Button btnDesasignar;
        private Button btnLimpiar;
        private DataGridView dtgChoferes;
        private TextBox txtRutaDisponible;
        private TextBox txtChoferDisponible;
        private DataGridView dtgRutas;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}