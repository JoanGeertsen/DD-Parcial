namespace DD_Parcial
{
    partial class FAcercaDe
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
            pictureBox = new PictureBox();
            label2 = new Label();
            bCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(218, 96, 15);
            label1.Location = new Point(43, 9);
            label1.Name = "label1";
            label1.Size = new Size(281, 46);
            label1.TabIndex = 0;
            label1.Text = "Joan Geertsen";
            // 
            // pictureBox
            // 
            pictureBox.Image = Properties.Resources._2;
            pictureBox.Location = new Point(66, 86);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(235, 311);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(243, 204, 88);
            label2.Location = new Point(107, 55);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 2;
            label2.Text = "Legajo: 901537";
            // 
            // bCerrar
            // 
            bCerrar.BackColor = Color.FromArgb(155, 133, 91);
            bCerrar.Dock = DockStyle.Bottom;
            bCerrar.FlatStyle = FlatStyle.Flat;
            bCerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bCerrar.Location = new Point(0, 418);
            bCerrar.Name = "bCerrar";
            bCerrar.Size = new Size(364, 32);
            bCerrar.TabIndex = 3;
            bCerrar.Text = "Cerrar";
            bCerrar.UseVisualStyleBackColor = false;
            bCerrar.Click += bCerrar_Click;
            // 
            // FAcercaDe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 91, 108);
            ClientSize = new Size(364, 450);
            Controls.Add(bCerrar);
            Controls.Add(label2);
            Controls.Add(pictureBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FAcercaDe";
            Text = "Acerca de";
            MouseDown += FAcercaDe_MouseDown;
            MouseMove += FAcercaDe_MouseMove;
            MouseUp += FAcercaDe_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox;
        private Label label2;
        private Button bCerrar;
    }
}