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
            components = new System.ComponentModel.Container();
            cbTipoProducto = new ComboBox();
            pCafe = new Panel();
            chMolido = new CheckBox();
            tOrigen = new TextBox();
            label2 = new Label();
            cbTueste = new ComboBox();
            pInfusion = new Panel();
            rtDescripcion = new RichTextBox();
            tNombre = new TextBox();
            dtFechaVencimiento = new DateTimePicker();
            nudStock = new NumericUpDown();
            label1 = new Label();
            bGuardar = new Button();
            label3 = new Label();
            pTe = new Panel();
            chPresentacion = new CheckBox();
            label4 = new Label();
            cbTipoTe = new ComboBox();
            ep = new ErrorProvider(components);
            label5 = new Label();
            tPrecio = new TextBox();
            tCodigo = new TextBox();
            chAzucar = new CheckBox();
            pCafe.SuspendLayout();
            pInfusion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            pTe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ep).BeginInit();
            SuspendLayout();
            // 
            // cbTipoProducto
            // 
            cbTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoProducto.FormattingEnabled = true;
            cbTipoProducto.Items.AddRange(new object[] { "Café para Filtrados", "Café para Espressos ", "Té", "Infusiones" });
            cbTipoProducto.Location = new Point(17, 20);
            cbTipoProducto.Margin = new Padding(4, 5, 4, 5);
            cbTipoProducto.Name = "cbTipoProducto";
            cbTipoProducto.Size = new Size(190, 33);
            cbTipoProducto.TabIndex = 0;
            cbTipoProducto.SelectedIndexChanged += cbTipoProducto_SelectedIndexChanged;
            cbTipoProducto.Validating += cbTipoProducto_Validating;
            // 
            // pCafe
            // 
            pCafe.BackColor = Color.Tan;
            pCafe.Controls.Add(chAzucar);
            pCafe.Controls.Add(chMolido);
            pCafe.Controls.Add(tOrigen);
            pCafe.Controls.Add(label2);
            pCafe.Controls.Add(cbTueste);
            pCafe.Location = new Point(17, 162);
            pCafe.Margin = new Padding(4, 5, 4, 5);
            pCafe.Name = "pCafe";
            pCafe.Size = new Size(300, 167);
            pCafe.TabIndex = 5;
            pCafe.Visible = false;
            // 
            // chMolido
            // 
            chMolido.AutoSize = true;
            chMolido.Location = new Point(16, 112);
            chMolido.Margin = new Padding(4, 5, 4, 5);
            chMolido.Name = "chMolido";
            chMolido.Size = new Size(95, 29);
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
            tOrigen.Location = new Point(14, 53);
            tOrigen.Margin = new Padding(4, 5, 4, 5);
            tOrigen.Name = "tOrigen";
            tOrigen.Size = new Size(261, 31);
            tOrigen.TabIndex = 2;
            tOrigen.Text = "Origen";
            tOrigen.Enter += tOrigen_Enter;
            tOrigen.Leave += tOrigen_Leave;
            tOrigen.Validating += tOrigen_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 12);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 1;
            label2.Text = "Tueste:";
            // 
            // cbTueste
            // 
            cbTueste.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTueste.FormattingEnabled = true;
            cbTueste.Items.AddRange(new object[] { "Bajo", "Medio", "Alto" });
            cbTueste.Location = new Point(87, 7);
            cbTueste.Margin = new Padding(4, 5, 4, 5);
            cbTueste.Name = "cbTueste";
            cbTueste.Size = new Size(80, 33);
            cbTueste.TabIndex = 0;
            cbTueste.Validating += cbTueste_Validating;
            // 
            // pInfusion
            // 
            pInfusion.BackColor = Color.Tan;
            pInfusion.Controls.Add(rtDescripcion);
            pInfusion.Location = new Point(15, 158);
            pInfusion.Margin = new Padding(4, 5, 4, 5);
            pInfusion.Name = "pInfusion";
            pInfusion.Size = new Size(300, 167);
            pInfusion.TabIndex = 0;
            pInfusion.Visible = false;
            // 
            // rtDescripcion
            // 
            rtDescripcion.ForeColor = SystemColors.InactiveCaption;
            rtDescripcion.Location = new Point(9, 18);
            rtDescripcion.Margin = new Padding(4, 5, 4, 5);
            rtDescripcion.Name = "rtDescripcion";
            rtDescripcion.Size = new Size(264, 121);
            rtDescripcion.TabIndex = 2;
            rtDescripcion.Text = "Descripción...";
            rtDescripcion.Enter += rtDescripcion_Enter;
            rtDescripcion.Leave += rtDescripcion_Leave;
            rtDescripcion.Validating += rtDescripcion_Validating;
            // 
            // tNombre
            // 
            tNombre.ForeColor = SystemColors.ControlDark;
            tNombre.Location = new Point(17, 65);
            tNombre.Margin = new Padding(4, 5, 4, 5);
            tNombre.Name = "tNombre";
            tNombre.Size = new Size(298, 31);
            tNombre.TabIndex = 2;
            tNombre.Text = "Nombre";
            tNombre.Enter += tNombre_Enter;
            tNombre.Leave += tNombre_Leave;
            tNombre.Validating += tNombre_Validating;
            // 
            // dtFechaVencimiento
            // 
            dtFechaVencimiento.CustomFormat = "dd/MM/yyyy";
            dtFechaVencimiento.Format = DateTimePickerFormat.Short;
            dtFechaVencimiento.Location = new Point(74, 113);
            dtFechaVencimiento.Margin = new Padding(4, 5, 4, 5);
            dtFechaVencimiento.Name = "dtFechaVencimiento";
            dtFechaVencimiento.Size = new Size(110, 31);
            dtFechaVencimiento.TabIndex = 4;
            dtFechaVencimiento.Value = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            dtFechaVencimiento.Validating += dtFechaVencimiento_Validating;
            // 
            // nudStock
            // 
            nudStock.Location = new Point(17, 340);
            nudStock.Margin = new Padding(4, 5, 4, 5);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(91, 31);
            nudStock.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 383);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 6;
            label1.Text = "Stock";
            // 
            // bGuardar
            // 
            bGuardar.BackColor = Color.PaleGreen;
            bGuardar.FlatStyle = FlatStyle.Flat;
            bGuardar.Location = new Point(131, 337);
            bGuardar.Margin = new Padding(4, 5, 4, 5);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(186, 72);
            bGuardar.TabIndex = 7;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = false;
            bGuardar.Click += bGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 118);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 8;
            label3.Text = "Venc.:";
            // 
            // pTe
            // 
            pTe.BackColor = Color.Tan;
            pTe.Controls.Add(chPresentacion);
            pTe.Controls.Add(label4);
            pTe.Controls.Add(cbTipoTe);
            pTe.Location = new Point(17, 163);
            pTe.Margin = new Padding(4, 5, 4, 5);
            pTe.Name = "pTe";
            pTe.Size = new Size(300, 167);
            pTe.TabIndex = 2;
            pTe.Visible = false;
            // 
            // chPresentacion
            // 
            chPresentacion.AutoSize = true;
            chPresentacion.Location = new Point(16, 70);
            chPresentacion.Margin = new Padding(4, 5, 4, 5);
            chPresentacion.Name = "chPresentacion";
            chPresentacion.Size = new Size(195, 29);
            chPresentacion.TabIndex = 3;
            chPresentacion.Text = "Presentación en lata";
            chPresentacion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 12);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 25);
            label4.TabIndex = 1;
            label4.Text = "Tipo:";
            // 
            // cbTipoTe
            // 
            cbTipoTe.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoTe.FormattingEnabled = true;
            cbTipoTe.Items.AddRange(new object[] { "Verde", "Blanco", "Amarillo", "Oolong", "Negro", "Pu-erh" });
            cbTipoTe.Location = new Point(71, 7);
            cbTipoTe.Margin = new Padding(4, 5, 4, 5);
            cbTipoTe.Name = "cbTipoTe";
            cbTipoTe.Size = new Size(131, 33);
            cbTipoTe.TabIndex = 0;
            cbTipoTe.Validating += cbTipoTe_Validating;
            // 
            // ep
            // 
            ep.ContainerControl = this;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(194, 120);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(22, 25);
            label5.TabIndex = 9;
            label5.Text = "$";
            // 
            // tPrecio
            // 
            tPrecio.BackColor = Color.WhiteSmoke;
            tPrecio.ForeColor = SystemColors.InactiveCaption;
            tPrecio.Location = new Point(217, 113);
            tPrecio.Margin = new Padding(4, 5, 4, 5);
            tPrecio.Name = "tPrecio";
            tPrecio.Size = new Size(98, 31);
            tPrecio.TabIndex = 10;
            tPrecio.Text = "0";
            tPrecio.Enter += tPrecio_Enter;
            tPrecio.KeyPress += tPrecio_KeyPress;
            tPrecio.Leave += tPrecio_Leave;
            tPrecio.Validating += tPrecio_Validating;
            // 
            // tCodigo
            // 
            tCodigo.BackColor = Color.WhiteSmoke;
            tCodigo.ForeColor = SystemColors.InactiveCaption;
            tCodigo.Location = new Point(234, 20);
            tCodigo.Margin = new Padding(4, 5, 4, 5);
            tCodigo.Name = "tCodigo";
            tCodigo.Size = new Size(81, 31);
            tCodigo.TabIndex = 11;
            tCodigo.Text = "Código";
            tCodigo.Enter += tCodigo_Enter;
            tCodigo.KeyPress += tCodigo_KeyPress;
            tCodigo.Leave += tCodigo_Leave;
            tCodigo.Validated += tCodigo_Validated;
            // 
            // chAzucar
            // 
            chAzucar.AutoSize = true;
            chAzucar.Location = new Point(116, 112);
            chAzucar.Margin = new Padding(4, 5, 4, 5);
            chAzucar.Name = "chAzucar";
            chAzucar.Size = new Size(163, 29);
            chAzucar.TabIndex = 4;
            chAzucar.Text = "Contiene azúcar";
            chAzucar.UseVisualStyleBackColor = true;
            // 
            // FCarga
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 437);
            Controls.Add(tCodigo);
            Controls.Add(tPrecio);
            Controls.Add(label5);
            Controls.Add(pInfusion);
            Controls.Add(pCafe);
            Controls.Add(pTe);
            Controls.Add(label3);
            Controls.Add(bGuardar);
            Controls.Add(label1);
            Controls.Add(nudStock);
            Controls.Add(dtFechaVencimiento);
            Controls.Add(tNombre);
            Controls.Add(cbTipoProducto);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FCarga";
            Text = "Carga / Modificación";
            pCafe.ResumeLayout(false);
            pCafe.PerformLayout();
            pInfusion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            pTe.ResumeLayout(false);
            pTe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTipoProducto;
        private Panel pCafe;
        private TextBox tNombre;
        private DateTimePicker dtFechaVencimiento;
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
        private ComboBox cbTipoTe;
        private Panel pInfusion;
        private RichTextBox rtDescripcion;
        private ErrorProvider ep;
        private TextBox tPrecio;
        private Label label5;
        private TextBox tCodigo;
        private CheckBox chAzucar;
    }
}