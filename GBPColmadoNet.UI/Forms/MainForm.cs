using GBPColmadoNet.Data.Context;
using GBPColmadoNet.UI.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace GBPColmadoNet
{
    public partial class MainForm : Form
    {
        private readonly ColmadoContext _context;

        public MainForm(ColmadoContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var hayConexion = _context.Database.CanConnect();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCatInicio_Click(object sender, EventArgs e)
        {
            var InicioForm = Program.ServiceProvider.GetRequiredService<MainForm>();
        }

        private void btnEntradaSalida_Click(object sender, EventArgs e)
        {
            var ES = Program.ServiceProvider.GetRequiredService<ESForm>();
        }
    }
}
