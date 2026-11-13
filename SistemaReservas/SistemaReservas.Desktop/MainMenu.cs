using SistemaReservas.Desktop.Screens;
using SistemaReservas.Services;

namespace SistemaReservas.Desktop
{
    public partial class MainMenu : Form
    {
        private SalaService _salaService;
        private ReservaService _reservaService;
        public MainMenu()
        {
            InitializeComponent();
            _salaService = new SalaService();
            _reservaService = new ReservaService();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            GerenciarSalas gerenciarSalas = new GerenciarSalas(_salaService);
            gerenciarSalas.ShowDialog();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            GerenciarReservas gerenciarReservas = new GerenciarReservas(_reservaService, _salaService);
            gerenciarReservas.ShowDialog();
        }
    }
}
