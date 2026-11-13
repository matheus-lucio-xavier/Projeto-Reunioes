using SistemaReservas.Dto.Response;
using SistemaReservas.Models;
using SistemaReservas.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaReservas.Desktop.Screens
{
    public partial class GerenciarReservas : Form
    {
        private readonly ReservaService _service;
        private readonly SalaService _salaService;
        private int page = 1;
        public GerenciarReservas(ReservaService service, SalaService salaService)
        {
            InitializeComponent();
            _service = service;
            _salaService = salaService;
            CarregarDados();
            maskedTextBox1.Text = page.ToString();
        }
        private void CarregarDados()
        {
            var reservas = _service.Consultar(page);
            CarregarDadosTabela(reservas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var reservas = _service.Consultar(textBox1.Text, page);
            CarregarDadosTabela(reservas);
        }
        private void CarregarDadosTabela(List<ReservaModel> lista)
        {
            dataGridView1.Rows.Clear();

            var salas = _salaService.Consultar();

            foreach (var reserva in lista)
            {
                dataGridView1.Rows.Add(
                    reserva.Nome,
                    reserva.Inicio,
                    reserva.Fim,
                    salas.FirstOrDefault(s => s.Id == reserva.SalaId)?.Nome ?? "Sala não encontrada",
                    reserva.Status
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_salaService.Consultar().Count() > 0)
            {
                var cadastroReserva = new CadastroReserva(_service, _salaService);
                if (cadastroReserva.ShowDialog() == DialogResult.OK)
                {
                    CarregarDados();
                }
            }
            else
            {
                MessageBox.Show("Nenhuma sala cadastrada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MaskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite teclas especiais (Backspace, Delete, etc.)
            if (char.IsControl(e.KeyChar))
                return;

            // Permite apenas digitos
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the key
                MessageBox.Show("Apenas valores numericos são permitidos.", "Input Invalido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MaskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(maskedTextBox1.Text, out int newPage))
            {

                if (newPage < 1 || newPage > Math.Ceiling((double)_service.Consultar().Count() / 10))
                {
                    maskedTextBox1.Text = page.ToString();
                    return;
                }
                page = newPage;
                CarregarDados();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (page < Math.Ceiling((double)_service.Consultar().Count() / 10))
            {
                maskedTextBox1.Text = (page + 1).ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                maskedTextBox1.Text = (page - 1).ToString();
            }
        }
    }
}
