using GBPColmadoNet.Data.Models;
using GBPColmadoNet.UI.Services;

namespace GBPColmadoNet.UI.Forms.Clientes.CuentasPorCobrar
{
    public partial class CuentasPorCobrarForm : Form
    {
        private readonly CuentasPorCobrarService _service;
        private List<Cliente> _clientes;
        private Data.Models.CuentasPorCobrar? _cuentaActual;
        private bool _esModoEditar;
        private bool _cambiosRealizados = false;

        public CuentasPorCobrarForm(CuentasPorCobrarService service)
        {
            InitializeComponent();
            _service = service;
            _esModoEditar = false;
            lblTitulo.Text = "Nueva Cuenta por Cobrar";
            dtpFechaVencimiento.Value = DateTime.Now.AddDays(15);
        }

        public CuentasPorCobrarForm(CuentasPorCobrarService service, Data.Models.CuentasPorCobrar cuenta) : this(service)
        {
            _cuentaActual = cuenta;
            _esModoEditar = true;
            lblTitulo.Text = "Cuenta por Cobrar";
        }

        private async void CuentasPorCobrarForm_Load(object sender, EventArgs e)
        {
            if (_esModoEditar && _cuentaActual != null)
            {
                await CargarDatosCuenta();
            }
            else
            {
                await CargarClientes();
            }
        }

