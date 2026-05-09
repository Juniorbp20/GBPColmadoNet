using GBPColmadoNet.Data.Models;
using GBPColmadoNet.UI.Services;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace GBPColmadoNet.UI.Forms.Configuracion
{
    public partial class ConfiguracionForm : Form
    {
        private readonly ConfiguracionService _configService;
        private ConfiguracionesNegocio? _configuracionActual;
        private string? _nuevaRutaLogo;
        private readonly string _logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SystemLogo.png");

        public ConfiguracionForm()
        {
            InitializeComponent();
            _configService = Program.ServiceProvider.GetRequiredService<ConfiguracionService>();
        }

        private async void ConfiguracionForm_Load(object sender, EventArgs e)
        {
            CargarImpresoras();

            // Cargar logo si existe
            if (File.Exists(_logoPath))
            {
                try
                {
                    using (var fs = new FileStream(_logoPath, FileMode.Open, FileAccess.Read))
                    {
                        picLogoPreview.Image = Image.FromStream(fs);
                    }
                }
                catch { /* Ignorar error de lectura de imagen */ }
            }

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

            var currentUser = SessionManager.CurrentUser;
            if (currentUser != null && currentUser.Rol == "Admin")
            {
                grpUsuarios.Visible = true;
            }
            else
            {
                grpUsuarios.Visible = false;
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

        private void btnSeleccionarLogo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Seleccionar Logo del Sistema";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _nuevaRutaLogo = ofd.FileName;
                    try
                    {
                        using (var fs = new FileStream(_nuevaRutaLogo, FileMode.Open, FileAccess.Read))
                        {
                            var tempImage = Image.FromStream(fs);
                            picLogoPreview.Image?.Dispose(); // Liberar la imagen anterior si existe
                            picLogoPreview.Image = tempImage;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
                // Guardar logo si se seleccionó uno nuevo
                if (!string.IsNullOrEmpty(_nuevaRutaLogo) && File.Exists(_nuevaRutaLogo))
                {
                    try
                    {
                        File.Copy(_nuevaRutaLogo, _logoPath, true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Configuración guardada, pero ocurrió un error al guardar el logo: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

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

        private void btnCrearUsuario_Click_1(object sender, EventArgs e)
        {
            var crearUsuarioForm = Program.ServiceProvider.GetRequiredService<CrearUsuarioForm>();
            crearUsuarioForm.UsuarioIdAEditar = null;
            crearUsuarioForm.ShowDialog();
        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            var listForm = Program.ServiceProvider.GetRequiredService<UsuarioListForm>();
            listForm.ShowDialog();
        }
    }
}
