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

namespace SistemaReservas.Desktop.Screens
{
    public partial class GerenciarSalas : Form
    {
        private readonly SalaService _service;
        private int page = 1;
        public GerenciarSalas(SalaService service)
        {
            _service = service;
            InitializeComponent();
            CarregarDados();
            maskedTextBox1.Text = page.ToString();
        }

        private void CarregarDados()
        {
            var salas = _service.Consultar(page);
            CarregarDadosTabela(salas);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var resultado = _service.Consultar(textBox1.Text, page);
            CarregarDadosTabela(resultado);
        }
        private void CarregarDadosTabela(List<ResponseSalaDto> lista)
        {
            dataGridView1.Rows.Clear();
            foreach (var sala in lista)
            {
                dataGridView1.Rows.Add(
                    sala.Nome,
                    sala.Andar,
                    sala.qtdAssentos,
                    sala.HorasLivres,
                    sala.ReunioesAgendadas
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cadastroSala = new CadastroSala(_service);
            if (cadastroSala.ShowDialog() == DialogResult.OK)
            {
                CarregarDados();
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
