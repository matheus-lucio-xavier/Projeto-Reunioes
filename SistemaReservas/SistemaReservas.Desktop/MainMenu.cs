using SistemaReservas.Desktop.Screens;

namespace SistemaReservas.Desktop
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            GerenciarSalas gerenciarSalas = new GerenciarSalas();
            gerenciarSalas.ShowDialog();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            GerenciarReservas gerenciarReservas = new GerenciarReservas();
            gerenciarReservas.ShowDialog();
        }
    }
}
