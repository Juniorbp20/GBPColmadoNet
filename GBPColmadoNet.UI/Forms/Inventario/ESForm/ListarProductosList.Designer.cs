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
            this.btnCreaProductos = new Button();
            btnEntradaProductos = new Button();
            panelContent = new Panel();
            PanelHeder = new Panel();
            ((System.ComponentModel.ISupportInitialize)productoDataGridView).BeginInit();
            panelContent.SuspendLayout();
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
            productoDataGridView.Size = new Size(800, 350);
            productoDataGridView.TabIndex = 1;
            // 
            // btnCreaProducto
            // 
            this.btnCreaProductos.FlatStyle = FlatStyle.System;
            this.btnCreaProductos.Location = new Point(12, 62);
            this.btnCreaProductos.Name = "btnCreaProducto";
            this.btnCreaProductos.Size = new Size(147, 23);
            this.btnCreaProductos.TabIndex = 2;
            this.btnCreaProductos.Text = "Crear Productos";
            this.btnCreaProductos.UseVisualStyleBackColor = true;
            this.btnCreaProductos.Click += this.btnEntrada_Click;
            // 
            // btnEntradaProductos
            // 
            btnEntradaProductos.Location = new Point(165, 62);
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
            panelContent.Location = new Point(0, 100);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(800, 350);
            panelContent.TabIndex = 4;
            // 
            // PanelHeder
            // 
            PanelHeder.Dock = DockStyle.Top;
            PanelHeder.Location = new Point(0, 0);
            PanelHeder.Name = "PanelHeder";
            PanelHeder.Size = new Size(800, 100);
            PanelHeder.TabIndex = 5;
            // 
            // ListarProductosList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbTituloList);
            Controls.Add(this.btnCreaProductos);
            Controls.Add(btnEntradaProductos);
            Controls.Add(panelContent);
            Controls.Add(PanelHeder);
            Name = "ListarProductosList";
            Text = "Inventario";
            Load += ESList_Load;
            ((System.ComponentModel.ISupportInitialize)productoDataGridView).EndInit();
            panelContent.ResumeLayout(false);
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
    }
}