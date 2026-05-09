namespace GBPColmadoNet.UI.Forms.Proveedor
{
    partial class ProveedorList
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
            lbTituloList = new Label();
            proveedorDataGridView = new DataGridView();
            btnCrearProveedor = new Button();
            panelContent = new Panel();
            panelHeader = new Panel();
            btnEliminar = new Button();
            btnModificar = new Button();
            txBuscarProveedor = new TextBox();
            lbBuscar = new Label();
            ((System.ComponentModel.ISupportInitialize)proveedorDataGridView).BeginInit();
            panelContent.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lbTituloList
            // 
            lbTituloList.AutoSize = true;
            lbTituloList.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbTituloList.Location = new Point(12, 19);
            lbTituloList.Name = "lbTituloList";
            lbTituloList.Size = new Size(226, 32);
            lbTituloList.TabIndex = 0;
            lbTituloList.Text = "Listar Proveedores";
            // 
            // proveedorDataGridView
            // 
            proveedorDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            proveedorDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            proveedorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            proveedorDataGridView.Dock = DockStyle.Fill;
            proveedorDataGridView.Location = new Point(0, 0);
            proveedorDataGridView.Name = "proveedorDataGridView";
            proveedorDataGridView.Size = new Size(800, 317);
            proveedorDataGridView.TabIndex = 1;
            // 
            // btnCrearProveedor
            // 
            btnCrearProveedor.FlatStyle = FlatStyle.System;
            btnCrearProveedor.Location = new Point(12, 62);
            btnCrearProveedor.Name = "btnCrearProveedor";
            btnCrearProveedor.Size = new Size(110, 23);
            btnCrearProveedor.TabIndex = 2;
            btnCrearProveedor.Text = "Crear Proveedor";
            btnCrearProveedor.UseVisualStyleBackColor = true;
            btnCrearProveedor.Click += btnCrearProveedor_Click;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(proveedorDataGridView);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 133);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(800, 317);
            panelContent.TabIndex = 4;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(btnEliminar);
            panelHeader.Controls.Add(btnModificar);
            panelHeader.Controls.Add(btnCrearProveedor);
            panelHeader.Controls.Add(txBuscarProveedor);
            panelHeader.Controls.Add(lbBuscar);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 133);
            panelHeader.TabIndex = 5;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(232, 62);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(128, 62);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 23);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txBuscarProveedor
            // 
            txBuscarProveedor.Location = new Point(625, 62);
            txBuscarProveedor.Name = "txBuscarProveedor";
            txBuscarProveedor.Size = new Size(163, 23);
            txBuscarProveedor.TabIndex = 2;
            txBuscarProveedor.TextChanged += txBuscarProveedor_TextChanged;
            // 
            // lbBuscar
            // 
            lbBuscar.AutoSize = true;
            lbBuscar.Location = new Point(625, 44);
            lbBuscar.Name = "lbBuscar";
            lbBuscar.Size = new Size(99, 15);
            lbBuscar.TabIndex = 3;
            lbBuscar.Text = "Buscar Proveedor";
            // 
            // ProveedorList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbTituloList);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Name = "ProveedorList";
            Text = "Proveedores";
            Load += ProveedorList_Load;
            ((System.ComponentModel.ISupportInitialize)proveedorDataGridView).EndInit();
            panelContent.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbTituloList;
        private System.Windows.Forms.DataGridView proveedorDataGridView;
        private System.Windows.Forms.Button btnCrearProveedor;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txBuscarProveedor;
        private System.Windows.Forms.Label lbBuscar;
    }
}