namespace CapaPresentacion
{
    partial class FormLogin
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
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnIniciarSesion = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = SystemColors.WindowFrame;
            txtUsuario.Location = new Point(100, 202);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(233, 26);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "Usuario";
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = Color.White;
            txtContrasena.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasena.ForeColor = SystemColors.WindowFrame;
            txtContrasena.Location = new Point(100, 261);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(233, 26);
            txtContrasena.TabIndex = 2;
            txtContrasena.Text = "Contraseña";
            txtContrasena.TextAlign = HorizontalAlignment.Center;
            txtContrasena.Enter += txtContrasena_Enter;
            txtContrasena.KeyPress += txtContrasena_KeyPress;
            txtContrasena.Leave += txtContrasena_Leave;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.FromArgb(68, 67, 110);
            btnIniciarSesion.Cursor = Cursors.Hand;
            btnIniciarSesion.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.Location = new Point(100, 327);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(233, 47);
            btnIniciarSesion.TabIndex = 0;
            btnIniciarSesion.Text = "Iniciar sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logocamion;
            pictureBox1.Location = new Point(110, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(235, 231, 211);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnIniciarSesion);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(txtContrasena);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(386, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 455);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(150, 147, 237);
            label2.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(74, 125);
            label2.Name = "label2";
            label2.Size = new Size(281, 37);
            label2.TabIndex = 3;
            label2.Text = "   Iniciar Sesion   ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(101, 271);
            label1.Name = "label1";
            label1.Size = new Size(173, 29);
            label1.TabIndex = 5;
            label1.Text = "Camioncitos S.A.";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.perfil;
            pictureBox2.Location = new Point(159, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(108, 99);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 455);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnIniciarSesion;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}