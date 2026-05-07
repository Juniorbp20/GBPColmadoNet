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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblVenta = new System.Windows.Forms.Label();
            this.cmbVenta = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.dgvProductosVenta = new System.Windows.Forms.DataGridView();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorProviderDevolucion = new System.Windows.Forms.ErrorProvider();
            this.lblInfoMonto = new System.Windows.Forms.Label();
            this.lblAccion = new System.Windows.Forms.Label();
            this.cmbAccion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(220, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(165, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registrar Devolución";
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Location = new System.Drawing.Point(30, 60);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(40, 15);
            this.lblVenta.TabIndex = 1;
            this.lblVenta.Text = "Venta:";
            // 
            // cmbVenta
            // 
            this.cmbVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVenta.FormattingEnabled = true;
            this.cmbVenta.Location = new System.Drawing.Point(30, 78);
            this.cmbVenta.Name = "cmbVenta";
            this.cmbVenta.Size = new System.Drawing.Size(520, 23);
            this.cmbVenta.TabIndex = 2;
            this.cmbVenta.SelectedIndexChanged += new System.EventHandler(this.cmbVenta_SelectedIndexChanged);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(30, 115);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(60, 15);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Productos:";
            // 
            // dgvProductosVenta
            // 
            this.dgvProductosVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosVenta.Location = new System.Drawing.Point(30, 133);
            this.dgvProductosVenta.Name = "dgvProductosVenta";
            this.dgvProductosVenta.RowHeadersVisible = false;
            this.dgvProductosVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosVenta.Size = new System.Drawing.Size(520, 120);
            this.dgvProductosVenta.TabIndex = 4;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(30, 265);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(60, 15);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // numericCantidad
            // 
            this.numericCantidad.Location = new System.Drawing.Point(30, 283);
            this.numericCantidad.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numericCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(100, 23);
            this.numericCantidad.TabIndex = 6;
            this.numericCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(30, 320);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(45, 15);
            this.lblMotivo.TabIndex = 7;
            this.lblMotivo.Text = "Motivo:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(30, 338);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(520, 23);
            this.txtMotivo.TabIndex = 8;
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Location = new System.Drawing.Point(150, 265);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(125, 15);
            this.lblAccion.TabIndex = 12;
            this.lblAccion.Text = "Destino del Inventario:";
            // 
            // cmbAccion
            // 
            this.cmbAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccion.FormattingEnabled = true;
            this.cmbAccion.Location = new System.Drawing.Point(150, 283);
            this.cmbAccion.Name = "cmbAccion";
            this.cmbAccion.Size = new System.Drawing.Size(400, 23);
            this.cmbAccion.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuardar.Location = new System.Drawing.Point(200, 385);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 35);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Location = new System.Drawing.Point(340, 385);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 35);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorProviderDevolucion
            // 
            this.errorProviderDevolucion.ContainerControl = this;
            // 
            // lblInfoMonto
            // 
            this.lblInfoMonto.AutoSize = true;
            this.lblInfoMonto.Location = new System.Drawing.Point(270, 375);
            this.lblInfoMonto.Name = "lblInfoMonto";
            this.lblInfoMonto.Size = new System.Drawing.Size(0, 15);
            this.lblInfoMonto.TabIndex = 11;
            // 
            // DevolucionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.cmbAccion);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.lblInfoMonto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.numericCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.dgvProductosVenta);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.cmbVenta);
            this.Controls.Add(this.lblVenta);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DevolucionesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Devolución";
            this.Load += new System.EventHandler(this.DevolucionesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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