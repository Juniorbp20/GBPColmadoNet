namespace GBPColmadoNet.UI.Forms.Inventario.ESForm
{
    partial class SForm
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
            numericUpDownStockIngresado = new NumericUpDown();
            lbestockIngresar = new Label();
            lbGanancia = new Label();
            lbVentaFinalItbis = new Label();
            lbInfoItbis = new Label();
            btnLimpiarFormulario = new Button();
            CboxProveedor = new ComboBox();
            lbProveedor = new Label();
            lbCategoria = new Label();
            CboxCategoria = new ComboBox();
            numericUpDownStock = new NumericUpDown();
            lbStock = new Label();
            RbtnItebis28 = new RadioButton();
            RbtnItbis18 = new RadioButton();
            RbtnItbis10 = new RadioButton();
            EbtnNoItebis = new RadioButton();
            lbItbis = new Label();
            lbSalidaStock = new Label();
            txCodigoBarras = new TextBox();
            lbCodigoBarra = new Label();
            txNombreProducto = new TextBox();
            numericUpDownPrecioVenta = new NumericUpDown();
            numericUpDownPrecioCompra = new NumericUpDown();
            btnGuardar = new Button();
            lbPrecioVenta = new Label();
            lbPrecioCompra = new Label();
            lbNombreProducto = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStockIngresado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioCompra).BeginInit();
            SuspendLayout();


            txCodigoBarras.KeyDown += txCodigoBarras_KeyDown;
            btnLimpiarFormulario.Click += btnLimpiarFormulario_Click;

            // 
            // numericUpDownStockIngresado
            // 
            numericUpDownStockIngresado.Location = new Point(402, 193);
            numericUpDownStockIngresado.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownStockIngresado.Name = "numericUpDownStockIngresado";
            numericUpDownStockIngresado.Size = new Size(120, 23);
            numericUpDownStockIngresado.TabIndex = 84;
            // 
            // lbestockIngresar
            // 
            lbestockIngresar.AutoSize = true;
            lbestockIngresar.Location = new Point(306, 195);
            lbestockIngresar.Name = "lbestockIngresar";
            lbestockIngresar.Size = new Size(90, 15);
            lbestockIngresar.TabIndex = 83;
            lbestockIngresar.Text = "Stock a Ingresar";
            // 
            // lbGanancia
            // 
            lbGanancia.AutoSize = true;
            lbGanancia.Location = new Point(569, 171);
            lbGanancia.Name = "lbGanancia";
            lbGanancia.Size = new Size(134, 15);
            lbGanancia.TabIndex = 82;
            lbGanancia.Text = "Ganancia RD$: Cantidad";
            // 
            // lbVentaFinalItbis
            // 
            lbVentaFinalItbis.AutoSize = true;
            lbVentaFinalItbis.Location = new Point(335, 170);
            lbVentaFinalItbis.Name = "lbVentaFinalItbis";
            lbVentaFinalItbis.Size = new Size(189, 15);
            lbVentaFinalItbis.TabIndex = 81;
            lbVentaFinalItbis.Text = "Precio FInal de Venta RD$ cantidad";
            // 
            // lbInfoItbis
            // 
            lbInfoItbis.AutoSize = true;
            lbInfoItbis.Location = new Point(153, 171);
            lbInfoItbis.Name = "lbInfoItbis";
            lbInfoItbis.Size = new Size(152, 15);
            lbInfoItbis.TabIndex = 80;
            lbInfoItbis.Text = "ITBIS del: (%): RD$ cantidad";
            // 
            // btnLimpiarFormulario
            // 
            btnLimpiarFormulario.FlatStyle = FlatStyle.System;
            btnLimpiarFormulario.Location = new Point(253, 307);
            btnLimpiarFormulario.Name = "btnLimpiarFormulario";
            btnLimpiarFormulario.Size = new Size(136, 34);
            btnLimpiarFormulario.TabIndex = 79;
            btnLimpiarFormulario.Text = "Limpiar Formulario";
            btnLimpiarFormulario.UseVisualStyleBackColor = true;
            // 
            // CboxProveedor
            // 
            CboxProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CboxProveedor.AutoCompleteSource = AutoCompleteSource.ListItems;
            CboxProveedor.FormattingEnabled = true;
            CboxProveedor.Location = new Point(147, 251);
            CboxProveedor.Name = "CboxProveedor";
            CboxProveedor.Size = new Size(589, 23);
            CboxProveedor.TabIndex = 78;
            // 
            // lbProveedor
            // 
            lbProveedor.AutoSize = true;
            lbProveedor.Location = new Point(12, 254);
            lbProveedor.Name = "lbProveedor";
            lbProveedor.Size = new Size(67, 15);
            lbProveedor.TabIndex = 77;
            lbProveedor.Text = "Proveedor: ";
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Location = new Point(12, 225);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(64, 15);
            lbCategoria.TabIndex = 76;
            lbCategoria.Text = "Categoria: ";
            // 
            // CboxCategoria
            // 
            CboxCategoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CboxCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
            CboxCategoria.FormattingEnabled = true;
            CboxCategoria.Location = new Point(148, 222);
            CboxCategoria.Name = "CboxCategoria";
            CboxCategoria.Size = new Size(588, 23);
            CboxCategoria.TabIndex = 75;
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(148, 193);
            numericUpDownStock.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(120, 23);
            numericUpDownStock.TabIndex = 74;
            // 
            // lbStock
            // 
            lbStock.AutoSize = true;
            lbStock.Location = new Point(12, 195);
            lbStock.Name = "lbStock";
            lbStock.Size = new Size(76, 15);
            lbStock.TabIndex = 73;
            lbStock.Text = "Stock Inicial: ";
            // 
            // RbtnItebis28
            // 
            RbtnItebis28.AutoSize = true;
            RbtnItebis28.Location = new Point(359, 144);
            RbtnItebis28.Name = "RbtnItebis28";
            RbtnItebis28.Size = new Size(47, 19);
            RbtnItebis28.TabIndex = 72;
            RbtnItebis28.TabStop = true;
            RbtnItebis28.Text = "28%\r\n";
            RbtnItebis28.UseVisualStyleBackColor = true;
            // 
            // RbtnItbis18
            // 
            RbtnItbis18.AutoSize = true;
            RbtnItbis18.Location = new Point(306, 144);
            RbtnItbis18.Name = "RbtnItbis18";
            RbtnItbis18.Size = new Size(47, 19);
            RbtnItbis18.TabIndex = 71;
            RbtnItbis18.TabStop = true;
            RbtnItbis18.Text = "18%";
            RbtnItbis18.UseVisualStyleBackColor = true;
            // 
            // RbtnItbis10
            // 
            RbtnItbis10.AutoSize = true;
            RbtnItbis10.Location = new Point(253, 144);
            RbtnItbis10.Name = "RbtnItbis10";
            RbtnItbis10.Size = new Size(47, 19);
            RbtnItbis10.TabIndex = 70;
            RbtnItbis10.TabStop = true;
            RbtnItbis10.Text = "10%";
            RbtnItbis10.UseVisualStyleBackColor = true;
            // 
            // EbtnNoItebis
            // 
            EbtnNoItebis.AutoSize = true;
            EbtnNoItebis.Location = new Point(148, 144);
            EbtnNoItebis.Name = "EbtnNoItebis";
            EbtnNoItebis.Size = new Size(99, 19);
            EbtnNoItebis.TabIndex = 69;
            EbtnNoItebis.TabStop = true;
            EbtnNoItebis.Text = "NO ITBIS (0%)";
            EbtnNoItebis.UseVisualStyleBackColor = true;
            // 
            // lbItbis
            // 
            lbItbis.AutoSize = true;
            lbItbis.Location = new Point(8, 144);
            lbItbis.Name = "lbItbis";
            lbItbis.Size = new Size(65, 15);
            lbItbis.TabIndex = 68;
            lbItbis.Text = "Tasa ITBIS: ";
            // 
            // lbSalidaStock
            // 
            lbSalidaStock.AutoSize = true;
            lbSalidaStock.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSalidaStock.Location = new Point(12, 9);
            lbSalidaStock.Name = "lbSalidaStock";
            lbSalidaStock.Size = new Size(162, 30);
            lbSalidaStock.TabIndex = 67;
            lbSalidaStock.Text = "Salida de Stock";
            // 
            // txCodigoBarras
            // 
            txCodigoBarras.Location = new Point(148, 52);
            txCodigoBarras.Name = "txCodigoBarras";
            txCodigoBarras.Size = new Size(170, 23);
            txCodigoBarras.TabIndex = 66;
            // 
            // lbCodigoBarra
            // 
            lbCodigoBarra.AutoSize = true;
            lbCodigoBarra.Location = new Point(10, 55);
            lbCodigoBarra.Name = "lbCodigoBarra";
            lbCodigoBarra.Size = new Size(97, 15);
            lbCodigoBarra.TabIndex = 65;
            lbCodigoBarra.Text = "Codigo de Barras";
            // 
            // txNombreProducto
            // 
            txNombreProducto.Location = new Point(148, 81);
            txNombreProducto.Name = "txNombreProducto";
            txNombreProducto.Size = new Size(588, 23);
            txNombreProducto.TabIndex = 64;
            // 
            // numericUpDownPrecioVenta
            // 
            numericUpDownPrecioVenta.Location = new Point(566, 111);
            numericUpDownPrecioVenta.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownPrecioVenta.Name = "numericUpDownPrecioVenta";
            numericUpDownPrecioVenta.Size = new Size(170, 23);
            numericUpDownPrecioVenta.TabIndex = 63;
            // 
            // numericUpDownPrecioCompra
            // 
            numericUpDownPrecioCompra.Location = new Point(148, 111);
            numericUpDownPrecioCompra.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownPrecioCompra.Name = "numericUpDownPrecioCompra";
            numericUpDownPrecioCompra.Size = new Size(170, 23);
            numericUpDownPrecioCompra.TabIndex = 62;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.System;
            btnGuardar.Location = new Point(147, 307);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 34);
            btnGuardar.TabIndex = 61;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lbPrecioVenta
            // 
            lbPrecioVenta.AutoSize = true;
            lbPrecioVenta.Location = new Point(440, 116);
            lbPrecioVenta.Name = "lbPrecioVenta";
            lbPrecioVenta.Size = new Size(88, 15);
            lbPrecioVenta.TabIndex = 60;
            lbPrecioVenta.Text = "Precio de venta";
            // 
            // lbPrecioCompra
            // 
            lbPrecioCompra.AutoSize = true;
            lbPrecioCompra.Location = new Point(10, 113);
            lbPrecioCompra.Name = "lbPrecioCompra";
            lbPrecioCompra.Size = new Size(100, 15);
            lbPrecioCompra.TabIndex = 59;
            lbPrecioCompra.Text = "Precio de compra";
            // 
            // lbNombreProducto
            // 
            lbNombreProducto.AutoSize = true;
            lbNombreProducto.Location = new Point(8, 84);
            lbNombreProducto.Name = "lbNombreProducto";
            lbNombreProducto.Size = new Size(122, 15);
            lbNombreProducto.TabIndex = 58;
            lbNombreProducto.Text = "Nombre del Producto";
            // 
            // SForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDownStockIngresado);
            Controls.Add(lbestockIngresar);
            Controls.Add(lbGanancia);
            Controls.Add(lbVentaFinalItbis);
            Controls.Add(lbInfoItbis);
            Controls.Add(btnLimpiarFormulario);
            Controls.Add(CboxProveedor);
            Controls.Add(lbProveedor);
            Controls.Add(lbCategoria);
            Controls.Add(CboxCategoria);
            Controls.Add(numericUpDownStock);
            Controls.Add(lbStock);
            Controls.Add(RbtnItebis28);
            Controls.Add(RbtnItbis18);
            Controls.Add(RbtnItbis10);
            Controls.Add(EbtnNoItebis);
            Controls.Add(lbItbis);
            Controls.Add(lbSalidaStock);
            Controls.Add(txCodigoBarras);
            Controls.Add(lbCodigoBarra);
            Controls.Add(txNombreProducto);
            Controls.Add(numericUpDownPrecioVenta);
            Controls.Add(numericUpDownPrecioCompra);
            Controls.Add(btnGuardar);
            Controls.Add(lbPrecioVenta);
            Controls.Add(lbPrecioCompra);
            Controls.Add(lbNombreProducto);
            Name = "SForm";
            Text = "SForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownStockIngresado).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownStockIngresado;
        private Label lbestockIngresar;
        private Label lbGanancia;
        private Label lbVentaFinalItbis;
        private Label lbInfoItbis;
        private Button btnLimpiarFormulario;
        private ComboBox CboxProveedor;
        private Label lbProveedor;
        private Label lbCategoria;
        private ComboBox CboxCategoria;
        private NumericUpDown numericUpDownStock;
        private Label lbStock;
        private RadioButton RbtnItebis28;
        private RadioButton RbtnItbis18;
        private RadioButton RbtnItbis10;
        private RadioButton EbtnNoItebis;
        private Label lbItbis;
        private Label lbSalidaStock;
        private TextBox txCodigoBarras;
        private Label lbCodigoBarra;
        private TextBox txNombreProducto;
        private NumericUpDown numericUpDownPrecioVenta;
        private NumericUpDown numericUpDownPrecioCompra;
        private Button btnGuardar;
        private Label lbPrecioVenta;
        private Label lbPrecioCompra;
        private Label lbNombreProducto;
    }
}