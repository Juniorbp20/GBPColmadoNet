using GBPColmadoNet.Data.Models;
using GBPColmadoNet.UI.Services;
using System.ComponentModel;

namespace GBPColmadoNet.UI.Forms.Ventas
{
    public partial class VentaRapidaForm : Form
    {
        private readonly ProductoService _productoService;
        private readonly VentasService _ventasService;
        private readonly ClienteService _clienteService;
        private BindingList<CarritoItem> _carrito;
        private List<Producto>? _productosDisponibles;

        public VentaRapidaForm(ProductoService productoService, VentasService ventasService, ClienteService clienteService)
        {
            InitializeComponent();
            _productoService = productoService;
            _ventasService = ventasService;
            _clienteService = clienteService;

            _carrito = new BindingList<CarritoItem>();
            dgvVenta.DataSource = _carrito;

            dgvVenta.CellValueChanged += DgvVenta_CellValueChanged;
            dgvVenta.DataBindingComplete += DgvVenta_DataBindingComplete;
        }

        private void DgvVenta_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn col in dgvVenta.Columns)
            {
                col.ReadOnly = col.Name != "Cantidad";
            }
        }

        private async void DgvVenta_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvVenta.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                var item = _carrito[e.RowIndex];
                
                var prod = await _productoService.Buscar(item.ProductoId);
                if (prod != null && prod.Stock < item.Cantidad)
                {
                    MessageBox.Show($"Stock insuficiente. Stock disponible: {prod.Stock}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    item.Cantidad = prod.Stock ?? 0;
                    _carrito.ResetBindings();
                }
                else if (item.Cantidad <= 0)
                {
                    item.Cantidad = 1;
                    _carrito.ResetBindings();
                }
                
                CalcularTotales();
            }
        }

        private async void VentaRapidaForm_Load(object sender, EventArgs e)
        {
            await CargarDatosIniciales();
        }

        private void BtnCancelarVenta_Click(object sender, EventArgs e)
        {
            LimpiarVenta();
        }

        private void TxtDescuento_TextChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void TxtDineroRecibido_TextChanged(object sender, EventArgs e)
        {
            CalcularCambio();
        }

        private async Task CargarDatosIniciales()
        {
            try
            {
                // Cargar Clientes
                var clientes = await _clienteService.GetList(c => true);
                var listaClientes = new List<Cliente> { new Cliente { ClienteId = 0, Nombre = "Consumidor Final" } };
                listaClientes.AddRange(clientes);

                cmbCliente.DataSource = listaClientes;
                cmbCliente.DisplayMember = "Nombre";
                cmbCliente.ValueMember = "ClienteId";
                cmbCliente.SelectedIndex = 0;
                
                // Configurar Tipo de Pago por defecto
                if (cmbTipoPago.Items.Count > 0)
                {
                    cmbTipoPago.SelectedIndex = 0;
                }

                // Cargar Productos
                _productosDisponibles = await _productoService.GetList(p => p.Activo == true);
                cmbProducto.DataSource = _productosDisponibles;
                cmbProducto.DisplayMember = "Nombre";
                cmbProducto.ValueMember = "ProductoId";
                cmbProducto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}");
            }
        }

        private void CmbCliente_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue is int cId && cId > 0)
            {
                lblTipoPago.Visible = true;
                cmbTipoPago.Visible = true;
            }
            else
            {
                lblTipoPago.Visible = false;
                cmbTipoPago.Visible = false;
                if (cmbTipoPago.Items.Count > 0)
                    cmbTipoPago.SelectedIndex = 0; // Por defecto Efectivo
            }
        }

        private void CmbTipoPago_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbTipoPago.SelectedItem != null && cmbTipoPago.SelectedItem.ToString() == "Crédito")
            {
                txtDineroRecibido.Text = "0.00";
                txtDineroRecibido.Enabled = false;
            }
            else
            {
                txtDineroRecibido.Enabled = true;
                txtDineroRecibido.Text = string.Empty;
            }
        }

        private void CmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarInfoProductoSeleccionado();
        }

        private void CmbProducto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_productosDisponibles == null)
                    return;

                string text = cmbProducto.Text.Trim();
                var prod = _productosDisponibles.FirstOrDefault(p => p.CodigoBarras == text || p.Nombre.Contains(text));

                if (prod != null)
                {
                    cmbProducto.SelectedValue = prod.ProductoId;
                    MostrarInfoProductoSeleccionado();
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void MostrarInfoProductoSeleccionado()
        {
            if (cmbProducto.SelectedItem is Producto prod)
            {
                lblStockDisp.Text = prod.Stock?.ToString("N2") ?? "0";
                lblPrecioU.Text = prod.PrecioVenta.ToString("C2");
            }
            else
            {
                lblStockDisp.Text = "-";
                lblPrecioU.Text = "-";
            }
        }

        private void BtnAgregarVenta_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem is not Producto prod)
            {
                MessageBox.Show("Seleccione un producto válido.");
                return;
            }

            decimal cantidadSolicitada = numCantidad.Value;
            var itemEnCarrito = _carrito.FirstOrDefault(c => c.ProductoId == prod.ProductoId);
            decimal cantActualEnCarrito = itemEnCarrito != null ? itemEnCarrito.Cantidad : 0;

            decimal stockDisp = prod.Stock ?? 0;

            if (stockDisp < (cantActualEnCarrito + cantidadSolicitada))
            {
                MessageBox.Show($"Stock insuficiente. Disp: {stockDisp}, En Carrito: {cantActualEnCarrito}");
                return;
            }

            if (itemEnCarrito != null)
            {
                itemEnCarrito.Cantidad += cantidadSolicitada;
                _carrito.ResetBindings();
            }
            else
            {
                _carrito.Add(new CarritoItem
                {
                    ProductoId = prod.ProductoId,
                    Codigo = prod.CodigoBarras ?? string.Empty,
                    Nombre = prod.Nombre,
                    Cantidad = cantidadSolicitada,
                    PrecioUnitario = prod.PrecioVenta,
                    TasaItbis = prod.TasaItbis ?? 0
                });
            }

            // Resetear inputs top
            cmbProducto.SelectedIndex = -1;
            cmbProducto.Text = "";
            numCantidad.Value = 1;
            lblStockDisp.Text = "-";
            lblPrecioU.Text = "-";
            cmbProducto.Focus();

            CalcularTotales();
        }

        private void BtnEliminarItem_Click(object sender, EventArgs e)
        {
            if (dgvVenta.CurrentRow?.DataBoundItem is CarritoItem item)
            {
                if (item.Cantidad > 1)
                {
                    using var prompt = new Form()
                    {
                        Width = 350,
                        Height = 150,
                        FormBorderStyle = FormBorderStyle.FixedDialog,
                        Text = "Eliminar Cantidad",
                        StartPosition = FormStartPosition.CenterParent,
                        MaximizeBox = false,
                        MinimizeBox = false
                    };
                    Label textLabel = new Label() { Left = 20, Top = 20, Width = 300, Text = $"¿Cuántas unidades de '{item.Nombre}' desea eliminar?" };
                    NumericUpDown inputBox = new NumericUpDown() { Left = 20, Top = 50, Width = 100, Minimum = 1, Maximum = item.Cantidad, Value = 1 };
                    Button confirmation = new Button() { Text = "Aceptar", Left = 140, Width = 80, Top = 48, DialogResult = DialogResult.OK };
                    Button cancel = new Button() { Text = "Cancelar", Left = 230, Width = 80, Top = 48, DialogResult = DialogResult.Cancel };
                    
                    prompt.Controls.Add(textLabel);
                    prompt.Controls.Add(inputBox);
                    prompt.Controls.Add(confirmation);
                    prompt.Controls.Add(cancel);
                    prompt.AcceptButton = confirmation;

                    if (prompt.ShowDialog() == DialogResult.OK)
                    {
                        if (inputBox.Value == item.Cantidad)
                        {
                            _carrito.Remove(item);
                        }
                        else
                        {
                            item.Cantidad -= inputBox.Value;
                            _carrito.ResetBindings();
                        }
                        CalcularTotales();
                    }
                }
                else
                {
                    var result = MessageBox.Show($"¿Estás seguro de que deseas eliminar el producto '{item.Nombre}' de la venta actual?", 
                                                 "Confirmar Eliminación", 
                                                 MessageBoxButtons.YesNo, 
                                                 MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        _carrito.Remove(item);
                        CalcularTotales();
                    }
                }
            }
        }

        private void CalcularTotales()
        {
            decimal subtotal = _carrito.Sum(c => c.Subtotal);
            decimal itbis = _carrito.Sum(c => c.Itbis);

            decimal descuento = 0;
            decimal.TryParse(txtDescuento.Text, out descuento);

            decimal totalVenta = subtotal + itbis;
            decimal totalPagar = totalVenta - descuento;

            if (totalPagar < 0) totalPagar = 0;

            lblSubtotal.Text = totalVenta.ToString("N2");
            lblItbisTotal.Text = itbis.ToString("N2");
            lblMontoDesc.Text = descuento.ToString("N2");
            lblTotalPagar.Text = totalPagar.ToString("N2");

            CalcularCambio(totalPagar);
        }

        private void CalcularCambio()
        {
            decimal.TryParse(lblTotalPagar.Text, out decimal totalPagar);
            CalcularCambio(totalPagar);
        }

        private void CalcularCambio(decimal totalPagar)
        {
            decimal.TryParse(txtDineroRecibido.Text, out decimal recibido);
            decimal cambio = recibido - totalPagar;

            if (cambio < 0 && recibido > 0)
            {
                // aqui se deside si el color es rojo o verde en base del monto

                lblCambio.ForeColor = Color.Red;
                lblCambio.Text = $"Faltan: RD$ {Math.Abs(cambio):N2}";
            }
            else
            {
                lblCambio.ForeColor = Color.DarkGreen;
                lblCambio.Text = $"RD$ {Math.Max(0, cambio):N2}";
            }
        }

        private void LimpiarVenta()
        {
            _carrito.Clear();
            txtDescuento.Text = "0";
            txtDineroRecibido.Clear();
            cmbCliente.SelectedIndex = 0;
            cmbProducto.SelectedIndex = -1;
            cmbProducto.Text = "";
            CalcularTotales();
        }

        private async void BtnConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (!_carrito.Any())
            {
                MessageBox.Show("La venta no tiene productos.");
                return;
            }

            decimal.TryParse(lblTotalPagar.Text, out decimal totalPagar);
            decimal.TryParse(txtDineroRecibido.Text, out decimal recibido);

            int? clienteId = null;
            if (cmbCliente.SelectedValue is int cId && cId > 0)
            {
                clienteId = cId;
            }

            string tipoPago = cmbTipoPago.Visible && cmbTipoPago.SelectedItem != null 
                ? cmbTipoPago.SelectedItem.ToString() ?? "Efectivo" 
                : "Efectivo";

            // Validar pago completo si es en efectivo
            if (tipoPago == "Efectivo" && recibido < totalPagar)
            {
                MessageBox.Show("Pago insuficiente. El dinero recibido no cubre el total de la venta en efectivo.");
                return;
            }

            decimal itbisTotal = _carrito.Sum(c => c.Itbis);
            decimal cambio = 0;
            string mensajeConfirmacion;

            if (tipoPago == "Crédito")
            {
                mensajeConfirmacion = $"Total a Pagar (Crédito): RD$ {totalPagar:N2}\n" +
                                      $"ITBIS Incluido: RD$ {itbisTotal:N2}\n\n" +
                                      "¿Confirmar y guardar la venta a crédito?";
            }
            else
            {
                cambio = recibido - totalPagar;
                mensajeConfirmacion = $"Total a Pagar: RD$ {totalPagar:N2}\n" +
                                      $"ITBIS Incluido: RD$ {itbisTotal:N2}\n" +
                                      $"Dinero Recibido: RD$ {recibido:N2}\n" +
                                      $"Cambio a Devolver: RD$ {(cambio > 0 ? cambio : 0):N2}\n\n" +
                                      "¿Confirmar y guardar la venta?";
            }

            var confirmacion = MessageBox.Show(mensajeConfirmacion, "Confirmar Venta Final", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            try
            {
                btnConfirmarVenta.Enabled = false;

                var venta = new Venta
                {
                    Fecha = DateTime.Now,
                    UsuarioId = SessionManager.CurrentUser?.UsuarioId,
                    TotalNeto = _carrito.Sum(c => c.Subtotal) - (decimal.TryParse(txtDescuento.Text, out decimal desc) ? desc : 0),
                    TotalItbis = _carrito.Sum(c => c.Itbis),
                    ClienteId = clienteId
                };

                foreach (var item in _carrito)
                {
                    venta.VentasDetalles.Add(new VentasDetalle
                    {
                        ProductoId = item.ProductoId,
                        Cantidad = item.Cantidad,
                        PrecioUnitario = item.PrecioUnitario
                    });

                    // Descontar inventario
                    var prodDb = await _productoService.Buscar(item.ProductoId);
                    if (prodDb != null)
                    {
                        prodDb.Stock -= item.Cantidad;
                        prodDb.Categoria = null;
                        prodDb.Proveedor = null;
                        
                        // Hacemos detach si ya está en local tracking para evitar choques
                        await _productoService.Modificar(prodDb);
                    }
                }

                // Generar Cuentas por Cobrar si fue fiado
                if (tipoPago == "Crédito" && clienteId != null)
                {
                    venta.CuentasPorCobrars.Add(new CuentasPorCobrar
                    {
                        ClienteId = clienteId.Value,
                        MontoDeuda = totalPagar - recibido,
                        BalancePendiente = totalPagar - recibido,
                        MontoAbonado = 0,
                        FechaRegistro = DateTime.Now,
                        Estado = "Pendiente"
                    });
                }

                bool exito = await _ventasService.Guardar(venta);

                if (exito)
                {
                    MessageBox.Show("Venta guardada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarVenta();
                    ImprimirFactura(venta.VentaId);
                }
                else
                {
                    MessageBox.Show("Error al guardar la venta.");
                }
            }
            catch (Exception ex)
            {
                var realMsg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show($"Error al procesar la venta: {realMsg}");
            }
            finally
            {
                btnConfirmarVenta.Enabled = true;
            }
        }
        private void ImprimirFactura(int ventaId)
        {
            // TODO: Aquí debes instanciar el formulario de tu factura (ej. FacturaForm) o el reporte
            // y pasarle el ID de la venta para que la imprima/muestre.
            // Ejemplo:
            // var facturaViewer = new FacturaReporteForm(ventaId);
            // facturaViewer.ShowDialog();

            MessageBox.Show($"Abriendo la factura para la venta #{ventaId}... (Conecta aquí tu diseño de factura)", "Imprimiendo Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

