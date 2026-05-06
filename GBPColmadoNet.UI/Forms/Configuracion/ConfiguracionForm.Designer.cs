namespace GBPColmadoNet.UI.Forms.Configuracion
{
    partial class ConfiguracionForm
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

        private void InitializeComponent()
        {
            grpDatosNegocio = new System.Windows.Forms.GroupBox();
            lblDescripcion = new System.Windows.Forms.Label();
            txtDescripcion = new System.Windows.Forms.TextBox();
            lblCorreo = new System.Windows.Forms.Label();
            txtCorreo = new System.Windows.Forms.TextBox();
            lblTelefono = new System.Windows.Forms.Label();
            txtTelefono = new System.Windows.Forms.TextBox();
            lblCiudad = new System.Windows.Forms.Label();
            txtCiudadProvincia = new System.Windows.Forms.TextBox();
            lblDireccion = new System.Windows.Forms.Label();
            txtDireccion = new System.Windows.Forms.TextBox();
            lblRnc = new System.Windows.Forms.Label();
            txtRnc = new System.Windows.Forms.TextBox();
            lblNombreComercial = new System.Windows.Forms.Label();
            txtNombreComercial = new System.Windows.Forms.TextBox();
            grpParametros = new System.Windows.Forms.GroupBox();
            lblMensajeTicket = new System.Windows.Forms.Label();
            txtMensajeTicket = new System.Windows.Forms.TextBox();
            lblImpresora = new System.Windows.Forms.Label();
            cmbImpresora = new System.Windows.Forms.ComboBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            grpDatosNegocio.SuspendLayout();
            grpParametros.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatosNegocio
            // 
            grpDatosNegocio.Controls.Add(lblDescripcion);
            grpDatosNegocio.Controls.Add(txtDescripcion);
            grpDatosNegocio.Controls.Add(lblCorreo);
            grpDatosNegocio.Controls.Add(txtCorreo);
            grpDatosNegocio.Controls.Add(lblTelefono);
            grpDatosNegocio.Controls.Add(txtTelefono);
            grpDatosNegocio.Controls.Add(lblCiudad);
            grpDatosNegocio.Controls.Add(txtCiudadProvincia);
            grpDatosNegocio.Controls.Add(lblDireccion);
            grpDatosNegocio.Controls.Add(txtDireccion);
            grpDatosNegocio.Controls.Add(lblRnc);
            grpDatosNegocio.Controls.Add(txtRnc);
            grpDatosNegocio.Controls.Add(lblNombreComercial);
            grpDatosNegocio.Controls.Add(txtNombreComercial);
            grpDatosNegocio.Location = new System.Drawing.Point(20, 20);
            grpDatosNegocio.Name = "grpDatosNegocio";
            grpDatosNegocio.Size = new System.Drawing.Size(600, 280);
            grpDatosNegocio.TabIndex = 0;
            grpDatosNegocio.TabStop = false;
            grpDatosNegocio.Text = "Datos del Negocio";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new System.Drawing.Point(20, 240);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(99, 15);
            lblDescripcion.TabIndex = 12;
            lblDescripcion.Text = "Descripción corta:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(160, 237);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(420, 23);
            txtDescripcion.TabIndex = 13;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new System.Drawing.Point(20, 205);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new System.Drawing.Size(108, 15);
            lblCorreo.TabIndex = 10;
            lblCorreo.Text = "Correo electrónico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new System.Drawing.Point(160, 202);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new System.Drawing.Size(420, 23);
            txtCorreo.TabIndex = 11;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new System.Drawing.Point(20, 170);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new System.Drawing.Size(55, 15);
            lblTelefono.TabIndex = 8;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(160, 167);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(420, 23);
            txtTelefono.TabIndex = 9;
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new System.Drawing.Point(20, 135);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new System.Drawing.Size(106, 15);
            lblCiudad.TabIndex = 6;
            lblCiudad.Text = "Ciudad / Provincia:";
            // 
            // txtCiudadProvincia
            // 
            txtCiudadProvincia.Location = new System.Drawing.Point(160, 132);
            txtCiudadProvincia.Name = "txtCiudadProvincia";
            txtCiudadProvincia.Size = new System.Drawing.Size(420, 23);
            txtCiudadProvincia.TabIndex = 7;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new System.Drawing.Point(20, 100);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new System.Drawing.Size(60, 15);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new System.Drawing.Point(160, 97);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(420, 23);
            txtDireccion.TabIndex = 5;
            // 
            // lblRnc
            // 
            lblRnc.AutoSize = true;
            lblRnc.Location = new System.Drawing.Point(20, 65);
            lblRnc.Name = "lblRnc";
            lblRnc.Size = new System.Drawing.Size(34, 15);
            lblRnc.TabIndex = 2;
            lblRnc.Text = "RNC:";
            // 
            // txtRnc
            // 
            txtRnc.Location = new System.Drawing.Point(160, 62);
            txtRnc.Name = "txtRnc";
            txtRnc.Size = new System.Drawing.Size(420, 23);
            txtRnc.TabIndex = 3;
            // 
            // lblNombreComercial
            // 
            lblNombreComercial.AutoSize = true;
            lblNombreComercial.Location = new System.Drawing.Point(20, 30);
            lblNombreComercial.Name = "lblNombreComercial";
            lblNombreComercial.Size = new System.Drawing.Size(111, 15);
            lblNombreComercial.TabIndex = 0;
            lblNombreComercial.Text = "Nombre Comercial:";
            // 
            // txtNombreComercial
            // 
            txtNombreComercial.Location = new System.Drawing.Point(160, 27);
            txtNombreComercial.Name = "txtNombreComercial";
            txtNombreComercial.Size = new System.Drawing.Size(420, 23);
            txtNombreComercial.TabIndex = 1;
            // 
            // grpParametros
            // 
            grpParametros.Controls.Add(lblMensajeTicket);
            grpParametros.Controls.Add(txtMensajeTicket);
            grpParametros.Controls.Add(lblImpresora);
            grpParametros.Controls.Add(cmbImpresora);
            grpParametros.Location = new System.Drawing.Point(20, 320);
            grpParametros.Name = "grpParametros";
            grpParametros.Size = new System.Drawing.Size(600, 100);
            grpParametros.TabIndex = 1;
            grpParametros.TabStop = false;
            grpParametros.Text = "Parámetros del Sistema";
            // 
            // lblMensajeTicket
            // 
            lblMensajeTicket.AutoSize = true;
            lblMensajeTicket.Location = new System.Drawing.Point(20, 65);
            lblMensajeTicket.Name = "lblMensajeTicket";
            lblMensajeTicket.Size = new System.Drawing.Size(86, 15);
            lblMensajeTicket.TabIndex = 2;
            lblMensajeTicket.Text = "Mensaje Ticket:";
            // 
            // txtMensajeTicket
            // 
            txtMensajeTicket.Location = new System.Drawing.Point(160, 62);
            txtMensajeTicket.Name = "txtMensajeTicket";
            txtMensajeTicket.Size = new System.Drawing.Size(420, 23);
            txtMensajeTicket.TabIndex = 3;
            // 
            // lblImpresora
            // 
            lblImpresora.AutoSize = true;
            lblImpresora.Location = new System.Drawing.Point(20, 30);
            lblImpresora.Name = "lblImpresora";
            lblImpresora.Size = new System.Drawing.Size(126, 15);
            lblImpresora.TabIndex = 0;
            lblImpresora.Text = "Impresora por Defecto:";
            // 
            // cmbImpresora
            // 
            cmbImpresora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbImpresora.FormattingEnabled = true;
            cmbImpresora.Location = new System.Drawing.Point(160, 27);
            cmbImpresora.Name = "cmbImpresora";
            cmbImpresora.Size = new System.Drawing.Size(420, 23);
            cmbImpresora.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.Color.Teal;
            btnGuardar.ForeColor = System.Drawing.Color.White;
            btnGuardar.Location = new System.Drawing.Point(500, 440);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(120, 35);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Silver;
            btnCancelar.Location = new System.Drawing.Point(360, 440);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(120, 35);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // ConfiguracionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(650, 500);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(grpParametros);
            Controls.Add(grpDatosNegocio);
            Name = "ConfiguracionForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Configuración del Sistema";
            Load += ConfiguracionForm_Load;
            grpDatosNegocio.ResumeLayout(false);
            grpDatosNegocio.PerformLayout();
            grpParametros.ResumeLayout(false);
            grpParametros.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpDatosNegocio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtCiudadProvincia;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblRnc;
        private System.Windows.Forms.TextBox txtRnc;
        private System.Windows.Forms.Label lblNombreComercial;
        private System.Windows.Forms.TextBox txtNombreComercial;
        private System.Windows.Forms.GroupBox grpParametros;
        private System.Windows.Forms.Label lblMensajeTicket;
        private System.Windows.Forms.TextBox txtMensajeTicket;
        private System.Windows.Forms.Label lblImpresora;
        private System.Windows.Forms.ComboBox cmbImpresora;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}