namespace GBPColmadoNet
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
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
            panelHeader = new Panel();
            lblBrandTitle = new Label();
            lblBrandSub = new Label();
            lblCajaAbierta = new Label();
            lblSesionRol = new Label();
            panelMenu = new Panel();
            panelSesion = new Panel();
            lblSesionActiva = new Label();
            lblUsuarioInfo = new Label();
            lblRolInfo = new Label();
            lblFechaInfo = new Label();
            lblHoraInfo = new Label();
            btnInicio = new Button();
            btnListarProductos = new Button();
            btnAgregarProductos = new Button();
            btnNuevaVenta = new Button();
            btnRegistrarCliente = new Button();
            btnRegistrarProveedor = new Button();
            btnHistorialVentas = new Button();
            btnHistorialProveedor = new Button();
            btnHistorialCliente = new Button();
            btnGestionUsuarios = new Button();
            btnConfiguracion = new Button();
            btnCerrarSesion = new Button();
            panelContent = new Panel();
            lblBienvenido = new Label();
            lblPanelActualizado = new Label();
            panelStatsTop = new Panel();
            lblProductosActivosTitle = new Label();
            lblProveedoresPendientesTitle = new Label();
            lblStockCriticoTitle = new Label();
            lblProductosActivosValue = new Label();
            lblProveedoresPendientesValue = new Label();
            lblStockCriticoValue = new Label();
            panelStatsBottom = new Panel();
            lblVentaTotalTitle = new Label();
            lblGananciaEstimadaTitle = new Label();
            lblFiadosPendientesTitle = new Label();
            lblVentaTotalValue = new Label();
            lblGananciaEstimadaValue = new Label();
            lblFiadosPendientesValue = new Label();
            panelHeader.SuspendLayout();
            panelMenu.SuspendLayout();
            panelSesion.SuspendLayout();
            panelContent.SuspendLayout();
            panelStatsTop.SuspendLayout();
            panelStatsBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(209, 209, 209);
            panelHeader.Controls.Add(lblBrandTitle);
            panelHeader.Controls.Add(lblBrandSub);
            panelHeader.Controls.Add(lblCajaAbierta);
            panelHeader.Controls.Add(lblSesionRol);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1024, 56);
            panelHeader.TabIndex = 2;
            // 
            // lblBrandTitle
            // 
            lblBrandTitle.AutoSize = true;
            lblBrandTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBrandTitle.ForeColor = Color.FromArgb(54, 66, 81);
            lblBrandTitle.Location = new Point(4, 2);
            lblBrandTitle.Name = "lblBrandTitle";
            lblBrandTitle.Size = new Size(199, 30);
            lblBrandTitle.TabIndex = 0;
            lblBrandTitle.Text = "GBP Colmado.Net";
            // 
            // lblBrandSub
            // 
            lblBrandSub.AutoSize = true;
            lblBrandSub.Font = new Font("Segoe UI", 10F);
            lblBrandSub.ForeColor = Color.FromArgb(96, 96, 96);
            lblBrandSub.Location = new Point(4, 30);
            lblBrandSub.Name = "lblBrandSub";
            lblBrandSub.Size = new Size(407, 19);
            lblBrandSub.TabIndex = 1;
            lblBrandSub.Text = "Gestiona tu inventario, ventas y proveedores desde un solo lugar";
            // 
            // lblCajaAbierta
            // 
            lblCajaAbierta.AutoSize = true;
            lblCajaAbierta.BackColor = Color.FromArgb(210, 248, 250);
            lblCajaAbierta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCajaAbierta.Location = new Point(675, 15);
            lblCajaAbierta.Name = "lblCajaAbierta";
            lblCajaAbierta.Padding = new Padding(12, 2, 12, 2);
            lblCajaAbierta.Size = new Size(118, 23);
            lblCajaAbierta.TabIndex = 2;
            lblCajaAbierta.Text = "Caja: abierta";
            // 
            // lblSesionRol
            // 
            lblSesionRol.AutoSize = true;
            lblSesionRol.BackColor = Color.FromArgb(210, 248, 250);
            lblSesionRol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSesionRol.Location = new Point(803, 15);
            lblSesionRol.Name = "lblSesionRol";
            lblSesionRol.Padding = new Padding(12, 2, 12, 2);
            lblSesionRol.Size = new Size(201, 23);
            lblSesionRol.TabIndex = 3;
            lblSesionRol.Text = "Sesión: Usuario . ROL: rol";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(44, 67, 93);
            panelMenu.Controls.Add(panelSesion);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 56);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 579);
            panelMenu.TabIndex = 1;
            // 
            // panelSesion
            // 
            panelSesion.BackColor = Color.WhiteSmoke;
            panelSesion.Controls.Add(lblSesionActiva);
            panelSesion.Controls.Add(lblUsuarioInfo);
            panelSesion.Controls.Add(lblRolInfo);
            panelSesion.Controls.Add(lblFechaInfo);
            panelSesion.Controls.Add(lblHoraInfo);
            panelSesion.Location = new Point(8, 6);
            panelSesion.Name = "panelSesion";
            panelSesion.Size = new Size(186, 100);
            panelSesion.TabIndex = 0;
            panelSesion.Paint += panelSesion_Paint_1;
            // 
            // lblSesionActiva
            // 
            lblSesionActiva.AutoSize = true;
            lblSesionActiva.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSesionActiva.Location = new Point(8, 4);
            lblSesionActiva.Name = "lblSesionActiva";
            lblSesionActiva.Size = new Size(110, 21);
            lblSesionActiva.TabIndex = 0;
            lblSesionActiva.Text = "Sesion activa";
            // 
            // lblUsuarioInfo
            // 
            lblUsuarioInfo.AutoSize = true;
            lblUsuarioInfo.Location = new Point(8, 30);
            lblUsuarioInfo.Name = "lblUsuarioInfo";
            lblUsuarioInfo.Size = new Size(47, 15);
            lblUsuarioInfo.TabIndex = 1;
            lblUsuarioInfo.Text = "Usuario";
            // 
            // lblRolInfo
            // 
            lblRolInfo.AutoSize = true;
            lblRolInfo.Location = new Point(8, 48);
            lblRolInfo.Name = "lblRolInfo";
            lblRolInfo.Size = new Size(52, 15);
            lblRolInfo.TabIndex = 2;
            lblRolInfo.Text = "ROL : rol";
            // 
            // lblFechaInfo
            // 
            lblFechaInfo.AutoSize = true;
            lblFechaInfo.Location = new Point(8, 66);
            lblFechaInfo.Name = "lblFechaInfo";
            lblFechaInfo.Size = new Size(74, 15);
            lblFechaInfo.TabIndex = 3;
            lblFechaInfo.Text = "Fecha y hora";
            // 
            // lblHoraInfo
            // 
            lblHoraInfo.AutoSize = true;
            lblHoraInfo.Location = new Point(8, 84);
            lblHoraInfo.Name = "lblHoraInfo";
            lblHoraInfo.Size = new Size(34, 15);
            lblHoraInfo.TabIndex = 4;
            lblHoraInfo.Text = "00:00";
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(114, 328);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(75, 23);
            btnInicio.TabIndex = 1;
            // 
            // btnListarProductos
            // 
            btnListarProductos.Location = new Point(195, 328);
            btnListarProductos.Name = "btnListarProductos";
            btnListarProductos.Size = new Size(75, 23);
            btnListarProductos.TabIndex = 2;
            // 
            // btnAgregarProductos
            // 
            btnAgregarProductos.Location = new Point(276, 328);
            btnAgregarProductos.Name = "btnAgregarProductos";
            btnAgregarProductos.Size = new Size(75, 23);
            btnAgregarProductos.TabIndex = 3;
            // 
            // btnNuevaVenta
            // 
            btnNuevaVenta.Location = new Point(357, 328);
            btnNuevaVenta.Name = "btnNuevaVenta";
            btnNuevaVenta.Size = new Size(75, 23);
            btnNuevaVenta.TabIndex = 4;
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Location = new Point(438, 328);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(75, 23);
            btnRegistrarCliente.TabIndex = 5;
            // 
            // btnRegistrarProveedor
            // 
            btnRegistrarProveedor.Location = new Point(519, 328);
            btnRegistrarProveedor.Name = "btnRegistrarProveedor";
            btnRegistrarProveedor.Size = new Size(75, 23);
            btnRegistrarProveedor.TabIndex = 6;
            // 
            // btnHistorialVentas
            // 
            btnHistorialVentas.Location = new Point(34, 328);
            btnHistorialVentas.Name = "btnHistorialVentas";
            btnHistorialVentas.Size = new Size(75, 23);
            btnHistorialVentas.TabIndex = 7;
            // 
            // btnHistorialProveedor
            // 
            btnHistorialProveedor.Location = new Point(600, 328);
            btnHistorialProveedor.Name = "btnHistorialProveedor";
            btnHistorialProveedor.Size = new Size(75, 23);
            btnHistorialProveedor.TabIndex = 8;
            // 
            // btnHistorialCliente
            // 
            btnHistorialCliente.Location = new Point(681, 328);
            btnHistorialCliente.Name = "btnHistorialCliente";
            btnHistorialCliente.Size = new Size(75, 23);
            btnHistorialCliente.TabIndex = 9;
            // 
            // btnGestionUsuarios
            // 
            btnGestionUsuarios.Location = new Point(34, 367);
            btnGestionUsuarios.Name = "btnGestionUsuarios";
            btnGestionUsuarios.Size = new Size(75, 23);
            btnGestionUsuarios.TabIndex = 10;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Location = new Point(115, 367);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(75, 23);
            btnConfiguracion.TabIndex = 11;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(255, 13, 13);
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(8, 539);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(186, 28);
            btnCerrarSesion.TabIndex = 12;
            btnCerrarSesion.TabStop = false;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(238, 238, 238);
            panelContent.Controls.Add(lblBienvenido);
            panelContent.Controls.Add(btnConfiguracion);
            panelContent.Controls.Add(btnGestionUsuarios);
            panelContent.Controls.Add(btnHistorialCliente);
            panelContent.Controls.Add(btnHistorialProveedor);
            panelContent.Controls.Add(btnHistorialVentas);
            panelContent.Controls.Add(btnRegistrarProveedor);
            panelContent.Controls.Add(btnRegistrarCliente);
            panelContent.Controls.Add(btnNuevaVenta);
            panelContent.Controls.Add(btnAgregarProductos);
            panelContent.Controls.Add(btnListarProductos);
            panelContent.Controls.Add(btnInicio);
            panelContent.Controls.Add(lblPanelActualizado);
            panelContent.Controls.Add(panelStatsTop);
            panelContent.Controls.Add(panelStatsBottom);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(200, 56);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(824, 579);
            panelContent.TabIndex = 0;
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblBienvenido.ForeColor = Color.FromArgb(56, 67, 83);
            lblBienvenido.Location = new Point(14, 0);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(506, 54);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "Bienvenido Usuario (ROL)";
            lblBienvenido.Click += lblBienvenido_Click;
            // 
            // lblPanelActualizado
            // 
            lblPanelActualizado.AutoSize = true;
            lblPanelActualizado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblPanelActualizado.ForeColor = Color.FromArgb(112, 112, 112);
            lblPanelActualizado.Location = new Point(648, 30);
            lblPanelActualizado.Name = "lblPanelActualizado";
            lblPanelActualizado.Size = new Size(156, 15);
            lblPanelActualizado.TabIndex = 1;
            lblPanelActualizado.Text = "Panel actualizado al instante";
            // 
            // panelStatsTop
            // 
            panelStatsTop.BackColor = Color.FromArgb(205, 234, 236);
            panelStatsTop.Controls.Add(lblProductosActivosTitle);
            panelStatsTop.Controls.Add(lblProveedoresPendientesTitle);
            panelStatsTop.Controls.Add(lblStockCriticoTitle);
            panelStatsTop.Controls.Add(lblProductosActivosValue);
            panelStatsTop.Controls.Add(lblProveedoresPendientesValue);
            panelStatsTop.Controls.Add(lblStockCriticoValue);
            panelStatsTop.Location = new Point(14, 56);
            panelStatsTop.Name = "panelStatsTop";
            panelStatsTop.Size = new Size(790, 108);
            panelStatsTop.TabIndex = 2;
            panelStatsTop.Paint += panelStatsTop_Paint;
            // 
            // lblProductosActivosTitle
            // 
            lblProductosActivosTitle.AutoSize = true;
            lblProductosActivosTitle.Location = new Point(18, 12);
            lblProductosActivosTitle.Name = "lblProductosActivosTitle";
            lblProductosActivosTitle.Size = new Size(101, 15);
            lblProductosActivosTitle.TabIndex = 0;
            lblProductosActivosTitle.Text = "Productos activos";
            // 
            // lblProveedoresPendientesTitle
            // 
            lblProveedoresPendientesTitle.AutoSize = true;
            lblProveedoresPendientesTitle.Location = new Point(284, 12);
            lblProveedoresPendientesTitle.Name = "lblProveedoresPendientesTitle";
            lblProveedoresPendientesTitle.Size = new Size(133, 15);
            lblProveedoresPendientesTitle.TabIndex = 1;
            lblProveedoresPendientesTitle.Text = "Proveedores Pendientes";
            // 
            // lblStockCriticoTitle
            // 
            lblStockCriticoTitle.AutoSize = true;
            lblStockCriticoTitle.Location = new Point(534, 12);
            lblStockCriticoTitle.Name = "lblStockCriticoTitle";
            lblStockCriticoTitle.Size = new Size(72, 15);
            lblStockCriticoTitle.TabIndex = 2;
            lblStockCriticoTitle.Text = "Stock crítico";
            // 
            // lblProductosActivosValue
            // 
            lblProductosActivosValue.AutoSize = true;
            lblProductosActivosValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblProductosActivosValue.ForeColor = Color.FromArgb(53, 70, 90);
            lblProductosActivosValue.Location = new Point(20, 40);
            lblProductosActivosValue.Name = "lblProductosActivosValue";
            lblProductosActivosValue.Size = new Size(41, 48);
            lblProductosActivosValue.TabIndex = 3;
            lblProductosActivosValue.Text = "0";
            // 
            // lblProveedoresPendientesValue
            // 
            lblProveedoresPendientesValue.AutoSize = true;
            lblProveedoresPendientesValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblProveedoresPendientesValue.ForeColor = Color.FromArgb(53, 70, 90);
            lblProveedoresPendientesValue.Location = new Point(286, 40);
            lblProveedoresPendientesValue.Name = "lblProveedoresPendientesValue";
            lblProveedoresPendientesValue.Size = new Size(41, 48);
            lblProveedoresPendientesValue.TabIndex = 4;
            lblProveedoresPendientesValue.Text = "0";
            // 
            // lblStockCriticoValue
            // 
            lblStockCriticoValue.AutoSize = true;
            lblStockCriticoValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblStockCriticoValue.ForeColor = Color.Red;
            lblStockCriticoValue.Location = new Point(536, 40);
            lblStockCriticoValue.Name = "lblStockCriticoValue";
            lblStockCriticoValue.Size = new Size(41, 48);
            lblStockCriticoValue.TabIndex = 5;
            lblStockCriticoValue.Text = "0";
            // 
            // panelStatsBottom
            // 
            panelStatsBottom.BackColor = Color.FromArgb(226, 226, 226);
            panelStatsBottom.Controls.Add(lblVentaTotalTitle);
            panelStatsBottom.Controls.Add(lblGananciaEstimadaTitle);
            panelStatsBottom.Controls.Add(lblFiadosPendientesTitle);
            panelStatsBottom.Controls.Add(lblVentaTotalValue);
            panelStatsBottom.Controls.Add(lblGananciaEstimadaValue);
            panelStatsBottom.Controls.Add(lblFiadosPendientesValue);
            panelStatsBottom.Location = new Point(14, 174);
            panelStatsBottom.Name = "panelStatsBottom";
            panelStatsBottom.Size = new Size(790, 110);
            panelStatsBottom.TabIndex = 3;
            // 
            // lblVentaTotalTitle
            // 
            lblVentaTotalTitle.AutoSize = true;
            lblVentaTotalTitle.Location = new Point(18, 12);
            lblVentaTotalTitle.Name = "lblVentaTotalTitle";
            lblVentaTotalTitle.Size = new Size(115, 15);
            lblVentaTotalTitle.TabIndex = 0;
            lblVentaTotalTitle.Text = "Venta Total hoy: RD$";
            // 
            // lblGananciaEstimadaTitle
            // 
            lblGananciaEstimadaTitle.AutoSize = true;
            lblGananciaEstimadaTitle.Location = new Point(286, 12);
            lblGananciaEstimadaTitle.Name = "lblGananciaEstimadaTitle";
            lblGananciaEstimadaTitle.Size = new Size(117, 15);
            lblGananciaEstimadaTitle.TabIndex = 1;
            lblGananciaEstimadaTitle.Text = "Gananncia Estimada:";
            // 
            // lblFiadosPendientesTitle
            // 
            lblFiadosPendientesTitle.AutoSize = true;
            lblFiadosPendientesTitle.Location = new Point(536, 12);
            lblFiadosPendientesTitle.Name = "lblFiadosPendientesTitle";
            lblFiadosPendientesTitle.Size = new Size(108, 15);
            lblFiadosPendientesTitle.TabIndex = 2;
            lblFiadosPendientesTitle.Text = "Fiadios Pendientes:";
            // 
            // lblVentaTotalValue
            // 
            lblVentaTotalValue.AutoSize = true;
            lblVentaTotalValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblVentaTotalValue.ForeColor = Color.FromArgb(0, 153, 94);
            lblVentaTotalValue.Location = new Point(20, 42);
            lblVentaTotalValue.Name = "lblVentaTotalValue";
            lblVentaTotalValue.Size = new Size(41, 48);
            lblVentaTotalValue.TabIndex = 3;
            lblVentaTotalValue.Text = "0";
            // 
            // lblGananciaEstimadaValue
            // 
            lblGananciaEstimadaValue.AutoSize = true;
            lblGananciaEstimadaValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblGananciaEstimadaValue.ForeColor = Color.FromArgb(0, 153, 94);
            lblGananciaEstimadaValue.Location = new Point(288, 42);
            lblGananciaEstimadaValue.Name = "lblGananciaEstimadaValue";
            lblGananciaEstimadaValue.Size = new Size(41, 48);
            lblGananciaEstimadaValue.TabIndex = 4;
            lblGananciaEstimadaValue.Text = "0";
            // 
            // lblFiadosPendientesValue
            // 
            lblFiadosPendientesValue.AutoSize = true;
            lblFiadosPendientesValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblFiadosPendientesValue.ForeColor = Color.FromArgb(53, 70, 90);
            lblFiadosPendientesValue.Location = new Point(538, 42);
            lblFiadosPendientesValue.Name = "lblFiadosPendientesValue";
            lblFiadosPendientesValue.Size = new Size(41, 48);
            lblFiadosPendientesValue.TabIndex = 5;
            lblFiadosPendientesValue.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 238, 238);
            ClientSize = new Size(1024, 635);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Colmado JB soluciones";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelSesion.ResumeLayout(false);
            panelSesion.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            panelStatsTop.ResumeLayout(false);
            panelStatsTop.PerformLayout();
            panelStatsBottom.ResumeLayout(false);
            panelStatsBottom.PerformLayout();
            ResumeLayout(false);
        }

        private void ConfigMenuButton(Button button, string text, int top, bool selected)
        {
            button.BackColor = selected ? Color.FromArgb(102, 183, 186) : Color.WhiteSmoke;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.ForeColor = Color.FromArgb(40, 55, 73);
            button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            button.Location = new Point(2, top);
            button.Name = $"btn{text.Replace(" ", string.Empty)}";
            button.Size = new Size(186, 29);
            button.TabStop = false;
            button.Text = text;
            button.UseVisualStyleBackColor = false;
        }

        #endregion

        private Panel panelHeader;
        private Label lblBrandTitle;
        private Label lblBrandSub;
        private Label lblCajaAbierta;
        private Label lblSesionRol;

        private Panel panelMenu;
        private Button btnCerrarSesion;

        private Panel panelContent;
        private Label lblBienvenido;
        private Label lblPanelActualizado;

        private Panel panelStatsTop;
        private Label lblProductosActivosTitle;
        private Label lblProveedoresPendientesTitle;
        private Label lblStockCriticoTitle;
        private Label lblProductosActivosValue;
        private Label lblProveedoresPendientesValue;
        private Label lblStockCriticoValue;

        private Panel panelStatsBottom;
        private Label lblVentaTotalTitle;
        private Label lblGananciaEstimadaTitle;
        private Label lblFiadosPendientesTitle;
        private Label lblVentaTotalValue;
        private Label lblGananciaEstimadaValue;
        private Label lblFiadosPendientesValue;
        private Panel panelSesion;
        private Label lblSesionActiva;
        private Label lblUsuarioInfo;
        private Label lblRolInfo;
        private Label lblFechaInfo;
        private Label lblHoraInfo;

        private Button btnInicio;
        private Button btnListarProductos;
        private Button btnAgregarProductos;
        private Button btnNuevaVenta;
        private Button btnRegistrarCliente;
        private Button btnRegistrarProveedor;
        private Button btnHistorialVentas;
        private Button btnHistorialProveedor;
        private Button btnHistorialCliente;
        private Button btnGestionUsuarios;
        private Button btnConfiguracion;
    }
}
