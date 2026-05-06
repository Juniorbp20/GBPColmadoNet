namespace GBPColmadoNet.UI.Forms.Ventas
{
    partial class VentaRapidaForm
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

        private void InitializeComponent()
        {
            PanelTop = new Panel();
            lblCliente = new Label();
            cmbCliente = new ComboBox();
            lblProducto = new Label();
            cmbProducto = new ComboBox();
            lblStockLabel = new Label();
            lblStockDisp = new Label();
            lblPrecioLabel = new Label();
            lblPrecioU = new Label();
            lblCantidad = new Label();
            numCantidad = new NumericUpDown();
            btnAgregarVenta = new Button();
            PanelMiddle = new Panel();
            lblItemsTitle = new Label();
            dgvVenta = new DataGridView();
            PanelBottom = new Panel();
            lblResumenTitle = new Label();
            PanelResumen = new Panel();
            lblSubtotalLabel = new Label();
            lblSubtotal = new Label();
            lblMontoDescLabel = new Label();
            lblMontoDesc = new Label();
            lblTotalPagarLabel = new Label();
            lblTotalPagar = new Label();
            lblDineroRecibido = new Label();
            txtDineroRecibido = new TextBox();
            lblDescuento = new Label();
            txtDescuento = new TextBox();
            lblItbisTotalLabel = new Label();
            lblItbisTotal = new Label();
            lblCambioLabel = new Label();
            lblCambio = new Label();
            btnEliminarItem = new Button();
            btnCancelarVenta = new Button();
            btnConfirmarVenta = new Button();
            lblTipoPago = new Label();
            cmbTipoPago = new ComboBox();
            PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            PanelMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            PanelBottom.SuspendLayout();
            PanelResumen.SuspendLayout();
            SuspendLayout();
            // 
            // PanelTop
            // 
            PanelTop.Controls.Add(lblTipoPago);
            PanelTop.Controls.Add(cmbTipoPago);
            PanelTop.Controls.Add(lblCliente);
            PanelTop.Controls.Add(cmbCliente);
            PanelTop.Controls.Add(lblProducto);
            PanelTop.Controls.Add(cmbProducto);
            PanelTop.Controls.Add(lblStockLabel);
            PanelTop.Controls.Add(lblStockDisp);
            PanelTop.Controls.Add(lblPrecioLabel);
            PanelTop.Controls.Add(lblPrecioU);
            PanelTop.Controls.Add(lblCantidad);
            PanelTop.Controls.Add(numCantidad);
            PanelTop.Controls.Add(btnAgregarVenta);
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(0, 0);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(900, 100);
            PanelTop.TabIndex = 0;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(20, 20);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.Location = new Point(80, 17);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(200, 23);
            cmbCliente.TabIndex = 1;
            cmbCliente.SelectedIndexChanged += CmbCliente_SelectedIndexChanged;
            // 
            // 
            // lblTipoPago
            // 
            lblTipoPago.AutoSize = true;
            lblTipoPago.Location = new Point(295, 20);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(63, 15);
            lblTipoPago.TabIndex = 11;
            lblTipoPago.Text = "Tipo Pago:";
            lblTipoPago.Visible = false;
            // 
            // cmbTipoPago
            // 
            cmbTipoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPago.Items.AddRange(new object[] { "Efectivo", "Crédito" });
            cmbTipoPago.Location = new Point(365, 17);
            cmbTipoPago.Name = "cmbTipoPago";
            cmbTipoPago.Size = new Size(100, 23);
            cmbTipoPago.TabIndex = 12;
            cmbTipoPago.Visible = false;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(475, 20);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(59, 15);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto:";
            // 
            // cmbProducto
            // 
            cmbProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProducto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(540, 17);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(340, 23);
            cmbProducto.TabIndex = 3;
            cmbProducto.SelectedIndexChanged += CmbProducto_SelectedIndexChanged;
            cmbProducto.KeyUp += CmbProducto_KeyUp;
            // 
            // lblStockLabel
            // 
            lblStockLabel.AutoSize = true;
            lblStockLabel.Location = new Point(20, 60);
            lblStockLabel.Name = "lblStockLabel";
            lblStockLabel.Size = new Size(65, 15);
            lblStockLabel.TabIndex = 4;
            lblStockLabel.Text = "Stock Disp:";
            // 
            // lblStockDisp
            // 
            lblStockDisp.AutoSize = true;
            lblStockDisp.Location = new Point(90, 60);
            lblStockDisp.Name = "lblStockDisp";
            lblStockDisp.Size = new Size(12, 15);
            lblStockDisp.TabIndex = 5;
            lblStockDisp.Text = "-";
            // 
            // lblPrecioLabel
            // 
            lblPrecioLabel.AutoSize = true;
            lblPrecioLabel.Location = new Point(200, 60);
            lblPrecioLabel.Name = "lblPrecioLabel";
            lblPrecioLabel.Size = new Size(54, 15);
            lblPrecioLabel.TabIndex = 6;
            lblPrecioLabel.Text = "Precio U:";
            // 
            // lblPrecioU
            // 
            lblPrecioU.AutoSize = true;
            lblPrecioU.Location = new Point(260, 60);
            lblPrecioU.Name = "lblPrecioU";
            lblPrecioU.Size = new Size(12, 15);
            lblPrecioU.TabIndex = 7;
            lblPrecioU.Text = "-";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(345, 60);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "Cantidad:";
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(409, 57);
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(80, 23);
            numCantidad.TabIndex = 9;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.BackColor = Color.White;
            btnAgregarVenta.ForeColor = Color.Black;
            btnAgregarVenta.Location = new Point(509, 52);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(120, 30);
            btnAgregarVenta.TabIndex = 10;
            btnAgregarVenta.Text = "Agregar a Venta";
            btnAgregarVenta.UseVisualStyleBackColor = false;
            btnAgregarVenta.Click += BtnAgregarVenta_Click;
            // 
            // PanelMiddle
            // 
            PanelMiddle.Controls.Add(lblItemsTitle);
            PanelMiddle.Controls.Add(dgvVenta);
            PanelMiddle.Dock = DockStyle.Fill;
            PanelMiddle.Location = new Point(0, 100);
            PanelMiddle.Name = "PanelMiddle";
            PanelMiddle.Padding = new Padding(20, 0, 20, 0);
            PanelMiddle.Size = new Size(900, 250);
            PanelMiddle.TabIndex = 1;
            // 
            // lblItemsTitle
            // 
            lblItemsTitle.AutoSize = true;
            lblItemsTitle.ForeColor = Color.DimGray;
            lblItemsTitle.Location = new Point(20, 5);
            lblItemsTitle.Name = "lblItemsTitle";
            lblItemsTitle.Size = new Size(121, 15);
            lblItemsTitle.TabIndex = 0;
            lblItemsTitle.Text = "Items en Venta Actual";
            // 
            // dgvVenta
            // 
            dgvVenta.AllowUserToAddRows = false;
            dgvVenta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVenta.BackgroundColor = Color.White;
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Location = new Point(20, 25);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.ReadOnly = true;
            dgvVenta.RowHeadersVisible = false;
            dgvVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVenta.Size = new Size(860, 225);
            dgvVenta.TabIndex = 1;
            // 
            // PanelBottom
            // 
            PanelBottom.Controls.Add(lblResumenTitle);
            PanelBottom.Controls.Add(PanelResumen);
            PanelBottom.Controls.Add(btnEliminarItem);
            PanelBottom.Controls.Add(btnCancelarVenta);
            PanelBottom.Controls.Add(btnConfirmarVenta);
            PanelBottom.Dock = DockStyle.Bottom;
            PanelBottom.Location = new Point(0, 350);
            PanelBottom.Name = "PanelBottom";
            PanelBottom.Size = new Size(900, 250);
            PanelBottom.TabIndex = 2;
            // 
            // lblResumenTitle
            // 
            lblResumenTitle.AutoSize = true;
            lblResumenTitle.ForeColor = Color.DimGray;
            lblResumenTitle.Location = new Point(20, 5);
            lblResumenTitle.Name = "lblResumenTitle";
            lblResumenTitle.Size = new Size(95, 15);
            lblResumenTitle.TabIndex = 0;
            lblResumenTitle.Text = "Resumen y Pago";
            // 
            // PanelResumen
            // 
            PanelResumen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PanelResumen.BorderStyle = BorderStyle.FixedSingle;
            PanelResumen.Controls.Add(lblSubtotalLabel);
            PanelResumen.Controls.Add(lblSubtotal);
            PanelResumen.Controls.Add(lblMontoDescLabel);
            PanelResumen.Controls.Add(lblMontoDesc);
            PanelResumen.Controls.Add(lblTotalPagarLabel);
            PanelResumen.Controls.Add(lblTotalPagar);
            PanelResumen.Controls.Add(lblDineroRecibido);
            PanelResumen.Controls.Add(txtDineroRecibido);
            PanelResumen.Controls.Add(lblDescuento);
            PanelResumen.Controls.Add(txtDescuento);
            PanelResumen.Controls.Add(lblItbisTotalLabel);
            PanelResumen.Controls.Add(lblItbisTotal);
            PanelResumen.Controls.Add(lblCambioLabel);
            PanelResumen.Controls.Add(lblCambio);
            PanelResumen.Location = new Point(20, 25);
            PanelResumen.Name = "PanelResumen";
            PanelResumen.Size = new Size(860, 150);
            PanelResumen.TabIndex = 1;
            // 
            // lblSubtotalLabel
            // 
            lblSubtotalLabel.AutoSize = true;
            lblSubtotalLabel.Location = new Point(20, 20);
            lblSubtotalLabel.Name = "lblSubtotalLabel";
            lblSubtotalLabel.Size = new Size(114, 15);
            lblSubtotalLabel.TabIndex = 0;
            lblSubtotalLabel.Text = "Subtotal (con ITBIS):";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSubtotal.Location = new Point(200, 20);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(29, 19);
            lblSubtotal.TabIndex = 1;
            lblSubtotal.Text = "0.0";
            // 
            // lblMontoDescLabel
            // 
            lblMontoDescLabel.AutoSize = true;
            lblMontoDescLabel.Location = new Point(20, 50);
            lblMontoDescLabel.Name = "lblMontoDescLabel";
            lblMontoDescLabel.Size = new Size(74, 15);
            lblMontoDescLabel.TabIndex = 2;
            lblMontoDescLabel.Text = "Monto Desc:";
            // 
            // lblMontoDesc
            // 
            lblMontoDesc.AutoSize = true;
            lblMontoDesc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMontoDesc.Location = new Point(200, 50);
            lblMontoDesc.Name = "lblMontoDesc";
            lblMontoDesc.Size = new Size(29, 19);
            lblMontoDesc.TabIndex = 3;
            lblMontoDesc.Text = "0.0";
            // 
            // lblTotalPagarLabel
            // 
            lblTotalPagarLabel.AutoSize = true;
            lblTotalPagarLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalPagarLabel.Location = new Point(20, 80);
            lblTotalPagarLabel.Name = "lblTotalPagarLabel";
            lblTotalPagarLabel.Size = new Size(131, 21);
            lblTotalPagarLabel.TabIndex = 4;
            lblTotalPagarLabel.Text = "TOTAL A PAGAR:";
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.AutoSize = true;
            lblTotalPagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalPagar.Location = new Point(200, 80);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(32, 21);
            lblTotalPagar.TabIndex = 5;
            lblTotalPagar.Text = "0.0";
            // 
            // lblDineroRecibido
            // 
            lblDineroRecibido.AutoSize = true;
            lblDineroRecibido.Location = new Point(20, 115);
            lblDineroRecibido.Name = "lblDineroRecibido";
            lblDineroRecibido.Size = new Size(94, 15);
            lblDineroRecibido.TabIndex = 6;
            lblDineroRecibido.Text = "Dinero Recibido:";
            // 
            // txtDineroRecibido
            // 
            txtDineroRecibido.Location = new Point(140, 110);
            txtDineroRecibido.Name = "txtDineroRecibido";
            txtDineroRecibido.Size = new Size(100, 23);
            txtDineroRecibido.TabIndex = 10;
            txtDineroRecibido.Text = "0.00";
            txtDineroRecibido.TextAlign = HorizontalAlignment.Right;
            txtDineroRecibido.TextChanged += TxtDineroRecibido_TextChanged;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(450, 20);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(66, 15);
            lblDescuento.TabIndex = 8;
            lblDescuento.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(549, 17);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 8;
            txtDescuento.Text = "0.00";
            txtDescuento.TextAlign = HorizontalAlignment.Right;
            txtDescuento.TextChanged += TxtDescuento_TextChanged;
            // 
            // lblItbisTotalLabel
            // 
            lblItbisTotalLabel.AutoSize = true;
            lblItbisTotalLabel.Location = new Point(450, 50);
            lblItbisTotalLabel.Name = "lblItbisTotalLabel";
            lblItbisTotalLabel.Size = new Size(97, 15);
            lblItbisTotalLabel.TabIndex = 10;
            lblItbisTotalLabel.Text = "ITBIS Total Venta:";
            // 
            // lblItbisTotal
            // 
            lblItbisTotal.AutoSize = true;
            lblItbisTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblItbisTotal.Location = new Point(620, 50);
            lblItbisTotal.Name = "lblItbisTotal";
            lblItbisTotal.Size = new Size(29, 19);
            lblItbisTotal.TabIndex = 11;
            lblItbisTotal.Text = "0.0";
            // 
            // lblCambioLabel
            // 
            lblCambioLabel.AutoSize = true;
            lblCambioLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCambioLabel.Location = new Point(450, 115);
            lblCambioLabel.Name = "lblCambioLabel";
            lblCambioLabel.Size = new Size(65, 19);
            lblCambioLabel.TabIndex = 12;
            lblCambioLabel.Text = "Cambio:";
            // 
            // lblCambio
            // 
            lblCambio.AutoSize = true;
            lblCambio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCambio.Location = new Point(600, 115);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(68, 19);
            lblCambio.TabIndex = 13;
            lblCambio.Text = "RD$ 0.00";
            // 
            // btnEliminarItem
            // 
            btnEliminarItem.BackColor = Color.LightCoral;
            btnEliminarItem.ForeColor = Color.White;
            btnEliminarItem.Location = new Point(20, 190);
            btnEliminarItem.Name = "btnEliminarItem";
            btnEliminarItem.Size = new Size(120, 35);
            btnEliminarItem.TabIndex = 3;
            btnEliminarItem.Text = "Eliminar Item";
            btnEliminarItem.UseVisualStyleBackColor = false;
            btnEliminarItem.Click += BtnEliminarItem_Click;
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.BackColor = Color.White;
            btnCancelarVenta.ForeColor = Color.Black;
            btnCancelarVenta.Location = new Point(150, 190);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(120, 35);
            btnCancelarVenta.TabIndex = 4;
            btnCancelarVenta.Text = "Cancelar Venta";
            btnCancelarVenta.UseVisualStyleBackColor = false;
            btnCancelarVenta.Click += BtnCancelarVenta_Click;
            // 
            // btnConfirmarVenta
            // 
            btnConfirmarVenta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConfirmarVenta.BackColor = Color.Teal;
            btnConfirmarVenta.ForeColor = Color.White;
            btnConfirmarVenta.Location = new Point(680, 190);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(200, 35);
            btnConfirmarVenta.TabIndex = 5;
            btnConfirmarVenta.Text = "Confirmar y Guardar Venta";
            btnConfirmarVenta.UseVisualStyleBackColor = false;
            btnConfirmarVenta.Click += BtnConfirmarVenta_Click;
            // 
            // VentaRapidaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(900, 600);
            Controls.Add(PanelMiddle);
            Controls.Add(PanelBottom);
            Controls.Add(PanelTop);
            Name = "VentaRapidaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta Rápida (POS)";
            Load += VentaRapidaForm_Load;
            PanelTop.ResumeLayout(false);
            PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            PanelMiddle.ResumeLayout(false);
            PanelMiddle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
            PanelBottom.ResumeLayout(false);
            PanelBottom.PerformLayout();
            PanelResumen.ResumeLayout(false);
            PanelResumen.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblStockLabel;
        private System.Windows.Forms.Label lblStockDisp;
        private System.Windows.Forms.Label lblPrecioLabel;
        private System.Windows.Forms.Label lblPrecioU;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Button btnAgregarVenta;

        private System.Windows.Forms.Panel PanelMiddle;
        private System.Windows.Forms.Label lblItemsTitle;
        private System.Windows.Forms.DataGridView dgvVenta;

        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Label lblResumenTitle;
        private System.Windows.Forms.Panel PanelResumen;
        private System.Windows.Forms.Label lblSubtotalLabel;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblMontoDescLabel;
        private System.Windows.Forms.Label lblMontoDesc;
        private System.Windows.Forms.Label lblTotalPagarLabel;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblDineroRecibido;
        private System.Windows.Forms.TextBox txtDineroRecibido;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblItbisTotalLabel;
        private System.Windows.Forms.Label lblItbisTotal;
        private System.Windows.Forms.Label lblCambioLabel;
        private System.Windows.Forms.Label lblCambio;

        private System.Windows.Forms.Button btnEliminarItem;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.Button btnConfirmarVenta;
    }
}