namespace GBPColmadoNet.UI.Forms.Inventario.Devoluciones
{
    partial class DevolucionesForm
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
            lblVenta = new Label();
            cmbVenta = new ComboBox();
            lblProducto = new Label();
            dgvProductosVenta = new DataGridView();
            lblCantidad = new Label();
            numericCantidad = new NumericUpDown();
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            errorProviderDevolucion = new ErrorProvider(components);
            lblInfoMonto = new Label();
            lblAccion = new Label();
            cmbAccion = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductosVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDevolucion).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(220, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(198, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar Devolución";
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Location = new Point(30, 60);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(39, 15);
            lblVenta.TabIndex = 1;
            lblVenta.Text = "Venta:";
            // 
            // cmbVenta
            // 
            cmbVenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVenta.FormattingEnabled = true;
            cmbVenta.Location = new Point(30, 78);
            cmbVenta.Name = "cmbVenta";
            cmbVenta.Size = new Size(520, 23);
            cmbVenta.TabIndex = 2;
            cmbVenta.SelectedIndexChanged += cmbVenta_SelectedIndexChanged;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(30, 115);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(64, 15);
            lblProducto.TabIndex = 3;
            lblProducto.Text = "Productos:";
            // 
            // dgvProductosVenta
            // 
            dgvProductosVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductosVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosVenta.Location = new Point(30, 133);
            dgvProductosVenta.Name = "dgvProductosVenta";
            dgvProductosVenta.RowHeadersVisible = false;
            dgvProductosVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductosVenta.Size = new Size(520, 120);
            dgvProductosVenta.TabIndex = 4;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(30, 265);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad:";
            // 
            // numericCantidad
            // 
            numericCantidad.Location = new Point(30, 283);
            numericCantidad.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericCantidad.Name = "numericCantidad";
            numericCantidad.Size = new Size(100, 23);
            numericCantidad.TabIndex = 6;
            numericCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Location = new Point(30, 320);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(48, 15);
            lblMotivo.TabIndex = 7;
            lblMotivo.Text = "Motivo:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(30, 338);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(520, 23);
            txtMotivo.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Teal;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(200, 385);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 35);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.System;
            btnCancelar.Location = new Point(340, 385);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 35);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProviderDevolucion
            // 
            errorProviderDevolucion.ContainerControl = this;
            // 
            // lblInfoMonto
            // 
            lblInfoMonto.AutoSize = true;
            lblInfoMonto.Location = new Point(270, 375);
            lblInfoMonto.Name = "lblInfoMonto";
            lblInfoMonto.Size = new Size(0, 15);
            lblInfoMonto.TabIndex = 11;
            // 
            // lblAccion
            // 
            lblAccion.AutoSize = true;
            lblAccion.Location = new Point(150, 265);
            lblAccion.Name = "lblAccion";
            lblAccion.Size = new Size(125, 15);
            lblAccion.TabIndex = 12;
            lblAccion.Text = "Destino del Inventario:";
            // 
            // cmbAccion
            // 
            cmbAccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAccion.FormattingEnabled = true;
            cmbAccion.Location = new Point(150, 283);
            cmbAccion.Name = "cmbAccion";
            cmbAccion.Size = new Size(400, 23);
            cmbAccion.TabIndex = 13;
            // 
            // DevolucionesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(580, 450);
            Controls.Add(cmbAccion);
            Controls.Add(lblAccion);
            Controls.Add(lblInfoMonto);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtMotivo);
            Controls.Add(lblMotivo);
            Controls.Add(numericCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(dgvProductosVenta);
            Controls.Add(lblProducto);
            Controls.Add(cmbVenta);
            Controls.Add(lblVenta);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DevolucionesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registrar Devolución";
            Load += DevolucionesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductosVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDevolucion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.ComboBox cmbVenta;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DataGridView dgvProductosVenta;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProviderDevolucion;
        private System.Windows.Forms.Label lblInfoMonto;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.ComboBox cmbAccion;
    }
}