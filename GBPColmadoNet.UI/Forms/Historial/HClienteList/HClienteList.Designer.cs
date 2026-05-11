namespace GBPColmadoNet.UI.Forms.Historial.HProveedorList
{
    partial class HClienteList
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
            dgvHistorialCliente = new DataGridView();
            panelFiltros = new Panel();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            txtBusquedaCliente = new TextBox();
            lblBuscar = new Label();
            panelTop.SuspendLayout();
            panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialCliente).BeginInit();
            panelFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.Teal;
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
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(221, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Historial de Clientes";
            // 
            // panelCentral
            // 
            panelCentral.Controls.Add(dgvHistorialCliente);
            panelCentral.Controls.Add(panelFiltros);
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 60);
            panelCentral.Name = "panelCentral";
            panelCentral.Padding = new Padding(20);
            panelCentral.Size = new Size(900, 490);
            panelCentral.TabIndex = 1;
            // 
            // dgvHistorialCliente
            // 
            dgvHistorialCliente.AllowUserToAddRows = false;
            dgvHistorialCliente.AllowUserToDeleteRows = false;
            dgvHistorialCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialCliente.BackgroundColor = Color.White;
            dgvHistorialCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialCliente.Dock = DockStyle.Fill;
            dgvHistorialCliente.Location = new Point(20, 80);
            dgvHistorialCliente.Name = "dgvHistorialCliente";
            dgvHistorialCliente.ReadOnly = true;
            dgvHistorialCliente.RowHeadersVisible = false;
            dgvHistorialCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorialCliente.Size = new Size(860, 390);
            dgvHistorialCliente.TabIndex = 1;
            // 
            // panelFiltros
            // 
            panelFiltros.Controls.Add(btnLimpiar);
            panelFiltros.Controls.Add(btnBuscar);
            panelFiltros.Controls.Add(txtBusquedaCliente);
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
            btnLimpiar.FlatStyle = FlatStyle.System;
            btnLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.Location = new Point(554, 12);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 30);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(30, 150, 255);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.System;
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(444, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 30);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBusquedaCliente
            // 
            txtBusquedaCliente.Font = new Font("Segoe UI", 10F);
            txtBusquedaCliente.Location = new Point(134, 14);
            txtBusquedaCliente.Name = "txtBusquedaCliente";
            txtBusquedaCliente.Size = new Size(300, 25);
            txtBusquedaCliente.TabIndex = 1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 10F);
            lblBuscar.Location = new Point(4, 17);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(123, 19);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar por Cliente:";
            // 
            // HClienteList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(900, 550);
            Controls.Add(panelCentral);
            Controls.Add(panelTop);
            Name = "HClienteList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historial de Clientes";
            Load += HClienteList_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorialCliente).EndInit();
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.DataGridView dgvHistorialCliente;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusquedaCliente;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}