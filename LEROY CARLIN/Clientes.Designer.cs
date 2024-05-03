namespace LEROY_CARLIN
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            pictureBox1 = new PictureBox();
            lblClientes = new Label();
            textBox1 = new TextBox();
            btnRegistro = new Button();
            btnInicioSesion = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(804, 454);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblClientes.Location = new Point(227, 9);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(362, 46);
            lblClientes.TabIndex = 1;
            lblClientes.Text = "¡Bienvenido!\r\nSi es la primera vez que entras, regístrate";
            lblClientes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(227, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(227, 115);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(94, 29);
            btnRegistro.TabIndex = 3;
            btnRegistro.Text = "Registrarse";
            btnRegistro.UseVisualStyleBackColor = true;
            // 
            // btnInicioSesion
            // 
            btnInicioSesion.Location = new Point(462, 115);
            btnInicioSesion.Name = "btnInicioSesion";
            btnInicioSesion.Size = new Size(127, 29);
            btnInicioSesion.TabIndex = 4;
            btnInicioSesion.Text = "Iniciar sesión";
            btnInicioSesion.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInicioSesion);
            Controls.Add(btnRegistro);
            Controls.Add(textBox1);
            Controls.Add(lblClientes);
            Controls.Add(pictureBox1);
            Name = "Clientes";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblClientes;
        private TextBox textBox1;
        private Button btnRegistro;
        private Button btnInicioSesion;
    }
}