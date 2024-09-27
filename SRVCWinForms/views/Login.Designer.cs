namespace SRVCWinForms.views
{
    partial class Login
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUsu = new TextBox();
            label3 = new Label();
            txtPass = new TextBox();
            btnCierra = new Button();
            btnIniciar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(2, -4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(302, 392);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(302, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(438, 392);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(457, 102);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 3;
            label1.Text = "Inicia sesion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 148);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Usuario";
            // 
            // txtUsu
            // 
            txtUsu.Location = new Point(335, 183);
            txtUsu.Name = "txtUsu";
            txtUsu.Size = new Size(279, 23);
            txtUsu.TabIndex = 5;
            txtUsu.TextChanged += txtUsu_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 230);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 6;
            label3.Text = "Contreseña";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(335, 264);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(279, 23);
            txtPass.TabIndex = 7;
            // 
            // btnCierra
            // 
            btnCierra.Location = new Point(345, 318);
            btnCierra.Name = "btnCierra";
            btnCierra.Size = new Size(75, 23);
            btnCierra.TabIndex = 8;
            btnCierra.Text = "Cerrar";
            btnCierra.UseVisualStyleBackColor = true;
            btnCierra.Click += btnCierra_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(539, 318);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(89, 23);
            btnIniciar.TabIndex = 9;
            btnIniciar.Text = "Iniciar sesión";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 387);
            Controls.Add(btnIniciar);
            Controls.Add(btnCierra);
            Controls.Add(txtPass);
            Controls.Add(label3);
            Controls.Add(txtUsu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtUsu;
        private Label label3;
        private TextBox txtPass;
        private Button btnCierra;
        private Button btnIniciar;
    }
}