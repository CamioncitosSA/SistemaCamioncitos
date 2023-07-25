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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgListadoChoferes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListadoChoferes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Choferes - Camioncitos S.A";
            // 
            // dtgListadoChoferes
            // 
            this.dtgListadoChoferes.AllowUserToAddRows = false;
            this.dtgListadoChoferes.AllowUserToDeleteRows = false;
            this.dtgListadoChoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListadoChoferes.Location = new System.Drawing.Point(53, 85);
            this.dtgListadoChoferes.Name = "dtgListadoChoferes";
            this.dtgListadoChoferes.ReadOnly = true;
            this.dtgListadoChoferes.RowTemplate.Height = 25;
            this.dtgListadoChoferes.Size = new System.Drawing.Size(694, 300);
            this.dtgListadoChoferes.TabIndex = 1;
            // 
            // FormListadoChoferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgListadoChoferes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListadoChoferes";
            this.Text = "FormListadoChoferes";
            this.Load += new System.EventHandler(this.FormListadoChoferes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListadoChoferes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dtgListadoChoferes;
    }
}