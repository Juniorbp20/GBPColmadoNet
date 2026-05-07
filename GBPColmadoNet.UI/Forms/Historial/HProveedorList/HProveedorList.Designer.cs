namespace GBPColmadoNet.UI.Forms.Historial.HProveedorList
{
    partial class HProveedorList
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
            panelTop = new Panel();
            lblTitulo = new Label();
            panelCentral = new Panel();
            dgvHistorialProveedor = new DataGridView();
            panelFiltros = new Panel();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            txtBusquedaProveedor = new TextBox();
            lblBuscar = new Label();
            panelTop.SuspendLayout();
            panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialProveedor).BeginInit();
            panelFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(224, 224, 224);
            panelTop.Controls.Add(lblTitulo);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(900, 60);
            panelTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(269, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Historial de Proveedores";
            // 
            // panelCentral
            // 
            panelCentral.Controls.Add(dgvHistorialProveedor);
            panelCentral.Controls.Add(panelFiltros);
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 60);
            panelCentral.Name = "panelCentral";
            panelCentral.Padding = new Padding(20);
            panelCentral.Size = new Size(900, 490);
            panelCentral.TabIndex = 1;
            // 
            // dgvHistorialProveedor
            // 
            dgvHistorialProveedor.AllowUserToAddRows = false;
            dgvHistorialProveedor.AllowUserToDeleteRows = false;
            dgvHistorialProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialProveedor.BackgroundColor = Color.White;
            dgvHistorialProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialProveedor.Dock = DockStyle.Fill;
            dgvHistorialProveedor.Location = new Point(20, 80);
            dgvHistorialProveedor.Name = "dgvHistorialProveedor";
            dgvHistorialProveedor.ReadOnly = true;
            dgvHistorialProveedor.RowHeadersVisible = false;
            dgvHistorialProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorialProveedor.Size = new Size(860, 390);
            dgvHistorialProveedor.TabIndex = 1;
            // 
            // panelFiltros
            // 
            panelFiltros.Controls.Add(btnLimpiar);
            panelFiltros.Controls.Add(btnBuscar);
            panelFiltros.Controls.Add(txtBusquedaProveedor);
            panelFiltros.Controls.Add(lblBuscar);
            panelFiltros.Dock = DockStyle.Top;
            panelFiltros.Location = new Point(20, 20);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(860, 60);
            panelFiltros.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(200, 200, 200);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.Location = new Point(550, 10);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 30);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(30, 150, 255);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(440, 10);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 30);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBusquedaProveedor
            // 
            txtBusquedaProveedor.Font = new Font("Segoe UI", 10F);
            txtBusquedaProveedor.Location = new Point(150, 12);
            txtBusquedaProveedor.Name = "txtBusquedaProveedor";
            txtBusquedaProveedor.Size = new Size(280, 25);
            txtBusquedaProveedor.TabIndex = 1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 10F);
            lblBuscar.Location = new Point(0, 15);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(144, 19);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar por Proveedor:";
            // 
            // HProveedorList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(900, 550);
            Controls.Add(panelCentral);
            Controls.Add(panelTop);
            Name = "HProveedorList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historial de Proveedores";
            Load += HProveedorList_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorialProveedor).EndInit();
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.DataGridView dgvHistorialProveedor;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusquedaProveedor;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}