using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GBPColmadoNet.UI.Services;

namespace GBPColmadoNet.UI.Forms.LoginForm
{
    public partial class LoginForm : Form
    {
        private readonly UsuarioServices _usuarioServices;
        private readonly ConfiguracionService _configuracionService;
        private int _intentosFallidos = 0;
        private int _tiempoRestante = 60;

        public LoginForm(UsuarioServices usuarioServices, ConfiguracionService configuracionService)
        {
            InitializeComponent();
            _usuarioServices = usuarioServices;
            _configuracionService = configuracionService;
            
            string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SystemLogo.png");
            if (File.Exists(logoPath))
            {
                try
                {
                    using (var fs = new FileStream(logoPath, FileMode.Open, FileAccess.Read))
                    {
                        picLogo.Image = Image.FromStream(fs);
                    }
                }
                catch { /* Ignorar si no se puede cargar */ }
            }
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var config = await _configuracionService.ObtenerConfiguracionAsync();
            if (config != null && !string.IsNullOrWhiteSpace(config.NombreComercial))
            {
                lblTitulo.Text = config.NombreComercial;
                this.Text = $"Bienvenido a {config.NombreComercial}";
            }
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text.Trim();
            string password = txtContrasena.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMensaje.Text = "Por favor ingrese usuario y contraseña.";
                return;
            }

            btnIngresar.Enabled = false;
            var usuario = await _usuarioServices.AutenticarAsync(username, password);
            btnIngresar.Enabled = true;

            if (usuario != null)
            {
                SessionManager.Login(usuario);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                _intentosFallidos++;
                lblMensaje.Text = $"Credenciales incorrectas. Intento {_intentosFallidos} de 3.";

                if (_intentosFallidos >= 3)
                {
                    BloquearLogin();
                }
            }
        }

        private void BloquearLogin()
        {
            btnIngresar.Enabled = false;
            txtUsuario.Enabled = false;
            txtContrasena.Enabled = false;
            _tiempoRestante = 60;
            timerBloqueo.Start();
            ActualizarMensajeBloqueo();
        }

        private void timerBloqueo_Tick(object sender, EventArgs e)
        {
            _tiempoRestante--;
            
            if (_tiempoRestante <= 0)
            {
                timerBloqueo.Stop();
                _intentosFallidos = 0;
                btnIngresar.Enabled = true;
                txtUsuario.Enabled = true;
                txtContrasena.Enabled = true;
                lblMensaje.Text = "";
            }
            else
            {
                ActualizarMensajeBloqueo();
            }
        }

        private void ActualizarMensajeBloqueo()
        {
            lblMensaje.Text = $"Demasiados intentos. Espere {_tiempoRestante} segundos.";
        }
    }
}
