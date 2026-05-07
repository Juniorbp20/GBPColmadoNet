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
            grpDatosNegocio = new GroupBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblCiudad = new Label();
            txtCiudadProvincia = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblRnc = new Label();
            txtRnc = new TextBox();
            lblNombreComercial = new Label();
            txtNombreComercial = new TextBox();
            grpParametros = new GroupBox();
            lblMensajeTicket = new Label();
            txtMensajeTicket = new TextBox();
            lblImpresora = new Label();
            cmbImpresora = new ComboBox();
            lblMargenGanancia = new Label();
            numMargenGanancia = new NumericUpDown();
            grpUsuarios = new GroupBox();
            btnCrearUsuario = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            grpDatosNegocio.SuspendLayout();
            grpParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMargenGanancia).BeginInit();
            grpUsuarios.SuspendLayout();
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
            grpDatosNegocio.Location = new Point(20, 20);
            grpDatosNegocio.Name = "grpDatosNegocio";
            grpDatosNegocio.Size = new Size(600, 280);
            grpDatosNegocio.TabIndex = 0;
            grpDatosNegocio.TabStop = false;
            grpDatosNegocio.Text = "Datos del Negocio";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(20, 240);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(102, 15);
            lblDescripcion.TabIndex = 12;
            lblDescripcion.Text = "Descripción corta:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(160, 237);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(420, 23);
            txtDescripcion.TabIndex = 13;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(20, 205);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(108, 15);
            lblCorreo.TabIndex = 10;
            lblCorreo.Text = "Correo electrónico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(160, 202);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(420, 23);
            txtCorreo.TabIndex = 11;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(20, 170);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 8;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(160, 167);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(420, 23);
            txtTelefono.TabIndex = 9;
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(20, 135);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(108, 15);
            lblCiudad.TabIndex = 6;
            lblCiudad.Text = "Ciudad / Provincia:";
            // 
            // txtCiudadProvincia
            // 
            txtCiudadProvincia.Location = new Point(160, 132);
            txtCiudadProvincia.Name = "txtCiudadProvincia";
            txtCiudadProvincia.Size = new Size(420, 23);
            txtCiudadProvincia.TabIndex = 7;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(20, 100);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(160, 97);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(420, 23);
            txtDireccion.TabIndex = 5;
            // 
            // lblRnc
            // 
            lblRnc.AutoSize = true;
            lblRnc.Location = new Point(20, 65);
            lblRnc.Name = "lblRnc";
            lblRnc.Size = new Size(34, 15);
            lblRnc.TabIndex = 2;
            lblRnc.Text = "RNC:";
            // 
            // txtRnc
            // 
            txtRnc.Location = new Point(160, 62);
            txtRnc.Name = "txtRnc";
            txtRnc.Size = new Size(420, 23);
            txtRnc.TabIndex = 3;
            // 
            // lblNombreComercial
            // 
            lblNombreComercial.AutoSize = true;
            lblNombreComercial.Location = new Point(20, 30);
            lblNombreComercial.Name = "lblNombreComercial";
            lblNombreComercial.Size = new Size(111, 15);
            lblNombreComercial.TabIndex = 0;
            lblNombreComercial.Text = "Nombre Comercial:";
            // 
            // txtNombreComercial
            // 
            txtNombreComercial.Location = new Point(160, 27);
            txtNombreComercial.Name = "txtNombreComercial";
            txtNombreComercial.Size = new Size(420, 23);
            txtNombreComercial.TabIndex = 1;
            // 
            // grpParametros
            // 
            grpParametros.Controls.Add(lblMensajeTicket);
            grpParametros.Controls.Add(txtMensajeTicket);
            grpParametros.Controls.Add(lblImpresora);
            grpParametros.Controls.Add(cmbImpresora);
            grpParametros.Controls.Add(lblMargenGanancia);
            grpParametros.Controls.Add(numMargenGanancia);
            grpParametros.Location = new Point(20, 320);
            grpParametros.Name = "grpParametros";
            grpParametros.Size = new Size(600, 140);
            grpParametros.TabIndex = 1;
            grpParametros.TabStop = false;
            grpParametros.Text = "Parámetros del Sistema";
            // 
            // lblMensajeTicket
            // 
            lblMensajeTicket.AutoSize = true;
            lblMensajeTicket.Location = new Point(20, 65);
            lblMensajeTicket.Name = "lblMensajeTicket";
            lblMensajeTicket.Size = new Size(89, 15);
            lblMensajeTicket.TabIndex = 2;
            lblMensajeTicket.Text = "Mensaje Ticket:";
            // 
            // txtMensajeTicket
            // 
            txtMensajeTicket.Location = new Point(160, 62);
            txtMensajeTicket.Name = "txtMensajeTicket";
            txtMensajeTicket.Size = new Size(420, 23);
            txtMensajeTicket.TabIndex = 3;
            // 
            // lblImpresora
            // 
            lblImpresora.AutoSize = true;
            lblImpresora.Location = new Point(20, 30);
            lblImpresora.Name = "lblImpresora";
            lblImpresora.Size = new Size(128, 15);
            lblImpresora.TabIndex = 0;
            lblImpresora.Text = "Impresora por Defecto:";
            // 
            // cmbImpresora
            // 
            cmbImpresora.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbImpresora.FormattingEnabled = true;
            cmbImpresora.Location = new Point(160, 27);
            cmbImpresora.Name = "cmbImpresora";
            cmbImpresora.Size = new Size(420, 23);
            cmbImpresora.TabIndex = 1;
            // 
            // lblMargenGanancia
            // 
            lblMargenGanancia.AutoSize = true;
            lblMargenGanancia.Location = new Point(20, 100);
            lblMargenGanancia.Name = "lblMargenGanancia";
            lblMargenGanancia.Size = new Size(132, 15);
            lblMargenGanancia.TabIndex = 4;
            lblMargenGanancia.Text = "Margen de Ganancia %:";
            // 
            // numMargenGanancia
            // 
            numMargenGanancia.DecimalPlaces = 2;
            numMargenGanancia.Location = new Point(160, 97);
            numMargenGanancia.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numMargenGanancia.Name = "numMargenGanancia";
            numMargenGanancia.Size = new Size(120, 23);
            numMargenGanancia.TabIndex = 5;
            // 
            // grpUsuarios
            // 
            grpUsuarios.Controls.Add(btnCrearUsuario);
            grpUsuarios.Location = new Point(20, 470);
            grpUsuarios.Name = "grpUsuarios";
            grpUsuarios.Size = new Size(600, 65);
            grpUsuarios.TabIndex = 2;
            grpUsuarios.TabStop = false;
            grpUsuarios.Text = "Gestión de Usuarios";
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Location = new Point(20, 25);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(200, 30);
            btnCrearUsuario.TabIndex = 0;
            btnCrearUsuario.Text = "Crear Nuevo Usuario";
            btnCrearUsuario.UseVisualStyleBackColor = true;
            btnCrearUsuario.Click += btnCrearUsuario_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Teal;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(500, 550);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 35);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.Location = new Point(360, 550);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 35);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // ConfiguracionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 600);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(grpUsuarios);
            Controls.Add(grpParametros);
            Controls.Add(grpDatosNegocio);
            Name = "ConfiguracionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuración del Sistema";
            Load += ConfiguracionForm_Load;
            grpDatosNegocio.ResumeLayout(false);
            grpDatosNegocio.PerformLayout();
            grpParametros.ResumeLayout(false);
            grpParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMargenGanancia).EndInit();
            grpUsuarios.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblMargenGanancia;
        private System.Windows.Forms.NumericUpDown numMargenGanancia;
        private System.Windows.Forms.GroupBox grpUsuarios;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}