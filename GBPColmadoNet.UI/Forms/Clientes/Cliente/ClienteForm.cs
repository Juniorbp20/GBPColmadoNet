using System;
using System.Windows.Forms;
using GBPColmadoNet.Data.Models;
using GBPColmadoNet.UI.Services;

namespace GBPColmadoNet.UI.Forms.Clientes
{
    public partial class ClienteForm : Form
    {
        private readonly ClienteService _clienteService;
        private Cliente? _clienteActual;

        public ClienteForm(ClienteService clienteService, Cliente? cliente = null)
        {
            InitializeComponent();
            _clienteService = clienteService;
            _clienteActual = cliente;

            if (_clienteActual != null)
            {
                lblTitulo.Text = "Editar Cliente";
                CargarDatos();
            }
            else
            {
                lblTitulo.Text = "Nuevo Cliente";
            }
        }

        private void CargarDatos()
        {
            if (_clienteActual == null) return;

            txtNombre.Text = _clienteActual.Nombre;
            txtTelefono.Text = _clienteActual.Telefono;
            chkActivo.Checked = _clienteActual.Activo ?? true;
        }

        private bool ValidateForm()
        {
            errorProviderCliente.Clear();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProviderCliente.SetError(txtNombre, "El nombre del cliente es obligatorio.");
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

                if (_clienteActual == null)
                {
                    var nuevoCliente = new Cliente
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim(),
                        Activo = chkActivo.Checked,
                        FechaRegistro = DateTime.Now,
                        FechaModificacion = DateTime.Now
                    };

                    bool exito = await _clienteService.Guardar(nuevoCliente);

                    if (exito)
                    {
                        MessageBox.Show("Cliente creado correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al crear el cliente.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    _clienteActual.Nombre = txtNombre.Text.Trim();
                    _clienteActual.Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim();
                    _clienteActual.Activo = chkActivo.Checked;
                    _clienteActual.FechaModificacion = DateTime.Now;

                    bool exito = await _clienteService.Guardar(_clienteActual);

                    if (exito)
                    {
                        MessageBox.Show("Cliente actualizado correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el cliente.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}