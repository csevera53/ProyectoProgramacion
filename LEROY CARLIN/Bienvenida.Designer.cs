namespace LEROY_CARLIN
{
    partial class Bienvenida
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenida));
            pictureBox1 = new PictureBox();
            lblBienvenida = new Label();
            lblEleccion = new Label();
            btnCliente = new Button();
            lBoxTrabajador = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 452);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblBienvenida.Location = new Point(67, 9);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(672, 32);
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = "Bienvenido a la pantalla de inicio de LEROY CARLIN";
            // 
            // lblEleccion
            // 
            lblEleccion.AutoSize = true;
            lblEleccion.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEleccion.Location = new Point(202, 71);
            lblEleccion.Name = "lblEleccion";
            lblEleccion.Size = new Size(395, 23);
            lblEleccion.TabIndex = 2;
            lblEleccion.Text = "Elija si entrar como cliente o como trabajador";
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(202, 259);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(94, 29);
            btnCliente.TabIndex = 3;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // lBoxTrabajador
            // 
            lBoxTrabajador.FormattingEnabled = true;
            lBoxTrabajador.ItemHeight = 20;
            lBoxTrabajador.Items.AddRange(new object[] { "Empleado", "Encargado", "Gerente" });
            lBoxTrabajador.Location = new Point(447, 259);
            lBoxTrabajador.Name = "lBoxTrabajador";
            lBoxTrabajador.Size = new Size(150, 64);
            lBoxTrabajador.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lBoxTrabajador);
            Controls.Add(btnCliente);
            Controls.Add(lblEleccion);
            Controls.Add(lblBienvenida);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblBienvenida;
        private Label lblEleccion;
        private Button btnCliente;
        private ListBox lBoxTrabajador;
    }
}