using System;
using System.Windows.Forms;
using GBPColmadoNet.Data.Models;
using GBPColmadoNet.UI.Services;

namespace GBPColmadoNet.UI.Forms.Ventas
{
    public partial class AperturaCajaForm : Form
    {
        private readonly CierreCajaService _cierreCajaService;

        public AperturaCajaForm(CierreCajaService cierreCajaService)
        {
            InitializeComponent();
            _cierreCajaService = cierreCajaService;
        }

        private async void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMontoInicial.Text, out decimal montoInicial) && montoInicial >= 0)
            {
                var nuevaCaja = new CierresCaja
                {
                    UsuarioId = SessionManager.CurrentUser!.UsuarioId,
                    FechaApertura = DateTime.Now,
                    MontoInicial = montoInicial,
                    Estado = "Abierta"
                };

                btnAbrirCaja.Enabled = false;
                bool exito = await _cierreCajaService.Guardar(nuevaCaja);
                btnAbrirCaja.Enabled = true;

                if (exito)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al abrir la caja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto inicial válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
