﻿namespace DD_Parcial
{
    partial class FCarga
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
            components = new System.ComponentModel.Container();
            cbTipoProducto = new ComboBox();
            pCafe = new Panel();
            chMolido = new CheckBox();
            tOrigen = new TextBox();
            label2 = new Label();
            cbTueste = new ComboBox();
            tNombre = new TextBox();
            mtPrecio = new MaskedTextBox();
            dtFechaIncorporacion = new DateTimePicker();
            nudStock = new NumericUpDown();
            label1 = new Label();
            bGuardar = new Button();
            label3 = new Label();
            pTe = new Panel();
            chPresentacion = new CheckBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            pInfusion = new Panel();
            rtDescripcion = new RichTextBox();
            ep = new ErrorProvider(components);
            pCafe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            pTe.SuspendLayout();
            pInfusion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ep).BeginInit();
            SuspendLayout();
            // 
            // cbTipoProducto
            // 
            cbTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoProducto.FormattingEnabled = true;
            cbTipoProducto.Items.AddRange(new object[] { "Café para Filtrados", "Café para Espressos ", "Té", "Infusiones" });
            cbTipoProducto.Location = new Point(12, 12);
            cbTipoProducto.Name = "cbTipoProducto";
            cbTipoProducto.Size = new Size(200, 23);
            cbTipoProducto.TabIndex = 0;
            cbTipoProducto.SelectedIndexChanged += cbTipoProducto_SelectedIndexChanged;
            // 
            // pCafe
            // 
            pCafe.BackColor = Color.Tan;
            pCafe.Controls.Add(chMolido);
            pCafe.Controls.Add(tOrigen);
            pCafe.Controls.Add(label2);
            pCafe.Controls.Add(cbTueste);
            pCafe.Location = new Point(12, 96);
            pCafe.Name = "pCafe";
            pCafe.Size = new Size(200, 100);
            pCafe.TabIndex = 5;
            pCafe.Visible = false;
            // 
            // chMolido
            // 
            chMolido.AutoSize = true;
            chMolido.Location = new Point(11, 67);
            chMolido.Name = "chMolido";
            chMolido.Size = new Size(64, 19);
            chMolido.TabIndex = 3;
            chMolido.Text = "Molido";
            chMolido.UseVisualStyleBackColor = true;
            // 
            // tOrigen
            // 
            tOrigen.AutoCompleteCustomSource.AddRange(new string[] { "Colombia", "Brasil", "Perú", "Bolivia", "Etiopía" });
            tOrigen.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tOrigen.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tOrigen.ForeColor = SystemColors.InactiveCaption;
            tOrigen.Location = new Point(10, 32);
            tOrigen.Name = "tOrigen";
            tOrigen.Size = new Size(184, 23);
            tOrigen.TabIndex = 2;
            tOrigen.Text = "Origen";
            tOrigen.Enter += tOrigen_Enter;
            tOrigen.Leave += tOrigen_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 7);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Tueste:";
            // 
            // cbTueste
            // 
            cbTueste.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTueste.FormattingEnabled = true;
            cbTueste.Items.AddRange(new object[] { "Bajo", "Medio", "Alto" });
            cbTueste.Location = new Point(61, 4);
            cbTueste.Name = "cbTueste";
            cbTueste.Size = new Size(57, 23);
            cbTueste.TabIndex = 0;
            // 
            // tNombre
            // 
            tNombre.ForeColor = SystemColors.ControlDark;
            tNombre.Location = new Point(12, 39);
            tNombre.Name = "tNombre";
            tNombre.Size = new Size(200, 23);
            tNombre.TabIndex = 2;
            tNombre.Text = "Nombre";
            tNombre.Enter += tNombre_Enter;
            tNombre.Leave += tNombre_Leave;
            // 
            // mtPrecio
            // 
            mtPrecio.Location = new Point(140, 68);
            mtPrecio.Mask = "$";
            mtPrecio.Name = "mtPrecio";
            mtPrecio.Size = new Size(72, 23);
            mtPrecio.TabIndex = 3;
            // 
            // dtFechaIncorporacion
            // 
            dtFechaIncorporacion.Format = DateTimePickerFormat.Short;
            dtFechaIncorporacion.Location = new Point(52, 68);
            dtFechaIncorporacion.Name = "dtFechaIncorporacion";
            dtFechaIncorporacion.Size = new Size(78, 23);
            dtFechaIncorporacion.TabIndex = 4;
            dtFechaIncorporacion.Value = new DateTime(2024, 5, 19, 0, 0, 0, 0);
            // 
            // nudStock
            // 
            nudStock.Location = new Point(12, 204);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(64, 23);
            nudStock.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 230);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 6;
            label1.Text = "Stock";
            // 
            // bGuardar
            // 
            bGuardar.BackColor = Color.PaleGreen;
            bGuardar.Enabled = false;
            bGuardar.FlatStyle = FlatStyle.Flat;
            bGuardar.Location = new Point(82, 202);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(130, 43);
            bGuardar.TabIndex = 7;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = false;
            bGuardar.Click += bGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 71);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 8;
            label3.Text = "Venc.:";
            // 
            // pTe
            // 
            pTe.BackColor = Color.Tan;
            pTe.Controls.Add(chPresentacion);
            pTe.Controls.Add(label4);
            pTe.Controls.Add(comboBox1);
            pTe.Location = new Point(12, 96);
            pTe.Name = "pTe";
            pTe.Size = new Size(200, 100);
            pTe.TabIndex = 2;
            pTe.Visible = false;
            // 
            // chPresentacion
            // 
            chPresentacion.AutoSize = true;
            chPresentacion.Location = new Point(11, 42);
            chPresentacion.Name = "chPresentacion";
            chPresentacion.Size = new Size(132, 19);
            chPresentacion.TabIndex = 3;
            chPresentacion.Text = "Presentación en lata";
            chPresentacion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 7);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 1;
            label4.Text = "Tipo:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Verde", "Blanco", "Amarillo", "Oolong", "Negro", "Pu-erh" });
            comboBox1.Location = new Point(50, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(63, 23);
            comboBox1.TabIndex = 0;
            // 
            // pInfusion
            // 
            pInfusion.BackColor = Color.Tan;
            pInfusion.Controls.Add(rtDescripcion);
            pInfusion.Location = new Point(12, 96);
            pInfusion.Name = "pInfusion";
            pInfusion.Size = new Size(200, 100);
            pInfusion.TabIndex = 0;
            pInfusion.Visible = false;
            // 
            // rtDescripcion
            // 
            rtDescripcion.ForeColor = SystemColors.InactiveCaption;
            rtDescripcion.Location = new Point(6, 11);
            rtDescripcion.Name = "rtDescripcion";
            rtDescripcion.Size = new Size(186, 74);
            rtDescripcion.TabIndex = 2;
            rtDescripcion.Text = "Descripción...";
            rtDescripcion.Enter += rtDescripcion_Enter;
            rtDescripcion.Leave += rtDescripcion_Leave;
            // 
            // ep
            // 
            ep.ContainerControl = this;
            // 
            // FCarga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(223, 262);
            Controls.Add(pInfusion);
            Controls.Add(pCafe);
            Controls.Add(pTe);
            Controls.Add(label3);
            Controls.Add(bGuardar);
            Controls.Add(label1);
            Controls.Add(nudStock);
            Controls.Add(dtFechaIncorporacion);
            Controls.Add(mtPrecio);
            Controls.Add(tNombre);
            Controls.Add(cbTipoProducto);
            Name = "FCarga";
            Text = "Carga / Modificación";
            pCafe.ResumeLayout(false);
            pCafe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            pTe.ResumeLayout(false);
            pTe.PerformLayout();
            pInfusion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTipoProducto;
        private Panel pCafe;
        private TextBox tNombre;
        private MaskedTextBox mtPrecio;
        private DateTimePicker dtFechaIncorporacion;
        private NumericUpDown nudStock;
        private Label label1;
        private Button bGuardar;
        private TextBox tOrigen;
        private Label label2;
        private ComboBox cbTueste;
        private CheckBox chMolido;
        private Label label3;
        private Panel pTe;
        private CheckBox chPresentacion;
        private Label label4;
        private ComboBox comboBox1;
        private Panel pInfusion;
        private RichTextBox rtDescripcion;
        private ErrorProvider ep;
    }
}