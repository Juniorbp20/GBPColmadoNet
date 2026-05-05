namespace GBPColmadoNet.UI.Forms.Inventario.ESForm
{
    partial class ListarProductosList
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lbTituloList = new Label();
            productoDataGridView = new DataGridView();
            btnCreaProductos = new Button();
            btnEntradaProductos = new Button();
            panelContent = new Panel();
            PanelHeder = new Panel();
            lbSalidaProductoss = new Button();
            lbBuscar = new Label();
            txBuscarProducto = new TextBox();
            btnELiminar = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)productoDataGridView).BeginInit();
            panelContent.SuspendLayout();
            PanelHeder.SuspendLayout();
            SuspendLayout();
            // 
            // lbTituloList
            // 
            lbTituloList.AutoSize = true;
            lbTituloList.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloList.Location = new Point(12, 19);
            lbTituloList.Name = "lbTituloList";
            lbTituloList.Size = new Size(200, 32);
            lbTituloList.TabIndex = 0;
            lbTituloList.Text = "Listar Productos";
            lbTituloList.Click += lbTituloList_Click;
            // 
            // productoDataGridView
            // 
            productoDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productoDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            productoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            productoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            productoDataGridView.Dock = DockStyle.Fill;
            productoDataGridView.Location = new Point(0, 0);
            productoDataGridView.Name = "productoDataGridView";
            productoDataGridView.Size = new Size(800, 317);
            productoDataGridView.TabIndex = 1;
            // 
            // btnCreaProductos
            // 
            btnCreaProductos.FlatStyle = FlatStyle.System;
            btnCreaProductos.Location = new Point(12, 62);
            btnCreaProductos.Name = "btnCreaProductos";
            btnCreaProductos.Size = new Size(98, 23);
            btnCreaProductos.TabIndex = 2;
            btnCreaProductos.Text = "Crear Productos";
            btnCreaProductos.UseVisualStyleBackColor = true;
            btnCreaProductos.Click += btnEntrada_Click;
            // 
            // btnEntradaProductos
            // 
            btnEntradaProductos.Location = new Point(12, 91);
            btnEntradaProductos.Name = "btnEntradaProductos";
            btnEntradaProductos.Size = new Size(139, 23);
            btnEntradaProductos.TabIndex = 3;
            btnEntradaProductos.Text = "Entrada de Productos";
            btnEntradaProductos.UseVisualStyleBackColor = true;
            btnEntradaProductos.Click += btnSalida_Click;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(productoDataGridView);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 133);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(800, 317);
            panelContent.TabIndex = 4;
            // 
            // PanelHeder
            // 
            PanelHeder.Controls.Add(lbSalidaProductoss);
            PanelHeder.Controls.Add(lbBuscar);
            PanelHeder.Controls.Add(btnEntradaProductos);
            PanelHeder.Controls.Add(txBuscarProducto);
            PanelHeder.Controls.Add(btnELiminar);
            PanelHeder.Controls.Add(btnModificar);
            PanelHeder.Dock = DockStyle.Top;
            PanelHeder.Location = new Point(0, 0);
            PanelHeder.Name = "PanelHeder";
            PanelHeder.Size = new Size(800, 133);
            PanelHeder.TabIndex = 5;
            // 
            // lbSalidaProductoss
            // 
            lbSalidaProductoss.Location = new Point(157, 91);
            lbSalidaProductoss.Name = "lbSalidaProductoss";
            lbSalidaProductoss.Size = new Size(136, 23);
            lbSalidaProductoss.TabIndex = 4;
            lbSalidaProductoss.Text = "Salida de Productos";
            lbSalidaProductoss.UseVisualStyleBackColor = true;
            lbSalidaProductoss.Click += lbSalidaProductoss_Click;
            // 
            // lbBuscar
            // 
            lbBuscar.AutoSize = true;
            lbBuscar.Location = new Point(625, 44);
            lbBuscar.Name = "lbBuscar";
            lbBuscar.Size = new Size(94, 15);
            lbBuscar.TabIndex = 3;
            lbBuscar.Text = "Buscar Producto";
            // 
            // txBuscarProducto
            // 
            txBuscarProducto.Location = new Point(625, 62);
            txBuscarProducto.Name = "txBuscarProducto";
            txBuscarProducto.Size = new Size(163, 23);
            txBuscarProducto.TabIndex = 2;
            txBuscarProducto.TextChanged += txBuscarProducto_TextChanged;
            // 
            // btnELiminar
            // 
            btnELiminar.Location = new Point(218, 62);
            btnELiminar.Name = "btnELiminar";
            btnELiminar.Size = new Size(75, 23);
            btnELiminar.TabIndex = 1;
            btnELiminar.Text = "Eliminar";
            btnELiminar.UseVisualStyleBackColor = true;
            btnELiminar.Click += btnELiminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(114, 62);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 23);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // ListarProductosList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbTituloList);
            Controls.Add(btnCreaProductos);
            Controls.Add(panelContent);
            Controls.Add(PanelHeder);
            Name = "ListarProductosList";
            Text = "Inventario";
            Load += ESList_Load;
            ((System.ComponentModel.ISupportInitialize)productoDataGridView).EndInit();
            panelContent.ResumeLayout(false);
            PanelHeder.ResumeLayout(false);
            PanelHeder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTituloList;
        private DataGridView productoDataGridView;
        private Button btnCreaProductos;
        private Button btnEntradaProductos;
        private Panel panelContent;
        private Panel PanelHeder;
        private Button btnModificar;
        private Button btnELiminar;
        private TextBox txBuscarProducto;
        private Label lbBuscar;
        private Button lbSalidaProductoss;
    }
}