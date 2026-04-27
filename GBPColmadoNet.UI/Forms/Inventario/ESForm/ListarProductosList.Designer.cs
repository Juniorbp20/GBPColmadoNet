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
            btnEntrada = new Button();
            btnSalida = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)productoDataGridView).BeginInit();
            panel1.SuspendLayout();
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
            productoDataGridView.Dock = DockStyle.Bottom;
            productoDataGridView.Location = new Point(0, 91);
            productoDataGridView.Name = "productoDataGridView";
            productoDataGridView.Size = new Size(800, 359);
            productoDataGridView.TabIndex = 1;
            // 
            // btnEntrada
            // 
            btnEntrada.FlatStyle = FlatStyle.System;
            btnEntrada.Location = new Point(24, 62);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(147, 23);
            btnEntrada.TabIndex = 2;
            btnEntrada.Text = "Entrada de Productos";
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnSalida
            // 
            btnSalida.Location = new Point(189, 62);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(139, 23);
            btnSalida.TabIndex = 3;
            btnSalida.Text = "Salida de Productos";
            btnSalida.UseVisualStyleBackColor = true;
            btnSalida.Click += btnSalida_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(productoDataGridView);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 4;
            // 
            // ListarProductosList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbTituloList);
            Controls.Add(btnEntrada);
            Controls.Add(btnSalida);
            Controls.Add(panel1);
            Name = "ListarProductosList";
            Text = "Inventario";
            Load += ESList_Load;
            ((System.ComponentModel.ISupportInitialize)productoDataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTituloList;
        private DataGridView productoDataGridView;
        private Button btnEntrada;
        private Button btnSalida;
        private Panel panel1;
    }
}