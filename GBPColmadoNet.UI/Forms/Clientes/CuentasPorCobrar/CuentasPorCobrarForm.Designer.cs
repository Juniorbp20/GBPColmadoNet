namespace GBPColmadoNet.UI.Forms.Clientes.CuentasPorCobrar
{
    partial class CuentasPorCobrarForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            lblCliente = new Label();
            cmbCliente = new ComboBox();
            lblMonto = new Label();
            numericMonto = new NumericUpDown();
            lblDiasCredito = new Label();
            numericDiasCredito = new NumericUpDown();
            lblFechaVencimiento = new Label();
            dtpFechaVencimiento = new DateTimePicker();
            lblEstado = new Label();
            txtEstado = new TextBox();
            lblAbonos = new Label();
            dgvAbonos = new DataGridView();
            panelAbono = new Panel();
            lblMontoAbono = new Label();
            numericAbono = new NumericUpDown();
            btnRegistrarAbono = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            errorProviderCuenta = new ErrorProvider(components);
            lblInfoBalance = new Label();
            ((System.ComponentModel.ISupportInitialize)numericMonto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDiasCredito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAbonos).BeginInit();
            panelAbono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericAbono).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCuenta).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(180, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(187, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cuentas por Cobrar";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(30, 60);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(30, 78);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(300, 23);
            cmbCliente.TabIndex = 2;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(350, 60);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(46, 15);
            lblMonto.TabIndex = 3;
            lblMonto.Text = "Monto:";
            // 
            // numericMonto
            // 
            numericMonto.Location = new Point(350, 78);
            numericMonto.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericMonto.Name = "numericMonto";
            numericMonto.Size = new Size(150, 23);
            numericMonto.TabIndex = 4;
            // 
            // lblDiasCredito
            // 
            lblDiasCredito.AutoSize = true;
            lblDiasCredito.Location = new Point(30, 115);
            lblDiasCredito.Name = "lblDiasCredito";
            lblDiasCredito.Size = new Size(74, 15);
            lblDiasCredito.TabIndex = 5;
            lblDiasCredito.Text = "Días Crédito:";
            // 
            // numericDiasCredito
            // 
            numericDiasCredito.Location = new Point(30, 133);
            numericDiasCredito.Maximum = new decimal(new int[] { 365, 0, 0, 0 });
            numericDiasCredito.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericDiasCredito.Name = "numericDiasCredito";
            numericDiasCredito.Size = new Size(100, 23);
            numericDiasCredito.TabIndex = 6;
            numericDiasCredito.Value = new decimal(new int[] { 15, 0, 0, 0 });
            numericDiasCredito.ValueChanged += numericDiasCredito_ValueChanged;
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Location = new Point(150, 115);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(110, 15);
            lblFechaVencimiento.TabIndex = 7;
            lblFechaVencimiento.Text = "Fecha Vencimiento:";
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Format = DateTimePickerFormat.Short;
            dtpFechaVencimiento.Location = new Point(150, 133);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(130, 23);
            dtpFechaVencimiento.TabIndex = 8;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(350, 115);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 9;
            lblEstado.Text = "Estado:";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(350, 133);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(150, 23);
            txtEstado.TabIndex = 10;
            // 
            // lblAbonos
            // 
            lblAbonos.AutoSize = true;
            lblAbonos.Location = new Point(30, 170);
            lblAbonos.Name = "lblAbonos";
            lblAbonos.Size = new Size(51, 15);
            lblAbonos.TabIndex = 11;
            lblAbonos.Text = "Abonos:";
            // 
            // dgvAbonos
            // 
            dgvAbonos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAbonos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAbonos.Location = new Point(30, 188);
            dgvAbonos.Name = "dgvAbonos";
            dgvAbonos.RowHeadersVisible = false;
            dgvAbonos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAbonos.Size = new Size(470, 120);
            dgvAbonos.TabIndex = 12;
            // 
            // panelAbono
            // 
            panelAbono.Controls.Add(lblMontoAbono);
            panelAbono.Controls.Add(numericAbono);
            panelAbono.Controls.Add(btnRegistrarAbono);
            panelAbono.Location = new Point(30, 314);
            panelAbono.Name = "panelAbono";
            panelAbono.Size = new Size(470, 40);
            panelAbono.TabIndex = 13;
            // 
            // lblMontoAbono
            // 
            lblMontoAbono.AutoSize = true;
            lblMontoAbono.Location = new Point(0, 12);
            lblMontoAbono.Name = "lblMontoAbono";
            lblMontoAbono.Size = new Size(46, 15);
            lblMontoAbono.TabIndex = 0;
            lblMontoAbono.Text = "Monto:";
            // 
            // numericAbono
            // 
            numericAbono.Location = new Point(50, 8);
            numericAbono.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericAbono.Minimum = new decimal(new int[] { -999999999, 0, 0, int.MinValue });
            numericAbono.Name = "numericAbono";
            numericAbono.Size = new Size(120, 23);
            numericAbono.TabIndex = 1;
            // 
            // btnRegistrarAbono
            // 
            btnRegistrarAbono.FlatStyle = FlatStyle.System;
            btnRegistrarAbono.Location = new Point(180, 7);
            btnRegistrarAbono.Name = "btnRegistrarAbono";
            btnRegistrarAbono.Size = new Size(120, 25);
            btnRegistrarAbono.TabIndex = 2;
            btnRegistrarAbono.Text = "Registrar Abono";
            btnRegistrarAbono.UseVisualStyleBackColor = true;
            btnRegistrarAbono.Click += btnRegistrarAbono_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Teal;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(115, 370);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 35);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.System;
            btnCancelar.Location = new Point(255, 370);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 35);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProviderCuenta
            // 
            errorProviderCuenta.ContainerControl = this;
            // 
            // lblInfoBalance
            // 
            lblInfoBalance.AutoSize = true;
            lblInfoBalance.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblInfoBalance.Location = new Point(30, 355);
            lblInfoBalance.Name = "lblInfoBalance";
            lblInfoBalance.Size = new Size(0, 15);
            lblInfoBalance.TabIndex = 16;
            // 
            // CuentasPorCobrarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 430);
            Controls.Add(lblInfoBalance);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(panelAbono);
            Controls.Add(dgvAbonos);
            Controls.Add(lblAbonos);
            Controls.Add(txtEstado);
            Controls.Add(lblEstado);
            Controls.Add(dtpFechaVencimiento);
            Controls.Add(lblFechaVencimiento);
            Controls.Add(numericDiasCredito);
            Controls.Add(lblDiasCredito);
            Controls.Add(numericMonto);
            Controls.Add(lblMonto);
            Controls.Add(cmbCliente);
            Controls.Add(lblCliente);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CuentasPorCobrarForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cuentas por Cobrar";
            Load += CuentasPorCobrarForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericMonto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDiasCredito).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAbonos).EndInit();
            panelAbono.ResumeLayout(false);
            panelAbono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericAbono).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCuenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.NumericUpDown numericMonto;
        private System.Windows.Forms.Label lblDiasCredito;
        private System.Windows.Forms.NumericUpDown numericDiasCredito;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblAbonos;
        private System.Windows.Forms.DataGridView dgvAbonos;
        private System.Windows.Forms.Panel panelAbono;
        private System.Windows.Forms.Label lblMontoAbono;
        private System.Windows.Forms.NumericUpDown numericAbono;
        private System.Windows.Forms.Button btnRegistrarAbono;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProviderCuenta;
        private System.Windows.Forms.Label lblInfoBalance;
    }
}