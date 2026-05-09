using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GBPColmadoNet.Data.Models;
using GBPColmadoNet.UI.Services;
using BCrypt.Net;

namespace GBPColmadoNet.UI.Forms.Configuracion
{
    public partial class CrearUsuarioForm : Form
    {
        private readonly UsuarioServices _usuarioServices;
        private readonly RoleService _roleService;
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int? UsuarioIdAEditar { get; set; }
        private Usuario? _usuarioEditando;

        public CrearUsuarioForm(UsuarioServices usuarioServices, RoleService roleService)
        {
            InitializeComponent();
            _usuarioServices = usuarioServices;
            _roleService = roleService;
            this.Load += CrearUsuarioForm_Load;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario()) return;

            btnGuardar.Enabled = false;
            try
            {
                using var scope = Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.CreateScope(Program.ServiceProvider);
                var usuarioServices = Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<UsuarioServices>(scope.ServiceProvider);

                bool exito = false;

                if (UsuarioIdAEditar.HasValue && _usuarioEditando != null)
                {
                    // Validación de nombre de usuario en edición
                    if (_usuarioEditando.Username.ToLower() != txtUsername.Text.Trim().ToLower())
                    {
                        var usuariosExistentes = await usuarioServices.GetList(u => u.Username.ToLower() == txtUsername.Text.Trim().ToLower());
                        if (usuariosExistentes.Any())
                        {
                            errorProvider.SetError(txtUsername, "Este nombre de usuario ya existe.");
                            btnGuardar.Enabled = true;
                            return;
                        }
                    }

                    _usuarioEditando.Username = txtUsername.Text.Trim();
                    _usuarioEditando.Rol = cmbRol.Text;
                    
                    if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                    {
                        _usuarioEditando.PasswordHash = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);
                    }

                    exito = await usuarioServices.Guardar(_usuarioEditando);
                }
                else
                {
                    // Inserción
                    var usuariosExistentes = await usuarioServices.GetList(u => u.Username.ToLower() == txtUsername.Text.Trim().ToLower());
                    if (usuariosExistentes.Any())
                    {
                        errorProvider.SetError(txtUsername, "Este nombre de usuario ya existe.");
                        btnGuardar.Enabled = true;
                        return;
                    }

                    string hash = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);

                    var nuevoUsuario = new Usuario
                    {
                        Username = txtUsername.Text.Trim(),
                        PasswordHash = hash,
                        Rol = cmbRol.Text,
                        Activo = true,
                        FechaRegistro = DateTime.Now
                    };

                    exito = await usuarioServices.Guardar(nuevoUsuario);
                }

                if (exito)
                {
                    MessageBox.Show(UsuarioIdAEditar.HasValue ? "Usuario actualizado exitosamente." : "Usuario creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hubo un problema al guardar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        private bool ValidarFormulario()
        {
            errorProvider.Clear();
            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, "El nombre de usuario es obligatorio.");
                valido = false;
            }

            if (!UsuarioIdAEditar.HasValue && string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "La contraseña es obligatoria para nuevos usuarios.");
                valido = false;
            }

            if (!string.IsNullOrWhiteSpace(txtPassword.Text) && txtPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider.SetError(txtConfirmPassword, "Las contraseñas no coinciden.");
                valido = false;
            }

            if (cmbRol.SelectedIndex == -1 && string.IsNullOrWhiteSpace(cmbRol.Text))
            {
                errorProvider.SetError(cmbRol, "Debe seleccionar un rol.");
                valido = false;
            }

            return valido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void CrearUsuarioForm_Load(object? sender, EventArgs e)
        {
            try
            {
                using var scope = Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.CreateScope(Program.ServiceProvider);
                var roleService = Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<RoleService>(scope.ServiceProvider);
                var roles = await roleService.GetList(r => true);

                if (roles != null && roles.Any())
                {
                    cmbRol.DataSource = roles;
                    cmbRol.DisplayMember = "Nombre";
                    cmbRol.ValueMember = "Nombre";
                    cmbRol.SelectedIndex = -1; // Deseleccionar por defecto
                }
                else
                {
                    // Fallback si no hay roles en BD
                    cmbRol.Items.Clear();
                    cmbRol.Items.AddRange(new string[] { "Admin", "Cajero" });
                }

                if (UsuarioIdAEditar.HasValue)
                {
                    this.Text = "Modificar Usuario";
                    btnGuardar.Text = "Actualizar";
                    
                    using var innerScope = Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.CreateScope(Program.ServiceProvider);
                    var userSrv = Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<UsuarioServices>(innerScope.ServiceProvider);
                    
                    _usuarioEditando = await userSrv.Buscar(UsuarioIdAEditar.Value);
                    if (_usuarioEditando != null)
                    {
                        txtUsername.Text = _usuarioEditando.Username;
                        cmbRol.Text = _usuarioEditando.Rol;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar formulario: {ex.Message}");
            }
        }
    }
}
