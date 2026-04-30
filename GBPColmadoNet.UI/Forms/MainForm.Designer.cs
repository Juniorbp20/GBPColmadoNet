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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelHeader = new Panel();
            dateTimePicker1 = new DateTimePicker();
            lblBrandTitle = new Label();
            lblBrandSub = new Label();
            menuStrip1 = new MenuStrip();
            inventarioToolStripMenuItem = new ToolStripMenuItem();
            eSToolStripMenuItem = new ToolStripMenuItem();
            devolucionesToolStripMenuItem = new ToolStripMenuItem();
            listarProductosToolStripMenuItem = new ToolStripMenuItem();
            panelContent = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripLabelMenuOp = new ToolStripLabel();
            toolStripLabelInventario = new ToolStripLabel();
            toolStripButton1 = new ToolStripButton();
            toolStripButtonDevoluciones = new ToolStripButton();
            toolStripButtonListarProductos = new ToolStripButton();
            toolStripLabelVentas = new ToolStripLabel();
            toolStripButtonVentaR = new ToolStripButton();
            toolStripButtonCuadre = new ToolStripButton();
            toolStripLabelCliente = new ToolStripLabel();
            toolStripButtonCliente = new ToolStripButton();
            toolStripButtonCuentasPCobrar = new ToolStripButton();
            toolStripLabelHistorial = new ToolStripLabel();
            toolStripButtonHClientes = new ToolStripButton();
            toolStripButtonHProveedor = new ToolStripButton();
            toolStripButtonHVentas = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButtonConfiguracion = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
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
            ventasToolStripMenuItem = new ToolStripMenuItem();
            clientresToolStripMenuItem = new ToolStripMenuItem();
            historialToolStripMenuItem = new ToolStripMenuItem();
            configuracionToolStripMenuItem = new ToolStripMenuItem();
            ventaRapidaToolStripMenuItem = new ToolStripMenuItem();
            cuadreToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            cuentasPorCobrarToolStripMenuItem = new ToolStripMenuItem();
            historialClienteToolStripMenuItem = new ToolStripMenuItem();
            historialProveedorToolStripMenuItem = new ToolStripMenuItem();
            historialVentasToolStripMenuItem = new ToolStripMenuItem();
            configuracionesToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            panelHeader.SuspendLayout();
            menuStrip1.SuspendLayout();
            panelContent.SuspendLayout();
            toolStrip1.SuspendLayout();
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
            panelHeader.Controls.Add(menuStrip1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1023, 101);
            panelHeader.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(205, 234, 236);
            dateTimePicker1.CausesValidation = false;
            dateTimePicker1.Location = new Point(788, 24);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(221, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // lblBrandTitle
            // 
            lblBrandTitle.AutoSize = true;
            lblBrandTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBrandTitle.ForeColor = Color.FromArgb(54, 66, 81);
            lblBrandTitle.Location = new Point(3, 24);
            lblBrandTitle.Name = "lblBrandTitle";
            lblBrandTitle.Size = new Size(187, 30);
            lblBrandTitle.TabIndex = 0;
            lblBrandTitle.Text = "GBPColmadoNet";
            // 
            // lblBrandSub
            // 
            lblBrandSub.AutoSize = true;
            lblBrandSub.Font = new Font("Segoe UI", 10F);
            lblBrandSub.ForeColor = Color.FromArgb(96, 96, 96);
            lblBrandSub.Location = new Point(3, 66);
            lblBrandSub.Name = "lblBrandSub";
            lblBrandSub.Size = new Size(407, 19);
            lblBrandSub.TabIndex = 1;
            lblBrandSub.Text = "Gestiona tu inventario, ventas y proveedores desde un solo lugar";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(205, 234, 236);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inventarioToolStripMenuItem, ventasToolStripMenuItem, clientresToolStripMenuItem, historialToolStripMenuItem, configuracionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1023, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eSToolStripMenuItem, devolucionesToolStripMenuItem, listarProductosToolStripMenuItem });
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(72, 20);
            inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // eSToolStripMenuItem
            // 
            eSToolStripMenuItem.BackColor = Color.FromArgb(209, 209, 209);
            eSToolStripMenuItem.Name = "eSToolStripMenuItem";
            eSToolStripMenuItem.Size = new Size(180, 22);
            eSToolStripMenuItem.Text = "E/S";
            eSToolStripMenuItem.Click += eSToolStripMenuItem_Click;
            // 
            // devolucionesToolStripMenuItem
            // 
            devolucionesToolStripMenuItem.BackColor = Color.FromArgb(209, 209, 209);
            devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            devolucionesToolStripMenuItem.Size = new Size(180, 22);
            devolucionesToolStripMenuItem.Text = "Devoluciones";
            devolucionesToolStripMenuItem.Click += devolucionesToolStripMenuItem_Click;
            // 
            // listarProductosToolStripMenuItem
            // 
            listarProductosToolStripMenuItem.BackColor = Color.FromArgb(209, 209, 209);
            listarProductosToolStripMenuItem.Name = "listarProductosToolStripMenuItem";
            listarProductosToolStripMenuItem.Size = new Size(180, 22);
            listarProductosToolStripMenuItem.Text = "Listar Productos";
            listarProductosToolStripMenuItem.Click += listarProductosToolStripMenuItem_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(238, 238, 238);
            panelContent.Controls.Add(toolStrip1);
            panelContent.Controls.Add(lblBienvenido);
            panelContent.Controls.Add(lblPanelActualizado);
            panelContent.Controls.Add(panelStatsTop);
            panelContent.Controls.Add(panelStatsBottom);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 101);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1023, 543);
            panelContent.TabIndex = 2;
            panelContent.Paint += panelContent_Paint;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.FromArgb(15, 35, 50);
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabelMenuOp, toolStripLabelInventario, toolStripButton1, toolStripButtonDevoluciones, toolStripButtonListarProductos, toolStripLabelVentas, toolStripButtonVentaR, toolStripButtonCuadre, toolStripLabelCliente, toolStripButtonCliente, toolStripButtonCuentasPCobrar, toolStripLabelHistorial, toolStripButtonHClientes, toolStripButtonHProveedor, toolStripButtonHVentas, toolStripButton2, toolStripButtonConfiguracion, toolStripButton3 });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(212, 543);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelMenuOp
            // 
            toolStripLabelMenuOp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripLabelMenuOp.ForeColor = Color.White;
            toolStripLabelMenuOp.Name = "toolStripLabelMenuOp";
            toolStripLabelMenuOp.Size = new Size(210, 30);
            toolStripLabelMenuOp.Text = "Menu de Opciones";
            toolStripLabelMenuOp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripLabelInventario
            // 
            toolStripLabelInventario.BackColor = Color.Transparent;
            toolStripLabelInventario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripLabelInventario.ForeColor = Color.White;
            toolStripLabelInventario.Name = "toolStripLabelInventario";
            toolStripLabelInventario.Size = new Size(210, 21);
            toolStripLabelInventario.Text = "Inventario";
            toolStripLabelInventario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.ForeColor = Color.White;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(210, 19);
            toolStripButton1.Text = "E/S";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButtonDevoluciones
            // 
            toolStripButtonDevoluciones.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonDevoluciones.ForeColor = Color.White;
            toolStripButtonDevoluciones.Image = (Image)resources.GetObject("toolStripButtonDevoluciones.Image");
            toolStripButtonDevoluciones.ImageTransparentColor = Color.Magenta;
            toolStripButtonDevoluciones.Name = "toolStripButtonDevoluciones";
            toolStripButtonDevoluciones.Size = new Size(210, 19);
            toolStripButtonDevoluciones.Text = "Devoluciones";
            toolStripButtonDevoluciones.Click += toolStripButtonDevoluciones_Click;
            // 
            // toolStripButtonListarProductos
            // 
            toolStripButtonListarProductos.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonListarProductos.ForeColor = Color.White;
            toolStripButtonListarProductos.Image = (Image)resources.GetObject("toolStripButtonListarProductos.Image");
            toolStripButtonListarProductos.ImageTransparentColor = Color.Magenta;
            toolStripButtonListarProductos.Name = "toolStripButtonListarProductos";
            toolStripButtonListarProductos.Size = new Size(210, 19);
            toolStripButtonListarProductos.Text = "Listar Productos";
            toolStripButtonListarProductos.Click += toolStripButtonListarProductos_Click;
            // 
            // toolStripLabelVentas
            // 
            toolStripLabelVentas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripLabelVentas.ForeColor = Color.White;
            toolStripLabelVentas.Name = "toolStripLabelVentas";
            toolStripLabelVentas.Size = new Size(210, 21);
            toolStripLabelVentas.Text = "Ventas";
            toolStripLabelVentas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripButtonVentaR
            // 
            toolStripButtonVentaR.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonVentaR.ForeColor = Color.White;
            toolStripButtonVentaR.Image = (Image)resources.GetObject("toolStripButtonVentaR.Image");
            toolStripButtonVentaR.ImageTransparentColor = Color.Magenta;
            toolStripButtonVentaR.Name = "toolStripButtonVentaR";
            toolStripButtonVentaR.Size = new Size(210, 19);
            toolStripButtonVentaR.Text = "Venta Rapida";
            // 
            // toolStripButtonCuadre
            // 
            toolStripButtonCuadre.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonCuadre.ForeColor = Color.White;
            toolStripButtonCuadre.Image = (Image)resources.GetObject("toolStripButtonCuadre.Image");
            toolStripButtonCuadre.ImageTransparentColor = Color.Magenta;
            toolStripButtonCuadre.Name = "toolStripButtonCuadre";
            toolStripButtonCuadre.Size = new Size(210, 19);
            toolStripButtonCuadre.Text = "Cuadre";
            // 
            // toolStripLabelCliente
            // 
            toolStripLabelCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripLabelCliente.ForeColor = Color.White;
            toolStripLabelCliente.Name = "toolStripLabelCliente";
            toolStripLabelCliente.Size = new Size(210, 21);
            toolStripLabelCliente.Text = "Cliente";
            toolStripLabelCliente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripButtonCliente
            // 
            toolStripButtonCliente.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonCliente.ForeColor = Color.White;
            toolStripButtonCliente.Image = (Image)resources.GetObject("toolStripButtonCliente.Image");
            toolStripButtonCliente.ImageTransparentColor = Color.Magenta;
            toolStripButtonCliente.Name = "toolStripButtonCliente";
            toolStripButtonCliente.Size = new Size(210, 19);
            toolStripButtonCliente.Text = "Clente";
            // 
            // toolStripButtonCuentasPCobrar
            // 
            toolStripButtonCuentasPCobrar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonCuentasPCobrar.ForeColor = Color.White;
            toolStripButtonCuentasPCobrar.Image = (Image)resources.GetObject("toolStripButtonCuentasPCobrar.Image");
            toolStripButtonCuentasPCobrar.ImageTransparentColor = Color.Magenta;
            toolStripButtonCuentasPCobrar.Name = "toolStripButtonCuentasPCobrar";
            toolStripButtonCuentasPCobrar.Size = new Size(210, 19);
            toolStripButtonCuentasPCobrar.Text = "Cuentas por Cobrar";
            // 
            // toolStripLabelHistorial
            // 
            toolStripLabelHistorial.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripLabelHistorial.ForeColor = Color.White;
            toolStripLabelHistorial.Name = "toolStripLabelHistorial";
            toolStripLabelHistorial.Size = new Size(210, 21);
            toolStripLabelHistorial.Text = "Historial";
            toolStripLabelHistorial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripButtonHClientes
            // 
            toolStripButtonHClientes.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonHClientes.ForeColor = Color.White;
            toolStripButtonHClientes.Image = (Image)resources.GetObject("toolStripButtonHClientes.Image");
            toolStripButtonHClientes.ImageTransparentColor = Color.Magenta;
            toolStripButtonHClientes.Name = "toolStripButtonHClientes";
            toolStripButtonHClientes.Size = new Size(210, 19);
            toolStripButtonHClientes.Text = "Historial de Clientes";
            // 
            // toolStripButtonHProveedor
            // 
            toolStripButtonHProveedor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonHProveedor.ForeColor = Color.White;
            toolStripButtonHProveedor.Image = (Image)resources.GetObject("toolStripButtonHProveedor.Image");
            toolStripButtonHProveedor.ImageTransparentColor = Color.Magenta;
            toolStripButtonHProveedor.Name = "toolStripButtonHProveedor";
            toolStripButtonHProveedor.Size = new Size(210, 19);
            toolStripButtonHProveedor.Text = "Historial de Proveedores";
            // 
            // toolStripButtonHVentas
            // 
            toolStripButtonHVentas.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonHVentas.ForeColor = Color.White;
            toolStripButtonHVentas.Image = (Image)resources.GetObject("toolStripButtonHVentas.Image");
            toolStripButtonHVentas.ImageTransparentColor = Color.Magenta;
            toolStripButtonHVentas.Name = "toolStripButtonHVentas";
            toolStripButtonHVentas.Size = new Size(210, 19);
            toolStripButtonHVentas.Text = "Historial de Ventas";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripButton2.ForeColor = Color.White;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(210, 4);
            toolStripButton2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripButtonConfiguracion
            // 
            toolStripButtonConfiguracion.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonConfiguracion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripButtonConfiguracion.ForeColor = Color.White;
            toolStripButtonConfiguracion.Image = (Image)resources.GetObject("toolStripButtonConfiguracion.Image");
            toolStripButtonConfiguracion.ImageTransparentColor = Color.Magenta;
            toolStripButtonConfiguracion.Name = "toolStripButtonConfiguracion";
            toolStripButtonConfiguracion.Size = new Size(210, 25);
            toolStripButtonConfiguracion.Text = "Configuracion";
            toolStripButtonConfiguracion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripButton3.ForeColor = Color.White;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(210, 25);
            toolStripButton3.Text = "Cerrar Sesion";
            toolStripButton3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblBienvenido.ForeColor = Color.FromArgb(56, 67, 83);
            lblBienvenido.Location = new Point(224, 0);
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
            lblPanelActualizado.Location = new Point(832, 31);
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
            panelStatsTop.Location = new Point(233, 57);
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
            panelStatsBottom.Location = new Point(233, 171);
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
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ventaRapidaToolStripMenuItem, cuadreToolStripMenuItem });
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(53, 20);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // clientresToolStripMenuItem
            // 
            clientresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, cuentasPorCobrarToolStripMenuItem });
            clientresToolStripMenuItem.Name = "clientresToolStripMenuItem";
            clientresToolStripMenuItem.Size = new Size(65, 20);
            clientresToolStripMenuItem.Text = "Clientres";
            // 
            // historialToolStripMenuItem
            // 
            historialToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { historialClienteToolStripMenuItem, historialProveedorToolStripMenuItem, historialVentasToolStripMenuItem });
            historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            historialToolStripMenuItem.Size = new Size(63, 20);
            historialToolStripMenuItem.Text = "Historial";
            // 
            // configuracionToolStripMenuItem
            // 
            configuracionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { configuracionesToolStripMenuItem, cerrarSesionToolStripMenuItem });
            configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            configuracionToolStripMenuItem.Size = new Size(95, 20);
            configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // ventaRapidaToolStripMenuItem
            // 
            ventaRapidaToolStripMenuItem.Name = "ventaRapidaToolStripMenuItem";
            ventaRapidaToolStripMenuItem.Size = new Size(180, 22);
            ventaRapidaToolStripMenuItem.Text = "Venta Rapida";
            // 
            // cuadreToolStripMenuItem
            // 
            cuadreToolStripMenuItem.Name = "cuadreToolStripMenuItem";
            cuadreToolStripMenuItem.Size = new Size(180, 22);
            cuadreToolStripMenuItem.Text = "Cuadre";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(180, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // cuentasPorCobrarToolStripMenuItem
            // 
            cuentasPorCobrarToolStripMenuItem.Name = "cuentasPorCobrarToolStripMenuItem";
            cuentasPorCobrarToolStripMenuItem.Size = new Size(180, 22);
            cuentasPorCobrarToolStripMenuItem.Text = "Cuentas por Cobrar";
            // 
            // historialClienteToolStripMenuItem
            // 
            historialClienteToolStripMenuItem.Name = "historialClienteToolStripMenuItem";
            historialClienteToolStripMenuItem.Size = new Size(180, 22);
            historialClienteToolStripMenuItem.Text = "Historial Cliente";
            // 
            // historialProveedorToolStripMenuItem
            // 
            historialProveedorToolStripMenuItem.Name = "historialProveedorToolStripMenuItem";
            historialProveedorToolStripMenuItem.Size = new Size(180, 22);
            historialProveedorToolStripMenuItem.Text = "Historial Proveedor";
            // 
            // historialVentasToolStripMenuItem
            // 
            historialVentasToolStripMenuItem.Name = "historialVentasToolStripMenuItem";
            historialVentasToolStripMenuItem.Size = new Size(180, 22);
            historialVentasToolStripMenuItem.Text = "Historial  Ventas";
            // 
            // configuracionesToolStripMenuItem
            // 
            configuracionesToolStripMenuItem.Name = "configuracionesToolStripMenuItem";
            configuracionesToolStripMenuItem.Size = new Size(180, 22);
            configuracionesToolStripMenuItem.Text = "Configuraciones";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(180, 22);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1023, 644);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Colmado  GBPColmadoNet";
            Load += MainForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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

        private Panel panelContent;
        private DateTimePicker dateTimePicker1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inventarioToolStripMenuItem;
        private ToolStripMenuItem eSToolStripMenuItem;
        private ToolStripMenuItem devolucionesToolStripMenuItem;
        private ToolStripMenuItem listarProductosToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabelMenuOp;
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
        private ToolStripLabel toolStripLabelInventario;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButtonDevoluciones;
        private ToolStripButton toolStripButtonListarProductos;
        private ToolStripLabel toolStripLabelVentas;
        private ToolStripButton toolStripButtonVentaR;
        private ToolStripButton toolStripButtonCuadre;
        private ToolStripLabel toolStripLabelCliente;
        private ToolStripButton toolStripButtonCliente;
        private ToolStripButton toolStripButtonCuentasPCobrar;
        private ToolStripLabel toolStripLabelHistorial;
        private ToolStripButton toolStripButtonHClientes;
        private ToolStripButton toolStripButtonHProveedor;
        private ToolStripButton toolStripButtonHVentas;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButtonConfiguracion;
        private ToolStripButton toolStripButton3;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem ventaRapidaToolStripMenuItem;
        private ToolStripMenuItem cuadreToolStripMenuItem;
        private ToolStripMenuItem clientresToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem historialToolStripMenuItem;
        private ToolStripMenuItem configuracionToolStripMenuItem;
        private ToolStripMenuItem cuentasPorCobrarToolStripMenuItem;
        private ToolStripMenuItem historialClienteToolStripMenuItem;
        private ToolStripMenuItem historialProveedorToolStripMenuItem;
        private ToolStripMenuItem historialVentasToolStripMenuItem;
        private ToolStripMenuItem configuracionesToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}
