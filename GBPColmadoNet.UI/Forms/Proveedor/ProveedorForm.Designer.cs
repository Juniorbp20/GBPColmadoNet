namespace GBPColmadoNet.UI.Forms.Proveedor
{
    partial class ProveedorForm
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
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            lblNombre = new Label();
            lblRnc = new Label();
            lblTelefono = new Label();
            txtNombre = new TextBox();
            txtRnc = new TextBox();
            txtTelefono = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            errorProviderProveedor = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderProveedor).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(230, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(179, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión Proveedor";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(50, 80);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblRnc
            // 
            lblRnc.AutoSize = true;
            lblRnc.Location = new Point(50, 130);
            lblRnc.Name = "lblRnc";
            lblRnc.Size = new Size(34, 15);
            lblRnc.TabIndex = 2;
            lblRnc.Text = "RNC:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(50, 180);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 77);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(400, 25);
            txtNombre.TabIndex = 4;
            // 
            // txtRnc
            // 
            txtRnc.Location = new Point(150, 127);
            txtRnc.Multiline = true;
            txtRnc.Name = "txtRnc";
            txtRnc.Size = new Size(400, 25);
            txtRnc.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(150, 177);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(400, 25);
            txtTelefono.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Teal;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(205, 236);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 35);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.FlatStyle = FlatStyle.System;
            btnCancelar.Location = new Point(345, 236);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 35);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProviderProveedor
            // 
            errorProviderProveedor.ContainerControl = this;
            // 
            // ProveedorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 320);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtTelefono);
            Controls.Add(txtRnc);
            Controls.Add(txtNombre);
            Controls.Add(lblTelefono);
            Controls.Add(lblRnc);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProveedorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestión de Proveedores";
            ((System.ComponentModel.ISupportInitialize)errorProviderProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRnc;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRnc;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProviderProveedor;
    }
}