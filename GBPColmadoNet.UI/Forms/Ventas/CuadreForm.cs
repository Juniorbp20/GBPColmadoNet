using System;
using System.Linq;
using System.Windows.Forms;
using GBPColmadoNet.Data.Context;
using GBPColmadoNet.Data.Models;
using GBPColmadoNet.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GBPColmadoNet.UI.Forms.Ventas
{
    public partial class CuadreForm : Form
    {
        private readonly CierreCajaService _cierreCajaService;
        private readonly ColmadoContext _context;
        private CierresCaja? _cajaAbierta;

        public CuadreForm()
        {
            InitializeComponent();
            _cierreCajaService = Program.ServiceProvider.GetRequiredService<CierreCajaService>();
            _context = Program.ServiceProvider.GetRequiredService<ColmadoContext>();
        }

        private async void CuadreForm_Load(object sender, EventArgs e)
        {
            var currentUser = SessionManager.CurrentUser;
            if (currentUser == null)
            {
                MessageBox.Show("Sesión no válida.", "Error");
                this.Close();
                return;
            }

            _cajaAbierta = await _cierreCajaService.ObtenerCajaAbiertaAsync(currentUser.UsuarioId);
            
            if (_cajaAbierta == null)
            {
                MessageBox.Show("No hay una caja abierta para cuadrar.", "Información");
                this.Close();
                return;
            }

            // Calcular ventas en efectivo (sin CuentasPorCobrar vinculada)
            var ventasEfectivo = await _context.Ventas
                .Where(v => v.UsuarioId == currentUser.UsuarioId && v.Fecha >= _cajaAbierta.FechaApertura && !v.CuentasPorCobrars.Any())
                .SumAsync(v => v.TotalNeto + v.TotalItbis);

            // Calcular ventas a crédito (con CuentasPorCobrar)
            var ventasCredito = await _context.Ventas
                .Where(v => v.UsuarioId == currentUser.UsuarioId && v.Fecha >= _cajaAbierta.FechaApertura && v.CuentasPorCobrars.Any())
                .SumAsync(v => v.TotalNeto + v.TotalItbis);

            // Calcular abonos recibidos
            var abonos = await _context.Abonos
                .Where(a => a.UsuarioId == currentUser.UsuarioId && a.Fecha >= _cajaAbierta.FechaApertura)
                .SumAsync(a => a.Monto);

            lblMontoInicial.Text = _cajaAbierta.MontoInicial.ToString("N2");
            lblVentasEfectivo.Text = ventasEfectivo.ToString("N2");
            lblVentasCredito.Text = ventasCredito.ToString("N2");
            lblAbonosRecibidos.Text = abonos.ToString("N2");

            decimal esperado = _cajaAbierta.MontoInicial + ventasEfectivo + abonos;
            lblMontoEsperado.Text = esperado.ToString("N2");

            _cajaAbierta.VentasEfectivo = ventasEfectivo;
            _cajaAbierta.VentasCredito = ventasCredito;
            _cajaAbierta.AbonosRecibidos = abonos;
            _cajaAbierta.MontoFinalEsperado = esperado;
        }

        private void txtMontoReal_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMontoReal.Text, out decimal real) && _cajaAbierta != null)
            {
                decimal diferencia = real - _cajaAbierta.MontoFinalEsperado;
                
                // Mostrar siempre el valor absoluto (positivo) para omitir signos negativos
                lblDiferencia.Text = Math.Abs(diferencia).ToString("N2");
                
                if (diferencia < 0)
                    lblDiferencia.ForeColor = System.Drawing.Color.Red;
                else if (diferencia > 0)
                    lblDiferencia.ForeColor = System.Drawing.Color.Green;
                else
                    lblDiferencia.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                lblDiferencia.Text = "0.00";
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_cajaAbierta == null) return;

            if (!decimal.TryParse(txtMontoReal.Text, out decimal real) || real < 0)
            {
                MessageBox.Show("Ingrese un monto real válido.", "Error");
                return;
            }

            _cajaAbierta.MontoRealEntregado = real;
            btnGuardar.Enabled = false;

            bool exito = await _cierreCajaService.CerrarCajaAsync(_cajaAbierta);
            
            btnGuardar.Enabled = true;

            if (exito)
            {
                MessageBox.Show("Cuadre de caja guardado con éxito. Sesión terminada.", "Caja Cerrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
                
                // Si el cuadre se guardó con éxito, forzamos el cierre de la app ya que la caja se cerró
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Hubo un error al guardar el cuadre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