        private async Task CargarClientes()
        {
            try
            {
                _clientes = await _service.GetClientesAsync();

                cmbCliente.DisplayMember = "Nombre";
                cmbCliente.ValueMember = "ClienteId";
                cmbCliente.DataSource = _clientes;

                panelAbono.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarDatosCuenta()
        {
            try
            {
                _clientes = await _service.GetClientesAsync();

                cmbCliente.DisplayMember = "Nombre";
                cmbCliente.ValueMember = "ClienteId";
                cmbCliente.DataSource = _clientes;

                if (_cuentaActual != null)
                {
                    cmbCliente.SelectedValue = _cuentaActual.ClienteId;
                    numericMonto.Value = _cuentaActual.MontoDeuda;
                    numericDiasCredito.Value = _cuentaActual.DiasCredito ?? 15;
                    dtpFechaVencimiento.Value = _cuentaActual.FechaVencimiento ?? DateTime.Now;
                    txtEstado.Text = _cuentaActual.Estado ?? "Pendiente";

                    cmbCliente.Enabled = false;
                    numericMonto.Enabled = false;
                    numericDiasCredito.Enabled = false;
                    dtpFechaVencimiento.Enabled = false;

                    ActualizarBalance();
                    MostrarAbonos();

                    if (_cuentaActual.Estado == "Pagada")
                    {
                        panelAbono.Enabled = false;
                        btnGuardar.Enabled = false;
                    }
                    else
                    {
                        panelAbono.Enabled = true;
                    }
                }

                btnGuardar.Text = "Cerrar";
                btnGuardar.Click -= btnGuardar_Click;
                btnGuardar.Click += btnCerrar_Click;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarAbonos()
        {
            if (_cuentaActual?.Abonos == null)
            {
                dgvAbonos.DataSource = null;
                return;
            }

            var abonosMostrar = _cuentaActual.Abonos.Select(a => new
            {
                a.AbonoId,
                a.Fecha,
                a.Monto,
                Usuario = a.Usuario?.Username
            }).OrderByDescending(a => a.Fecha).ToList();

            dgvAbonos.DataSource = abonosMostrar;

            if (dgvAbonos.Columns["Fecha"] != null)
                dgvAbonos.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            if (dgvAbonos.Columns["Monto"] != null)
                dgvAbonos.Columns["Monto"].DefaultCellStyle.Format = "N2";
        }

        private void ActualizarBalance()
        {
            if (_cuentaActual == null) return;

            decimal balance = _cuentaActual.MontoDeuda - (_cuentaActual.MontoAbonado ?? 0);
            lblInfoBalance.Text = $"Deuda: RD$ {_cuentaActual.MontoDeuda:N2} | Abonado: RD$ {(_cuentaActual.MontoAbonado ?? 0):N2} | Balance: RD$ {balance:N2}";
        }

        private void numericDiasCredito_ValueChanged(object sender, EventArgs e)
        {
            if (!_esModoEditar)
            {
                dtpFechaVencimiento.Value = DateTime.Now.AddDays((int)numericDiasCredito.Value);
            }
        }

        private bool ValidateForm()
        {
            errorProviderCuenta.Clear();
            bool valid = true;

            if (cmbCliente.SelectedValue == null)
            {
                errorProviderCuenta.SetError(cmbCliente, "Debe seleccionar un cliente.");
                valid = false;
            }

            if (numericMonto.Value <= 0)
            {
                errorProviderCuenta.SetError(numericMonto, "El monto debe ser mayor a 0.");
                valid = false;
            }

            if (numericDiasCredito.Value <= 0)
            {
                errorProviderCuenta.SetError(numericDiasCredito, "Los días de crédito deben ser mayores a 0.");
                valid = false;
            }

            return valid;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                btnGuardar.Enabled = false;

                var nuevaCuenta = new Data.Models.CuentasPorCobrar
                {
                    ClienteId = (int)cmbCliente.SelectedValue!,
                    MontoDeuda = numericMonto.Value,
                    MontoAbonado = 0,
                    BalancePendiente = numericMonto.Value,
                    DiasCredito = (int)numericDiasCredito.Value,
                    FechaVencimiento = dtpFechaVencimiento.Value,
                    Estado = "Pendiente",
                    FechaRegistro = DateTime.Now,
                    FechaModificacion = DateTime.Now
                };

                bool exito = await _service.Guardar(nuevaCuenta);

                if (exito)
                {
                    MessageBox.Show("Cuenta creada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al crear la cuenta.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                var realMsg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show($"Error de Base de Datos: {realMsg}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        private async void btnRegistrarAbono_Click(object sender, EventArgs e)
        {
            if (_cuentaActual == null)
            {
                MessageBox.Show("Debe guardar la cuenta primero.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericAbono.Value == 0)
            {
                MessageBox.Show("El monto del abono debe ser diferente de 0.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal balanceReal = _cuentaActual.MontoDeuda - (_cuentaActual.MontoAbonado ?? 0);
            if (numericAbono.Value > balanceReal)
            {
                var resultado = MessageBox.Show(
                    $"El abono es mayor que el balance pendiente ({balanceReal:N2}). ¿Desea marcar la cuenta como pagada?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado != DialogResult.Yes)
                    return;
            }

            try
            {
                btnRegistrarAbono.Enabled = false;

                var usuarioId = SessionManager.CurrentUser?.UsuarioId ?? 0;
                bool exito = await _service.RegistrarAbonoAsync(_cuentaActual.Id, numericAbono.Value, usuarioId);

                if (exito)
                {
                    MessageBox.Show("Abono registrado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _cuentaActual = await _service.Buscar(_cuentaActual.Id);
                    ActualizarBalance();
                    MostrarAbonos();
                    _cambiosRealizados = true;

                    if (_cuentaActual?.Estado == "Pagada")
                    {
                        txtEstado.Text = "Pagada";
                        panelAbono.Enabled = false;
                        btnGuardar.Enabled = true;
                        btnGuardar.Text = "Cerrar";
                        btnGuardar.Click -= btnGuardar_Click;
                        btnGuardar.Click += btnCerrar_Click;
                    }

                    numericAbono.Value = 0;
                }
                else
                {
                    MessageBox.Show("Error al registrar el abono.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                var realMsg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show($"Error de Base de Datos: {realMsg}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRegistrarAbono.Enabled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_cambiosRealizados && this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
            base.OnFormClosing(e);
        }
    }
}