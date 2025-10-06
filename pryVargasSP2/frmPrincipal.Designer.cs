namespace pryVargasSP2
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            lblTipoCabaña = new Label();
            lblTipo = new Label();
            lblPersonas = new Label();
            lblDias = new Label();
            cmbCabaña = new ComboBox();
            nudPersonas = new NumericUpDown();
            nudDias = new NumericUpDown();
            lblAdicionales = new Label();
            lblFormaDePago = new Label();
            optEfectivo = new RadioButton();
            optTarjeta = new RadioButton();
            lblTarjetas = new Label();
            cmbTarjeta = new ComboBox();
            lblTitularReserva = new Label();
            lblNombre = new Label();
            lblTelefono = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            btnAceptar = new Button();
            chkCocina = new CheckBox();
            chkHeladera = new CheckBox();
            chkTelevisor = new CheckBox();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDias).BeginInit();
            SuspendLayout();
            // 
            // lblTipoCabaña
            // 
            lblTipoCabaña.BorderStyle = BorderStyle.Fixed3D;
            lblTipoCabaña.Location = new Point(12, 16);
            lblTipoCabaña.Name = "lblTipoCabaña";
            lblTipoCabaña.Size = new Size(555, 89);
            lblTipoCabaña.TabIndex = 0;
            lblTipoCabaña.Text = "Tipo de cabaña";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(29, 61);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo";
            // 
            // lblPersonas
            // 
            lblPersonas.AutoSize = true;
            lblPersonas.Location = new Point(221, 61);
            lblPersonas.Name = "lblPersonas";
            lblPersonas.Size = new Size(54, 15);
            lblPersonas.TabIndex = 2;
            lblPersonas.Text = "Personas";
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(394, 61);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(29, 15);
            lblDias.TabIndex = 3;
            lblDias.Text = "Días";
            // 
            // cmbCabaña
            // 
            cmbCabaña.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCabaña.FormattingEnabled = true;
            cmbCabaña.Items.AddRange(new object[] { "A", "B" });
            cmbCabaña.Location = new Point(65, 53);
            cmbCabaña.Name = "cmbCabaña";
            cmbCabaña.Size = new Size(121, 23);
            cmbCabaña.TabIndex = 0;
            cmbCabaña.SelectedIndexChanged += cmbCabaña_SelectedIndexChanged;
            // 
            // nudPersonas
            // 
            nudPersonas.Location = new Point(281, 53);
            nudPersonas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPersonas.Name = "nudPersonas";
            nudPersonas.Size = new Size(53, 23);
            nudPersonas.TabIndex = 1;
            nudPersonas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudDias
            // 
            nudDias.Location = new Point(429, 53);
            nudDias.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDias.Name = "nudDias";
            nudDias.Size = new Size(54, 23);
            nudDias.TabIndex = 2;
            nudDias.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblAdicionales
            // 
            lblAdicionales.BorderStyle = BorderStyle.Fixed3D;
            lblAdicionales.Location = new Point(12, 122);
            lblAdicionales.Name = "lblAdicionales";
            lblAdicionales.Size = new Size(123, 105);
            lblAdicionales.TabIndex = 7;
            lblAdicionales.Text = "Adicionales";
            // 
            // lblFormaDePago
            // 
            lblFormaDePago.BorderStyle = BorderStyle.Fixed3D;
            lblFormaDePago.Location = new Point(141, 122);
            lblFormaDePago.Name = "lblFormaDePago";
            lblFormaDePago.Size = new Size(426, 105);
            lblFormaDePago.TabIndex = 9;
            lblFormaDePago.Text = "Forma de Pago";
            // 
            // optEfectivo
            // 
            optEfectivo.AutoSize = true;
            optEfectivo.Location = new Point(156, 147);
            optEfectivo.Name = "optEfectivo";
            optEfectivo.Size = new Size(67, 19);
            optEfectivo.TabIndex = 6;
            optEfectivo.TabStop = true;
            optEfectivo.Text = "Efectivo";
            optEfectivo.UseVisualStyleBackColor = true;
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Location = new Point(156, 172);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(59, 19);
            optTarjeta.TabIndex = 7;
            optTarjeta.TabStop = true;
            optTarjeta.Text = "Tarjeta";
            optTarjeta.UseVisualStyleBackColor = true;
            optTarjeta.CheckedChanged += btnTarjeta_CheckedChanged;
            // 
            // lblTarjetas
            // 
            lblTarjetas.AutoSize = true;
            lblTarjetas.Location = new Point(360, 172);
            lblTarjetas.Name = "lblTarjetas";
            lblTarjetas.Size = new Size(46, 15);
            lblTarjetas.TabIndex = 12;
            lblTarjetas.Text = "Tarjetas";
            // 
            // cmbTarjeta
            // 
            cmbTarjeta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTarjeta.FormattingEnabled = true;
            cmbTarjeta.Items.AddRange(new object[] { "Card Red", "Card Green", "Card Blue" });
            cmbTarjeta.Location = new Point(360, 190);
            cmbTarjeta.Name = "cmbTarjeta";
            cmbTarjeta.Size = new Size(169, 23);
            cmbTarjeta.TabIndex = 8;
            // 
            // lblTitularReserva
            // 
            lblTitularReserva.BorderStyle = BorderStyle.Fixed3D;
            lblTitularReserva.Location = new Point(12, 240);
            lblTitularReserva.Name = "lblTitularReserva";
            lblTitularReserva.Size = new Size(555, 87);
            lblTitularReserva.TabIndex = 14;
            lblTitularReserva.Text = "Titular de la Reserva";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(28, 266);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 15;
            lblNombre.Text = "Nombre";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(29, 301);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(57, 15);
            lblTelefono.TabIndex = 16;
            lblTelefono.Text = "Teléfonos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(101, 266);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(428, 23);
            txtNombre.TabIndex = 9;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Enabled = false;
            txtTelefono.Location = new Point(101, 298);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(428, 23);
            txtTelefono.TabIndex = 10;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Enabled = false;
            btnAceptar.Font = new Font("Segoe UI", 12F);
            btnAceptar.Location = new Point(465, 345);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(102, 38);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // chkCocina
            // 
            chkCocina.AutoSize = true;
            chkCocina.Location = new Point(23, 147);
            chkCocina.Name = "chkCocina";
            chkCocina.Size = new Size(63, 19);
            chkCocina.TabIndex = 3;
            chkCocina.Text = "Cocina";
            chkCocina.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            chkHeladera.AutoSize = true;
            chkHeladera.Location = new Point(23, 168);
            chkHeladera.Name = "chkHeladera";
            chkHeladera.Size = new Size(73, 19);
            chkHeladera.TabIndex = 4;
            chkHeladera.Text = "Heladera";
            chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkTelevisor
            // 
            chkTelevisor.AutoSize = true;
            chkTelevisor.Location = new Point(23, 190);
            chkTelevisor.Name = "chkTelevisor";
            chkTelevisor.Size = new Size(71, 19);
            chkTelevisor.TabIndex = 5;
            chkTelevisor.Text = "Televisor";
            chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(357, 346);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 38);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 396);
            Controls.Add(btnCancelar);
            Controls.Add(chkTelevisor);
            Controls.Add(chkHeladera);
            Controls.Add(chkCocina);
            Controls.Add(btnAceptar);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(lblTelefono);
            Controls.Add(lblNombre);
            Controls.Add(lblTitularReserva);
            Controls.Add(cmbTarjeta);
            Controls.Add(lblTarjetas);
            Controls.Add(optTarjeta);
            Controls.Add(optEfectivo);
            Controls.Add(lblFormaDePago);
            Controls.Add(lblAdicionales);
            Controls.Add(nudDias);
            Controls.Add(nudPersonas);
            Controls.Add(cmbCabaña);
            Controls.Add(lblDias);
            Controls.Add(lblPersonas);
            Controls.Add(lblTipo);
            Controls.Add(lblTipoCabaña);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservas de cabañas";
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)nudPersonas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipoCabaña;
        private Label lblTipo;
        private Label lblPersonas;
        private Label lblDias;
        private ComboBox cmbCabaña;
        private NumericUpDown nudPersonas;
        private NumericUpDown nudDias;
        private Label lblAdicionales;
        private Label lblFormaDePago;
        private RadioButton optEfectivo;
        private RadioButton optTarjeta;
        private Label lblTarjetas;
        private ComboBox cmbTarjeta;
        private Label lblTitularReserva;
        private Label lblNombre;
        private Label lblTelefono;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private Button btnAceptar;
        private CheckBox chkCocina;
        private CheckBox chkHeladera;
        private CheckBox chkTelevisor;
        private Button btnCancelar;
    }
}
