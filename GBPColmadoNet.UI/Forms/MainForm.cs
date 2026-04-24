using GBPColmadoNet.Data.Context;

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

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {

        }
    }
}
