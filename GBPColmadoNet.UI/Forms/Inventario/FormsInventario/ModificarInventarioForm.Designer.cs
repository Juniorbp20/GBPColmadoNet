namespace GBPColmadoNet.UI.Forms.Inventario.ESForm
{
    partial class ModificarInventarioForm
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
            chkActivo = new CheckBox();
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
            lbAregarProducto = new Label();
            txCodigoBarras = new TextBox();
            lbCodigoBarra = new Label();
            txNombreProducto = new TextBox();
            numericUpDownPrecioVenta = new NumericUpDown();
            numericUpDownPrecioCompra = new NumericUpDown();
            btnGuardar = new Button();
            lbPrecioVenta = new Label();
            lbPrecioCompra = new Label();
            lbNombreProducto = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioCompra).BeginInit();
            SuspendLayout();
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(151, 290);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(112, 19);
            chkActivo.TabIndex = 56;
            chkActivo.Text = "Producto Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // lbGanancia
            // 
            lbGanancia.AutoSize = true;
            lbGanancia.Location = new Point(573, 182);
            lbGanancia.Name = "lbGanancia";
            lbGanancia.Size = new Size(134, 15);
            lbGanancia.TabIndex = 55;
            lbGanancia.Text = "Ganancia RD$: Cantidad";
            // 
            // lbVentaFinalItbis
            // 
            lbVentaFinalItbis.AutoSize = true;
            lbVentaFinalItbis.Location = new Point(339, 181);
            lbVentaFinalItbis.Name = "lbVentaFinalItbis";
            lbVentaFinalItbis.Size = new Size(189, 15);
            lbVentaFinalItbis.TabIndex = 54;
            lbVentaFinalItbis.Text = "Precio FInal de Venta RD$ cantidad";
            // 
            // lbInfoItbis
            // 
            lbInfoItbis.AutoSize = true;
            lbInfoItbis.Location = new Point(157, 182);
            lbInfoItbis.Name = "lbInfoItbis";
            lbInfoItbis.Size = new Size(152, 15);
            lbInfoItbis.TabIndex = 53;
            lbInfoItbis.Text = "ITBIS del: (%): RD$ cantidad";
            // 
            // btnLimpiarFormulario
            // 
            btnLimpiarFormulario.FlatStyle = FlatStyle.System;
            btnLimpiarFormulario.Location = new Point(257, 318);
            btnLimpiarFormulario.Name = "btnLimpiarFormulario";
            btnLimpiarFormulario.Size = new Size(136, 34);
            btnLimpiarFormulario.TabIndex = 52;
            btnLimpiarFormulario.Text = "Limpiar Formulario";
            btnLimpiarFormulario.UseVisualStyleBackColor = true;
            // 
            // CboxProveedor
            // 
            CboxProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CboxProveedor.AutoCompleteSource = AutoCompleteSource.ListItems;
            CboxProveedor.FormattingEnabled = true;
            CboxProveedor.Location = new Point(151, 262);
            CboxProveedor.Name = "CboxProveedor";
            CboxProveedor.Size = new Size(589, 23);
            CboxProveedor.TabIndex = 51;
            // 
            // lbProveedor
            // 
            lbProveedor.AutoSize = true;
            lbProveedor.Location = new Point(16, 265);
            lbProveedor.Name = "lbProveedor";
            lbProveedor.Size = new Size(67, 15);
            lbProveedor.TabIndex = 50;
            lbProveedor.Text = "Proveedor: ";
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Location = new Point(16, 236);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(64, 15);
            lbCategoria.TabIndex = 49;
            lbCategoria.Text = "Categoria: ";
            // 
            // CboxCategoria
            // 
            CboxCategoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CboxCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
            CboxCategoria.FormattingEnabled = true;
            CboxCategoria.Location = new Point(152, 233);
            CboxCategoria.Name = "CboxCategoria";
            CboxCategoria.Size = new Size(588, 23);
            CboxCategoria.TabIndex = 48;
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(152, 204);
            numericUpDownStock.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(120, 23);
            numericUpDownStock.TabIndex = 47;
            // 
            // lbStock
            // 
            lbStock.AutoSize = true;
            lbStock.Location = new Point(16, 206);
            lbStock.Name = "lbStock";
            lbStock.Size = new Size(76, 15);
            lbStock.TabIndex = 46;
            lbStock.Text = "Stock Inicial: ";
            // 
            // RbtnItebis28
            // 
            RbtnItebis28.AutoSize = true;
            RbtnItebis28.Location = new Point(363, 155);
            RbtnItebis28.Name = "RbtnItebis28";
            RbtnItebis28.Size = new Size(47, 19);
            RbtnItebis28.TabIndex = 45;
            RbtnItebis28.TabStop = true;
            RbtnItebis28.Text = "28%\r\n";
            RbtnItebis28.UseVisualStyleBackColor = true;
            // 
            // RbtnItbis18
            // 
            RbtnItbis18.AutoSize = true;
            RbtnItbis18.Location = new Point(310, 155);
            RbtnItbis18.Name = "RbtnItbis18";
            RbtnItbis18.Size = new Size(47, 19);
            RbtnItbis18.TabIndex = 44;
            RbtnItbis18.TabStop = true;
            RbtnItbis18.Text = "18%";
            RbtnItbis18.UseVisualStyleBackColor = true;
            // 
            // RbtnItbis10
            // 
            RbtnItbis10.AutoSize = true;
            RbtnItbis10.Location = new Point(257, 155);
            RbtnItbis10.Name = "RbtnItbis10";
            RbtnItbis10.Size = new Size(47, 19);
            RbtnItbis10.TabIndex = 43;
            RbtnItbis10.TabStop = true;
            RbtnItbis10.Text = "10%";
            RbtnItbis10.UseVisualStyleBackColor = true;
            // 
            // EbtnNoItebis
            // 
            EbtnNoItebis.AutoSize = true;
            EbtnNoItebis.Location = new Point(152, 155);
            EbtnNoItebis.Name = "EbtnNoItebis";
            EbtnNoItebis.Size = new Size(99, 19);
            EbtnNoItebis.TabIndex = 42;
            EbtnNoItebis.TabStop = true;
            EbtnNoItebis.Text = "NO ITBIS (0%)";
            EbtnNoItebis.UseVisualStyleBackColor = true;
            // 
            // lbItbis
            // 
            lbItbis.AutoSize = true;
            lbItbis.Location = new Point(12, 155);
            lbItbis.Name = "lbItbis";
            lbItbis.Size = new Size(65, 15);
            lbItbis.TabIndex = 41;
            lbItbis.Text = "Tasa ITBIS: ";
            // 
            // lbAregarProducto
            // 
            lbAregarProducto.AutoSize = true;
            lbAregarProducto.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAregarProducto.Location = new Point(16, 20);
            lbAregarProducto.Name = "lbAregarProducto";
            lbAregarProducto.Size = new Size(205, 30);
            lbAregarProducto.TabIndex = 40;
            lbAregarProducto.Text = "Modificar Producto";
            // 
            // txCodigoBarras
            // 
            txCodigoBarras.Location = new Point(152, 63);
            txCodigoBarras.Name = "txCodigoBarras";
            txCodigoBarras.Size = new Size(170, 23);
            txCodigoBarras.TabIndex = 39;
            // 
            // lbCodigoBarra
            // 
            lbCodigoBarra.AutoSize = true;
            lbCodigoBarra.Location = new Point(14, 66);
            lbCodigoBarra.Name = "lbCodigoBarra";
            lbCodigoBarra.Size = new Size(97, 15);
            lbCodigoBarra.TabIndex = 38;
            lbCodigoBarra.Text = "Codigo de Barras";
            // 
            // txNombreProducto
            // 
            txNombreProducto.Location = new Point(152, 92);
            txNombreProducto.Name = "txNombreProducto";
            txNombreProducto.Size = new Size(588, 23);
            txNombreProducto.TabIndex = 37;
            // 
            // numericUpDownPrecioVenta
            // 
            numericUpDownPrecioVenta.Location = new Point(570, 122);
            numericUpDownPrecioVenta.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownPrecioVenta.Name = "numericUpDownPrecioVenta";
            numericUpDownPrecioVenta.Size = new Size(170, 23);
            numericUpDownPrecioVenta.TabIndex = 36;
            // 
            // numericUpDownPrecioCompra
            // 
            numericUpDownPrecioCompra.Location = new Point(152, 122);
            numericUpDownPrecioCompra.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownPrecioCompra.Name = "numericUpDownPrecioCompra";
            numericUpDownPrecioCompra.Size = new Size(170, 23);
            numericUpDownPrecioCompra.TabIndex = 35;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Teal;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(151, 318);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 34);
            btnGuardar.TabIndex = 34;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // lbPrecioVenta
            // 
            lbPrecioVenta.AutoSize = true;
            lbPrecioVenta.Location = new Point(444, 127);
            lbPrecioVenta.Name = "lbPrecioVenta";
            lbPrecioVenta.Size = new Size(88, 15);
            lbPrecioVenta.TabIndex = 33;
            lbPrecioVenta.Text = "Precio de venta";
            // 
            // lbPrecioCompra
            // 
            lbPrecioCompra.AutoSize = true;
            lbPrecioCompra.Location = new Point(14, 124);
            lbPrecioCompra.Name = "lbPrecioCompra";
            lbPrecioCompra.Size = new Size(100, 15);
            lbPrecioCompra.TabIndex = 32;
            lbPrecioCompra.Text = "Precio de compra";
            // 
            // lbNombreProducto
            // 
            lbNombreProducto.AutoSize = true;
            lbNombreProducto.Location = new Point(12, 95);
            lbNombreProducto.Name = "lbNombreProducto";
            lbNombreProducto.Size = new Size(122, 15);
            lbNombreProducto.TabIndex = 31;
            lbNombreProducto.Text = "Nombre del Producto";
            // 
            // ModificarInventarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkActivo);
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
            Name = "ModificarInventarioForm";
            Text = "ModificarInventarioForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkActivo;
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
        private Label lbAregarProducto;
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