namespace GBPColmadoNet.UI.Forms
{
    partial class EForm
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
            ((System.ComponentModel.ISupportInitialize)errorProviderES).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioVenta).BeginInit();
            SuspendLayout();
            // 
            // lbNombreProducto
            // 
            lbNombreProducto.AutoSize = true;
            lbNombreProducto.Location = new Point(12, 60);
            lbNombreProducto.Name = "lbNombreProducto";
            lbNombreProducto.Size = new Size(122, 15);
            lbNombreProducto.TabIndex = 0;
            lbNombreProducto.Text = "Nombre del Producto";
            // 
            // lbPrecioCompra
            // 
            lbPrecioCompra.AutoSize = true;
            lbPrecioCompra.Location = new Point(14, 89);
            lbPrecioCompra.Name = "lbPrecioCompra";
            lbPrecioCompra.Size = new Size(100, 15);
            lbPrecioCompra.TabIndex = 2;
            lbPrecioCompra.Text = "Precio de compra";
            // 
            // lbPrecioVenta
            // 
            lbPrecioVenta.AutoSize = true;
            lbPrecioVenta.Location = new Point(14, 121);
            lbPrecioVenta.Name = "lbPrecioVenta";
            lbPrecioVenta.Size = new Size(88, 15);
            lbPrecioVenta.TabIndex = 3;
            lbPrecioVenta.Text = "Precio de venta";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(14, 163);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
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
            numericUpDownPrecioCompra.Location = new Point(140, 87);
            numericUpDownPrecioCompra.Name = "numericUpDownPrecioCompra";
            numericUpDownPrecioCompra.Size = new Size(170, 23);
            numericUpDownPrecioCompra.TabIndex = 7;
            // 
            // numericUpDownPrecioVenta
            // 
            numericUpDownPrecioVenta.Location = new Point(140, 116);
            numericUpDownPrecioVenta.Name = "numericUpDownPrecioVenta";
            numericUpDownPrecioVenta.Size = new Size(170, 23);
            numericUpDownPrecioVenta.TabIndex = 8;
            // 
            // txNombreProducto
            // 
            txNombreProducto.Location = new Point(140, 57);
            txNombreProducto.Name = "txNombreProducto";
            txNombreProducto.Size = new Size(170, 23);
            txNombreProducto.TabIndex = 9;
            // 
            // lbCodigoBarra
            // 
            lbCodigoBarra.AutoSize = true;
            lbCodigoBarra.Location = new Point(14, 31);
            lbCodigoBarra.Name = "lbCodigoBarra";
            lbCodigoBarra.Size = new Size(97, 15);
            lbCodigoBarra.TabIndex = 10;
            lbCodigoBarra.Text = "Codigo de Barras";
            // 
            // txCodigoBarras
            // 
            txCodigoBarras.Location = new Point(140, 28);
            txCodigoBarras.Name = "txCodigoBarras";
            txCodigoBarras.Size = new Size(170, 23);
            txCodigoBarras.TabIndex = 11;
            // 
            // ESForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(txCodigoBarras);
            Controls.Add(lbCodigoBarra);
            Controls.Add(txNombreProducto);
            Controls.Add(numericUpDownPrecioVenta);
            Controls.Add(numericUpDownPrecioCompra);
            Controls.Add(btnGuardar);
            Controls.Add(lbPrecioVenta);
            Controls.Add(lbPrecioCompra);
            Controls.Add(lbNombreProducto);
            Name = "ESForm";
            Text = "InventarioForm";
            ((System.ComponentModel.ISupportInitialize)errorProviderES).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioVenta).EndInit();
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
    }
}