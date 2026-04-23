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
    }
}
