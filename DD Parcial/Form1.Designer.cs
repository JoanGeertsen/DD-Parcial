﻿namespace DD_Parcial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrincipal));
            lbProductos = new ListBox();
            cbFiltros = new ComboBox();
            pCafe = new Panel();
            cbTueste = new ComboBox();
            chEspresso = new CheckBox();
            chFiltro = new CheckBox();
            label1 = new Label();
            pDatos = new Panel();
            lCantidadTotal = new Label();
            lCantidadEnPantalla = new Label();
            bAgregar = new Button();
            bModificar = new Button();
            bEliminar = new Button();
            bSalir = new Button();
            bAcercaDe = new Button();
            pTe = new Panel();
            rbSobre = new RadioButton();
            rbLata = new RadioButton();
            rbCualquiea = new RadioButton();
            cbTipoTe = new ComboBox();
            label2 = new Label();
            pCafe.SuspendLayout();
            pDatos.SuspendLayout();
            pTe.SuspendLayout();
            SuspendLayout();
            // 
            // lbProductos
            // 
            lbProductos.FormattingEnabled = true;
            lbProductos.HorizontalExtent = 800;
            lbProductos.HorizontalScrollbar = true;
            lbProductos.ItemHeight = 25;
            lbProductos.Location = new Point(12, 12);
            lbProductos.Name = "lbProductos";
            lbProductos.Size = new Size(381, 379);
            lbProductos.TabIndex = 0;
            // 
            // cbFiltros
            // 
            cbFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltros.FormattingEnabled = true;
            cbFiltros.Items.AddRange(new object[] { "Productos (TODOS)", "Café", "Té", "Infusiones" });
            cbFiltros.Location = new Point(429, 18);
            cbFiltros.Name = "cbFiltros";
            cbFiltros.Size = new Size(242, 33);
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
            pCafe.Location = new Point(429, 57);
            pCafe.Name = "pCafe";
            pCafe.Size = new Size(242, 137);
            pCafe.TabIndex = 2;
            // 
            // cbTueste
            // 
            cbTueste.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTueste.FormattingEnabled = true;
            cbTueste.Items.AddRange(new object[] { "Todos", "Tueste bajo", "Tueste medio", "Tueste alto" });
            cbTueste.Location = new Point(9, 94);
            cbTueste.Name = "cbTueste";
            cbTueste.Size = new Size(196, 33);
            cbTueste.TabIndex = 7;
            cbTueste.SelectedIndexChanged += cbTueste_SelectedIndexChanged;
            // 
            // chEspresso
            // 
            chEspresso.AutoSize = true;
            chEspresso.Checked = true;
            chEspresso.CheckState = CheckState.Checked;
            chEspresso.Location = new Point(9, 59);
            chEspresso.Name = "chEspresso";
            chEspresso.Size = new Size(151, 29);
            chEspresso.TabIndex = 6;
            chEspresso.Text = "Perfil espresso";
            chEspresso.UseVisualStyleBackColor = true;
            chEspresso.CheckedChanged += chEspresso_CheckedChanged;
            // 
            // chFiltro
            // 
            chFiltro.AutoSize = true;
            chFiltro.Checked = true;
            chFiltro.CheckState = CheckState.Checked;
            chFiltro.Location = new Point(9, 31);
            chFiltro.Name = "chFiltro";
            chFiltro.Size = new Size(146, 29);
            chFiltro.TabIndex = 5;
            chFiltro.Text = "Perfil filtrados";
            chFiltro.UseVisualStyleBackColor = true;
            chFiltro.CheckedChanged += chFiltro_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 8);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 4;
            label1.Text = "Café";
            // 
            // pDatos
            // 
            pDatos.BackColor = Color.Wheat;
            pDatos.Controls.Add(lCantidadTotal);
            pDatos.Controls.Add(lCantidadEnPantalla);
            pDatos.Location = new Point(429, 340);
            pDatos.Name = "pDatos";
            pDatos.Size = new Size(242, 71);
            pDatos.TabIndex = 4;
            // 
            // lCantidadTotal
            // 
            lCantidadTotal.AutoSize = true;
            lCantidadTotal.Location = new Point(6, 10);
            lCantidadTotal.Name = "lCantidadTotal";
            lCantidadTotal.Size = new Size(199, 25);
            lCantidadTotal.TabIndex = 10;
            lCantidadTotal.Text = "Cantidad de productos:";
            // 
            // lCantidadEnPantalla
            // 
            lCantidadEnPantalla.AutoSize = true;
            lCantidadEnPantalla.Location = new Point(6, 33);
            lCantidadEnPantalla.Name = "lCantidadEnPantalla";
            lCantidadEnPantalla.Size = new Size(174, 25);
            lCantidadEnPantalla.TabIndex = 9;
            lCantidadEnPantalla.Text = "Cantidad en pantalla";
            // 
            // bAgregar
            // 
            bAgregar.BackColor = Color.PaleGreen;
            bAgregar.FlatStyle = FlatStyle.Flat;
            bAgregar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            bAgregar.ForeColor = SystemColors.ActiveCaptionText;
            bAgregar.Location = new Point(12, 417);
            bAgregar.Name = "bAgregar";
            bAgregar.Size = new Size(118, 46);
            bAgregar.TabIndex = 0;
            bAgregar.Text = "Agregar";
            bAgregar.UseVisualStyleBackColor = false;
            bAgregar.Click += bAgregar_Click;
            // 
            // bModificar
            // 
            bModificar.BackColor = Color.Khaki;
            bModificar.FlatStyle = FlatStyle.Flat;
            bModificar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            bModificar.ForeColor = SystemColors.ActiveCaptionText;
            bModificar.Location = new Point(275, 417);
            bModificar.Name = "bModificar";
            bModificar.Size = new Size(118, 46);
            bModificar.TabIndex = 5;
            bModificar.Text = "Modificar";
            bModificar.UseVisualStyleBackColor = false;
            bModificar.Click += bModificar_Click;
            // 
            // bEliminar
            // 
            bEliminar.BackColor = Color.IndianRed;
            bEliminar.FlatStyle = FlatStyle.Flat;
            bEliminar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            bEliminar.ForeColor = SystemColors.ActiveCaptionText;
            bEliminar.Location = new Point(144, 417);
            bEliminar.Name = "bEliminar";
            bEliminar.Size = new Size(118, 46);
            bEliminar.TabIndex = 6;
            bEliminar.Text = "Eliminar";
            bEliminar.UseVisualStyleBackColor = false;
            bEliminar.Click += bEliminar_Click;
            // 
            // bSalir
            // 
            bSalir.BackColor = Color.WhiteSmoke;
            bSalir.FlatStyle = FlatStyle.Flat;
            bSalir.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bSalir.Location = new Point(429, 417);
            bSalir.Name = "bSalir";
            bSalir.Size = new Size(118, 46);
            bSalir.TabIndex = 7;
            bSalir.Text = "Salir";
            bSalir.UseVisualStyleBackColor = false;
            bSalir.Click += bSalir_Click;
            // 
            // bAcercaDe
            // 
            bAcercaDe.BackColor = Color.WhiteSmoke;
            bAcercaDe.FlatStyle = FlatStyle.Flat;
            bAcercaDe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bAcercaDe.Location = new Point(553, 417);
            bAcercaDe.Name = "bAcercaDe";
            bAcercaDe.Size = new Size(118, 46);
            bAcercaDe.TabIndex = 8;
            bAcercaDe.Text = "Acerca de";
            bAcercaDe.UseVisualStyleBackColor = false;
            bAcercaDe.Click += bAcercaDe_Click;
            // 
            // pTe
            // 
            pTe.BackColor = Color.Tan;
            pTe.Controls.Add(rbSobre);
            pTe.Controls.Add(rbLata);
            pTe.Controls.Add(rbCualquiea);
            pTe.Controls.Add(cbTipoTe);
            pTe.Controls.Add(label2);
            pTe.Enabled = false;
            pTe.Location = new Point(429, 200);
            pTe.Name = "pTe";
            pTe.Size = new Size(242, 137);
            pTe.TabIndex = 8;
            // 
            // rbSobre
            // 
            rbSobre.AutoSize = true;
            rbSobre.Location = new Point(96, 96);
            rbSobre.Name = "rbSobre";
            rbSobre.Size = new Size(84, 29);
            rbSobre.TabIndex = 10;
            rbSobre.Text = "Sobre";
            rbSobre.UseVisualStyleBackColor = true;
            rbSobre.CheckedChanged += rbSobre_CheckedChanged;
            // 
            // rbLata
            // 
            rbLata.AutoSize = true;
            rbLata.Location = new Point(9, 96);
            rbLata.Name = "rbLata";
            rbLata.Size = new Size(69, 29);
            rbLata.TabIndex = 9;
            rbLata.Text = "Lata";
            rbLata.UseVisualStyleBackColor = true;
            rbLata.CheckedChanged += rbLata_CheckedChanged;
            // 
            // rbCualquiea
            // 
            rbCualquiea.AutoSize = true;
            rbCualquiea.Checked = true;
            rbCualquiea.Location = new Point(9, 66);
            rbCualquiea.Name = "rbCualquiea";
            rbCualquiea.Size = new Size(217, 29);
            rbCualquiea.TabIndex = 11;
            rbCualquiea.TabStop = true;
            rbCualquiea.Text = "Cualquier presentación";
            rbCualquiea.UseVisualStyleBackColor = true;
            rbCualquiea.CheckedChanged += rbCualquiea_CheckedChanged;
            // 
            // cbTipoTe
            // 
            cbTipoTe.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoTe.FormattingEnabled = true;
            cbTipoTe.Items.AddRange(new object[] { "TODOS", "Verde", "Blanco", "Amarillo", "Oolong", "Negro", "Pu-erh" });
            cbTipoTe.Location = new Point(38, 13);
            cbTipoTe.Name = "cbTipoTe";
            cbTipoTe.Size = new Size(167, 33);
            cbTipoTe.TabIndex = 8;
            cbTipoTe.SelectedIndexChanged += cbTipoTe_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 15);
            label2.Name = "label2";
            label2.Size = new Size(28, 25);
            label2.TabIndex = 4;
            label2.Text = "Té";
            // 
            // FPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 482);
            Controls.Add(pTe);
            Controls.Add(bAcercaDe);
            Controls.Add(bSalir);
            Controls.Add(bEliminar);
            Controls.Add(bModificar);
            Controls.Add(bAgregar);
            Controls.Add(pDatos);
            Controls.Add(pCafe);
            Controls.Add(cbFiltros);
            Controls.Add(lbProductos);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FPrincipal";
            Text = "Principal";
            pCafe.ResumeLayout(false);
            pCafe.PerformLayout();
            pDatos.ResumeLayout(false);
            pDatos.PerformLayout();
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
        private Button bAgregar;
        private Button bModificar;
        private Button bEliminar;
        private Button bSalir;
        private Button bAcercaDe;
        private ComboBox cbTueste;
        private Panel pTe;
        private ComboBox cbTipoTe;
        private Label label2;
        private RadioButton rbCualquiea;
        private RadioButton rbSobre;
        private RadioButton rbLata;
        private Label lCantidadTotal;
        private Label lCantidadEnPantalla;
    }
}