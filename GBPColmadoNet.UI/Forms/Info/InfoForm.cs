using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GBPColmadoNet.UI.Services;

namespace GBPColmadoNet.UI.Forms.Ayuda
{
    public partial class InfoForm : Form
    {
        private readonly ConfiguracionService _configuracionService;

        public InfoForm(ConfiguracionService configuracionService)
        {
            _configuracionService = configuracionService;
            InitializeComponent();
            CargarDatos();
        }

        private async void CargarDatos()
        {
            var config = await _configuracionService.ObtenerConfiguracionAsync();
            lbNombreSistema.Text = config?.NombreComercial ?? "JB Solutions";
            lbCreador.Text = "Gustavo Junior Bonifacio Peña";
            lbProfesor.Text = "Enel Ramon Almonte Pichardo";
            lbVersion.Text = "v1.0.0";
        }
    }
}
