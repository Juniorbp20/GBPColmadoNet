namespace GBPColmadoNet.UI.Forms.Clientes
{
    partial class ClienteList
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
            this.lbTituloList = new System.Windows.Forms.Label();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txBuscarCliente = new System.Windows.Forms.TextBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            this.panelContent.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTituloList
            // 
            this.lbTituloList.AutoSize = true;
            this.lbTituloList.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbTituloList.Location = new System.Drawing.Point(12, 19);
            this.lbTituloList.Name = "lbTituloList";
            this.lbTituloList.Size = new System.Drawing.Size(123, 32);
            this.lbTituloList.TabIndex = 0;
            this.lbTituloList.Text = "Listar Clientes";
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clienteDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clienteDataGridView.Location = new System.Drawing.Point(0, 0);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.Size = new System.Drawing.Size(800, 317);
            this.clienteDataGridView.TabIndex = 1;
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCrearCliente.Location = new System.Drawing.Point(12, 62);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Size = new System.Drawing.Size(95, 23);
            this.btnCrearCliente.TabIndex = 2;
            this.btnCrearCliente.Text = "Crear Cliente";
            this.btnCrearCliente.UseVisualStyleBackColor = true;
            this.btnCrearCliente.Click += new System.EventHandler(this.btnCrearCliente_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.clienteDataGridView);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 133);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 317);
            this.panelContent.TabIndex = 4;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.btnEliminar);
            this.panelHeader.Controls.Add(this.btnModificar);
            this.panelHeader.Controls.Add(this.btnCrearCliente);
            this.panelHeader.Controls.Add(this.txBuscarCliente);
            this.panelHeader.Controls.Add(this.lbBuscar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 133);
            this.panelHeader.TabIndex = 5;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(218, 62);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(114, 62);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 23);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txBuscarCliente
            // 
            this.txBuscarCliente.Location = new System.Drawing.Point(625, 62);
            this.txBuscarCliente.Name = "txBuscarCliente";
            this.txBuscarCliente.Size = new System.Drawing.Size(163, 23);
            this.txBuscarCliente.TabIndex = 2;
            this.txBuscarCliente.TextChanged += new System.EventHandler(this.txBuscarCliente_TextChanged);
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Location = new System.Drawing.Point(625, 44);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(88, 15);
            this.lbBuscar.TabIndex = 3;
            this.lbBuscar.Text = "Buscar Cliente";
            // 
            // ClienteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTituloList);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Name = "ClienteList";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ClienteList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbTituloList;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.Button btnCrearCliente;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txBuscarCliente;
        private System.Windows.Forms.Label lbBuscar;
    }
}