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
            lbTituloList = new Label();
            devolucionDataGridView = new DataGridView();
            btnRegistrarDevolucion = new Button();
            panelContent = new Panel();
            panelHeader = new Panel();
            txBuscarDevolucion = new TextBox();
            lbBuscar = new Label();
            ((System.ComponentModel.ISupportInitialize)devolucionDataGridView).BeginInit();
            panelContent.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lbTituloList
            // 
            lbTituloList.AutoSize = true;
            lbTituloList.BackColor = SystemColors.Control;
            lbTituloList.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbTituloList.ForeColor = Color.Black;
            lbTituloList.Location = new Point(12, 19);
            lbTituloList.Name = "lbTituloList";
            lbTituloList.Size = new Size(237, 32);
            lbTituloList.TabIndex = 0;
            lbTituloList.Text = "Listar Devoluciones";
            // 
            // devolucionDataGridView
            // 
            devolucionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            devolucionDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            devolucionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            devolucionDataGridView.Dock = DockStyle.Fill;
            devolucionDataGridView.Location = new Point(0, 0);
            devolucionDataGridView.Name = "devolucionDataGridView";
            devolucionDataGridView.Size = new Size(800, 350);
            devolucionDataGridView.TabIndex = 1;
            // 
            // btnRegistrarDevolucion
            // 
            btnRegistrarDevolucion.FlatStyle = FlatStyle.System;
            btnRegistrarDevolucion.Location = new Point(12, 62);
            btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            btnRegistrarDevolucion.Size = new Size(140, 23);
            btnRegistrarDevolucion.TabIndex = 2;
            btnRegistrarDevolucion.Text = "Registrar Devolución";
            btnRegistrarDevolucion.UseVisualStyleBackColor = true;
            btnRegistrarDevolucion.Click += btnRegistrarDevolucion_Click;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(devolucionDataGridView);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 100);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(800, 350);
            panelContent.TabIndex = 4;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.Control;
            panelHeader.Controls.Add(btnRegistrarDevolucion);
            panelHeader.Controls.Add(txBuscarDevolucion);
            panelHeader.Controls.Add(lbBuscar);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 100);
            panelHeader.TabIndex = 5;
            // 
            // txBuscarDevolucion
            // 
            txBuscarDevolucion.Location = new Point(625, 62);
            txBuscarDevolucion.Name = "txBuscarDevolucion";
            txBuscarDevolucion.Size = new Size(163, 23);
            txBuscarDevolucion.TabIndex = 2;
            txBuscarDevolucion.TextChanged += txBuscarDevolucion_TextChanged;
            // 
            // lbBuscar
            // 
            lbBuscar.AutoSize = true;
            lbBuscar.Location = new Point(625, 44);
            lbBuscar.Name = "lbBuscar";
            lbBuscar.Size = new Size(105, 15);
            lbBuscar.TabIndex = 3;
            lbBuscar.Text = "Buscar Devolución";
            // 
            // DevolucionesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbTituloList);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Name = "DevolucionesList";
            Text = "Devoluciones";
            Load += DevolucionesList_Load;
            ((System.ComponentModel.ISupportInitialize)devolucionDataGridView).EndInit();
            panelContent.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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