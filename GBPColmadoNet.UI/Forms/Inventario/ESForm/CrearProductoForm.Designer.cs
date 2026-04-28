namespace GBPColmadoNet.UI.Forms
{
    partial class CrearProductoForm
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
            lbNombreProducto = new Label();
            lbPrecioCompra = new Label();
            lbPrecioVenta = new Label();
            btnGuardar = new Button();
            errorProviderES = new ErrorProvider(components);
            numericUpDownPrecioCompra = new NumericUpDown();
            numericUpDownPrecioVenta = new NumericUpDown();
            txNombreProducto = new TextBox();
            lbCodigoBarra = new Label();
            txCodigoBarras = new TextBox();
            lbAregarProducto = new Label();
            lbItbis = new Label();
            EbtnNoItebis = new RadioButton();
            RbtnItbis10 = new RadioButton();
            RbtnItbis18 = new RadioButton();
            RbtnItebis28 = new RadioButton();
            lbStock = new Label();
            numericUpDownStock = new NumericUpDown();
            CboxCategoria = new ComboBox();
            lbCategoria = new Label();
            lbProveedor = new Label();
            CboxProveedor = new ComboBox();
            btnLimpiarFormulario = new Button();
            lbInfoItbis = new Label();
            lbVentaFinalItbis = new Label();
            lbGanancia = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProviderES).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            SuspendLayout();
            // 
            // lbNombreProducto
            // 
            lbNombreProducto.AutoSize = true;
            lbNombreProducto.Location = new Point(12, 95);
            lbNombreProducto.Name = "lbNombreProducto";
            lbNombreProducto.Size = new Size(122, 15);
            lbNombreProducto.TabIndex = 0;
            lbNombreProducto.Text = "Nombre del Producto";
            // 
            // lbPrecioCompra
            // 
            lbPrecioCompra.AutoSize = true;
            lbPrecioCompra.Location = new Point(14, 124);
            lbPrecioCompra.Name = "lbPrecioCompra";
            lbPrecioCompra.Size = new Size(100, 15);
            lbPrecioCompra.TabIndex = 2;
            lbPrecioCompra.Text = "Precio de compra";
            // 
            // lbPrecioVenta
            // 
            lbPrecioVenta.AutoSize = true;
            lbPrecioVenta.Location = new Point(444, 127);
            lbPrecioVenta.Name = "lbPrecioVenta";
            lbPrecioVenta.Size = new Size(88, 15);
            lbPrecioVenta.TabIndex = 3;
            lbPrecioVenta.Text = "Precio de venta";
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.System;
            btnGuardar.Location = new Point(151, 318);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 34);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // errorProviderES
            // 
            errorProviderES.ContainerControl = this;
            // 
            // numericUpDownPrecioCompra
            // 
            numericUpDownPrecioCompra.Location = new Point(152, 122);
            numericUpDownPrecioCompra.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownPrecioCompra.Name = "numericUpDownPrecioCompra";
            numericUpDownPrecioCompra.Size = new Size(170, 23);
            numericUpDownPrecioCompra.TabIndex = 7;
            // 
            // numericUpDownPrecioVenta
            // 
            numericUpDownPrecioVenta.Location = new Point(570, 122);
            numericUpDownPrecioVenta.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownPrecioVenta.Name = "numericUpDownPrecioVenta";
            numericUpDownPrecioVenta.Size = new Size(170, 23);
            numericUpDownPrecioVenta.TabIndex = 8;
            // 
            // txNombreProducto
            // 
            txNombreProducto.Location = new Point(152, 92);
            txNombreProducto.Name = "txNombreProducto";
            txNombreProducto.Size = new Size(588, 23);
            txNombreProducto.TabIndex = 9;
            // 
            // lbCodigoBarra
            // 
            lbCodigoBarra.AutoSize = true;
            lbCodigoBarra.Location = new Point(14, 66);
            lbCodigoBarra.Name = "lbCodigoBarra";
            lbCodigoBarra.Size = new Size(97, 15);
            lbCodigoBarra.TabIndex = 10;
            lbCodigoBarra.Text = "Codigo de Barras";
            // 
            // txCodigoBarras
            // 
            txCodigoBarras.Location = new Point(152, 63);
            txCodigoBarras.Name = "txCodigoBarras";
            txCodigoBarras.Size = new Size(170, 23);
            txCodigoBarras.TabIndex = 11;
            // 
            // lbAregarProducto
            // 
            lbAregarProducto.AutoSize = true;
            lbAregarProducto.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAregarProducto.Location = new Point(16, 20);
            lbAregarProducto.Name = "lbAregarProducto";
            lbAregarProducto.Size = new Size(161, 30);
            lbAregarProducto.TabIndex = 12;
            lbAregarProducto.Text = "Crear producto";
            // 
            // lbItbis
            // 
            lbItbis.AutoSize = true;
            lbItbis.Location = new Point(12, 155);
            lbItbis.Name = "lbItbis";
            lbItbis.Size = new Size(65, 15);
            lbItbis.TabIndex = 13;
            lbItbis.Text = "Tasa ITBIS: ";
            // 
            // EbtnNoItebis
            // 
            EbtnNoItebis.AutoSize = true;
            EbtnNoItebis.Location = new Point(152, 155);
            EbtnNoItebis.Name = "EbtnNoItebis";
            EbtnNoItebis.Size = new Size(99, 19);
            EbtnNoItebis.TabIndex = 14;
            EbtnNoItebis.TabStop = true;
            EbtnNoItebis.Text = "NO ITBIS (0%)";
            EbtnNoItebis.UseVisualStyleBackColor = true;
            // 
            // RbtnItbis10
            // 
            RbtnItbis10.AutoSize = true;
            RbtnItbis10.Location = new Point(257, 155);
            RbtnItbis10.Name = "RbtnItbis10";
            RbtnItbis10.Size = new Size(47, 19);
            RbtnItbis10.TabIndex = 15;
            RbtnItbis10.TabStop = true;
            RbtnItbis10.Text = "10%";
            RbtnItbis10.UseVisualStyleBackColor = true;
            // 
            // RbtnItbis18
            // 
            RbtnItbis18.AutoSize = true;
            RbtnItbis18.Location = new Point(310, 155);
            RbtnItbis18.Name = "RbtnItbis18";
            RbtnItbis18.Size = new Size(47, 19);
            RbtnItbis18.TabIndex = 16;
            RbtnItbis18.TabStop = true;
            RbtnItbis18.Text = "18%";
            RbtnItbis18.UseVisualStyleBackColor = true;
            // 
            // RbtnItebis28
            // 
            RbtnItebis28.AutoSize = true;
            RbtnItebis28.Location = new Point(363, 155);
            RbtnItebis28.Name = "RbtnItebis28";
            RbtnItebis28.Size = new Size(47, 19);
            RbtnItebis28.TabIndex = 17;
            RbtnItebis28.TabStop = true;
            RbtnItebis28.Text = "28%\r\n";
            RbtnItebis28.UseVisualStyleBackColor = true;
            // 
            // lbStock
            // 
            lbStock.AutoSize = true;
            lbStock.Location = new Point(16, 206);
            lbStock.Name = "lbStock";
            lbStock.Size = new Size(76, 15);
            lbStock.TabIndex = 21;
            lbStock.Text = "Stock Inicial: ";
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(152, 204);
            numericUpDownStock.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(120, 23);
            numericUpDownStock.TabIndex = 22;
            // 
            // CboxCategoria
            // 
            CboxCategoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CboxCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
            CboxCategoria.FormattingEnabled = true;
            CboxCategoria.Location = new Point(152, 233);
            CboxCategoria.Name = "CboxCategoria";
            CboxCategoria.Size = new Size(588, 23);
            CboxCategoria.TabIndex = 23;
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Location = new Point(16, 236);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(64, 15);
            lbCategoria.TabIndex = 24;
            lbCategoria.Text = "Categoria: ";
            // 
            // lbProveedor
            // 
            lbProveedor.AutoSize = true;
            lbProveedor.Location = new Point(16, 265);
            lbProveedor.Name = "lbProveedor";
            lbProveedor.Size = new Size(67, 15);
            lbProveedor.TabIndex = 25;
            lbProveedor.Text = "Proveedor: ";
            // 
            // CboxProveedor
            // 
            CboxProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CboxProveedor.AutoCompleteSource = AutoCompleteSource.ListItems;
            CboxProveedor.FormattingEnabled = true;
            CboxProveedor.Location = new Point(151, 262);
            CboxProveedor.Name = "CboxProveedor";
            CboxProveedor.Size = new Size(589, 23);
            CboxProveedor.TabIndex = 26;
            // 
            // btnLimpiarFormulario
            // 
            btnLimpiarFormulario.FlatStyle = FlatStyle.System;
            btnLimpiarFormulario.Location = new Point(257, 318);
            btnLimpiarFormulario.Name = "btnLimpiarFormulario";
            btnLimpiarFormulario.Size = new Size(136, 34);
            btnLimpiarFormulario.TabIndex = 27;
            btnLimpiarFormulario.Text = "Limpiar Formulario";
            btnLimpiarFormulario.UseVisualStyleBackColor = true;
            btnLimpiarFormulario.Click += btnLimpiarFormulario_Click;
            // 
            // lbInfoItbis
            // 
            lbInfoItbis.AutoSize = true;
            lbInfoItbis.Location = new Point(157, 182);
            lbInfoItbis.Name = "lbInfoItbis";
            lbInfoItbis.Size = new Size(152, 15);
            lbInfoItbis.TabIndex = 28;
            lbInfoItbis.Text = "ITBIS del: (%): RD$ cantidad";
            // 
            // lbVentaFinalItbis
            // 
            lbVentaFinalItbis.AutoSize = true;
            lbVentaFinalItbis.Location = new Point(339, 181);
            lbVentaFinalItbis.Name = "lbVentaFinalItbis";
            lbVentaFinalItbis.Size = new Size(189, 15);
            lbVentaFinalItbis.TabIndex = 29;
            lbVentaFinalItbis.Text = "Precio FInal de Venta RD$ cantidad";
            // 
            // lbGanancia
            // 
            lbGanancia.AutoSize = true;
            lbGanancia.Location = new Point(573, 182);
            lbGanancia.Name = "lbGanancia";
            lbGanancia.Size = new Size(134, 15);
            lbGanancia.TabIndex = 30;
            lbGanancia.Text = "Ganancia RD$: Cantidad";
            // 
            // CrearProductoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
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
            Controls.Add(lbAregarProducto);
            Controls.Add(txCodigoBarras);
            Controls.Add(lbCodigoBarra);
            Controls.Add(txNombreProducto);
            Controls.Add(numericUpDownPrecioVenta);
            Controls.Add(numericUpDownPrecioCompra);
            Controls.Add(btnGuardar);
            Controls.Add(lbPrecioVenta);
            Controls.Add(lbPrecioCompra);
            Controls.Add(lbNombreProducto);
            Name = "CrearProductoForm";
            Text = "Crear Productos";
            ((System.ComponentModel.ISupportInitialize)errorProviderES).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNombreProducto, lbPrecioCompra, lbPrecioVenta;
        private Button btnGuardar;
        private ErrorProvider errorProviderES;
        private NumericUpDown numericUpDownPrecioVenta;
        private NumericUpDown numericUpDownPrecioCompra;
        private TextBox txNombreProducto;
        private TextBox txCodigoBarras;
        private Label lbCodigoBarra;
        private RadioButton EbtnNoItebis;
        private Label lbItbis;
        private Label lbAregarProducto;
        private RadioButton RbtnItebis28;
        private RadioButton RbtnItbis18;
        private RadioButton RbtnItbis10;
        private ComboBox CboxCategoria;
        private NumericUpDown numericUpDownStock;
        private Label lbStock;
        private Button btnLimpiarFormulario;
        private ComboBox CboxProveedor;
        private Label lbProveedor;
        private Label lbCategoria;
        private Label lbVentaFinalItbis;
        private Label lbInfoItbis;
        private Label lbGanancia;
    }
}