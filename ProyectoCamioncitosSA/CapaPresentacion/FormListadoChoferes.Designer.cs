namespace CapaPresentacion
{
    partial class FormListadoChoferes
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
            dtgListadoChoferes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgListadoChoferes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(23, 40);
            label1.Name = "label1";
            label1.Size = new Size(389, 27);
            label1.TabIndex = 0;
            label1.Text = "Listado de Choferes - Camioncitos S.A";
            // 
            // dtgListadoChoferes
            // 
            dtgListadoChoferes.AllowUserToAddRows = false;
            dtgListadoChoferes.AllowUserToDeleteRows = false;
            dtgListadoChoferes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListadoChoferes.Location = new Point(28, 86);
            dtgListadoChoferes.Name = "dtgListadoChoferes";
            dtgListadoChoferes.ReadOnly = true;
            dtgListadoChoferes.RowTemplate.Height = 25;
            dtgListadoChoferes.Size = new Size(694, 300);
            dtgListadoChoferes.TabIndex = 1;
            // 
            // FormListadoChoferes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgListadoChoferes);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormListadoChoferes";
            Text = "FormListadoChoferes";
            Load += FormListadoChoferes_Load;
            ((System.ComponentModel.ISupportInitialize)dtgListadoChoferes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgListadoChoferes;
    }
}