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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.numericMonto = new System.Windows.Forms.NumericUpDown();
            this.lblDiasCredito = new System.Windows.Forms.Label();
            this.numericDiasCredito = new System.Windows.Forms.NumericUpDown();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblAbonos = new System.Windows.Forms.Label();
            this.dgvAbonos = new System.Windows.Forms.DataGridView();
            this.panelAbono = new System.Windows.Forms.Panel();
            this.lblMontoAbono = new System.Windows.Forms.Label();
            this.numericAbono = new System.Windows.Forms.NumericUpDown();
            this.btnRegistrarAbono = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorProviderCuenta = new System.Windows.Forms.ErrorProvider();
            this.lblInfoBalance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiasCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAbono)).BeginInit();
            this.panelAbono.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(180, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(190, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cuentas por Cobrar";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(30, 60);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(47, 15);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(30, 78);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(300, 23);
            this.cmbCliente.TabIndex = 2;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(350, 60);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 15);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.Text = "Monto:";
            // 
            // numericMonto
            // 
            this.numericMonto.Location = new System.Drawing.Point(350, 78);
            this.numericMonto.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            this.numericMonto.Name = "numericMonto";
            this.numericMonto.Size = new System.Drawing.Size(150, 23);
            this.numericMonto.TabIndex = 4;
            // 
            // lblDiasCredito
            // 
            this.lblDiasCredito.AutoSize = true;
            this.lblDiasCredito.Location = new System.Drawing.Point(30, 115);
            this.lblDiasCredito.Name = "lblDiasCredito";
            this.lblDiasCredito.Size = new System.Drawing.Size(73, 15);
            this.lblDiasCredito.TabIndex = 5;
            this.lblDiasCredito.Text = "Días Crédito:";
            // 
            // numericDiasCredito
            // 
            this.numericDiasCredito.Location = new System.Drawing.Point(30, 133);
            this.numericDiasCredito.Maximum = new decimal(new int[] { 365, 0, 0, 0 });
            this.numericDiasCredito.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericDiasCredito.Name = "numericDiasCredito";
            this.numericDiasCredito.Size = new System.Drawing.Size(100, 23);
            this.numericDiasCredito.TabIndex = 6;
            this.numericDiasCredito.Value = new decimal(new int[] { 15, 0, 0, 0 });
            this.numericDiasCredito.ValueChanged += new System.EventHandler(this.numericDiasCredito_ValueChanged);
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(150, 115);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(108, 15);
            this.lblFechaVencimiento.TabIndex = 7;
            this.lblFechaVencimiento.Text = "Fecha Vencimiento:";
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(150, 133);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(130, 23);
            this.dtpFechaVencimiento.TabIndex = 8;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(350, 115);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 15);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(350, 133);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(150, 23);
            this.txtEstado.TabIndex = 10;
            // 
            // lblAbonos
            // 
            this.lblAbonos.AutoSize = true;
            this.lblAbonos.Location = new System.Drawing.Point(30, 170);
            this.lblAbonos.Name = "lblAbonos";
            this.lblAbonos.Size = new System.Drawing.Size(51, 15);
            this.lblAbonos.TabIndex = 11;
            this.lblAbonos.Text = "Abonos:";
            // 
            // dgvAbonos
            // 
            this.dgvAbonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAbonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbonos.Location = new System.Drawing.Point(30, 188);
            this.dgvAbonos.Name = "dgvAbonos";
            this.dgvAbonos.RowHeadersVisible = false;
            this.dgvAbonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbonos.Size = new System.Drawing.Size(470, 120);
            this.dgvAbonos.TabIndex = 12;
            // 
            // panelAbono
            // 
            this.panelAbono.Controls.Add(this.lblMontoAbono);
            this.panelAbono.Controls.Add(this.numericAbono);
            this.panelAbono.Controls.Add(this.btnRegistrarAbono);
            this.panelAbono.Location = new System.Drawing.Point(30, 314);
            this.panelAbono.Name = "panelAbono";
            this.panelAbono.Size = new System.Drawing.Size(470, 40);
            this.panelAbono.TabIndex = 13;
            // 
            // lblMontoAbono
            // 
            this.lblMontoAbono.AutoSize = true;
            this.lblMontoAbono.Location = new System.Drawing.Point(0, 12);
            this.lblMontoAbono.Name = "lblMontoAbono";
            this.lblMontoAbono.Size = new System.Drawing.Size(40, 15);
            this.lblMontoAbono.TabIndex = 0;
            this.lblMontoAbono.Text = "Monto:";
            // 
            // numericAbono
            // 
            this.numericAbono.Location = new System.Drawing.Point(50, 8);
            this.numericAbono.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            this.numericAbono.Minimum = new decimal(new int[] { -999999999, 0, 0, -2147483648 });
            this.numericAbono.Name = "numericAbono";
            this.numericAbono.Size = new System.Drawing.Size(120, 23);
            this.numericAbono.TabIndex = 1;
            // 
            // btnRegistrarAbono
            // 
            this.btnRegistrarAbono.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRegistrarAbono.Location = new System.Drawing.Point(180, 7);
            this.btnRegistrarAbono.Name = "btnRegistrarAbono";
            this.btnRegistrarAbono.Size = new System.Drawing.Size(120, 25);
            this.btnRegistrarAbono.TabIndex = 2;
            this.btnRegistrarAbono.Text = "Registrar Abono";
            this.btnRegistrarAbono.UseVisualStyleBackColor = true;
            this.btnRegistrarAbono.Click += new System.EventHandler(this.btnRegistrarAbono_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuardar.Location = new System.Drawing.Point(200, 370);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 35);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Location = new System.Drawing.Point(340, 370);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 35);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorProviderCuenta
            // 
            this.errorProviderCuenta.ContainerControl = this;
            // 
            // lblInfoBalance
            // 
            this.lblInfoBalance.AutoSize = true;
            this.lblInfoBalance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblInfoBalance.Location = new System.Drawing.Point(30, 355);
            this.lblInfoBalance.Name = "lblInfoBalance";
            this.lblInfoBalance.Size = new System.Drawing.Size(0, 15);
            this.lblInfoBalance.TabIndex = 16;
            // 
            // CuentasPorCobrarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 430);
            this.Controls.Add(this.lblInfoBalance);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panelAbono);
            this.Controls.Add(this.dgvAbonos);
            this.Controls.Add(this.lblAbonos);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.numericDiasCredito);
            this.Controls.Add(this.lblDiasCredito);
            this.Controls.Add(this.numericMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CuentasPorCobrarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cuentas por Cobrar";
            this.Load += new System.EventHandler(this.CuentasPorCobrarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiasCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAbono)).EndInit();
            this.panelAbono.ResumeLayout(false);
            this.panelAbono.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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