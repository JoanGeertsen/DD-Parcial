namespace DD_Parcial
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
            cbTipoProducto = new ComboBox();
            pCafe = new Panel();
            tOrigen = new TextBox();
            label2 = new Label();
            cbTueste = new ComboBox();
            tNombre = new TextBox();
            mtPrecio = new MaskedTextBox();
            dtFechaIncorporacion = new DateTimePicker();
            nudStock = new NumericUpDown();
            label1 = new Label();
            bGuardar = new Button();
            chMolido = new CheckBox();
            pCafe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
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
            // 
            // pCafe
            // 
            pCafe.BackColor = Color.Tan;
            pCafe.Controls.Add(chMolido);
            pCafe.Controls.Add(tOrigen);
            pCafe.Controls.Add(label2);
            pCafe.Controls.Add(cbTueste);
            pCafe.Location = new Point(12, 98);
            pCafe.Name = "pCafe";
            pCafe.Size = new Size(200, 100);
            pCafe.TabIndex = 1;
            // 
            // tOrigen
            // 
            tOrigen.AutoCompleteCustomSource.AddRange(new string[] { "Colombia", "Brasil", "Perú", "Bolivia", "Etiopía" });
            tOrigen.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tOrigen.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tOrigen.Location = new Point(10, 32);
            tOrigen.Name = "tOrigen";
            tOrigen.Size = new Size(184, 23);
            tOrigen.TabIndex = 2;
            tOrigen.Text = "Origen";
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
            tNombre.Location = new Point(12, 39);
            tNombre.Name = "tNombre";
            tNombre.Size = new Size(200, 23);
            tNombre.TabIndex = 2;
            tNombre.Text = "Nombre";
            // 
            // mtPrecio
            // 
            mtPrecio.Location = new Point(129, 68);
            mtPrecio.Mask = "$";
            mtPrecio.Name = "mtPrecio";
            mtPrecio.Size = new Size(83, 23);
            mtPrecio.TabIndex = 3;
            // 
            // dtFechaIncorporacion
            // 
            dtFechaIncorporacion.Format = DateTimePickerFormat.Short;
            dtFechaIncorporacion.Location = new Point(12, 68);
            dtFechaIncorporacion.Name = "dtFechaIncorporacion";
            dtFechaIncorporacion.Size = new Size(88, 23);
            dtFechaIncorporacion.TabIndex = 4;
            dtFechaIncorporacion.Value = new DateTime(2024, 4, 16, 0, 0, 0, 0);
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
            bGuardar.FlatStyle = FlatStyle.Flat;
            bGuardar.Location = new Point(82, 202);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(130, 43);
            bGuardar.TabIndex = 7;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = false;
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
            // FCarga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(226, 262);
            Controls.Add(bGuardar);
            Controls.Add(label1);
            Controls.Add(nudStock);
            Controls.Add(dtFechaIncorporacion);
            Controls.Add(mtPrecio);
            Controls.Add(tNombre);
            Controls.Add(pCafe);
            Controls.Add(cbTipoProducto);
            Name = "FCarga";
            Text = "Carga / Modificación";
            pCafe.ResumeLayout(false);
            pCafe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
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
    }
}