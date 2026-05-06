using System;
using System.Windows.Forms;
using GBPColmadoNet.Data.Models;
using GBPColmadoNet.UI.Services;

namespace GBPColmadoNet.UI.Forms.Proveedor
{
    public partial class ProveedorForm : Form
    {
        private readonly ProveedorService _proveedorService;
        private Proveedore? _proveedorActual;

        public ProveedorForm(ProveedorService proveedorService, Proveedore? proveedor = null)
        {
            InitializeComponent();
            _proveedorService = proveedorService;
            _proveedorActual = proveedor;

            if (_proveedorActual != null)
            {
                lblTitulo.Text = "Editar Proveedor";
                CargarDatos();
            }
            else
            {
                lblTitulo.Text = "Nuevo Proveedor";
            }
        }

        private void CargarDatos()
        {
            if (_proveedorActual == null) return;

            txtNombre.Text = _proveedorActual.Nombre;
            txtRnc.Text = _proveedorActual.Rnc;
            txtTelefono.Text = _proveedorActual.Telefono;
        }

        private bool ValidateForm()
        {
            errorProviderProveedor.Clear();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProviderProveedor.SetError(txtNombre, "El nombre del proveedor es obligatorio.");
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

                if (_proveedorActual == null)
                {
                    var nuevoProveedor = new Proveedore
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Rnc = string.IsNullOrWhiteSpace(txtRnc.Text) ? null : txtRnc.Text.Trim(),
                        Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim(),
                        FechaRegistro = DateTime.Now,
                        FechaModificacion = DateTime.Now
                    };

                    bool exito = await _proveedorService.Guardar(nuevoProveedor);

                    if (exito)
                    {
                        MessageBox.Show("Proveedor creado correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al crear el proveedor.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    _proveedorActual.Nombre = txtNombre.Text.Trim();
                    _proveedorActual.Rnc = string.IsNullOrWhiteSpace(txtRnc.Text) ? null : txtRnc.Text.Trim();
                    _proveedorActual.Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim();
                    _proveedorActual.FechaModificacion = DateTime.Now;

                    bool exito = await _proveedorService.Guardar(_proveedorActual);

                    if (exito)
                    {
                        MessageBox.Show("Proveedor actualizado correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el proveedor.", "Error",
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