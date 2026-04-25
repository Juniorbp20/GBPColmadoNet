using System;
using System.Drawing;
using System.Windows.Forms;

namespace GBPColmadoNet
{
    partial class MainForm
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
            panelHeader = new Panel();
            dateTimePicker1 = new DateTimePicker();
            lblBrandTitle = new Label();
            lblBrandSub = new Label();
            panelMenu = new Panel();
            flpNavigation = new FlowLayoutPanel();
            btnCatInicio = new Button();
            btnCatInventario = new Button();
            pnlSubInventario = new Panel();
            btnDevoluciones = new Button();
            btnEntradaSalida = new Button();
            btnCatVentas = new Button();
            pnlSubVentas = new Panel();
            btnVentaRapida = new Button();
            btnCuadre = new Button();
            btnCatClientes = new Button();
            pnlSubClientes = new Panel();
            btnCuentaPorPagar = new Button();
            btnCliente = new Button();
            btnCatProveedores = new Button();
            pnlSubProveedores = new Panel();
            btnProveedor = new Button();
            btnCatHistorial = new Button();
            pnlSubHistorial = new Panel();
            btnHProveedor = new Button();
            BtnHVentas = new Button();
            btnHClientes = new Button();
            btnCatConfig = new Button();
            btnCatCerrarSesion = new Button();
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
            flpNavigation.SuspendLayout();
            pnlSubInventario.SuspendLayout();
            pnlSubVentas.SuspendLayout();
            pnlSubClientes.SuspendLayout();
            pnlSubProveedores.SuspendLayout();
            pnlSubHistorial.SuspendLayout();
            panelContent.SuspendLayout();
            panelStatsTop.SuspendLayout();
            panelStatsBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(209, 209, 209);
            panelHeader.Controls.Add(dateTimePicker1);
            panelHeader.Controls.Add(lblBrandTitle);
            panelHeader.Controls.Add(lblBrandSub);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1023, 56);
            panelHeader.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(205, 234, 236);
            dateTimePicker1.CausesValidation = false;
            dateTimePicker1.Location = new Point(790, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(221, 23);
            dateTimePicker1.TabIndex = 3;
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
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(15, 32, 50);
            panelMenu.Controls.Add(flpNavigation);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 56);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 588);
            panelMenu.TabIndex = 1;
            // 
            // flpNavigation
            // 
            flpNavigation.AutoScroll = true;
            flpNavigation.BackColor = Color.Transparent;
            flpNavigation.Controls.Add(btnCatInicio);
            flpNavigation.Controls.Add(btnCatInventario);
            flpNavigation.Controls.Add(pnlSubInventario);
            flpNavigation.Controls.Add(btnCatVentas);
            flpNavigation.Controls.Add(pnlSubVentas);
            flpNavigation.Controls.Add(btnCatClientes);
            flpNavigation.Controls.Add(pnlSubClientes);
            flpNavigation.Controls.Add(btnCatProveedores);
            flpNavigation.Controls.Add(pnlSubProveedores);
            flpNavigation.Controls.Add(btnCatHistorial);
            flpNavigation.Controls.Add(pnlSubHistorial);
            flpNavigation.Controls.Add(btnCatConfig);
            flpNavigation.Controls.Add(btnCatCerrarSesion);
            flpNavigation.Dock = DockStyle.Fill;
            flpNavigation.FlowDirection = FlowDirection.TopDown;
            flpNavigation.Location = new Point(0, 0);
            flpNavigation.Name = "flpNavigation";
            flpNavigation.Size = new Size(250, 588);
            flpNavigation.TabIndex = 0;
            flpNavigation.WrapContents = false;
            // 
            // btnCatInicio
            // 
            btnCatInicio.BackColor = Color.FromArgb(15, 32, 50);
            btnCatInicio.FlatAppearance.BorderSize = 0;
            btnCatInicio.FlatStyle = FlatStyle.Flat;
            btnCatInicio.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCatInicio.ForeColor = Color.White;
            btnCatInicio.Location = new Point(3, 3);
            btnCatInicio.Name = "btnCatInicio";
            btnCatInicio.Size = new Size(230, 45);
            btnCatInicio.TabIndex = 0;
            btnCatInicio.Text = "  Inicio";
            btnCatInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnCatInicio.UseVisualStyleBackColor = false;
            btnCatInicio.Click += btnCatInicio_Click;
            // 
            // btnCatInventario
            // 
            btnCatInventario.BackColor = Color.FromArgb(20, 45, 65);
            btnCatInventario.FlatAppearance.BorderSize = 0;
            btnCatInventario.FlatStyle = FlatStyle.Flat;
            btnCatInventario.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCatInventario.ForeColor = Color.White;
            btnCatInventario.Location = new Point(3, 54);
            btnCatInventario.Name = "btnCatInventario";
            btnCatInventario.Size = new Size(230, 45);
            btnCatInventario.TabIndex = 1;
            btnCatInventario.Text = "  Inventario";
            btnCatInventario.TextAlign = ContentAlignment.MiddleLeft;
            btnCatInventario.UseVisualStyleBackColor = false;
            btnCatInventario.Click += btnInventario_Click;
            // 
            // pnlSubInventario
            // 
            pnlSubInventario.BackColor = Color.Transparent;
            pnlSubInventario.Controls.Add(btnDevoluciones);
            pnlSubInventario.Controls.Add(btnEntradaSalida);
            pnlSubInventario.Location = new Point(3, 105);
            pnlSubInventario.Name = "pnlSubInventario";
            pnlSubInventario.Size = new Size(230, 96);
            pnlSubInventario.TabIndex = 2;
            pnlSubInventario.Visible = false;
            // 
            // btnDevoluciones
            // 
            btnDevoluciones.BackColor = Color.Transparent;
            btnDevoluciones.FlatStyle = FlatStyle.Popup;
            btnDevoluciones.ForeColor = Color.White;
            btnDevoluciones.Location = new Point(-3, 48);
            btnDevoluciones.Name = "btnDevoluciones";
            btnDevoluciones.Size = new Size(233, 39);
            btnDevoluciones.TabIndex = 3;
            btnDevoluciones.Text = "Devoluciones";
            btnDevoluciones.UseVisualStyleBackColor = false;
            btnDevoluciones.Click += btnDevoluciones_Click;
            // 
            // btnEntradaSalida
            // 
            btnEntradaSalida.BackColor = Color.Transparent;
            btnEntradaSalida.FlatStyle = FlatStyle.Popup;
            btnEntradaSalida.ForeColor = Color.White;
            btnEntradaSalida.Location = new Point(-3, 3);
            btnEntradaSalida.Name = "btnEntradaSalida";
            btnEntradaSalida.Size = new Size(233, 39);
            btnEntradaSalida.TabIndex = 0;
            btnEntradaSalida.Text = "E/S";
            btnEntradaSalida.UseVisualStyleBackColor = false;
            btnEntradaSalida.Click += btnEntradaSalida_Click;
            // 
            // btnCatVentas
            // 
            btnCatVentas.BackColor = Color.FromArgb(20, 45, 65);
            btnCatVentas.FlatAppearance.BorderSize = 0;
            btnCatVentas.FlatStyle = FlatStyle.Flat;
            btnCatVentas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCatVentas.ForeColor = Color.White;
            btnCatVentas.Location = new Point(3, 207);
            btnCatVentas.Name = "btnCatVentas";
            btnCatVentas.Size = new Size(230, 45);
            btnCatVentas.TabIndex = 3;
            btnCatVentas.Text = "  Ventas";
            btnCatVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnCatVentas.UseVisualStyleBackColor = false;
            btnCatVentas.Click += btnVentas_Click;
            // 
            // pnlSubVentas
            // 
            pnlSubVentas.BackColor = Color.Transparent;
            pnlSubVentas.Controls.Add(btnVentaRapida);
            pnlSubVentas.Controls.Add(btnCuadre);
            pnlSubVentas.Location = new Point(3, 258);
            pnlSubVentas.Name = "pnlSubVentas";
            pnlSubVentas.Size = new Size(230, 98);
            pnlSubVentas.TabIndex = 4;
            pnlSubVentas.Visible = false;
            // 
            // btnVentaRapida
            // 
            btnVentaRapida.FlatStyle = FlatStyle.Popup;
            btnVentaRapida.ForeColor = Color.White;
            btnVentaRapida.Location = new Point(-3, 3);
            btnVentaRapida.Name = "btnVentaRapida";
            btnVentaRapida.Size = new Size(233, 42);
            btnVentaRapida.TabIndex = 1;
            btnVentaRapida.Text = "Venta Rapida";
            btnVentaRapida.UseVisualStyleBackColor = true;
            btnVentaRapida.Click += button2_Click;
            // 
            // btnCuadre
            // 
            btnCuadre.BackColor = Color.Transparent;
            btnCuadre.FlatStyle = FlatStyle.Popup;
            btnCuadre.ForeColor = Color.White;
            btnCuadre.Location = new Point(-3, 51);
            btnCuadre.Name = "btnCuadre";
            btnCuadre.Size = new Size(233, 39);
            btnCuadre.TabIndex = 0;
            btnCuadre.Text = "Cuadre";
            btnCuadre.UseVisualStyleBackColor = false;
            btnCuadre.Click += btnCuadre_Click;
            // 
            // btnCatClientes
            // 
            btnCatClientes.BackColor = Color.FromArgb(20, 45, 65);
            btnCatClientes.FlatAppearance.BorderSize = 0;
            btnCatClientes.FlatStyle = FlatStyle.Flat;
            btnCatClientes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCatClientes.ForeColor = Color.White;
            btnCatClientes.Location = new Point(3, 362);
            btnCatClientes.Name = "btnCatClientes";
            btnCatClientes.Size = new Size(230, 45);
            btnCatClientes.TabIndex = 5;
            btnCatClientes.Text = "  Clientes";
            btnCatClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnCatClientes.UseVisualStyleBackColor = false;
            btnCatClientes.Click += btnClientes_Click;
            // 
            // pnlSubClientes
            // 
            pnlSubClientes.BackColor = Color.Transparent;
            pnlSubClientes.Controls.Add(btnCuentaPorPagar);
            pnlSubClientes.Controls.Add(btnCliente);
            pnlSubClientes.Location = new Point(3, 413);
            pnlSubClientes.Name = "pnlSubClientes";
            pnlSubClientes.Size = new Size(230, 94);
            pnlSubClientes.TabIndex = 6;
            pnlSubClientes.Visible = false;
            // 
            // btnCuentaPorPagar
            // 
            btnCuentaPorPagar.FlatStyle = FlatStyle.Popup;
            btnCuentaPorPagar.ForeColor = Color.White;
            btnCuentaPorPagar.Location = new Point(-3, 47);
            btnCuentaPorPagar.Name = "btnCuentaPorPagar";
            btnCuentaPorPagar.Size = new Size(233, 39);
            btnCuentaPorPagar.TabIndex = 5;
            btnCuentaPorPagar.Text = "Cuentas por Cobrar";
            btnCuentaPorPagar.UseVisualStyleBackColor = true;
            btnCuentaPorPagar.Click += btnCuentaPorPagar_Click;
            // 
            // btnCliente
            // 
            btnCliente.FlatStyle = FlatStyle.Popup;
            btnCliente.ForeColor = Color.White;
            btnCliente.Location = new Point(-3, 3);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(233, 38);
            btnCliente.TabIndex = 4;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnCatProveedores
            // 
            btnCatProveedores.BackColor = Color.FromArgb(20, 45, 65);
            btnCatProveedores.FlatAppearance.BorderSize = 0;
            btnCatProveedores.FlatStyle = FlatStyle.Flat;
            btnCatProveedores.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCatProveedores.ForeColor = Color.White;
            btnCatProveedores.Location = new Point(3, 513);
            btnCatProveedores.Name = "btnCatProveedores";
            btnCatProveedores.Size = new Size(230, 45);
            btnCatProveedores.TabIndex = 7;
            btnCatProveedores.Text = "  Proveedores";
            btnCatProveedores.TextAlign = ContentAlignment.MiddleLeft;
            btnCatProveedores.UseVisualStyleBackColor = false;
            btnCatProveedores.Click += btnProveedores_Click;
            // 
            // pnlSubProveedores
            // 
            pnlSubProveedores.BackColor = Color.Transparent;
            pnlSubProveedores.Controls.Add(btnProveedor);
            pnlSubProveedores.Location = new Point(3, 564);
            pnlSubProveedores.Name = "pnlSubProveedores";
            pnlSubProveedores.Size = new Size(230, 42);
            pnlSubProveedores.TabIndex = 8;
            pnlSubProveedores.Visible = false;
            // 
            // btnProveedor
            // 
            btnProveedor.FlatStyle = FlatStyle.Popup;
            btnProveedor.ForeColor = Color.White;
            btnProveedor.Location = new Point(-3, 3);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(233, 37);
            btnProveedor.TabIndex = 0;
            btnProveedor.Text = "Proveedor";
            btnProveedor.UseVisualStyleBackColor = true;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // btnCatHistorial
            // 
            btnCatHistorial.BackColor = Color.FromArgb(20, 45, 65);
            btnCatHistorial.FlatAppearance.BorderSize = 0;
            btnCatHistorial.FlatStyle = FlatStyle.Flat;
            btnCatHistorial.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCatHistorial.ForeColor = Color.White;
            btnCatHistorial.Location = new Point(3, 612);
            btnCatHistorial.Name = "btnCatHistorial";
            btnCatHistorial.Size = new Size(230, 45);
            btnCatHistorial.TabIndex = 9;
            btnCatHistorial.Text = "  Historial";
            btnCatHistorial.TextAlign = ContentAlignment.MiddleLeft;
            btnCatHistorial.UseVisualStyleBackColor = false;
            btnCatHistorial.Click += btnHistorial_Click;
            // 
            // pnlSubHistorial
            // 
            pnlSubHistorial.BackColor = Color.Transparent;
            pnlSubHistorial.Controls.Add(btnHProveedor);
            pnlSubHistorial.Controls.Add(BtnHVentas);
            pnlSubHistorial.Controls.Add(btnHClientes);
            pnlSubHistorial.Location = new Point(3, 663);
            pnlSubHistorial.Name = "pnlSubHistorial";
            pnlSubHistorial.Size = new Size(233, 145);
            pnlSubHistorial.TabIndex = 10;
            pnlSubHistorial.Visible = false;
            // 
            // btnHProveedor
            // 
            btnHProveedor.FlatStyle = FlatStyle.Popup;
            btnHProveedor.ForeColor = Color.White;
            btnHProveedor.Location = new Point(-3, 96);
            btnHProveedor.Name = "btnHProveedor";
            btnHProveedor.Size = new Size(233, 42);
            btnHProveedor.TabIndex = 6;
            btnHProveedor.Text = "Historial de Clientes";
            btnHProveedor.UseVisualStyleBackColor = true;
            btnHProveedor.Click += btnHProveedor_Click;
            // 
            // BtnHVentas
            // 
            BtnHVentas.FlatStyle = FlatStyle.Popup;
            BtnHVentas.ForeColor = Color.White;
            BtnHVentas.Location = new Point(-3, 3);
            BtnHVentas.Name = "BtnHVentas";
            BtnHVentas.Size = new Size(233, 39);
            BtnHVentas.TabIndex = 4;
            BtnHVentas.Text = "Historial de Ventas";
            BtnHVentas.UseVisualStyleBackColor = true;
            BtnHVentas.Click += BtnHVentas_Click;
            // 
            // btnHClientes
            // 
            btnHClientes.FlatStyle = FlatStyle.Popup;
            btnHClientes.ForeColor = Color.White;
            btnHClientes.Location = new Point(-3, 48);
            btnHClientes.Name = "btnHClientes";
            btnHClientes.Size = new Size(233, 42);
            btnHClientes.TabIndex = 5;
            btnHClientes.Text = "Historial de Clientes";
            btnHClientes.UseVisualStyleBackColor = true;
            btnHClientes.Click += btnHClientes_Click;
            // 
            // btnCatConfig
            // 
            btnCatConfig.BackColor = Color.FromArgb(20, 45, 65);
            btnCatConfig.FlatAppearance.BorderSize = 0;
            btnCatConfig.FlatStyle = FlatStyle.Flat;
            btnCatConfig.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCatConfig.ForeColor = Color.White;
            btnCatConfig.Location = new Point(3, 814);
            btnCatConfig.Name = "btnCatConfig";
            btnCatConfig.Size = new Size(230, 45);
            btnCatConfig.TabIndex = 11;
            btnCatConfig.Text = "  Configuración";
            btnCatConfig.TextAlign = ContentAlignment.MiddleLeft;
            btnCatConfig.UseVisualStyleBackColor = false;
            btnCatConfig.Click += btnCatConfig_Click;
            // 
            // btnCatCerrarSesion
            // 
            btnCatCerrarSesion.BackColor = Color.FromArgb(20, 45, 65);
            btnCatCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCatCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCatCerrarSesion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCatCerrarSesion.ForeColor = Color.White;
            btnCatCerrarSesion.Location = new Point(3, 865);
            btnCatCerrarSesion.Name = "btnCatCerrarSesion";
            btnCatCerrarSesion.Size = new Size(230, 45);
            btnCatCerrarSesion.TabIndex = 13;
            btnCatCerrarSesion.Text = "  Cerrar Sesión";
            btnCatCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCatCerrarSesion.UseVisualStyleBackColor = false;
            btnCatCerrarSesion.Click += btnCatCerrarSesion_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(238, 238, 238);
            panelContent.Controls.Add(lblBienvenido);
            panelContent.Controls.Add(lblPanelActualizado);
            panelContent.Controls.Add(panelStatsTop);
            panelContent.Controls.Add(panelStatsBottom);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(250, 56);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(773, 588);
            panelContent.TabIndex = 2;
            panelContent.Paint += panelContent_Paint;
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblBienvenido.ForeColor = Color.FromArgb(56, 67, 83);
            lblBienvenido.Location = new Point(6, 0);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(506, 54);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "Bienvenido Usuario (ROL)";
            // 
            // lblPanelActualizado
            // 
            lblPanelActualizado.AutoSize = true;
            lblPanelActualizado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblPanelActualizado.ForeColor = Color.FromArgb(112, 112, 112);
            lblPanelActualizado.Location = new Point(603, 30);
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
            panelStatsTop.Location = new Point(6, 56);
            panelStatsTop.Name = "panelStatsTop";
            panelStatsTop.Size = new Size(755, 108);
            panelStatsTop.TabIndex = 2;
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
            panelStatsBottom.Location = new Point(6, 174);
            panelStatsBottom.Name = "panelStatsBottom";
            panelStatsBottom.Size = new Size(755, 110);
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
            lblGananciaEstimadaTitle.Size = new Size(110, 15);
            lblGananciaEstimadaTitle.TabIndex = 1;
            lblGananciaEstimadaTitle.Text = "Ganancia estimada:";
            // 
            // lblFiadosPendientesTitle
            // 
            lblFiadosPendientesTitle.AutoSize = true;
            lblFiadosPendientesTitle.Location = new Point(536, 12);
            lblFiadosPendientesTitle.Name = "lblFiadosPendientesTitle";
            lblFiadosPendientesTitle.Size = new Size(105, 15);
            lblFiadosPendientesTitle.TabIndex = 2;
            lblFiadosPendientesTitle.Text = "Fiados pendientes:";
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
            ClientSize = new Size(1023, 644);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Colmado - GBP Colmado.Net";
            Load += MainForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMenu.ResumeLayout(false);
            flpNavigation.ResumeLayout(false);
            pnlSubInventario.ResumeLayout(false);
            pnlSubVentas.ResumeLayout(false);
            pnlSubClientes.ResumeLayout(false);
            pnlSubProveedores.ResumeLayout(false);
            pnlSubHistorial.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            panelStatsTop.ResumeLayout(false);
            panelStatsTop.PerformLayout();
            panelStatsBottom.ResumeLayout(false);
            panelStatsBottom.PerformLayout();
            ResumeLayout(false);
        }

        private void FormatearBotonAccion(Button btn, string texto, int top)
        {
            btn.BackColor = Color.FromArgb(30, 60, 85);
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.ForeColor = Color.Gainsboro;
            btn.Font = new Font("Segoe UI", 10F);
            btn.Location = new Point(0, top);
            btn.Size = new Size(230, 40);
            btn.Text = texto;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(35, 0, 0, 0);
            btn.Name = "btn" + texto.Replace(" ", "").Replace("/", "");
            btn.UseVisualStyleBackColor = false;
        }

        #endregion

        private Panel panelHeader;
        private Label lblBrandTitle;
        private Label lblBrandSub;

        private Panel panelMenu;
        private FlowLayoutPanel flpNavigation;
        private Button btnCatInicio;
        private Button btnCatInventario;
        private Panel pnlSubInventario;
        private Button btnEntradaSalida;
        private Button btnCatVentas;
        private Panel pnlSubVentas;
        private Button btnCatClientes;
        private Panel pnlSubClientes;
        private Button btnCatProveedores;
        private Panel pnlSubProveedores;
        private Button btnCatHistorial;
        private Panel pnlSubHistorial;
        private Button btnCatConfig;
        private Button btnCatCerrarSesion;

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
        private void btnInventario_Click(object sender, EventArgs e) => pnlSubInventario.Visible = !pnlSubInventario.Visible;
        private void btnVentas_Click(object sender, EventArgs e) => pnlSubVentas.Visible = !pnlSubVentas.Visible;
        private void btnClientes_Click(object sender, EventArgs e) => pnlSubClientes.Visible = !pnlSubClientes.Visible;
        private void btnProveedores_Click(object sender, EventArgs e) => pnlSubProveedores.Visible = !pnlSubProveedores.Visible;
        private void btnHistorial_Click(object sender, EventArgs e) => pnlSubHistorial.Visible = !pnlSubHistorial.Visible;

        private Button btnDevoluciones;
        private Button btnVentaRapida;
        private Button btnCuadre;
        private Button btnCuentaPorPagar;
        private Button btnCliente;
        private Button btnProveedor;
        private Button btnHProveedor;
        private Button BtnHVentas;
        private Button btnHClientes;
        private DateTimePicker dateTimePicker1;
        
    }
}
