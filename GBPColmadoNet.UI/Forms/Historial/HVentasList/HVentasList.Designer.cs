namespace GBPColmadoNet.UI.Forms.Historial.HVentasForm
{
    partial class HVentasList
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
            dgvVentas = new DataGridView();
            panelFiltros = new Panel();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            txtCliente = new TextBox();
            lblCliente = new Label();
            dtpHasta = new DateTimePicker();
            lblHasta = new Label();
            dtpDesde = new DateTimePicker();
            lblDesde = new Label();
            btnReimprimir = new Button();
            panelTop.SuspendLayout();
            panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
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
            panelTop.Size = new Size(950, 60);
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
            lblTitulo.Size = new Size(209, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Historial de Ventas";
            // 
            // panelCentral
            // 
            panelCentral.Controls.Add(dgvVentas);
            panelCentral.Controls.Add(panelFiltros);
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 60);
            panelCentral.Name = "panelCentral";
            panelCentral.Padding = new Padding(20);
            panelCentral.Size = new Size(950, 490);
            panelCentral.TabIndex = 1;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = Color.White;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Dock = DockStyle.Fill;
            dgvVentas.Location = new Point(20, 80);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(910, 390);
            dgvVentas.TabIndex = 1;
            // 
            // panelFiltros
            // 
            panelFiltros.Controls.Add(btnReimprimir);
            panelFiltros.Controls.Add(btnLimpiar);
            panelFiltros.Controls.Add(btnBuscar);
            panelFiltros.Controls.Add(txtCliente);
            panelFiltros.Controls.Add(lblCliente);
            panelFiltros.Controls.Add(dtpHasta);
            panelFiltros.Controls.Add(lblHasta);
            panelFiltros.Controls.Add(dtpDesde);
            panelFiltros.Controls.Add(lblDesde);
            panelFiltros.Dock = DockStyle.Top;
            panelFiltros.Location = new Point(20, 20);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(910, 60);
            panelFiltros.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.System;
            btnLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.Location = new Point(689, 15);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(69, 30);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Transparent;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.System;
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(597, 16);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(74, 30);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Segoe UI", 10F);
            txtCliente.Location = new Point(402, 16);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(180, 25);
            txtCliente.TabIndex = 5;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 10F);
            lblCliente.Location = new Point(342, 17);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(54, 19);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "Cliente:";
            // 
            // dtpHasta
            // 
            dtpHasta.Font = new Font("Segoe UI", 10F);
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(226, 14);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(110, 25);
            dtpHasta.TabIndex = 3;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 10F);
            lblHasta.Location = new Point(173, 17);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(47, 19);
            lblHasta.TabIndex = 2;
            lblHasta.Text = "Hasta:";
            lblHasta.Click += lblHasta_Click;
            // 
            // dtpDesde
            // 
            dtpDesde.Font = new Font("Segoe UI", 10F);
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(57, 14);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(110, 25);
            dtpDesde.TabIndex = 1;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 10F);
            lblDesde.Location = new Point(1, 17);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(50, 19);
            lblDesde.TabIndex = 0;
            lblDesde.Text = "Desde:";
            // 
            // btnReimprimir
            // 
            btnReimprimir.Location = new Point(775, 17);
            btnReimprimir.Name = "btnReimprimir";
            btnReimprimir.Size = new Size(132, 29);
            btnReimprimir.TabIndex = 8;
            btnReimprimir.Text = "Reimprimir Factura";
            btnReimprimir.UseVisualStyleBackColor = true;
            btnReimprimir.Click += btnReimprimir_Click;
            // 
            // HVentasList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(950, 550);
            Controls.Add(panelCentral);
            Controls.Add(panelTop);
            Name = "HVentasList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historial de Ventas";
            Load += HVentasList_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private Button btnReimprimir;
    }
}