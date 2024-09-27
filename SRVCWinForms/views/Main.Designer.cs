namespace SRVCWinForms.views
{
    partial class Main
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnGeneral = new Button();
            btnIngresos = new Button();
            btnHistoria = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 449);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(261, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(538, 100);
            panel1.TabIndex = 1;
            // 
            // btnGeneral
            // 
            btnGeneral.Location = new Point(35, 27);
            btnGeneral.Name = "btnGeneral";
            btnGeneral.Size = new Size(186, 49);
            btnGeneral.TabIndex = 2;
            btnGeneral.Text = "Panel General";
            btnGeneral.UseVisualStyleBackColor = true;
            // 
            // btnIngresos
            // 
            btnIngresos.Location = new Point(35, 126);
            btnIngresos.Name = "btnIngresos";
            btnIngresos.Size = new Size(186, 49);
            btnIngresos.TabIndex = 3;
            btnIngresos.Text = "INGRESOS";
            btnIngresos.UseVisualStyleBackColor = true;
            // 
            // btnHistoria
            // 
            btnHistoria.Location = new Point(35, 203);
            btnHistoria.Name = "btnHistoria";
            btnHistoria.Size = new Size(186, 49);
            btnHistoria.TabIndex = 4;
            btnHistoria.Text = "Historia";
            btnHistoria.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(35, 280);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(186, 49);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditar);
            Controls.Add(btnHistoria);
            Controls.Add(btnIngresos);
            Controls.Add(btnGeneral);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnGeneral;
        private Button btnIngresos;
        private Button btnHistoria;
        private Button btnEditar;
        private Button button5;
    }
}