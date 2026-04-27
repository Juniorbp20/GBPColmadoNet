using GBPColmadoNet.Data.Context;

namespace GBPColmadoNet.UI.Forms
{
    public partial class EForm : Form
    {
        private readonly ColmadoContext _context;

        public EForm(ColmadoContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                btnGuardar.Enabled = false;
                var producto = new Data.Models.Producto()
                {
                    CodigoBarras = txCodigoBarras.Text.Trim(),
                    Nombre = txNombreProducto.Text.Trim(),
                    PrecioCompra = numericUpDownPrecioCompra.Value,
                    PrecioVenta = numericUpDownPrecioVenta.Value,
                    FechaModificacion = DateTime.Now

                };

                _context.Productos.Add(producto);
                await _context.SaveChangesAsync();


                MessageBox.Show("Producto creado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        private bool ValidateForm()
        {
            errorProviderES.Clear();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txCodigoBarras.Text))
            {
                errorProviderES.SetError(txCodigoBarras, "El codigo de barras es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(txNombreProducto.Text))
            {
                errorProviderES.SetError(txNombreProducto, "El nombre del producto es obligatirio.");
            }

            if (numericUpDownPrecioCompra.Value <= 0)
            {
                errorProviderES.SetError(numericUpDownPrecioCompra,"El precio de compra es obligatirio u mayor a 0.");
                valid = false;
            }

            if (numericUpDownPrecioVenta.Value <= 0)
            {
                errorProviderES.SetError(numericUpDownPrecioVenta, "El  precio de venta es obligatorio y mayor a 0.");
                valid = false;
            }

            return valid;
        }
    }
}
