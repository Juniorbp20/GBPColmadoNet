namespace GBPColmadoNet.UI.Forms.Inventario.Devoluciones
{
    partial class DevolucionesList
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
            this.devolucionDataGridView = new System.Windows.Forms.DataGridView();
            this.btnRegistrarDevolucion = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.txBuscarDevolucion = new System.Windows.Forms.TextBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionDataGridView)).BeginInit();
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
            this.lbTituloList.Size = new System.Drawing.Size(168, 32);
            this.lbTituloList.TabIndex = 0;
            this.lbTituloList.Text = "Listar Devoluciones";
            // 
            // devolucionDataGridView
            // 
            this.devolucionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.devolucionDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.devolucionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devolucionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devolucionDataGridView.Location = new System.Drawing.Point(0, 0);
            this.devolucionDataGridView.Name = "devolucionDataGridView";
            this.devolucionDataGridView.Size = new System.Drawing.Size(800, 350);
            this.devolucionDataGridView.TabIndex = 1;
            // 
            // btnRegistrarDevolucion
            // 
            this.btnRegistrarDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRegistrarDevolucion.Location = new System.Drawing.Point(12, 62);
            this.btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            this.btnRegistrarDevolucion.Size = new System.Drawing.Size(140, 23);
            this.btnRegistrarDevolucion.TabIndex = 2;
            this.btnRegistrarDevolucion.Text = "Registrar Devolución";
            this.btnRegistrarDevolucion.UseVisualStyleBackColor = true;
            this.btnRegistrarDevolucion.Click += new System.EventHandler(this.btnRegistrarDevolucion_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.devolucionDataGridView);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 100);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 350);
            this.panelContent.TabIndex = 4;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.btnRegistrarDevolucion);
            this.panelHeader.Controls.Add(this.txBuscarDevolucion);
            this.panelHeader.Controls.Add(this.lbBuscar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 100);
            this.panelHeader.TabIndex = 5;
            // 
            // txBuscarDevolucion
            // 
            this.txBuscarDevolucion.Location = new System.Drawing.Point(625, 62);
            this.txBuscarDevolucion.Name = "txBuscarDevolucion";
            this.txBuscarDevolucion.Size = new System.Drawing.Size(163, 23);
            this.txBuscarDevolucion.TabIndex = 2;
            this.txBuscarDevolucion.TextChanged += new System.EventHandler(this.txBuscarDevolucion_TextChanged);
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Location = new System.Drawing.Point(625, 44);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(110, 15);
            this.lbBuscar.TabIndex = 3;
            this.lbBuscar.Text = "Buscar Devolución";
            // 
            // DevolucionesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTituloList);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Name = "DevolucionesList";
            this.Text = "Devoluciones";
            this.Load += new System.EventHandler(this.DevolucionesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.devolucionDataGridView)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbTituloList;
        private System.Windows.Forms.DataGridView devolucionDataGridView;
        private System.Windows.Forms.Button btnRegistrarDevolucion;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TextBox txBuscarDevolucion;
        private System.Windows.Forms.Label lbBuscar;
    }
}