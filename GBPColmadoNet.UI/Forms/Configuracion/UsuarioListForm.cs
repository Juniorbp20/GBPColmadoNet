using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GBPColmadoNet.UI.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GBPColmadoNet.UI.Forms.Configuracion
{
    public partial class UsuarioListForm : Form
    {
        private readonly UsuarioServices _usuarioServices;

        public UsuarioListForm(UsuarioServices usuarioServices)
        {
            InitializeComponent();
            _usuarioServices = usuarioServices;
        }

        private async void UsuarioListForm_Load(object sender, EventArgs e)
        {
            await CargarUsuarios();
        }

        private async Task CargarUsuarios()
        {
            try
            {
                var usuarios = await _usuarioServices.GetList(u => true);
                
                dgvUsuarios.DataSource = usuarios.Select(u => new
                {
                    u.UsuarioId,
                    u.Username,
                    u.Rol,
                    Estado = u.Activo == true ? "Activo" : "Inactivo",
                    u.FechaRegistro
                }).ToList();

                if (dgvUsuarios.Columns.Count > 0)
                {
                    dgvUsuarios.Columns["UsuarioId"].HeaderText = "ID";
                    dgvUsuarios.Columns["Username"].HeaderText = "Usuario";
                    dgvUsuarios.Columns["Rol"].HeaderText = "Rol";
                    dgvUsuarios.Columns["Estado"].HeaderText = "Estado";
                    dgvUsuarios.Columns["FechaRegistro"].HeaderText = "Fecha Registro";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await CargarUsuarios();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione un usuario para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int usuarioId = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["UsuarioId"].Value);

            var formCrear = Program.ServiceProvider.GetRequiredService<CrearUsuarioForm>();
            formCrear.UsuarioIdAEditar = usuarioId;

            if (formCrear.ShowDialog() == DialogResult.OK)
            {
                await CargarUsuarios();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione un usuario para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int usuarioId = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["UsuarioId"].Value);
            string username = dgvUsuarios.SelectedRows[0].Cells["Username"].Value.ToString();

            // No permitir eliminar al usuario actual
            var currentUser = SessionManager.CurrentUser;
            if (currentUser != null && currentUser.UsuarioId == usuarioId)
            {
                MessageBox.Show("No puede eliminar el usuario con el que tiene la sesión iniciada.", "Acción Denegada", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            var confirm = MessageBox.Show($"¿Está seguro que desea eliminar al usuario '{username}' de forma permanente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    bool exito = await _usuarioServices.Eliminar(usuarioId);
                    if (exito)
                    {
                        MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await CargarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el usuario. Es posible que tenga registros asociados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
