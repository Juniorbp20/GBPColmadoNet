using GBPColmadoNet.Data.Models;
using GBPColmadoNet.UI.Services;
using System;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace GBPColmadoNet.UI.Forms.Configuracion
{
    public partial class ConfiguracionForm : Form
    {
        private readonly ConfiguracionService _configService;
        private ConfiguracionesNegocio? _configuracionActual;

        public ConfiguracionForm()
        {
            InitializeComponent();
            _configService = Program.ServiceProvider.GetRequiredService<ConfiguracionService>();
        }

        private async void ConfiguracionForm_Load(object sender, EventArgs e)
        {
            CargarImpresoras();

            _configuracionActual = await _configService.ObtenerConfiguracionAsync();

            if (_configuracionActual != null)
            {
                txtNombreComercial.Text = _configuracionActual.NombreComercial;
                txtRnc.Text = _configuracionActual.Rnc;
                txtDireccion.Text = _configuracionActual.Direccion;
                txtCiudadProvincia.Text = _configuracionActual.CiudadProvincia;
                txtTelefono.Text = _configuracionActual.Telefono;
                txtCorreo.Text = _configuracionActual.Correo;
                txtDescripcion.Text = _configuracionActual.Descripcion;
                txtMensajeTicket.Text = _configuracionActual.MensajeTicket;
                numMargenGanancia.Value = _configuracionActual.MargenGananciaDefecto;

                if (!string.IsNullOrEmpty(_configuracionActual.ImpresoraPredeterminada) && 
                    cmbImpresora.Items.Contains(_configuracionActual.ImpresoraPredeterminada))
                {
                    cmbImpresora.SelectedItem = _configuracionActual.ImpresoraPredeterminada;
                }
            }
        }

        private void CargarImpresoras()
        {
            cmbImpresora.Items.Clear();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                cmbImpresora.Items.Add(printer);
            }

            if (cmbImpresora.Items.Count > 0)
            {
                cmbImpresora.SelectedIndex = 0;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreComercial.Text))
            {
                MessageBox.Show("El Nombre Comercial es requerido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_configuracionActual == null)
            {
                _configuracionActual = new ConfiguracionesNegocio { Id = 1 };
            }

            _configuracionActual.NombreComercial = txtNombreComercial.Text;
            _configuracionActual.Rnc = txtRnc.Text;
            _configuracionActual.Direccion = txtDireccion.Text;
            _configuracionActual.CiudadProvincia = txtCiudadProvincia.Text;
            _configuracionActual.Telefono = txtTelefono.Text;
            _configuracionActual.Correo = txtCorreo.Text;
            _configuracionActual.Descripcion = txtDescripcion.Text;
            _configuracionActual.MensajeTicket = txtMensajeTicket.Text;
            _configuracionActual.MargenGananciaDefecto = numMargenGanancia.Value;
            
            if (cmbImpresora.SelectedItem != null)
            {
                _configuracionActual.ImpresoraPredeterminada = cmbImpresora.SelectedItem.ToString();
            }

            btnGuardar.Enabled = false;

            bool guardado = await _configService.GuardarConfiguracionAsync(_configuracionActual);

            btnGuardar.Enabled = true;

            if (guardado)
            {
                MessageBox.Show("Configuración guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al intentar guardar la configuración.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
