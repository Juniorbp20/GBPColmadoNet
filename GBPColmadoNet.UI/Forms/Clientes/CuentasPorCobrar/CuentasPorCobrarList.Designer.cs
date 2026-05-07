namespace GBPColmadoNet.UI.Forms.Clientes.CuentasPorCobrar
{
    partial class CuentasPorCobrarList
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
            this.cuentaDataGridView = new System.Windows.Forms.DataGridView();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnAbonar = new System.Windows.Forms.Button();
            this.txBuscarCuenta = new System.Windows.Forms.TextBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaDataGridView)).BeginInit();
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
            this.lbTituloList.Size = new System.Drawing.Size(218, 32);
            this.lbTituloList.TabIndex = 0;
            this.lbTituloList.Text = "Cuentas por Cobrar";
            // 
            // cuentaDataGridView
            // 
            this.cuentaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cuentaDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.cuentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cuentaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuentaDataGridView.Location = new System.Drawing.Point(0, 0);
            this.cuentaDataGridView.Name = "cuentaDataGridView";
            this.cuentaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cuentaDataGridView.Size = new System.Drawing.Size(800, 317);
            this.cuentaDataGridView.TabIndex = 1;
            this.cuentaDataGridView.DoubleClick += new System.EventHandler(this.cuentaDataGridView_DoubleClick);
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCrearCuenta.Location = new System.Drawing.Point(12, 62);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(110, 23);
            this.btnCrearCuenta.TabIndex = 2;
            this.btnCrearCuenta.Text = "Crear Cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.cuentaDataGridView);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 133);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 317);
            this.panelContent.TabIndex = 4;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.btnAbonar);
            this.panelHeader.Controls.Add(this.btnCrearCuenta);
            this.panelHeader.Controls.Add(this.txBuscarCuenta);
            this.panelHeader.Controls.Add(this.lbBuscar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 133);
            this.panelHeader.TabIndex = 5;
            // 
            // btnAbonar
            // 
            this.btnAbonar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAbonar.Location = new System.Drawing.Point(128, 62);
            this.btnAbonar.Name = "btnAbonar";
            this.btnAbonar.Size = new System.Drawing.Size(75, 23);
            this.btnAbonar.TabIndex = 0;
            this.btnAbonar.Text = "Abonar";
            this.btnAbonar.UseVisualStyleBackColor = true;
            this.btnAbonar.Click += new System.EventHandler(this.btnAbonar_Click);
            // 
            // txBuscarCuenta
            // 
            this.txBuscarCuenta.Location = new System.Drawing.Point(625, 62);
            this.txBuscarCuenta.Name = "txBuscarCuenta";
            this.txBuscarCuenta.Size = new System.Drawing.Size(163, 23);
            this.txBuscarCuenta.TabIndex = 2;
            this.txBuscarCuenta.TextChanged += new System.EventHandler(this.txBuscarCuenta_TextChanged);
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Location = new System.Drawing.Point(625, 44);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(113, 15);
            this.lbBuscar.TabIndex = 3;
            this.lbBuscar.Text = "Buscar Cuenta";
            // 
            // CuentasPorCobrarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTituloList);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Name = "CuentasPorCobrarList";
            this.Text = "Cuentas por Cobrar";
            this.Load += new System.EventHandler(this.CuentasPorCobrarList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuentaDataGridView)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbTituloList;
        private System.Windows.Forms.DataGridView cuentaDataGridView;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnAbonar;
        private System.Windows.Forms.TextBox txBuscarCuenta;
        private System.Windows.Forms.Label lbBuscar;
    }
}