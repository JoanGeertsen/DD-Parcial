namespace DD_Parcial
{
    partial class FPrincipal
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
            lbProductos = new ListBox();
            cbFiltros = new ComboBox();
            pCafe = new Panel();
            chEspresso = new CheckBox();
            chFiltro = new CheckBox();
            label1 = new Label();
            pDatos = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            cbTueste = new ComboBox();
            pTe = new Panel();
            chEnLata = new CheckBox();
            label2 = new Label();
            cbTipoTe = new ComboBox();
            pCafe.SuspendLayout();
            pTe.SuspendLayout();
            SuspendLayout();
            // 
            // lbProductos
            // 
            lbProductos.FormattingEnabled = true;
            lbProductos.ItemHeight = 15;
            lbProductos.Location = new Point(12, 12);
            lbProductos.Name = "lbProductos";
            lbProductos.Size = new Size(284, 304);
            lbProductos.TabIndex = 0;
            // 
            // cbFiltros
            // 
            cbFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltros.FormattingEnabled = true;
            cbFiltros.Items.AddRange(new object[] { "Productos (TODOS)", "Café", "Té", "Infusiones" });
            cbFiltros.Location = new Point(302, 12);
            cbFiltros.Name = "cbFiltros";
            cbFiltros.Size = new Size(145, 23);
            cbFiltros.TabIndex = 1;
            cbFiltros.SelectedIndexChanged += cbFiltros_SelectedIndexChanged;
            // 
            // pCafe
            // 
            pCafe.BackColor = Color.Tan;
            pCafe.Controls.Add(cbTueste);
            pCafe.Controls.Add(chEspresso);
            pCafe.Controls.Add(chFiltro);
            pCafe.Controls.Add(label1);
            pCafe.Enabled = false;
            pCafe.Location = new Point(302, 41);
            pCafe.Name = "pCafe";
            pCafe.Size = new Size(145, 123);
            pCafe.TabIndex = 2;
            // 
            // chEspresso
            // 
            chEspresso.AutoSize = true;
            chEspresso.Checked = true;
            chEspresso.CheckState = CheckState.Checked;
            chEspresso.Location = new Point(9, 59);
            chEspresso.Name = "chEspresso";
            chEspresso.Size = new Size(101, 19);
            chEspresso.TabIndex = 6;
            chEspresso.Text = "Perfil espresso";
            chEspresso.UseVisualStyleBackColor = true;
            // 
            // chFiltro
            // 
            chFiltro.AutoSize = true;
            chFiltro.Checked = true;
            chFiltro.CheckState = CheckState.Checked;
            chFiltro.Location = new Point(9, 31);
            chFiltro.Name = "chFiltro";
            chFiltro.Size = new Size(99, 19);
            chFiltro.TabIndex = 5;
            chFiltro.Text = "Perfil filtrados";
            chFiltro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 8);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "Café";
            // 
            // pDatos
            // 
            pDatos.BackColor = Color.Wheat;
            pDatos.Location = new Point(302, 260);
            pDatos.Name = "pDatos";
            pDatos.Size = new Size(145, 56);
            pDatos.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(12, 322);
            button1.Name = "button1";
            button1.Size = new Size(84, 39);
            button1.TabIndex = 0;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Khaki;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(113, 322);
            button2.Name = "button2";
            button2.Size = new Size(84, 39);
            button2.TabIndex = 5;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(212, 322);
            button3.Name = "button3";
            button3.Size = new Size(84, 39);
            button3.TabIndex = 6;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.WhiteSmoke;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(302, 322);
            button4.Name = "button4";
            button4.Size = new Size(67, 39);
            button4.TabIndex = 7;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.WhiteSmoke;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(375, 322);
            button5.Name = "button5";
            button5.Size = new Size(72, 39);
            button5.TabIndex = 8;
            button5.Text = "Acerca de";
            button5.UseVisualStyleBackColor = false;
            // 
            // cbTueste
            // 
            cbTueste.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTueste.FormattingEnabled = true;
            cbTueste.Items.AddRange(new object[] { "Todos", "Bajo", "Medio", "Alto" });
            cbTueste.Location = new Point(9, 84);
            cbTueste.Name = "cbTueste";
            cbTueste.Size = new Size(121, 23);
            cbTueste.TabIndex = 7;
            // 
            // pTe
            // 
            pTe.BackColor = Color.Tan;
            pTe.Controls.Add(cbTipoTe);
            pTe.Controls.Add(chEnLata);
            pTe.Controls.Add(label2);
            pTe.Enabled = false;
            pTe.Location = new Point(302, 170);
            pTe.Name = "pTe";
            pTe.Size = new Size(145, 84);
            pTe.TabIndex = 8;
            // 
            // chEnLata
            // 
            chEnLata.AutoSize = true;
            chEnLata.Checked = true;
            chEnLata.CheckState = CheckState.Checked;
            chEnLata.Location = new Point(9, 55);
            chEnLata.Name = "chEnLata";
            chEnLata.Size = new Size(132, 19);
            chEnLata.TabIndex = 5;
            chEnLata.Text = "Presentación en lata";
            chEnLata.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 8);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 4;
            label2.Text = "Té";
            // 
            // cbTipoTe
            // 
            cbTipoTe.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoTe.FormattingEnabled = true;
            cbTipoTe.Items.AddRange(new object[] { "Verde", "Blanco", "Amarillo", "Oolong", "Negro", "Pu-erh" });
            cbTipoTe.Location = new Point(9, 26);
            cbTipoTe.Name = "cbTipoTe";
            cbTipoTe.Size = new Size(121, 23);
            cbTipoTe.TabIndex = 8;
            // 
            // FPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 383);
            Controls.Add(pTe);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pDatos);
            Controls.Add(pCafe);
            Controls.Add(cbFiltros);
            Controls.Add(lbProductos);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FPrincipal";
            Text = "Principal";
            pCafe.ResumeLayout(false);
            pCafe.PerformLayout();
            pTe.ResumeLayout(false);
            pTe.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbProductos;
        private ComboBox cbFiltros;
        private Panel pCafe;
        private CheckBox chEspresso;
        private CheckBox chFiltro;
        private Label label1;
        private Panel pDatos;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private ComboBox cbTueste;
        private Panel pTe;
        private ComboBox cbTipoTe;
        private CheckBox chEnLata;
        private Label label2;
    }
}